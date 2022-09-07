namespace Metodologia_de_Programacion_2
{
	public class Persona : Comparable
	{
		private int dni;
		private string nombre;

		public Persona(int dni, string nombre)
		{
			this.dni = dni;
			this.nombre = nombre;
		}
		public int getDni { get { return dni; } }
		public string getNombre { get { return nombre; } }
		override public string ToString()
		{
			return "Nombre: " + this.getNombre.ToString() + ", Dni: " + getDni.ToString();
		}
		public bool sosIgual(Comparable x)
		{
			if (this.getDni == ((Persona)x).getDni)
			{
				return true;
			}
			else return false;
		}
		public bool sosMenor(Comparable x)
		{
			if (this.getDni < ((Persona)x).getDni)
			{
				return true;
			}
			else return false;
		}
		public bool sosMayor(Comparable x)
		{
			if (this.getDni > ((Persona)x).getDni)
			{
				return true;
			}
			else return false;
		}
	}
}
