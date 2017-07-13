using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name:Nguyen Thi Kim Ngan
 * Date: July 13, 2017
 * Description: This is the driver class for my project
 * Version: 0.5 - Implemented the SuperVillain class
 */

namespace COMP123_S2017_Lesson9A
{
    class Program
    {
        static void Main(string[] args)
        {
            //SuperHero superHero = new SuperHero("SuperHero Dude", 20);
            //superHero.Powers.Add(new Power("Teleportation", 50));
            //superHero.Powers.Add(new Power("Phasing", 40));
            //superHero.Powers.Add(new Power("Invisibility", 30));
            //Console.WriteLine(superHero.ToString());
            //Console.WriteLine("Karma: " + superHero.Karma);
            SuperVillain superVillain1 = new SuperVillain("SupperVillain Alan", 10);
            superVillain1.Powers.Add(new Power("War", 20));
            superVillain1.Powers.Add(new Power("Disease", 40));
            Console.WriteLine(superVillain1.ToString());
            Console.WriteLine("Malice: " + superVillain1.Malice);
            SuperVillain superVillain2 = new SuperVillain("SupperVillain Angela", 15);
            superVillain2.Powers.Add(new Power("Fire", 35));
            Console.WriteLine(superVillain2.ToString());
            Console.WriteLine("Malice: " + superVillain2.Malice);
        }
    }
}
