#pragma checksum "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "081fad0e0127173ba87af774445fbe987545a737"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Edit), @"mvc.1.0.view", @"/Views/Job/Edit.cshtml")]
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
#line 2 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
using EasyJobHunter.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
using EasyJobHunter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"081fad0e0127173ba87af774445fbe987545a737", @"/Views/Job/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5b851981696bbb8a6796b6f9236145b2f8858b", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyJobHunter.ViewModel.vm_ManageJob>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
  
	ViewBag.Title = "Edit Job #" + Model.JOB.id;
	Layout = "~/Views/Shared/_Layout.cshtml";

	List<tbl_location> location = ViewBag.location;
	List<tbl_category_j> category = ViewBag.category;
	List<tbl_job_images> IMGs = ViewBag.IMGs;

	string referer = Context.Request.Headers["Referer"].ToString();
	Uri baseUri = new Uri(referer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n\t<h4 class=\"card-header bg-teal\">\r\n\t\t");
#nullable restore
#line 20 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</h4>\r\n\t<div class=\"card-body\">\r\n");
#nullable restore
#line 23 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
         using (Html.BeginForm(null, null, FormMethod.Post, new { enctype = "multipart/form-data" }))
		{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"form-horizontal\">\r\n\t\t\t\t<a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 828, "\"", 856, 1);
#nullable restore
#line 27 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
WriteAttributeValue("", 835, baseUri.AbsolutePath, 835, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"loading();\"><i class=\"fas fa-chevron-left mr-2\"></i>Back to List</a>\r\n\t\t\t\t<hr />\r\n\r\n\t\t\t\t<input hidden type=\"text\" id=\"edited_by\" name=\"edited_by\"");
            BeginWriteAttribute("value", " value=\"", 1012, "\"", 1080, 1);
#nullable restore
#line 30 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
WriteAttributeValue("", 1020, HttpContextAccessor.HttpContext.Session.GetString("USERID"), 1020, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t<input hidden type=\"text\" id=\"edited_date\" name=\"edited_date\"");
            BeginWriteAttribute("value", " value=\"", 1151, "\"", 1172, 1);
#nullable restore
#line 31 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
WriteAttributeValue("", 1159, DateTime.Now, 1159, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\t\t\t\t<div class=\"form-row\">\r\n\r\n\t\t\t\t\t<div class=\"form-group col-sm-2\">\r\n\t\t\t\t\t\t<label for=\"item_id\">Job ID</label>\r\n\t\t\t\t\t\t<input readonly class=\"form-control\" autocomplete=\"off\" type=\"text\" id=\"item_id\" name=\"item_id\"");
            BeginWriteAttribute("value", " value=\"", 1394, "\"", 1415, 1);
#nullable restore
#line 37 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
WriteAttributeValue("", 1402, Model.JOB.id, 1402, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t<div class=\"form-group col-sm-5\">\r\n\t\t\t\t\t\t<label for=\"item_name\">Job Name</label>\r\n\t\t\t\t\t\t<input class=\"form-control\" autocomplete=\"off\" type=\"text\" id=\"item_name\" name=\"item_name\"");
            BeginWriteAttribute("value", " value=\"", 1618, "\"", 1641, 1);
#nullable restore
#line 42 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
WriteAttributeValue("", 1626, Model.JOB.name, 1626, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t<div class=\"form-group col-sm-2\">\r\n\t\t\t\t\t\t<label for=\"item_salary\">Salary (RM)</label>\r\n\t\t\t\t\t\t<input class=\"form-control\" autocomplete=\"off\" type=\"text\" id=\"item_salary\" name=\"item_salary\"");
            BeginWriteAttribute("value", "  value=\"", 1854, "\"", 1880, 1);
#nullable restore
#line 47 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
WriteAttributeValue("", 1863, Model.JOB.salary, 1863, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t<div class=\"form-group col-sm-2\">\r\n\t\t\t\t\t\t<label for=\"stock_qty\">Location</label>\r\n\t\t\t\t\t\t<select class=\"form-control\" id=\"item_location_id\" name=\"item_location_id\">\r\n");
#nullable restore
#line 53 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
                             foreach (var i in location.OrderBy(x => x.name))
							{
								string selected = Model.JOB.location_id == i.id ? "selected" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<option");
            BeginWriteAttribute("value", " value=\"", 2229, "\"", 2242, 1);
#nullable restore
#line 56 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
WriteAttributeValue("", 2237, i.id, 2237, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 56 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
                                                 Write(selected);

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 56 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
                                                           Write(i.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 57 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"						</select>
					</div>

					<div class=""form-group col-sm-1"">
						<label for=""is_publish"">Publish</label>
						<div class=""custom-control custom-switch"">
							<input type=""checkbox"" class=""custom-control-input"" id=""is_publish"" name=""is_publish"" ");
#nullable restore
#line 64 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
                                                                                                              Write(Model.JOB.is_publish ? "checked" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(@">
							<label class=""custom-control-label"" for=""is_publish""></label>
						</div>
					</div>

				</div><!--form-row-->

				<div class=""form-row"">

					<div class=""form-group col-sm-12 col-md-12"">
						<label for=""cate_ids"">Category</label>
						<select multiple class=""form-control"" id=""cate_ids"" name=""cate_ids"">
");
#nullable restore
#line 76 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
                             foreach (var i in category.OrderBy(x => x.name))
							{
								string selected = Model.cate_ids.Contains(i.id) ? "selected" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<option");
            BeginWriteAttribute("value", " value=\"", 3077, "\"", 3090, 1);
#nullable restore
#line 79 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
WriteAttributeValue("", 3085, i.id, 3085, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 79 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
                                                 Write(selected);

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 79 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
                                                           Write(i.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 80 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"						</select>
						<button style=""margin-top:10px"" type=""button"" class=""btn btn-xs btn-success"" id=""selectallbtn""><i class=""fas fa-check""></i>&nbsp; Select All </button>
						<button style=""margin-top:10px"" type=""button"" class=""btn btn-xs btn-danger"" id=""deselectallbtn""><i class=""fas fa-times""></i>&nbsp; Cancel All </button>
					</div>

				</div><!--form-row-->

				<div class=""form-row"">
					<div class=""form-group col-sm-12"">
						<label for=""item_content"">Description</label>
						<textarea class=""form-control"" autocomplete=""off"" id=""item_content"" name=""item_content"">");
#nullable restore
#line 91 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
                                                                                                           Write(Model.JOB.content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n\r\n\t\t\t\t\t\t<div class=\"d-flex justify-content-start\">\r\n\r\n");
#nullable restore
#line 95 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
                             for (int i = 0; i < IMGs.Count; i++)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"uploadimg_container ORI\" data-keptimg=\"");
#nullable restore
#line 97 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
                                                                              Write(IMGs[i].id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 3952, "\"", 3976, 1);
#nullable restore
#line 98 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
WriteAttributeValue("", 3958, IMGs[i].file_path, 3958, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"uploadimg\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"uploadimg_overlay\"><i class=\"fas fa-trash\"></i></div>\r\n\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 101 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t<div class=\"uploadimg_container EMPTY\">\r\n\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 4162, "\"", 4204, 1);
#nullable restore
#line 104 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
WriteAttributeValue("", 4168, Url.Content("~" +"/img/camera.jpg"), 4168, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"uploadimg\">\r\n\t\t\t\t\t\t\t\t<div class=\"uploadimg_overlay\">");
#nullable restore
#line 105 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
                                                           Write(5- IMGs.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" / 5</div>
								<input type=""file"" hidden accept=""image/*"" />
							</div>

						</div>

					</div>
				</div><!--form-row-->

				<div class=""form-row"">
					<div class=""form-group col-sm-12"">
						<input type=""submit"" value=""Save"" class=""btn bg-teal"" />
					</div>
				</div><!--form-row-->

			</div>
");
#nullable restore
#line 121 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n</div>\r\n\r\n<script>\r\n\tvar currentUser = \'");
#nullable restore
#line 126 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
                  Write(HttpContextAccessor.HttpContext.Session.GetString("USERID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n\r\n\tvar clonedplaceholder = $(\'.uploadimg_container.EMPTY\').clone();\r\n\tvar placesleft = ");
#nullable restore
#line 129 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
                 Write(5- IMGs.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

	$(document).ready(function () {

	});//$(document).ready(function () {


	$('#cate_ids').select2({
		multiple: true,
		closeOnSelect: false,
	});

	$('#selectallbtn').on('click', function () {
		$(""#cate_ids > option"").prop(""selected"", ""selected"");
		$(""#cate_ids"").trigger(""change"");
	});

	$('#deselectallbtn').on('click', function () {
		$(""#cate_ids"").val(null).trigger(""change"");
	});

	$(document).on('click', '.uploadimg_container.EMPTY .uploadimg_overlay', function () {
		if (placesleft > 0) {
			$(this).next().trigger('click');
		}
	});

	$(document).on('click', '.uploadimg_container:not(.EMPTY) .uploadimg_overlay', function () {
		placesleft++;
		$('.uploadimg_container.EMPTY .uploadimg_overlay').text(placesleft + ' / 5');
		$(this).closest('.uploadimg_container').remove();
	});

	$(document).on('change', '.uploadimg_container.EMPTY input', function () {
		var ext = $(this).val().split('.').pop().toLowerCase();
		if ($.inArray(ext, ['gif', 'png', 'jpg', 'jpeg']) ==");
            WriteLiteral(@" -1) {
			Swal.fire('Only allow images in [gif, png, jpg, jpeg] format');
		}
		else {
			$(this).closest('.uploadimg_container.EMPTY').removeClass('EMPTY');
			//load preview
			var File = this.files;
			if (File && File[0]) {
				ReadImage(File[0], $(this).closest('.uploadimg_container').find('img'));
			}
			$(this).closest('.uploadimg_container').find('.uploadimg_overlay').html('<i class=""fas fa-trash""></i>');

			$(this).closest('.uploadimg_container').parent().append(clonedplaceholder.clone());
			placesleft--;
			$('.uploadimg_container.EMPTY .uploadimg_overlay').text(placesleft + ' / 5');
		}
	});

	var ReadImage = function (file, imgelement) {
		var reader = new FileReader;
		var image = new Image;
		reader.readAsDataURL(file);
		reader.onload = function (_file) {
			image.src = _file.target.result;
			image.onload = function () {
				$(imgelement).attr('src', _file.target.result);
			}
		}
	};

	$('input[type=""submit""]').click(function (e) {
		e.preventDefault();
		va");
            WriteLiteral(@"r edited_by = $(""#edited_by"").val(),
			edited_date = $(""#edited_date"").val(),
			item_id = $(""#item_id"").val(),
			item_name = $(""#item_name"").val(),
			item_salary = $(""#item_salary"").val(),
			item_location_id = $(""#item_location_id"").val(),
			cate_ids = $(""#cate_ids"").val(),
			item_content = $(""#item_content"").val(),
			is_publish = $(""#is_publish"").is("":checked"")
			;


		if (edited_by && edited_date && item_id && item_name && item_salary && item_location_id
		) {
			Swal.fire({
				text: ""Are You Sure?"",
				title: '");
#nullable restore
#line 212 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
                   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
				type: ""warning"",
				showCancelButton: true,
				allowOutsideClick: false,
			}).then((result) => {
				if (result.value) {
					loading();

					var model = new FormData();
					model.append('JOB.id', item_id);
					model.append('JOB.edited_by', edited_by);
					model.append('JOB.edited_date', edited_date);
					model.append('JOB.name', item_name);
					model.append('JOB.salary', item_salary);
					model.append('JOB.content', item_content);
					model.append('JOB.location_id', item_location_id);
					model.append('JOB.status', 'A');
					model.append('JOB.is_publish', is_publish);

					$(cate_ids).each(function () {
						model.append('cate_ids', this);
					});

					if ($('.uploadimg_container:not(.EMPTY):not(.ORI)').length) {
						$('.uploadimg_container:not(.EMPTY):not(.ORI)').each(function () {
							var input = $(this).find('input');
							var File = $(input).prop('files')[0];
							if (File) {
								model.append('FILES', File);
							}
						});
					}

");
            WriteLiteral("\t\t\t\t\tif ($(\'.uploadimg_container.ORI\').length) {\r\n\t\t\t\t\t\t$(\'.uploadimg_container.ORI\').each(function () {\r\n\t\t\t\t\t\t\tvar prodimg_id = $(this).data(\'keptimg\');\r\n\t\t\t\t\t\t\tmodel.append(\'ids_keptImg\', prodimg_id);\r\n\t\t\t\t\t\t});\r\n\t\t\t\t\t}\r\n\t\t\t\t\t$.ajax({\r\n\t\t\t\t\t\turl: \"");
#nullable restore
#line 252 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
                         Write(Url.Action("Edit"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
						type: ""POST"",
						data: model,//name must be same with the parameter received in controller action
						cache: false,
            contentType: false,
            processData: false,
						enctype: ""multipart/form-data"",
						dataType: ""text"",
						success: function (result) {
							console.log(123);
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
#line 271 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Edit.cshtml"
                                                                                  Write(baseUri.AbsolutePath);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'; }, 1000);
							}
						},
						error: function (err) {
              console.log(456);
							$(""#divLoading"").hide();
							console.log(err);
							swal.fire({ type: ""error"", title: ""Error""});
						}
					});

				} else if (result.dismiss === Swal.DismissReason.cancel) {
					//do nothing
				}
			});
		}
		else {
			swal.fire(""Do not leave blank"");
		}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyJobHunter.ViewModel.vm_ManageJob> Html { get; private set; }
    }
}
#pragma warning restore 1591