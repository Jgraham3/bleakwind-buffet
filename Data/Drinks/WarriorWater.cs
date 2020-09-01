/*		
 *		Author: Justin Graham
 * 
 *		Class name: WarriorWater.cs
 *		Purpose: To encapsulate all code/data regarding a Warrior Water order
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
	public class WarriorWater
	{
		/// <summary>
		/// Gets the price of the drink
		/// </summary>
		public double Price
		{
			get
			{
				return 0;
			}
		}

		/// <summary>
		/// Gets the calories of the drink
		/// </summary>
		public uint Calories
		{
			get
			{
				return 0;
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

		private bool lemon = true;
		/// <summary>
		/// Gets if the drink has lemon
		/// </summary>
		public bool Lemon
		{
			get
			{
				return lemon;
			}
			set
			{
				lemon = value;
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
				if (Lemon) instructions.Add("Add lemon");
				return instructions;
			}
		}

		/// <summary>
		/// Returns the name of the drink as a string
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "" + Size + " Warrior Water";
		}

	}
}


