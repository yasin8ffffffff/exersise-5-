///////////////////////////////////////////////////////////////////////یاسین منعم///////////////////////////////////////////////////////////////////////////////////////
using System.ComponentModel.Design;

int x ;
bool check;
string input;
ConsoleKeyInfo digit;
do
{
   Scoretorank();
    YesorNo();
   

} while (input.ToLower() == "y");
Console.WriteLine("Thank you fo using this program, Have nice day");

//////////////////////////////////////////////////////////////////Method/////////////////////////////////////////////////////////////////////////////////////////////////////////

void Scoretorank()
{
Console.Write("please enter a score to rank: ");
    x = Convert.ToInt32(Console.ReadLine());


    if (x > 20)
    {
        Console.WriteLine("Enter another score");
    }
    if (x >= 17 && x < 20)
    {
        Console.WriteLine("Your rank is A");
        Console.WriteLine("Your percent is: ");
        Console.WriteLine(x * 5);
    }
    if (x >= 15 && x < 17)
    {
        Console.WriteLine("Your rank is B");
        Console.WriteLine("Your percent is: ");
        Console.WriteLine(x * 5);
    }
    if (x >= 10 && x < 15)
    {
        Console.WriteLine("Your rank is C");
        Console.WriteLine("Your percent is: ");
        Console.WriteLine(x * 5);
    }
    if (x >= 0 && x < 10)
    {
        Console.WriteLine("Unfourtunetly You have failed");
        Console.WriteLine("Your percent is: ");
        Console.WriteLine(x * 5);

    }
}
void YesorNo()
{
 Console.WriteLine("Do you want to countinue?  Press Y, for stop press N");
    do
    {
        input = Console.ReadKey(true).KeyChar.ToString();

    } while (input.ToLower() != "y" && input.ToLower() != "n");
}