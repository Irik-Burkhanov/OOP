using System;
using System.Collections.Generic;
using System.Text;

namespace laba_nomer3
{
    public abstract class Some_class
    {
        public virtual void getName() 
        { 
            //Console.WriteLine("Some_class");
        }
    }
    public class Point: Some_class
    {
        public override void getName()
        {
            //base.getName();
            Console.WriteLine("Point");
        }
    }
    public class Point3d : Some_class
    {
        public override void getName()
        {
            Console.WriteLine("Point3d");
        }
    }
    public class Color_Point : Some_class
    {
        public override void getName()
        {
            Console.WriteLine("Color_Point");
        }
    }
    public class Circle : Some_class
    {
        public override void getName()
        {
            Console.WriteLine("Circle");
        }
    }
}
