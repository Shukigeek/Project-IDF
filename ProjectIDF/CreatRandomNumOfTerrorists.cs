using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    internal class CreatRandomNumOfTerrorists
    {
        static Random rand = RandomProvider.GetRandom();
        static int amount = rand.Next(5,11);
        public static string[] terroristNames = new string[amount];
        public static List<Terrorist> terroristList = new List<Terrorist>();
        //public static void printTerrorist()
        //{
        //    for (int i = 0; i < amount; i++)
        //    {
        //        Terrorist terrorist = new Terrorist(CreatRandomTerroristNames.getNewName(), RandomProvider.GetRandom().Next(1, 6), AliveOrDead.Status(), TerroristWeaponArssenal.Personalweapon());
        //        //terroristList.Add(terrorist);
        //        Console.WriteLine(terrorist.ToString());
        //    }
        //}
        public static List<Terrorist> TerroristList()
        {
            for (int i = 0; i < amount; i++)
            {
                Terrorist terrorist = new Terrorist(CreatRandomTerroristNames.getNewName(), RandomProvider.GetRandom().Next(1, 6), AliveOrDead.Status(), TerroristWeaponArssenal.Personalweapon());
                terroristNames[i] = terrorist.Name;
                terroristList.Add(terrorist);
                //Console.WriteLine(terrorist.ToString());
            }
            return terroristList;
        }
        public static string[] TerroristNames()
        {
            return terroristNames;
        }
}
}
