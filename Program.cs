using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1 
            Console.WriteLine("Task 1");
            List<string> list = new List<string>();
            list = AddList(list);
            PrintList(list);
            //Task 2
            Console.WriteLine("Task 2");
            List<string> sortedList = new List<string>();
            sortedList = SortList(list);
            PrintList(sortedList);
            //Task 3
            Console.WriteLine("Task 3");
            HashSet<string> hashList1 = new HashSet<string>();
            HashSet<string> hashList2 = new HashSet<string>();
            List<string> hashList = new List<string>();
            hashList1.Add("item1");
            hashList1.Add("item2");
            hashList1.Add("item3");
            hashList2.Add("item3");
            hashList2.Add("item1");
            hashList2.Add("item5");
            hashList2.Add("item6");
            hashList2.ExceptWith(hashList1);
            hashList = hashList2.ToList();
            hashList.Sort();
            foreach(var item in hashList)
            {
                Console.WriteLine(item);
            }
            //Task 4
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("item");
            queue.Dequeue();
            //Task 5
            Console.WriteLine("Task 5");
            Dictionary<int, string> carCodes = new Dictionary<int, string>();
            carCodes.Add(0, "BMW");
            carCodes.Add(1, "TOYOTA");
            carCodes.Add(2, "HONDA");
            foreach(var cars in carCodes)
            {
                Console.WriteLine($"Car code {cars.Key}, Car Name {cars.Value}");
            }
            Console.ReadLine();

        }
        static List<string> AddList(List<string> list)
        {
            list.Add("item3");
            list.Add("item1");
            list.Add("item2");
            return list;
        }
        
        static List<string> SortList(List<string> list)
        {
            List<string> SortList = new List<string>();
            SortList.AddRange(list);
            SortList.Sort();
            return SortList;
        }
        static void PrintList(List<string> list)
        {
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
        
    }
    
}
