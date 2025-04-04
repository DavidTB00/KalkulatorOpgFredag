namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bruker double for desimaltall
            double num1 = 0;
            double num2 = 0;
            double sum = 0;

            Console.WriteLine("Kalkulator!");

            Console.WriteLine("Skriv inn ett tall:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Skriv inn enda ett tall:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hva vil du gjøre?");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            Console.WriteLine("%");


            switch(Console.ReadLine())
            {
                case "+":
                    sum = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = " + sum);
                    break;
                case "-":
                    sum = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = " + sum);
                    break;
                case "*":
                    sum = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = " + sum);
                    break;
                case "/":
                    sum = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = " + sum);
                    break;
                case "%":
                    sum = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = " + sum);
                    break;
            }


            Console.ReadKey();
        }
    }
}
