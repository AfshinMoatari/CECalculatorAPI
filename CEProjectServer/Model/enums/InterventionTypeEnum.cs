using System.ComponentModel;
using static CEProjectServer.Model.enums.AttributeHelperExtension;

namespace CEProjectServer.Model.enums
{
    public class InterventionTypeEnum
    {
        public enum InterventionType
        {
            [MultilingualDescription(new string[] { "Social network", "Socialt netværk" })]
            SocialNetwork = 1,
            [MultilingualDescription(new string[] { "Social support", "Social støtte" })]
            SocialSupport = 2,
            [MultilingualDescription(new string[] { "Social and emotional skills training", "Social færdighedstræning" })]
            SocialAndEmotional = 3,
            [MultilingualDescription(new string[] { "Psychological treatment", "Psykologisk behandling" })]
            PsychologicalTreatment = 4,
            [MultilingualDescription(new string[] { "Other intervention type", "Anden interventionstype" })]
            Unspecified = 5,
            [MultilingualDescription(new string[] { "Own specification", "Egen" })]
            OwnSpecification = 6
        }
    }
}
