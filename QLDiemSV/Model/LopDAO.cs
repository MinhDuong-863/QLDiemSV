
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
    public void Them(Lop lop, int phong, int thu, int ca) {
        string sqlQuery = string.Format("INSERT INTO LOP (TenLop, LoaiLop, SL, HocKy, NamHoc, GV, MonHoc) VALUES ('{0}', '{1}', {2}, {3}, {4}, {5}, {6}); INSERT INTO BUOIHOC ( PhongHoc, Thu, Ca) VALUES ({7}, {8}, {9})", lop.TenLopHoc, lop.LoaiLopHoc, lop.SoSVToiDa, lop.HocKy, lop.NamHoc, lop.MaGV, lop.MaMon, phong, thu, ca);
        dbConn.ThucThi(sqlQuery);
    }

    /// <summary>
    /// @return
    /// </summary>
    public DataTable LayDanhSachLop() {
        string sqlStr = string.Format("select MaLop, TenLop, TenMon, LoaiLop, SL, HocKy, NamHoc, HoTen\r\n  from LOP, GIANGVIEN, MON\r\n  where MonHoc = MaMon and GV = MaGV");
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