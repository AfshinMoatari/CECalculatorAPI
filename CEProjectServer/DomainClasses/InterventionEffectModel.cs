using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CEProjectServer;

    public class InterventionEffectModel
{
    [Key]
        public int Id { get; set; }
        public string EffectType { get; set; }
        [Column(TypeName = "decimal(28, 18)")]
        public decimal EffectValue { get; set; }

        public InterventionEffectModel()
        { }
        public InterventionEffectModel(int id, string effectType, decimal effectValue)
        {
            Id = id;
            EffectType = effectType;
            EffectValue = effectValue;
        }
    }

