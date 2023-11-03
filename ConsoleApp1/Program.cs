

using System.Threading.Channels;
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

Console.WriteLine(" Hi. please insert your score correctly!");
string[] doross1= new string[6] { "fizik", "riazi", "shimi", "hesaban", "hendese", "gosaste"};
bool check = true;
double sum1 = 0;
for (int i = 0; i < doross1.Length; i++)
{
    Console.Write(doross1[i] + ":  ");
    double score1 = Convert.ToDouble(Console.ReadLine());

    check = score1 >= 0 && score1 <= 20;
    while (!check)
    {
        Console.WriteLine("please insert your score between 0 to 20 ! try again.");
        Console.Write(doross1[i] + ":  ");
        score1 = Convert.ToDouble(Console.ReadLine());
        check = score1 >= 0 && score1 <= 20;
    }
    sum1 = sum1 + (score1 * 3);
}


string[] doross2 = new string[4] { "zaban", "farsi", "dini", "arabi" };
bool check1 = true;
double sum2 = 0;
for (int x = 0 ; x < doross2.Length ; x++)
{
    Console.Write(doross2[x] + ":  ");
    double score2 = Convert.ToDouble(Console.ReadLine());

    check1 = score2 >= 0 && score2 <= 20;
    while (!check1)
    {
        Console.WriteLine("please insert your score between 0 to 20 ! try again.");
        Console.Write(doross1[x] + ":  ");
        score2= Convert.ToDouble(Console.ReadLine());
        check1 = score2 >= 0 && score2 <= 20;
    }
    sum2 = sum2 + (score2 * 2);

}
double sum= sum1+sum2;
Console.WriteLine("your score is :  " + sum / 26);













