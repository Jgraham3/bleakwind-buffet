/*		
 *		Author: Justin Graham
 * 
 *		Class name: AretinoAppleJuice.cs
 *		Purpose: To encapsulate all code/data regarding a Aretino Apple Juice order
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
	public class AretinoAppleJuice
	{
		/// <summary>
		/// Gets the price of the drink
		/// </summary>
		public double Price
		{
			get
			{
				if (size == Data.Enums.Size.Small) return 0.62;
				else if (size == Data.Enums.Size.Medium) return 0.87;
				else if (size == Data.Enums.Size.Large) return 1.01;
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
				if (size == Data.Enums.Size.Small) return 44;
				else if (size == Data.Enums.Size.Medium) return 88;
				else if (size == Data.Enums.Size.Large) return 132;
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
			return "" + Size + " Aretino Apple Juice";
		}

	}
}


