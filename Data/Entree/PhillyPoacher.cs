/*		
 *		Author: Justin Graham
 * 
 *		Class name: PhillyPoacher.cs
 *		Purpose: To encapsulate all code/data regarding a Philly Poacher order
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
	public class PhillyPoacher
	{
		/// <summary>
		/// Gets the price of the entree
		/// </summary>
		public double Price
		{
			get { return 7.23; }
		}

		/// <summary>
		/// Gets the calories of the entree
		/// </summary>
		public uint Calories => 784;


		private bool sirloin = true;
		/// <summary>
		/// Gets if the entree has sirloin
		/// </summary>
		public bool Sirloin
		{
			get
			{
				return sirloin;
			}
			set
			{
				sirloin = value;
			}
		}

		private bool onion = true;
		/// <summary>
		/// Gets if the entree has onion
		/// </summary>
		public bool Onion
		{
			get
			{
				return onion;
			}
			set
			{
				onion = value;
			}
		}

		private bool roll = true;
		/// <summary>
		/// Gets if the entree has a roll
		/// </summary>
		public bool Roll
		{
			get
			{
				return roll;
			}
			set
			{
				roll = value;
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
				if (!Sirloin) instructions.Add("Hold sirloin");
				if (!Onion) instructions.Add("Hold onions");
				if (!Roll) instructions.Add("Hold roll");
				return instructions;
			}
		}

		/// <summary>
		/// Returns the name of the entree as a string
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "Philly Poacher";
		}

	}
}

