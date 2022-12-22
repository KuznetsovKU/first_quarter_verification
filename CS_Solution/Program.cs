// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше  обойтись исключительно массивами.

string[] ChooseCorrectElements(string[] inputArray, int maxStringLength = 3)
{
    int counter = 0;                                       // счетчик количества элементов для нового массива
    foreach (string element in inputArray)                 // перебираем все элементы исходного массива
    {
        if (element.Length <= maxStringLength) counter++;  // если длина элемента <= максимально допустимой по условию задачи, увеличиваем счетчик на 1
    }
    string[] outputArray = new string[counter];            // инициализируем измененный массив с количеством элементов подсчитанным ранее
    int j = 0;                                             // инициализируем индексацию измененного массива
    for (int i = 0; i < inputArray.Length; i++)            // проходим циклом по всем элементам исходного массива
    {
        if(inputArray[i].Length <= maxStringLength)        // если длина элемента <= максимально допустимой по условию задачи
        {
            outputArray[j] = inputArray[i];                // присваиваем его значение очередному элементу измененного массива
            j++;                                           // переходим к следующему элементу измененного массива
        }
    }
    return outputArray;                                    // возвращаем из метода измененный массив
}

void PrintArray(string[] arrayToPrint)  // метод вывода в консоль элементов массива
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