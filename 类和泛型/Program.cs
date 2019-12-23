using System;
using System.Collections.Generic;

namespace 类和泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle1 = new Rectangle(1, 2);
            var rectangle2 = new Rectangle(1, 2);
            var result = rectangle1.CompareTo(rectangle2);
            List<Rectangle> rectangles = new List<Rectangle>()
            {
                new Rectangle(1,3),
                new Rectangle(4,3),
                new Rectangle(2,1),
                new Rectangle(6,1),
            };

            rectangles.Sort();//经过这一行就按照面积排序了
            var searchresult = rectangles.BinarySearch(new Rectangle(6, 1)); //使用二分查找必须是有序的

            foreach (var item in rectangles)
            {
                Console.WriteLine(item);
            }
            rectangles.Sort(new CompareHeight()); //按照高度排序了
            var searchresult2 = rectangles.BinarySearch(new Rectangle(6, 1), new CompareHeight()); //使用二分查找必须是有序的

            foreach (var item in rectangles)
            {
                Console.WriteLine(item);
            }

        }
    }
}
