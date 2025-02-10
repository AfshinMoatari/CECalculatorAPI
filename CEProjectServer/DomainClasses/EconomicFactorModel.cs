using System.ComponentModel.DataAnnotations;

namespace CEProjectServer;

    public class EconomicFactorModel 
    {
        [Key]
        public int Id { get; set; }
        public string Factor { get; set; }
        public decimal FactorValue { get; set; }

        public EconomicFactorModel()
        { }
        public EconomicFactorModel(int id, string factor, decimal factorValue)
        {
            Id = id;
            Factor = factor;
            FactorValue = factorValue;
        }
    }

