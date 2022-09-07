using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Metodologia_de_Programacion_2
{
	class ColeccionMultiple : Coleccionable
	{
		private Pila PILA;
		private Cola COLA;

		public Pila GetPila { get { return PILA; } }
		public Cola GetCola { get { return COLA; } }

		public ColeccionMultiple(Pila p, Cola c)
		{
			PILA = p;
			COLA = c;
		}
		
		public int cuantos()
		{
			return GetPila.cuantos() + GetCola.cuantos();
		}
		public Comparable minimo()
		{
			Comparable aux1 = PILA.minimo();
			Comparable aux2 = COLA.minimo();
			if (aux1.sosMenor(aux2))
			{
				return aux1;
			}
			else return aux2;
		}
		public Comparable maximo()
		{
			Comparable aux1 = PILA.maximo();
			Comparable aux2 = COLA.maximo();
			if (aux1.sosMayor(aux2))
			{
				return aux1;
			}
			else return aux2;
		}
		public void agregar(Comparable x) { }
		public bool contiene(Comparable x)
		{
			bool aux1 = PILA.contiene(x);
			bool aux2 = COLA.contiene(x);
			if (aux1 == true || aux1 == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
