namespace ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    interface IProcessable
    {
        string Read();
        void Write();
    }

    public class TextFile : IProcessable
    {
        public string Read() { return "čitam"; }

        public void Write() { Console.WriteLine("Pišem"); }
    }

    public class ReadOnlyTextFile : IProcessable
    {
        public string Read() { return "čitam"; }

        public void Write() { throw new NotImplementedException(); }
    }

    // Ne implementira svaka klasa sve metode koju nasljeđuje tako da bi bilo pametno razdvojiti interface u 2 posebna
}