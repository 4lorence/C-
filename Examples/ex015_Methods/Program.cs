// Тип 1
void Method1()
{
    Console.WriteLine("Autor me");
}

//Method1();

//Тип 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("text message");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
       Console.WriteLine(msg);
        i++;
    } 
}
//Method21(msg:"текст", count: 4);

//Тип 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

//Тип 4
string Method4(int count, string text)
{
    int i = 0;
    string result = "";

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
//string res = Method4(10,"z");
//Console.WriteLine(res);

//for
string Method5(int count, string text)
{
    string result = "";
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
//string res = Method4(10,"z");
//Console.WriteLine(res);

for(int i = 2; i<=10;i++)
{
    for(int j = 2;j<=10;j++)
    {
        //Console.WriteLine($"{i} * {j} = {i * j}");
    }
    //Console.WriteLine();
}
// Работа с текстом

string text = "-Я думаю, - сказал князь, улыбаясь, - что,"
            + "Ежели вы послали вместо нашего милого Винцегероде,"
            +"вы бы взяли приступом согласие прусского короля."
            +"Вы так красноречивы. Вы дадите мне чаю?";
//string s ="qwerty"
            //012   
//s[3] //r
string Replace(string text, char oldValue, char NewValue)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{NewValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string NewText = Replace(text, ' ', '|');      
// Console.WriteLine(NewText);
// Console.WriteLine();
// NewText = Replace(NewText,'к','К');       
// Console.WriteLine(NewText);

int[] arr = {5, 6, 3, 7, 4, 2, 8, 9 };

void PrintArray(int[] array)
{
    int count = array.Length;
    {
        for(int i = 0; i < count; i++)
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;

        for(int j = i; j < array.Length; j++)
        {
            if(array[j]<array[minPosition]) minPosition = j;
        }



        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);



