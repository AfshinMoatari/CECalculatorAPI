using CEProjectServer.Data;
using CEProjectServer.Model.enums;
using Microsoft.EntityFrameworkCore;
using static CEProjectServer.Model.enums.AbbreviateTypeEnum;
using static CEProjectServer.Model.enums.InterventionResultsEnum;
using static CEProjectServer.Model.enums.LanguagesEnum;
using static CEProjectServer.Model.enums.MeasurementTypeEnum;
using static CEProjectServer.Model.enums.PDFReportCellEnum;
using static CEProjectServer.Model.enums.SectorTypeEnum;
using static CEProjectServer.Model.enums.StakeholderTypeEnum;
using static CEProjectServer.ReportData;
using static CEProjectServer.ReportData.Sector;
using static CEProjectServer.ReportPDFData;

namespace CEProjectServer.Services
{
    public interface IInterventionCalculatorService
    {
        Task<ReportData> GetReportDataAsync(InterventionRequestModel interventionRequestModel, Languages lang);
        Task<ReportPDFData> GetPDFReportDataAsync(InterventionRequestModel interventionRequestModel, ReportData reportData, Languages lang);
    }

    public class InterventionCalculatorService : IInterventionCalculatorService
    {
        private readonly CEContext _context;

        public InterventionCalculatorService(CEContext context)
        {
            _context = context;
        }

        public async Task<ReportPDFData> GetPDFReportDataAsync(InterventionRequestModel interventionRequestModel, ReportData reportData, Languages lang)
        {
            var rows = new Dictionary<string, List<Cell>>();
            var projectName = interventionRequestModel.ProjectName;
            var inputCells = new List<Cell>();
            inputCells.AddRange(new List<Cell>(){
                new Cell(PDFReportCells.Type.GetLanguageSpecificDescription(lang),
                interventionRequestModel.InterventionType.GetLanguageSpecificDescription(lang)),
                new Cell(PDFReportCells.Participant.GetLanguageSpecificDescription(lang), $"{AbbreviateNumber(AbbreviateType.Population,2, interventionRequestModel.TotalParticipant, lang)} ({interventionRequestModel.PopulationType.GetLanguageSpecificDescription(lang)})"),
                new Cell(PDFReportCells.Cost.GetLanguageSpecificDescription(lang), AbbreviateNumber(AbbreviateType.Currency,2, interventionRequestModel.InterventionCosts, lang)),
                new Cell(PDFReportCells.EffectSize.GetLanguageSpecificDescription(lang), ((int)interventionRequestModel.InterventionType == 6 || interventionRequestModel.EffectScale != decimal.Zero) ? interventionRequestModel.EffectScale.ToString() + " (UCLA-3)" : RoundDouble(await _context.InterventionEffects
                    .Where(x => x.Id == (int)interventionRequestModel.InterventionType)
                    .Select(y => y.EffectValue)
                    .FirstOrDefaultAsync()) + " (UCLA-20)")
            });
            var financialGainsTotal = 0m;
            var valueDriversCells = new List<Cell>();
            foreach (var sectors in reportData.SectorBenefits)
            {
                string cellName = "";
                var sumTotalGains = 0m;
                foreach (var stakeholders in sectors.Value.Stakeholders)
                {
                    sumTotalGains += stakeholders.Value.TotalGains;
                    if (sectors.Key != SectorType.Wellbeing.GetLanguageSpecificDescription(lang))
                    {
                        financialGainsTotal += stakeholders.Value.TotalGains;
                    }
                }

                if (sectors.Key.Equals(SectorType.Healthcare.GetLanguageSpecificDescription(lang)))
                {
                    cellName = PDFReportCells.Healthcare.GetLanguageSpecificDescription(lang);
                }
                else if (sectors.Key.Equals(SectorType.SickDays.GetLanguageSpecificDescription(lang)))
                {
                    cellName = PDFReportCells.SickDays.GetLanguageSpecificDescription(lang);
                }
                else if (sectors.Key.Equals(SectorType.Unemployment.GetLanguageSpecificDescription(lang)))
                {
                    cellName = PDFReportCells.Unemployment.GetLanguageSpecificDescription(lang);
                }
                else if (sectors.Key.Equals(SectorType.Wellbeing.GetLanguageSpecificDescription(lang)))
                {
                    cellName = PDFReportCells.Wellbeing.GetLanguageSpecificDescription(lang);
                }

                valueDriversCells.Add(new Cell(cellName, AbbreviateNumber(AbbreviateType.Currency,1, sumTotalGains, lang)));
            }

            var beneficiariesCells = new List<Cell>();
            var stateSumTotalGains = 0m;
            var regionSumTotalGains = 0m;
            var municipalitySumTotalGains = 0m;
            var productionSumTotalGains = 0m;
            var individualsSumTotalGains = 0m;

            foreach (var sectors in reportData.SectorBenefits)
            {
                foreach (var stakeholders in sectors.Value.Stakeholders)
                {
                    if (stakeholders.Key.Equals(StakeholderType.OtherState.GetLanguageSpecificDescription(lang)))
                    {
                        stateSumTotalGains += stakeholders.Value.TotalGains;
                    }
                    else if (stakeholders.Key.Equals(StakeholderType.Municipality.GetLanguageSpecificDescription(lang)))
                    {
                        municipalitySumTotalGains += stakeholders.Value.TotalGains;
                    }
                    else if (stakeholders.Key.Equals(StakeholderType.Region.GetLanguageSpecificDescription(lang)))
                    {
                        regionSumTotalGains += stakeholders.Value.TotalGains;
                    }
                    else if (stakeholders.Key.Equals(StakeholderType.Production.GetLanguageSpecificDescription(lang)))
                    {
                        productionSumTotalGains += stakeholders.Value.TotalGains;
                    }
                    else if (stakeholders.Key.Equals(StakeholderType.MonetaryQualityOfLife.GetLanguageSpecificDescription(lang)))
                    {
                        individualsSumTotalGains += stakeholders.Value.TotalGains;
                    }
                }
            }
            beneficiariesCells.AddRange(new List<Cell>(){
                new Cell(PDFReportCells.State.GetLanguageSpecificDescription(lang), AbbreviateNumber(AbbreviateType.Currency,1, stateSumTotalGains, lang)),
                new Cell(PDFReportCells.Region.GetLanguageSpecificDescription(lang), AbbreviateNumber(AbbreviateType.Currency,1, regionSumTotalGains, lang)),
                new Cell(PDFReportCells.Municipality.GetLanguageSpecificDescription(lang), AbbreviateNumber(AbbreviateType.Currency, 1, municipalitySumTotalGains, lang)),
                new Cell(PDFReportCells.Production.GetLanguageSpecificDescription(lang), AbbreviateNumber(AbbreviateType.Currency, 1, productionSumTotalGains, lang)),
                new Cell(PDFReportCells.Individuals.GetLanguageSpecificDescription(lang), AbbreviateNumber(AbbreviateType.Currency, 1, individualsSumTotalGains, lang))});

            var valueDistributionCells = new List<Cell>();
            var budgetaryValue = 0m;
            var socialvalue = 0m;
            var netBenefit = reportData.NetBenefits.Where(x => x.Key.Equals(InterventionResults.Net.GetLanguageSpecificDescription(lang))).FirstOrDefault().Value.Total;
            var grossBenefit = reportData.NetBenefits.Where(x => x.Key.Equals(InterventionResults.Total.GetLanguageSpecificDescription(lang))).FirstOrDefault().Value.Total;
            var distributionChartFigures = new Dictionary<string, object>();
            var sum = reportData.NetBenefits.Where(x => x.Key.Equals(InterventionResults.Total.GetLanguageSpecificDescription(lang))).FirstOrDefault().Value.Total;
            distributionChartFigures.Add(PDFReportCells.State.GetLanguageSpecificDescription(lang), Math.Round(((stateSumTotalGains / sum) * 100), 1));
            distributionChartFigures.Add(PDFReportCells.Region.GetLanguageSpecificDescription(lang), Math.Round(((regionSumTotalGains / sum) * 100), 1));
            distributionChartFigures.Add(PDFReportCells.Municipality.GetLanguageSpecificDescription(lang), Math.Round(((municipalitySumTotalGains / sum) * 100), 1));
            distributionChartFigures.Add(PDFReportCells.Production.GetLanguageSpecificDescription(lang), Math.Round(((productionSumTotalGains / sum) * 100), 1));

            var distributionChart = new ProgressChart(distributionChartFigures.OrderBy(d => d.Value).ToDictionary(x => x.Key, x => x.Value));

            valueDistributionCells.Add(new Cell(PDFReportCells.Distribution.GetLanguageSpecificDescription(lang), distributionChart));
            valueDistributionCells.Add(new Cell(PDFReportCells.NetBenefit.GetLanguageSpecificDescription(lang), AbbreviateNumber(AbbreviateType.Currency, 1, netBenefit, lang)));
            valueDistributionCells.Add(new Cell(PDFReportCells.GrossBenefit.GetLanguageSpecificDescription(lang), AbbreviateNumber(AbbreviateType.Currency, 1,grossBenefit, lang)));

            var wellbyCells = new List<Cell>
            {
                new Cell(PDFReportCells.WellbyPoint.GetLanguageSpecificDescription(lang), reportData.Wellbys.WellbyPoint),
                new Cell(PDFReportCells.WellbySocialValuePerParticipant.GetLanguageSpecificDescription(lang), AbbreviateNumber(AbbreviateType.Currency, 1,reportData.Wellbys.WellbySocialValuePerParticipant, lang)),
                new Cell(PDFReportCells.WellbySocialValueTotal.GetLanguageSpecificDescription(lang), AbbreviateNumber(AbbreviateType.Currency, 1, reportData.Wellbys.WellbySocialValueTotal, lang))
            };
            var othersCell = new List<Cell>
            {
                new Cell(PDFReportCells.FinancialGainsTotal.GetLanguageSpecificDescription(lang), AbbreviateNumber(AbbreviateType.Currency, 1, financialGainsTotal, lang))
            };

            rows.Add("INPUT", inputCells);
            rows.Add("VALUE DRIVERS", valueDriversCells);
            rows.Add("BENEFICIARIES", beneficiariesCells);
            rows.Add("VALUE DISTRIBUTION", valueDistributionCells);
            rows.Add("WELLBY", wellbyCells);
            rows.Add("OTHERS", othersCell);

            var reportAppendix = new ReportAppendixData(
                projectName,
                ((int)interventionRequestModel.InterventionType == 6 || interventionRequestModel.EffectScale != 0) ? interventionRequestModel.EffectScale.ToString() + " (UCLA-3)" : RoundDouble(await _context.InterventionEffects
                    .Where(x => x.Id == (int)interventionRequestModel.InterventionType)
                    .Select(y => y.EffectValue)
                    .FirstOrDefaultAsync()) + " (UCLA-20)",
                valueDriversCells.Where(x => x.Name.Equals(PDFReportCells.Healthcare.GetLanguageSpecificDescription(lang))).Select(x => x.Figure).FirstOrDefault(),
                valueDriversCells.Where(x => x.Name.Equals(PDFReportCells.SickDays.GetLanguageSpecificDescription(lang))).Select(x => x.Figure).FirstOrDefault(),
                valueDriversCells.Where(x => x.Name.Equals(PDFReportCells.Unemployment.GetLanguageSpecificDescription(lang))).Select(x => x.Figure).FirstOrDefault(),
                beneficiariesCells.Where(x => x.Name.Equals(PDFReportCells.Municipality.GetLanguageSpecificDescription(lang))).Select(x => x.Figure).FirstOrDefault(),
                beneficiariesCells.Where(x => x.Name.Equals(PDFReportCells.Region.GetLanguageSpecificDescription(lang))).Select(x => x.Figure).FirstOrDefault(),
                beneficiariesCells.Where(x => x.Name.Equals(PDFReportCells.State.GetLanguageSpecificDescription(lang))).Select(x => x.Figure).FirstOrDefault(),
                beneficiariesCells.Where(x => x.Name.Equals(PDFReportCells.Production.GetLanguageSpecificDescription(lang))).Select(x => x.Figure).FirstOrDefault(),
                valueDriversCells.Where(x => x.Name.Equals(PDFReportCells.Wellbeing.GetLanguageSpecificDescription(lang))).Select(x => x.Figure).FirstOrDefault(),
                wellbyCells.Where(x => x.Name.Equals(PDFReportCells.WellbyPoint.GetLanguageSpecificDescription(lang))).Select(x => x.Figure).FirstOrDefault(),
                beneficiariesCells.Where(x => x.Name.Equals(PDFReportCells.Individuals.GetLanguageSpecificDescription(lang))).Select(x => x.Figure).FirstOrDefault()
            );

            return new ReportPDFData(rows, projectName, reportAppendix);
        }
        public async Task<ReportData> GetReportDataAsync(InterventionRequestModel interventionRequestModel, Languages lang)
        {
            var interventionEffectValue = await GetInterventionEffectValue((int)interventionRequestModel.InterventionType, interventionRequestModel.EffectScale);

            var totalSectorCostValues = await _context.TotalSectorCosts
                .Where(x => x.PopulationModelId == ((int)interventionRequestModel.PopulationType))
                .Where(y => y.MeasurementModelId == ((int)MeasurementType.UCLA))
                .ToListAsync();

            var sectorBenefits = GetSectorBenefits(interventionEffectValue, interventionRequestModel.TotalParticipant, totalSectorCostValues, lang);
            var netBenefits = GetNetBenefits(sectorBenefits, interventionRequestModel.TotalParticipant, interventionRequestModel.InterventionCosts, lang);

            var effectScale = ((int)interventionRequestModel.InterventionType == 6 || interventionRequestModel.EffectScale != decimal.Zero) ? interventionRequestModel.EffectScale : interventionEffectValue;
            var UCLAType = ((int)interventionRequestModel.InterventionType == 6 || interventionRequestModel.EffectScale != decimal.Zero) ? "UCLA-3" : "UCLA-20";
            var wellbyData = GetWellbyData((int)interventionRequestModel.InterventionType, interventionRequestModel.TotalParticipant, effectScale, UCLAType);

            var interventionResponseModel = new ReportData(sectorBenefits, netBenefits, wellbyData);
            return interventionResponseModel;
        }
        public async Task<decimal> GetInterventionEffectValue(int interventionType, decimal effectScale)
        {
            var result = 0m;
            if (interventionType.Equals(6) || effectScale != 0)
            {
                var deadweightFactor = await _context.EconomicFactors
                   .Where(x => x.Id == 1)
                   .Select(y => y.FactorValue)
                   .FirstOrDefaultAsync();
                var conversionFactor = await _context.EconomicFactors
                   .Where(x => x.Id == 2)
                   .Select(y => y.FactorValue)
                   .FirstOrDefaultAsync();
                result = (effectScale * conversionFactor) / 100 * (100 - deadweightFactor);
            }
            else
            {
                result = await _context.InterventionEffects
                    .Where(x => x.Id == (interventionType))
                    .Select(y => y.EffectValue)
                    .FirstOrDefaultAsync();
            }
            return result;
        }
        public Dictionary<string, Sector> GetSectorBenefits(decimal interventionEffectValue, int totalParticipant, List<TotalSectorCostModel> totalSectorCostValues, Languages lang)
        {
            var sectorBenefits = new Dictionary<string, Sector>();
            foreach (SectorType sectorType in Enum.GetValues(typeof(SectorType)))
            {
                var sector = new Sector();
                foreach (StakeholderType stakeholderType in Enum.GetValues(typeof(StakeholderType)))
                {
                    if (totalSectorCostValues.Where(x => x.SectorModelId.Equals((int)sectorType) && x.StakeholderModelId.Equals((int)stakeholderType)).Count() > 0)
                    {
                        sector.Stakeholders.Add(stakeholderType.GetLanguageSpecificDescription(lang), new Stakeholder(
                            (RoundDouble(totalSectorCostValues
                            .Where(x => x.StakeholderModelId == (int)stakeholderType)
                            .Where(y => y.SectorModelId == (int)sectorType)
                            .Select(z => z.TotalSectorCost).FirstOrDefault() * interventionEffectValue)),
                            RoundDouble(((totalSectorCostValues
                            .Where(x => x.StakeholderModelId == (int)stakeholderType)
                            .Where(y => y.SectorModelId == (int)sectorType)
                            .Select(z => z.TotalSectorCost).FirstOrDefault() * interventionEffectValue) * totalParticipant)
                            )));
                    }
                }
                sectorBenefits.Add(sectorType.GetLanguageSpecificDescription(lang), sector);
            }
            return sectorBenefits;
        }
        public Dictionary<string, KeyMetric> GetNetBenefits(Dictionary<string, Sector> sectorBenefits, int totalParticipant, decimal interventionCosts, Languages lang)
        {
            var netBenefits = new Dictionary<string, KeyMetric>();
            var totalBenefitsPerPerson = 0m;
            var totalBenefits = 0m;
            foreach (var stakeholder in sectorBenefits.Select(x => x.Value.Stakeholders.Values).ToList())
            {
                totalBenefitsPerPerson += stakeholder.Sum(x => x.GainsPerPerson);
                totalBenefits += stakeholder.Sum(x => x.TotalGains);
            }
            netBenefits.Add(
            InterventionResults.Cost.GetLanguageSpecificDescription(lang),
            new KeyMetric(
                    RoundDouble(RoundDouble(interventionCosts * -1) / totalParticipant),
                    RoundDouble(interventionCosts * -1)
                )
            );
            netBenefits.Add(
            InterventionResults.Total.GetLanguageSpecificDescription(lang),
            new KeyMetric(
                   RoundDouble(totalBenefitsPerPerson),
                   RoundDouble(totalBenefits)
                )
            );
            netBenefits.Add(
            InterventionResults.Net.GetLanguageSpecificDescription(lang),
            new KeyMetric(
                   RoundDouble(totalBenefitsPerPerson + (interventionCosts * -1) / totalParticipant),
                   RoundDouble(totalBenefits + interventionCosts * -1)
                )
            );

            return netBenefits;
        }

        public Wellby GetWellbyData(int interventionType, int totalParticipant, decimal interventionEffectValue, string UCLAType)
        {
            var UCLAScale = (UCLAType.Equals("UCLA-3")) ? interventionEffectValue * 10 * 0.81m : interventionEffectValue;
            var wellbyPoint = (UCLAScale / 30) * 0.48m;
            var wellbySocialValuePerParticipant = wellbyPoint * 185714;
            var wellbySocialValueTotal = wellbySocialValuePerParticipant * totalParticipant;

            return new Wellby(
                RoundDouble(wellbyPoint),
                RoundDouble(wellbySocialValuePerParticipant),
                RoundDouble(wellbySocialValueTotal)
                );
        }

        public decimal RoundDouble(decimal inputValue)
        {
            return Math.Round(inputValue, 2, MidpointRounding.AwayFromZero);
        }
        public string AbbreviateNumber(AbbreviateType abbreviateType,int decimalPoint, decimal number, Languages lang)
        {
            var currency = "kr";
            var thousend = "";
            var million = "";
            var billion = "";
            var trillion = "";

            if (abbreviateType.Equals(AbbreviateType.Currency))
            {
                 thousend = (int)lang == 1 ? " k" : $" t{currency}.";
                 million = (int)lang == 1 ? " m" : $" mio. {currency}.";
                 billion = (int)lang == 1 ? " b" : $" mia. {currency}.";
                 trillion = (int)lang == 1 ? " tn" : $" tn. {currency}.";
            }
            else if (abbreviateType.Equals(AbbreviateType.Population))
            {
                 thousend = (int)lang == 1 ? " thousands" : " tusind";
                 million = (int)lang == 1 ? " million" : " mio";
                 billion = (int)lang == 1 ? " billions" : " mia";
                 trillion = (int)lang == 1 ? " trillion" : " billion";
            }
           
            var sufix = number < 0 ? "- " : "";
            var numberAbs = Math.Abs(number);
            if (numberAbs < 1000)
                if (abbreviateType.Equals(AbbreviateType.Currency))
                {
                    return numberAbs.ToString("#0").Replace(",", ".") + " " + currency;
                }
                else if (abbreviateType.Equals(AbbreviateType.Population))
                {
                    return numberAbs.ToString("#0").Replace(",", ".");
                }      

            if (numberAbs < 10_000)
            {
                if (numberAbs % 1000 >= 100)
                    return sufix + Math.Round(numberAbs / 1000m, decimalPoint, MidpointRounding.ToZero).ToString().Replace(",", ".") + thousend;

                return (numberAbs / 1000m).ToString($"{sufix}#{thousend}").Replace(",", ".");
            }

            if (numberAbs < 1_000_000)
            {
                if (number % 1000 >= 100)
                    return sufix + Math.Round(numberAbs / 1000m, decimalPoint, MidpointRounding.ToZero).ToString().Replace(",", ".") + thousend;

                return (numberAbs / 1000m).ToString($"{sufix}#{thousend}").Replace(",", ".");
            }

            if (numberAbs < 1_000_000)
            {
                return sufix + Math.Round(numberAbs / 1000m, decimalPoint, MidpointRounding.ToZero).ToString().Replace(",", ".") + thousend;
            }

            if (numberAbs < 1_000_000_000)
            {
                return sufix + Math.Round(numberAbs / 1_000_000m, decimalPoint, MidpointRounding.ToZero).ToString().Replace(",", ".") + million;
            }

            if (numberAbs < 1_000_000_000_000)
            {
                return sufix + Math.Round(numberAbs / 1_000_000_000m, decimalPoint, MidpointRounding.ToZero).ToString().Replace(",", ".") + billion;
            }

            if (numberAbs < 1_000_000_000_000_000)
            {
                return sufix + Math.Round(numberAbs / 1_000_000_000_000m, decimalPoint, MidpointRounding.ToZero).ToString().Replace(",", ".") + trillion;
            }

            return (numberAbs / 1000000m).ToString($"{sufix}#,0.0{billion}").Replace(",", ".");
        }
    }
}
