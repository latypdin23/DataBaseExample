using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExample
{
    public class Postgre
    {
        private static String ConnectionString = "Host=localhost;Username=postgres;Password=123456;Database=Univer";
        private static NpgsqlConnection getConnection()
        {
            NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
            return connection;
        }
        private static Group readDrGroup(NpgsqlDataReader dr)
        {
            Group result = new Group();
            result.Id = int.Parse(dr["Id"].ToString());
            result.Description = dr["Description"].ToString();

            return result;
        }
        public static Group GetGroup(int Id)
        {
            string sql = "SELECT * from Main.\"Group\" Where \"Id\"=:Id";

            Group result = null;
            NpgsqlConnection conn = getConnection();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            try
            {
                conn.Open();
                cmd.Parameters.Add(new NpgsqlParameter(":Id", Id));
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        result = readDrGroup(dr);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }
        private static Role readDrRole(NpgsqlDataReader dr)
        {
            Role result = new Role();
            result.Id = int.Parse(dr["Id"].ToString());
            result.Name = dr["Name"].ToString();

            return result;
        }
        public static Role GetRole(int Id)
        {
            string sql = "SELECT * from Main.\"Role\" Where \"Id\"=:Id";

            Role result = null;
            NpgsqlConnection conn = getConnection();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            try
            {
                conn.Open();
                cmd.Parameters.Add(new NpgsqlParameter(":Id", Id));
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        result = readDrRole(dr);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }
        private static Student ReadDrPerson(NpgsqlDataReader dr)
        {
            Student result = new Student();
            object tmp = null;
            result.Id = dr.GetInt32(dr.GetOrdinal("Id"));
            result.Surname = dr["Surname"].ToString();
            result.Name = dr["Name"].ToString();

            result.Id_Group = (dr["Group"] != null && dr["Group"] != DBNull.Value ? int.Parse(dr["Group"].ToString()) : (int?)null);
            if (result.Id_Group != null)
            {
                result.Group = GetGroup((int)result.Id_Group);
            }

            result.Id_Role = (dr["Role"] != null && dr["Role"] != DBNull.Value ? int.Parse(dr["Role"].ToString()) : (int?)null);
            if (result.Id_Role != null)
            {
                result.Role = GetRole((int)result.Id_Role);
            }
            return result;
        }
        public static List<Student> GetAllStudents()
        {
            List<Student> result = new List<Student>();
            NpgsqlConnection conn = getConnection();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from Main.\"Student\" ";
            try
            {
                conn.Open();

                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        result.Add(ReadDrPerson(dr));
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }
        public static DataTable GetAllStudents(string join)
        {
            DataSet ds = new DataSet();
            NpgsqlConnection conn = getConnection();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select s.\"Id\", s.\"Name\", s.\"Surname\", r.\"Name\" as \"RoleName\" " +
                "from main.\"Student\" s " +
                 join+" main.\"Role\" r on r.\"Id\" = s.\"Role\"";
            try
            {
                conn.Open();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd.CommandText, conn);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return ds.Tables[0];
        }
        public static DataTable ExecuteSql(string command)
        {
            NpgsqlConnection conn = getConnection();
            DataSet ds = new DataSet();
            try
            {
                conn.Open();

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command, conn);               
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
            return ds.Tables[0];
        }
    }
}
