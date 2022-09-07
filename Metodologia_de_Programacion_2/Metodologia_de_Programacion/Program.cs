using System;
using System.Collections.Generic;

namespace Metodologia_de_Programacion_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Cola c1 = new Cola();
			Pila p1 = new Pila();
			ColeccionMultiple cm1 = new ColeccionMultiple(p1, c1);
			Conjunto conj1 = new Conjunto();
			Diccionario dic1 = new Diccionario();

			//----------------------------------PRACTICA 2----------------------------------//

			//hice un método llamado Llenarclavevalor(Comparable). para poder hacer el ejercicio 8
			//porque sino, al agregar alumnos al diccionario no lo permite porque no es un objeto de clavevalor.
			//Así que dejo los 2 métodos para llenar el diccionario a forma de prueba


			//- EJERCICIO 8-//
			llenarAlumnos(c1);
			llenarAlumnos(p1);
			llenarAlumnos(conj1);
			llenarAlumnos(dic1);
			llenarClavevalor(dic1);


			Console.WriteLine("		*** ALUMNOS EN COLA ***");
			Console.WriteLine("");
			imprimirElementos(c1);
			Console.WriteLine("");

			Console.WriteLine("		*** ALUMNOS EN PILA ***");
			Console.WriteLine("");
			imprimirElementos(p1);
			Console.WriteLine("");

			Console.WriteLine("		*** ALUMNOS EN CONJUNTO ***");
			Console.WriteLine("");
			imprimirElementos(conj1);
			Console.WriteLine("");

			Console.WriteLine("		*** ALUMNOS EN DICCIONARIO ***");
			Console.WriteLine("");
			imprimirElementos(dic1);
			Console.WriteLine("");

			//- EJERCICIO 8-//

			//- EJERCICIO 10-//
			llenarAlumnos(p1);

			Console.WriteLine("**** Estrategia por Nombre ****");
			Console.WriteLine("");
			CambiarEstrategia(p1, new PorNombre());
			Informar(p1);

			Console.WriteLine("");
			Console.WriteLine("**** Estrategia por Dni ****");
			Console.WriteLine("");
			CambiarEstrategia(p1, new PorDni());
			Informar(p1);

			Console.WriteLine("");
			Console.WriteLine("**** Estrategia por Legajo ****");
			Console.WriteLine("");
			CambiarEstrategia(p1, new PorLegajo());
			Informar(p1);

			Console.WriteLine("");
			Console.WriteLine("**** Estrategia por Promedio ****");
			Console.WriteLine("");
			CambiarEstrategia(p1, new PorPromedio());
			Informar(p1);

			//-EJERICIO 10-//

			//----------------------------------PRACTICA 2----------------------------------//
			Console.ReadKey();
		}

		//----------------------------------FUNCIONES----------------------------------//
		static void Llenar(Coleccionable x)
		{
			Random aleatorio = new Random();
			for (int i = 0; i < 20; i++)
			{
				int numeros = aleatorio.Next(50);
				Numero aux = new Numero(numeros);
				x.agregar(aux);
			}
		}
		static void Informar(Coleccionable x)
		{
			//Console.Write("Ingrese un número: ");
			//int aux2 = int.Parse(Console.ReadLine());

			Console.WriteLine("En la coleccion hay: " + x.cuantos() + " Elementos.");
			Console.WriteLine("");
			Console.WriteLine(x.minimo());
			Console.WriteLine(x.maximo());

			//Console.WriteLine(x.contiene(new Numero(aux2)));

		}
		static string Nombres(int numero)
		{
			List<string> l1 = new List<string>();

			l1.Add("Alex"); l1.Add("Belén"); l1.Add("Cruz"); l1.Add("Dante");
			l1.Add("Elena"); l1.Add("Federico"); l1.Add("Gastón"); l1.Add("Hernan");
			l1.Add("Índigo"); l1.Add("Juan"); l1.Add("Kinga"); l1.Add("Luciano");
			l1.Add("Mati"); l1.Add("Norma"); l1.Add("Ñasd"); l1.Add("Oscar");
			l1.Add("Pablo"); l1.Add("Quico"); l1.Add("Roxxana"); l1.Add("Sebastian");
			l1.Add("Tomás"); l1.Add("Ursula"); l1.Add("Victoria"); l1.Add("Ximena");
			l1.Add("Wilson"); l1.Add("Yamila"); l1.Add("Zulma");

			return l1[numero];
		}
		static void LlenarPersonas(Coleccionable x)
		{
			Random aleatorio = new Random();

			for (int i = 0; i < 10; i++)
			{
				int numeros2 = aleatorio.Next(10000000, 99999999);
				Persona aux2 = new Persona(numeros2, Nombres(aleatorio.Next(0, 26)));
				x.agregar(aux2);
			}
		}
		static void llenarAlumnos(Coleccionable x)
		{
			Random aleatorio = new Random();
			int leg, dni, prom;
			for (int i = 0; i < 10; i++)
			{
				Alumno alu = new Alumno(Nombres(aleatorio.Next(0, 27)), dni = aleatorio.Next(10000000, 99999999), leg = aleatorio.Next(10000, 99999), prom = aleatorio.Next(100, 1000));
				x.agregar(alu);
			}
		}
		static void llenarClavevalor(Coleccionable x)
		{
			Random aleatorio = new Random();
			int leg, dni, prom;
			for (int i = 0; i < 10; i++)
			{
				x.agregar(new ClaveValor(aleatorio.Next(5), new Alumno(Nombres(aleatorio.Next(0, 27)), dni = aleatorio.Next(10000000, 99999999), leg = aleatorio.Next(10000, 99999), prom = aleatorio.Next(100, 1000))));
			}
		}
		static void imprimirElementos(Iterable x)
		{
			Impresora impresora = new Impresora();

			impresora.Imprimir(x);
		}
		static void CambiarEstrategia(Iterable documento, Strategy_Alumno estrategia)
		{
			Iterator iterador = documento.CrearIterador();
			while (!iterador.fin())
			{
				Comparable aux1 = iterador.actual();
				((Alumno)aux1).CambiarEstrategia(estrategia);
				iterador.siguiente();
			}
		}

		//----------------------------------FUNCIONES----------------------------------//
	}
}
