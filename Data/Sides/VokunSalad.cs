/*		
 *		Author: Justin Graham
 * 
 *		Class name: VokunSalad.cs
 *		Purpose: To encapsulate all code/data regarding a Vokun Salad order
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
	public class VokunSalad
	{
		/// <summary>
		/// Gets the price of the side
		/// </summary>
		public double Price
		{
			get
			{
				if (size == Data.Enums.Size.Small) return 0.93;
				else if (size == Data.Enums.Size.Medium) return 1.28;
				else if (size == Data.Enums.Size.Large) return 1.82;
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
				if (size == Data.Enums.Size.Small) return 41;
				else if (size == Data.Enums.Size.Medium) return 52;
				else if (size == Data.Enums.Size.Large) return 73;
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
			return "" + Size + " Vokun Salad";
		}

	}
}


