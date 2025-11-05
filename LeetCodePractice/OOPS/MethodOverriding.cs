namespace LeetCodePractice.OOPS
{
    public class MethodOverriding
    {
        //ABSTRACT


        public abstract class PaymentMethod
        {
            public abstract void Pay(decimal amount);
        }

        public class CreditCardPayment : PaymentMethod
        {
            public override void Pay(decimal amount)
            {
                Console.WriteLine($"CreditCard = {amount}");

            }
        }

        public class UPIPayment : PaymentMethod
        {
            public override void Pay(decimal amount)
            {
                Console.WriteLine($"Paytm = {amount}");
            }
        }

        // VIRTUAl

        public class Notification
        {
            public virtual void Notify(string name)
            {
                Console.WriteLine($"Notify recieved : {name}");
            }
        }


        public class Email : Notification
        {
            public override void Notify(string name)
            {
                Console.WriteLine($"Email Mesaage: {name}");
            }

        }


        public class Whatsapp : Notification
        {
            public override void Notify(string name)
            {
                Console.WriteLine($"Whatsapp Message: {name}");
            }

        }
    }
}
