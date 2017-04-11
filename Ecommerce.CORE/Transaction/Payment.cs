using Ecommerce.CORE.Repository;

namespace Ecommerce.CORE.Transaction
{
    public class Payment
    {
        private IPayment _payment;

        public Payment(IPayment payment)
        {
            _payment = payment;
        }

        public void DoPayment()
        {
            _payment.DoPayment();
        }

    }
}
