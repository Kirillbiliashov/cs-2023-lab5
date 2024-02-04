using System;
namespace lab5.Model
{
	public class Salad
	{

		private List<Vegetable> Vegetables { get; init; }


        public double TotalCaloroies
        {
            get =>
                Vegetables.Select(v => v.Calories).Sum();

        }

        public Salad(List<Vegetable> vegetables)
		{
			Vegetables = vegetables;
		}


        public IEnumerable<Vegetable> VegetablesInCaloriesRange(double start, double end)
        {
            if (start >= end)
            {
                throw new ArgumentException("The provided calories range should be valid", nameof(start));
            }
            return Vegetables.Where(v => v.Calories >= start && v.Calories <= end);
        }

        public void SortVegetablesByQuantity()
        {
            var size = Vegetables.Count;
            for (int i = 0; i < size - 1; i++)
            {
                var swapHappened = false;
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (Vegetables[j].Quantity > Vegetables[j + 1].Quantity)
                    {
                        var temp = Vegetables[j];
                        Vegetables[j] = Vegetables[j + 1];
                        Vegetables[j + 1] = temp;
                        swapHappened = true;
                    }
                }
                if (!swapHappened) break;
            }
        }



    }
}

