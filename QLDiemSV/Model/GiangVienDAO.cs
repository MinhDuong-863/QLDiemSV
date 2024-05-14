
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

public class GiangVienDAO {
    DBConnection dbConn = new DBConnection();

    public GiangVienDAO() {
    }

    /// <summary>
    /// @return
    /// </summary>
    public DataTable LayDanhSachGV() {
        string sqlQuery = string.Format("SELECT * FROM GIANGVIEN");
        return dbConn.LayDanhSach(sqlQuery);
    }
    public DataTable LayDanhSachLichDayGV(int gv)
    {
        string sqlQuery = string.Format("SELECT bh.* FROM LOP  AS l JOIN BUOIHOC AS bh ON l.MaLop = bh.MaLop WHERE GV = {0}", gv);
        return dbConn.LayDanhSach(sqlQuery);
    }
}