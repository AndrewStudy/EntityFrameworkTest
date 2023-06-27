using EntityFrameworkTest.Models;

namespace EntityFrameworkTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (var context = new Context())
            //{
            //    var deal1 = new Deal()
            //    {
            //        IdClient = 1,
            //        IdService = 1,
            //        Sum = "500",
            //        Commission = "50",
            //        Description = "Test"              
            //    };

            //    context.Deals.Add(deal1);
            //    context.SaveChanges();
            //}

            using (var context = new Context())
            {
                var deals = context.Deals;

                foreach (var deal in deals)
                {
                    Console.WriteLine($"{deal}");
                }
            }

        }
    }
}