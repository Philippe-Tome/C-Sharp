using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _5._1_method_overridint_code_along
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);

        }
    }
}
