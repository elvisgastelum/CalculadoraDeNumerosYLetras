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
	public class Calcular: CalcularAbstracto
	{
		Engine Convertir = new Engine();
		
		
		public Calcular()
		{
			Convertir.AddData();
		}
		
		
		
		public override int Suma(int x, int y)
		{
			
			return x + y;
			
		}
		
		public override int Suma(int x, string y)
		{
			
			char[] SplitY = Engine.Split(y);
			int _y = Convert.ToInt32(Convertir.Dynamic(SplitY, y));
			
			return x + _y;
		}
		
		public override int Suma(string x, int y)
		{
			char[] SplitX = Engine.Split(x);
			int _x = Convert.ToInt32(Convertir.Dynamic(SplitX, x));
			return _x + y;
		}
		
		public override int Suma(string x, string y)
		{
			char[] SplitX = Engine.Split(x);
			int _x = Convert.ToInt32(Convertir.Dynamic(SplitX, x));
			char[] SplitY = Engine.Split(y);
			int _y = Convert.ToInt32(Convertir.Dynamic(SplitY, y));
			
			return _x + _y;
		}
		
		
		
		
	}
}
