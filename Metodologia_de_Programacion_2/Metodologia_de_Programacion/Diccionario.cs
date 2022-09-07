using System;
using System.Collections.Generic;

namespace Metodologia_de_Programacion_2
{
	class Diccionario : Coleccionable, Iterable
	{
		private List<Comparable> lista;

		public Diccionario()
		{
			lista = new List<Comparable>();
		}

		public Comparable ValorDe(int indice)
		{
			foreach (ClaveValor item in lista)
			{
				if (item.Clave == indice)
				{
					return item.Valor;
				}
			}
			return null;
		}

		public int cuantos()
		{
			return lista.Count;
		}

		public Comparable minimo()
		{
			Comparable aux1 = lista[0];
			foreach (ClaveValor item in lista)
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
			foreach (ClaveValor item in lista)
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
			foreach (ClaveValor item in lista)
			{
				if (x.sosIgual(item))
				{
					return true;
				}
			}
			return false;
		}
		public void agregar(Comparable x)
		{

			bool aux1 = true;
			foreach (ClaveValor item in lista)
			{
				if (item.Clave.Equals((((ClaveValor)x).Clave)))
				{
					item.Valor = (((ClaveValor)x).Valor);
					aux1 = false;
					break;
				}
			}
			if (aux1 == false)
			{
				Console.WriteLine("El elemento ha sido modificado en el conjunto");
			}
			if (aux1 == true)
			{
				if (x.GetType() == typeof(ClaveValor))
				{
					lista.Add(x);
					Console.WriteLine("El elemento ha sido agregado al conjunto");
				}
				else
					Console.WriteLine("No se puede agregar un comparable al diccionario sin una clave.");
			}
		}
		public Iterator CrearIterador()
		{
			return new IteradorDeListas(lista);
		}
	}
	class ClaveValor : Comparable
	{
		private int clave;
		private Comparable valor;
		public ClaveValor(int clave, Comparable valor)
		{
			this.clave = clave;
			this.valor = valor;
		}

		public int Clave
		{
			get { return clave; }
			set { clave = value; }
		}
		public Comparable Valor
		{
			get { return valor; }
			set { valor = value; }
		}
		public override string ToString()
		{
			return "Clave:" + this.Clave.ToString() + " " + this.Valor;
		}


		public bool sosIgual(Comparable x)
		{
			return clave == ((ClaveValor)x).Clave;
		}
		public bool sosMenor(Comparable x)
		{
			return clave < ((ClaveValor)x).Clave;
		}
		public bool sosMayor(Comparable x)
		{
			return clave > ((ClaveValor)x).Clave;
		}
	}
}
