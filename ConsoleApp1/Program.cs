namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            persona x = new persona("giuseppe", "Garibaldi",26);
            Console.WriteLine(x.getNome());
            Console.WriteLine(x.getCognome());
            Console.WriteLine(x.getEta());
            Console.WriteLine(x.GetDettagli());

        }
    }
}
