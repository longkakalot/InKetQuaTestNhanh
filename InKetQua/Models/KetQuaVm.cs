using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InKetQua.Models
{
    public class KetQuaVm
    {
        public int Id { get; set; }
        public string TenBenhNhan { get; set; }
        public string MaYTe { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }
        public string NamSinh { get; set; }
        public string DoiTuong { get; set; }
        public string DichVu { get; set; }
        public string NguoiChiDinh { get; set; }
        public string KhoaChiDinh { get; set; }
        public string NguoiLayMau { get; set; }
        public DateTime ThoiGianLayMau { get; set; }
        public DateTime ThoiGianKetQua { get; set; }
        public bool KetQua { get; set; }
        public int CodeXn { get; set; }       
        public DateTime ThoiGianIn { get; set; }
        public int ThanhToan { get; set; }
        public string KyThuatXetNghiem { get; set; }
        public string LyDoXetNghiem { get; set; }
        public string LoaiMau { get; set; }
        public string MaCskcb { get; set; }
    }
}
