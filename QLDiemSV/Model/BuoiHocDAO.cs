
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

public class BuoiHocDAO {
    DBConnection dbConn = new DBConnection();

    public BuoiHocDAO() {
    }

    /// <summary>
    /// @param maSV 
    /// @param hocKy 
    /// @param namHoc 
    /// @return
    /// </summary>
    public DataTable LayTKB(int maSV, int hocKy, int namHoc) {
        // TODO implement here
        return null;
    }
    public DataTable LayDanhSachBuoi()
    {
        string sqlQuery = string.Format("SELECT * FROM BUOIHOC");
        return dbConn.LayDanhSach(sqlQuery);
    }
}