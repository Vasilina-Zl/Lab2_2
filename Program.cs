using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor_2_2
{
    internal class Converter
    {
        static void Main(string[] args)
        {
            double purchaseUSD = 27.8500;
            double saleUSD = 28.0500;

            double purchaseEUR = 31.7150;
            double saleEUR = 32.0500;

            double purchaseRUB = 0.3570;
            double saleRUB = 0.3720;

            double compareSum = 0;
            string changeFromStr, changeToStr;
            string cycleCondition = "";



			while (cycleCondition != "exit")
            {
                Console.Clear();
                Console.WriteLine("Конвертер валют\n");

                

                
                Console.SetCursorPosition(13, 2);
                Console.WriteLine("Поточний курс валют:\n");
                Console.WriteLine($"Продати USD: {saleUSD} RUB, "
                    + $"Купити USD: {purchaseUSD} RUB\n"
                    + $"Продати EUR: {saleEUR} RUB, "
                    + $"Купити EUR: {purchaseEUR} RUB\n"
                    + $"Продати RUB: {saleRUB} RUB, "
                    + $"Купити RUB: {purchaseRUB} RUB\n");

               
                Console.Write("Яку валюту бажаєте помiняти?\n" +
                         "1-гривнi, 2-долари, 3-євро, 4-рублi: ");
                changeFromStr = Console.ReadLine();

                Console.Write("Введiть суму для обмiну: ");
                double changeSum = Convert.ToDouble(Console.ReadLine());

                
                if (changeFromStr == "1")
                {
                    Console.Write("Яку валюту бажаєте отримати?\n" +
                                       "1-долари, 2-євро, 3-рублi: ");
                    changeToStr = Console.ReadLine();
                    

                    if (changeToStr == "1")
                    {
                        compareSum = changeSum / purchaseUSD;
                                            }
                    else if (changeToStr == "2")
                    {
                        compareSum = changeSum / purchaseEUR;
                    }
                    else if (changeToStr == "3")
                    {
                        compareSum = changeSum / purchaseRUB;
                    }
                    else
                    {
                        continue;
                    }
                 }                                      
                else if (changeFromStr == "2")
                {
                    compareSum = changeSum * saleUSD;
                }
                else if (changeFromStr == "3")
                {
                    compareSum = changeSum * saleEUR;
                }
                else if (changeFromStr == "4")
                {
                    compareSum = changeSum * saleRUB;
                }
                else
                {
                    continue;
                }

                
                Console.Clear();
                Console.WriteLine($"Обмiн зроблено.\n" +
                    $"У Вас {Math.Round(compareSum, 2)}");

                Console.WriteLine("Для продовження натиснiть Enter,\n" +
                    "для виходу з програми введiть exit i натиснiть Enter");

               cycleCondition = Console.ReadLine();
            }
        }
    }
}

