//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//int sumSegment(int start, int end)
//{
//    int sum = 0;
//    for(int i = start; i < end; i++)
//    {
//        Thread.Sleep(100);
//        sum += array[i];
//    }
//    return sum;
//}

//int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;

//var startTime = DateTime.Now;

//int numOfThread = 4;
//int Segment = array.Length/numOfThread;

//Thread[] threads = new Thread[numOfThread];

//threads[0] = new Thread(() => sum1 = sumSegment(0, Segment));
//threads[1] = new Thread(() => sum2 = sumSegment(Segment, 2*Segment));
//threads[2] = new Thread(() => sum3 = sumSegment(2*Segment, 3 * Segment));
//threads[3] = new Thread(() => sum4 = sumSegment(3*Segment, array.Length));

//foreach(var thread in threads)
//{
//    thread.Start();
//}

//foreach (var thread in threads)
//{
//    thread.Join();
//}

//var endTime = DateTime.Now; 
//var timeSpan = endTime - startTime;

//Console.WriteLine($"Sum of the array is {sum1 + sum2 + sum3 + sum4}");
//Console.WriteLine($"Time it takes: {timeSpan.TotalMilliseconds}");

#region Bài 1 Tạo và chạy nhiều thread đơn giản
//for (int i = 0; i < 3; i++)
//{
//    Thread thread = new Thread(() => Console.WriteLine($"Hello from thread {i + 1}"));
//    thread.Start();
//    Thread.Sleep(1000);
//}
#endregion

#region Bài 2 Sử dụng join để đảm bảo thứ tự thực thi
//Thread threadA = new Thread(() => Console.WriteLine("thread A start"));

//Thread threadB = new Thread(() => Console.WriteLine("Thread B Start"));

//threadA.Start();

//Thread.Sleep(2000);
//Console.WriteLine("Thread A finished");
//threadA.Join();
//threadB.Start();
//Thread.Sleep(2000);
//threadB.Join();
//Console.WriteLine("Thread B finished");
#endregion

#region Bài 3 Điều chỉnh độ ưu tiên của thread
//void count()
//{
//    for(int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine(i);
//        Thread.Sleep(1000); 
//    }    
//}

//void count2()
//{
//    for(int i = 10; i >= 1; i--)
//    {
//        Console.WriteLine(i);
//        Thread.Sleep(1000);
//    }
//}

//Thread threadA = new Thread(count);

//Thread threadB = new Thread(count2);

//threadA.Priority = ThreadPriority.Lowest;
//threadB.Priority = ThreadPriority.Highest;
//threadA.Start();
//threadA.Join();
//threadB.Start();
#endregion

#region Bài 4 Sử dụng interrupt() để dừng một thread dang ngủ
//void process()
//{

//    while (true)
//    {
//        Thread threadA = new Thread(() => Console.WriteLine("Processing...."));
//        threadA.Start();
//        Thread.Sleep(1000);
//    }
//}

//Thread thread2 = new Thread(process);
//try
//{
//    while (true)
//    {
//        thread2.Start();
//        Thread.Sleep(5000);
//    }
//}
//catch (ThreadInterruptedException e)
//{
//    Console.Error.WriteLine(e.Message);
//}

//thread2.Interrupt();
#endregion

#region Bài 5 Đua xe

#endregion

#region Thread State
//void run()
//{
//    Console.WriteLine("Threading is running....");
//    Thread.Sleep(500);
//}

//Thread t = new Thread(run);
//Console.WriteLine($"Thread state before starting: {t.ThreadState}");

//t.Start();
//Console.WriteLine($"Thread state after starting: {t.ThreadState}");

//t.Join();
//Console.WriteLine($"Thread state after finish: {t.ThreadState}");
#endregion

#region Thread Parameter
//void PrintMessage(object Message)
//{
//    Console.WriteLine(Message);
//}

//Thread t = new Thread(new ParameterizedThreadStart(PrintMessage));

//t.Start("Hello C#");
#endregion

#region Custom Thread Object
//public class Worker
//{
//    private string message;

//    public Worker(string msg) => this.message = msg;

//    public void run()
//    {
//        Console.WriteLine($"Worker said: {this.message}");
//    }
//}

//class programing {
//    static void Main()
//    {
//        Worker worker = new Worker("I'm working");
//        Thread t = new Thread(worker.run);
//        t.Start();
//    }
//}
#endregion

#region Callback in Thread

//void LongRunningTask(Action callback)
//{
//    Console.WriteLine("Thread is working....");
//    Thread.Sleep(1000);
//    callback();
//}

//void TaskComplete()
//{
//    Console.WriteLine("Task is finished...");
//}

//Thread t = new Thread(() => LongRunningTask(TaskComplete));
//t.Start();
#endregion

#region Shared Resource in Thread
int counter = 0;

void Increment()
{
    for (int i = 0; i < 100; i++)
    {
        counter++;
    }
}

Thread t1 = new Thread(Increment);
Thread t2 = new Thread(Increment);

t1.Start();
t2.Start();

t1.Join();
t2.Join();

Console.WriteLine($"Final counter is: {counter}");

#endregion