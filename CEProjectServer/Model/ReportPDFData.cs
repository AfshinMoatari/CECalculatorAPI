namespace CEProjectServer;

public class ReportPDFData
{
    public string ProjectName { get; set; }
    public Dictionary<string, List<Cell>>? Rows { get; set; }
    public ReportAppendixData ReportAppendix { get; set; }

    public class Cell
    {
        public string Name { get; set; }
        public object Figure { get; set; }

        public Cell(string name, object figure)
        {
            Name = name;
            Figure = figure;
        }
    }

    public ReportPDFData(Dictionary<string, List<Cell>>? rows, string projectName, ReportAppendixData reportAppendix)
    {
        Rows = rows;
        ProjectName = projectName;
        ReportAppendix = reportAppendix;
    }

    public ReportPDFData() {}
}

public class ProgressChart
{
    public Dictionary<string, object> Figure { get; set; }

    public ProgressChart(Dictionary<string, object> figure)
    {
        Figure = figure;
    }
}

public class ReportAppendixData
{
    public ReportAppendixData(object reportName, object effectSize, object healthCareBenefit, object sickDaysBenefit, object unemploymentBenefit, object municipalityImpact, object regionImpact, object stateImpact, object productionImpact, object wellbeingImpact, object wELLBYPoint, object impactSum)
    {
        ReportName = reportName;
        EffectSize = effectSize;
        HealthCareBenefit = healthCareBenefit;
        SickDaysBenefit = sickDaysBenefit;
        UnemploymentBenefit = unemploymentBenefit;
        MunicipalityImpact = municipalityImpact;
        RegionImpact = regionImpact;
        StateImpact = stateImpact;
        ProductionImpact = productionImpact;
        WellbeingImpact = wellbeingImpact;
        WELLBYPoint = wELLBYPoint;
        ImpactSum = impactSum;
    }

    public object ReportName { get; set; }
    public object EffectSize { get; set; }
    public object HealthCareBenefit { get; set; }
    public object SickDaysBenefit { get; set; }
    public object UnemploymentBenefit { get; set; }
    public object MunicipalityImpact { get; set; }
    public object RegionImpact { get; set; }
    public object StateImpact { get; set; }
    public object ProductionImpact { get; set; }
    public object WellbeingImpact { get; set; }
    public object WELLBYPoint { get; set; }
    public object ImpactSum { get; set; }

    
}