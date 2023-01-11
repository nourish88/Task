////using System;
////using System.Threading;


////namespace Problems.Breakfast
////{
////    class Program
////    {
////        // Task: rewrite the code to reduce the time of breakfast making

////        static void Main(string[] args)
////        {
////            var start = DateTime.Now;

////            Cook();

////            Console.WriteLine($"Time spent: {DateTime.Now.Subtract(start).TotalSeconds}s");
////        }

////        public   static void Cook()
////        {
////            Console.WriteLine("Starting cooking sync-ly.");

////            Coffee cup = PourCoffee(); // 1s
////            Console.WriteLine("coffee is ready");

////            EggPack eggs = FryEggs(2); // 6s
////            Console.WriteLine("eggs are ready");

////            BaconPack bacon = FryBacon(3); // 6s
////            Console.WriteLine("bacon is ready");

////            ServeBreakfast(cup, eggs, bacon);
////        }

////        private static void ServeBreakfast(Coffee cup, EggPack eggs, BaconPack bacon)
////        {
////            Console.WriteLine("Breakfast is ready!");
////        }

////        private   static Coffee PourCoffee()
////        {
////            Console.WriteLine("Pouring coffee");
////            Thread.Sleep(1000);
////            return new Coffee();
////        }

////        private static BaconPack FryBacon(int slices)
////        {
////            Console.WriteLine("Warming the pan...");
////            Console.WriteLine($"putting {slices} slices of bacon in the pan");

////            Console.WriteLine("cooking first side of bacon...");
////            Thread.Sleep(3000);
////            for (int slice = 0; slice < slices; slice++)
////            {
////                Console.WriteLine("flipping a slice of bacon");
////            }
////            Console.WriteLine("cooking the second side of bacon...");
////            Thread.Sleep(3000);
////            Console.WriteLine("Put bacon on plate");

////            return new BaconPack();
////        }

////        private static EggPack FryEggs(int howMany)
////        {
////            Console.WriteLine("Warming the pan...");
////            Thread.Sleep(3000);
////            Console.WriteLine($"cracking {howMany} eggs");
////            Console.WriteLine("cooking the eggs ...");
////            Thread.Sleep(2000);
////            Console.WriteLine("Put eggs on plate");

////            return new EggPack();
////        }

////    }
////    public class Coffee { }

////    public class BaconPack
////    {
////        private List<Bacon> _list = new List<Bacon>();
////    }
////    public class Bacon { }

////    public class EggPack
////    {
////        private List<Egg> _list = new List<Egg>();
////    }
////    public class Egg { }

////    public class PowerIsMissingException : ApplicationException { }

////}
//using System;
//using System.Threading;


//namespace Problems.Breakfast
//{
//    class Program
//    {
//        // Task: rewrite the code to reduce the time of breakfast making

//        static void Main(string[] args)
//        {
//            var start = DateTime.Now;

//            Cook().Wait();

//            Console.WriteLine($"Time spent: {DateTime.Now.Subtract(start).TotalSeconds}s");
//        }

//        public static async Task Cook()
//        {
//            Console.WriteLine("Starting cooking sync-ly.");



//            var cupTask = Task.Run(() => PourCoffee()); // 1s


//            var eggsTask = Task.Run(() => FryEggs(2)); // 6s


//            var baconTask = Task.Run(() => FryBacon(3)); // 6s

//            await Task.WhenAll(cupTask, eggsTask, baconTask);
//            var cup = await cupTask;
//            Console.WriteLine("coffee is ready");
//            var eggs = await eggsTask;
//            Console.WriteLine("eggs are ready");
//            var bacon = await baconTask;
//            Console.WriteLine("bacon is ready");
//            ServeBreakfast(cup, eggs, bacon);
//        }

//        private static void ServeBreakfast(Coffee cup, EggPack eggs, BaconPack bacon)
//        {
//            Console.WriteLine("Breakfast is ready!");
//        }

//        private static Coffee PourCoffee()
//        {
//            Console.WriteLine("Pouring coffee");
//            Thread.Sleep(1000);
//            return new Coffee();
//        }

//        private static BaconPack FryBacon(int slices)
//        {
//            Console.WriteLine("Warming the pan...");
//            Console.WriteLine($"putting {slices} slices of bacon in the pan");

//            Console.WriteLine("cooking first side of bacon...");
//            Thread.Sleep(3000);
//            for (int slice = 0; slice < slices; slice++)
//            {
//                Console.WriteLine("flipping a slice of bacon");
//            }
//            Console.WriteLine("cooking the second side of bacon...");
//            Thread.Sleep(3000);
//            Console.WriteLine("Put bacon on plate");

//            return new BaconPack();
//        }

//        private static EggPack FryEggs(int howMany)
//        {
//            Console.WriteLine("Warming the pan...");
//            Thread.Sleep(3000);
//            Console.WriteLine($"cracking {howMany} eggs");
//            Console.WriteLine("cooking the eggs ...");
//            Thread.Sleep(2000);
//            Console.WriteLine("Put eggs on plate");

//            return new EggPack();
//        }

//    }
//    public class Coffee { }

//    public class BaconPack
//    {
//        private List<Bacon> _list = new List<Bacon>();
//    }
//    public class Bacon { }

//    public class EggPack
//    {
//        private List<Egg> _list = new List<Egg>();
//    }
//    public class Egg { }

//    public class PowerIsMissingException : ApplicationException { }

//}
//using System.Collections.Generic;
//using System.Linq;
//using System;
//namespace Problems.LINQ
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            var apple = new Product { Name = "Apple" };
//            var apricot = new Product { Name = "Apricot" };
//            var orange = new Product { Name = "Orange" };
//            var bread = new Product { Name = "Bread" };
//            var products = new[] { apple, orange, apricot, bread };
//            var customers = new[] {
//        new Customer { Name = "Alexey", Orders = new[] { new Order { Product = apple, Quantity = 10 },
//                                                         new Order { Product = orange, Quantity = 5 } }.ToList() },
//        new Customer { Name = "Paul", Orders = new[] { new Order { Product = bread, Quantity = 5 },
//                                                         new Order { Product = orange, Quantity = 2 } }.ToList() },
//        new Customer { Name = "Enoch", Orders = new[] { new Order { Product = apple, Quantity = 10 } }.ToList() }
//        }.ToList();

//            var result = customers.Select(q => new
//            {
//                Name=q.Name,
//                Orders= string.Join(",", q.Orders.Select(q => q.Product.Name).ToList())

//            }).OrderBy(x=>x.Name).ToList();
                

//            Console.WriteLine(result);

//            // list names of products starting with 'A'
//            // Print list of customers sorted by name with the names of the bought products e.g.
//            // Enoch: Apple
//            // Paul: Bread, Orange
//        }
//    }
//    public class Customer
//    {
//        public string Name { get; set; }
//        public List<Order> Orders { get; set; }
//    }
//    public class Order
//    {
//        public Product Product { get; set; }
//        public int Quantity { get; set; }
//    }
//    public class Product
//    {
//        public string Name { get; set; }
//    }
    
//}