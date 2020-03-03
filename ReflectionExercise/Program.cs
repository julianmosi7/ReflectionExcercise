using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ShapeLib;

namespace ReflectionExercise
{
  public static class ExtensionMethods
  {
    public static IEnumerable<T> Print<T>(this IEnumerable<T> collection)
    {
      collection.ToList().ForEach(x => Console.WriteLine($"  {x}"));
      Console.WriteLine();
      return collection;
    }
  }

  public class Program
  {
    public const string pathCorlib = @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\mscorlib.dll";
    private static void Main()
    {
      if (!System.IO.File.Exists(pathCorlib))
      {
        Console.WriteLine($"Path for pathCorlib is incorrect!");
        Console.WriteLine($"File {pathCorlib} not found!");
        Console.ReadKey();
        return;
      }
      try
      {
        var list = T01_List();
        var dict = T02_Dictionary();
        var val = T03_Parse("123");
        var sFont = T04_GetFontHeight();
        T05_ConcreteShapes("ShapeLib").Print();
        T05_ConcreteShapes("DummyLib").Print();
        T06_VoidMethods("ShapeLib").Print();
        T06_VoidMethods("DummyLib").Print();
        T07_TwoOrMoreParameters("ShapeLib").Print();
        T07_TwoOrMoreParameters("DummyLib").Print();
        T08_AllProperties("ShapeLib").Print();
        T08_AllProperties("DummyLib").Print();
        T09_ClassesWithNonDefaultConstructor("ShapeLib").Print();
        T09_ClassesWithNonDefaultConstructor("DummyLib").Print();
        T10_ClassesImplementingDraw("ShapeLib").Print();
        T10_ClassesImplementingDraw("DummyLib").Print();
      }
      catch (Exception exc)
      {
        Console.WriteLine(exc.ToString());
      }
      Console.ReadKey();
    }

    public static object T01_List()
    {
            Assembly assembly = Assembly.LoadFile(pathCorlib);
            Type type = assembly.GetType("ArrayList");
            object instance = Activator.CreateInstance(type, new object[] { 5 });
            MethodInfo methodInfo = type.GetMethod("Add");
            ArrayList result;
            result = new ArrayList();
            methodInfo.Invoke(instance, new object[] { "abc", "def", "ghi" });
            return new ArrayList();
    }

    public static object T02_Dictionary()
    {
      return new Hashtable();
    }

    public static object T03_Parse(string sVal)
    {
            Assembly assembly = Assembly.LoadFile(pathCorlib);
            Type type = assembly.GetType("Int32");
            object instance = Activator.CreateInstance(type, new object[] { 5 });
            MethodInfo methodInfo = type.GetMethod("Parse", new[] { typeof(string) });
            object result = methodInfo.Invoke(instance, new object[] { sVal });
            return result; 
    }

    public static object T04_GetFontHeight()
    {
            Assembly assembly = Assembly.LoadFile(pathCorlib);
            Type type = assembly.GetType("Font");
            object instance = Activator.CreateInstance(type);
            MethodInfo methodInfo = type.GetMethod("GetHeight", new[] { typeof(string) });
            object result = methodInfo.Invoke(instance, new object[] { 100 });
            return result;
        }

    public static IEnumerable<string> T05_ConcreteShapes(string localAssemblyame)
    {
      Console.WriteLine($"T05_ConcreteShapes {localAssemblyame}");
      return new List<string>();
    }

    public static IEnumerable<string> T06_VoidMethods(string localAssemblyame)
    {
      Console.WriteLine($"T06_VoidMethods {localAssemblyame}");
      return new List<string>();
    }

    public static IEnumerable<string> T07_TwoOrMoreParameters(string localAssemblyame)
    {
      Console.WriteLine($"T07_TwoOrMoreParameters {localAssemblyame}");
      return new List<string>();
    }

    public static IEnumerable<string> T08_AllProperties(string localAssemblyame)
    {
      Console.WriteLine($"T08_AllProperties {localAssemblyame}");
      return new List<string>();
    }

    public static IEnumerable<string> T09_ClassesWithNonDefaultConstructor(string localAssemblyame)
    {
      Console.WriteLine($"T09_ClassesWithNonDefaultConstructor {localAssemblyame}");
      return new List<string>();
    }

    public static IEnumerable<string> T10_ClassesImplementingDraw(string localAssemblyame)
    {
      Console.WriteLine($"T10_ClassesImplementingDraw {localAssemblyame}");
      return new List<string>();
    }

  }
}
