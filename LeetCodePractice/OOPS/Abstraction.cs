namespace LeetCodePractice.OOPS
{
    public class Abstraction
    {

        public abstract class Payment () 
        {

            public abstract void pay(decimal message);

            public void paymentmessage(string message)
            {
                Console.WriteLine($"Payment Done message {message}");

            }
        
        }

        public class Paypal : Payment
        {
            public override void pay(decimal message)
            {
                Console.WriteLine($"Paypal payment Done and the Amount is {message}");
            }
        }

        public class Card : Payment
        {
            public override void pay(decimal message)
            {
                Console.WriteLine($"Card payment is Done and the Amount is {message}");
            }
        }

    }
}
