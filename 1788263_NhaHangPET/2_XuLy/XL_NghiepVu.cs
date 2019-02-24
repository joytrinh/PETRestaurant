using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class XL_NghiepVu
{
    // Tạo Danh sách dựa vào Liên kết
    public static List<XL_MatHang> TaoDanhSachMatHangThuocMotNhomHang(List<XL_MatHang> DachSachTatCaMatHang, XL_NhomHang NhomHang)
    {
        var DanhSach = new List<XL_MatHang>();
        DanhSach = DachSachTatCaMatHang.FindAll(x => x.Nhom_Hang.Ma_so == NhomHang.Ma_so);
        return DanhSach;
    }
}