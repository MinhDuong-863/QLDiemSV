
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

public class LopDAO {
    DBConnection dbConn = new DBConnection();

    public LopDAO() {
    }

    /// <summary>
    /// @param lop
    /// </summary>
    public void Them(Lop lop) {
        // TODO implement here
    }

    /// <summary>
    /// @return
    /// </summary>
    public DataTable LayDanhSachLop() {
        string sqlStr = string.Format("");
        return dbConn.LayDanhSach(sqlStr);
    }

    /// <summary>
    /// @return
    /// </summary>
    public DataTable LayDanhSachSV() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param sinhvien
    /// </summary>
    public void ThemLopSV(SinhVien sinhvien ) {
        // TODO implement here
    }

    /// <summary>
    /// @return
    /// </summary>
    public DataTable LayDanhSachTatCaSinhVien() {
        // TODO implement here
        return null;
    }

}