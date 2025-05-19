namespace Assignments7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testOne= { 1, 3, 2, 4, 6, 5, 8, 7, 9, -1 };
            int[] testTwo = { 1, 3, 2, 4, 6, 5, 8, 7, 9, -1 };
            int[] testThree = { 1, 3, 2, 4, 6, 5, 8, 7, 9, -1 };

            TripleSorts.BubbleSort(testOne);
            TripleSorts.InsertionSort(testTwo);
            TripleSorts.SelectionSort(testThree);
            TripleSorts.Display(testOne);
            TripleSorts.Display(testTwo);
            TripleSorts.Display(testThree);

            wordMerge.WordMerge("ace","bdf");
            wordMerge.WordMerge("ace", "bdfjklmn");
        }
    }
}
