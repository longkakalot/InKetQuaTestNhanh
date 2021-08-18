using InKetQua.Models;
using InKetQua.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace InKetQua.Repository
{
    public class KetQuaRepo : IKetQuaRepo
    {
        private readonly IDapperService _dapper;
        private readonly ILogger<KetQuaRepo> _logger;
        public KetQuaRepo(IDapperService dapper, ILogger<KetQuaRepo> logger, ILoggerFactory logFactory)
        {
            _logger = logger;
            _dapper = dapper;
            _logger = logFactory.CreateLogger<KetQuaRepo>();
        }

        public async Task<KetQuaVm> GetKetQuaById(int id, string tuNgay, string denNgay)
        {
            try
            {
                //var readSql = System.IO.TextReader()
                //var tuNgay = DateTime.Now.ToString("yyyyMMdd");
                //var denNgay = DateTime.Now.AddDays(1).ToString("yyyyMMdd");
                var sql =
                    @$"select  STT = ROW_NUMBER() over (order by chitiet.TenBenhNhan),*
	from (
	select distinct
		bn.TenBenhNhan		
		,bn.MaYTe
		,bn.DiaChi
		,bn.SoDienThoai
		,GioiTinh  =  case when bn.GioiTinh = 'T' then N'M' else N'F' end		
		,NamSinh = bn.NamSinh
		,DoiTuong = dt.TenDoiTuong
		,DichVu = dv.TenDichVu
		,ThoiGianLayMau = sl.tglaymau
        ,ThoiGianKetQua = sl.tgketqua
        ,ThoiGianIn = sl.tgin
        ,Id = sl.Id
        ,KetQua = sl.KetQua
        ,CodeXn = sl.CodeXn
        ,NguoiLayMau = nv.TenNhanVien
		,ThanhToan = case when hd.HoaDon_Id is not null and hd.HuyHoaDon = 0 and hd.HoanTra = 0 then 0 else 1 end

	from CLSYeuCau yc
		left join CLSYeuCauChiTiet ct on ct.CLSYeuCau_Id = yc.CLSYeuCau_Id
		left join DM_DichVu dv on dv.DichVu_Id = ct.DichVu_Id
left join NhanVien nv on nv.NhanVien_Id = yc.BacSiChiDinh_Id
		left join TiepNhan tn on tn.TiepNhan_Id = yc.TiepNhan_Id
		left join DM_DoiTuong dt on dt.DoiTuong_Id = tn.DoiTuong_Id
		left join DM_BenhNhan bn on bn.BenhNhan_Id = yc.BenhNhan_Id	
left join HoaDonChiTiet hdct on hdct.YeuCauChiTiet_Id = ct.YeuCauChiTiet_Id
		left join HoaDon hd on hd.HoaDon_Id = hdct.HoaDon_Id
        left join SoLanIn sl on sl.IDRef = yc.CLSYeuCau_Id
	where yc.ThoiGianYeuCau between '{tuNgay}' and '{denNgay}'
		and ct.DichVu_Id in (803,1375,1410,1413)
        and yc.CLSYeuCau_Id in (select IDRef from SoLanIn where IDRef = yc.CLSYeuCau_Id)
        and sl.LayMau = 1
        and sl.ketqua is not null
        and sl.DaIn is not null and sl.tgin is not null
        and sl.Id = {id}
	) chitiet";


                var resultAwait = await _dapper.Get<KetQuaVm>(sql, null, CommandType.Text);
                var result = resultAwait;
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetKetQuaById KetQuaRepo" + ex.Message);
                return null;
            }
        }

        public async Task<IList<LayMauTestNhanh>> GetListDaKetQua(string tuNgay, string denNgay, string Query)
        {
            try
            {               

                string text = File.ReadAllText(Query);
                var sql = String.Format(text, tuNgay, denNgay);
                var resultAwait = await _dapper.GetAll<LayMauTestNhanh>(sql, null, CommandType.Text);
                var result = resultAwait.ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetListDaKetQua KetQuaRepo" + ex.Message);
                return null;
            }
        }

        public async Task<IList<KetQuaVm>> GetListKetQuaChuaIn(string tuNgay, string denNgay)
        {
            try
            {
                //var readSql = System.IO.TextReader()

                var sql =
                    @$"select  STT = ROW_NUMBER() over (order by chitiet.TenBenhNhan),*
	from (
	select distinct
		bn.TenBenhNhan		
		,bn.MaYTe
		,bn.DiaChi
		,bn.SoDienThoai
		,GioiTinh  =  case when bn.GioiTinh = 'T' then N'M' else N'F' end		
		,NamSinh = bn.NamSinh
		,DoiTuong = dt.TenDoiTuong
		,DichVu = dv.TenDichVu
		,ThoiGianLayMau = sl.tglaymau
        ,ThoiGianKetQua = sl.tgketqua
        ,ThoiGianIn = sl.tgin
        ,Id = sl.Id
        ,KetQua = sl.KetQua
        ,CodeXn = sl.CodeXn
        ,NguoiLayMau = nv.TenNhanVien
		,ThanhToan = case when hd.HoaDon_Id is not null and hd.HuyHoaDon = 0 and hd.HoanTra = 0 then 0 else 1 end
        ,tn.TenCongTy, yc.GhiChu

	from CLSYeuCau yc
		left join CLSYeuCauChiTiet ct on ct.CLSYeuCau_Id = yc.CLSYeuCau_Id
		left join DM_DichVu dv on dv.DichVu_Id = ct.DichVu_Id
left join NhanVien nv on nv.NhanVien_Id = yc.BacSiChiDinh_Id
		left join TiepNhan tn on tn.TiepNhan_Id = yc.TiepNhan_Id
		left join DM_DoiTuong dt on dt.DoiTuong_Id = tn.DoiTuong_Id
		left join DM_BenhNhan bn on bn.BenhNhan_Id = yc.BenhNhan_Id	
left join HoaDonChiTiet hdct on hdct.YeuCauChiTiet_Id = ct.YeuCauChiTiet_Id
		left join HoaDon hd on hd.HoaDon_Id = hdct.HoaDon_Id
        left join SoLanIn sl on sl.IDRef = yc.CLSYeuCau_Id
	where yc.ThoiGianYeuCau between '{tuNgay}' and '{denNgay}'
		and ct.DichVu_Id in (803,1375,1410,1413)
        and yc.CLSYeuCau_Id in (select IDRef from SoLanIn where IDRef = yc.CLSYeuCau_Id)
        and sl.LayMau = 1
        and sl.ketqua is not null
        and sl.DaIn is null and sl.tgin is null
	) chitiet";


                var resultAwait = await _dapper.GetAll<KetQuaVm>(sql, null, CommandType.Text);
                var result = resultAwait.ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetListCoKqChuaIn KetQuaRepo" + ex.Message);
                return null;
            }
        }

        public async Task<IList<KetQuaVm>> GetListKetQuaDaIn(string tuNgay, string denNgay, string Query)
        {
            try
            {               

                string text = File.ReadAllText(Query);
                var sql = String.Format(text, tuNgay, denNgay);
                var resultAwait = await _dapper.GetAll<KetQuaVm>(sql, null, CommandType.Text);
                var result = resultAwait.ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetListKetQuaDaIn KetQuaRepo" + ex.Message);
                return null;
            }
        }

        public async Task<IList<KetQuaXnImport>> GetListKetQuaImport(string tuNgay, string denNgay, string textFile)
        {
            try
            {
                //var readSql = System.IO.TextReader()

                string text = File.ReadAllText(textFile);
                var sql = String.Format(text, tuNgay, denNgay);

                var resultAwait = await _dapper.GetAll<KetQuaXnImport>(sql, null, CommandType.Text);
                var result = resultAwait.ToList();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("GetListKetQuaImport KetQuaRepo" + ex.Message);
                return null;
            }
        }

        public async Task<int> UpdateDaIn(int id)
        {
            try
            {
                var thoiGianIn = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

                var sql =
                    $@"UPDATE SoLanIn 
	                    SET DaIn = 1, tgin = '{thoiGianIn}'
	                    where id = {id} ";

                var resultAwait = await _dapper.Update<int>(sql, null, CommandType.Text);
                var result = resultAwait;
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("UpdateDaIn KetQuaRepo" + ex.Message);
                return 0;
            }
        }
    }
}
