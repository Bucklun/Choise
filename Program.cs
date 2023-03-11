// Программа, формирующая из имеющегося массива строк массив строк, имеющих длинну, не превышающую 3 символа
int EnterIntegerNumber(string comment)
{
    int x = 0;
    Console.WriteLine(comment);
    try
    {
        x = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Try again");
        x = EnterIntegerNumber(comment);
    }
    x = x > 0 ? x: EnterIntegerNumber(comment);
    return x;
}
void printArray (string[] array)
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
int firstArraySize = EnterIntegerNumber("How much strings in array we need?");

string[] firstArray = new string [firstArraySize];

for (int i = 0; i < firstArraySize; i++)
{
    Console.WriteLine($"Enter an {i+1} string");
    firstArray[i] = Console.ReadLine();
}

Console.WriteLine("We set first array: ");
printArray(firstArray);

int secondArraySize = 0;

foreach (var item in firstArray)
{
    if (item.Length <= 3) secondArraySize++;
}

string [] secondArray = new string [secondArraySize];

int secondIndex = 0;

foreach (var item in firstArray)
{
    if (item.Length <= 3) 
    {
        secondArray[secondIndex] = item;
        secondIndex++;
    }
}

Console.WriteLine("...and we got an array: ");
printArray (secondArray);