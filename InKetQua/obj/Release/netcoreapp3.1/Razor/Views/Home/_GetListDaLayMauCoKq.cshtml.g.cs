#pragma checksum "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "133561bb1cda6681e89becf5a0e2faa9977c73a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__GetListDaLayMauCoKq), @"mvc.1.0.view", @"/Views/Home/_GetListDaLayMauCoKq.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133561bb1cda6681e89becf5a0e2faa9977c73a7", @"/Views/Home/_GetListDaLayMauCoKq.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85b0c7a9a59bbeebb46814699697d82f88779699", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__GetListDaLayMauCoKq : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LayMauTestNhanh>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
  
    var stt = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<table id=""tblDanhSachCoKetQua"" class=""table display table-striped table-bordered"" style=""width:100%; font-size: 13px; color: black"">
    <thead>
        <tr class=""text-center"">
            <th style=""width: 5%"">STT</th>
            <th style=""width: 5%"">Mã Y tế</th>
            <th style=""width: 10%"">Họ tên</th>
            <th style=""width: 5%"">Năm sinh</th>
            <th style=""width: 5%"">Giới tính</th>
            <th style=""width: 10%"">Điện thoại</th>
            <th style=""width: 20%"">Tên chỉ định</th>
            <th style=""width: 10%"">Thời gian kết quả</th>
            <th style=""width: 20%"">Đối tượng</th>

            <th style=""width: 10%"">Kết quả</th>
            <th>Ghi chú</th>
            <th>#</th>
");
            WriteLiteral("\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
         foreach (var item in Model.OrderByDescending(m=>m.ThoiGian))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 41 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
            Write(stt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 42 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                                                  Write(item.MaYTe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 43 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                                                  Write(item.TenBenhNhan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"color: blue; font-weight: bold\">");
#nullable restore
#line 44 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                                                  Write(item.NamSinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 46 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                 if (item.GioiTinh == "F")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Nữ</p>\r\n");
#nullable restore
#line 49 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Nam</p>\r\n");
#nullable restore
#line 53 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>");
#nullable restore
#line 55 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
           Write(item.SoDienThoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 56 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
           Write(item.DichVu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 57 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
           Write(item.ThoiGian.ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 59 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                 if (item.ThanhToan == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"btn btn-info\">Theo Yêu cầu</span>\r\n");
#nullable restore
#line 62 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 65 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                 if (item.KetQua == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"btn btn-primary\">\r\n                        Âm tính\r\n                    </span>\r\n");
#nullable restore
#line 70 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"btn btn-danger\">\r\n                        Dương tính\r\n                    </span>\r\n");
#nullable restore
#line 76 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 81 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                 if (item.GhiChu == "null" || item.GhiChu is null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span></span>\r\n");
#nullable restore
#line 84 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                }
                else if (item.GhiChu.Contains("2"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Cổng số 2</span>\r\n");
#nullable restore
#line 88 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                }
                else if (item.GhiChu == "3")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Cổng số 3</span>\r\n");
#nullable restore
#line 92 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                }
                else if (item.GhiChu == "4")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Cổng số 4</span>\r\n");
#nullable restore
#line 96 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                }
                else if (item.GhiChu == "5")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Cổng số 5</span>\r\n");
#nullable restore
#line 100 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                }
                else if (item.GhiChu.ToLower() == "ck")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Hợp đồng công ty</span>\r\n");
#nullable restore
#line 104 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span></span>\r\n");
#nullable restore
#line 108 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </td>
            <td>
                <span title=""Điều chỉnh kết quả""
                      style=""font-size: 24px; color: blue""
                      onclick=""EditKetQua()"">
                    <i class=""fas fa-edit""></i>
                </span>


                <div class=""modal"" id=""myModalValidate"">
                    <div class=""modal-dialog modal-xl"">
                        <div class=""modal-content"">

                            <!-- Modal Header -->
                            <div class=""modal-header"">
                                <h4 class=""modal-title"">Thông tin bệnh nhân</h4>
                                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                            </div>

                            <!-- Modal body -->
                            <div class=""modal-body"">
                                <!--Thông tin hành chính-->
                                <div class=""row"">
                                 ");
            WriteLiteral("   <div class=\"col-xl-12 col-lg-12 col-md-12 col-sm-12\">\r\n                                        <p>Mã Y tế: ");
#nullable restore
#line 133 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                                               Write(item.MaYTe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>Họ tên: ");
#nullable restore
#line 134 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                                              Write(item.TenBenhNhan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>Năm sinh: ");
#nullable restore
#line 135 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                                                Write(item.NamSinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>Điện thoại: ");
#nullable restore
#line 136 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                                                  Write(item.SoDienThoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>\r\n                                            Kết quả hiện tại:\r\n");
#nullable restore
#line 139 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                                             if (item.KetQua == false)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"btn btn-primary\">\r\n                                                    Âm tính\r\n                                                </span>\r\n");
#nullable restore
#line 144 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"btn btn-danger\">\r\n                                                    Dương tính\r\n                                                </span>\r\n");
#nullable restore
#line 150 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </p>\r\n                                        <p>\r\n                                            Kết quả muốn điều chỉnh:\r\n");
#nullable restore
#line 154 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                                             if (item.KetQua == true)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"btn btn-primary\">\r\n                                                    Âm tính\r\n                                                </span>\r\n");
#nullable restore
#line 159 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"btn btn-danger\">\r\n                                                    Dương tính\r\n                                                </span>\r\n");
#nullable restore
#line 165 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </p>
                                        <div class=""form-group floating-control-group"">
                                            <input type=""password"" placeholder=""Nhập mã bảo mật"" class=""form-control"" style=""color: blue; font-weight: bold"" id=""txtValidate"" />
                                        </div>
                                    </div>
                                </div>
                                <!--End Thông tin hành chính-->
                            </div>

                            <!-- Modal footer -->
                            <div class=""modal-footer"">
");
            WriteLiteral(@"                                <button id=""btnCheckMaBaoMat"" type=""button"" class=""btn btn-danger"">Đồng ý</button>

                            </div>

                        </div>
                    </div>
                </div>
            </td>

");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 189 "G:\SourceCodeWebApp\XNTestNhanhCovid\InKetQua\InKetQua\Views\Home\_GetListDaLayMauCoKq.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            WriteLiteral(@"    <script>
        function UpdateLis(id, nhapLis) {
            $.ajax({
                type: ""GET"",
                url: ""/ketqua/UpdateLis"",
                //data: JSON.stringify(objArr),
                data: { 'id': id, 'nhapLis': nhapLis },
                //contentType: ""application/json; charset=utf-8"",
                dataType: ""text"",
                success: function (responses) {
                    if (responses === 1 || responses === ""1"") {
                        GetListChuaNhapLis();
                    } else {
                        swal.fire(""Thêm dữ liệu bị lỗi"");
                    }
                },
                failure: function (response) {
                    alert(""failure: GetListLayMauTestNhanh"" + response.responseText);
                },
                error: function (response) {
                    alert(""error: GetListLayMauTestNhanh"" + response.responseText);
                }
            });
        }

        function EditKetQua(id) {
 ");
            WriteLiteral("           $(\"#myModalValidate\").modal(\'show\');\r\n        };\r\n\r\n\r\n        $(document).ready(function () {\r\n            $(\'#tblDanhSachCoKetQua\').DataTable();\r\n\r\n            \r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LayMauTestNhanh>> Html { get; private set; }
    }
}
#pragma warning restore 1591
