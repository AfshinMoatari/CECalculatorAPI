using System.ComponentModel.DataAnnotations;

namespace CEProjectServer;

    public class SectorModel
    {
        [Key]
        public int Id { get; set; }
        public string SectorType { get; set; }

        public ICollection<TotalSectorCostModel> TotalSectorCostModel { get; set; }

        public SectorModel()
        { }
        public SectorModel(int id, string sectorType)
        {
            Id = id;
            SectorType = sectorType;
        }
    }

