
/*
Напишите программу, которая принимает 
на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27 
5 -> 1, 8, 27, 64, 125
*/

string CubeOfNum(int num){

    string result = String.Empty;
    int cube = 0;
    for (int i = 1; i <= num; i++){
        cube = i*i*i;
        result += cube + " ";
    }
    return result;
}


int N = 10;
Console.WriteLine(CubeOfNum(N));
