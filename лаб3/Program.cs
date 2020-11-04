using System;

abstract class CGraphicsObject
{
    public abstract void Show();
      
}
class CPoint : CGraphicsObject
{
    public double x { get; set; }
    public double y { get; set; }
    public CPoint(double X, double Y) { x = X; y = Y; }
    public override  void Show()
    {
        Console.WriteLine("CPoint: x= " + x +", y= " + y); 
    }

}
class Circle : CPoint
{
    public double Radius { get; set; }

    public Circle (double a, double X, double Y ) : base(X,Y) { Radius = a;  }

    public double Diameter()
    {
        return Radius * 2;
    }
    public double Circumference()
    {
        return 2 * Math.PI * Radius;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine("Circle: Radius= " + Radius + ", Diameter= " + Diameter() + ", Circumference= " + Circumference()) ;
    }
    ~Circle()
    {
        Console.WriteLine("disposed");
    }
}

class HelloWorld
{
    static void Main()
    {
        Circle Circle1 = new Circle(5.25,2,3);
          Circle1.Show();

    }
}