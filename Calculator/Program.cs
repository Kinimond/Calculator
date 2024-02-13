namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            int x = 0;
            string calculation;
            double result = 0;
            char mathing = ' ';

            CalculatorCalc calc = new CalculatorCalc();


            Console.Write("Indtast din første værdi: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Indtast din anden værdi: ");
             y = int.Parse(Console.ReadLine());

            Console.Write("Hvilken operatør vil du benytte? ");
            mathing = char.Parse(Console.ReadLine());   

            switch (mathing)
            {
                case '+':
                    result = calc.Add(x, y);
                    break;
                case '-':
                    result = calc.Subtract(x, y);
                    break;
                case '*':
                    result = calc.Multiply(x, y);
                    break;
                case '/':
                    result = calc.Divide(x, y);
                    break;
                default:
                    break;
            }

            Console.WriteLine("Resultatet er: " + result);
            double divide = calc.Divide(8, 3);
            Console.WriteLine(divide);
        }
    }
}