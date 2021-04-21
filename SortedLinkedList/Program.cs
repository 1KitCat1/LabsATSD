using System;

namespace SortedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>(0);
            for (int i = 0; i < 8; i++)
            {
                list.InsertSorted(i);
            }
            list.Print();
            list.Delete(3);
            list.Print();
            list.InsertSorted(3);
            //list.InsertSorted(7);
            list.InsertSorted(8);
            list.Print();
            //list.AppendHead(1);
            //List.DeleteDuplicated();
            list.Print();
            //list.Reverse();
            list.Print();
            
            var list2 = new LinkedList<string>("abc");
            list2.InsertSorted("bce");
            list2.InsertSorted("cde");
            list2.InsertSorted("dde");
            list2.InsertSorted("cde");
            
            var list3 = new LinkedList<string>("qrft");
            list3.InsertSorted("rtw");
            list3.InsertSorted("sfrf");
            list3.InsertSorted("trfr");
            list3.InsertSorted("udfk");

            var list4 = new LinkedList<string>("abc");
            list4.InsertSorted("zced");
            list4.InsertSorted("tef");
            list4.InsertSorted("ofg");
            list4.InsertSorted("gaf");

            list2.Print();
            list3.Print();
            list4.Print();

            Console.WriteLine(list2.LengthOfLongestSubsequence());
            Console.WriteLine(list3.LengthOfLongestSubsequence());
            Console.WriteLine(list4.LengthOfLongestSubsequence());

            
            Console.WriteLine(Math.Max(list2.LengthOfLongestSubsequence(), 
                Math.Max(list3.LengthOfLongestSubsequence(), list4.LengthOfLongestSubsequence())));
            Console.Read();

        }
    }
}