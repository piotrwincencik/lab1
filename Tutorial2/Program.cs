using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Object obiekt1 = new Object(5);
            Object obiekt2 = new Object(10);




            Console.WriteLine(obiekt1.ShowObjectLenght());

            Console.WriteLine("Wpisz liczbe przez jaką chcesz pomnożyć długość:");
            Console.WriteLine("Wynik to: " + Math.Multiplication(obiekt1.Lenght, int.Parse(Console.ReadLine())));

            Console.WriteLine("Wpisz liczbe przez jaką chcesz podzielić długość:");
            Console.WriteLine("Wynik to: " + Math.Division(obiekt1.Lenght, int.Parse(Console.ReadLine())));

            Console.WriteLine("Wpisz liczbe, którą chcesz dodać do długości:");
            Console.WriteLine("Wynik to: " + Math.Addition(obiekt1.Lenght, int.Parse(Console.ReadLine())));

        }
    }
    class Object
    {
        public int Lenght { get; set; }

        public int sum { get; set; }

        public Object(int lenght)
        {
            this.Lenght = lenght;
        }

        public Object()
        {
            Lenght = 0;
        }

        new public string ShowObjectLenght()
        {
            return "Długość obiektu wynosi:" + Lenght;
        }

    }
    
    class Math
    {
        public static int sum { get; set; }
      
        public static int div { get; set; }

        public static int Division(int a, int b)
        {
            div = a / b;

            return div;
        }

        public static int Multiplication(int a, int b)
        {
            div = a * b;

            return div;
        }

        public static int Addition(int lenght, int b)
        {
            sum = b + lenght;

            return sum;
        }
    }
}
