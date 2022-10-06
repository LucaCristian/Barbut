using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Barbut";
            Console.Write("Nume: ");
            String name = Console.ReadLine();
            Console.WriteLine("\nSalut " + name + ". Bine ai venit la Barbut!\nBarbut este un joc de noroc in care iti vei pierde toti banii!");

            int playerNr1;
            int playerNr2;
            int playerSum;
            int playerPoints = 0;

            int enemyNr1;
            int enemyNr2;
            int enemySum;
            int enemyPoints = 0;

            int round = 1;

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\n\nApasa orice tasta pentru a da cu zarurile.");
                Console.ReadKey();
                Console.WriteLine("\n\n---------------------  RUNDA " + round + "  ---------------------");
                playerNr1 = random.Next(1, 7);
                playerNr2 = random.Next(1, 7);
                playerSum = playerNr1 + playerNr2;
                Console.WriteLine("\t< " + name + " >\n\tPrimul zar: " + playerNr1 + "\n\tAl doilea zar: " + playerNr2 + "\n\tTotal: " + playerSum);

                Console.WriteLine("-----------------------------------------------------");
                System.Threading.Thread.Sleep(1500);
                enemyNr1 = random.Next(1, 7);
                enemyNr2 = random.Next(1, 7);
                enemySum = enemyNr1 + enemyNr2;
                Console.WriteLine("\t< Enemy >\n\tPrimul zar: " + enemyNr1 + "\n\tAl doilea zar: " + enemyNr2 + "\n\tTotal: " + enemySum);
                Console.WriteLine("-----------------------------------------------------");
                round++;

                if (playerSum > enemySum)
                {
                    playerPoints++;
                    Console.WriteLine("!!! " + name + " A CASTIGAT !!!\t\t" + name + ": " + playerPoints + "\tEnemy: " + enemyPoints);
                }
                else if(playerSum < enemySum)
                {
                    enemyPoints++;
                    Console.WriteLine("!!! Enemy A CASTIGAT !!!\t\t" + name + ": " + playerPoints + "\tEnemy: " + enemyPoints);
                }
                else
                {
                    Console.WriteLine("!!! EGALITATE !!!\t\t" + name + ": " + playerPoints + "\tEnemy: " + enemyPoints);
                }
                
                System.Threading.Thread.Sleep(500);
                
                if (playerPoints > 2)
                {
                    Console.WriteLine("\n\n\n\t!!! " + name + " A CASTIGAT TOTI BANII !!!");
                    playerPoints = 0;
                    enemyPoints = 0;
                    round = 1;
                }
                else if(enemyPoints > 2)
                {
                    Console.WriteLine("\n\n\n\t!!! Enemy A CASTIGAT TOTI BANII !!!");
                    playerPoints = 0;
                    enemyPoints = 0;
                    round = 1;
                }
            }
            Console.ReadKey();
        }
    }
}
