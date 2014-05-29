/*
 * Created by SharpDevelop.
 * User: Dany
 * Date: 07/05/2014
 * Time: 04:45 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace profesores
{
	/// <summary>
	/// Description of Mysql.
	/// </summary>
	public class MySQL
	{
		public MySqlConnection myConnection;

		public MySQL ()
		{
		}

		public void abrirConexion(){
			string connectionString =
				"Server=localhost;" +
				"Database=escuela;" +
				"User ID=root;" +
				"Password=1602;" +
				"Pooling=false;";
			this.myConnection = new MySqlConnection(connectionString);
			this.myConnection.Open();
		}

		public void cerrarConexion(){
			this.myConnection.Close();
			this.myConnection = null;
		}
	}
}
