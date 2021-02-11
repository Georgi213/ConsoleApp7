using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        public void Main(string[] args);
        {
            ConsoleKeyInfo nupp = new ConsoleKeyInfo();
        int[,] nums = new int[4, 7];
            for(int i = 0; i<nums.GetLength(0);i++)
            {
                for(int j=0;j<nums.GetLength(1);j++)
                {
                   nums[i, j] = 0;
                   Console.Write(nums[i, j]);
                }
    Console.WriteLine();

        static void Main(string[] args)
    {
        int[,] nums = new int[4, 7];
        ConsoleKeyInfo nupp = new ConsoleKeyInfo();
        Program prog = new Program()
                  prog.vabad_piletid(nums);

    }
            do
            {
                Console.Write("Vali rida:");
                int rida = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Vali rida:");
                int koht = Convert.ToInt32(Console.ReadLine()) - 1;
                if(nums[rida, koht] == 0;
                {
                    Console.WriteLine("Koht on vaba!");
                    nums[rida, koht]=1;
                    for(int i = 0;i<nums.GetLength(0);i++)
                    {
                        for(int j = 0;j<nums.GetLength(0);j++)
                        {
                            Console.Write(nums[i, j]);
                        }
Console.WriteLine();

nupp = Console.ReadKey();
            }while (nupp.Key != ConsoleKey.Escape) ;


string[] texts = new string[4];
for (int i = 0; i < texts.GetLength(0); i++)
{
    Console.WriteLine("{0}-text", i.ToString());
    texts[i] = Console.ReadLine();
}
foreach (int item in texts)
{
    Console.Write(item + " ");
}



int[] numbers = new int[5] { 1, 2, 3, 4, 5 };//Создание списка в котором будет отдельное количество цифр
Console.WriteLine(numbers[1]);
foreach (int item in numbers)//Цикл foreach служит для циклического обращения к элементам коллекции, представляющей собой группу объектов. В C# определено несколько видов коллекций, каждая из которых является массивом. Ниже приведена общая форма оператора цикла foreach:
{
    Console.Write(item + " ");
}
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + "_");

}
int a_ = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("a_={0},b={1}", a_, b);
double c = (a_ + b) / (6 * a_ - 4 * b);
Console.WriteLine("c={0}", c.ToString());


Random rnd = new Random();
int hinne = rnd.Next(1, 5);
Console.WriteLine("Hinne:{0}", hinne);
string tekst = "???";
switch (hinne)
{
    case 1: tekst = "Õpi veel!"; break;
    case 2: tekst = "Õpi natuke veel!"; break;
    case 3: tekst = "Rahuldav!"; break;
    case 4: tekst = "Hea!"; break;
    case 5: tekst = "Väga hea!"; break;
    default:
        tekst = "Viga!";
        break;
}
Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Blue;
Console.Clear();
Console.WriteLine(tekst);


do
{
    Console.WriteLine("Zadanie");
    nupp = Console.ReadKey();


} while (nupp.Key != ConsoleKey.Backspace);
Console.ReadLine();
Console.WriteLine("Töö failidega:");
string a;
Console.WriteLine("Q-on vaja salvestada failisse");
Console.WriteLine("N-on vaja lugeda failist");
nupp = Console.ReadKey();
if (nupp.Key == ConsoleKey.Q)
{
    StreamWriter file = new StreamWriter(@"..\..\texsts.txt", true);
    file.WriteLine(hinne + "" + tekst);
    file.Close();
    a = hinne + "" + tekst;
    Console.WriteLine("Failisse oli salvestatud:{0}", a);
}
else if (nupp.Key == ConsoleKey.N)
{
    Console.WriteLine("Failis on järgmine informatsion:{0}");
    StreamReader fillist = new StreamReader(@"..\..\texsts.txt");
    a = fillist.ReadToEnd();
    Console.WriteLine(a);
}

{

}

{
    Console.WriteLine("Puhkame");
}
Console.ReadLine();
        }
    }
}
