/*		
 *		Author: Justin Graham
 * 
 *		Class name: MarkarthMilk.cs
 *		Purpose: To encapsulate all code/data regarding a Markarth Milk order
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
	public class MarkarthMilk
	{
		/// <summary>
		/// Gets the price of the drink
		/// </summary>
		public double Price
		{
			get
			{
				if (size == Data.Enums.Size.Small) return 1.05;
				else if (size == Data.Enums.Size.Medium) return 1.11;
				else if (size == Data.Enums.Size.Large) return 1.22;
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
				if (size == Data.Enums.Size.Small) return 56;
				else if (size == Data.Enums.Size.Medium) return 72;
				else if (size == Data.Enums.Size.Large) return 93;
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

		/// <summary>
		/// Generates and returns a list of special instructions (empty list = no special instructions)
		/// </summary>
		public List<string> SpecialInstructions
		{
			get
			{
				List<string> instructions = new List<string>();
				if (Ice) instructions.Add("Add ice");
				return instructions;
			}
		}

		/// <summary>
		/// Returns the name of the drink as a string
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "" + Size + " Markarth Milk";
		}

	}
}


