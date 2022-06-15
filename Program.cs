// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

int num = Input("Введите пятизначное число: ");
PalindromeOrNo(num);

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = Input("Введите x1: "),
    y1 = Input("Введите y1: "),
    z1 = Input("Введите z1: "),
    x2 = Input("Введите x2: "),
    y2 = Input("Введите y2: "),
    z2 = Input("Введите z2: ");

int distanceX = CalcDistance(x1,x2),
    distanceY = CalcDistance(y1,y2),
    distanceZ = CalcDistance(z1,z2);

double result = Math.Sqrt(ExpNum(distanceX,2) + 
                          ExpNum(distanceY,2) + 
                          ExpNum(distanceZ,2));
Console.WriteLine($"Расстояние между точками: {result}");

// Задача 23: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

int numBase = Input("Введите целое число (основание): ");
int extend = Input("Введите степень в которую нужно возвести основание: ");
PrintAllExpNum(numBase,extend);

void PalindromeOrNo(int num)
{
    string yes = "Число палиндром.",
       no = "Число не палиндром.",
       result = no;

    if (num % 10 == num / 10000)
    {
        if (((num % 100)-(num % 10))*100 == (num % 10000) - (num % 1000))
        {
            result = $"{yes}";
        }
    }
Console.WriteLine(result);
}

int CalcDistance(int a, int b)
{
    return a - b;
}

void PrintAllExpNum(int b, int e)
{
    int count = 1;
    string result = string.Empty;
    while (count <= b)
    {
        int nums = ExpNum(count, e);
        Console.Write(nums);
        if (count == b)
        {
            break;
        }
        Console.Write(",");
        count++;
    }
}

int ExpNum(int b,int e)
{
    int count = 1;
    int result = 1;
     while(count <= e)
     {
        result *= b; 
        count++;
     }
     return result;
}

int Input(string str)
{
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

