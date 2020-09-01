/*		
 *		Author: Justin Graham
 * 
 *		Class name: ThugsTBone.cs
 *		Purpose: To encapsulate all code/data regarding a Thugs T-Bone order
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
	public class ThugsTBone
	{
		/// <summary>
		/// Gets the price of the entree
		/// </summary>
		public double Price
		{
			get { return 6.44; }
		}

		/// <summary>
		/// Gets the calories of the entree
		/// </summary>
		public uint Calories => 982;


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
		/// Returns the name of the entree as a string
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "Thugs T-Bone";
		}

	}
}

