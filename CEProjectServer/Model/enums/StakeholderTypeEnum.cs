using System.ComponentModel;
using static CEProjectServer.Model.enums.AttributeHelperExtension;

namespace CEProjectServer.Model.enums
{
    public class StakeholderTypeEnum
    {
        public enum StakeholderType
        {
            [MultilingualDescription(new string[] { "Municipality", "Kommune" })]
            Municipality = 1,
            [MultilingualDescription(new string[] { "Region", "Område" })]
            Region = 2,
            [MultilingualDescription(new string[] { "Other state", "Anden stat" })]
            OtherState = 3,
            [MultilingualDescription(new string[] { "Other economic", "Andet økonomisk" })]
            OtherEconomic = 4,
            [MultilingualDescription(new string[] { "Monetary quality of life", "Monetær livskvalitet" })]
            MonetaryQualityOfLife = 5,
            [MultilingualDescription(new string[] { "Production", "Produktion" })]
            Production = 6
        }
    }
}
