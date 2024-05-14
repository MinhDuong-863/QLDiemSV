
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;

public class DBConnection {
    SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-JGJ5K3KB;Initial Catalog=QuanLySinhVien;Persist Security Info=True;User ID=sa;Password=123456;Integrated Security=True");

    public DBConnection()
    {
    }

    /// <summary>
    /// @param sqlQuery 
    /// @return
    /// </summary>
    public DataTable LayDanhSach(string sqlQuery) {
        // TODO implement here
        DataTable dtds = new DataTable();
        try
        {
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conn);
            adapter.Fill(dtds);
            
        }
        catch (Exception exc)
        {
            MessageBox.Show(exc.Message);
        }
        finally
        {
            conn.Close();
        }
        return dtds;
    }

    /// <summary>
    /// @param sqlQuery 
    /// @return
    /// </summary>
    public DataTable LayThongTin(string sqlQuery) {
        // TODO implement here
        DataTable dtds = new DataTable();
        try
        {
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conn);
            adapter.Fill(dtds);

        }
        catch (Exception exc)
        {
            MessageBox.Show(exc.Message);
        }
        finally
        {
            conn.Close();
        }
        return dtds;
    }

    /// <summary>
    /// @param sqlQuery
    /// </summary>
    public void ThucThi(string sqlQuery)
    {
        // TODO implement here
    }

}