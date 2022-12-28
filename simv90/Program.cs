//Скрипников 17 вариант 
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int sBefore = str.IndexOf('$');
            Console.WriteLine($"до него: {sBefore}");
            int sAfter = str.Length - sBefore - 1;
            Console.WriteLine($"после него: {sAfter}");
            Console.ReadLine();
        }
    }