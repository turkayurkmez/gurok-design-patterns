using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstition
{
    public class Geometry
    {
        public static IArea GetRectangle(int unit1, int? unit2=null)
        {
            if (unit2.HasValue)
            {
                return new Rectangle { Width = unit1, Height = unit2.Value };
            }
            //hayal gücünüz :)
            return new Square() {  EdgeLength = unit1};
        }
    }

    public interface IArea
    {
        int GetArea();
    }
    public class Rectangle : IArea
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public int GetArea() => Width * Height;
    }

    public class Square : IArea// : Rectangle
    {
        //public override int Width
        //{
        //    get => base.Width;
        //    set
        //    {
        //        base.Width = value;
        //        base.Height = value;
        //    }
        //}
        //public override int Height { get => base.Width; set { base.Width = value; base.Height = value; } }
        public int EdgeLength { get; set; }

        public int GetArea() => EdgeLength * EdgeLength;
    }
}
