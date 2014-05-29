/*
 * Created by SharpDevelop.
 * User: Dany
 * Date: 07/05/2014
 * Time: 03:52 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace profesores
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine ("¿Que deceas Hacer?\n\n" +
			                   "1.- Ver\n" +
			                   "2.- Agregar\n" +
			                   "3.- Editar\n" +
			                   "4.- Eliminar\n"+
			                   "5.- Salirr\n");
			
			String s1 = null;
			
			
			
			s1 = Console.ReadLine();
			
			switch (s1){
				case "1":
					Console.WriteLine("Opcion ver");
					Profesores profesor=new Profesores();
					profesor.mostrarTodos();
					break;
					
				case "2":
					Console.WriteLine("Opcion Agregar");
					Profesores Agregar = new Profesores();
					Console.WriteLine("Introduce el nombre");
					string codigo = Console.ReadLine();
					Console.WriteLine("Introduce Codigo");
					Console.WriteLine();
					string nombre = Console.ReadLine();
					Agregar.insertarRegistroNuevo(codigo,nombre);
					Console.WriteLine("Has agregado con exito, Pulsa una tecla para finalizar");
					break;
					
				case "3":
					Console.WriteLine("Opcion Editar \n");
					Profesores EditarCod = new Profesores();
					Console.WriteLine("\nIngresa el id a editar\n");
					string id= Console.ReadLine();
					codigo= Console.ReadLine();
					EditarCod.editarCodigoRegistro(id,codigo);
					
					Console.WriteLine("\nNombre del id\n");
					Profesores EditarNom = new Profesores();
					nombre= Console.ReadLine();
					EditarNom.editarNombreRegistro(id,nombre);
					Console.WriteLine("Ha Finalizando con exito la edicion");
					break;
				
				case "4":
					Console.WriteLine("Has elegido la opcion: Eliminar");
					Profesores Eliminar = new Profesores();
					Console.WriteLine("Ingresa el Id que deseas Eliminar");
					id=Console.ReadLine();
					Eliminar.eliminarRegistroPorId(id);
					Console.WriteLine("Has eliminado con exito, presiona una tecla para salir");
					
					break;
				case "5":
					
					Console.WriteLine("Salir");
					break;
					
				default:
					Console.WriteLine("No se ha seleccionado niguna Opcion");
					break;
			}
			
			
			Console.ReadKey();
		}
	}
}