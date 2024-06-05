namespace SOLID.OCP
{
    public class PaymentProcessor
    {
        private readonly IPaymentMethod _paymentMethod;

        public PaymentProcessor(IPaymentMethod paymentMethod) => _paymentMethod = paymentMethod;
        
        public void ProcessPayment(decimal amount)
        {
            _paymentMethod.ProcessPayment(amount);
        }
    }
}
