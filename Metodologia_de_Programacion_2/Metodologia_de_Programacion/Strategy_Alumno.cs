namespace Metodologia_de_Programacion_2
{
	public interface Strategy_Alumno
	{
		bool sosIgual(Comparable x, Alumno y);
		bool sosMenor(Comparable x, Alumno y);
		bool sosMayor(Comparable x, Alumno y);
	}
	public class PorDni : Strategy_Alumno
	{
		public bool sosIgual(Comparable x, Alumno y)
		{
			return ((Alumno)x).getDni == y.getDni;
		}
		public bool sosMenor(Comparable x, Alumno y)
		{
			return ((Alumno)x).getDni < y.getDni;
		}
		public bool sosMayor(Comparable x, Alumno y)
		{
			return ((Alumno)x).getDni > y.getDni;
		}
	}
	public class PorNombre : Strategy_Alumno
	{
		public bool sosIgual(Comparable x, Alumno y)
		{
			if (((Alumno)x).getNombre.CompareTo(y.getNombre) == 0)
			{
				return true;
			}
			else return false;
		}
		public bool sosMenor(Comparable x, Alumno y)
		{
			if (((Alumno)x).getNombre.CompareTo(y.getNombre) < 0)
			{
				return true;
			}
			else return false;
		}
		public bool sosMayor(Comparable x, Alumno y)
		{
			if (((Alumno)x).getNombre.CompareTo(y.getNombre) > 0)
			{
				return true;
			}
			else return false;
		}
	}
	public class PorPromedio : Strategy_Alumno
	{
		public bool sosIgual(Comparable x, Alumno y)
		{
			return ((Alumno)x).getPromedio == y.getPromedio;
		}
		public bool sosMenor(Comparable x, Alumno y)
		{
			return ((Alumno)x).getPromedio < y.getPromedio;
		}
		public bool sosMayor(Comparable x, Alumno y)
		{
			return ((Alumno)x).getPromedio > y.getPromedio;
		}
	}
	public class PorLegajo : Strategy_Alumno
	{
		public bool sosIgual(Comparable x, Alumno y)
		{
			return ((Alumno)x).getLegajo == y.getLegajo;
		}
		public bool sosMenor(Comparable x, Alumno y)
		{
			return ((Alumno)x).getLegajo < y.getLegajo;
		}
		public bool sosMayor(Comparable x, Alumno y)
		{
			return ((Alumno)x).getLegajo > y.getLegajo;
		}
	}
}
