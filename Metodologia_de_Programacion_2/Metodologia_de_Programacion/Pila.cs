using System;
using System.Collections.Generic;

namespace Metodologia_de_Programacion_2
{
	class Pila : Coleccionable, Iterable
	{
		List<Comparable> ListaP;

		public Pila()
		{
			ListaP = new List<Comparable>();
		}
		public void agregar(Comparable x)
		{
			ListaP.Insert(0, x);
		}
		public bool contiene(Comparable x)
		{
			foreach (Comparable item in ListaP)
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
			foreach (Comparable item in ListaP)
			{
				if (item.sosIgual(x))
				{
					ListaP.Remove(x);
					Console.WriteLine("Se borró. ");
					break;
				}
			}
			Console.WriteLine("No se borró. ");
		}
		public Comparable maximo()
		{
			Comparable aux1 = ListaP[0];
			foreach (Comparable item in ListaP)
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
			Comparable aux1 = ListaP[0];
			foreach (Comparable item in ListaP)
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
			return ListaP.Count;
		}
		public void mostrar()
		{
			foreach (Comparable item in ListaP)
			{
				Console.Write(item + " ");
			}
		}

		//ITERABLE//
		public Iterator CrearIterador()
		{
			return new IteradorDeListas(ListaP);
		}
		//ITERABLE//
	}
}
