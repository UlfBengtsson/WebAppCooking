using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCooking.Models.Util
{
    public class RandomLunshGenerator
    {
        private static Random randomGen = new Random();

        public static List<string> menuOptions = new List<string>()
        {
            "Chicken with Rise",
            "Fried patatos with fish",
            "Muschroom stew",
            "Swedish meatballs with potatos",
            "Fufu",
            "Pizza",
            "Sallad blow",
            "Spaggeti bolones",
            "Hamburger"
        };

        public static List<string> GenerateMenu()
        {
            List<string> weekPicks = new List<string>();

            for (int i = 0; i < 7; i++)
            {
                weekPicks.Add(
                    menuOptions[randomGen.Next(menuOptions.Count)]
                    );
            }

            return weekPicks;
        }
    }
}
