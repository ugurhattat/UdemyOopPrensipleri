using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Product
{
    //static int _staticField;
    int _normalField;
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public int NormalProperty { get; set; }
    public static int StaticProperty { get; set; }

    public void NormalMethod()
    {
        _normalField = 10;
        //_staticField = 20;
    }
     public static void StaticMethod()
    {
        //_staticField = 10;
    }

    public override string ToString()
    {
        return $"ID:{ID}  Name:{Name} Price:{Price:C2}";
    }
}
