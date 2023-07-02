
using System.Text;
var str = new StringBuilder();

var date = DateTime.Now;
str.Append(date.Month.ToString("00")); str.Append(date.Day.ToString("00")); str.Append(date.Year);
Console.WriteLine(DateTime.Now);
Console.Write("Enter the pin: ");


string pin = Console.ReadLine();








if (pin != "" && pin == str.ToString())
{

    Console.WriteLine("Welcome to the Flames game!");
    Console.Write("Enter your name: ");
    string yourName = Console.ReadLine();
    Console.Write("Enter your partner's name: ");
    string partnerName = Console.ReadLine();
    string flamesResult = CalculateFlames(yourName, partnerName);
    Console.WriteLine("Your Flames result is: " + flamesResult);
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

