namespace Generics_homework
{ 
class Program
{
    static void Main(string[] args)
    {

            Gen<int> MyGen = new Gen<int>();

            int[] array = MyGen.CreateArr(6); // create array
            Console.Write("Create array   -----  ");
            MyGen.ShowArr(array);

            Console.WriteLine();

            int[] AddInArray = MyGen.AddIteminArr(array, 8);// add item in array
            Console.Write("Add item in array   -----  ");

            MyGen.ShowArr(AddInArray);

            Console.WriteLine();

            int[] AddAgain = MyGen.AddIteminArr(AddInArray, 15); // add again
            Console.Write("Add item in array again   -----  ");
            MyGen.ShowArr(AddAgain);


            Console.WriteLine();


            int[] DeleteInArray = MyGen.DeleteIteminArr(AddAgain, 1); // Delete item
            Console.Write("Delete item from  array   -----  ");
            MyGen.ShowArr(DeleteInArray);

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
            return CopyArr;
        }

        public void ShowArr(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + ", ");
            }
        }

}
}