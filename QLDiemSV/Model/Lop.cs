
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Lop
{

    public Lop(string tenLopHoc, string loaiLopHoc, int soSVToiDa, int hocKy, int namHoc, int maGV, int maMon) {
        this.tenLopHoc = tenLopHoc;
        this.loaiLopHoc = loaiLopHoc;
        this.soSVToiDa = soSVToiDa;
        this.hocKy = hocKy;
        this.namHoc = namHoc;
        this.maGV = maGV;
        this.maMon = maMon;
    }

    private int maLop;

    private string tenLopHoc;

    private string loaiLopHoc;

    private int soSVToiDa;

    private int hocKy;

    private int namHoc;

    private int maGV;

    private int maMon;

    public int MaLop
    {
        get { return maLop; }
        set { maLop = value; }
    }

    public string TenLopHoc
    {
        get { return tenLopHoc; }
        set { tenLopHoc = value; }
    }

    public string LoaiLopHoc
    {
        get { return loaiLopHoc; }
        set { loaiLopHoc = value; }
    }

    public int SoSVToiDa
    {
        get { return soSVToiDa; }
        set { soSVToiDa = value; }
    }

    public int HocKy
    {
        get { return hocKy; }
        set { hocKy = value; }
    }

    public int NamHoc
    {
        get { return namHoc; }
        set { namHoc = value; }
    }

    public int MaGV
    {
        get { return maGV; }
        set { maGV = value; }
    }

    public int MaMon
    {
        get { return maMon; }
        set { maMon = value; }
    }

}