
// Напишите программу, которая принимает на
 // вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int Palindrom(int[] num){
    int flag = 0;
    int len = num.length -1;
    for (int i = 0; i < (len-i); i++){
        if(num[i] == num[len-i]){
            flag = 1;
        }
        else{
            flag = 0;
            break;
        }
    }
    return flag;
}

int[] CountOfNumber(int numeric){
    int[] NumericCount = new int [5]; 
    for (int i = 0;i < 5 ;i++){
        NumericCount[i] = (numeric%10);
        numeric /= 10;                                      
    } 
    return NumericCount;           
}


int testnum = 12821;
int id = Palindrom(CountOfNumber(testnum));
if (testnum < 100000 && testnum > 9999){
    if (id == 1){
        Console.WriteLine("Yes");
    }
    else {
        Console.WriteLine("No");
    }
} 
else{
    Console.WriteLine("Число не 5ти значное");
    }




