namespace Metodologia_de_Programacion_2
{
	class Numero : Comparable
	{
		private int valor;
		public Numero(int x)
		{
			valor = x;
		}
		public int getValor
		{
			get { return valor; }
		}
		override public string ToString()
		{
			return "Numero:" + this.getValor.ToString();
		}
		public bool sosIgual(Comparable x)
		{
			if (this.valor == ((Numero)x).getValor)
			{
				return true;
			}
			else return false;
		}
		public bool sosMenor(Comparable x)
		{
			if (this.valor <= ((Numero)x).getValor)
			{
				return true;
			}
			else return false;
		}
		public bool sosMayor(Comparable x)
		{
			if (this.valor >= ((Numero)x).getValor)
			{
				return true;
			}
			else return false;
		}
	}
}
