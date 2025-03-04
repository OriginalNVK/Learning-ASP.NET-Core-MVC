using System.Threading;
class Shared
{
    public static int[] Data { get; set; }

    public static int BatchCount { get; set; }

    public static int BatchSize { get; set; }

    public static ManualResetEvent Event { get; set; }

    static Shared(){
        Data = new int[15];
        BatchCount = 5;
        Event = new ManualResetEvent(false); // Unsignaled (false)
        BatchSize = 3;
    }
}

//Represent producer thread
class Producer
{
    public  void Produce()
    {
        Console.WriteLine($"{Thread.CurrentThread.Name} started");

        //Generate some data and store it in Data array
        for (int i = 0; i < Shared.BatchCount; i++)
        {
            for (int j = 0; j < Shared.BatchSize; j++)
            {
                Shared.Data[i*Shared.BatchSize + j] = i * Shared.BatchSize + j + 1;
                Thread.Sleep(300);// simular artificial latency (delay)
            }
            // Set the signal to true
            Shared.Event.Set();

            Shared.Event.Reset();
        }

        Console.WriteLine($"{Thread.CurrentThread.Name} completed");
    }
}

//Represent cusumer thread
class Consumer
{
    public void Consume()
    {
        Console.WriteLine($"{Thread.CurrentThread.Name} started");
        Console.WriteLine("Consumer is waiting for producer thread to finish generating data");
        // wait
        
        for(int i = 0; i < Shared.BatchCount; i++)
        {
            Shared.Event.WaitOne(); //Consumer thread wait until the status of event becomes signaled
            Console.WriteLine("Consumer has received a signal from the Producer");
            // read Data
            Console.WriteLine("\n Data is: ");
            for (int j = 0; j < Shared.BatchSize; j++)
            {
                Console.WriteLine($"{Shared.Data[i * Shared.BatchSize + j]}");
            }
            //Thread.Sleep(1000);
        }
        

        Console.WriteLine($"{Thread.CurrentThread.Name} completed");
    }
}

class Program
{
    static void Main()
    {
        // Create object producer and consumer
        Producer producer = new Producer();
        Consumer consumer = new Consumer();

        // Create delegate object of ThreadStart
        ThreadStart threadStart1 = new ThreadStart(producer.Produce);

        ThreadStart threadStart2 = new ThreadStart(consumer.Consume);

        // create thread object
        Thread producerThread = new Thread(threadStart1)
        {
            Name = "Producer Thread"
        };
        Thread consumerThread = new Thread(threadStart2)
        {
            Name = "Consumer Thread"
        };

        //Start threads
        producerThread.Start();
        consumerThread.Start();

        // Join both thread
        producerThread.Join();
        consumerThread.Join();

        Console.ReadKey();
    }
}