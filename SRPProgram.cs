namespace zadaca_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        public class Product
        {
            public string Name { get; set; }
            public float TaxRate { get; set; }
            public float Price { get; set; }

            
            public Product(string name, float  taxRate, float price)
            {
                Name = name;
                TaxRate = taxRate;
                Price = price;
            }

            public float Calculate_Tax()
            {
                return Price * TaxRate;
            }
            //Klasa produkt treba imati samo jednu odgovornost, da stvori produkt... Calculate Tax trebamo prebaciti u novu klasu npr. Tax_Calculator


        }
    }
}