using System.ComponentModel;
using static CEProjectServer.Model.enums.AttributeHelperExtension;

namespace CEProjectServer.Model.enums
{
    public class SectorTypeEnum
    {
        public enum SectorType
        {
            [MultilingualDescription(new string[] { "Healthcare", "Sundhedspleje" })]
            Healthcare = 1,
            [MultilingualDescription(new string[] { "Sick days", "Syge dage" })]
            SickDays = 2,
            [MultilingualDescription(new string[] { "Unemployment", "Arbejdsløshed" })]
            Unemployment = 3,
            [MultilingualDescription(new string[] { "Wellbeing", "Velvære" })]
            Wellbeing = 4
        }
    }
}
