using System;

namespace practica3hashtable
{
	class Principal
	{

		public static void Main (string[] args)
		{
			Programa programa = new Programa();
			programa.capturar ();
			Console.Clear();
			programa.editar ();
			programa.eliminar ();
			Console.Clear();
			programa.mostrarTodos ();

		
		
		}
	}
}
