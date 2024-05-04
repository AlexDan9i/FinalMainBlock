
//Определение размерности массива
Console.Write("Введите размерность массива строк где 1 - одномерный, 2 - двумерный: ");
int dim = Convert.ToInt32(Console.ReadLine());
if (dim == 1)
{
    // Ввод исходного массива строк с клавиатуры
    Console.WriteLine("Введите элементы массива через пробел:");
    string input = Console.ReadLine();
    string[] originalArray = input.Split(new string[] { " " }, StringSplitOptions.None);


    // Формирование нового массива из строк длиной не более 3 символов
    string[] newArray = FilterArray(originalArray);

    // Вывод нового массива на экран
    Console.WriteLine("Новый массив:");
    Console.WriteLine(string.Join(" ", newArray)); // Выводим элементы нового массива через пробел


    static string[] FilterArray(string[] array)
    {
        // Подсчет количества строк, удовлетворяющих условию
        int count = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива нужной длины
        string[] resultArray = new string[count];

        // Заполнение нового массива подходящими строками
        int index = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        return resultArray;
    }

}
else if (dim == 2)
{
    // Ввод исходного двумерного массива строк с клавиатуры
    Console.WriteLine("Введите элементы двумерного массива (разделяйте строки символом ',' и элементы в строках символом ' '):");
    string input = Console.ReadLine();
    string[][] originalArray = ParseInputArray(input);

    // Формирование нового двумерного массива из строк длиной не более 3 символов
    string[][] newArray = FilterArray(originalArray);

    // Вывод нового двумерного массива на экран
    Console.WriteLine("Новый двумерный массив:");
    foreach (string[] row in newArray)
    {
        Console.WriteLine(string.Join(" ", row));
    }

    static string[][] ParseInputArray(string input)
    {
        string[] rows = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        string[][] array = new string[rows.Length][];

        for (int i = 0; i < rows.Length; i++)
        {
            array[i] = rows[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        return array;
    }

    static string[][] FilterArray(string[][] array)
    {
        // Подсчет количества строк, удовлетворяющих условию
        int rowCount = array.Length;
        int[] columnCounts = new int[rowCount];
        for (int i = 0; i < rowCount; i++)
        {
            int count = 0;
            foreach (string str in array[i])
            {
                if (str.Length <= 3)
                {
                    count++;
                }
            }
            columnCounts[i] = count;
        }

        // Создание нового двумерного массива нужной размерности
        string[][] resultArray = new string[rowCount][];
        for (int i = 0; i < rowCount; i++)
        {
            resultArray[i] = new string[columnCounts[i]];
        }

        // Заполнение нового массива подходящими строками
        for (int i = 0; i < rowCount; i++)
        {
            int index = 0;
            foreach (string str in array[i])
            {
                if (str.Length <= 3)
                {
                    resultArray[i][index] = str;
                    index++;
                }
            }
        }

        return resultArray;
    }
}
else if (dim != 1 || dim != 2)
{
    Console.WriteLine($"Некорректный ввод. Размерность {dim} не поддерживается прокраммой.");
}
