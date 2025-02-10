using System.ComponentModel;
using static CEProjectServer.Model.enums.AttributeHelperExtension;

namespace CEProjectServer.Model.enums
{
    public class MeasurementTypeEnum
    {
        public enum MeasurementType
        {
            [MultilingualDescription(new string[] { "N scale", "Dansk" })]
            Nscale = 1,
            [MultilingualDescription(new string[] { "UCLA Loneliness Scale", "UCLA Loneliness Scale" })]
            UCLA = 2
        }
    }
}
