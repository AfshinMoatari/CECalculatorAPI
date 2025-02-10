using System.ComponentModel;
using static CEProjectServer.Model.enums.AttributeHelperExtension;

namespace CEProjectServer.Model.enums
{
    public class OrganisationTypeEnum
    {
        public enum OrganisationType
        {
            [MultilingualDescription(new string[] { "Municipality", "Kommune" })]
            Municipality = 1,
            [MultilingualDescription(new string[] { "Region", "Region" })]
            Region = 2,
            [MultilingualDescription(new string[] { "Governmental institution", "Offentlig institution" })]
            GovernmentalInstitution = 3,
            [MultilingualDescription(new string[] { "Social Intervention", "Social Indsats" })]
            SocialIntervention = 4,
            [MultilingualDescription(new string[] { "Foundation", "Fond" })]
            Foundation = 5,
            [MultilingualDescription(new string[] { "Private company", "Privat virksomhed" })]
            PrivatCompany = 6,
            [MultilingualDescription(new string[] { "Private Person", "Privat Person" })]
            PrivatPerson = 7,
            [MultilingualDescription(new string[] { "NGO", "NGO" })]
            NGO = 8,
            [MultilingualDescription(new string[] { "Other", "Andet" })]
            Andet = 9
        }
    }
}
