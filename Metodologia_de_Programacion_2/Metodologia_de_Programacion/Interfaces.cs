using System.Collections.Generic;

namespace Metodologia_de_Programacion_2
{
	public interface Comparable
	{
		bool sosIgual(Comparable x);
		bool sosMenor(Comparable x);
		bool sosMayor(Comparable x);

	}
	interface Coleccionable
	{
		int cuantos();
		Comparable minimo();
		Comparable maximo();
		void agregar(Comparable x);
		bool contiene(Comparable x);
	}
}
