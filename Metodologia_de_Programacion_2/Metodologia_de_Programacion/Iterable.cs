using System;
using System.Collections.Generic;
using System.Linq;

namespace Metodologia_de_Programacion_2
{
	interface Iterator
	{
		void primero();
		void siguiente();
		bool fin();
		Comparable actual();
	}
	interface Iterable
	{
		Iterator CrearIterador();
	}

	class IteradorDeListas : Iterator
	{
		private int paginaActual;
		private List<Comparable> paginas;
		public IteradorDeListas(List<Comparable> documento)
		{
			paginas = documento;
		}
		public void primero()
		{
			paginaActual = 0;
		}
		public void siguiente()
		{
			paginaActual++;
		}
		public bool fin()
		{
			return paginaActual == paginas.Count();
		}
		public Comparable actual()
		{
			return paginas[paginaActual];
		}
	}


	class Impresora
	{
		Iterator iterador;
		public Impresora()
		{
		}
		public void Imprimir(Iterable documento)
		{
			iterador = documento.CrearIterador();
			while (!iterador.fin())
			{
				Comparable aux1 = iterador.actual();
				Console.WriteLine(aux1);
				iterador.siguiente();
			}
		}
	}
}
