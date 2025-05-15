/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 15/05/2025
 * Time: 07:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PAtrilhasAtiv05
{
	class A05
	{
		public static void Main()
		{
			int[] valor=new int[2];//0 e 1
			
			for(int i=0;i<2;i++){
				Console.WriteLine("[DIGITE] o {0}º valor: ",i+1);
				valor[i]=int.Parse(Console.ReadLine());
			}
			
			for(int i=0;i<2;i++){
				parimpar(valor[i]);
				positivonegarivo(valor[i]);
			}
			maioremenor(valor[0],valor[1]);
			somasubidração(valor[0],valor[1]);
			divisibilidade(valor[0],valor[1]);
			
			
			Console.ReadKey();
		}
	
		static void parimpar(int valor){}
		static void positivonegarivo(int valor){}
				
		static void maioremenor(int valor0, int valor1){}
		static void somasubidração( int valor0, int valor1){}
		static void divisibilidade(int valor0, int valor1){}
	}
}