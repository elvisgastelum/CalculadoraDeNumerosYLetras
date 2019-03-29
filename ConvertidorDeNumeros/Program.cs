/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 3/25/2019
 * Time: 6:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConvertidorDeNumeros
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Calcular Calcula = new Calcular();
			
			int resultado = 0;
			int x = 0;
			int y = 0;
			bool _xx = false;
			bool _yy = false;
			Console.Write("Escriba el primer numero: ");
			string _x = Console.ReadLine();
			Console.Write("Escriba el segundo numero: ");
			string _y = Console.ReadLine();
			
			try {
				x = Convert.ToInt32(_x);
			} catch (FormatException) {
				
				_xx = true;
			}
			
			try {
				y = Convert.ToInt32(_y);
			} catch (FormatException) {
				
				_yy = true;
			}
			
			if (_xx == false && _yy == false) {
				resultado = Calcula.Suma(x,y);
			}
			else if(_xx == false && _yy == true){
				resultado = Calcula.Suma(x,_y);
			}else if(_xx == true && _yy == false){
				resultado = Calcula.Suma(_x,y);
			}else if(_xx == true && _yy == true){
				resultado = Calcula.Suma(_x,_y);
			}
			
			Console.WriteLine("El resultado se la suma es: {0}", resultado);
			
			
			
			
			
			
			
			
			
			
			
			
			Console.ReadKey(true);
		}
	}
}