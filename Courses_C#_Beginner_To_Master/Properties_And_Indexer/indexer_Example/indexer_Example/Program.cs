class Program
{
    static void Main()
    {
        car c = new car();
        // Call get accessor of indexer
        System.Console.WriteLine(c[0]);
        System.Console.WriteLine(c["first"]);


        // Call set accessor of indexer
        c[0] = "Nissan";
        System.Console.WriteLine(c[0]);
        System.Console.ReadKey();
    }
}