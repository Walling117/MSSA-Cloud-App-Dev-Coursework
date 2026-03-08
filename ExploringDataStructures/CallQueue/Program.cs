namespace CallQueue
{
    internal class Program
    {
        public static void EnQueueMenu(MyQ queue)
        {
            long id;
            string name;
            Console.Clear();
            Console.WriteLine("Current waiting list: ");
            queue.Print();


            Console.Write("Please enter the Customer ID: ");
            while(!long.TryParse(Console.ReadLine(), out id));
            Console.Write("\nName: ");
            name = Console.ReadLine();
            Console.WriteLine("\n\n\nNew Waiting list");
            queue.Enqueue(new Customer(id,name));
            queue.Print();
            Console.ReadKey();
        }
        public static void DequeueMenu(MyQ queue)
        {
            Console.Clear();
            Node<Customer> dequeed;
            Console.WriteLine("Current waiting list:");
            queue.Print();
            Console.WriteLine("\n\nAfter Dequeue: ");
            queue.Dequeue();
            queue.Print();
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            MyQ queue = new MyQ();
            queue.Enqueue(new Customer(12,"Andy Ben"));
            queue.Enqueue(new Customer(40,"Andrew Walling"));
            queue.Enqueue(new Customer(89,"Lucas Anthony"));
            queue.Enqueue(new Customer(78,"Robert Lathon"));
            queue.Enqueue(new Customer(26,"Jen Bronks"));
            queue.Enqueue(new Customer(99,"Emma Taysons"));
            queue.Enqueue(new Customer(100,"Luke Hodge"));
            queue.Enqueue(new Customer(199,"James Luke"));
            queue.Enqueue(new Customer(4558,"Tylor Jason"));
            queue.Enqueue(new Customer(1,"Ben Bricks"));
            bool doRepeat = true;
            while (doRepeat) 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1.Answer call (Dequeue)\n2.Make a call (Enqueue)\n");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    
                    case "1": 
                        DequeueMenu(queue);
                        break;
                    case "2":
                        EnQueueMenu(queue);
                        break;
                }


            }

        }
    }
}
