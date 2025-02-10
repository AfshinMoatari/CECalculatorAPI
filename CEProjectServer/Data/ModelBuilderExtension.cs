using CEProjectServer.Model.enums;
using Microsoft.EntityFrameworkCore;
using static CEProjectServer.Model.enums.EconomicFactorEnum;
using static CEProjectServer.Model.enums.InterventionTypeEnum;
using static CEProjectServer.Model.enums.LanguagesEnum;
using static CEProjectServer.Model.enums.MeasurementTypeEnum;
using static CEProjectServer.Model.enums.PopulationTypeEnum;
using static CEProjectServer.Model.enums.SectorTypeEnum;
using static CEProjectServer.Model.enums.StakeholderTypeEnum;

namespace CEProjectServer.Data
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InterventionEffectModel>().HasData(
                new InterventionEffectModel((int)InterventionType.SocialNetwork, InterventionType.SocialNetwork.GetLanguageSpecificDescription(Languages.EN), 2.65923970302888m),
                new InterventionEffectModel((int)InterventionType.SocialSupport, InterventionType.SocialSupport.GetLanguageSpecificDescription(Languages.EN), 3.45701161393755m),
                new InterventionEffectModel((int)InterventionType.SocialAndEmotional, InterventionType.SocialAndEmotional.GetLanguageSpecificDescription(Languages.EN), 3.36837029050325m),
                new InterventionEffectModel((int)InterventionType.PsychologicalTreatment, InterventionType.PsychologicalTreatment.GetLanguageSpecificDescription(Languages.EN), 4.4320661717148m),
                new InterventionEffectModel((int)InterventionType.Unspecified, InterventionType.Unspecified.GetLanguageSpecificDescription(Languages.EN), 3.47917194479612m),
                new InterventionEffectModel((int)InterventionType.OwnSpecification, InterventionType.OwnSpecification.GetLanguageSpecificDescription(Languages.EN), 0m)
            );
            modelBuilder.Entity<SectorModel>().HasData(
                new SectorModel((int)SectorType.Healthcare, SectorType.Healthcare.GetLanguageSpecificDescription(Languages.EN)),
                new SectorModel((int)SectorType.SickDays, SectorType.SickDays.GetLanguageSpecificDescription(Languages.EN)),
                new SectorModel((int)SectorType.Unemployment, SectorType.Unemployment.GetLanguageSpecificDescription(Languages.EN)),
                new SectorModel((int)SectorType.Wellbeing, SectorType.Wellbeing.GetLanguageSpecificDescription(Languages.EN))
            );
            modelBuilder.Entity<StakeholderModel>().HasData(
                new StakeholderModel((int)StakeholderType.Municipality, StakeholderType.Municipality.GetLanguageSpecificDescription(Languages.EN)),
                new StakeholderModel((int)StakeholderType.Region, StakeholderType.Region.GetLanguageSpecificDescription(Languages.EN)),
                new StakeholderModel((int)StakeholderType.OtherState, StakeholderType.OtherState.GetLanguageSpecificDescription(Languages.EN)),
                new StakeholderModel((int)StakeholderType.OtherEconomic, StakeholderType.OtherEconomic.GetLanguageSpecificDescription(Languages.EN)),
                new StakeholderModel((int)StakeholderType.MonetaryQualityOfLife, StakeholderType.MonetaryQualityOfLife.GetLanguageSpecificDescription(Languages.EN)),
                new StakeholderModel((int)StakeholderType.Production, StakeholderType.Production.GetLanguageSpecificDescription(Languages.EN))
            );
            modelBuilder.Entity<PopulationModel>().HasData(
                new PopulationModel((int)PopulationType.GeneralPopulation, PopulationType.GeneralPopulation.GetLanguageSpecificDescription(Languages.EN)),
                new PopulationModel((int)PopulationType.Youth, PopulationType.Youth.GetLanguageSpecificDescription(Languages.EN)),
                new PopulationModel((int)PopulationType.WorkingAge, PopulationType.WorkingAge.GetLanguageSpecificDescription(Languages.EN)),
                new PopulationModel((int)PopulationType.PopulationOver65, PopulationType.PopulationOver65.GetLanguageSpecificDescription(Languages.EN))
            );
            modelBuilder.Entity<MeasurementModel>().HasData(
                 new MeasurementModel((int)MeasurementType.Nscale, MeasurementType.Nscale.GetLanguageSpecificDescription(Languages.EN)),
                 new MeasurementModel((int)MeasurementType.UCLA, MeasurementType.UCLA.GetLanguageSpecificDescription(Languages.EN))
             );
            modelBuilder.Entity<EconomicFactorModel>().HasData(
                new EconomicFactorModel((int)EconomicFactor.Deadweight, EconomicFactor.Deadweight.GetLanguageSpecificDescription(Languages.EN), 19),
                new EconomicFactorModel((int)EconomicFactor.Conversion, EconomicFactor.Conversion.GetLanguageSpecificDescription(Languages.EN), 1)
            );
            modelBuilder.Entity<TotalSectorCostModel>().HasData(
            //Nscale
            //Healthcare

               new TotalSectorCostModel(1, 1385m, (int)StakeholderType.Municipality, (int)SectorType.Healthcare, (int)PopulationType.GeneralPopulation, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(2, 0m, (int)StakeholderType.Municipality, (int)SectorType.Healthcare, (int)PopulationType.Youth, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(3, 185m, (int)StakeholderType.Municipality, (int)SectorType.Healthcare, (int)PopulationType.WorkingAge, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(4, 6247m, (int)StakeholderType.Municipality, (int)SectorType.Healthcare, (int)PopulationType.PopulationOver65, (int)MeasurementType.Nscale),
               //----
               new TotalSectorCostModel(5, 8056m, (int)StakeholderType.Region, (int)SectorType.Healthcare, (int)PopulationType.GeneralPopulation, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(6, 7642m, (int)StakeholderType.Region, (int)SectorType.Healthcare, (int)PopulationType.Youth, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(7, 7775m, (int)StakeholderType.Region, (int)SectorType.Healthcare, (int)PopulationType.WorkingAge, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(8, 9268m, (int)StakeholderType.Region, (int)SectorType.Healthcare, (int)PopulationType.PopulationOver65, (int)MeasurementType.Nscale),
               //----
               new TotalSectorCostModel(9, 0m, (int)StakeholderType.OtherState, (int)SectorType.Healthcare, (int)PopulationType.GeneralPopulation, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(10, 0m, (int)StakeholderType.OtherState, (int)SectorType.Healthcare, (int)PopulationType.Youth, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(11, 0m, (int)StakeholderType.OtherState, (int)SectorType.Healthcare, (int)PopulationType.WorkingAge, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(12, 0m, (int)StakeholderType.OtherState, (int)SectorType.Healthcare, (int)PopulationType.PopulationOver65, (int)MeasurementType.Nscale),
               //----
               new TotalSectorCostModel(13, 0m, (int)StakeholderType.OtherEconomic, (int)SectorType.Healthcare, (int)PopulationType.GeneralPopulation, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(14, 0m, (int)StakeholderType.OtherEconomic, (int)SectorType.Healthcare, (int)PopulationType.Youth, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(15, 0m, (int)StakeholderType.OtherEconomic, (int)SectorType.Healthcare, (int)PopulationType.WorkingAge, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(16, 0m, (int)StakeholderType.OtherEconomic, (int)SectorType.Healthcare, (int)PopulationType.PopulationOver65, (int)MeasurementType.Nscale),

               //Sick days
               new TotalSectorCostModel(17, 979m, (int)StakeholderType.Municipality, (int)SectorType.SickDays, (int)PopulationType.GeneralPopulation, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(18, 0m, (int)StakeholderType.Municipality, (int)SectorType.SickDays, (int)PopulationType.Youth, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(19, 1570m, (int)StakeholderType.Municipality, (int)SectorType.SickDays, (int)PopulationType.WorkingAge, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(20, 0m, (int)StakeholderType.Municipality, (int)SectorType.SickDays, (int)PopulationType.PopulationOver65, (int)MeasurementType.Nscale),
               //----
               new TotalSectorCostModel(21, 0m, (int)StakeholderType.Region, (int)SectorType.SickDays, (int)PopulationType.GeneralPopulation, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(22, 0m, (int)StakeholderType.Region, (int)SectorType.SickDays, (int)PopulationType.Youth, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(23, 0m, (int)StakeholderType.Region, (int)SectorType.SickDays, (int)PopulationType.WorkingAge, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(24, 0m, (int)StakeholderType.Region, (int)SectorType.SickDays, (int)PopulationType.PopulationOver65, (int)MeasurementType.Nscale),
               //----
               new TotalSectorCostModel(25, 0m, (int)StakeholderType.OtherState, (int)SectorType.SickDays, (int)PopulationType.GeneralPopulation, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(26, 0m, (int)StakeholderType.OtherState, (int)SectorType.SickDays, (int)PopulationType.Youth, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(27, 0m, (int)StakeholderType.OtherState, (int)SectorType.SickDays, (int)PopulationType.WorkingAge, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(28, 0m, (int)StakeholderType.OtherState, (int)SectorType.SickDays, (int)PopulationType.PopulationOver65, (int)MeasurementType.Nscale),
               //----
               new TotalSectorCostModel(29, 4522m, (int)StakeholderType.Production, (int)SectorType.SickDays, (int)PopulationType.GeneralPopulation, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(30, 0m, (int)StakeholderType.Production, (int)SectorType.SickDays, (int)PopulationType.Youth, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(31, 7249m, (int)StakeholderType.Production, (int)SectorType.SickDays, (int)PopulationType.WorkingAge, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(32, 0m, (int)StakeholderType.Production, (int)SectorType.SickDays, (int)PopulationType.PopulationOver65, (int)MeasurementType.Nscale),

               //Unemployment
               new TotalSectorCostModel(33, 306m, (int)StakeholderType.Municipality, (int)SectorType.Unemployment, (int)PopulationType.GeneralPopulation, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(34, 0m, (int)StakeholderType.Municipality, (int)SectorType.Unemployment, (int)PopulationType.Youth, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(35, 491m, (int)StakeholderType.Municipality, (int)SectorType.Unemployment, (int)PopulationType.WorkingAge, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(36, 0m, (int)StakeholderType.Municipality, (int)SectorType.Unemployment, (int)PopulationType.PopulationOver65, (int)MeasurementType.Nscale),
               //----
               new TotalSectorCostModel(37, 0m, (int)StakeholderType.Region, (int)SectorType.Unemployment, (int)PopulationType.GeneralPopulation, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(38, 0m, (int)StakeholderType.Region, (int)SectorType.Unemployment, (int)PopulationType.Youth, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(39, 0m, (int)StakeholderType.Region, (int)SectorType.Unemployment, (int)PopulationType.WorkingAge, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(40, 0m, (int)StakeholderType.Region, (int)SectorType.Unemployment, (int)PopulationType.PopulationOver65, (int)MeasurementType.Nscale),
               //----
               new TotalSectorCostModel(41, 2221m, (int)StakeholderType.OtherState, (int)SectorType.Unemployment, (int)PopulationType.GeneralPopulation, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(42, 0m, (int)StakeholderType.OtherState, (int)SectorType.Unemployment, (int)PopulationType.Youth, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(43, 3561m, (int)StakeholderType.OtherState, (int)SectorType.Unemployment, (int)PopulationType.WorkingAge, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(44, 0m, (int)StakeholderType.OtherState, (int)SectorType.Unemployment, (int)PopulationType.PopulationOver65, (int)MeasurementType.Nscale),
               //----
               new TotalSectorCostModel(45, 7973m, (int)StakeholderType.Production, (int)SectorType.Unemployment, (int)PopulationType.GeneralPopulation, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(46, 0m, (int)StakeholderType.Production, (int)SectorType.Unemployment, (int)PopulationType.Youth, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(47, 12783m, (int)StakeholderType.Production, (int)SectorType.Unemployment, (int)PopulationType.WorkingAge, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(48, 0m, (int)StakeholderType.Production, (int)SectorType.Unemployment, (int)PopulationType.PopulationOver65, (int)MeasurementType.Nscale),

               //Wellbeing
               new TotalSectorCostModel(49, 0m, (int)StakeholderType.Municipality, (int)SectorType.Wellbeing, (int)PopulationType.GeneralPopulation, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(50, 0m, (int)StakeholderType.Municipality, (int)SectorType.Wellbeing, (int)PopulationType.Youth, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(51, 0m, (int)StakeholderType.Municipality, (int)SectorType.Wellbeing, (int)PopulationType.WorkingAge, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(52, 0m, (int)StakeholderType.Municipality, (int)SectorType.Wellbeing, (int)PopulationType.PopulationOver65, (int)MeasurementType.Nscale),
               //----
               new TotalSectorCostModel(53, 0m, (int)StakeholderType.Region, (int)SectorType.Wellbeing, (int)PopulationType.GeneralPopulation, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(54, 0m, (int)StakeholderType.Region, (int)SectorType.Wellbeing, (int)PopulationType.Youth, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(55, 0m, (int)StakeholderType.Region, (int)SectorType.Wellbeing, (int)PopulationType.WorkingAge, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(56, 0m, (int)StakeholderType.Region, (int)SectorType.Wellbeing, (int)PopulationType.PopulationOver65, (int)MeasurementType.Nscale),
               //----
               new TotalSectorCostModel(57, 0m, (int)StakeholderType.OtherState, (int)SectorType.Wellbeing, (int)PopulationType.GeneralPopulation, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(58, 0m, (int)StakeholderType.OtherState, (int)SectorType.Wellbeing, (int)PopulationType.Youth, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(59, 0m, (int)StakeholderType.OtherState, (int)SectorType.Wellbeing, (int)PopulationType.WorkingAge, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(60, 0m, (int)StakeholderType.OtherState, (int)SectorType.Wellbeing, (int)PopulationType.PopulationOver65, (int)MeasurementType.Nscale),
               //----
               new TotalSectorCostModel(61, 89143m, (int)StakeholderType.MonetaryQualityOfLife, (int)SectorType.Wellbeing, (int)PopulationType.GeneralPopulation, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(62, 89143m, (int)StakeholderType.MonetaryQualityOfLife, (int)SectorType.Wellbeing, (int)PopulationType.Youth, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(63, 89143m, (int)StakeholderType.MonetaryQualityOfLife, (int)SectorType.Wellbeing, (int)PopulationType.WorkingAge, (int)MeasurementType.Nscale),
               new TotalSectorCostModel(64, 89143m, (int)StakeholderType.MonetaryQualityOfLife, (int)SectorType.Wellbeing, (int)PopulationType.PopulationOver65, (int)MeasurementType.Nscale),

               //UCLA
               //Healthcare
               new TotalSectorCostModel(65, 46m, (int)StakeholderType.Municipality, (int)SectorType.Healthcare, (int)PopulationType.GeneralPopulation, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(66, 0m, (int)StakeholderType.Municipality, (int)SectorType.Healthcare, (int)PopulationType.Youth, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(67, 6m, (int)StakeholderType.Municipality, (int)SectorType.Healthcare, (int)PopulationType.WorkingAge, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(68, 208m, (int)StakeholderType.Municipality, (int)SectorType.Healthcare, (int)PopulationType.PopulationOver65, (int)MeasurementType.UCLA),
               //----
               new TotalSectorCostModel(69, 269m, (int)StakeholderType.Region, (int)SectorType.Healthcare, (int)PopulationType.GeneralPopulation, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(70, 255m, (int)StakeholderType.Region, (int)SectorType.Healthcare, (int)PopulationType.Youth, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(71, 259m, (int)StakeholderType.Region, (int)SectorType.Healthcare, (int)PopulationType.WorkingAge, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(72, 309m, (int)StakeholderType.Region, (int)SectorType.Healthcare, (int)PopulationType.PopulationOver65, (int)MeasurementType.UCLA),
               //----
               new TotalSectorCostModel(73, 0m, (int)StakeholderType.OtherState, (int)SectorType.Healthcare, (int)PopulationType.GeneralPopulation, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(74, 0m, (int)StakeholderType.OtherState, (int)SectorType.Healthcare, (int)PopulationType.Youth, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(75, 0m, (int)StakeholderType.OtherState, (int)SectorType.Healthcare, (int)PopulationType.WorkingAge, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(76, 0m, (int)StakeholderType.OtherState, (int)SectorType.Healthcare, (int)PopulationType.PopulationOver65, (int)MeasurementType.UCLA),
               //----
               new TotalSectorCostModel(77, 0m, (int)StakeholderType.OtherEconomic, (int)SectorType.Healthcare, (int)PopulationType.GeneralPopulation, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(78, 0m, (int)StakeholderType.OtherEconomic, (int)SectorType.Healthcare, (int)PopulationType.Youth, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(79, 0m, (int)StakeholderType.OtherEconomic, (int)SectorType.Healthcare, (int)PopulationType.WorkingAge, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(80, 0m, (int)StakeholderType.OtherEconomic, (int)SectorType.Healthcare, (int)PopulationType.PopulationOver65, (int)MeasurementType.UCLA),

               //Sick days
               new TotalSectorCostModel(81, 33m, (int)StakeholderType.Municipality, (int)SectorType.SickDays, (int)PopulationType.GeneralPopulation, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(82, 0m, (int)StakeholderType.Municipality, (int)SectorType.SickDays, (int)PopulationType.Youth, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(83, 52m, (int)StakeholderType.Municipality, (int)SectorType.SickDays, (int)PopulationType.WorkingAge, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(84, 0m, (int)StakeholderType.Municipality, (int)SectorType.SickDays, (int)PopulationType.PopulationOver65, (int)MeasurementType.UCLA),
               //----
               new TotalSectorCostModel(85, 0m, (int)StakeholderType.Region, (int)SectorType.SickDays, (int)PopulationType.GeneralPopulation, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(86, 0m, (int)StakeholderType.Region, (int)SectorType.SickDays, (int)PopulationType.Youth, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(87, 0m, (int)StakeholderType.Region, (int)SectorType.SickDays, (int)PopulationType.WorkingAge, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(88, 0m, (int)StakeholderType.Region, (int)SectorType.SickDays, (int)PopulationType.PopulationOver65, (int)MeasurementType.UCLA),
               //----
               new TotalSectorCostModel(89, 0m, (int)StakeholderType.OtherState, (int)SectorType.SickDays, (int)PopulationType.GeneralPopulation, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(90, 0m, (int)StakeholderType.OtherState, (int)SectorType.SickDays, (int)PopulationType.Youth, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(91, 0m, (int)StakeholderType.OtherState, (int)SectorType.SickDays, (int)PopulationType.WorkingAge, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(92, 0m, (int)StakeholderType.OtherState, (int)SectorType.SickDays, (int)PopulationType.PopulationOver65, (int)MeasurementType.UCLA),
               //----
               new TotalSectorCostModel(93, 151m, (int)StakeholderType.Production, (int)SectorType.SickDays, (int)PopulationType.GeneralPopulation, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(94, 0m, (int)StakeholderType.Production, (int)SectorType.SickDays, (int)PopulationType.Youth, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(95, 242m, (int)StakeholderType.Production, (int)SectorType.SickDays, (int)PopulationType.WorkingAge, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(96, 0m, (int)StakeholderType.Production, (int)SectorType.SickDays, (int)PopulationType.PopulationOver65, (int)MeasurementType.UCLA),

               //Unemployment
               new TotalSectorCostModel(97, 10m, (int)StakeholderType.Municipality, (int)SectorType.Unemployment, (int)PopulationType.GeneralPopulation, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(98, 0m, (int)StakeholderType.Municipality, (int)SectorType.Unemployment, (int)PopulationType.Youth, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(99, 16m, (int)StakeholderType.Municipality, (int)SectorType.Unemployment, (int)PopulationType.WorkingAge, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(100, 0m, (int)StakeholderType.Municipality, (int)SectorType.Unemployment, (int)PopulationType.PopulationOver65, (int)MeasurementType.UCLA),
               //----
               new TotalSectorCostModel(101, 0m, (int)StakeholderType.Region, (int)SectorType.Unemployment, (int)PopulationType.GeneralPopulation, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(102, 0m, (int)StakeholderType.Region, (int)SectorType.Unemployment, (int)PopulationType.Youth, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(103, 0m, (int)StakeholderType.Region, (int)SectorType.Unemployment, (int)PopulationType.WorkingAge, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(104, 0m, (int)StakeholderType.Region, (int)SectorType.Unemployment, (int)PopulationType.PopulationOver65, (int)MeasurementType.UCLA),
               //----
               new TotalSectorCostModel(105, 74m, (int)StakeholderType.OtherState, (int)SectorType.Unemployment, (int)PopulationType.GeneralPopulation, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(106, 0m, (int)StakeholderType.OtherState, (int)SectorType.Unemployment, (int)PopulationType.Youth, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(107, 119m, (int)StakeholderType.OtherState, (int)SectorType.Unemployment, (int)PopulationType.WorkingAge, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(108, 0m, (int)StakeholderType.OtherState, (int)SectorType.Unemployment, (int)PopulationType.PopulationOver65, (int)MeasurementType.UCLA),
               //----
               new TotalSectorCostModel(109, 266m, (int)StakeholderType.Production, (int)SectorType.Unemployment, (int)PopulationType.GeneralPopulation, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(110, 0m, (int)StakeholderType.Production, (int)SectorType.Unemployment, (int)PopulationType.Youth, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(111, 426m, (int)StakeholderType.Production, (int)SectorType.Unemployment, (int)PopulationType.WorkingAge, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(112, 0m, (int)StakeholderType.Production, (int)SectorType.Unemployment, (int)PopulationType.PopulationOver65, (int)MeasurementType.UCLA),

               //Wellbeing
               new TotalSectorCostModel(113, 0m, (int)StakeholderType.Municipality, (int)SectorType.Wellbeing, (int)PopulationType.GeneralPopulation, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(114, 0m, (int)StakeholderType.Municipality, (int)SectorType.Wellbeing, (int)PopulationType.Youth, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(115, 0m, (int)StakeholderType.Municipality, (int)SectorType.Wellbeing, (int)PopulationType.WorkingAge, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(116, 0m, (int)StakeholderType.Municipality, (int)SectorType.Wellbeing, (int)PopulationType.PopulationOver65, (int)MeasurementType.UCLA),
               //----
               new TotalSectorCostModel(117, 0m, (int)StakeholderType.Region, (int)SectorType.Wellbeing, (int)PopulationType.GeneralPopulation, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(118, 0m, (int)StakeholderType.Region, (int)SectorType.Wellbeing, (int)PopulationType.Youth, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(119, 0m, (int)StakeholderType.Region, (int)SectorType.Wellbeing, (int)PopulationType.WorkingAge, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(120, 0m, (int)StakeholderType.Region, (int)SectorType.Wellbeing, (int)PopulationType.PopulationOver65, (int)MeasurementType.UCLA),
               //----
               new TotalSectorCostModel(121, 0m, (int)StakeholderType.OtherState, (int)SectorType.Wellbeing, (int)PopulationType.GeneralPopulation, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(122, 0m, (int)StakeholderType.OtherState, (int)SectorType.Wellbeing, (int)PopulationType.Youth, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(123, 0m, (int)StakeholderType.OtherState, (int)SectorType.Wellbeing, (int)PopulationType.WorkingAge, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(124, 0m, (int)StakeholderType.OtherState, (int)SectorType.Wellbeing, (int)PopulationType.PopulationOver65, (int)MeasurementType.UCLA),
               //----
               new TotalSectorCostModel(125, 2971m, (int)StakeholderType.MonetaryQualityOfLife, (int)SectorType.Wellbeing, (int)PopulationType.GeneralPopulation, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(126, 2971m, (int)StakeholderType.MonetaryQualityOfLife, (int)SectorType.Wellbeing, (int)PopulationType.Youth, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(127, 2971m, (int)StakeholderType.MonetaryQualityOfLife, (int)SectorType.Wellbeing, (int)PopulationType.WorkingAge, (int)MeasurementType.UCLA),
               new TotalSectorCostModel(128, 2971m, (int)StakeholderType.MonetaryQualityOfLife, (int)SectorType.Wellbeing, (int)PopulationType.PopulationOver65, (int)MeasurementType.UCLA)
           );
        }
    }
}
