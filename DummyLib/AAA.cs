using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#pragma warning disable 1591 //to hide warnings due to missing docs

namespace DummyLib
{
  public class AAA
  {
    public double Wurzel(int x) => Math.Sqrt(x);
    public double Squared(double x, double exp) => Math.Pow(x, exp);

    public int DummyProp { get; set; }
  }
}
