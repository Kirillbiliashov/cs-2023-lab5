using System;
namespace lab5.Model
{
	public class Tomato: Vegetable
	{
		public Tomato(double quantity): base(quantity)
		{
			CaloriesPerPiece = 22;
			Color = "Red";
		}
	}
}

