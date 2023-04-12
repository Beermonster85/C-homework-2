// int t = 6;
// // Канкатинация - выводит зп одну команду строчное и числовое значение

// Console.WriteLine("наше число:" + t);

// //Интерпаляция (так же выводит строчное и цифровое значение)

// Console.WriteLine($"Наше число:{t}");



// Заданиe №1
// Написать программу которая выводит случайное двузначное число из отрезка от {10 - 99 (если мы хотим включительно последнее число, то в формуле указываем +1 ко второму числу)} 
// и показывет наибольшую цифру двузначного числа.
// Например:
// 78 ---> 8
// 95 ---> 9

// int num = new Random().Next(10, 100);
// Console.WriteLine(num);

// int a = num / 10;
// int b = num % 10;

// if (a > b)
// {
//     Console.WriteLine("max:" + a);
// }

// else if (b > a)
// {
//     Console.WriteLine("max:" + b);
// }

// else
// {
//     Console.WriteLine("числа равны");
// }



//Задача №2

//Написать рандомное трехзначное число и удаляет вторую цифру этого числа
//Например:
// 456 ----> 46

//Вариант решения №1
// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// int a = num % 10;
// int b = num / 10;
// int c = b / 10;
// int f = ((c * 10) + a);

// Console.WriteLine(f);

// //Вариант решения №2
// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// int a = num / 100;
// int b = num % 10;

// Console.WriteLine("" + a + b);



//Задача №3

// Написать программу которая принимает на вход 2 числа и выводить
// является ли второе число кратное первому.
// Если второе число не кратное перому то программа выводит остаток от деления.
// Если кратное то пишет "кратно"

// Console.WriteLine("Ввести первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Ввести второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 % number2 == 0)
// {
//     Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine(number1 % number2);
// }


// Задача №4

// Написать проограмму которая принмает на вход число и проверяет кратно ли оно одновременно 7 и 23

// 14 ----> нет
// 161---- да

//Вариант решения №1
// Console.WriteLine("Ввести число");
// int number = Convert.ToInt32(Console.ReadLine());

// if ((number % 7) + (number % 23) == 0)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }

// Вариант решения №2

// Console.WriteLine("Ввести число");
// int number = Convert.ToInt32(Console.ReadLine());

// if ((number % 7 == 0) && (number % 23 == 0))
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }
// Если должны быть выполнены 2 условия то ставится &&
// Если какое то из условий то ставится ||


// Задача №5

//Ввести 2 числа и проверить является ли одно число квадратом другого

Console.WriteLine("Ввести число №1");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввести число №2");
int number2 = Convert.ToInt32(Console.ReadLine());

if ((number1 * number1 == number2) || (number2 * number2 == number1))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}



