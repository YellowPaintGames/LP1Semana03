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
            string T1="";
            string T2="";
            string T3="";
            string Aux="";
            foreach(char letter in Tools)
            {
                
                if (char.IsWhiteSpace(letter))
                {
                    if (T1=="" && T2=="" && T3=="")
                    {
                        T1=Aux;
                        Aux="";
                    }
                    else if (T2 == "" && T1!="" && T3=="")
                    {
                        T2=Aux;
                        Aux="";
                    }
                    else if (T3 == "" && T2!="" && T1!="")
                    {
                        T3=Aux;
                        Aux="";
                    }
                }
                else
                {
                    Aux+=letter;
                }
            }
            Console.WriteLine(T1);
            Console.WriteLine(T2);
            Console.WriteLine(T3);
        }
    }
}
