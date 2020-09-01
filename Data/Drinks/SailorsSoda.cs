/*		
 *		Author: Justin Graham
 * 
 *		Class name: SailorsSoda.cs
 *		Purpose: To encapsulate all code/data regarding a Sailor's Soda order
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
	public class SailorsSoda
	{
		/// <summary>
		/// Gets the price of the drink
		/// </summary>
		public double Price
		{
			get
			{
				if (size == Data.Enums.Size.Small) return 1.42;
				else if (size == Data.Enums.Size.Medium) return 1.74;
				else if (size == Data.Enums.Size.Large) return 2.07;
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
				if (size == Data.Enums.Size.Small) return 117;
				else if (size == Data.Enums.Size.Medium) return 153;
				else if (size == Data.Enums.Size.Large) return 205;
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

		private Data.Enums.SodaFlavor flavor;
		/// <summary>
		/// Gets the flavor of the soda
		/// </summary>
		public Data.Enums.SodaFlavor Flavor
		{
			get
			{
				return flavor;
			}
			set
			{
				flavor = value;
			}
		}

		private bool ice = true;
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
				if (!Ice) instructions.Add("Hold ice");
				return instructions;
			}
		}

		

		/// <summary>
		/// Returns the name of the drink as a string
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "" + Size + " " + Flavor + " Sailor's Soda";
		}

	}
}


