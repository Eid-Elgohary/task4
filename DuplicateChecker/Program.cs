namespace DuplicateChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<int> arr = [];
            Console.WriteLine("please enter a list of unique numbers separated by a space");

            string[] inputs = Console.ReadLine().Split(' ');

            foreach (var item in inputs)
            {
                arr.Add(Convert.ToInt32(item));
            }

            arr.Sort();

            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] == arr[i - 1]) throw new ArgumentException("numbers are duplicates");

            }


            Console.WriteLine("you list is contain only unique numbers");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


        }




    }
}
