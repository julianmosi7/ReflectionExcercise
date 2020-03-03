using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib
{
  public class SomeDummyClass
  {
    public SomeDummyClass()
    {
    }

    public SomeDummyClass(string s)
    {
      //just to have a second constructor
    }

    public void MethodWithOneParameter(int x)
    {
    }

    public void MethodWithTwoParameters(int x, string y)
    {
    }

    public DateTime MethodWithReturnValue(DateTime t) => t;
  }
}
