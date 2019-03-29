/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 3/28/2019
 * Time: 8:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ConvertidorDeNumeros
{
	/// <summary>
	/// Description of Calcular.
	/// </summary>
	public abstract class CalcularAbstracto
	{
		public abstract int Suma(int x, int y);
		
		public abstract int Suma(int x, string y);
		
		public abstract int Suma(string x, int y);
		
		public abstract int Suma(string x, string y);
		
		
		
		
		
	}
}

