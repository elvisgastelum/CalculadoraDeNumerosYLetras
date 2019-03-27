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
			
			Engine Convertir = new Engine();
			Convertir.AddData();
			
			
			Console.Write("Escriba numero: ");
			string _num = Console.ReadLine();
			// Engine.Split, Crea un arreglo de chars apartir de un string mandado
			char[] NumeroArray = Engine.Split(_num);
			
			
			var num = Convertir.Dynamic(NumeroArray, _num);
			
			
			
			
			Console.WriteLine(num);
			
			
			
			
			
			
			
			
			
			
			Console.ReadKey(true);
		}
	}
}