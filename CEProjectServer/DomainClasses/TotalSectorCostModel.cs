using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CEProjectServer;

    public class TotalSectorCostModel
    {
        [Key]
        public int Id { get; set; }
        public decimal TotalSectorCost { get; set; }

        public StakeholderModel StakeholderModel { get; set; }
        [ForeignKey("StakeholderModel")]
        public int StakeholderModelId { get; set; }

        public SectorModel SectorModel { get; set; }
        [ForeignKey("SectorModel")]
        public int SectorModelId { get; set; }

        public PopulationModel PopulationModel { get; set; }
        [ForeignKey("PopulationModel")]
        public int PopulationModelId { get; set; }

        public MeasurementModel MeasurementModel { get; set; }
        [ForeignKey("MeasurementModel")]
        public int MeasurementModelId { get; set; }

    public TotalSectorCostModel()
        { }
        public TotalSectorCostModel(int id, decimal totalSectorCost, int stakeholderModelId, int sectorModelId, int
            populationModelId, int measurementModelId)
        {
            Id = id;
            TotalSectorCost = totalSectorCost;
            StakeholderModelId = stakeholderModelId;
            SectorModelId = sectorModelId;
            PopulationModelId = populationModelId;
            MeasurementModelId = measurementModelId;
        }
    }

