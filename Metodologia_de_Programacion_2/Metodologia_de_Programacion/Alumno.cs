namespace Metodologia_de_Programacion_2
{
	public class Alumno : Persona, Comparable
	{
		private int legajo;
		private int promedio;
		private Strategy_Alumno estrategia;
		public Alumno(string nombre, int dni, int legajo, int promedio) : base(dni, nombre)
		{
			this.legajo = legajo;
			this.promedio = promedio;
			estrategia = new PorLegajo();
		}
		public int getLegajo { get { return legajo; } }
		public int getPromedio { get { return promedio; } }
		override public string ToString()
		{
			return "Nombre: " + this.getNombre.ToString() + ", Dni: " + getDni.ToString() + ", Legajo: " + getLegajo.ToString() + ", Promedio: " + getPromedio.ToString();
		}
		public new bool sosIgual(Comparable x)
		{
			return this.estrategia.sosIgual(this, (Alumno)x);
		}
		public new bool sosMenor(Comparable x)
		{
			return this.estrategia.sosMenor(this, (Alumno)x);
		}
		public new bool sosMayor(Comparable x)
		{
			return this.estrategia.sosMayor(this, (Alumno)x);
		}
		public void CambiarEstrategia(Strategy_Alumno x)
		{
			this.estrategia = x;
		}
		public Strategy_Alumno VerEstrategia()
		{
			return this.estrategia;
		}
	} 
}
