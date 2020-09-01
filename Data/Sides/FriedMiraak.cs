/*		
 *		Author: Justin Graham
 * 
 *		Class name: FriedMiraak.cs
 *		Purpose: To encapsulate all code/data regarding a Fried Miraak order
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
	public class FriedMiraak
	{
		/// <summary>
		/// Gets the price of the side
		/// </summary>
		public double Price
		{
			get
			{
				if (size == Data.Enums.Size.Small) return 1.78;
				else if (size == Data.Enums.Size.Medium) return 2.01;
				else if (size == Data.Enums.Size.Large) return 2.88;
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Gets the calories of the side
		/// </summary>
		public uint Calories
		{
			get
			{
				if (size == Data.Enums.Size.Small) return 151;
				else if (size == Data.Enums.Size.Medium) return 236;
				else if (size == Data.Enums.Size.Large) return 306;
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Gets the size of the side
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

		/// <summary>
		/// Generates and returns a list of special instructions (empty list = no special instructions)
		/// </summary>
		public List<string> SpecialInstructions
		{
			get
			{
				List<string> instructions = new List<string>();
				return instructions;
			}
		}

		/// <summary>
		/// Returns the name of the side as a string
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "" + Size + " Fried Miraak";
		}

	}
}


