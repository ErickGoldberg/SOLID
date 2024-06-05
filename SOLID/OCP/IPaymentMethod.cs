namespace SOLID.OCP
{
    public interface IPaymentMethod
    {
        void ProcessPayment(decimal amount);
    }
}
