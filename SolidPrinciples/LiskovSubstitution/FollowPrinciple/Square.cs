using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitution.FollowPrinciple
{
    public class Square : Rectangle
    {
        private int _side;
        public override int Width 
        {
            get
            {
                return _side;
            }
            set
            {
                _side = value;
                base.SetHeight(_side);
                base.SetWidth(_side);
            }
        }
        public override int Height
        {
            get
            {
                return _side;
            }
            set
            {
                _side = value;
                base.SetHeight(_side);
                base.SetWidth(_side);
            }
        }
        
        public Square(int side)
        {
            _side = side;
        }
        public void SetHeight()
        {
            base.SetHeight(_side);
        }
        public void SetWidth()
        {
            base.SetWidth(_side);
        }
        public int getWidth()
        {
            return base.GetWidth();
        }
        public int getHeight()
        {
            return base.GetHeight();
        }
    }
}
