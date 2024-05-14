
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

public class MonHocDAO {
    DBConnection dbConn = new DBConnection();

    public MonHocDAO() {
    }

    /// <summary>
    /// @return
    /// </summary>
    public DataTable LayDanhSachMon() {
        string sqlQuery = string.Format("SELECT * FROM MON");
        return dbConn.LayDanhSach(sqlQuery);
    }

}