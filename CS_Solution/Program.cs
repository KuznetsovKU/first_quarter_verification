// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше  обойтись исключительно массивами.

string[] ChooseCorrectElements(string[] inputArray, int maxStringLength = 3)
{
    int counter = 0;
    foreach (string element in inputArray)
    {
        if (element.Length <= maxStringLength) counter++;
    }
    string[] outputArray = new string[counter];
    int j = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if(inputArray[i].Length <= maxStringLength) 
        {
            outputArray[j] = inputArray[i];
            j++;
        }
    }
    return outputArray;
}

void PrintArray(string[] arrayToPrint)
{
    foreach (string element in arrayToPrint) System.Console.Write($"{element}  ");
    System.Console.WriteLine();
}

string[] mainArray = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan", "123", "fin" };
System.Console.WriteLine("Вывод исходного массива строк");
PrintArray(mainArray);
System.Console.WriteLine();

string[] secondArray = ChooseCorrectElements(mainArray);
System.Console.WriteLine("Вывод измененного массива строк");
PrintArray(secondArray);
System.Console.WriteLine();