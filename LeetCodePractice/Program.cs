using LeetCodePractice.LeetCode_Programs;
using LeetCodePractice.OOPS;
using static LeetCodePractice.OOPS.MethodOverLoading;
using static LeetCodePractice.OOPS.MethodOverriding;
using static LeetCodePractice.OOPS.Multi_Level_Inheritance;
using static LeetCodePractice.OOPS.SingleInheritance;

namespace LeetCodePractice
{
    public class Program
    {
        public static void Main(string[] args)
        {

            PaymentMethod paymentMethod = new UPIPayment();
            paymentMethod.Pay(1000);


            Notification notification = new Whatsapp();
            notification.Notify("sangs");

            Notification notification1 = new Notification();
            notification1.Notify("malu");


            OrderService orderService = new OrderService();

            orderService.PlaceOrder(1);


            OrderService orderServices = new OrderService();

            orderService.PlaceOrder(1, 2);



            OrderService orderServices2 = new OrderService();

            orderService.PlaceOrder(new List<Product> { });


            //Single Inheritance
               
            FileLogger filelogger = new FileLogger();
            filelogger.File("While saving the File Failed");

            //Mutilevel Inheritance

            Contactor contactor = new Contactor();
            contactor.ceo("sangs");
            contactor.employee("sangs bro");
            contactor.contactor("sangeeth");

            Easy easy = new Easy();
            easy.ScoreofString("hello");
            easy.LastWord("Hello World");
            easy.reverse("zaza");
           
        }
    }
}
