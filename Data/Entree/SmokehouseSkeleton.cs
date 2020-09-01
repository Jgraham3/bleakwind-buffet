/*		
 *		Author: Justin Graham
 * 
 *		Class name: SmokehouseSkeleton.cs
 *		Purpose: To encapsulate all code/data regarding a Smokehouse Skeleton order
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
	public class SmokehouseSkeleton
	{
		/// <summary>
		/// Gets the price of the entree
		/// </summary>
		public double Price
		{
			get { return 5.62; }
		}

		/// <summary>
		/// Gets the calories of the entree
		/// </summary>
		public uint Calories => 602;


		private bool sausageLink = true;
		/// <summary>
		/// Gets if the entree has sausage links
		/// </summary>
		public bool SausageLink
		{
			get
			{
				return sausageLink;
			}
			set
			{
				sausageLink = value;
			}
		}

		private bool egg = true;
		/// <summary>
		/// Gets if the entree has egg
		/// </summary>
		public bool Egg
		{
			get
			{
				return egg;
			}
			set
			{
				egg = value;
			}
		}

		private bool hashBrowns = true;
		/// <summary>
		/// Gets if the entree has hashbrowns
		/// </summary>
		public bool HashBrowns
		{
			get
			{
				return hashBrowns;
			}
			set
			{
				hashBrowns = value;
			}
		}

		private bool pancake = true;
		/// <summary>
		/// Gets if the entree has pancake(s)
		/// </summary>
		public bool Pancake
		{
			get
			{
				return pancake;
			}
			set
			{
				pancake = value;
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
				if (!SausageLink) instructions.Add("Hold sausage");
				if (!Egg) instructions.Add("Hold egg");
				if (!HashBrowns) instructions.Add("Hold hash browns");
				if (!Pancake) instructions.Add("Hold pancakes");
				return instructions;
			}
		}

		/// <summary>
		/// Returns the name of the entree as a string
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "Smokehouse Skeleton";
		}

	}
}
