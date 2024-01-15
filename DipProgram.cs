namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class DieselEngine{



        }

    public class PetrolEngine
    {

    }


    public class Car
    {
        DieselEngine dieselEngine;

        public Car()
        {
            dieselEngine = new DieselEngine();
        }
    }


    // Radimo čvrstu spregu klase Car s klasom DieseEgine jer ne ovisimo o apstrakciji
}

