using System;
using System.Threading;
namespace CyberHack
{
    public class Program
    {
        private static void Main(string[] args)
        {
            
            string Stype=Console.ReadLine();
            SystemType type;
            switch (Stype)
            {
                case "CorporateServer":
                type=SystemType.CorporateServer;
                break;

                case "BankDatabase":
                type=SystemType.BankDatabase;
                break;

                case "SmartCityCore":
                type=SystemType.SmartCityCore;
                break;

                case "MilitaryAI":
                type=SystemType.MilitaryAI;
                break;
            }
            string Tools=Console.ReadLine();
            string[] Tools2=Tools.Split(' ');

        }
    }
}
