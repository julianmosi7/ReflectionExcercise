using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapeLib
{
  [Serializable]
  public abstract class BaseShape
  {
    #region ------------------------- Propterties
    public int TopLeftX { get; set; }
    public int TopLeftY { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    [NonSerialized]
    protected Color color;
    [NonSerialized]
    protected Brush baseBrush;
    public Color Color
    {
      get => color;
      set
      {
        color = value;
        baseBrush = new SolidColorBrush(color);
      }
    }

    public bool Fill { get; set; }

    public Brush Brush => Fill ? baseBrush : null;
    public Pen Pen => Fill ? null : new Pen(baseBrush, 2);
    #endregion

    protected BaseShape()
    {
      TopLeftX = 0;
      TopLeftY = 0;
      Width = 50;
      Height = 40;
      Color = Colors.Blue;
      Fill = false;
    }

    public abstract void Draw(DrawingContext g);

  }
}
