using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertricSystem
{
    class Convertion
    {
        static void Main(string[] args)
        {
        double pounds;
        double price_per_gram;
        Console.WriteLine("Enter number of grams to be converted to pounds: ");
       
        double grams = Convert.ToDouble(Console.ReadLine());
        double Montreal_Smoked_Meat = grams * 0.0209;   
        
        pounds = grams * 0.00220462;
        price_per_gram = pounds * 453.592;
        
        Console.WriteLine(" Grams in pounds is : " + pounds);
        Console.WriteLine(" The Price of the product in pounds is : " + Montreal_Smoked_Meat.ToString("C2"));
        //Console.WriteLine(" The Price of your product in pound is:" + price_per_gram.ToString("C6"));
        Console.ReadKey();  
        
        }
    }
}


