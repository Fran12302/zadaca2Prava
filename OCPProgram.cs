namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, World!");
            
        }
    }

    public class Pool
    {
        public float Dužina { get; set; }
        public float Širina{ get; set; }

        public float Dubina { get; set; }
        

    }

    public class KalkulatorKolicineVode {
       
      public float IzracunajKolicinuVode(Pool pool)
        {
            return pool.Dužina * pool.Dubina * pool.Širina;
        }
    }

    //Krši OCP jer je za svaki novi oblik bazena potrebno mijenjati klasu KalkulatorKolicineVode... Znači ne radimo proširenje nego promjenu a to ne želimo
}