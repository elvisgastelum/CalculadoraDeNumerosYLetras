/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 3/25/2019
 * Time: 7:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;

namespace ConvertidorDeNumeros
{
	/// <summary>
	/// Description of Engine.
	/// </summary>
	public class Engine
	{
		public Engine()
		{
		}
		
		
//		string[] Unidades = {
//			"Cero",
//			"Uno",
//			"Dos",
//			"Tres",
//			"Cuatro",
//			"Cinco",
//			"Seis",
//			"Siete",
//			"Ocho",
//			"Nueve"
//		};
//		string[,] Decenas ={
//			{
//				"Diez",
//				"Veinte",
//				"Treinta",
//				"Cuarenta",
//				"Cincuenta",
//				"Sesenta",
//				"Setenta",
//				"Ochenta",
//				"Noventa",
//				""
//				
//			},
//			{
//				"Cero",
//				"Uno",
//				"Dos",
//				"Tres",
//				"Cuatro",
//				"Cinco",
//				"Seis",
//				"Siete",
//				"Ocho",
//				"Nueve"
//			}
//			
//		};
//		string[,] Centenas = {
//			{
//				"Ciento",
//				"Doscientos",
//				"Trecientos",
//				"Cuatrocientos",
//				"Quinientos",
//				"Seicientos",
//				"Setecientos",
//				"Ochocientos",
//				"Novecientos",
//				""
//				
//			},
//			{
//				"Diez",
//				"Veinte",
//				"Treinta",
//				"Cuarenta",
//				"Cincuenta",
//				"Sesenta",
//				"Setenta",
//				"Ochenta",
//				"Noventa",
//				""
//				
//			},
//			
//			{
//				"Cero",
//				"Uno",
//				"Dos",
//				"Tres",
//				"CUnidades.Auatro",
//				"Cinco",
//				"Seis",
//				"Siete",
//				"Ocho",
//				"Nueve"
//			}
//			
//		};
//		string Millares = "Mil";
		
		Dictionary<string, string> Unidades = new Dictionary<string, string>();
		Dictionary<string, string> Decenas = new Dictionary<string, string>();
		Dictionary<string, string> Centenas = new Dictionary<string, string>();
		Dictionary<string, string> Millares = new Dictionary<string, string>();
		
		
		public void AddData()
		{
			Unidades.Add("0","Cero");
			Unidades.Add("1","Uno");
			Unidades.Add("2","Dos");
			Unidades.Add("3","Tres");
			Unidades.Add("4","Cuatro");
			Unidades.Add("5","Cinco");
			Unidades.Add("6","Seis");
			Unidades.Add("7","Siete");
			Unidades.Add("8","Ocho");
			Unidades.Add("9","Nueve");
			
			Decenas.Add("1","Diez");
			Decenas.Add("2","Veinte");
			Decenas.Add("3","Treinta");
			Decenas.Add("4","Cuarenta");
			Decenas.Add("5","Cincuenta");
			Decenas.Add("6","Sesenta");
			Decenas.Add("7","Setenta");
			Decenas.Add("8","Ochenta");
			Decenas.Add("9","Noventa");
			
			Centenas.Add("1","Ciento");
			Centenas.Add("2","Doscientos");
			Centenas.Add("3","Trescientos");
			Centenas.Add("4","Cuatrocientos");
			Centenas.Add("5","Quinientos");
			Centenas.Add("6","Seiscientos");
			Centenas.Add("7","Setecientos");
			Centenas.Add("8","Ochocientos");
			Centenas.Add("9","Novecientos");
			
			
			Millares.Add("1","Mil");
			
			
			Unidades.Add("cero","0");
			Unidades.Add("uno","1");
			Unidades.Add("dos","2");
			Unidades.Add("tres","3");
			Unidades.Add("cuatro","4");
			Unidades.Add("cinco","5");
			Unidades.Add("seis","6");
			Unidades.Add("siete","7");
			Unidades.Add("ocho","8");
			Unidades.Add("nueve","9");
			
			Decenas.Add("diez","10");
			Decenas.Add("once","11");
			Decenas.Add("doce","12");
			Decenas.Add("trece","13");
			Decenas.Add("catorce","14");
			Decenas.Add("quince","15");
			Decenas.Add("veinte","2");
			Decenas.Add("treinta","3");
			Decenas.Add("cuarenta","4");
			Decenas.Add("cincuenta","5");
			Decenas.Add("sesenta","6");
			Decenas.Add("setenta","7");
			Decenas.Add("ochenta","8");
			Decenas.Add("noventa","9");
			
			Centenas.Add("cien","100");
			Centenas.Add("ciento","1");
			Centenas.Add("doscientos","2");
			Centenas.Add("trescientos","3");
			Centenas.Add("cuatrocientos","4");
			Centenas.Add("quinientos","5");
			Centenas.Add("seiscientos","6");
			Centenas.Add("setecientos","7");
			Centenas.Add("ochocientos","8");
			Centenas.Add("novecientos","9");
			
			
			Millares.Add("mil","1000");
			
			
		}
		
		public static char[] Split(string value)
		{
        	
        	char[] array = value.ToCharArray();
			
        	
        	return array;
		}
		
		public string Dynamic(char[] _numbers, string _num)
		{
			string tmp = "";
			string _numStr = _num.ToLower();
			
			string[] _numStrArray = _numStr.Split(' ');
			int _numStrArrayInt = _numStrArray.GetLength(0);
			
			
			
			try {
				Convert.ToInt32(_num);
				
			
			
			if (_numbers.GetLength(0) == 1) {
				if (_numbers[0] == '0') {
					tmp += Unidades["0"];
				}
				if (_numbers[0] == '1') {
					tmp += Unidades["1"];
				}
				if (_numbers[0] == '2') {
					tmp += Unidades["2"];
				}
				if (_numbers[0] == '3') {
					tmp += Unidades["3"];
				}
				if (_numbers[0] == '4') {
					tmp += Unidades["4"];
				}
				if (_numbers[0] == '5') {
					tmp += Unidades["5"];
				}
				if (_numbers[0] == '6') {
					tmp += Unidades["6"];
				}
				if (_numbers[0] == '7') {
					tmp += Unidades["7"];
				}
				if (_numbers[0] == '8') {
					tmp += Unidades["8"];
				}
				if (_numbers[0] == '9') {
					tmp += Unidades["9"];
				}
				
				
				
			}
			
			
			if (_numbers.GetLength(0) == 2) {
				int _numInt = Convert.ToInt32(_num);
				// Menor que 15
				if (_numInt <= 15) {
					if (_num == "11") {
						tmp = "Once";
					}
					if (_num == "12") {
						tmp = "Doce";
					}
					if (_num == "13") {
						tmp = "Trece";
					}
					if (_num == "14") {
						tmp = "Catorce";
					}
					if (_num == "15") {
						tmp = "Quince";
					}
					
				}
				else if (_numInt > 15)
				{
					//Decenas
					if (_numbers[0] == '1') {
						tmp += Decenas["1"];
					}
					if (_numbers[0] == '2') {
						tmp += Decenas["2"];
					}
					if (_numbers[0] == '3') {
						tmp += Decenas["3"];
					}
					if (_numbers[0] == '4') {
						tmp += Decenas["4"];
					}
					if (_numbers[0] == '5') {
						tmp += Decenas["5"];
					}
					if (_numbers[0] == '6') {
						tmp += Decenas["6"];
					}
					if (_numbers[0] == '7') {
						tmp += Decenas["7"];
					}
					if (_numbers[0] == '8') {
						tmp += Decenas["8"];
					}
					if (_numbers[0] == '9') {
						tmp += Decenas["9"];
					}
					tmp += " y ";
					//Unidades
					if (_numbers[1] == '0') {
						tmp += Unidades["0"];
					}
					if (_numbers[1] == '1') {
						tmp += Unidades["1"];
					}
					if (_numbers[1] == '2') {
						tmp += Unidades["2"];
					}
					if (_numbers[1] == '3') {
						tmp += Unidades["3"];
					}
					if (_numbers[1] == '4') {
						tmp += Unidades["4"];
					}
					if (_numbers[1] == '5') {
						tmp += Unidades["5"];
					}
					if (_numbers[1] == '6') {
						tmp += Unidades["6"];
					}
					if (_numbers[1] == '7') {
						tmp += Unidades["7"];
					}
					if (_numbers[1] == '8') {
						tmp += Unidades["8"];
					}
					if (_numbers[1] == '9') {
						tmp += Unidades["9"];
					}
					
				}
			}
			
			if (_numbers.GetLength(0) == 3) {
				//Centenas
				if (_numbers[0] == '1') {
					tmp += Centenas["1"];
					
				}
				if (_numbers[0] == '2') {
					tmp += Centenas["2"];
					
				}
				if (_numbers[0] == '3') {
					tmp += Centenas["3"];
					
				}
				if (_numbers[0] == '4') {
					tmp += Centenas["4"];
					
				}
				if (_numbers[0] == '5') {
					tmp += Centenas["5"];
					
				}
				if (_numbers[0] == '6') {
					tmp += Centenas["6"];
					
				}
				if (_numbers[0] == '7') {
					tmp += Centenas["7"];
					
				}
				if (_numbers[0] == '8') {
					tmp += Centenas["8"];
					
				}
				if (_numbers[0] == '9') {
					tmp += Centenas["9"];
					
				}
				tmp += " ";
				// Decenas
				if (_numbers[1] == '1') {
					tmp += Decenas["1"];
					
				}
				if (_numbers[1] == '2') {
					tmp += Decenas["2"];
					
				}
				if (_numbers[1] == '3') {
					tmp += Decenas["3"];
					
				}
				if (_numbers[1] == '4') {
					tmp += Decenas["4"];
					
				}
				if (_numbers[1] == '5') {
					tmp += Decenas["5"];
					
				}
				if (_numbers[1] == '6') {
					tmp += Decenas["6"];
					
				}
				if (_numbers[1] == '7') {
					tmp += Decenas["7"];
					
				}
				if (_numbers[1] == '8') {
					tmp += Decenas["8"];
					
				}
				if (_numbers[1] == '9') {
					tmp += Decenas["9"];
					
				}
				
				
				//Unidades
				if (_numbers[2] == '0') {
					return tmp;
					
				}else
				{
					tmp += " y ";
					
				}
				if (_numbers[2] == '1') {
					tmp += Unidades["1"];
					
				}
				if (_numbers[2] == '2') {
					tmp += Unidades["2"];
					
				}
				if (_numbers[2] == '3') {
					tmp += Unidades["3"];
					
				}
				if (_numbers[2] == '4') {
					tmp += Unidades["4"];
					
				}
				if (_numbers[2] == '5') {
					tmp += Unidades["5"];
					
				}
				if (_numbers[2] == '6') {
					tmp += Unidades["6"];
					
				}
				if (_numbers[2] == '7') {
					tmp += Unidades["7"];
					
				}
				if (_numbers[2] == '8') {
					tmp += Unidades["8"];
					
				}
				if (_numbers[2] == '9') {
					tmp += Unidades["9"];
					
				}
				
				
				
			}
			
			if (_numbers.GetLength(0) == 4) {
				tmp = "Mil";
			}
			
				
				
			
			} catch (FormatException) {
				
				// Unidades
				if (_numStrArrayInt == 1) {
					if (_numStr == "cero") {
						tmp += Unidades["cero"];
					}
				
					if (_numStr == "uno") {
						tmp += Unidades["uno"];
					}
				
					if (_numStr == "dos") {
						tmp += Unidades["dos"];
					}
				
					if (_numStr == "tres") {
						tmp += Unidades["tres"];
					}
				
					if (_numStr == "cuatro") {
						tmp += Unidades["cuatro"];
					}
				
					if (_numStr == "cinco") {
						tmp += Unidades["cinco"];
					}
				
					if (_numStr == "seis") {
						tmp += Unidades["seis"];
					}
				
					if (_numStr == "siete") {
						tmp += Unidades["siete"];
					}
				
					if (_numStr == "ocho") {
						tmp += Unidades["ocho"];
					}
				
					if (_numStr == "nueve") {
						tmp += Unidades["nueve"];
					}
				
					if (_numStr == "diez") {
						tmp += Unidades["diez"];
					}
				
					if (_numStr == "once") {
						tmp += Decenas["once"];
					}
				
					if (_numStr == "doce") {
						tmp += Decenas["doce"];
					}
				
					if (_numStr == "trece") {
						tmp += Decenas["trece"];
					}
				
					if (_numStr == "catorce") {
						tmp += Decenas["catorce"];
					}
				
					if (_numStr == "quince") {
						tmp += Decenas["quince"];
					}
				
					if (_numStr == "veinte") {
						tmp += Decenas["veinte"];
					}
				
					if (_numStr == "treinta") {
						tmp += Decenas["treinta"];
						tmp += "0";
					}
				
					if (_numStr == "cuarenta") {
						tmp += Decenas["cuarenta"];
						tmp += "0";
					}
				
					if (_numStr == "cincuenta") {
						tmp += Decenas["cincuenta"];
						tmp += "0";
					}
				
					if (_numStr == "sesenta") {
						tmp += Decenas["sesenta"];
						tmp += "0";
					}
				
					if (_numStr == "setenta") {
						tmp += Decenas["setenta"];
						tmp += "0";
					}
				
					if (_numStr == "ochenta") {
						tmp += Decenas["ochenta"];
						tmp += "0";
					}
				
					if (_numStr == "noventa") {
						tmp += Decenas["noventa"];
						tmp += "0";
					}
				
					if (_numStr == "cien") {
						tmp += Centenas["cien"];
						
					}
				
					if (_numStr == "doscientos") {
						tmp += Centenas["doscientos"];
						tmp += "00";
					}
				
					if (_numStr == "trecientos") {
						tmp += Centenas["trecientos"];
						tmp += "00";
					}
				
					if (_numStr == "cuatrocientos") {
						tmp += Centenas["cuatrocientos"];
						tmp += "00";
					}
				
					if (_numStr == "quinientos") {
						tmp += Centenas["quinientos"];
						tmp += "00";
					}
				
					if (_numStr == "seiscientos") {
						tmp += Centenas["seiscientos"];
						tmp += "00";
					}
				
					if (_numStr == "setecientos") {
						tmp += Centenas["setecientos"];
						tmp += "00";
					}
				
					if (_numStr == "ochocientos") {
						tmp += Centenas["ochocientos"];
						tmp += "00";
					}
				
					if (_numStr == "novecientos") {
						tmp += Centenas["novecientos"];
						tmp += "00";
					}
				
					if (_numStr == "mil") {
						tmp += Millares["mil"];
					}
				}
				
				
				
				
				if (_numStrArrayInt == 4) {
					
					//Centenas
					if (_numStrArray[0] == "ciento") {
						tmp += Centenas["ciento"];
						
					}
					if (_numStrArray[0] == "doscientos") {
						tmp += Centenas["doscientos"];
						
					}
					if (_numStrArray[0] == "trescientos") {
						tmp += Centenas["trescientos"];
						
					}
					if (_numStrArray[0] == "cuatrocientos") {
						tmp += Centenas["cuatrocientos"];
						
					}
					if (_numStrArray[0] == "quinientos") {
						tmp += Centenas["quinientos"];
						
					}
					if (_numStrArray[0] == "seiscientos") {
						tmp += Centenas["seiscientos"];
						
					}
					if (_numStrArray[0] == "setecientos") {
						tmp += Centenas["setecientos"];
						
					}
					if (_numStrArray[0] == "ochocientos") {
						tmp += Centenas["ochocientos"];
						
					}
					if (_numStrArray[0] == "novecientos") {
						tmp += Centenas["novecientos"];
						
					}
					
					
					// Decenas
					if (_numStrArray[1] == "diez") {
						tmp += Decenas["diez"];
						
					}
					if (_numStrArray[1] == "veinte") {
						tmp += Decenas["veinte"];
						
					}
					if (_numStrArray[1] == "treinta") {
						tmp += Decenas["treinta"];
						
					}
					if (_numStrArray[1] == "cuarenta") {
						tmp += Decenas["cuarenta"];
						
					}
					if (_numStrArray[1] == "cincuenta") {
						tmp += Decenas["cincuenta"];
						
					}
					if (_numStrArray[1] == "sesenta") {
						tmp += Decenas["sesenta"];
						
					}
					if (_numStrArray[1] == "setenta") {
						tmp += Decenas["setenta"];
						
					}
					if (_numStrArray[1] == "ochenta") {
						tmp += Decenas["ochenta"];
						
					}
					if (_numStrArray[1] == "noventa") {
						tmp += Decenas["noventa"];
						
					}
					
					//Unidades
					
					if (_numStrArray[3] == "uno") {
						tmp += Unidades["uno"];
						
					}
					if (_numStrArray[3] == "dos") {
						tmp += Unidades["dos"];
						
					}
					if (_numStrArray[3] == "tres") {
						tmp += Unidades["tres"];
						
					}
					if (_numStrArray[3] == "cuatro") {
						tmp += Unidades["cuatro"];
						
					}
					if (_numStrArray[3] == "cinco") {
						tmp += Unidades["cinco"];
						
					}
					if (_numStrArray[3] == "seis") {
						tmp += Unidades["seis"];
						
					}
					if (_numStrArray[3] == "siete") {
						tmp += Unidades["siete"];
						
					}
					if (_numStrArray[3] == "ocho") {
						tmp += Unidades["ocho"];
						
					}
					if (_numStrArray[3] == "nueve") {
						tmp += Unidades["nueve"];
						
					}
					
					
					
					
				}
				
				if (_numStrArrayInt == 2 || _numStrArrayInt == 3) {
					
					//Centenas
					if (_numStrArray[0] == "ciento") {
						tmp += Centenas["ciento"];
						
					}
					if (_numStrArray[0] == "doscientos") {
						tmp += Centenas["doscientos"];
						
					}
					if (_numStrArray[0] == "trescientos") {
						tmp += Centenas["trescientos"];
						
					}
					if (_numStrArray[0] == "cuatrocientos") {
						tmp += Centenas["cuatrocientos"];
						
					}
					if (_numStrArray[0] == "quinientos") {
						tmp += Centenas["quinientos"];
						
					}
					if (_numStrArray[0] == "seiscientos") {
						tmp += Centenas["seiscientos"];
						
					}
					if (_numStrArray[0] == "setecientos") {
						tmp += Centenas["setecientos"];
						
					}
					if (_numStrArray[0] == "ochocientos") {
						tmp += Centenas["ochocientos"];
						
					}
					if (_numStrArray[0] == "novecientos") {
						tmp += Centenas["novecientos"];
						
					}
					
					
					// Decenas
					if (_numStrArray[1] == "diez" || _numStrArray[0] == "diez") {
						tmp += Decenas["diez"];
						
					}
					if (_numStrArray[1] == "veinte" || _numStrArray[0] == "veinte") {
						tmp += Decenas["veinte"];
						
					}
					if (_numStrArray[1] == "treinta" || _numStrArray[0] == "treinta") {
						tmp += Decenas["treinta"];
						
					}
					if (_numStrArray[1] == "cuarenta" || _numStrArray[0] == "cuarenta") {
						tmp += Decenas["cuarenta"];
						
					}
					if (_numStrArray[1] == "cincuenta" || _numStrArray[0] == "cincuenta") {
						tmp += Decenas["cincuenta"];
						
					}
					if (_numStrArray[1] == "sesenta" || _numStrArray[0] == "sesenta") {
						tmp += Decenas["sesenta"];
						
					}
					if (_numStrArray[1] == "setenta" || _numStrArray[0] == "setenta") {
						tmp += Decenas["setenta"];
						
					}
					if (_numStrArray[1] == "ochenta" || _numStrArray[0] == "ochenta") {
						tmp += Decenas["ochenta"];
						
					}
					if (_numStrArray[1] == "noventa" || _numStrArray[0] == "noventa") {
						tmp += Decenas["noventa"];
						
					}
					
					if(_numStrArrayInt == 3){
						//Unidades
						
						if (_numStrArray[2] == "uno") {
							tmp += Unidades["uno"];
							
						}
						if (_numStrArray[2] == "dos") {
							tmp += Unidades["dos"];
							
						}
						if (_numStrArray[2] == "tres") {
							tmp += Unidades["tres"];
							
						}
						if (_numStrArray[2] == "cuatro") {
							tmp += Unidades["cuatro"];
							
						}
						if (_numStrArray[2] == "cinco") {
							tmp += Unidades["cinco"];
							
						}
						if (_numStrArray[2] == "seis") {
							tmp += Unidades["seis"];
							
						}
						if (_numStrArray[2] == "siete") {
							tmp += Unidades["siete"];
							
						}
						if (_numStrArray[2] == "ocho") {
							tmp += Unidades["ocho"];
							
						}
						if (_numStrArray[2] == "nueve") {
							tmp += Unidades["nueve"];
							
						}
					}else
					{
						tmp += "0";
					}
					
					
					
				}
				
				
				
				
			}	
				
			
			return tmp;
		}
		
		
		
		
		
		
	}
}
