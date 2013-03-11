using System;

namespace practica3hashtable
{
	public class Programa
	{
		Persona persona1 = new Persona ();//
		Persona persona2 = new Persona ();//
		Persona persona3 = new Persona ();//
		Persona persona4 = new Persona ();//

		public string codigo;
		public string codigo2;
		public string codigo3;
		public string codigo4;

		public Programa ()
		{


		}
		public void  capturar(){
			
			persona1.capturar ();
			Console.Clear();
			persona2.capturar ();
			Console.Clear();
			persona3.capturar ();
			Console.Clear();
			persona4.capturar ();
			this.obtnerCodigos ();
		}
     public void obtnerCodigos(){
			this.codigo = persona1.getCodigo ();
			this.codigo2 = persona2.getCodigo ();
			this.codigo3 = persona3.getCodigo ();
			this.codigo4 = persona4.getCodigo ();

		}
		public void  editar(){
			string codigoTemporalComparar;
			for (int i=0; i<2; i++) {

				Console.WriteLine ("Dame el codigo a editar ");
				codigoTemporalComparar="";
				codigoTemporalComparar = Console.ReadLine();
				if (codigoTemporalComparar==codigo) {
					persona1.mostrarDatos ();
					persona1.limpiar ();
					persona1.capturar ();
				} else {
					if (codigoTemporalComparar==codigo2) {
						persona2.mostrarDatos ();
						persona2.limpiar ();
						persona2.capturar ();

					} else {
						if (codigoTemporalComparar==codigo3) {
							persona3.mostrarDatos ();
							persona3.limpiar();
							persona3.capturar ();
						
						} else {
							 if (codigoTemporalComparar==codigo4) {
								persona4.mostrarDatos ();
								persona4.limpiar ();
								persona4.capturar ();
							
							}else{
								Console.WriteLine("el codigo no existe");
								Console.ReadKey();
							}

					}
				}
			}

				this.obtnerCodigos ();
				Console.Clear();
			}
	}
		public void  eliminar(){

			{
				string codigoTemporalComparar;
				for (int i=0; i<2; i++) {

					Console.WriteLine ("Dame el codigo a eliminar ");
					codigoTemporalComparar="";
					codigoTemporalComparar = Console.ReadLine();
					if (codigoTemporalComparar==codigo) {
						persona1.eliminar ();
					} else {
						if (codigoTemporalComparar==codigo2) {
							persona2.eliminar ();
							
						} else {
							if (codigoTemporalComparar==codigo3) {
								persona3.eliminar ();

								
							} else {
								if (codigoTemporalComparar==codigo4) {
									persona4.eliminar ();
									
								} else {
									Console.WriteLine ("el codigo no existe");
									Console.ReadKey();
								}

							}
						}
					}
					this.obtnerCodigos ();
					Console.Clear();


				}
			}


		

		}
		public void mostrarTodos(){

			persona1.mostrarDatos ();
			persona2.mostrarDatos ();
			persona3.mostrarDatos ();
			persona4.mostrarDatos ();




		}





}
}

