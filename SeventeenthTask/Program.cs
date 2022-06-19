using System;

namespace SeventeenthTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal principal = 0M;
            decimal interest = 0M;
            decimal duration = 0M;
            InputInterestData(ref principal, ref interest, ref duration);

            Console.WriteLine();
            Console.WriteLine("Вклад = " + principal);
            Console.WriteLine("Процентная Ставка = " + interest + "%");
            Console.WriteLine("Срок = " + duration + " Лет");
            Console.WriteLine();
            OutputInterestTable(principal, interest, duration);
            Console.WriteLine("Нажмите <Enter> Для Завершения Программы . . .");
            Console.Read();
        }
        public static void InputInterestData(ref decimal principal ,ref decimal interest ,ref decimal duration)
        {
            principal = InputPositiveDecimal("Вклaд");
            interest = InputPositiveDecimal("Процентная Ставка");
            duration = InputPositiveDecimal("Срок");
        }
        public static decimal InputPositiveDecimal(string prompt)
        {
            while (true)
            {
                Console.Write("Введите " + prompt + ": ");
                string input = Console.ReadLine();
                decimal value = Convert.ToDecimal(input);
                if (value >= 0)
                {
                    return value;
                }
                Console.WriteLine(prompt + "Не Может Иметь Отрицательного Значения");
                Console.WriteLine("Попробуйте еще раз");
                Console.WriteLine();
            }
        }
        public static void OutputInterestTable(decimal principal, decimal interest, decimal duration)
        {
            for(int year = 1; year <= duration; year++)
            {
                decimal interestPaid;
                interestPaid = principal * (interest / 100);
                principal = principal + interestPaid;
                principal = decimal.Round(principal, 2);
                Console.WriteLine(year + "-" + principal);  

            }
        }
    }
}
