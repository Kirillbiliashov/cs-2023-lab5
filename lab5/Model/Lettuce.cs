using System;
namespace lab5.Model
{
    public class Lettuce : Vegetable
    {
        public Lettuce(double quantity) : base(quantity)
        {
            CaloriesPerPiece = 4.2;
            Color = "Green";
        }
    }
}

