void Method1()
{
    Console.WriteLine("некий текст");
}
Method1();

void Method21(int cont, string msg)
{
    int i = 0;
    while (i<cont)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(3, "Text");
Method21(msg: "asdf", cont: 5);

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


string Method4(int connt, string text)
{
    int i = 0;
    string rusult = String.Empty;
    while(i < connt)
    {
        rusult+= text;
        i++;
    }
    return rusult;
}

string res = Method4(10, "sdf");
Console.WriteLine(res);

string Method41(int connt, string text)
{
    string rusult = String.Empty;
    for(int i = 0; i < connt; i++)
    {
        rusult+= text;
    }
    return rusult;
}

res = Method41(10, "2-");
Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{j} x {i} = {i * j}");
    }    
    Console.WriteLine();
}


//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.

// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";


// sting s = "qwerty"
//            012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int len = text.Length;
    for(int i = 0; i < text.Length; i++)
    {
        if(text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();



int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PtintArray(arr);
selectionSort(arr);
PtintArray(arr);

void selectionSortBack(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
selectionSortBack(arr);
PtintArray(arr);