using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologia_de_Programacion_2
{
	class Conjunto : Coleccionable, Iterable
	{
		private List<Comparable> lista;
		public Conjunto()
		{
			lista = new List<Comparable>();
		}
		public List<Comparable> getLista()
		{
			return lista;
		}

		public void agregar(Comparable x)
		{
			bool aux1 = false;
			foreach (Comparable item in lista)
			{
				if (item.sosIgual(x))
				{
					aux1 = true;
					break;
				}
			}
			if (aux1 == false)
			{
				lista.Add(x);
				//Console.WriteLine("El elemento ha sido agregado al conjunto");
			}
			if (aux1 == true)
			{
				Console.WriteLine("El elemento repetido. ");
			}
		}
		

		public int cuantos()
		{
			return lista.Count;
		}
		public Comparable minimo()
		{
			Comparable aux1 = lista[0];
			foreach (Comparable item in lista)
			{
				if (item.sosMenor(aux1))
				{
					aux1 = item;
				}
			}
			return aux1;
		}
		public Comparable maximo()
		{
			Comparable aux1 = lista[0];
			foreach (Comparable item in lista)
			{
				if (item.sosMayor(aux1))
				{
					aux1 = item;
				}
			}
			return aux1;
		}
		public bool contiene(Comparable x)
		{
			foreach (Comparable item in lista)
			{
				if (item.sosIgual(x))
				{
					return true;
				}
			}
			return false;
		}

		public Iterator CrearIterador()
		{
			return new IteradorDeListas(lista);
		}
	}
}
