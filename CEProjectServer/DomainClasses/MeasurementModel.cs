using System.ComponentModel.DataAnnotations;

namespace CEProjectServer;

    public class MeasurementModel
{
        [Key]
        public int Id { get; set; }
        public string MeasurementType { get; set; }

        public ICollection<TotalSectorCostModel> TotalSectorCostModel { get; set; }

        public MeasurementModel()
        { }
        public MeasurementModel(int id, string measurementType)
        {
            Id = id;
            MeasurementType = measurementType;
        }
    }

