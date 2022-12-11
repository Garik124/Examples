// ВИД 1 (Методы которые ничего не принимают и ничего не возвращают)
void Method1 ()
{
    Console.WriteLine ("Автор ...");
}

// Method1();




// ВИД 2 (Методы которые что-то принимают и ничего не возвращают)
void Method2 (string msg)
{
    Console.WriteLine(msg);
}

// Method2(msg "Текстовое сообщение");


void Method21 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

// Method21 (msg: "Text", count: 4); вводные данные можно писать как по порядку, так и в случайном порядке




// ВИД 3 (Методы которые ничего не принимают, но чтото возвращают)
int Method3 ()
{
    return DateTime.Now.Year;
}

// int year = Method3();
// Console.WriteLine(year);





// ВИД 4 (Методы которые что-то принимают и что-то возвращают - печатаем строку стринг каунт раз);
string Method4 (int count, string text)
{
    int i =0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

// string res = Method4(10, "asdf");
// Console.WriteLine(res);


string Method41 (int count, string text) // тот же метод, только с циклом for
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

// string res = Method41(10, "asdf");
// Console.WriteLine(res);



// использование ЦИКЛА в ЦИКЛЕ - делаем таблицу умножения
// for(int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//      Console.WriteLine();

// }








// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого "
//             + "Винценгероде, вы бы взяли приступом согласие "
//             + "прусского короля. Вы так красноречивы. Вы "
//             + "дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

// string Replace (string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int lenght = text.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }


// string newText = Replace(text, ' ', '|'); // применяем метод и затем с помощью него работаем далее с изменённым текстом
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);




int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) 
            minPosition = j;
        }
        int temp = array[i];
        array[i] = array [minPosition];
        array[minPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
