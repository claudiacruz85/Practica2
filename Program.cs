/*
 * Created by SharpDevelop.
 * User: Claudia
 * Date: 25/02/2015
 * Time: 10:09 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;

namespace Practica2
{
	class Program
	{
		static void Cronometro(){
			
			int hora=0;
			int minutos=0;
			int segundos=0;
			
			
			for (hora=0; hora<24; hora ++)
				for (minutos=0; minutos<60; minutos ++)
					for (segundos=0; segundos<60; segundos ++){
						Console.WriteLine("Cronometro:  " + hora +":" + minutos +":" +segundos);
						Thread.Sleep(1000);
						Console.Clear();
			}
		}
		
		static void Reloj(){
			
			while (true) 
          { 
               Console.Clear(); 
               Console.WriteLine (DateTime.Now.ToLongTimeString() ); 
               Thread.Sleep(1000); 
          } 
       		
				
		}
		
		
		public static void Main(string[] args)
		{
			int opcion;
			
			Console.WriteLine("\t   *** PROGRAMA DE CRONOMETRO Y RELOJ ***" + "\n" + "\t \t" + "Selecciona la opcion deseada:");
			
			do{
				
				Console.WriteLine(" 1) Cronometro \n 2) Reloj \n 3) Salir");
				opcion = Convert.ToInt32(Console.ReadLine());
				switch(opcion){
						
					case 1:
						Cronometro();
						break;
					case 2:
						Reloj();
						break;
				}
				
			}while(opcion!=3);
			
		}
	}
}