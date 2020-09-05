/*		
 *		Author: Justin Graham
 * 
 *		Class name: DoubleDraugr.cs
 *		Purpose: To encapsulate all code/data regarding a Double Draugr order
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
	public class DoubleDraugr
	{
		/// <summary>
		/// Gets the price of the entree
		/// </summary>
		public double Price
		{
			get { return 7.32; }
		}

		/// <summary>
		/// Gets the calories of the burger
		/// </summary>
		public uint Calories => 843;


		private bool ketchup = true;
		/// <summary>
		/// Gets if ketchup is on the burger
		/// </summary>
		public bool Ketchup
		{
			get
			{
				return ketchup;
			}
			set
			{
				ketchup = value;
			}
		}

		private bool mustard = true;
		/// <summary>
		/// Gets if mustard is on the burger
		/// </summary>
		public bool Mustard
		{
			get
			{
				return mustard;     //note//	or:		get => mustard;
			}
			set
			{
				mustard = value;    //note//	or:		set => mustard => value;
			}
		}

		private bool bun = true;
		/// <summary>
		/// Gets if there is a bun
		/// </summary>
		public bool Bun
		{
			get
			{
				return bun;
			}
			set
			{
				bun = value;
			}
		}       //note//	or:		public bool Bun { get; set; } = true;

		private bool pickle = true;
		/// <summary>
		/// Gets if there are pickles on the entree
		/// </summary>
		public bool Pickle
		{
			get
			{
				return pickle;
			}
			set
			{
				pickle = value;
			}
		}

		private bool cheese = true;
		/// <summary>
		/// Gets if there is cheese on the entree
		/// </summary>
		public bool Cheese
		{
			get
			{
				return cheese;
			}
			set
			{
				cheese = value;
			}
		}

		/*********************************************/
		///////////////////////////////////////////////
		/*********************************************/

		private bool tomato = true;
		/// <summary>
		/// Gets if there is tomato on the entree
		/// </summary>
		public bool Tomato
		{
			get
			{
				return tomato;
			}
			set
			{
				tomato = value;
			}
		}

		private bool lettuce = true;
		/// <summary>
		/// Gets if there is lettuce on the entree
		/// </summary>
		public bool Lettuce
		{
			get
			{
				return lettuce;
			}
			set
			{
				lettuce = value;
			}
		}

		private bool mayo = true;
		/// <summary>
		/// Gets if there is mayo on the entree
		/// </summary>
		public bool Mayo
		{
			get
			{
				return mayo;
			}
			set
			{
				mayo = value;
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
				if (!Bun) instructions.Add("Hold bun");
				if (!Ketchup) instructions.Add("Hold ketchup");
				if (!Mustard) instructions.Add("Hold mustard");
				if (!Pickle) instructions.Add("Hold pickle");
				if (!Cheese) instructions.Add("Hold cheese");
				if (!Tomato) instructions.Add("Hold tomato");
				if (!Lettuce) instructions.Add("Hold lettuce");
				if (!Mayo) instructions.Add("Hold mayo");
				return instructions;
			}
		}

		/// <summary>
		/// Returns the name of the entree as a string
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "Double Draugr";
		}

	}
}
