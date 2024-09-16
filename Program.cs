Random random = new Random();
int n = 90; // Размер массива

// Создаем массив случайных чисел от 1 до 5 без использования цикла
int[] nums = Enumerable.Range(0, n).Select( int_=> random.Next(1, 4)).ToArray();// Генерация чисел от 1 до 5
int count = 0;
int candidate = 0;
Console.WriteLine("Сгенерированный массив:");
Console.WriteLine(string.Join(", ", nums));

// Первый проход: определяем кандидата
foreach (int num in nums)
{
    if (count == 0)
    {
        candidate = num;
        count = 1;
    }
    else if (num == candidate)
    {
        count++;
    }
    else
    {
        count--;
    }
}

// Второй проход: проверяем, является ли кандидат мажоритарным
count = 0;
foreach (int num in nums)
{
    if (num == candidate)
    {
        count++;
    }
}

// Вывод результата
if (count > nums.Length / 2)
{
    Console.WriteLine($"Мажоритарное число: {candidate}");
}
else
{
    Console.WriteLine("Мажоритарного числа нет.");
}