// РЕШАЕМ ЗАДАЧУ 010 С ПОМОЩЬЮ МЕТОДОВ И ГЕНЕРАТОРА СЛУЧАЙНЫХ ЧИСЕЛ ДЛЯ МАССИВА
// void метод который ничего не возвращает - оператор return в конце не используем

void FillArray(int[] collection) // этот метод генерирует массив из случайных чисел от 1 до 10
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // этод метод выводить весь наш массив на экран
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // в этот метод вшита функция поиска индекса одного из чисел массива
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int [] array = new int [10]; // значит создай массив в котором будет 10 случайных елементов 
// (по умолчанию он будет заполнен нулями, поэтому используем методы - начинаются со слова void)

FillArray (array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 23);
Console.WriteLine(pos);

// при данных настройках на экран выведется индекс последнего найденного значения, чтобы найти первое нужно добавить в цикл while
// в функции IndexOf команду break, чтобы программа остановилась после того как найдет первое значение
// так же при данных настройках: если нужного числа нет в массиве, то на экран будет выводится значение position которое мы задали
// изначально - то есть 0. В таком случае изначально нужно присваивать значение -1 и тогда если элемента в массиве нет - ты это увидишь