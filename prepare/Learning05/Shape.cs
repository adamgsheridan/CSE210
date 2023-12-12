using System;
namespace Learning05
{
    public class Shape
    {
        // Add the color member variable.
        private string _color;

        // Getter and setter for it.
        public string GetColor()
        {
            return "";
        }

        public void SetColor()
        {
            _color = "";
        }

        // Create a constructor that accepts the color and set its.
        public Shape(string color)
        {
            _color = color;
        }

        // Create a virtual method for GetArea().
        public virtual float GetArea()
        {
            return -1;
        }
    }
}
