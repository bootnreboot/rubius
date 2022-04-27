while (true)
{
    Console.WriteLine("Введите первое число:"); //ввод первого числа
    var number1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Введите операцию (+ - / * %):"); //ввод операции
    var operation = Console.ReadLine();

    Console.WriteLine("Введите второе число:"); //ввод второго числа
    var number2 = float.Parse(Console.ReadLine());


    switch (operation)
    {
        case "+":
            Console.WriteLine("Результат: " + (number1 + number2));
            Console.WriteLine();
            break;
        case "-":
            Console.WriteLine("Результат: " + (number1 - number2));
            Console.WriteLine();
            break;
        case "/":
            Console.WriteLine("Результат: " + (number1 / number2));
            Console.WriteLine();
            break;
        case "*":
            Console.WriteLine("Результат: " + (number1 * number2));
            Console.WriteLine();
            break;
        case "%":
            Console.WriteLine("Результат: "+ (number1 / number2) * 100);
            Console.WriteLine();
            break;
        default:
            Console.WriteLine("Ошибка! Попробуйте заново.");
            Console.WriteLine();
            break;
    }
}