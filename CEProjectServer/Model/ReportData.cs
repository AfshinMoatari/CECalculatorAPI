namespace CEProjectServer;

public class ReportData
{
    public Dictionary<string, Sector> SectorBenefits { get; set; }
    public Dictionary<string, KeyMetric> NetBenefits { get; set; }
    public Wellby Wellbys { get; set; }

    public ReportData(Dictionary<string, Sector> sectorBenefits, Dictionary<string, KeyMetric> netBenefits, Wellby wellbys)
    {
        SectorBenefits = sectorBenefits;
        NetBenefits = netBenefits;
        Wellbys = wellbys;
    }

    public ReportData(){}

    public class Sector
    {
        public Dictionary<string, Stakeholder> Stakeholders { get; set; }

        public class Stakeholder
        {
            public decimal GainsPerPerson { get; set; }
            public decimal TotalGains { get; set; }

            public Stakeholder(decimal gainsPerPerson, decimal totalGains)
            {
                GainsPerPerson = gainsPerPerson;
                TotalGains = totalGains;
            }
        }

        public Sector()
        {
            Stakeholders = new Dictionary<string, Stakeholder>();
        }

    }

    public class KeyMetric
    {
        public decimal PerCapita { get; set; }
        public decimal Total { get; set; }

        public KeyMetric(decimal perCapita, decimal total)
        {
            PerCapita = perCapita;
            Total = total;
        }
    }

    public class Wellby
    {
        public decimal WellbyPoint { get; set; }
        public decimal WellbySocialValuePerParticipant { get; set; }
        public decimal WellbySocialValueTotal { get; set; }

        public Wellby(decimal wellbyPoint, decimal wellbySocialValuePerParticipant, decimal wellbySocialValueTotal)
        {
            WellbyPoint = wellbyPoint;
            WellbySocialValuePerParticipant = wellbySocialValuePerParticipant;
            WellbySocialValueTotal = wellbySocialValueTotal;
        }
    }
}