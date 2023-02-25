// Напишите прошграмму кот принимает на вход число и выдает 
// сумму цифр в числе (452->11)
int a = int.Parse(Console.ReadLine());
            int s = 0;
            while (a > 0)
            {
 
                s = s + a % 10;
                a = a /10 ;
 
            }
 Console.WriteLine(s);
