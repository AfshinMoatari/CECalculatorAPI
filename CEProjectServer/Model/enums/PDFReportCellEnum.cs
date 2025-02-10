using static CEProjectServer.Model.enums.AttributeHelperExtension;

namespace CEProjectServer.Model.enums
{
    public class PDFReportCellEnum
    {
        public enum PDFReportCells
        {
            [MultilingualDescription(new string[] { "Type of intervention", "Indsatstype" })]
            Type = 1,
            [MultilingualDescription(new string[] { "Participants", "Deltagere" })]
            Participant = 2,
            [MultilingualDescription(new string[] { "Cost", "Omkostning" })]
            Cost = 3,
            [MultilingualDescription(new string[] { "Effect size", "Estimeret effektstørrelse" })]
            EffectSize = 4,
            [MultilingualDescription(new string[] { "Healthcare", "Sundhedsydelser" })]
            Healthcare = 5,
            [MultilingualDescription(new string[] { "Sick days", "Sygedage" })]
            SickDays = 6,
            [MultilingualDescription(new string[] { "Unemployment", "Arbejdsløshed" })]
            Unemployment = 7,
            [MultilingualDescription(new string[] { "Wellbeing", "Trivsel" })]
            Wellbeing = 8,
            [MultilingualDescription(new string[] { "State", "Stat" })]
            State = 9,
            [MultilingualDescription(new string[] { "Region", "Region" })]
            Region = 10,
            [MultilingualDescription(new string[] { "Municipality", "Kommune" })]
            Municipality = 11,
            [MultilingualDescription(new string[] { "Production", "Produktion" })]
            Production = 12,
            [MultilingualDescription(new string[] { "Individuals", "Borgere" })]
            Individuals = 13,
            [MultilingualDescription(new string[] { "Distribution of value per beneficiary", "Fordeling af værdi blandt interessenter" })]
            Distribution = 14,
            [MultilingualDescription(new string[] { "Socioeconomic benefit, gross", "Samfundsøkonomisk værdi, brutto" })]
            GrossBenefit = 15,
            [MultilingualDescription(new string[] { "Socioeconomic benefit, net", "Samfundsøkonomisk værdi, netto" })]
            NetBenefit = 16,
            [MultilingualDescription(new string[] { "Unallocated", "Ikke tildelt" })]
            Unallocated = 17,

            [MultilingualDescription(new string[] { "Wellby Point", "Wellby Point" })]
            WellbyPoint = 18,
            [MultilingualDescription(new string[] { "Wellby Social Value Per Participant", "Wellby Social Value Per Participant" })]
            WellbySocialValuePerParticipant = 19,
            [MultilingualDescription(new string[] { "Wellby Social Value Total", "Wellby Social Value Total" })]
            WellbySocialValueTotal = 20,
             [MultilingualDescription(new string[] { "Financial gains, in total", "Økonomiske gevinster, i alt" })]
            FinancialGainsTotal = 21
        }
    }
}
