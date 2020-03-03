using System;
using System.Windows;
using System.Windows.Media;

namespace ShapeLib
{
  [Serializable]
  internal class Line : BaseShape
  {
    public override void Draw(DrawingContext g)
    {
      g.DrawLine(new Pen(baseBrush, 2),
        new Point(TopLeftX, TopLeftY),
        new Point(TopLeftX + Width, TopLeftY + Height));
    }
  }
}
