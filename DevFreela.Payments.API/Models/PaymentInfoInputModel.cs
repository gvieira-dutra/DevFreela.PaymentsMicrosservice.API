namespace DevFreela.Payments.API.Models
{
    public class PaymentInfoInputModel
    {
        public int ProjectId { get; set; }
        public string CcNumber { get; set; }
        public string Cvv { get; set; }
        public string ExpiryDate { get; set; }
        public string FullName { get; set; }
    }
}
