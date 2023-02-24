Console.Write("Введите число: ");
int cub = Convert.ToInt32(Console.ReadLine());

void Cub(int[] cub){
  int counter = 0;
  int length = cub.Length;
  while (counter <  length){
    cub[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cub+1];
Cub(arry);
PrintArry(arry);
