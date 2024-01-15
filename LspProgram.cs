namespace Liskov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    public class Employee
    {
        public virtual float CalculateSalary()
        {
            return 1000;
        }

        public virtual float CalculateBonus()
        {
            return 500;
        }




    }

    public class PernamentEmploye:Employee
    {
        public override float CalculateSalary()
        {
            return base.CalculateSalary()*2;
        }


    }

    public class ContractualEmoloyee : Employee
    {
        public override float CalculateSalary()
        {
            return base.CalculateSalary() +500;
        }

        public override float CalculateBonus() {
            throw new System.Exception();
        
        }
    }

    // Jer djecja klasa ContractualEmploye ne može implementirati metodu iz roditeljske klase Employee. Tako da ju ne može ni zamijeniti.


}