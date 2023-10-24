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
        double result5 = (num3 * 0.18) * 0.03;
        Console.WriteLine(result5);
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
//4) 3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;

Console.WriteLine("3 reqemli eded daxil edin");
int num4 = int.Parse(Console.ReadLine());
string str4 = num4.ToString();
while (true)
{
    if (str4.Length == 3) //yoxluyur gorur 3ludur
    {
        int numWith7 = num4 * 10 + 7;
        double result4 = numWith7 * 0.07;
        Console.WriteLine("Cavab: " + result4);
        break;
    }
    else
    {
        Console.WriteLine("Duzgun formatda eded daxil etmediniz.");
        str4 = Console.ReadLine();
    }
}
#endregion
#region 5ci
//5) 4 reqemli eded verilib. Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap.

Console.WriteLine("4remli eded daxil edin");
int num5 = int.Parse(Console.ReadLine());
string str5 = num5.ToString();
while (true)
{
    if (str5.Length == 4)
    {
        string result2 = "4" + str5 + "44";
        int resultInt = int.Parse(result2);
        int lastResult = (resultInt * 44) / 100;
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
#region 6ci
Console.WriteLine("4remli eded daxil edin");
int num6= int.Parse(Console.ReadLine());
string str6= num6.ToString();   
while (true)
{
    if(str6.Length == 4)
    {
        int firstCalculationPart = (num6 * 20) / 100;
        int SecondCalculationPart = (firstCalculationPart * 10) / 100;
        int result = SecondCalculationPart * SecondCalculationPart;
        Console.WriteLine(result);
        break;
    }
    else
    {
        Console.WriteLine("Duzgun formatda eded daxil etmediniz.");
        str6 = Console.ReadLine();
    }
}
#endregion
#region 7ci
int num7= int.Parse(Console.ReadLine());
int num8= int.Parse(Console.ReadLine());
string str8= num8.ToString();
string str7= num7.ToString();
while (true)
{
    if(str7.Length == 5&&str8.Length==5)
    {
        int firstPart = num7 + num8;
        string firstPartString=firstPart.ToString();
        string result1 = "5" + firstPartString + "5";
        int resultPart2 = int.Parse(result1);
        int lastResult = (resultPart2 * 5) / 100;
        Console.WriteLine(lastResult);
        break;
    }
    else
    {
        Console.WriteLine("Duzgun formatda eded daxil etmediniz.");
        str7 = Console.ReadLine();
        str8 = Console.ReadLine();
    }
}
#endregion