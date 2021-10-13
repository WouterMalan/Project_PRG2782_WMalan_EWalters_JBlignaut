using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Project_PRG2782_WMalan_EWalters_JBlignaut.Business_Layer;
using System.Drawing;
using Project_PRG2782_WMalan_EWalters_JBlignaut.Presentation_Layer;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Project_PRG2782_WMalan_EWalters_JBlignaut.Data_Layer
{
    internal class CRUD_operations:IDataHandler_Student,IDataHandler_Module
    {
        static string connectionString = "Data Source=DESKTOP-BPTNHN8;Initial Catalog=PRG2782_Project;Integrated Security=True";

        SqlConnection connection;

        public string addModule(string mcode, string mname, string desc, string res)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("spAddModule", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Mcode", mcode);
                sqlCommand.Parameters.AddWithValue("@Name", mname);
                sqlCommand.Parameters.AddWithValue("@Desc", desc);
                sqlCommand.Parameters.AddWithValue("@Link", res);

 
                connection.Open();
                sqlCommand.ExecuteNonQuery();

                return "Module added successfully";
            }
        }

        public string addStudent(int num, string Fname, string date, string gender, string phone, string address, string moduleCode,Image image)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("spAddStudent", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                MemoryStream ms = new MemoryStream();

                image.Save(ms, ImageFormat.Jpeg);
                byte[] photo = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo, 0, photo.Length);


                sqlCommand.Parameters.AddWithValue("@Id", num);
                sqlCommand.Parameters.AddWithValue("@Name", Fname);
                sqlCommand.Parameters.AddWithValue("@Date", date);
                sqlCommand.Parameters.AddWithValue("@Gender", gender);
                sqlCommand.Parameters.AddWithValue("@Phone", phone);
                sqlCommand.Parameters.AddWithValue("@Address", address);
                sqlCommand.Parameters.AddWithValue("@Mcode", moduleCode);
                sqlCommand.Parameters.AddWithValue("@Image", photo);



                connection.Open();
                sqlCommand.ExecuteNonQuery();

                return "Student added successfully";
            }
        }
        public string addStudent(int num, string Fname, string date, string gender, string phone, string address, string moduleCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("spAddStudent", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Id", num);
                sqlCommand.Parameters.AddWithValue("@Name", Fname);
                sqlCommand.Parameters.AddWithValue("@Date", date);
                sqlCommand.Parameters.AddWithValue("@Gender", gender);
                sqlCommand.Parameters.AddWithValue("@Phone", phone);
                sqlCommand.Parameters.AddWithValue("@Address", address);
                sqlCommand.Parameters.AddWithValue("@Mcode", moduleCode);

                connection.Open();
                sqlCommand.ExecuteNonQuery();

                return "Student added successfully";
            }
        }

        public string deleteModule(string mcode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("spDeleteModule", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Mcode", mcode);

                connection.Open();
                sqlCommand.ExecuteNonQuery();

                return "Module deleted successfully";
            }
        }

      

        public string deleteStudent(int num)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("spDeleteStudent", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Id", num);

                connection.Open();
                sqlCommand.ExecuteNonQuery();
                return "Student deleted successfully";
            }
        }

        public DataTable displayModule()
        {
            connection = new SqlConnection(connectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetModule", connection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);
            return dataTable;
           
        }

        public DataTable displayStudent()
        {
            connection = new SqlConnection(connectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spGetStudents", connection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);
            return dataTable;

            
        }

        

        public DataTable moduleSearch(string mcode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("spSearchModule", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Mcode", mcode);
               

                connection.Open();
                DataTable dataTable = new DataTable();

                using (SqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    dataTable.Load(dr);
                    return dataTable;
                    
                }
            }
        }

        public DataTable studentSearch(int num)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("spSearchStudent", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Id", num);

                connection.Open();
                DataTable dataTable = new DataTable();

                using (SqlDataReader dr = sqlCommand.ExecuteReader())
                {
                    dataTable.Load(dr);
                    return dataTable;
                }
            }
        }

        public string updateModule(string mcode, string mname, string desc, string res)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("spUpdateModule", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Mcode", mcode);
                sqlCommand.Parameters.AddWithValue("@Name", mname);
                sqlCommand.Parameters.AddWithValue("@Desc", desc);
                sqlCommand.Parameters.AddWithValue("@Link", res);


                connection.Open();
                sqlCommand.ExecuteNonQuery();

                return "Module updated successfully";
            }
        }

        public string updateStudent(int num, string Fname, string date, string gender, string phone, string address, string moduleCode, Image image)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("spUpdateStudent", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                MemoryStream ms = new MemoryStream();

                image.Save(ms, ImageFormat.Jpeg);
                byte[] photo = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo, 0, photo.Length);

                sqlCommand.Parameters.AddWithValue("@Id", num);
                sqlCommand.Parameters.AddWithValue("@Name", Fname);
                sqlCommand.Parameters.AddWithValue("@Date", date);
                sqlCommand.Parameters.AddWithValue("@Gender", gender);
                sqlCommand.Parameters.AddWithValue("@Phone", phone);
                sqlCommand.Parameters.AddWithValue("@Address", address);
                sqlCommand.Parameters.AddWithValue("@Mcode", moduleCode);
                sqlCommand.Parameters.AddWithValue("@Image", photo);



                connection.Open();
                sqlCommand.ExecuteNonQuery();
                return "Student updated successfully";
            }
        }
        public string updateStudent(int num, string Fname, string date, string gender, string phone, string address, string moduleCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("spUpdateStudent", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Id", num);
                sqlCommand.Parameters.AddWithValue("@Name", Fname);
                sqlCommand.Parameters.AddWithValue("@Date", date);
                sqlCommand.Parameters.AddWithValue("@Gender", gender);
                sqlCommand.Parameters.AddWithValue("@Phone", phone);
                sqlCommand.Parameters.AddWithValue("@Address", address);
                sqlCommand.Parameters.AddWithValue("@Mcode", moduleCode);

                connection.Open();
                sqlCommand.ExecuteNonQuery();
                return "Student updated successfully";
            }
        }
    }
}

