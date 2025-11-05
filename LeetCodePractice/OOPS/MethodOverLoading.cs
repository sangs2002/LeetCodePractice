namespace LeetCodePractice.OOPS
{
    public class MethodOverLoading
    {

        public class OrderService
        { 

            public void PlaceOrder(int productid)
            {
                Console.WriteLine(productid);
            }

            public void PlaceOrder(int productid,int shippingid)
            {
                Console.WriteLine(productid + shippingid);
            }

            public void PlaceOrder(List<Product> products)
            {
                Console.WriteLine(products);
            }
        }



        public class Product
        {
            public int id { get; set; }
            public string name { get; set; }

            public string description { get; set; }

            public int price { get; set; }
        }

    }
}
