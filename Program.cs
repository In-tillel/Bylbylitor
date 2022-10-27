namespace Бульбулятор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Сложить два числа");
            Console.WriteLine("2. Вычесть");
            Console.WriteLine("3. Умножить");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");
            while (true)
            {
                double a;
                double b;
                double n;
                double r;
                double oper;
                char numb;

                Console.WriteLine("Выберите действие: ");
                numb = Convert.ToChar(Console.ReadLine());
                if (numb == '9')
                {
                    Environment.Exit(0);
                }

                Console.WriteLine("Введите первое число: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                b = Convert.ToDouble(Console.ReadLine());

                if (numb == '1')
                {
                    oper = a + b;
                    Console.WriteLine(oper);
                }
                else if (numb == '2')
                {
                    oper = a - b;
                    Console.WriteLine(oper);
                }
                else if (numb == '3')
                {
                    oper = a * b;
                    Console.WriteLine(oper);
                }
                else if (numb == '4')
                {
                    oper = a / b;
                    Console.WriteLine(oper);
                }
                else if (numb == '5')
                {
                   Console.WriteLine("Введите стпень N: ");
                   n = Convert.ToDouble(Console.ReadLine());
                    r = 1;
                   for (int i = 1; i <= n; i++)    
                   {
                        r *= a;
                        
                   }
                    Console.WriteLine(r);
                }
                else if (numb == '6')
                {
                    Console.WriteLine(Math.Sqrt(a));
                }
                else if (numb == '7')
                {
                    oper = a / 100;
                    Console.WriteLine(oper);
                }
                else if (numb == '8')
                {
                    void factorial(int fact)
                    {
                        int j = fact;
                        long k = 1;
                        if (fact == 0)
                            Console.WriteLine(1);
                        else
                        {
                            for(int f = 1; f <= j;f++)
                            {
                                k *= f;
                            }
                        }
                        Console.WriteLine(k);
                    }
                    factorial((int)Convert.ToDouble(a));
                }
            }
        }
    }
}