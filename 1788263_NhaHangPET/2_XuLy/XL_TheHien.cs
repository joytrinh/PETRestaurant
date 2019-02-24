using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

public class XL_TheHien
{
    public static CultureInfo DinhDangVN = CultureInfo.GetCultureInfo("vi-VN");

    // Thể hiện Đối tượng Người dùng khi Chào
    public static string TaoChuoiHTMLChaoKhachThamQuan(XL_KhachThamQuan KTQ)
    {
        var ChuoiHinh = $"<img src='../Media/{KTQ.MaSo}.png' style='width:60px;height:60px;margin:5px;' />";
        var ChuoiLoiChao = $"<div class='btn'> Xin chào {KTQ.HoTen} </div>";
        var ChuoiHTML = $"<div class='btn' > {ChuoiHinh} {ChuoiLoiChao} </div>";
        return ChuoiHTML;
    }
    public static string TaoChuoiHTMLDanhSachNhomHang(List<XL_NhomHang> DanhSachNhomHang, List<XL_MatHang> DanhSachMatHang)
    {
        var ChuoiHTML = "<div> ";
        DanhSachNhomHang.ForEach(NhomHang =>
        {
            var DanhSachMatHangCuaNhomHang = XL_NghiepVu.TaoDanhSachMatHangThuocMotNhomHang(DanhSachMatHang, NhomHang);
            var ChuoiHinh = $"<img src='../Media/{NhomHang.Ma_so}.png' style='width:40px;height:40px;margin:5px;' />";
            var ChuoiTen = $"<div class='btn 'style='border:none'> {NhomHang.Ten} {DanhSachMatHangCuaNhomHang.Count} </div>";
            ChuoiHTML += $"<div class='btn'  > {ChuoiHinh} {ChuoiTen} </div>";
        });
        ChuoiHTML += "</div> <br/>";
        return ChuoiHTML;
    }
    public static string TaoChuoiHTMLDanhSachMatHang(List<XL_MatHang> DanhSachMatHang)
    {
        var ChuoiHTML = "<div class='row'>";
        DanhSachMatHang.ForEach(MatHang =>
        {
            var ChuoiHinh = $"<img src='../Media/{MatHang.Ma_so}.png' style='width:40px;height:40px;margin:5px;' />";
            var ChuoiTen = $"<div class='btn' style='text-align:left'> {MatHang.Ten} <br/>" + $"Đơn giá {MatHang.Don_gia_Ban.ToString("n0", DinhDangVN)}</div> <br/>";
            ChuoiHTML += $"<div class='col-md-4'> {ChuoiHinh} {ChuoiTen} </div>";
        });
        ChuoiHTML += "</div>";
        return ChuoiHTML;
    }
}