using System;
namespace Sort
{
    public class Program
    {
        public static void Main()
        {
            const string MsgUnsorted = "Array original: ";
            const string MsgSorted = "Array ordenat: ";

            int[] marks = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };

            Console.WriteLine(MsgUnsorted);
            foreach (int num in marks)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");

            for (int i = 0; i < marks.Length; i++)
            {
                for (int j = i + 1; j < marks.Length; j++)
                {
                    if (marks[i] < marks[j])
                    {
                        int aux = marks[i];
                        marks[i] = marks[j];
                        marks[j] = aux;
                    }
                }
            }

            Console.WriteLine(MsgSorted);
            foreach (int num in marks)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
