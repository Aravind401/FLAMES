
using System.Text;

Thread.Sleep(1000);
Console.Write(DateTime.Now);
Console.Write("\nEnter the pin: ");
var date = DateTime.Now;
var str = new StringBuilder();
str.Append(date.Month.ToString("00")); str.Append(date.Day.ToString("00")); str.Append(date.Year);

string pin = Console.ReadLine();

if (pin != "" && pin == str.ToString())
{
start:;
    Console.Clear();
    Console.WriteLine("Welcome to the Flames game!");
    Thread.Sleep(1000);
    Console.Write("Enter your name: ");
    Thread.Sleep(1000);
    string yourName = Console.ReadLine();
    Thread.Sleep(1000);
    Console.Write("Enter your partner's name: ");
    Thread.Sleep(1000);
    string partnerName = Console.ReadLine();
    if (yourName.Length == 0 || partnerName.Length == 0) return;
    if (yourName.Contains("vijay") || partnerName.Contains("vijay")) { Console.Write("SISTER"); return; }
    string flamesResult = CalculateFlames(yourName, partnerName);

    var result = string.Empty;
    switch (flamesResult)
    {

        case "F": result = "FRIEND"; break;
        case "L": result = "LOVER"; break;
        case "A": result = "AFFECTION"; break;
        case "M": result = "MARRIAGE"; break;
        case "E": result = "ENEMY"; break;
        case "S": result = "SISTER"; break;

    }
    Thread.Sleep(2000);
    Console.Write("Processing");
    for (int i = 0; i < 3; i++)
    {
        Console.Write(".");
        Thread.Sleep(1000);
    }
    Console.WriteLine();
    Console.WriteLine("++++++++++++++++++++++++++++++++");
      
    Console.WriteLine("+ Your Flames result is: " + result+" +");
    Console.WriteLine("++++++++++++++++++++++++++++++++");
    Console.WriteLine();
    Console.WriteLine("Do you want to continue y/n");
    var r = Console.ReadLine();

    if (r.ToUpper() == "Y")
        goto start;
    else
        return;
}
static string CalculateFlames(string yourName, string partnerName)
{
    string flames = "FLAMES";
    int count = yourName.Length + partnerName.Length;
    for (int i = 0; i < yourName.Length; i++)
    {
        for (int j = 0; j < partnerName.Length; j++)
        {
            if (yourName[i] == partnerName[j])
            {
                count -= 2;
                yourName = yourName.Remove(i, 1);
                partnerName = partnerName.Remove(j, 1);
                i--;
                break;
            }
        }
    }



    int index = 0;
    for (int i = 1; i <= 5; i++)
    {
        index = (index + count) % flames.Length;
        if (index == 0)
        {
            index = flames.Length;
        }
        flames = flames.Remove(index - 1, 1);
    }
    return flames;
}

