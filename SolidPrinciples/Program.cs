using SolidPrinciples.LiskovSubstitution.FollowPrinciple;

namespace SolidPrinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 20);
            GetArea(rect);

            Rectangle square = new Square(10);

            GetArea(square);
        }
        public static void GetArea(Rectangle x)
        {
            Console.WriteLine("Width: {0}", x.GetWidth());
            Console.WriteLine("Height: {0}", x.GetHeight());
            int area = x.GetArea();
            Console.WriteLine("Area: {0}", area);
        }
    }
}
