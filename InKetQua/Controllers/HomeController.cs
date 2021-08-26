using DevExpress.XtraReports.UI;
using InKetQua.Models;
using InKetQua.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace InKetQua.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _env;
        private readonly IKetQuaRepo _iKetQuaRepo;
        

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env
            , IKetQuaRepo iKetQuaRepo)
        {
            _logger = logger;
            _env = env;
            _iKetQuaRepo = iKetQuaRepo;            
        }

        public IActionResult Index()
        {
            //var pathName = System.IO.Path.Combine(_env.WebRootPath, "Query\\KetQuaXnImport.txt" );

            //var tuNgay = DateTime.Now.ToString("yyyyMMdd");
            //var denNgay = DateTime.Now.AddDays(1).ToString("yyyyMMdd");

            //var kq = _iKetQuaRepo.GetListKetQuaImport(tuNgay, denNgay, pathName);
            //var a = pathName;
            


            return View();
        }

        public async Task<IActionResult> GetListKetQuaChuaIn(string tenCongTy, string congSo2)
        {
            try
            {
                var tuNgay = DateTime.Now.AddDays(-1).ToString("yyyyMMdd");
                var denNgay = DateTime.Now.AddDays(1).ToString("yyyyMMdd");

                var resultAwait = await _iKetQuaRepo.GetListKetQuaChuaIn(tuNgay, denNgay);

                if (tenCongTy == "0" && congSo2 == "0") //ds không có hợp đồng, ko có số 2
                {
                    var result = resultAwait
                    .Where(m => m.GhiChu is null || m.GhiChu.ToLower().Contains("nn")
                    || m.GhiChu.ToLower().Contains("nv")
                    || m.GhiChu == "3" || m.GhiChu == "4" || m.GhiChu == "5")
                    .ToList();                    

                    return PartialView("_GetListKetQuaChuaIn", result);
                }
                else if (tenCongTy == "1" && congSo2 == "0") // có cty, ko có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu != null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower() == "ck")
                        .OrderBy(m => m.TenCongTy)
                        .ToList();                    

                    return PartialView("_GetListKetQuaChuaIn", result);
                }
                else if (tenCongTy == "0" && congSo2 == "1") // ko có cty, có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu != null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2"))
                        .ToList();                    

                    return PartialView("_GetListKetQuaChuaIn", result);
                }

                else
                {
                    var result1 = resultAwait.Where(m => m.GhiChu != null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2") || m.GhiChu.ToLower() == "ck")
                        .OrderBy(m => m.TenCongTy)
                        .ToList();                    

                    return PartialView("_GetListKetQuaChuaIn", result);
                }

                //var result = resultAwait.ToList();

                //return PartialView("_GetListKetQuaChuaIn", result);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("GetListKetQuaChuaIn HomeController" + ex.Message);
                return Content("0");
            }
        }

        public async Task<IActionResult> GetListKetQuaDaIn(DateTime tuNgay, DateTime denNgay, string tenCongTy, string congSo2)
        {
            try
            {
                var pathName = System.IO.Path.Combine(_env.WebRootPath, "Query\\GetListKetQuaDaIn.txt");
                                
                var tuNgay1 = tuNgay.ToString("yyyyMMdd");
                var denNgay1 = denNgay.AddDays(1).ToString("yyyyMMdd");

                var resultAwait = await _iKetQuaRepo.GetListKetQuaDaIn(tuNgay1, denNgay1, pathName);

                if (tenCongTy == "0" && congSo2 == "0") //ds không có hợp đồng, ko có số 2
                {
                    var result = resultAwait
                        .Where(m => m.GhiChu is null || m.GhiChu.ToLower().Contains("nn")
                        || m.GhiChu.ToLower().Contains("nv")
                        || m.GhiChu == "3" || m.GhiChu == "4" || m.GhiChu == "5")
                        .ToList();

                    return PartialView("_GetListKetQuaDaIn", result);
                }
                else if (tenCongTy == "1" && congSo2 == "0") // có cty, ko có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu != null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower() == "ck")
                        .OrderBy(m => m.TenCongTy)
                        .ToList();

                    return PartialView("_GetListKetQuaDaIn", result);
                }
                else if (tenCongTy == "0" && congSo2 == "1") // ko có cty, có cổng 2
                {
                    var result1 = resultAwait.Where(m => m.GhiChu != null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2"))
                        .ToList();

                    return PartialView("_GetListKetQuaDaIn", result);
                }

                else
                {
                    var result1 = resultAwait.Where(m => m.GhiChu != null).ToList();

                    var result = result1
                        .Where(m => m.GhiChu.ToLower().Contains("2") || m.GhiChu.ToLower() == "ck")
                        .OrderBy(m => m.TenCongTy)
                        .ToList();

                    return PartialView("_GetListKetQuaDaIn", result);
                }


                //var result = resultAwait.ToList();

                //return PartialView("_GetListKetQuaDaIn", result);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("GetListKetQuaDaIn HomeController" + ex.Message);
                return Content("0");
            }
        }

        public async Task<IActionResult> InKetQua(int id, string thoiGianLayMau)
        {
            try
            {
                string folder = _env.WebRootPath + "\\ReportPrint";

                // Delete all files in a directory    
                string[] files = Directory.GetFiles(folder);
                foreach (string file in files)
                {
                    System.IO.File.Delete(file);
                    //Console.WriteLine($"{file} is deleted.");
                }

                var thoiGianLayMauDt = Convert.ToDateTime(thoiGianLayMau);
                var thoiGianNow = DateTime.Now;

                var timeSpan = thoiGianNow.Subtract(thoiGianLayMauDt);
                var totalMinute = timeSpan.TotalMinutes;

                if(totalMinute < 15.0)
                {
                    return Content("3");
                }
                else
                {
                    var tuNgay = DateTime.Now.AddDays(-1).ToString("yyyyMMdd");
                    var denNgay = DateTime.Now.AddDays(1).ToString("yyyyMMdd");

                    var ketQuaIn = await UpdateDaIn(id);
                    if (ketQuaIn == 1)
                    {
                        //GetReport
                        var reportResult = await GetReport(id, tuNgay, denNgay);
                        if (reportResult != null)
                        {
                            //Inreport
                            var fileName = PrintReport(reportResult);
                            return Content(fileName);
                        }
                        else
                        {
                            return Content("1"); //Lấy kết quả in bị lỗi
                        }
                    }
                    else
                    {
                        return Content("2"); //Cập nhật kết quả in bị lỗi
                    }
                }                
                
            }
            catch (Exception ex)
            {
                _logger.LogInformation("UpdateDaIn HomeController" + ex.Message);
                return Content("0");
            }
        }

        public async Task<IActionResult> InLaiKetQua(int id, DateTime tuNgay, DateTime denNgay, string thoiGianLayMau)
        {
            try
            {
                var thoiGianLayMauDt = Convert.ToDateTime(thoiGianLayMau);
                var thoiGianNow = DateTime.Now;

                var timeSpan = thoiGianNow.Subtract(thoiGianLayMauDt);
                var totalMinute = timeSpan.TotalMinutes;

                if (totalMinute < 15.0)
                {
                    return Content("3");
                }
                else
                {
                    string folder = _env.WebRootPath + "\\ReportPrint";

                    // Delete all files in a directory    
                    string[] files = Directory.GetFiles(folder);
                    foreach (string file in files)
                    {
                        System.IO.File.Delete(file);
                        //Console.WriteLine($"{file} is deleted.");
                    }

                    var tuNgay1 = tuNgay.AddDays(-1).ToString("yyyyMMdd");
                    var denNgay1 = denNgay.AddDays(1).ToString("yyyyMMdd");

                    //GetReport
                    var reportResult = await GetReport(id, tuNgay1, denNgay1);
                    if (reportResult != null)
                    {
                        //Inreport
                        var fileName = PrintReport(reportResult);
                        return Content(fileName);
                    }
                    else
                    {
                        return Content("1"); //Lấy kết quả in bị lỗi
                    }
                }               

            }
            catch (Exception ex)
            {
                _logger.LogInformation("InLaiKetQua HomeController" + ex.Message);
                return Content("0");
            }
        }

        public async Task<IActionResult> UploadKetQua(int id, string thoiGianLayMau)
        {
            try
            {
                var thoiGianLayMauDt = Convert.ToDateTime(thoiGianLayMau);
                var thoiGianNow = DateTime.Now;

                var timeSpan = thoiGianNow.Subtract(thoiGianLayMauDt);
                var totalMinute = timeSpan.TotalMinutes;

                if (totalMinute < 15.0)
                {
                    return Content("3");
                }
                else
                {
                    var ketQuaIn = await UpdateDaIn(id);
                    if (ketQuaIn == 1)
                    {
                        return Content("1");
                    }
                    else
                    {
                        return Content("0");
                    }
                }
                
            }
            catch (Exception ex)
            {
                _logger.LogInformation("UploadKetQua HomeController" + ex.Message);
                return Content("0");
            }
        }

        public async Task<IActionResult> LayBaoCao(DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                var pathName = System.IO.Path.Combine(_env.WebRootPath, "Query\\KetQuaXnImport.txt");

                var tuNgay1 = tuNgay.ToString("yyyyMMdd");
                var denNgay1 = denNgay.AddDays(1).ToString("yyyyMMdd");

                var kqAwait = await _iKetQuaRepo.GetListKetQuaImport(tuNgay1, denNgay1, pathName);
                var kq = kqAwait.ToList();

                return PartialView("_LayBaoCao", kq);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("LayBaoCao HomeController" + ex.Message);
                return Content("0");
            }
        }

        public async Task<IActionResult> XuatExcel(DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                string folder = _env.WebRootPath + "\\Excel";

                // Delete all files in a directory    
                string[] files = Directory.GetFiles(folder);
                foreach (string file in files)
                {
                    System.IO.File.Delete(file);
                    //Console.WriteLine($"{file} is deleted.");
                }


                var pathName = System.IO.Path.Combine(_env.WebRootPath, "Query\\KetQuaXnImport.txt");

                var tuNgay1 = tuNgay.ToString("yyyyMMdd");
                var denNgay1 = denNgay.AddDays(1).ToString("yyyyMMdd");

                var kqAwait = await _iKetQuaRepo.GetListKetQuaImport(tuNgay1, denNgay1, pathName);
                var kq = kqAwait.ToList();

                var soDong = kq.Count();


                string excelName = $"{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
                //string downloadUrl = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, excelName);
                
                //Sheet Chưa khai báo
                var sheetName = "ket qua";
                //var path = "TrongNgay_" + DateTime.Now.ToString("dd-MM-yy_HH-mm-ss-ffff") + ".xlsx";

                var pathToFile = Path.Combine(folder, excelName);

                var tableName = "tbl" + DateTime.Now.ToString("yyMMddHHmmssffff");               
                

                FileInfo filePath = new FileInfo(Path.Combine(folder, excelName));
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(filePath))
                {
                    var workSheet = package.Workbook.Worksheets.Add(sheetName);
                    //workSheet.Cells["A1:M1"].Merge = true;
                    //workSheet.Cells["A1:M1"].Value = "Danh sách bệnh nhân chưa khai báo - (" + soLuongBnChuaKhaiBao + ")";
                    //workSheet.Cells["A1:M1"].Style.Font.Size = 18;
                    //workSheet.Cells["A1:M1"].Style.Font.Bold = true;
                    //workSheet.Cells["A1:M1"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    //workSheet.Cells["A1:M1"].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                    //using (ExcelRange Rng = workSheet.Cells["A3:P" + soDong + 1])
                    //{
                    //    //Rng.Merge = true;
                    //    //Rng.Value = "This is my title";
                    //    ExcelTableCollection tblcollection = workSheet.Tables;
                    //    ExcelTable table = tblcollection.Add(Rng, tableName);
                    //    table.ShowHeader = true;
                    //}


                    workSheet.Cells["A2"].LoadFromCollection(kq, true);
                    //workSheet.Cells["L1:L125"].Style.Numberformat.Format = "dd-MM-yyyy HH:mm";
                    workSheet.Cells[workSheet.Dimension.Address].AutoFitColumns();

                    package.Save();

                    var memory = new MemoryStream();
                    using (var stream = new FileStream(pathToFile, FileMode.Open))
                    {
                        await stream.CopyToAsync(memory);
                    }
                    memory.Position = 0;

                    var abc = File(memory, "application/octet-stream", Path.GetFileName(pathToFile));
                    return Content(excelName);
                }                    
            }
            catch (Exception ex)
            {
                _logger.LogInformation("XuatExcel HomeController" + ex.Message);
                return Content("0");
            }
        }



        private async Task<KetQuaVm> GetReport(int id, string tuNgay, string denNgay)
        {
            try
            {
                //var thoiGian = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

                var resultAwait = await _iKetQuaRepo.GetKetQuaById(id, tuNgay, denNgay);
                var result = resultAwait;

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogInformation("UpdateDaIn HomeController" + ex.Message);
                return null;
            }
        }

        private string PrintReport(KetQuaVm ketQuaVm)
        {
            try
            {
                var reportName = System.IO.Path.Combine(_env.WebRootPath, "Reports\\rptKetQua.repx");
                var filename = DateTime.Now.ToString("yyyyMMdd_hhmmss_fff_tt") + ".pdf";
                var pathName = System.IO.Path.Combine(_env.WebRootPath, "ReportPrint\\" + filename);
                
                var report = XtraReport.FromFile(reportName, true);
                var reportData = new List<KetQuaVm>();
                reportData.Add(ketQuaVm);
                report.DataSource = reportData;
                report.CreateDocument(true);
                _logger.LogInformation(pathName);
                //var printTool = new PrintToolBase(report.PrintingSystem);
                
                report.ExportToPdf(pathName);
                return filename;
            }
            catch (Exception ex)
            {
                _logger.LogInformation("PrintReport HomeController" + ex.Message);
                return null; 
            }            
        }

        private async Task<int> UpdateDaIn(int id)
        {
            try
            {
                //var thoiGian = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

                var resultAwait = await _iKetQuaRepo.UpdateDaIn(id);
                var result = resultAwait;

                return 1;
            }
            catch (Exception ex)
            {
                _logger.LogInformation("UpdateDaIn HomeController" + ex.Message);
                return 0;
            }
        }

        public async Task<IActionResult> Admin(string matKhau)
        {
            //if(matKhau == "abc")
            //{
            //    return View();
            //}
            //return RedirectToAction("Index");
            return View();
        }

        public async Task<IActionResult> GetListCoKetQua(DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                var pathName = System.IO.Path.Combine(_env.WebRootPath, "Query\\GetListKetQua.txt");

                var tuNgay1 = tuNgay.ToString("yyyyMMdd");
                var denNgay1 = denNgay.AddDays(1).ToString("yyyyMMdd");

                var resultAwait = await _iKetQuaRepo.GetListDaKetQua(tuNgay1, denNgay1, pathName);

                

                var result = resultAwait.ToList();

                return PartialView("_GetListDaLayMauCoKq", result);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("GetListCoKetQua HomeController" + ex.Message);
                return Content("0");
            }
        }



    }
}
