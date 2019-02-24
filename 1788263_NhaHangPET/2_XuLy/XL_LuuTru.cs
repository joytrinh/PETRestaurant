using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Script.Serialization;

public class XL_LuuTru
{   
    // ******* Biến dùng chung *************
    static DirectoryInfo ThuMucDuLieu = new DirectoryInfo(HttpContext.Current.Server.MapPath("..\\DuLieu"));
    static DirectoryInfo ThuMucNhomHang = ThuMucDuLieu.GetDirectories("NhomHang")[0];
    static DirectoryInfo ThuMucMatHang = ThuMucDuLieu.GetDirectories("MatHang")[0];
    static DirectoryInfo ThuMucNhanVien = ThuMucDuLieu.GetDirectories("NhanVien")[0];
    static DirectoryInfo ThuMucQuanLy = ThuMucDuLieu.GetDirectories("QuanLy")[0];

    // ****** Xử lý Đọc **********
    public static List<XL_MatHang> DocDanhSachMatHang()
    {
        var DanhSach = new List<XL_MatHang>();
        ThuMucMatHang.GetFiles("*.json").ToList().ForEach(TapTin =>
        {
            var DuongDan = TapTin.FullName;
            var Chuoi = File.ReadAllText(DuongDan);
            var XuLy = new JavaScriptSerializer();
            var MatHang = new XL_MatHang();
            MatHang = (XL_MatHang)XuLy.Deserialize(Chuoi, MatHang.GetType());
            DanhSach.Add(MatHang);
        });
        return DanhSach;
    }
    public static List<XL_NhomHang> DocDanhSachNhomHang()
    {
        var DanhSach = new List<XL_NhomHang>();
        ThuMucNhomHang.GetFiles("*.json").ToList().ForEach(TapTin =>
        {
            var DuongDan = TapTin.FullName;
            var Chuoi = File.ReadAllText(DuongDan);
            var XuLy = new JavaScriptSerializer();
            var NhomHang = new XL_NhomHang();
            NhomHang = (XL_NhomHang)XuLy.Deserialize(Chuoi, NhomHang.GetType());
            DanhSach.Add(NhomHang);
        });
        return DanhSach;
    }
}