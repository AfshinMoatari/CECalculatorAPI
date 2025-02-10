using System.ComponentModel.DataAnnotations;

namespace CEProjectServer;

    public class StakeholderModel
    {
        [Key]
        public int Id { get; set; }
        public string StakeholderType { get; set; }

        public ICollection<TotalSectorCostModel> TotalSectorCostModel { get; set; }

        public StakeholderModel()
        { }
        public StakeholderModel(int id, string stakeholderType)
        {
            Id = id;
            StakeholderType = stakeholderType;
        }
    }