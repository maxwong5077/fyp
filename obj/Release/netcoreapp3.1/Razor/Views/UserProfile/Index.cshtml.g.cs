#pragma checksum "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c1d052b77370c2d338f269d3a1e9f1dd5d1c5dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserProfile_Index), @"mvc.1.0.view", @"/Views/UserProfile/Index.cshtml")]
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
#line 1 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\_ViewImports.cshtml"
using Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
using EasyJobHunter.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1d052b77370c2d338f269d3a1e9f1dd5d1c5dc", @"/Views/UserProfile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5b851981696bbb8a6796b6f9236145b2f8858b", @"/Views/_ViewImports.cshtml")]
    public class Views_UserProfile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EasyJobHunter.Models.tbl_user_profile>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
  
  ViewBag.Title = "Manage Users";
  Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a class=\"btn btn-default\" id=\"btnCreateNew\" onclick=\"loading();\"");
            BeginWriteAttribute("href", " href=\"", 354, "\"", 382, 1);
#nullable restore
#line 11 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
WriteAttributeValue("", 361, Url.Action("Create"), 361, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none\"><span class=\"text-dark\"><i class=\"fas fa-plus text-teal\"></i> Create New</span></a>\r\n\r\n<div class=\"card\" style=\"display:none\">\r\n  <h4 class=\"card-header bg-teal\">\r\n    ");
#nullable restore
#line 15 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  </h4>
  <div class=""card-body"">
    <table class=""table table-hover table-bordered"" id=""mydt"">
      <thead>
        <tr>
          <th>
            Userid
          </th>
          <th>
            Name
          </th>
          <th>
            Role
          </th>
          <th>
            Created Date
          </th>
          <th>
            Created By
          </th>
          <th>
            Last Modified Date
          </th>
          <th>
            Last Modified By
          </th>
          <th></th>
        </tr>
      </thead>

      <tbody>
");
#nullable restore
#line 47 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\r\n\t\t\t\t\t\t<td>\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1279, "\"", 1341, 1);
#nullable restore
#line 51 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
WriteAttributeValue("", 1286, Url.Action("Detail","Profile",new { id = item.userid}), 1286, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"View Profile\" data-toggle=\"tooltip\">");
#nullable restore
#line 51 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
                                                                                                                                    Write(item.userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t</td>\r\n            <td>\r\n              ");
#nullable restore
#line 54 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
         Write(item.real_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n              ");
#nullable restore
#line 57 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
         Write(item.role);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n              ");
#nullable restore
#line 60 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
          Write(item.created_date.HasValue ? Convert.ToDateTime(item.created_date).ToString("yyyy-MM-dd , HH:mm") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1727, "\"", 1793, 1);
#nullable restore
#line 63 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
WriteAttributeValue("", 1734, Url.Action("Detail","Profile",new { id = item.created_by}), 1734, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"View Profile\" data-toggle=\"tooltip\">");
#nullable restore
#line 63 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
                                                                                                                                        Write(item.created_by);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t</td>\r\n            <td>\r\n              ");
#nullable restore
#line 66 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
          Write(item.edited_date.HasValue ? Convert.ToDateTime(item.edited_date).ToString("yyyy-MM-dd , HH:mm") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2050, "\"", 2115, 1);
#nullable restore
#line 69 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
WriteAttributeValue("", 2057, Url.Action("Detail","Profile",new { id = item.edited_by}), 2057, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"View Profile\" data-toggle=\"tooltip\">");
#nullable restore
#line 69 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
                                                                                                                                       Write(item.edited_by);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t</td>\r\n            <td class=\"shrink\">\r\n              <a onclick=\"loading();\"");
            BeginWriteAttribute("href", " href=\"", 2264, "\"", 2316, 1);
#nullable restore
#line 72 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
WriteAttributeValue("", 2271, Url.Action("Edit", new { id = item.userid }), 2271, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Edit\" data-toggle=\"tooltip\" class=\"btn btn-warning\"><i class=\"fas fa-pen\"></i></a>\r\n              <a");
            BeginWriteAttribute("href", " href=\"", 2425, "\"", 2479, 1);
#nullable restore
#line 73 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
WriteAttributeValue("", 2432, Url.Action("Delete", new { id = item.userid }), 2432, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-showid=\"");
#nullable restore
#line 73 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
                                                                                Write(item.userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" title=\"Delete\" data-toggle=\"tooltip\" class=\"btn btn-danger btn-delete\"><i class=\"fas fa-trash\"></i></a>\r\n            </td>\r\n          </tr>\r\n");
#nullable restore
#line 76 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </tbody>\r\n    </table>\r\n  </div>\r\n</div>\r\n\r\n<br />\r\n\r\n<script>\r\n\tvar currentUser = \'");
#nullable restore
#line 85 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
                  Write(HttpContextAccessor.HttpContext.Session.GetString("USERID"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
	$(document).ready(function () {
		var mydt = $('#mydt').DataTable({
      ""order"": [],
      fixedHeader: true,
      buttons: [],
			dom: 'Bfrtip',
			responsive: true,
			""autoWidth"": false,
			""initComplete"": function (settings, json) {
				$('.card').css(""display"", ""block"");
				$(""#divLoading"").hide();
				var btn_add = $(""#btnCreateNew"");
				$(btn_add).show();
				$('#mydt').closest('.dataTables_wrapper').find("".dt-buttons.btn-group.flex-wrap"").append(btn_add);
			},
			columnDefs: [
				{ orderable: false, targets: -1 }
			],
		});

		mydt.columns('.hidden-col').visible(false);
		$("".dataTables_scrollHeadInner"").css({ ""width"": ""100%"" });
		$("".table "").css({ ""width"": ""100%"" });
		$($.fn.dataTable.tables(true)).css('width', '100%');
		$($.fn.dataTable.tables(true)).DataTable().columns.adjust().draw();

	});//$(document).ready(function () {



	$('.btn-delete').click(function (e) {
		e.preventDefault();
		Swal.fire({
			title: ""Are You Sure?"",
			text: 'Delete #' +");
            WriteLiteral(@" $(this).data('showid'),
			type: ""warning"",
			showCancelButton: true,
			allowOutsideClick: false,
		}).then((result) => {
			if (result.value) {
				loading();
				$.ajax({
					url: $(this).attr('href'),
					type: ""POST"",
					dataType: ""text"",
					success: function (result) {
						$(""#divLoading"").hide();
						if (result) {
							//got error msg from controller
							console.log(result);
							swal.fire({ type: ""error"", title: ""Error"", text: result });
						}
						else {
							//no error msg
							Swal.fire({ type: 'success', title: 'Done', showConfirmButton: false, timer: 1000 });
							setTimeout(function () { loading(); window.location = '");
#nullable restore
#line 141 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\UserProfile\Index.cshtml"
                                                                              Write(Url.Action("Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'; }, 1000);
						}
					},
					error: function (err) {
						$(""#divLoading"").hide();
						console.log(err);
						swal.fire({ type: ""error"", title: ""Error""});
					}
				});
			} else if (result.dismiss === Swal.DismissReason.cancel) {
				//do nothing
			}
		});
	});
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EasyJobHunter.Models.tbl_user_profile>> Html { get; private set; }
    }
}
#pragma warning restore 1591