bool isWork = true;

while(isWork)

{
    Console.WriteLine("Для завершения работы введите: -1");
    Console.Write("Введите номер задачи ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {
            case 1:
            {
                Console.Write("Введите трёхзначное число: ");
                int.TryParse(Console.ReadLine(), out int num);
                if (num > 99 && num < 1000)
                {
                    int result = num / 10 % 10;
                    Console.WriteLine($"вторая цифра {result}");
                }
                else Console.WriteLine("не трёхзначное число");
                break; 
            }
            case 2:
            {
                Console.Write("Введите число: ");
                int.TryParse(Console.ReadLine(), out int num);
                if (num > 99)
                {
                    int digitindex = 2;
                    int digit = num.ToString()[digitindex] - '0';
                    Console.WriteLine($"третья цифра - {digit}");
                }
                else Console.WriteLine("третьей цифры нет");
                break;
            }
            case 3:
            {
                string[] days = new String[]{"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
                Console.Write("Введите число: ");
                int.TryParse(Console.ReadLine(), out int day);
                if (day == 6 || day == 7)
                {
                    Console.WriteLine($"да, {days[day - 1]} выходной");
                }
                else Console.WriteLine($"нет, {days[day - 1]} не выходной");

                break;
            }

            case -1: isWork = false; break;
        }
    }
}