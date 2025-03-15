using System;

namespace Bai27 {
    class Program {
        static void Main(string[] args)
        {
            // Queue<string> cacHoSo = new Queue<string>();
            // cacHoSo.Enqueue("Hoang");
            // cacHoSo.Enqueue("Hai");
            // cacHoSo.Enqueue("Hoa");
            // while (cacHoSo.Count > 0)
            // {
            //     Console.WriteLine($"Ho so cua {cacHoSo.Dequeue()} da duoc xu ly - con lai {cacHoSo.Count} ho so");
            // }

            LinkedList<string> BaiHoc = new LinkedList<string>();
            var bh1 = BaiHoc.AddFirst("bai 1");
            var bh3 = BaiHoc.AddLast("Bai3");
            LinkedListNode<string> bh2 = BaiHoc.AddAfter(bh1, "Bai 2");
            BaiHoc.AddLast("Bai 4");

            var node = BaiHoc.Last;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Previous;
            }
        }
    }
}