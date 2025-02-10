namespace CEProjectServer.Model
{
    public class InterventionResponseModel
    {
        public string Status { get; set; }

        public InterventionResponseModel(string status)
        {
            Status = status;    
        }
    }
}
