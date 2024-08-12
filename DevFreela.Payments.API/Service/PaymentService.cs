using DevFreela.Payments.API.Models;

namespace DevFreela.Payments.API.Service
{
    public class PaymentService : IPaymentService
    {
        public Task<bool> Process(PaymentInfoInputModel paymentInfoUpdateModel)
        {
            return Task.FromResult(true);
        }
    }
}
