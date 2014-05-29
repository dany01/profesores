/*
 * Created by SharpDevelop.
 * User: Dany
 * Date: 14/05/2014
 * Time: 01:50 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace profesores
{
	/// <summary>
	/// Description of Editar.
	/// </summary>
	public class Editar
	{
		public static void alumnos (string[] args)
		{
				Profesores alumnos = new Profesores();
				alumnos.insertarRegistroNuevo("9876","Mariana");
				alumnos.editarNombreRegistro("11", "Gustavo");
				alumnos.mostrarTodos();
				Console.WriteLine("------------------------------------------------------------");
				alumnos.editarCodigoRegistro("11", "2211");
				alumnos.mostrarTodos();
				Console.WriteLine("------------------------------------------------------------");
				alumnos.eliminarRegistroPorId("11");
				alumnos.mostrarTodos();
				Console.WriteLine("------------------------------------------------------------");
				Console.Read();
		
		}
	}
}
