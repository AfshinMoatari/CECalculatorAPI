using System.ComponentModel;
using static CEProjectServer.Model.enums.AttributeHelperExtension;

namespace CEProjectServer.Model.enums
{
    public class EconomicFactorEnum
    {
        public enum EconomicFactor
        {
            [MultilingualDescription(new string[] { "Deadweight Factor", "Dødvægts Faktor" })]
            Deadweight = 1,
            [MultilingualDescription(new string[] { "Deadweight Factor", "Konverterings Faktor" })]
            Conversion = 2,
        }
    }
}
