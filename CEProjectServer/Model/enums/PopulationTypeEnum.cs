using System.ComponentModel;
using static CEProjectServer.Model.enums.AttributeHelperExtension;

namespace CEProjectServer.Model.enums
{
    public static class PopulationTypeEnum
    {
        public enum PopulationType
        {
            [MultilingualDescription(new string[] { "General Population", "Generel befolkning" })]
            GeneralPopulation = 1,
            [MultilingualDescription(new string[] { "Youth 0-15", "Unge, 0-15" })]
            Youth = 2,
            [MultilingualDescription(new string[] { "Working age 16-64", "Arbejdsdygtig alder, 15 – 65" })]
            WorkingAge = 3,
            [MultilingualDescription(new string[] { "Population 65+", "Ældre, +65" })]
            PopulationOver65 = 4
        }
    }
}
