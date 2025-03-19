using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using MySql;
using MySql.Data.MySqlClient;
public class account_api
{
    public OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OleDB.4.0;Data Source=C:\WEB DEV\PCI PORTAL\database\pcidb.mdb");
    //public MySqlConnection conn = new MySqlConnection("Data Source=localhost;Initial Catalog=lpjvsrgl_pci_admin;User Id=lpjvsrgl_pci_admin;password=Online@2024;SslMode=none");
    public string status;
    public int exe;
    private bool loginStatus;
    public string g_regno, g_pincode, g_fullname, g_email, g_mobile, g_address, g_age, g_gender, g_username, g_password,g_passport, g_package, g_duration;
    public string g_staff_name;
    public string l_tutorname, l_topic, l_details;
    public string p_package, p_duration, p_amount, p_balance, p_pin_code, p_paystatus;
    public string c_course_title, c_package, c_description,cbt_status_check;
    public string t_tutor_name, t_course_taken, t_package, t_contact_no, t_username, t_password, xcbt_status, xcbt_mark, xcbt_time;
    public bool pin_used, pin_exist, cbt_exist;
    private string verify_pincode,verify_regno,package_for_cbt;
    public string result_del_file_path, upload_del_file_path, student_uploads_del_file_path;
    private string stud_class;

    public account_api()
    {

    }

    public void checkstate()
    {
        if (conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
    }

    public string generateID()
    {
        Random rnd = new Random();
        int myRandomNo = rnd.Next(1000, 9999);
        return myRandomNo.ToString();
    }


    public string generate_Pin()
    {
        Random rnd = new Random();
        int myRandomNo = rnd.Next(1000, 9999);
        int myRandomNo2 = rnd.Next(1050, 8960);
        int myRandomNo3 = rnd.Next(5000, 9000);
        return myRandomNo.ToString() +"-" +myRandomNo2.ToString() +"-"+ myRandomNo3.ToString();
    }
    public int account_ID()
    {
        checkstate();
        string check = "select * from account";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt.Rows.Count + 1;
    }

    public int contact_ID()
    {
        checkstate();
        string check = "select * from contact";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt.Rows.Count + 1;
    }


    public int payment_ID()
    {
        checkstate();
        string check = "select * from payment";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt.Rows.Count + 1;
    }

    public int course_ID()
    {
        checkstate();
        string check = "select * from course";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt.Rows.Count + 1;
    }

    public string get_package_cbt(string regno)
    {
        checkstate();
        conn.Open();
        string check = "select package from payment where reg_no=@regno";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@regno", regno);
        OleDbDataReader dr = cmd.ExecuteReader();
        if(dr.Read())
        {
            package_for_cbt = dr[0].ToString();
        }
        else
        {
            package_for_cbt = "No Course Found";
        }

        return package_for_cbt;
    }

    


    
    public string cbt_ID()
    {
        Random rnd = new Random();
        int myRandomNo = rnd.Next(1000, 9999);
        int myRandomNo2 = rnd.Next(3590, 9000);
        return "cbt-" + myRandomNo.ToString() + myRandomNo2.ToString(); ;
    }

    public int tutor_ID()
    {
        checkstate();
        string check = "select * from tutor";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt.Rows.Count + 1;
    }


    public int pin_ID()
    {
        checkstate();
        string check = "select * from pin";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt.Rows.Count + 1;
    }

    public int lecture_ID()
    {
        checkstate();
        string check = "select * from lecture";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt.Rows.Count + 1;
    }

    public int uploads_ID()
    {
        checkstate();
        string check = "select * from uploads";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt.Rows.Count + 1;
    }

    public int result_ID()
    {
        checkstate();
        string check = "select * from result";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt.Rows.Count + 1;
    }

    public int studentUploads_ID()
    {
        checkstate();
        string check = "select * from student_uploads";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt.Rows.Count + 1;
    }





    public string msg()
    {
        return status;
    }

    public void new_user(string regno, string pincode, string fullname,string email, string mobile, string address, string age, string gender, string username, string password)
    {

        checkstate();
        conn.Open();
        string check = "select * from account where reg_no=@regno";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@regno", regno);
        OleDbDataReader dr = cmd.ExecuteReader();

        if (dr.Read() == true)
        {
            exe = 0;
            status = "Existing Account please try another!";
        }
        else
        {

            save_account(regno, pincode, fullname, email, mobile, address, age, gender, username, password);
            dr.Close();
            dr.Dispose();
           
        }
    }



    public void save_account(string regno, string pincode, string fullname, string email, string mobile, string address, string age, string gender, string username, string password)
    {
        checkstate();
        string save = "insert into account values(@id,@regno,@pincode,@fullname,@email,@mobile,@address,@age,@gender,@user,@pass,@passport,@date)";
        OleDbCommand cmd = new OleDbCommand(save, conn);
        cmd.Parameters.AddWithValue("@id", account_ID());
        cmd.Parameters.AddWithValue("@regno", regno);
        cmd.Parameters.AddWithValue("@pincode", pincode);
        cmd.Parameters.AddWithValue("@fullname", fullname);
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@mobile", mobile);
        cmd.Parameters.AddWithValue("@address", address);
        cmd.Parameters.AddWithValue("@age", age);
        cmd.Parameters.AddWithValue("@gender", gender);
        cmd.Parameters.AddWithValue("@user", username);
        cmd.Parameters.AddWithValue("@pass", password);
        cmd.Parameters.AddWithValue("@passport", "");
        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Record created successfully - please login!";
            exe = 1;
        }
        else
        {
            status = "Error while creating record!";
            exe = 0;
        }
    }




    public void new_payment(string regno, string package, string duration, string amount, string balance, string pincode, string paymentStatus)
    {

        checkstate();
        conn.Open();
        string check = "select * from payment where reg_no=@regno";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@regno", regno);
        OleDbDataReader dr = cmd.ExecuteReader();

        if (dr.Read() == true)
        {
            exe = 0;
            status = "Existing registration number";
        }
        else
        {

            save_payment(regno, package, duration, amount, balance, pincode, paymentStatus);
            dr.Close();
            dr.Dispose();

        }
    }



    public void save_payment(string regno, string package, string duration, string amount, string balance, string pincode, string paymentStatus)
    {
        checkstate();
        string save = "insert into payment values(@id,@regno,@package,@duration,@amount,@balance,@pincode,@pstatus,@date)";
        OleDbCommand cmd = new OleDbCommand(save, conn);
        cmd.Parameters.AddWithValue("@id", payment_ID());
        cmd.Parameters.AddWithValue("@regno", regno);
        cmd.Parameters.AddWithValue("@package", package);
        cmd.Parameters.AddWithValue("@duration", duration);
        cmd.Parameters.AddWithValue("@amount", amount);
        cmd.Parameters.AddWithValue("@balance", balance);
        cmd.Parameters.AddWithValue("@pincode", pincode);
        cmd.Parameters.AddWithValue("@pstatus", paymentStatus);
        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Payment Record created successfully";
            exe = 1;
        }
        else
        {
            status = "Error while creating payment record!";
            exe = 0;
        }
    }




    public void new_course(string course_code,string course_title, string package, string description)
    {

        checkstate();
        conn.Open();
        string check = "select * from course where course_code=@course_code";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@course_code", course_code);
        OleDbDataReader dr = cmd.ExecuteReader();

        if (dr.Read() == true)
        {
            exe = 0;
            status = "Existing course!";
        }
        else
        {

            save_course(course_code, course_title, package, description);
            dr.Close();
            dr.Dispose();

        }
    }



    public void save_course(string course_code, string course_title, string package, string description)
    {
        checkstate();
        string save = "insert into course values(@id,@course_code,@course_title,@package,@description,@cbt_status,@cbt_mark,@cbt_time,@date)";
        OleDbCommand cmd = new OleDbCommand(save, conn);
        cmd.Parameters.AddWithValue("@id", course_ID());
        cmd.Parameters.AddWithValue("@course_code", course_code);
        cmd.Parameters.AddWithValue("@course_title", course_title);
        cmd.Parameters.AddWithValue("@package", package);
        cmd.Parameters.AddWithValue("@description", description);
        cmd.Parameters.AddWithValue("@cbt_status", "Disable");
        cmd.Parameters.AddWithValue("@cbt_mark", "0");
        cmd.Parameters.AddWithValue("@cbt_time", "0");
        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "New course added successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while adding course";
            exe = 0;
        }
    }





    // CBT

    public void new_cbt(string course, string question, string option_a, string option_b, string option_c, string answer)
    {

        checkstate();
        conn.Open();
        string check = "select * from cbt_data where course=@course and question=@question";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@course", course);
        cmd.Parameters.AddWithValue("@question", question);
        OleDbDataReader dr = cmd.ExecuteReader();

        if (dr.Read() == true)
        {
            exe = 0;
            status = "Existing CBT Question: Change";
        }
        else
        {

            save_cbt(course,question,option_a,option_b,option_c,answer);
            dr.Close();
            dr.Dispose();

        }
    }



    public void save_cbt(string course, string question, string option_a, string option_b, string option_c, string answer)
    {
        checkstate();
        conn.Open();
        string save = "insert into cbt_data values(@id,@course,@question,@option_a,@option_b,@option_c,@answer,@date)";
        OleDbCommand cmd = new OleDbCommand(save, conn);
        cmd.Parameters.AddWithValue("@id", cbt_ID());
        cmd.Parameters.AddWithValue("@course", course);
        cmd.Parameters.AddWithValue("@question", question);
        cmd.Parameters.AddWithValue("@option_a", option_a);
        cmd.Parameters.AddWithValue("@option_b", option_b);
        cmd.Parameters.AddWithValue("@option_c", option_c);
        cmd.Parameters.AddWithValue("@answer", answer);
        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "CBT Question added successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while adding CBT Question";
            exe = 0;
        }
    }

    string cbt_result_id()
    {
        Random rnd = new Random();
        return "CBTR-" + rnd.Next(10000, 90000).ToString();
    }

    public void save_cbt_result(string reg_no,string package, string score)
    {
        checkstate();
        conn.Open();
        string save = "insert into cbt_result values(@id,@reg_no,@package,@score,@date,@year)";
        OleDbCommand cmd = new OleDbCommand(save, conn);
        cmd.Parameters.AddWithValue("@id", cbt_result_id());
        cmd.Parameters.AddWithValue("@reg_no", reg_no);
        cmd.Parameters.AddWithValue("@package", package);
        cmd.Parameters.AddWithValue("@score", score);
        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
        cmd.Parameters.AddWithValue("@year", DateTime.Now.Year.ToString());
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "CBT Result has been updated successfully";
            exe = 1;
        }
        else
        {
            status = "Error while updating cbt result";
            exe = 0;
        }
    }


    public bool cbt_done(string reg_no)
    {
        checkstate();
        conn.Open();
        string check = "select * from cbt_result where reg_no=@reg_no";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@reg_no", reg_no);
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {

            cbt_exist = true;
        }
        else
        {
            cbt_exist = false;
        }
        dr.Close();
        dr.Dispose();
        return cbt_exist;
    }


    public DataTable get_cbt_result_admin()
    {
        checkstate();
        string check = "select * from cbt_result";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable get_cbt_result_student(string regno)
    {
        checkstate();
        string check = "select * from cbt_result where reg_no=@reg_no";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@reg_no", regno);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }


    public void delete_cbt_result(string id)
    {
        checkstate();
        string check = "delete  from cbt_result where cbt_id=@id";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@id", id);
        conn.Open();
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "CBT Result Deleted Successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while deleting CBT Result";
            exe = 0;
        }
    }

    public void fetch_cbt_settings(string package)
    {

        checkstate();
        conn.Open();
        string check = "select cbt_status, cbt_mark, cbt_time from course where package=@package";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@package", package);
        OleDbDataReader dr = cmd.ExecuteReader();

        if (dr.Read() == true)
        {
            exe = 1;
            xcbt_status = dr[0].ToString();
            xcbt_mark = dr[1].ToString();
            xcbt_time = dr[2].ToString();
        }
        else
        {

            exe = 0;
            xcbt_status = "";
            xcbt_mark = "";
            xcbt_time = "";
            dr.Close();
            dr.Dispose();

        }
    }


    public void update_cbt_settings( string cbt_status, string cbt_mark, string cbt_time, string cbt_package)
    {
        checkstate();
        conn.Open();
        string update = "update course set cbt_status=@cbt_status,cbt_mark=@cbt_mark,cbt_time=@cbt_time where package=@package";
        OleDbCommand cmd = new OleDbCommand(update, conn);
        cmd.Parameters.AddWithValue("@cbt_status", cbt_status);
        cmd.Parameters.AddWithValue("@cbt_mark", cbt_mark);
        cmd.Parameters.AddWithValue("@cbt_time", cbt_time);
        cmd.Parameters.AddWithValue("@package", cbt_package);
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Cbt Settings updated successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while updating Cbt Settings!";
            exe = 0;
        }
    }

    public void delete_cbt_questions(string cbt_id)
    {
        checkstate();
        conn.Open();
        string sql = "delete from cbt_data where cbt_id=@cbt_id";
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        cmd.Parameters.AddWithValue("@cbt_id", cbt_id);
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Question deleted successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while deleting question";
            exe = 0;
        }
    }

    public string check_cbt_settings(string package)
    {
        checkstate();
        conn.Open();
        string check = "select cbt_status from course where package=@package";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@package", package);
        OleDbDataReader dr = cmd.ExecuteReader();

        if (dr.Read() == true)
        {
            cbt_status_check = dr[0].ToString();
        }
        else
        {
            cbt_status_check = " ";
        }

        return cbt_status_check;
    }



    // End CBT

    
    public void save_pin(string pin, string pin_status)
    {
        checkstate();
        string save = "insert into pin values(@id,@pin,@pin_status,@date)";
        OleDbCommand cmd = new OleDbCommand(save, conn);
        cmd.Parameters.AddWithValue("@id", pin_ID());
        cmd.Parameters.AddWithValue("@pin", pin);
        cmd.Parameters.AddWithValue("@pin_status", pin_status);
        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "pin generated successfully";
            exe = 1;
        }
        else
        {
            status = "Error while generating pin";
            exe = 0;
        }
    }





    public void new_tutor(string tutor_name, string course_taken, string package, string user, string pass, string contactno)
    {
        checkstate();
        string save = "insert into tutor values(@id,@tutor_name,@course_taken,@package,@contactno,@user,@pass,@date)";
        OleDbCommand cmd = new OleDbCommand(save, conn);
        cmd.Parameters.AddWithValue("@id", tutor_ID());
        cmd.Parameters.AddWithValue("@tutor_name", tutor_name);
        cmd.Parameters.AddWithValue("@course_taken", course_taken);
        cmd.Parameters.AddWithValue("@package", package);
        cmd.Parameters.AddWithValue("@contactno", contactno);
        cmd.Parameters.AddWithValue("@user", user);
        cmd.Parameters.AddWithValue("@pass", pass);
        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "New tutor added successfully";
            exe = 1;
        }
        else
        {
            status = "Error while adding tutor!";
            exe = 0;
        }
    }

    public void new_lecture(string tutor_name, string topic, string details)
    {
        checkstate();
        string save = "insert into lecture values(@id,@tutor_name,@topic,@details,@date)";
        OleDbCommand cmd = new OleDbCommand(save, conn);
        cmd.Parameters.AddWithValue("@id", lecture_ID());
        cmd.Parameters.AddWithValue("@tutor_name", tutor_name);
        cmd.Parameters.AddWithValue("@topic", topic);
        cmd.Parameters.AddWithValue("@details", details);
        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Lecture added successfully";
            exe = 1;
        }
        else
        {
            status = "Error while adding lecture!";
            exe = 0;
        }
    }

    public void new_uploads(string package, string uploadtype, string description, string file_name, string filepath, string file_size)
    {
        checkstate();
        string save = "insert into uploads values(@id,@package,@type,@description,@filename,@path,@size,@date)";
        OleDbCommand cmd = new OleDbCommand(save, conn);
        cmd.Parameters.AddWithValue("@id", uploads_ID());
        cmd.Parameters.AddWithValue("@package", package);
        cmd.Parameters.AddWithValue("@type",uploadtype);
        cmd.Parameters.AddWithValue("@description", description);
        cmd.Parameters.AddWithValue("@filename", file_name);
        cmd.Parameters.AddWithValue("@path", filepath);
        cmd.Parameters.AddWithValue("@size", file_size);
        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Submission was successful";
            exe = 1;
        }
        else
        {
            status = "Error while uploading file";
            exe = 0;
        }
    }

    public void new_result(string regno, string description, string file_name, string path, string file_size)
    {


            save_result(regno, description, file_name, path, file_size);
    }

    public void save_result(string regno, string description, string file_name, string path, string file_size)
    {
        checkstate();
        string save = "insert into result values(@id,@regno,@description,@filename,@path,@size,@date)";
        OleDbCommand cmd = new OleDbCommand(save, conn);
        cmd.Parameters.AddWithValue("@id", result_ID());
        cmd.Parameters.AddWithValue("@regno", regno);
        cmd.Parameters.AddWithValue("@description", description);
        cmd.Parameters.AddWithValue("@filename", file_name);
        cmd.Parameters.AddWithValue("@path", path);
        cmd.Parameters.AddWithValue("@size", file_size);
        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Result Uploaded Successfully";
            exe = 1;
        }
        else
        {
            status = "Error while uploading result";
            exe = 0;
        }
    }


    public void new_student_uploads(string student_name, string tutor, string type, string description, string file_name, string path, string file_size)
    {

        checkstate();
        conn.Open();
        string check = "select * from student_uploads where student_name=@studname and file_name=@filename";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@studname", student_name );
        cmd.Parameters.AddWithValue("@filename", file_name);
        OleDbDataReader dr = cmd.ExecuteReader();

        if (dr.Read() == true)
        {
            exe = 0;
            status = "you have uploaded already!";
        }
        else
        {

            save_student_uploads(student_name, tutor, type, description, file_name, path, file_size);
            dr.Close();
            dr.Dispose();

        }
    }

    public void save_student_uploads(string student_name, string tutor, string type, string description, string file_name, string path, string file_size)
    {
        checkstate();
        string save = "insert into student_uploads values(@id,@student_name,@tutor,@type,@description,@file_name,@path,@file_size,@date)";
        OleDbCommand cmd = new OleDbCommand(save, conn);
        cmd.Parameters.AddWithValue("@id", studentUploads_ID());
        cmd.Parameters.AddWithValue("@student_name", student_name);
        cmd.Parameters.AddWithValue("@tutor", tutor);
        cmd.Parameters.AddWithValue("@type", type);
        cmd.Parameters.AddWithValue("@description", description);
        cmd.Parameters.AddWithValue("@file_name", file_name);
        cmd.Parameters.AddWithValue("@path", path);
        cmd.Parameters.AddWithValue("@file_size", file_size);
        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());

        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "You file uploaded successfully";
            exe = 1;
        }
        else
        {
            status = "Error while uploading file";
            exe = 0;
        }
    }






    public void new_request(string fullname, string email, string mobile, string description)
    {
        checkstate();
        string check = "select * from contact where email=@email and description=@des";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@des", description);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            status = "Your request have been sent already!";
        }
        else
        {
            save_request(fullname, email, mobile, description);
        }
        dr.Close();
        dr.Dispose();
    }



    public void save_request(string fullname, string email, string mobile, string description)
    {
        checkstate();
        string save = "insert into contact values(@id,@fname,@email,@mobile,@des,@date)";
        OleDbCommand cmd = new OleDbCommand(save, conn);
        cmd.Parameters.AddWithValue("@id", contact_ID());
        cmd.Parameters.AddWithValue("@fname", fullname);
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@mobile", mobile);
        cmd.Parameters.AddWithValue("@des", description);
        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Your request have been sent successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while sending request!";
            exe = 0;
        }
    }







    public DataTable get_contact()
    {
        checkstate();
        string check = "select * from contact";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable get_course()
    {
        checkstate();
        string check = "select * from course";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable get_cbt_data()
    {
        checkstate();
        string check = "select * from cbt_data";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable get_cbt_course_data(string course)
    {
        checkstate();
        string check = "select * from cbt_data where course=@course";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@course", course);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        if(dt.Rows.Count>0)
        {
            exe = 1;
            status = "CBT has started... Goodluck!";
        }
        else
        {
            exe =0;
            status = "CBT has not been setup for your course yet.";
        }
        return dt;
    }



    public DataTable get_course_user(string package)
    {
        checkstate();
        string check = "select * from course where package=@package";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@package", package);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable get_tutorsName()
    {
        checkstate();
        string check = "select tutor_name from tutor";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }


    public DataTable get_tutors()
    {
        checkstate();
        string check = "select * from tutor";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }


    public DataTable get_tutors_package( string package)
    {
        checkstate();
        string check = "select tutor_name,course_taken,package,contact_no from tutor where package=@package";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@package", package);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable get_pins()
    {
        checkstate();
        string check = "select * from pin";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable get_record()
    {
        checkstate();
        string check = "select * from account";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable get_payment(string package)
    {
        checkstate();
        string check = "select * from payment where package=@package";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@package", package);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable get_payment()
    {
        checkstate();
        string check = "select * from payment";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable get_mobile_numbers()
    {
        checkstate();
        string check = "select id, fullname, mobile, date from account ";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable get_lecture()
    {
        checkstate();
        string check = "select * from lecture";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }


   


    public DataTable get_result()
    {
        checkstate();
        string check = "select * from result";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable get_result_regno(string reg_no)
    {
        checkstate();
        string check = "select * from result where reg_no=@regno";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@regno", reg_no);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }


    public DataTable get_uploads_package(string package)
    {
        checkstate();
        string check = "select * from uploads where package=@package";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@package", package);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }


    public DataTable get_uploads()
    {
        checkstate();
        string check = "select * from uploads";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable get_student_uploads()
    {
        checkstate();
        string check = "select * from student_uploads";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public DataTable get_student_uploads_tutor( string tutor)
    {
        checkstate();
        string check = "select * from student_uploads where tutor=@tutor";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("tutor", tutor);
        conn.Open();
        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        DataTable dt = new DataTable();
        dt.Clear();
        da.Fill(dt);
        return dt;
    }

    public string get_class(string regno)
    {
        checkstate();
        string check = "select * from payment where reg_no=@regno";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@regno", regno);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {

            stud_class = dr[2].ToString();
        }
        else
        {
            status = "invalid username or password";
            stud_class = "";
        }
        dr.Close();
        dr.Dispose();
        return stud_class;
    }

    public bool login(string username, string password)
    {
        checkstate();
        string check = "select * from account where username=@user and password=@pass";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@user", username);
        cmd.Parameters.AddWithValue("@pass", password);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            
            loginStatus = true;
            g_regno = dr[1].ToString();
        }
        else
        {
            status = "invalid username or password";
            loginStatus = false;
        }
        dr.Close();
        dr.Dispose();
        return loginStatus;
    }

    public bool staff_login(string username, string password)
    {
        checkstate();
        string check = "select * from tutor where username=@user and password=@pass";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@user", username);
        cmd.Parameters.AddWithValue("@pass", password);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            g_staff_name = dr[1].ToString();
            loginStatus = true;
        }
        else
        {
            status = "invalid username or password";
            loginStatus = false;
        }
        dr.Close();
        dr.Dispose();
        return loginStatus;
    }

    public void update_pin(string pin)
    {
        checkstate();
        string check = "update pin set pin_status=@status where pin=@pin";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@status", "1");
        cmd.Parameters.AddWithValue("@pin", pin);
        conn.Open();
        cmd.ExecuteNonQuery();
    }

    public bool pin_verify(string pin)
    {
        checkstate();
        string check = "select * from pin where pin=@pin";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@pin", pin);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {

             pin_exist = true;
        }
        else
        {
            pin_exist= false;
        }
        dr.Close();
        dr.Dispose();
        return pin_exist;
    }

    public bool pin_available(string pin)
    {
        checkstate();
        string check = "select pin_status from pin where pin=@pin";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@pin", pin );
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            string xstatus = dr[0].ToString();
            if (xstatus == "0")
            {
                pin_used = true;
            }
            else
            {
                pin_used = false;
            }
        }
        else
        {
            
        }
        dr.Close();
        dr.Dispose();
        return pin_used;
    }

    public string pin_check(string regno)
    {
        checkstate();
        string check = "select pin_code from payment where reg_no=@regno";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@regno", regno);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            verify_pincode = dr[0].ToString();
        }
        dr.Close();
        dr.Dispose();
        return verify_pincode;
    }

    public string regno_check(string regno)
    {
        checkstate();
        string check = "select reg_no from payment where reg_no=@regno";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@regno", regno);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            verify_regno = dr[0].ToString();
        }
        dr.Close();
        dr.Dispose();
        return verify_regno;
    }


    public void get_update(string username)
    {
        checkstate();
        string check = "select * from account where username=@user";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@user", username);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            g_regno = dr[1].ToString();
            g_pincode = dr[2].ToString();
            g_fullname = dr[3].ToString();
            g_email = dr[4].ToString();
            g_mobile = dr[5].ToString();
            g_address = dr[6].ToString();
            g_age = dr[7].ToString();
            g_gender = dr[8].ToString();
            g_username = dr[9].ToString();
            g_password = dr[10].ToString();
            g_passport = dr[11].ToString();
            status = "successful!";

        }
        else
        {
            status = "No data found";
        }
        dr.Close();
        dr.Dispose();
    }

    public void get_update2(string reg_no)
    {
        checkstate();
        string check = "select * from payment where reg_no=@regno";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@regno", reg_no);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            g_package = dr[2].ToString();
            g_duration = dr[3].ToString();
            status = "successful!";

        }
        else
        {
            status = "No data found";
        }
        dr.Close();
        dr.Dispose();
    }
    public void get_lecture_last_post()
    {
        checkstate();
        string check = "select * from lecture order by id desc";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
           l_tutorname = dr[1].ToString();
           l_topic = dr[2].ToString();
          l_details= dr[3].ToString();
            status = "successful!";

        }
        else
        {
            status = "No data found";
        }
        dr.Close();
        dr.Dispose();
    }

    public void get_record_regno(string reg_no)
    {
        checkstate();
        string check = "select * from account where reg_no=@reg_no";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@reg_no", reg_no );
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            g_pincode = dr[2].ToString();
            g_fullname = dr[3].ToString();
            g_email = dr[4].ToString();
            g_mobile = dr[5].ToString();
            g_address = dr[6].ToString();
            g_age = dr[7].ToString();
            g_gender = dr[8].ToString();
            status = "successful!";

        }
        else
        {
            status = "No data found";
        }
        dr.Close();
        dr.Dispose();
    }


    public void get_payment_regno(string reg_no)
    {
        checkstate();
        string check = "select * from payment where reg_no=@reg_no";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@reg_no", reg_no);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            p_package = dr[3].ToString();
            p_duration= dr[4].ToString();
            p_amount = dr[5].ToString();
            p_balance = dr[6].ToString();
            p_pin_code = dr[7].ToString();
            p_paystatus = dr[8].ToString();
            status = "successful!";

        }
        else
        {
            status = "No data found";
        }
        dr.Close();
        dr.Dispose();
    }

    public void get_course_coursecode(string coursecode)
    {
        checkstate();
        string check = "select * from course where course_code=@coursecode";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@coursecode", coursecode);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            c_course_title = dr[3].ToString();
            c_package = dr[4].ToString();
            c_description = dr[5].ToString();
            status = "successful!";

        }
        else
        {
            status = "No data found";
        }
        dr.Close();
        dr.Dispose();
    }

    public void get_tutor_ID(string id)
    {
        checkstate();
        string check = "select * from tutor where id=@id";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@id", id);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            t_tutor_name = dr[2].ToString();
            t_course_taken = dr[3].ToString();
            t_package = dr[4].ToString();
            t_contact_no = dr[5].ToString();
            status = "successful!";

        }
        else
        {
            status = "No data found";
        }
        dr.Close();
        dr.Dispose();
    }


    public void search_record(string regno)
    {
        checkstate();
        string check = "select * from account where reg_no=@regno";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@regno", regno);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            g_fullname = dr[3].ToString();
            g_email = dr[4].ToString();
            g_mobile = dr[5].ToString();
            g_address = dr[6].ToString();
            g_age = dr[7].ToString();
            g_gender = dr[8].ToString();
            g_username = dr[9].ToString();
            g_password = dr[10].ToString();
            exe = 1;
            status = "successful!";

        }
        else
        {
            status = "No data found";
            exe = 0;
        }
        dr.Close();
        dr.Dispose();
    }


    public void update_record(string fullname, string email, string mobile, string address, string age, string gender, string username,string password, string regno)
    {
        checkstate();
        conn.Open();
        string update = "update account set fullname=@fname,email=@email,mobile=@mobile,address=@address,age=@age,gender=@gender,[username]=@user,[password]=@pass where reg_no=@regno";
        OleDbCommand cmd = new OleDbCommand(update, conn);
        cmd.Parameters.AddWithValue("@fname", fullname);
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@mobile", mobile);
        cmd.Parameters.AddWithValue("@address", address);
        cmd.Parameters.AddWithValue("@age", age);
        cmd.Parameters.AddWithValue("@gender", gender);
        cmd.Parameters.AddWithValue("@user", username);
        cmd.Parameters.AddWithValue("@pass", password);
        cmd.Parameters.AddWithValue("@regno", regno);
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Record updated successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while updating record!";
            exe = 0;
        }
    }

    public void delete_record(string regno)
    {
        checkstate();
        string check = "delete * from account where reg_no=@regno";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@regno", regno);
        conn.Open();
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Record Deleted Successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while deleting record";
            exe = 0;
        }
    }





    public void search_payment(string regno)
    {
        checkstate();
        string check = "select * from payment where reg_no=@regno";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@regno", regno);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            p_package = dr[2].ToString();
            p_duration = dr[3].ToString();
            p_amount = dr[4].ToString();
            p_balance = dr[5].ToString();
            p_paystatus  = dr[7].ToString();
            status = "successful!";
            exe = 1;

        }
        else
        {
            status = "No data found";
            exe = 0;
        }
        dr.Close();
        dr.Dispose();
    }


    public void update_payment(string package, string duration, string amount, string balance,string paymentStatus, string regno)
    {
        checkstate();
        conn.Open();
        string update = "update payment set package=@package,duration=@duration,amount=@amount,balance=@balance,payment_status=@pstatus where reg_no=@regno";
        OleDbCommand cmd = new OleDbCommand(update, conn);
        cmd.Parameters.AddWithValue("@package", package);
        cmd.Parameters.AddWithValue("@duration", duration);
        cmd.Parameters.AddWithValue("@amount", amount);
        cmd.Parameters.AddWithValue("@balance", balance);
        cmd.Parameters.AddWithValue("@pstatus", paymentStatus);
        cmd.Parameters.AddWithValue("@regno", regno);
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Payment Record updated successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while updating record!";
            exe = 0;
        }
    }

    public void delete_payment(string regno)
    {
        checkstate();
        string check = "delete  from payment where reg_no=@regno";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@regno", regno);
        conn.Open();
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Payment Record Deleted Successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while deleting record";
            exe = 0;
        }
    }



    public void search_course(string course_code)
    {
        checkstate();
        string check = "select * from course where course_code=@coursecode";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@coursecode", course_code);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            c_course_title = dr[2].ToString();
            c_package = dr[3].ToString();
            c_description = dr[4].ToString();
            status = "successful!";
            exe = 1;

        }
        else
        {
            status = "No data found";
            exe = 0;
        }
        dr.Close();
        dr.Dispose();
    }


    public void update_course(string course_title, string package, string description, string coursecode)
    {
        checkstate();
        conn.Open();
        string update = "update course set course_title=@coursetitle,package=@package,description=@description where course_code=@coursecode";
        OleDbCommand cmd = new OleDbCommand(update, conn);
        cmd.Parameters.AddWithValue("@coursetitle", course_title);
        cmd.Parameters.AddWithValue("@package", package);
        cmd.Parameters.AddWithValue("@description", description);
        cmd.Parameters.AddWithValue("@coursecode", coursecode);
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Course updated successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while updating course!";
            exe = 0;
        }
    }

    public void delete_course(string coursecode)
    {
        checkstate();
        string check = "delete  from course where course_code=@coursecode";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@coursecode", coursecode );
        conn.Open();
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Course Deleted Successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while deleting course";
            exe = 0;
        }
    }





    public void search_tutor(string ID)
    {
        checkstate();
        string check = "select * from tutor where id=@id";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@id", ID);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            t_tutor_name = dr[1].ToString();
           t_course_taken = dr[2].ToString();
            t_package = dr[3].ToString();
            t_contact_no = dr[4].ToString();
            t_username = dr[5].ToString();
            t_password = dr[6].ToString();
            status = "successful!";
            exe = 1;

        }
        else
        {
            status = "No data found";
            exe = 0;
        }
        dr.Close();
        dr.Dispose();
    }


    public void update_tutor(string tutorname, string coursetaken, string package, string contactno, string username, string password, string id)
    {
        checkstate();
        conn.Open();
        string update = "update tutor set tutor_name=@tutorname,course_taken=@coursetaken,package=@package,contact_no=@contactno,[username]=@username,[password]=@password where id=@id";
        OleDbCommand cmd = new OleDbCommand(update, conn);
        cmd.Parameters.AddWithValue("@tutorname", tutorname);
        cmd.Parameters.AddWithValue("@coursetaken", coursetaken);
        cmd.Parameters.AddWithValue("@package", package);
        cmd.Parameters.AddWithValue("@contactno", contactno);
        cmd.Parameters.AddWithValue("@username", username);
        cmd.Parameters.AddWithValue("@password", password);
        cmd.Parameters.AddWithValue("@id", id);
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Tutor updated successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while updating tutor!";
            exe = 0;
        }
    }

    public void delete_tutor(string id)
    {
        checkstate();
        string check = "delete  from tutor where id=@id";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@id", id);
        conn.Open();
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Tutor Deleted Successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while deleting Tutor";
            exe = 0;
        }
    }

    public void update_profile(string fullname, string email, string mobile, string address, string age, string gender, string passport, string username)
    {
        checkstate();
        conn.Open();
        string update = "update account set fullname=@fname,email=@email,mobile=@mobile,address=@address,age=@age,gender=@gender,passport=@passport where username=@user";
        OleDbCommand cmd = new OleDbCommand(update, conn);
        cmd.Parameters.AddWithValue("@fname", fullname);
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@mobile", mobile);
        cmd.Parameters.AddWithValue("@address", address);
        cmd.Parameters.AddWithValue("@age", age);
        cmd.Parameters.AddWithValue("@gender", gender);
        cmd.Parameters.AddWithValue("@passport", passport);
        cmd.Parameters.AddWithValue("@user", username);
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Record updated successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while updating record!";
            exe = 0;
        }
    }

    public void update_profile2(string fullname, string email, string mobile, string address, string age, string gender,string username)
    {
        checkstate();
        conn.Open();
        string update = "update account set fullname=@fname,email=@email,mobile=@mobile,address=@address,age=@age,gender=@gender where username=@user";
        OleDbCommand cmd = new OleDbCommand(update, conn);
        cmd.Parameters.AddWithValue("@fname", fullname);
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@mobile", mobile);
        cmd.Parameters.AddWithValue("@address", address);
        cmd.Parameters.AddWithValue("@age", age);
        cmd.Parameters.AddWithValue("@gender", gender);
        cmd.Parameters.AddWithValue("@user", username);
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Record updated successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while updating record!";
            exe = 0;
        }
    }

    // Delete uploads and results

    public void delete_uploads(string id)
    {
        checkstate();
        string check = "delete  from uploads where id=@id";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@id", id);
        conn.Open();
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Uploads Deleted Successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while deleting uploads";
            exe = 0;
        }
    }

    public void delete_student_uploads(string id)
    {
        checkstate();
        string check = "delete from student_uploads where id=@id";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@id", id);
        conn.Open();
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Uploads Deleted Successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while deleting uploads";
            exe = 0;
        }
    }

    public void delete_results(string id)
    {
        checkstate();
        string check = "delete from result where id=@id";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@id", id);
        conn.Open();
        if (cmd.ExecuteNonQuery() != 0)
        {
            status = "Results Deleted Successfully!";
            exe = 1;
        }
        else
        {
            status = "Error while deleting results";
            exe = 0;
        }
    }

    public string get_result_file_path(string ID)
    {
        checkstate();
        string check = "select path from result where id=@id";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@id", ID);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            result_del_file_path = dr[0].ToString();
        }
        else
        {
            result_del_file_path = "Nothing";
            exe = 0;
        }
        dr.Close();
        dr.Dispose();

        return result_del_file_path;
    }


    public string get_uploads_file_path(string ID)
    {
        checkstate();
        string check = "select path from uploads where id=@id";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@id", ID);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            upload_del_file_path = dr[0].ToString();
        }
        else
        {
            upload_del_file_path = "Nothing";
            exe = 0;
        }
        dr.Close();
        dr.Dispose();

        return upload_del_file_path;
    }


    public string get_student_uploads_file_path(string ID)
    {
        checkstate();
        string check = "select path from student_uploads where id=@id";
        OleDbCommand cmd = new OleDbCommand(check, conn);
        cmd.Parameters.AddWithValue("@id", ID);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            student_uploads_del_file_path = dr[0].ToString();
        }
        else
        {
            student_uploads_del_file_path = "Nothing";
            exe = 0;
        }
        dr.Close();
        dr.Dispose();

        return student_uploads_del_file_path;
    }

}