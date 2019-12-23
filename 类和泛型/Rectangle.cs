using System;
using System.Collections.Generic;
using System.Text;

namespace 类和泛型
{
    public class Rectangle : IComparable
    {
        /// <summary>
        /// 长方形自定义排序规则
        /// </summary>
        public Rectangle()
        {
        }
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }
        public double Height { get; set; }
        public double Width { get; set; }

        public int CompareTo(object obj)
        {
            Rectangle rectangle = obj as Rectangle;
            if (rectangle!=null)
            {
                return CompareTo(rectangle);
            }
            throw
                new ArgumentException("不是同一类型无法比较");
        }
        public int CompareTo(Rectangle rectangle)
        {
            double area1 = this.Height * this.Width;
            double area2 = rectangle.Height * rectangle.Width;
            if (area1==area2)
            {
                return 0;

            }
            else if (area1 > area2)
            {
                return 1;
            }
            else if (area1 < area2)
            {
                return -1;
            }
            else
            {
                return -1;

            }

        }

        public override bool Equals(object obj)
        {
            return obj is Rectangle rectangle &&
                   Height == rectangle.Height &&
                   Width == rectangle.Width;
        }
        public override string ToString()
        {
            return $"height:{this.Height},width:{this.Width}";
        }
        public override int GetHashCode()
        {
            return this.Height.GetHashCode()|this.Width.GetHashCode();
        }
    }
}
