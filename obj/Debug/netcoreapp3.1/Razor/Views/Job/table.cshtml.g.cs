#pragma checksum "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "821dbcf317598380f156e0977d62461bca01cc19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_table), @"mvc.1.0.view", @"/Views/Job/table.cshtml")]
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
#line 2 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\_ViewImports.cshtml"
using EasyJobHunter.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"821dbcf317598380f156e0977d62461bca01cc19", @"/Views/Job/table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5b851981696bbb8a6796b6f9236145b2f8858b", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EasyJobHunter.ViewModel.vm_Job>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
  
	//ViewBag.Title = "table"; //defined in controller already, this is a shared view
	Layout = "~/Views/Shared/_Layout.cshtml";

	List<tbl_location> location = ViewBag.location;
	List<tbl_category_j> category = ViewBag.category;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a class=\"btn btn-default\" id=\"btnCreateNew\" onclick=\"loading();\"");
            BeginWriteAttribute("href", " href=\"", 468, "\"", 496, 1);
#nullable restore
#line 12 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
WriteAttributeValue("", 475, Url.Action("Create"), 475, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none\"><span class=\"text-dark\"><i class=\"fas fa-plus text-teal\"></i> Create New</span></a>\r\n\r\n<div class=\"card\" style=\"display:none\">\r\n\t<h4 class=\"card-header bg-teal\">\r\n\t\t");
#nullable restore
#line 16 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
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
						Job ID
					</th>
					<th>
						Title
					</th>
					<th>
						Salary
					</th>
					<th>
						Location
					</th>
					<th>
						Category
					</th>
					<th>
						Publish
					</th>
					<th>
						Created
					</th>
					<th>
						Last Modified
					</th>
					<th></th>
				</tr>
			</thead>

			<tbody>
");
#nullable restore
#line 51 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
                 foreach (var item in Model)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 55 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
                       Write(Html.DisplayFor(modelItem => item.JOB.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 58 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
                       Write(Html.DisplayFor(modelItem => item.JOB.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 61 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
                       Write(Html.DisplayFor(modelItem => item.JOB.salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 64 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
                       Write(location.Where(x => x.id == item.JOB.location_id).FirstOrDefault().name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n");
#nullable restore
#line 67 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
                             foreach (var i in category.Where(x => item.cate_ids.Any(a => a == x.id)).OrderBy(x => x.name).ToList())
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span class=\"badge bg-teal mr-2\">");
#nullable restore
#line 69 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
                                                            Write(i.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 70 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 73 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
                        Write(!item.JOB.is_publish ?"No":"Yes");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 76 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
                        Write(item.JOB.created_date.HasValue ? Convert.ToDateTime(item.JOB.created_date).ToString("yyyy-MM-dd , HH:mm") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t<br />\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2014, "\"", 2084, 1);
#nullable restore
#line 78 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
WriteAttributeValue("", 2021, Url.Action("Detail","Profile",new { id = item.JOB.created_by}), 2021, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"View Profile\" data-toggle=\"tooltip\">");
#nullable restore
#line 78 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
                                                                                                                                            Write(item.JOB.created_by);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 81 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
                        Write(item.JOB.edited_date.HasValue ? Convert.ToDateTime(item.JOB.edited_date).ToString("yyyy-MM-dd , HH:mm") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t<br />\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2324, "\"", 2393, 1);
#nullable restore
#line 83 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
WriteAttributeValue("", 2331, Url.Action("Detail","Profile",new { id = item.JOB.edited_by}), 2331, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"View Profile\" data-toggle=\"tooltip\">");
#nullable restore
#line 83 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
                                                                                                                                           Write(item.JOB.edited_by);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td class=\"shrink\">\r\n\t\t\t\t\t\t\t<a onclick=\"loading();\"");
            BeginWriteAttribute("href", " href=\"", 2533, "\"", 2585, 1);
#nullable restore
#line 86 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
WriteAttributeValue("", 2540, Url.Action("Edit", new { id = item.JOB.id }), 2540, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Edit\" data-toggle=\"tooltip\" class=\"btn btn-warning\"><i class=\"fas fa-pen\"></i></a>\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2687, "\"", 2741, 1);
#nullable restore
#line 87 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
WriteAttributeValue("", 2694, Url.Action("Delete", new { id = item.JOB.id }), 2694, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-showid=\"");
#nullable restore
#line 87 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
                                                                                              Write(item.JOB.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" title=\"Delete\" data-toggle=\"tooltip\" class=\"btn btn-danger btn-delete\"><i class=\"fas fa-trash\"></i></a>\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2884, "\"", 2938, 1);
#nullable restore
#line 88 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
WriteAttributeValue("", 2891, Url.Action("Detail", new { id = item.JOB.id }), 2891, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"View\" data-toggle=\"tooltip\" class=\"btn btn-info\"><i class=\"fas fa-eye\"></i></a>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 91 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</tbody>\r\n\t\t</table>\r\n\t</div>\r\n</div>\r\n\r\n<br />\r\n\r\n<script>\r\n\tvar currentUser = \'");
#nullable restore
#line 100 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\table.cshtml"
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
			text: 'Delete #' + $(this).");
            WriteLiteral(@"data('showid'),
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
							setTimeout(function () { loading(); location.reload(true); }, 1000);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EasyJobHunter.ViewModel.vm_Job>> Html { get; private set; }
    }
}
#pragma warning restore 1591