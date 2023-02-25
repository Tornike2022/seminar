// нап программу которая принимает на вход число n и выдает произв 
// чисел от 1 до n  (5 -> 120 == 1*2*3*4*5)
Console.Clear();
Console.Write("введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"произведение цифр {GetMultiply(num)}");
// int num1 = 2;
// Console.WriteLine($"произведение цифр {GetMultiply(num1)}");
// int num2 = 3;
// Console.WriteLine($"произведение цифр {GetMultiply(num2)}");
// int num3 = 4;
// Console.WriteLine($"произведение цифр {GetMultiply(num3)}");

long GetMultiply(long n) {//n=3
    long result = 1;
    long i = 2;
    if (n<0){
        i=n;
        n=-1;
    }
    for (; i <=n; i++) { //i <=n; 2,=3
        result*=i; //result

    }
    return result;


}