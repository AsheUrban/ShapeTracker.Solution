using System.Collections.Generic;

namespace ShapeTracker.Models
{
  public class Triangle
  {

    //Side1 is an example of using a C# property to provide access to a private field.
    private int _side1;

    public int Side1
    {
      get { return _side1; }
      set { _side1 = value; }
    }
    
    //Side2 is an example of an auto-implemented property.
    public int Side2 { get; set; }

    private int _side3;
    private static List<Triangle> _instances = new List<Triangle> {};

    public Triangle(int length1, int length2, int length3)
    {
      _side1 = length1;
      Side2 = length2;
      _side3 = length3;
      _instances.Add(this);
    }


//_side3 is an example using getter and setter methods to access a private field, using no properties.
    public int GetSide3()
    {
      return _side3;
    }

    public void SetSide3(int newSide)
    {
      _side3 = newSide;
    }

    public string CheckType()
    {
      if ((_side1 > (Side2+_side3)) || (Side2 > (_side1+_side3)) || (_side3 > (_side1+Side2)))
      {
      return "not a triangle";
      }
      else if ((_side1 !=Side2) && ((_side1 !=_side3)) && ((Side2 !=_side3)))
      {
      return "scalene triangle";
      }
      else if ((_side1 ==Side2) && (Side2 ==_side3))
      {
      return "equilateral triangle";
      }
      else 
      {
      return "isosceles triangle";
      }
    }

      public static List<Triangle> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}