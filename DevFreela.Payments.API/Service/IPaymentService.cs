using DevFreela.Payments.API.Models;

namespace DevFreela.Payments.API.Service
{
    public interface IPaymentService
    {
        Task<bool> Process(PaymentInfoInputModel paymentInfoUpdateModel);
    }
}
