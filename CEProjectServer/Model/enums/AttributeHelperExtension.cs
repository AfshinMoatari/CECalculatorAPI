using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using static CEProjectServer.Model.enums.InterventionTypeEnum;
using static CEProjectServer.Model.enums.LanguagesEnum;

namespace CEProjectServer.Model.enums
{
    public static class AttributeHelperExtension
    {
        public static string GetLanguageSpecificDescription(this Enum value, Languages language)
        {
            var attribute = (MultilingualDescription[])(value.GetType().GetField(value.ToString())).GetCustomAttributes(typeof(MultilingualDescription), false);
            return attribute.Length > 0 ? attribute[0].Descriptions[(int)language - 1] : value.ToString();
        }

        [AttributeUsage(AttributeTargets.All)]
        public class MultilingualDescription : DescriptionAttribute
        {
            public string[] Descriptions { get; set; }

            public MultilingualDescription(string[] descriptions)
            {
                Descriptions = descriptions;
            }
        }
    }
}
