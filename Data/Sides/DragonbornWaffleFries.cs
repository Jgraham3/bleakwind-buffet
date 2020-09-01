/*		
 *		Author: Justin Graham
 * 
 *		Class name: DragonbornWaffleFries.cs
 *		Purpose: To encapsulate all code/data regarding a Dragonborn Waffle Fries order
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
	public class DragonbornWaffleFries
	{
		/// <summary>
		/// Gets the price of the side
		/// </summary>
		public double Price
		{
			get
			{
				if (size == Data.Enums.Size.Small) return 0.42;
				else if (size == Data.Enums.Size.Medium) return 0.76;
				else if (size == Data.Enums.Size.Large) return 0.96;
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
				if (size == Data.Enums.Size.Small) return 77;
				else if (size == Data.Enums.Size.Medium) return 89;
				else if (size == Data.Enums.Size.Large) return 100;
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
			return "" + Size + " Dragonborn Waffle Fries";
		}

	}
}


