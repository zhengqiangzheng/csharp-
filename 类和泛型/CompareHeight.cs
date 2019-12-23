using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace 类和泛型
{
    /// <summary>
    /// 比较长方形的高度 放到list<rectangle>的sort()的参数里
    /// </summary>
    class CompareHeight : IComparer<Rectangle>
    {
        public int Compare([AllowNull] Rectangle x, [AllowNull] Rectangle y)
        {
            if (x==null||y==null)
            {
                throw new ArgumentException("不能为空");
            }
            else
            {
                if (x.Height==y.Height)
                {
                    return 0;
                }
                else if (x.Height>y.Height)
                {
                    return 1;
                }
                else if (x.Height < y.Height)
                {
                    return -1;
                }
            }
            return -1;
        }

    }
}
