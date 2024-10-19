using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution.FollowPrinciple
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public Rectangle()
        {
            
        }
        public int GetWidth()
        {
            return Width;
        }
        public int GetHeight()
        {
            return Height;
        }
        public int SetWidth(int width)
        {
            Width = width;
            return Width;
        }
        public int SetHeight(int height)
        {
            Height = height;
            return Height;
        }
        public int GetArea()
        {
            return Width * Height;
        }
    }
}
