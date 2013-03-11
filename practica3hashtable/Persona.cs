using System;
using System.Collections;
namespace practica3hashtable
{
	public class Persona
	{

		public Hashtable persona;
		public string codigo;
		public Persona ()
		{
			this.persona=new Hashtable();
		

		}

		public void capturar(){
		
			Console.WriteLine("Dame el codigo");
			codigo = Console.ReadLine ();
			persona.Add("codigo",codigo);

			Console.WriteLine("Dame el nombre");

			persona.Add("nombre",Console.ReadLine());

			Console.WriteLine("Dame la dirección");
			persona.Add("direccion",Console.ReadLine());

			Console.WriteLine("Dame el telefono");
			persona.Add("telefono",Console.ReadLine());

			Console.WriteLine("Dame la dirección de facebook");
			persona.Add("facebook",Console.ReadLine());


		}
		public void limpiar(){

			persona.Clear ();
		}
		public void eliminar(){
			Console.WriteLine("¿Esta seguro que desea eliminar?");
			Console.WriteLine("0 = No, 1 = Si");
			string opcion = Console.ReadLine();
			if(opcion != "0"){
				persona.Clear ();
			}

		}
		public string getCodigo(){
			
			return this.codigo;
			
		}
		public void mostrarDatos(){
			foreach( DictionaryEntry de in persona )
			{
				Console.WriteLine("" + de.Key + "\n" + de.Value);
			}

			Console.WriteLine("");
		}


	}




	}


