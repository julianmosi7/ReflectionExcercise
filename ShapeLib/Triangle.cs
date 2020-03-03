using System;
using System.Collections.Generic;
using System.Windows;

namespace ShapeLib
{
  [Serializable]
  internal class Triangle : PointShape
  {
    protected override List<Point> Points => new List<Point>
      {
        new Point(TopLeftX + Width/2, TopLeftY),
        new Point(TopLeftX, TopLeftY + Height),
        new Point(TopLeftX + Width, TopLeftY + Height)
      };
  }
}
