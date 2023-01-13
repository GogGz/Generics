namespace Generics_homework
{ 
class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("__________ INT ___________");

            Gen<int> MyGen = new Gen<int>();

            int[] array = MyGen.CreateArr(6); // create array
            MyGen.ShowArr(array);

            Console.WriteLine();

            int[] AddInArray = MyGen.AddIteminArr(array, 8);// add item in array
            MyGen.ShowArr(AddInArray);

            Console.WriteLine();

            int[] AddAgain = MyGen.AddIteminArr(AddInArray, 15); // add again
            MyGen.ShowArr(AddAgain);


            Console.WriteLine();


            int[] DeleteInArray = MyGen.DeleteIteminArr(AddAgain, 1); // Delete item
            MyGen.ShowArr(DeleteInArray);


            Console.WriteLine("\n\n__________ CHAR ___________");

            Gen<char> CharGen = new Gen<char>(); // ok a vor im popokhakani mej pahum em Gen classi arr
            char[] char_arr1 = CharGen.CreateArr('a');
            CharGen.ShowArr(char_arr1);
            Console.WriteLine();

            char[] char_arr2 = CharGen.AddIteminArr(char_arr1, 'b');
            CharGen.ShowArr(char_arr2);
            Console.WriteLine();

            char[] char_arr3 = CharGen.AddIteminArr(char_arr2, 'c');
            CharGen.ShowArr(char_arr3);
            Console.WriteLine();

            char[] char_arr4 = CharGen.DeleteIteminArr(char_arr3, 0);
            CharGen.ShowArr(char_arr4);
            Console.WriteLine();

            Console.WriteLine("\n\n__________ STRING ___________");

            Gen<string> StrGen = new Gen<string>();
            string[] str_arr1 = StrGen.CreateArr("Gohar ");
            StrGen.ShowArr(str_arr1);
            Console.WriteLine();

            string[] str_arr2 = StrGen.AddIteminArr(str_arr1,"Zhanna ");
            StrGen.ShowArr(str_arr2);
            Console.WriteLine();

            string[] str_arr3 = StrGen.AddIteminArr(str_arr2, "Hasmik ");
            StrGen.ShowArr(str_arr3);
            Console.WriteLine();

            string[] str_arr4 = StrGen.DeleteIteminArr(str_arr3, 0);
            StrGen.ShowArr(str_arr4);
            Console.WriteLine();

        }
    }
    public class Gen <T>
{
        T obj;
        public Gen()
        {

        }
        public Gen (T o)
        {
            obj = o;
        }

        public T[] CreateArr(T o)
        {
            T[] arr = new T[] { o };
            return arr;
        }
        public T[] AddIteminArr(T[] arr, T new_o)
        {

            T[] CopyArr = new T[arr.Length+1];

            for (int i = 0; i < arr.Length; i++)
            {
                CopyArr[i] = arr[i];

            }
            CopyArr[CopyArr.Length-1] = new_o;

            return CopyArr;

        }
        public T[] DeleteIteminArr(T[] arr, int index)
        {
            T[] CopyArr = new T[arr.Length - 1];

            try
            {
                for (int i = 0; i < arr.Length-1; ++i)
                {
                   
                        if (i != index)
                         {
                            CopyArr[i] = arr[i];
                         }
                        else
                        {
                        for (int j = i+1; j < arr.Length; j++)
                        {
                            CopyArr[i] = arr[j];
                        }
                        
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\nPlease try again");
            }
            return CopyArr;  // vonc anem vor exceptioni depqum eli return chani
        }

        public void ShowArr(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + ", ");
            }
        }

}
}