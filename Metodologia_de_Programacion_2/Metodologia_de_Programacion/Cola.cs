using System;
using System.Collections.Generic;

namespace Metodologia_de_Programacion_2
{
	class Cola : Coleccionable, Iterable
	{
		List<Comparable> ListaC;
		public Cola()
		{
			ListaC = new List<Comparable>();
		}
		public void agregar(Comparable x)
		{
			ListaC.Add(x);
		}
		public bool contiene(Comparable x)
		{
			foreach (Comparable item in ListaC)
			{
				if (item.sosIgual(x))
				{
					return true;
				}
			}
			return false;
		}
		public void borrar(Comparable x)
		{
			foreach (Comparable item in ListaC)
			{
				if (item.sosIgual(x))
				{
					ListaC.Remove(x);
					Console.WriteLine("Se borró. ");
					break;
				}
			}
			Console.WriteLine("No se borró. ");
		}
		public Comparable maximo()
		{
			Comparable aux1 = ListaC[0];
			foreach (Comparable item in ListaC)
			{
				if (item.sosMayor(aux1))
				{
					aux1 = item;
				}
			}
			return aux1;
		}
		public Comparable minimo()
		{
			Comparable aux1 = ListaC[0];
			foreach (Comparable item in ListaC)
			{
				if (item.sosMenor(aux1))
				{
					aux1 = item;
				}
			}
			return aux1;
		}
		public int cuantos()
		{
			return ListaC.Count;
		}
		public void mostrar()
		{
			foreach (Comparable item in ListaC)
			{

				Console.Write(item + " ");
			}
		}
		public Iterator CrearIterador()
		{
			return new IteradorDeListas(ListaC);
		}
	}
}
