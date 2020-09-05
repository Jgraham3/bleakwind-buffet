/*		
 *		Author: Nathan Bean
 *		Edited by: Justin Graham
 * 
 *		Class name: BriarheartBurger.cs
 *		Purpose: To encapsulate all code/data regarding a Briarheart Burger order
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
	public class BriarheartBurger
	{
		/// <summary>
		/// Gets the price of the burger
		/// </summary>
		public double Price
		{
			get { return 6.32; } //note// or:		get => 6.32;
		}
		//note// or even:		public double Price => 6.32; 


		/// <summary>
		/// Gets the calories of the burger
		/// </summary>
		public uint Calories => 732;    //note// unsigned integer as you can't have negative calories

		
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

		//note//	this notation without the "= true" default to false
		//note//	uses hidden backing variable that we cannot access 


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
				//note//		if (!value) specialInstructions.Add("Hold ketchup");
				//note//		else specialInstructions.Remove("Hold ketchup"); 
				//note//
				//note//		these lines only necessary if utilizing private backing list variable
				//note//		for the special instructions rather than creating when requested.
				
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
				return mustard;		//note//	or:		get => mustard;
			}
			set
			{
				mustard = value;	//note//	or:		set => mustard => value;
			}
		}

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




		//note//	private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// Generates and returns a list of special instructions (empty list = no special instructions)
		/// </summary>
		public List<string> SpecialInstructions
		{
			//note//	get => new List<string>(specialInstructions);
			//note//	process of using a private list backing variable for special instructions

			get
			{
				List<string> instructions = new List<string>();
				if (!Bun) instructions.Add("Hold bun");
				if (!Ketchup) instructions.Add("Hold ketchup");
				if (!Mustard) instructions.Add("Hold mustard");
				if (!Pickle) instructions.Add("Hold pickle");
				if (!Cheese) instructions.Add("Hold cheese");
				return instructions;
			}
		}

		/// <summary>
		/// Returns the name of the entree as a string
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "Briarheart Burger";
		}

	}
}
