// Где ошибка и как ее исправить?????
int N;
Console.Write("Number for test = ");
N = Convert.ToInt32(Console.ReadLine());
int number = 0;
int index = 0;
int sorted = 0;
while (number < N)
{
  if(number % 2 == 0) 
  {
  sorted = number[index];
  index = index + 1;
  }
  number = number + 14;
} 
Console.WriteLine("Ряд чётных чисел:  ");
Console.WriteLine(sorted);