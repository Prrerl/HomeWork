namespace CSharpLessons
{
    class Program
    {
        private static void Task_1()
        {

            //Напишите программу, которая принимает на вход трёхзначное число.
            //А на выходе показывает вторую цифру этого числа.

            Console.WriteLine("Введите трехзначное число");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второй цифрой числа будет: ");
            Console.WriteLine (A % 100 / 10);
        }

        private static void Task_2()
        {

            //Напишите программу, которая выводит третью цифру заданного числа.
            //Либо сообщает, что третьей цифры нет.

            Console.WriteLine("Введите трехзначное число: ");
            int A;
            do
            {
                A = Convert.ToInt32(Console.ReadLine());
                if ((int)(A / 100) > 0 && A / 100 < 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели не трехзначное число, попробуйте вновь: ");
                }
            }
            while (true);
            Console.WriteLine(A % 10);
        } 

        private static void Task_3()
        {

            //Напишите программу, которая принимает на вход цифру, обозначающую 
            //день недели, и проверяет, является ли этот день выходным.

            Boolean IsOutOfLoop = true;
            do
            {
                IsOutOfLoop = true;
                Console.WriteLine("Введите день недели числом: ");
                int A = Convert.ToInt32(Console.ReadLine());
                switch (A)
                {
                    case 1:
                        Console.WriteLine("Понедельник – Не выходной");
                        break;
                    case 2:
                        Console.WriteLine("Вторник – Не выходной");
                        break;
                    case 3:
                        Console.WriteLine("Среда – Не выходной");
                        break;
                    case 4:
                        Console.WriteLine("Четверг – Не выходной");
                        break;
                    case 5:
                        Console.WriteLine("Пятница – Не выходной");
                        break;
                    case 6:
                        Console.WriteLine("Суббота – Выходной");
                        break;
                    case 7:
                        Console.WriteLine("Воскресенье – Выходной");
                        break;
                    default:
                        Console.WriteLine("В неделе семь дней. Попробуйте еще раз! ");
                        IsOutOfLoop = false;
                        break;
                }
            } while (!IsOutOfLoop);
        }

        private static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            int NumberOfTask = Convert.ToInt32(Console.ReadLine());
            switch(NumberOfTask) 
            {
            case 1:
                Task_1();
            break;
            case 2:
                Task_2();
            break;
            case 3:
                Task_3();
            break;
            default:
                Console.Write("Задачи с таким номером нет!");
            break;
            }
        }
    }
}
