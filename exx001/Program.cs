// Написать программу, которая из имеющегося массива строк формирует массив из строк,длина которых меньше либо равна 3. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

void getArray (string [] array)
{
    string [] myArr = new string [array.Length];
    for(int i = 0; i < array.Length; i++ )
    {
        if (array[i]. Length <= 3 ){
        myArr[i] = array[i];
        Console.WriteLine(myArr[i]);
        }
    }
    Console.WriteLine();
}
void PrintArray(string [] Array){
    for (int i = 0; i < Array.Length; i++){
        Console.WriteLine(Array[i]);
    }
    Console.WriteLine();
}
string [] array = {"1234", "1567", "-2", "computer science"};

getArray(array);
PrintArray(array);