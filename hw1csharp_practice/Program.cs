while (true)
{
    Console.WriteLine("Введите номер задания 1-7");

    int number = int.Parse(Console.ReadLine());
    switch (number) {
        case 1:
            {
                // 1) Ввести три целых числа, вывести их сумму и произведение
                Console.WriteLine("Введите три целых числа через Enter");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int sum = a + b + c;
                int mult = a * b * c;
                Console.WriteLine($"Сумма чисел: {sum}");
                Console.WriteLine($"Произведение чисел: {mult}");
                break;

               
            }
        case 2: 
            {
                // 2) Ввести двузначное число, поменять его цифры местами
                Console.WriteLine("Введите одно ДВУЗНАЧНОЕ число");
                int a2 = int.Parse(Console.ReadLine());
                if (a2 < 0)
                {
                    Console.WriteLine($"Если поменять цифры местами то получится: {(a2 % 10)}{(a2 / 10) * -1}");
                }
                else Console.WriteLine($"Если поменять цифры местами то получится: {a2 % 10}{a2 / 10}");
                break;
            }
        case 3: 
            {   // 3) Найти гипотенузу прямоуглольного треугольника по двум катетам
                Console.WriteLine("Введите длину двух катетов треугольника через Enter");
                double a3 = double.Parse(Console.ReadLine());
                double b3 = double.Parse(Console.ReadLine());
                double c3 = Math.Pow((a3 * a3 + b3 * b3),(1.0/2));
                Console.WriteLine($" Гипотенуза = {c3}");
                break;
            }
        case 4:
            {
                // 4) Найти ребро кубо объем которого равен v
                Console.WriteLine("Введите объем куба: ");
                double v = double.Parse(Console.ReadLine());
                double c4 = Math.Pow(v, (1.0 / 3));
                Console.WriteLine( $"Ребра куба = {c4}");
                break;
            }
        case 5:
            {   // Вывести кол-во дней в месяце в зависимоти от его номера ( в феврале 28 дней)
                Console.WriteLine("Введите номер  месяца:");
                int a5 = int.Parse(Console.ReadLine());
                if (a5 == 1) Console.WriteLine("В этом месяце 31 день");
                else if (a5 == 2) Console.WriteLine("В этом месяце 28 дней");
                else a5 = a5 % 2;
                    switch (a5)
                    {
                        case 0:
                            {
                                Console.WriteLine("В этом месяце 30 дней");
                                break;
                            }
                        case 1:
                            {
                                Console.WriteLine("В этом месяце 31 день");
                                break;
                            }


                    }
                break;
            }
        case 6: 
            {
                // Стоимость билета в зависимости от возраста
                int price = 200;
                Console.WriteLine("Введите возсраст:");
                int a6 = int.Parse(Console.ReadLine());
                if (a6 <= 7 && a6 >= 0) Console.WriteLine("Стоимость билета: бесплатно");
                else if (a6 <= 18 && a6 > 0) Console.WriteLine($"Стоимость билета: {price / 2}");
                else if (a6 <= 60 && a6 > 0) Console.WriteLine($"Стоимость билета: {price}");
                else if (a6 > 60 && a6 > 0) Console.WriteLine($"Стоимость билета: {price / 2}");
                else Console.WriteLine("Такого не бывает, досвидания!");
                break;
            }



        case 7:
            { //проверка существования треугольника , а также проверка на то, является ли он прямоугольным
                Console.WriteLine("Введите три стороны треугольника через Enter");
                int a7 = int.Parse(Console.ReadLine());
                int b7 = int.Parse(Console.ReadLine());
                int c7 = int.Parse(Console.ReadLine());

                if ((a7 * a7 + b7 * b7) == (c7 * c7) || 
                    (c7 * c7 + b7 * b7) == (a7 * a7) ||
                    (a7 * a7 + c7 * b7) == (b7 * b7)) 
                    Console.WriteLine("Треугольник существует и он прямоугольный");

                else if ((a7 + b7) > c7 && 
                        (a7 + c7) > b7 && 
                        (c7 + b7) > a7)
                        Console.WriteLine("Треугольник существует");

                
                else Console.WriteLine("Треугольник не существует");
                break;
            }
    }   
}



/*Console.WriteLine("Введите возсраст:");
int a66 = int.Parse(Console.ReadLine());

string q = a66 switch
{
    < 0 =>"Возраст не может быть отрицательлным",
    < 7 =>"билет бесплатный",
    < 18 => "половина стоимости",
    < 60 => "билет бесплатный",
    _ => "Половина стоимости"

};
Другой вариант решения для задания 6 */
