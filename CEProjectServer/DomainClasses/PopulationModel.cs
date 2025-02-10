using System.ComponentModel.DataAnnotations;

namespace CEProjectServer;

    public class PopulationModel
    {
        [Key]
        public int Id { get; set; }
        public string PopulationType { get; set; }

        public ICollection<TotalSectorCostModel> TotalSectorCostModel { get; set; }

        public PopulationModel()
        { }
        public PopulationModel(int id, string populationType)
        {
            Id = id;
            PopulationType = populationType;
        }
    }
