/*
 * Created by SharpDevelop.
 * User: Ridger
 * Date: 06/04/2015
 * Time: 04:28 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejemplo
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("numero1: ");
			int num1=int.Parse(Console.ReadLine());
			Console.WriteLine("numero2: ");
			int num2=int.Parse(Console.ReadLine());
			
			int resultado= num1+num2;
			Console.WriteLine("resultado: "+resultado);
			Console.ReadLine();
		}
	}
}