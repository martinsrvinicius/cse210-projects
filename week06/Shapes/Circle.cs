using System;
public class Circle : Shape {
    private double _radius;

    public Circle(string color, string name, double radius) : base(color, name) {
        _radius = radius;
    }
    
    public double GetRadius() {
        return _radius;
    }
    public void SetRadius(double radius) {
        _radius = radius;
    }

    public override double GetArea() {
        return _radius * _radius * _radius;
    }

}