string [] GetArray (string [] Array)
{
    string [] Result= new string [Array.Length];
    for (int i=0; i< Array.Length; i++)
    {
        if (Array[i].Length<=3)
        {
            Result [i]= Array[i];
        }
    }
    return Result;
}

void PrintArray(string [] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        {
            Console.Write($"{inArray[i]}  ");
        }
    }
}

string [] array= {"1234", "1567", "-2", "computer science"};
string [] NewArray= GetArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(NewArray);