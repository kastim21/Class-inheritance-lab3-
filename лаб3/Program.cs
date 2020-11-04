using System;


class CPoint
{
    public double x { get; set; }
    public double y { get; set; }
    public CPoint(double X, double Y) { x = X; y = Y; }

    public  void Show()
    {
        Console.WriteLine("parent class: \nx= " + x +", y= " + y); 
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


    public  void Show()
    {
        base.Show();
        Console.WriteLine("class Circle: \nRadius= " + Radius + ", Diameter= " + Diameter() + ", Circumference= " + Circumference()) ;
        
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