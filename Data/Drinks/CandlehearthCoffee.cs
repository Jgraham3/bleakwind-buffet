/*		
 *		Author: Justin Graham
 * 
 *		Class name: CandlehearthCoffee.cs
 *		Purpose: To encapsulate all code/data regarding a Candlehearth Coffee order
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
	public class CandlehearthCoffee
	{
		/// <summary>
		/// Gets the price of the drink
		/// </summary>
		public double Price
		{
			get
			{
				if (size == Data.Enums.Size.Small) return 0.75;
				else if (size == Data.Enums.Size.Medium) return 1.25;
				else if (size == Data.Enums.Size.Large) return 1.75;
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Gets the calories of the drink
		/// </summary>
		public uint Calories
		{
			get
			{
				if (size == Data.Enums.Size.Small) return 7;
				else if (size == Data.Enums.Size.Medium) return 10;
				else if (size == Data.Enums.Size.Large) return 20;
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Gets the size of the drink
		/// </summary>
		private Data.Enums.Size size;
		public Data.Enums.Size Size
		{
			get
			{
				return size;
			}
			set
			{
				size = value;
			}
		}

		private bool ice = false;
		/// <summary>
		/// Gets if the drink has ice
		/// </summary>
		public bool Ice
		{
			get
			{
				return ice;
			}
			set
			{
				ice = value;
			}
		}

		private bool roomForCream = false;
		/// <summary>
		/// Gets if the drink has room for cream
		/// </summary>
		public bool RoomForCream
		{
			get
			{
				return roomForCream;
			}
			set
			{
				roomForCream = value;
			}
		}

		private bool decaf = false;
		/// <summary>
		/// Gets if the drink is decaf
		/// </summary>
		public bool Decaf
		{
			get
			{
				return decaf;
			}
			set
			{
				decaf = value;
			}
		}

		/// <summary>
		/// Generates and returns a list of special instructions (empty list = no special instructions)
		/// </summary>
		public List<string> SpecialInstructions
		{
			get
			{
				List<string> instructions = new List<string>();
				if (Ice) instructions.Add("Add ice");
				if (RoomForCream) instructions.Add("Add cream");
				return instructions;
			}
		}

		/// <summary>
		/// Returns the name of the drink as a string
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			if (Decaf)
			{
				return "" + Size + " Decaf Candlehearth Coffee";
			}
			return "" + Size + " Candlehearth Coffee";

		}

	}
}



