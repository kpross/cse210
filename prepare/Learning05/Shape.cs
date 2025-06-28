// Parent Class
public class Shape
{
    // Set Color
    private string _color;

    // personal stretch
    private string _type;
    // Constructor
    public Shape(string type, string color)
    {
        _type = type;
        _color = color;
    }
    
    

    // Grabing the Color
    public string GetColor()
    {
        return _color;
    }

    // personal stretch name
    public string GetType()
    {
        return _type;
    }

    //Setting the Color
    public void SetColor(string color)
    {
        _color = color;
    }

    // personal stretch setting th type
    public void SetType(string type)
    {
        _type = type;
    }

    // Since we don't know the equation for all possible shapes that will be coded we just set it as virtual and put out a value of 0 so that the child classes can adjust as needed
    // Perhaps abstract would be better here since someone could code a child class and forget to overide the GetArea
    public virtual double GetArea()
    {
        return 0;
    }

}