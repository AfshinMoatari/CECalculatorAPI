using static CEProjectServer.Model.enums.AttributeHelperExtension;

namespace CEProjectServer.Model.enums
{
    public class InterventionResultsEnum
    {
        public enum InterventionResults
        {
            [MultilingualDescription(new string[] { "Costs of the intervention", "Omkostninger ved indgrebet" })]
            Cost = 1,
            [MultilingualDescription(new string[] { "Total benefits of the intervention", "Samlede fordele ved interventionen" })]
            Total = 2,
            [MultilingualDescription(new string[] { "Net benefit", "Netto fordel" })]
            Net = 3
        }
    }
}
