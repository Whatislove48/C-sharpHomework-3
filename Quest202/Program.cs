

//1 . Напишите программу,
 //которая принимает
 //на вход координаты точки (X и Y),
  //причём X ≠ 0 и Y ≠ 0 и выдаёт
   //номер четверти плоскости,
   // в которой находится эта точка.
   //  2 |  1  
//-------------------
 //    3 |  4 


int SpaceVector(int x,int y){
    if (x > 0 && y > 0) return 1;
    if (x > 0 && y < 0) return 4;
    if (x < 0 && y < 0) return 3;
    if (x < 0 && y > 0) return 2;
    return 5;
}

int X = 1;
int Y = 2;
int flag = SpaceVector(X,Y);
if (flag > 0 && flag <5){
    Console.WriteLine(flag + " Четверть");
}
else {
    Console.WriteLine(" Такого нету");
}



