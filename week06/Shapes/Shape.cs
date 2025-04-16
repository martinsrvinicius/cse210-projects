public class Shape {
    public string _color;
    public string _name; 

    public Shape(string color, string name) {
        _color = color;
        _name = name;
    }

    public string GetColor() {
        return _color;
    }
    public string GetName() {
        return _name;
    }

    public void SetColor(string color) {
        _color = color;
    }
    public void SetName(string name) {
        _name = name;
    }
    
    public virtual double GetArea() {
        return 0;
    }
}