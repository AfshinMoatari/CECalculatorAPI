using static CEProjectServer.Model.enums.InterventionTypeEnum;
using static CEProjectServer.Model.enums.OrganisationTypeEnum;
using static CEProjectServer.Model.enums.PopulationTypeEnum;

namespace CEProjectServer;

public partial class InterventionRequestModel
{
    public string ProjectName { get; set; }
    public int TotalParticipant { get; set; }
    public decimal InterventionCosts { get; set; }
    public PopulationType PopulationType { get; set; }
    public InterventionType InterventionType { get; set; }
    public decimal EffectScale { get; set; } = 0;
    public OrganisationType OrganisationType { get; set; }
    public string OrganisationName { get; set; }

    public InterventionRequestModel (
        string projectName, 
        int totalParticipant, 
        decimal interventionCosts, 
        PopulationType populationType,
        InterventionType interventionType, 
        decimal effectScale,
        OrganisationType organisationType,
        string organisationName)
        {
            ProjectName = projectName;
            TotalParticipant = totalParticipant;
            InterventionCosts = interventionCosts;
            PopulationType = populationType;
            InterventionType = interventionType;
            EffectScale = effectScale;
            OrganisationType = organisationType;
            OrganisationName = organisationName;
        }
}