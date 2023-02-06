// 0, 7, 8, -2, -2 -> 2


void PrintArray(string[] numbers)
{
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write($"{numbers[i]}, ");
    }
    System.Console.WriteLine("]");
}


// int[] ConvertStingToArray(string str)
// {

//     string[] parts = str.Split(',');
//     int[] myArray = new int[parts.Length];
//     for (int i = 0; i < parts.Length; i++)
//     {
//         int temp = Convert.ToInt32(parts[i]);
//         myArray[i] = temp;

//     }
//     return myArray;
// }

// System.Console.WriteLine("Введите числа через запятую: ");

// int[] newString = ConvertStingToArray(Console.ReadLine());
// PrintArray(newString);



// 123,456,743,1,2

string[] Split(string str, char c)
{
    string temp = string.Empty; // "" - не надо так обозначать пустую строку
    int i = 0;
    List<string> array = new List<string>();

    while (i != str.Length)
    {

        if (str[i] == c) 
        {
            array.Add(temp);
            temp = string.Empty;
        }
        else
        {
            temp += str[i];

        }
        i++;

    }
    array.Add(temp);
    return array.ToArray();
}


string[] splitter = Split("123,532,7,fwef,gq,e", ',');
PrintArray(splitter);







