
namespace Rechteck_Aufgabe
{
    internal class Rechteck
    {

        public double Height {  get; set; }
        public double Width { get; set; }


        public double GetArea() 
        {
            double area = Height * Width;

            return area;
        }
    }
}
