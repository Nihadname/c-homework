// See https://aka.ms/new-console-template for more information
#region 1ci task
//1) 4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir. Example1: 333= 73338
using System.Threading.Channels;

Console.WriteLine("Hello, World!");
Console.WriteLine("4reqemli eded daxil edin");
int num1 = int.Parse(Console.ReadLine());
string num1String = num1.ToString();
while (true)
{
    if (num1String.Length == 4)
  {
        Console.WriteLine("7" + num1String + "8");
        break;
    }
    else
    {
        Console.WriteLine("Yanlış formatda eded daxil etdiniz. Yeniden daxil edin.");
        num1String = Console.ReadLine();
    }
}
#endregion
#region 2ci
//2) 3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir. example: 333= 333333;
Console.WriteLine("ededi daxil edin");
int num2 = int.Parse(Console.ReadLine());
string str2 = num2.ToString();
while (true)
{



    if (str2.Length == 3)
    {
        Console.WriteLine(str2 + str2);
        break;
    }
    else
    {
        Console.WriteLine("Yanlış formatda eded daxil etdiniz. Yeniden daxil edin.");
        str2 = Console.ReadLine();
    }
}
#endregion
#region 3cu
//3) 5 reqemli eded verilib. Bu ededin evvel 18 % sonra ise 3 % tap.
Console.WriteLine("ededi daxil edin");
int num3 = int.Parse(Console.ReadLine());
string str3 = num3.ToString();
while (true)
{
    if (str3.Length == 5)
    {
        double result = (num3 * 0.18) * 0.03;
        Console.WriteLine(result);
        break;
    }
    else
    {
        Console.WriteLine("Yanlış formatda eded daxil etdiniz. Yeniden daxil edin.");
       str3 = Console.ReadLine();
    }
}
//if(str3.Length == 5)
//{
//    double result = (num3 * 0.18) * 0.03;
//}
//else
//{
//    Console.WriteLine("5 reqmli eded daxil edin");
//}
#endregion
#region 4cu
Console.WriteLine("3 reqemli eded daxil edin");
int num4 = int.Parse(Console.ReadLine());
string str4 = num4.ToString();
while (true)
{
    if (str4.Length == 3) //yoxluyur gorur 3ludur
    {
        int numWith7 = num4 * 10 + 7;
        double result = numWith7 * 0.07;
        Console.WriteLine("Cavab: " + result);
        break;
    }
    else
    {
        Console.WriteLine("Duzgun formatda eded daxil etmediniz.");
        num4 = int.Parse(Console.ReadLine());
    }
}
#endregion
#region 5ci
Console.WriteLine("4remli eded daxil edin");
int num5 = int.Parse(Console.ReadLine());
string str5 = num5.ToString();
while (true)
{
    if (str5.Length == 4)
    {
        string result = "4" + str5 + "44";
        int resultInt = int.Parse(result);
        int lastResult = (resultInt * 100) / 44;
        Console.WriteLine(lastResult);
        break;
    }
    else
    {
        Console.WriteLine("Duzgun formatda eded daxil etmediniz.");
        str5 = Console.ReadLine();
    }
}
#endregion