using System.ComponentModel.DataAnnotations;
using System.Threading;

static class Shared
{
    public static object LockObject = new object();
    public static Queue<int> Buffer = new Queue<int>(); // Buffer is empty
    public const int BufferCapacity = 5; // Maximun capacity of the buffer
    public static void Print()
    {
        Console.Write("Buffer: ");
        foreach (int item in Buffer)
        {
            Console.Write($"{item}, ");
        }
        Console.WriteLine();
    } 
}

class Producer
{
    public void Produce()
    {
        Console.WriteLine($"Producer: Generating Data");
        for (int i = 0; i < 10; i++)
        {
            lock(Shared.LockObject)
            {
                Thread.Sleep(7000);
                if (Shared.Buffer.Count == Shared.BufferCapacity)
                {
                    Console.WriteLine("Buffer is full. Waiting for the signal from consumer.");
                    Monitor.Wait(Shared.LockObject);
                }
                Shared.Buffer.Enqueue(i + 1);

                Console.WriteLine($"Producer produce: {i + 1}");
                Shared.Print();
                Monitor.Pulse(Shared.LockObject); // wake up the consumer thread
            }
            
        }      
        Console.WriteLine($"Producer Completed");

    }
}

class Consumer
{
    public void Consume()
    {
        Console.WriteLine($"Consumer: Collecting Data");
        for(int i = 0; i < Shared.BufferCapacity; i++)
        {
            lock (Shared.LockObject)
            {
                if (Shared.Buffer.Count == 0)
                {
                    Console.WriteLine("Buffer is empty. Waiting for the signal from producer");
                    Monitor.Wait(Shared.LockObject);
                }
            }
            Console.WriteLine("Consumer: processing Data");
            Thread.Sleep(2500);

            lock (Shared.LockObject)
            {
                int value = Shared.Buffer.Dequeue();
                Console.WriteLine($"Consumer consumed value: {value}");

                // Signal the producer that there is a space in the buffer
                Monitor.Pulse(Shared.LockObject);
            }
        }

        Console.WriteLine($"Consumer Completed");

    }
}

class Program
{
    static void Main()
    {
        Producer producer = new Producer();

        Consumer consumer = new Consumer();

        // Create objects of Thread class
        Thread producerThread = new Thread(producer.Produce) {
            Name = "Producer Thread"
        };
        Thread consumerThread = new Thread(consumer.Consume)
        {
            Name = "Consumer Thread"
        };

        // Starts threads
        producerThread.Start();
        consumerThread.Start();

        // Join threads 
        producerThread.Join();
        consumerThread.Join();

        Console.ReadKey();
    }
}
