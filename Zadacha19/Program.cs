// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int digital = Convert.ToInt32(Console.ReadLine());

while (digital >= 10000 && digital <= 100000)
    {
        if((digital/10000 == digital%10) && ((digital/1000)%10 == (digital%100)/10))
            {
                Console.WriteLine("Данное пятизначное число является палиндромом!)");
                break;
            }
        else
            {
                Console.WriteLine("Данное пятизначное число НЕ является палиндромом!)");
                break;
            } 
    }



