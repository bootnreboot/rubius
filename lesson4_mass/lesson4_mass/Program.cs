while (true)
{
    Console.WriteLine("Введите размер массива:");
    try
    {
        var index = Convert.ToInt32(Console.ReadLine());
        var array = new int[index];

        Console.WriteLine("Введите содержимое массива:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(array);
        Console.WriteLine("Второй наибольший элемент в массиве:");
        Console.WriteLine(array[^2]);
    }
    catch (FormatException)
    {
        Console.WriteLine("Ошибка! Нельзя вводить буквы, дроби и ничего.");
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Ошибка! Размер массива должен быть больше 1");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Ошибка! Размер массива должен быть больше 1");
    }
    finally
    {
        Console.WriteLine("Перезапуск программы.");
        Console.WriteLine("");
    }
}