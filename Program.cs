using System;

namespace Connection1
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanCon humanCon = new HumanCon();

            for (int i = 1; i < 10; ++i)
            {
                humanCon.InsertParm
                    (new Human
                    { ID = 1, Name = "Alexandra" + i, Age = 21, LastName = "Mangasaryan" + i });
                Console.WriteLine($"ResultText for Human {i}: {humanCon.ResultText}");
            }
        }
    }
}
