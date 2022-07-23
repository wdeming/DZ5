void FillArray(int[] array, int first, int last){
    Random random = new Random();
    for(int i = 0; i < array.Length; i++){
        array[i] = random.Next(first,last);
    }
}
void PrintArray(int[] array, string dzNumber){
    Console.WriteLine(dzNumber);
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void dz34 (){
    int size = 5;
    int[] array = new int[size];
    
    FillArray(array,100,999);
    PrintArray(array, "Задача 34:");

    int even = 0;

    for(int i = 0; i < array.Length; i++){
        if (array[i]%2 == 0) even++;
    }

    Console.WriteLine("Кол-во целых чисел: " + even );
}
dz34();

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void dz36 (){
    int size = 7;
    int[] array = new int[size];
    
    FillArray(array,-100,100);
    PrintArray(array, "Задача 36:");

    int notEvenSum = 0;

    for(int i = 0; i < array.Length; i+=2){
        notEvenSum += array[i];
    }

    Console.WriteLine("Кол-во целых чисел: " + notEvenSum );
}
dz36();

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


void dz38 (){
    int size = 7;
    int[] array = new int[size];
    //вещественных чисел - я так понимаю тут через double делать надо... но, надеюсь на понимание делаю в дороге, тяжко.
    
    FillArray(array,1,100);
    PrintArray(array, "Задача 38:");
    int max = array[0];
    int min = array[0];
    int diff = 0;

    for (int i = 0; i < array.Length; i++){
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
        diff = max - min;
    }

    Console.WriteLine("Разница: " + diff );
}
dz38();
