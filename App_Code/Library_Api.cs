using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using MySql;
using MySql.Data.MySqlClient;

public class Library_Api
{
    public OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OleDb.4.0;Data Source=C:\WEB DEV\PCI PORTAL\database\pcidb.mdb");
    //public MySqlConnection conn = new MySqlConnection("Data Source=localhost;Initial Catalog=lpjvsrgl_pci_admin;User Id=lpjvsrgl_pci_admin;password=Online@2024;SslMode=none");
    private string status;
    private bool login_status;
    public int exe;
    

	public Library_Api()
	{
		
	}

    public string msg()
    {
        return status;
    }

    private void checkconn()
    {
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
    }

    private int ebooks_ID()
    {
        checkconn();
        conn.Open();
        string sql = "select * from library";
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        DataTable dt = new DataTable();
        dt.Clear();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        da.Fill(dt);
        return dt.Rows.Count + 1;
    }

    public void new_ebook(string ebookname,string file_option, string student_class, string filename)
    {
        checkconn();
        conn.Open();
        string sql="select * from library where file_option=@fo and student_class=@sc and filename=@fn";
        OleDbCommand cmd = new OleDbCommand(sql,conn);
        cmd.Parameters.AddWithValue("@fo",file_option);
        cmd.Parameters.AddWithValue("@sc",student_class);
        cmd.Parameters.AddWithValue("@fn",filename);
        OleDbDataReader dr = cmd.ExecuteReader();
        if(dr.Read())
        {
            status="You have previously uploaded this file for the specified class";
        }
        else
        {
            save_ebook(ebookname,file_option,student_class,filename);
        }
    }

     private void save_ebook(string ebookname,string file_option, string student_class, string filename)
    {
         checkconn();
         conn.Open();
         string sql="insert into library values (@id,@ebn,@fo,@sc,@fn,@date)";
         OleDbCommand cmd = new OleDbCommand(sql,conn);
         cmd.Parameters.AddWithValue("@id",ebooks_ID());
         cmd.Parameters.AddWithValue("@ebn", ebookname);
         cmd.Parameters.AddWithValue("@fo",file_option);
         cmd.Parameters.AddWithValue("@sc",student_class);
         cmd.Parameters.AddWithValue("@fn",filename);
         cmd.Parameters.AddWithValue("@date",DateTime.Now.ToShortDateString());
         if(cmd.ExecuteNonQuery()!=0)
         {
             status="File has been uploaded successfully!";
             exe = 1;
         }
         else
         {
             status ="Error: File was not uploaded successfully!";
             exe=0;
         }
    }

     public DataTable get_ebooks_admin()
     {
         checkconn();
         conn.Open();
         string sql = "select * from library";
         OleDbCommand cmd = new OleDbCommand(sql, conn);
         OleDbDataAdapter da = new OleDbDataAdapter(cmd);
         DataTable dt = new DataTable();
         dt.Clear();
         da.Fill(dt);
         return dt;
     }

     public DataTable get_ebooks_student(string student_class)
     {
         checkconn();
         conn.Open();
         string sql = "select * from library where student_class=@class";
         OleDbCommand cmd = new OleDbCommand(sql, conn);
         cmd.Parameters.AddWithValue("@class", student_class);
         OleDbDataAdapter da = new OleDbDataAdapter(cmd);
         DataTable dt = new DataTable();
         dt.Clear();
         da.Fill(dt);
         return dt;
     }

     public DataTable get_ebooks(string filename, string studclass)
     {
         checkconn();
         conn.Open();
         string sql = "select * from library where file_ebook_name like @fen and student_class=@class";
         OleDbCommand cmd = new OleDbCommand(sql, conn);
         cmd.Parameters.AddWithValue("@fen", "%" + filename + "%");
         cmd.Parameters.AddWithValue("@class", studclass);
         OleDbDataAdapter da = new OleDbDataAdapter(cmd);
         DataTable dt = new DataTable();
         dt.Clear();
         da.Fill(dt);
         if (dt.Rows.Count > 0)
         {
             exe = 1;
             status = "Record(s) found successfully!";
         }
         else
         {
             exe = 0;
             status = "No record found";

         }
         return dt;
     }

     public DataTable get_ebooks_admin(string filename)
     {
         checkconn();
         conn.Open();
         string sql = "select * from library where file_ebook_name like @fen";
         OleDbCommand cmd = new OleDbCommand(sql, conn);
         cmd.Parameters.AddWithValue("@fen", "%" + filename + "%");
         OleDbDataAdapter da = new OleDbDataAdapter(cmd);
         DataTable dt = new DataTable();
         dt.Clear();
         da.Fill(dt);
         if (dt.Rows.Count > 0)
         {
             exe = 1;
             status = "Record(s) found successfully!";
         }
         else
         {
             exe = 0;
             status = "No record found";

         }
         return dt;
     }

     public DataTable get_ebooks(string file_option, string stud_class, bool status)
     {
         checkconn();
         conn.Open();
         string sql = "select * from library where file_option=@fn and student_class=@class";
         OleDbCommand cmd = new OleDbCommand(sql, conn);
         cmd.Parameters.AddWithValue("@fn", file_option);
         cmd.Parameters.AddWithValue("@class", stud_class);
         OleDbDataAdapter da = new OleDbDataAdapter(cmd);
         DataTable dt = new DataTable();
         dt.Clear();
         da.Fill(dt);
         return dt;
     }



     public void delete_ebook(string id)
     {
         checkconn();
         conn.Open();
         string sql = "delete from library where id=@id";
         OleDbCommand cmd = new OleDbCommand(sql, conn);
         cmd.Parameters.AddWithValue("@id", id);
         if (cmd.ExecuteNonQuery() != 0)
         {
             status = "File deleted successfully!";
             exe = 1;
         }
         else
         {
             status="Error: No record found to delete";
             exe = 0;
         }
     }



}