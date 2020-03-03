using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using ReflectionExercise;
using Xunit;
using FluentAssertions;

namespace UnitTestReflectionExercise
{
  public class ReflectionTests
  {

    [Fact]
    public void T01_ListTest()
    {
      var expected = new ArrayList { "abc", "def", "ghi" };
      object obj = Program.T01_List();
      Assert.IsType<ArrayList>(obj);
      var actual = obj as ArrayList;
      actual.Should().Equal(expected);
    }

    [Fact]
    public void T02_DictionaryTest()
    {
      var expected = new Hashtable
      {
        { 1, "Hansi" },
        { 2, "Susi" }
      };
      object obj = Program.T02_Dictionary();
      Assert.IsType<Hashtable>(obj);
      var actual = obj as Hashtable;
      actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void T03_ParseTest()
    {
      int val = 123;
      object actual = Program.T03_Parse("" + val);
      Assert.IsType<int>(actual);
      Assert.Equal(val, Convert.ToInt32(actual));
    }

    [Fact]
    public void T04_GetFontTest()
    {
      //var rect = new System.Drawing.Rectangle(10, 10, 50, 50);
      var font = new System.Drawing.Font("Arial", 12);
      float expected = font.GetHeight(100);
      object actual = Program.T04_GetFontHeight();
      Assert.IsType<float>(actual);
      Assert.Equal(expected, actual);
    }

    [Fact]
    public void T05_ConcreteShapes()
    {
      Program.T05_ConcreteShapes("ShapeLib").Should().Equal(new List<string> { "Circle", "Line", "Rectangle", "Trapez", "Triangle" });
      Program.T05_ConcreteShapes("DummyLib").Should().Equal(new List<string> { });
    }
    [Fact]
    public void T06_VoidMethods()
    {
      var expected = new List<string> { "Circle::Draw", "Line::Draw", "PointShape::Draw", "Rectangle::Draw", "BaseShape::Draw", "SomeDummyClass::MethodWithOneParameter", "SomeDummyClass::MethodWithTwoParameters", "Trapez::Draw", "Triangle::Draw" };
      Program.T06_VoidMethods("ShapeLib").Should().Equal(expected);
      Program.T06_VoidMethods("DummyLib").Should().Equal(new List<string> { "DummyClass::DummyF", "DummyClass::StaticDummy" });
    }
    [Fact]
    public void T07_TwoOrMoreParameters()
    {
      Program.T07_TwoOrMoreParameters("ShapeLib").Should().Equal(new List<string> { "SomeDummyClass::MethodWithTwoParameters" });
      Program.T07_TwoOrMoreParameters("DummyLib").Should().Equal(new List<string> { "AAA::Squared", "DummyClass::DummyH", "ClassA::G", "ClassB::G", "ClassC::H" });
    }
    [Fact]
    public void T08_AllProperties()
    {
      var expected = new List<string> { "Circle::TopLeftX", "Circle::TopLeftY", "Circle::Width", "Circle::Height", "Circle::Color", "Circle::Fill", "Circle::Brush", "Circle::Pen", "Line::TopLeftX", "Line::TopLeftY", "Line::Width", "Line::Height", "Line::Color", "Line::Fill", "Line::Brush", "Line::Pen", "PointShape::TopLeftX", "PointShape::TopLeftY", "PointShape::Width", "PointShape::Height", "PointShape::Color", "PointShape::Fill", "PointShape::Brush", "PointShape::Pen", "Rectangle::TopLeftX", "Rectangle::TopLeftY", "Rectangle::Width", "Rectangle::Height", "Rectangle::Color", "Rectangle::Fill", "Rectangle::Brush", "Rectangle::Pen", "BaseShape::TopLeftX", "BaseShape::TopLeftY", "BaseShape::Width", "BaseShape::Height", "BaseShape::Color", "BaseShape::Fill", "BaseShape::Brush", "BaseShape::Pen", "Trapez::TopLeftX", "Trapez::TopLeftY", "Trapez::Width", "Trapez::Height", "Trapez::Color", "Trapez::Fill", "Trapez::Brush", "Trapez::Pen", "Triangle::TopLeftX", "Triangle::TopLeftY", "Triangle::Width", "Triangle::Height", "Triangle::Color", "Triangle::Fill", "Triangle::Brush", "Triangle::Pen" };
      Program.T08_AllProperties("ShapeLib").Should().Equal(expected);
      Program.T08_AllProperties("DummyLib").Should().Equal(new List<string> { "AAA::DummyProp", "DummyClass::DummyProp" });
    }
    [Fact]
    public void T09_ClassesWithNonDefaultConstructor()
    {
      Program.T09_ClassesWithNonDefaultConstructor("ShapeLib").Should().Equal(new List<string> { "SomeDummyClass" });
      Program.T09_ClassesWithNonDefaultConstructor("DummyLib").Should().Equal(new List<string> { "DummyClass" });
    }
    [Fact]
    public void T10_ClassesImplementingDraw()
    {
      Program.T10_ClassesImplementingDraw("ShapeLib").Should().Equal(new List<string> { "Circle", "Line", "Rectangle", "Trapez", "Triangle" });
      Program.T10_ClassesImplementingDraw("DummyLib").Should().Equal(new List<string> { });
    }
  }
}
