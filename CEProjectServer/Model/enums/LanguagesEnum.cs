using System.ComponentModel;
using static CEProjectServer.Model.enums.AttributeHelperExtension;

namespace CEProjectServer.Model.enums
{
    public class LanguagesEnum
    {
        public enum Languages
        {
            [MultilingualDescription(new string[] { "English", "Engelsk" })]
            EN = 1,
            [MultilingualDescription(new string[] { "Danish", "Dansk" })]
            DA = 2
        }
    }
}
