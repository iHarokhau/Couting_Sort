//Сортировка подсчетом

Console.Clear();

int[] array = { 0, 2, 3, 2, 1, 5, 9, 1, 1 };

CoutingSort(array);

System.Console.WriteLine(string.Join(", ", array));

void CoutingSort(int[] inputArray)
{
    int[] counters = new int[10]; //Массив повторений

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i]]++;
        // int ourNumber = inputArray[i]; 12 и 13 строка = 11
        // counters[ourNumber]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i;
            index++;
        }
    }
}