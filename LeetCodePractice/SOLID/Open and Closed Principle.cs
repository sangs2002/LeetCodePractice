namespace LeetCodePractice.SOLID
{
    public class Open_and_Closed_Principle
    {


        //VOILATES OCP AND SRP
        //public class PaymentProcess
        //{
        //    public PaymentProcess(string method, string paymenttype)
        //    {

        //        if (method == "Debit")
        //        {
        //            Console.WriteLine("DEBIT");
        //        }
        //        else if(method == "credit")
        //        {
        //            Console.WriteLine("CREDIT");
        //        }
        //        else if (method == "UPI")
        //        {
        //            Console.WriteLine("UPI");
        //        }

        //    }
        //}


        public interface PaymentProcessor
        {
            void Process(string method);
        }


        public class CreditCard : PaymentProcessor
        {
            public void Process(string method)
            {
                Console.WriteLine("CREDIT");
            }
        }

        public class Debit : PaymentProcessor
        {
            public void Process(string method)  
            {
                Console.WriteLine("Debit");
            }
        }

        public class UPI : PaymentProcessor
        {
            public void Process(string method)
            {
                Console.WriteLine("UPI");
            }
        }
    }
}
