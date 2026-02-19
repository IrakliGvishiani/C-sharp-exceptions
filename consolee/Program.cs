using System.Text.Json;

namespace consolee
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  string jsonPath = @"../../../orders.json";


          //  string jsonData = File.ReadAllText(jsonPath);
          //  var orders = JsonSerializer.Deserialize<Queue<Order>>(jsonData);
          //  var ordered =  ReturnNextOrder(orders);
          //foreach (var order in ordered)
          //  {
          //      Console.WriteLine($"Order Name: {order.name}, Completed Date: {order.completedDate}");
          //  }








            //Dictionary<string , decimal> userBlance = new Dictionary<string , decimal>();


            string text = "apple banana appe banana banana";
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            string[] words = text.Split(' ',StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount.Add(word, 1);
                }
            }
        }





        //private static Queue<Order> ReturnNextOrder(Queue<Order> orders)
        //{
        //    Queue<Order> sortedOrder = new Queue<Order>();


        //    while (orders.Count > 0)
        //    {
        //        Order earliest = orders.Peek();
        //        int count = orders.Count;

        //        for (int i = 0; i < count; i++)
        //        {
        //            Order current = orders.Dequeue();

        //            if (current.completedDate < earliest.completedDate)
        //                earliest = current;

        //            orders.Enqueue(current);
        //        }

              
        //        for (int i = 0; i < count; i++)
        //        {
        //            Order current = orders.Dequeue();
        //            if ( current.completedDate == earliest.completedDate)
        //            {
        //                sortedOrder.Enqueue(current);
                        
        //            }
        //            else
        //            {
        //                orders.Enqueue(current);
        //            }
        //        }
        //    }


        //    return sortedOrder;
        //}
    }
}


   

