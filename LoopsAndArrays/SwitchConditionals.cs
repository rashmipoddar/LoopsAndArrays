using System;
namespace LoopsAndArrays
{
    enum Seasons
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    public class SwitchConditionals
    {
        public SwitchConditionals()
        {
        }

        public static void RunSwitchConditionals()
        {
            PrintCurrentSeason(); // It is the Autumn or Winter season
        }

        public static void PrintCurrentSeason()
        {
            var currentSeason = Seasons.Winter;

            switch (currentSeason)
            {
                case Seasons.Spring:
                    Console.WriteLine("It is the Spring season");
                    break;

                // Same code block to be executed with multiple cases is called falling through to the next case
                case Seasons.Autumn:
                case Seasons.Winter:
                    Console.WriteLine("It is the Autumn or Winter season");
                    break;

                default:
                    Console.WriteLine("It is the Summer season");
                    break;
            }
        }
    }   
}
