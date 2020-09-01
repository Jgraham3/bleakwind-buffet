/*		
 *		Author: Justin Graham
 * 
 *		Class name: GardenOrcOmelette.cs
 *		Purpose: To encapsulate all code/data regarding a Garden Orc Omelette order
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
	public class GardenOrcOmelette
	{
		/// <summary>
		/// Gets the price of the entree
		/// </summary>
		public double Price
		{
			get { return 4.57; }
		}

		/// <summary>
		/// Gets the calories of the entree
		/// </summary>
		public uint Calories => 404;


		private bool broccoli = true;
		/// <summary>
		/// Gets if the entree has broccoli
		/// </summary>
		public bool Broccoli
		{
			get
			{
				return broccoli;
			}
			set
			{
				broccoli = value;
			}
		}

		private bool mushrooms = true;
		/// <summary>
		/// Gets if the entree has mushrooms
		/// </summary>
		public bool Mushrooms
		{
			get
			{
				return mushrooms;
			}
			set
			{
				mushrooms = value;
			}
		}

		private bool tomato = true;
		/// <summary>
		/// Gets if the entree has tomato
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

		private bool cheddar = true;
		/// <summary>
		/// Gets if the entree has cheddar cheese
		/// </summary>
		public bool Cheddar
		{
			get
			{
				return cheddar;
			}
			set
			{
				cheddar = value;
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
				if (!Broccoli) instructions.Add("Hold broccoli");
				if (!Mushrooms) instructions.Add("Hold mushrooms");
				if (!Tomato) instructions.Add("Hold tomato");
				if (!Cheddar) instructions.Add("Hold cheddar");
				return instructions;
			}
		}

		/// <summary>
		/// Returns the name of the entree as a string
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "Garden Orc Omelette";
		}

	}
}

