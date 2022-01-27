using System;
using Projeto_GFT.src.Entities;

namespace Projeto_GFT
{

    class Program
    {

        static void Main(string[] args)
        {

            Agility ranger = new Agility("Drow Ranger", 20, "Carrier", "Ranged");
            Intelligence mage = new Intelligence("Ancient", 20, "Support", "Ranged");
            Strength knight = new Strength("Chaos Knight", 20, "Pusher", "Meele");

            Console.WriteLine(ranger.Attack(5));
            Console.WriteLine(mage.Attack(8));
            Console.WriteLine(knight.Attack(11));
        }
    }
}

