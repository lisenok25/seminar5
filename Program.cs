// дз
// задача34.
// Задать массив, заполненный случайными положительными трехзначными числами 
// Напишите прогу, кот покажет кол-во четных чисел в массиве


// int[] Change(int size){
//     int[] array=new int[size];
//     for(int i=0; i<size; i++){
//         array[i]=new Random().Next(100,1000);
//     }
//     return array;
// }

// void ShowArray(int[]array){
//     for(int i=0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }

// int Elements(int[] array){
//     int count=0;
//     for(int i=0; i < array.Length; i++){
//         if(array[i] % 2 == 0) {
//            count++; 
//         }            
//     }      
//     return count;      
// }

// Console.Write("введите размер массива: ");
// int size=Convert.ToInt32(Console.ReadLine());

// int[] array=Change(size);
// ShowArray(array);

// Console.WriteLine();
// int count=Elements(array);

// Console.WriteLine("кол-во четных чисел= " + count);   









// задача 36.
// Задать одномерный массив, заполненный случайными числами.
// Найти сумму эл-в, стоящих на нечетных позициях

// int[] Change(int size, int min, int max){
//     int[] array=new int[size];
//     for(int i=0; i<size; i++){
//         array[i]=new Random().Next(min,max+1);
//     }
//     return array;
// }

// void ShowArray(int[]array){
//     for(int i=0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }

// int Elements(int[] array){
//     int sum=0;
//     for(int i=0; i < array.Length; i++){
       
//         if(i % 2 != 0){
//             sum=sum + array[i];  
//         }        
//     }      
//     return sum;      
// }

// Console.Write("введите размер массива: ");
// int size=Convert.ToInt32(Console.ReadLine());

// Console.Write("введите min: ");
// int min=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите max: ");
// int max=Convert.ToInt32(Console.ReadLine());

// int[] array=Change(size, min, max);
// ShowArray(array);

// Console.WriteLine();
// int sum=Elements(array);

// Console.WriteLine("сумма чисел на нечетных позициях= " + sum);   





// Задача 38.
// Задать массив вещественных чисел (от -бесконечности до +бесконечности)
// Найти разницу между мах и мин элементами массива

// 2 этапа(1.найти мах и мин значение, 2.а потом от одного отнять другое)

// как в фор найти мах? создать переменн кот отвечает за мах и каждую проверять,
// если он > мах и дальше сравнивать

// int[]  Change(int size){
//     int[] array=new int[size];
//     for(int i=0; i < array.Length; i++){
//         array[i]=Convert.ToInt32(new Random().Next(-1000,1000));
//     } 
//     return array;
// }

// void ShowArray(int[]array){
//     for(int i=0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }

// int Elements1(int[] array){
//     int max=0;
//     for(int i=0; i < array.Length; i++){  
//         if(array[i] > max) max=array[i];   
//     }            
//     return max;      
// }

// int Elements2(int[] array){
//     int min=0;
//     for(int i=0; i < array.Length; i++){
//         if(array[i] < min) min=array[i];  
//         }             
//     return min;      
// }


// Console.Write("введите размер массива: ");
// int size=Convert.ToInt32(Console.ReadLine());

// int[] array=Change(size);

// // Console.WriteLine("Вот наш массив: ");
// ShowArray(array);

// Console.WriteLine();

// int max=Elements1(array);
// Console.WriteLine("max= " + max);   
// // Console.WriteLine();

// int min=Elements2(array);
// Console.WriteLine("min= " + min); 

// Console.WriteLine("Разницу между маx и мин элементом массива: " + (max - min));



