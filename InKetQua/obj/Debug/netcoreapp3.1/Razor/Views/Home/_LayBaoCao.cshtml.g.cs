#pragma checksum "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d0128891bc85c65eb97bceeeab8fda0708f42c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__LayBaoCao), @"mvc.1.0.view", @"/Views/Home/_LayBaoCao.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\_ViewImports.cshtml"
using InKetQua;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\_ViewImports.cshtml"
using InKetQua.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0128891bc85c65eb97bceeeab8fda0708f42c5", @"/Views/Home/_LayBaoCao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85b0c7a9a59bbeebb46814699697d82f88779699", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__LayBaoCao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KetQuaXnImport>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
  
    var stt = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""float-right"">
    <button id=""btnXuatExcel"" class=""btn btn-primary"">Xuất excel</button>
</div>
<table id=""tblBaoCao"" class=""table display table-striped table-bordered"" style=""width:100%; font-size: 13px; color: black"">
    <thead>
        <tr class=""text-center"">
            <th>STT</th>
            <th>Họ tên</th>
            <th>Điện thoại</th>
            <th>Năm sinh</th>
            <th>Giới tính</th>
            <th>Địa chỉ</th>
            <th>Kết quả</th>
            <th>Kỹ thuật XN</th>
            <th>Lý do xét nghiệm</th>
            <th>Loại mẫu</th>
            <th>Thời gian lấy mẫu</th>
            <th>Thời gian kết quả</th>           

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 29 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
         foreach (var item in Model.OrderBy(m => m.ThoiGianKetQua))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 32 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                Write(stt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 33 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                                                      Write(item.HoVaTen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 34 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                                                      Write(item.SoDienThoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 35 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                                                      Write(item.NamSinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 37 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                     if (item.GioiTinh == "1")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Nữ</p>\r\n");
#nullable restore
#line 40 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Nam</p>\r\n");
#nullable restore
#line 44 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>");
#nullable restore
#line 46 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
               Write(item.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 48 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                     if (item.KetQua == "2")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"btn btn-primary\">\r\n                            Âm tính\r\n                        </span>\r\n");
#nullable restore
#line 53 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"btn btn-danger\">\r\n                            Dương tính\r\n                        </span>\r\n");
#nullable restore
#line 59 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 62 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                     if (item.KyThuatXetNghiem == "1")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Xét nghiệm nhanh kháng nguyên</span>\r\n");
#nullable restore
#line 65 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>RT-PCR</span>\r\n");
#nullable restore
#line 69 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 73 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                     if(item.LyDoXetNghiem == "1")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Thường quy</span>\r\n");
#nullable restore
#line 76 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Khẩn cấp</span>\r\n");
#nullable restore
#line 80 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 84 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                     if (item.LoaiMau == "0")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Mẫu đơn</span>\r\n");
#nullable restore
#line 87 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Mẫu gộp</span>\r\n");
#nullable restore
#line 91 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 94 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
               Write(item.ThoiGianLayMau);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 96 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
               Write(item.ThoiGianKetQua);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 100 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_LayBaoCao.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            WriteLiteral(@"    <script>               
        function XuatExcel() {
            var tuNgay = $(""#dtTuNgay"").val();
            var denNgay = $(""#dtDenNgay"").val();

            $.ajax({
                type: ""GET"",
                url: ""/Home/XuatExcel"",
                //data: JSON.stringify(obj),
                data: { 'tuNgay': tuNgay, 'denNgay': denNgay },
                //contentType: ""application/json; charset=utf-8"",
                dataType: ""text"",
                success: function (response) {
                    //alert(response);
                    if (response === 0 || response === ""0"") {
                        swal.fire(""Lỗi khi xuất excel"");
                        return false;
                    } else {                        
                        window.location.href = ""/Excel/"" + response;
                    }
                },
                failure: function (response) {
                    swal.fire(""GetKhoaPhongChiTiet (failure): "" + response);
                ");
            WriteLiteral(@"},
                error: function (response) {
                    swal.fire(""GetKhoaPhongChiTiet (error): "" + response);
                }
            });
        }
        $(document).ready(function () {
            $('#tblBaoCao').DataTable();

            $(""#btnXuatExcel"").click(function () {
                XuatExcel();
            });
        });
    </script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KetQuaXnImport>> Html { get; private set; }
    }
}
#pragma warning restore 1591
