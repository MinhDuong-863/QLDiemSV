
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

}