using System;


namespace Sphere
{
    class Program
    {
      


           public static double diameter;
		/**
	 * Empty-argument constructor to put object
	 * into a consistent state.
	 */

			public static void Main(string[] args)
		{
			Console.WriteLine("Enter Diamter:");
			diameter = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Result" + toString(diameter) + "Volume: " + getVolume(diameter) + "Surface Area: " + getSurfaceArea(diameter)
				);
		}
		public void Sphere()
		{
			
		}//end constructor

		/**
		 * Constructor accepts value of diameter.
		 * Preferred constructor.
		 * @param diameter
		 */
		public void Sphere(double diameter)
		{

			this.setDiameter(diameter);

		}//end constructor

		/**
		 * Calculates the volume of the sphere.
		 * @return volume
		 */
		public static double getVolume(double diameter)
		{

			return (4.0 / 3.0) * Math.PI * Math.Pow(diameter / 2, 3);

		}//end getVolume

		/**
		 * Calculates the surface area of the sphere.
		 * @return - surface area
		 */
		public static double getSurfaceArea(double diameter)
		{
			//Console.WriteLine("Enter Diameter:");
			//diameter = Convert.ToInt16(Console.ReadLine());
			return 4.0 * Math.PI * Math.Pow(diameter / 2, 2);
		}//end getSurfaceArea


		/**
		 * Getter for diameter
		 * @return
		 */
		public double getDiameter()
		{
			//Console.WriteLine("Enter Diameter:");
			//diameter = Convert.ToInt16(Console.ReadLine());
			return diameter;
		}//end getDiameter

		/**
		 * Setter for diameter. Checks bound on
		 * formal parameter and resets to 2 if
		 * the value is less than 2.
		 * @param diameter
		 */
		public void setDiameter(double diameter)
		{
			if (diameter < 2)
				diameter = 2;
			else
				diameter = diameter;
		}//end setDiameter

		
	public static string toString(double diameter)
		{
			
			return "Sphere [diameter= " + diameter;
		}//end toString

	}
}

