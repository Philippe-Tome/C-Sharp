using System;
using System.Collections.Generic;

namespace _5._1_method_overridint_code_along
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
