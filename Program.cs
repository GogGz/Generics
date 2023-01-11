namespace Genereics
{
    class Program
    {
        static void Main(string[] args)
        {
            Adding<int, int> obj1 = new Adding<int, int>();
            Console.WriteLine("int 6 + 9 = " + obj1.AddingFunction(6, 9));

            Adding<char, char> obj2 = new Adding<char, char>();
            Console.WriteLine("char a + b = " + (int)obj2.AddingFunction('a', 'b'));

            Adding<int, char> obj3 = new Adding<int, char>();
            Console.WriteLine("char 7 + b = " + obj3.AddingFunction(7, 'b'));

            Adding<int, string> obj4 = new Adding<int, string>();
            Console.WriteLine("7 + bkl = " + obj4.AddingFunction(7, "bkl"));

            Adding<string, int> obj5 = new Adding<string, int>();
            Console.WriteLine("bkl + 7 = " + obj5.AddingFunction("bkl", 7));



            Console.ReadKey();
        }
    }
    public class Adding<T, G>
    {

        //public T MyT { get; set; }
        //public G MyG { get; set; }


        public dynamic AddingFunction(T first, G second)
        {
            dynamic a = first;
            dynamic b = second;
            return a + b;
        }




    }
}