/*		
 *		Author: Justin Graham
 * 
 *		Class name: MadOtarGrits.cs
 *		Purpose: To encapsulate all code/data regarding a Mad Otar Grits order
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
	public class MadOtarGrits
	{
		/// <summary>
		/// Gets the price of the side
		/// </summary>
		public double Price
		{
			get
			{
				if (size == Data.Enums.Size.Small) return 1.22;
				else if (size == Data.Enums.Size.Medium) return 1.58;
				else if (size == Data.Enums.Size.Large) return 1.93;
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
				if (size == Data.Enums.Size.Small) return 105;
				else if (size == Data.Enums.Size.Medium) return 142;
				else if (size == Data.Enums.Size.Large) return 179;
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
			return "" + Size + " Mad Otar Grits";
		}

	}
}


