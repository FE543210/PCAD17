namespace Assignments6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Q myq = new();
            myq.Enqueu("111-457-4715");
            myq.Enqueu("222-457-4715");
            myq.Enqueu("333-457-4715");
            myq.Display();
            myq.Deque();
            myq.Deque();
            myq.Display();
            myq.Deque();
            myq.Display();

        }
    }
}
