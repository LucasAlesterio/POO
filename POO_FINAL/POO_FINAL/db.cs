using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace POO_FINAL
{
    class db
    {
        private NpgsqlConnection conn; //Variavel para conectar com o banco de dados
        private NpgsqlCommand command; //Variavel para manipular comandos
        private NpgsqlDataReader result;//


        public void connectionTest()
        {
            //throw new NotImplementedException();

            try
            {
                conn = new NpgsqlConnection("Server=127.0.0.1 ;User Id=postgres; Password=220199; Database=POO;");
                conn.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro Encontrado:" + ex);
                
            }

        }
        public void insert(String str)
        {
            connectionTest();
            try
            {
                command = new NpgsqlCommand(str,conn);
                    //"INSERT into teste (FName,Lname) VALUES ('"+ txtFname.Text + "','" + txtLname.Text + "')", conn);
                command.ExecuteReader();
                Console.WriteLine("Registro Inserido!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro Encontrado:" + ex);
            }
            //conn.Close();
        }
        public NpgsqlDataReader select(string str)
        {
            connectionTest();
            try
            {
                command = new NpgsqlCommand(str, conn);
                result = command.ExecuteReader();
                /*while (result.Read())
                {
                    dataGridView1.Rows.Add(new object[] { result.GetValue(0), result.GetValue(1), result.GetValue(2) });
                }*/
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro encontrado: " + ex);
            }

            //conn.Close();
            return result;
        }
        public String[] materia()
        {
            connectionTest();
           
            int i = 0,j=0;
            String str = "SELECT count(*) FROM materias";

            try
            {
                command = new NpgsqlCommand(str, conn);
                result = command.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro encontrado: " + ex);
            }
            while (result.Read())
            {
                j = Convert.ToInt32(result[0]);
            }
            conn.Close();
            connectionTest();
            str = "SELECT * FROM materias";
            try
            {
                command = new NpgsqlCommand(str, conn);
                result = command.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro encontrado: " + ex);
            }
            String[] a = new string[j];
            
            while (result.Read())
            {
                a[i] = Convert.ToString(result[2]);
                i++;

            }
            //conn.Close();
            return a;
        }
        public int id(String str)
        {
            int i = 0;
            connectionTest();
            str = "Select id_materia from materias where nome_materia='" + str + "'";

            /*try
            {
                command = new NpgsqlCommand(str, conn);
                result = command.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro encontrado: " + ex);
            }*/
            result = select(str);
            while (result.Read())
            {
                i = Convert.ToInt32(result[0]);
            }
            //conn.Close();
            return i;
        }
    }
}
