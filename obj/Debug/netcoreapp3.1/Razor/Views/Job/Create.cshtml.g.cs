#pragma checksum "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3b49671234daedf747207d158610addb6ac5513"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Create), @"mvc.1.0.view", @"/Views/Job/Create.cshtml")]
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
#line 2 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
using EasyJobHunter.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
using EasyJobHunter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b49671234daedf747207d158610addb6ac5513", @"/Views/Job/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5b851981696bbb8a6796b6f9236145b2f8858b", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyJobHunter.ViewModel.vm_ManageJob>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
  
	ViewBag.Title = "Create Job";
	Layout = "~/Views/Shared/_Layout.cshtml";

	List<tbl_location> location = ViewBag.location;
	List<tbl_category_j> category = ViewBag.category;

	string referer = Context.Request.Headers["Referer"].ToString();
	Uri baseUri = new Uri(referer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n\t<h4 class=\"card-header bg-teal\">\r\n\t\t");
#nullable restore
#line 19 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</h4>\r\n\t<div class=\"card-body\">\r\n");
#nullable restore
#line 22 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
         using (Html.BeginForm(null, null, FormMethod.Post, new { enctype = "multipart/form-data" }))
		{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"form-horizontal\">\r\n\t\t\t\t<a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 769, "\"", 797, 1);
#nullable restore
#line 26 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
WriteAttributeValue("", 776, baseUri.AbsolutePath, 776, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"loading();\"><i class=\"fas fa-chevron-left mr-2\"></i>Back to List</a>\r\n\t\t\t\t<hr />\r\n\r\n\t\t\t\t<input hidden type=\"text\" id=\"edited_by\" name=\"edited_by\"");
            BeginWriteAttribute("value", " value=\"", 953, "\"", 1021, 1);
#nullable restore
#line 29 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
WriteAttributeValue("", 961, HttpContextAccessor.HttpContext.Session.GetString("USERID"), 961, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t<input hidden type=\"text\" id=\"edited_date\" name=\"edited_date\"");
            BeginWriteAttribute("value", " value=\"", 1092, "\"", 1113, 1);
#nullable restore
#line 30 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
WriteAttributeValue("", 1100, DateTime.Now, 1100, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

				<div class=""form-row"">

					<div class=""form-group col-sm-2"">
						<label for=""item_id"">Job ID</label>
						<input readonly class=""form-control"" autocomplete=""off"" type=""text"" id=""item_id"" name=""item_id"" />
					</div>

					<div class=""form-group col-sm-5"">
						<label for=""item_name"">Job Name</label>
						<input class=""form-control"" autocomplete=""off"" type=""text"" id=""item_name"" name=""item_name"" />
					</div>

					<div class=""form-group col-sm-2"">
						<label for=""item_salary"">Salary (RM)</label>
						<input class=""form-control"" autocomplete=""off"" type=""text"" id=""item_salary"" name=""item_salary"" value=""0""/>
					</div>

					<div class=""form-group col-sm-2"">
						<label for=""stock_qty"">Location</label>
						<select class=""form-control"" id=""item_location_id"" name=""item_location_id"">
");
#nullable restore
#line 52 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
                             foreach (var i in location.OrderBy(x => x.name))
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<option");
            BeginWriteAttribute("value", " value=\"", 2032, "\"", 2045, 1);
#nullable restore
#line 54 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
WriteAttributeValue("", 2040, i.id, 2040, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 54 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
                                                 Write(i.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 55 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"						</select>
					</div>

					<div class=""form-group col-sm-1"">
						<label for=""is_publish"">Publish</label>
						<div class=""custom-control custom-switch"">
							<input type=""checkbox"" class=""custom-control-input"" id=""is_publish"" name=""is_publish"" checked>
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
#line 74 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
                             foreach (var i in category.OrderBy(x => x.name))
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<option");
            BeginWriteAttribute("value", " value=\"", 2761, "\"", 2774, 1);
#nullable restore
#line 76 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
WriteAttributeValue("", 2769, i.id, 2769, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 76 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
                                                 Write(i.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 77 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
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
						<textarea class=""form-control"" autocomplete=""off"" id=""item_content"" name=""item_content""></textarea>

						<div class=""d-flex justify-content-start"">

							<div class=""uploadimg_container EMPTY"">
								<img");
            BeginWriteAttribute("src", " src=\"", 3525, "\"", 3567, 1);
#nullable restore
#line 93 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
WriteAttributeValue("", 3531, Url.Content("~" +"/img/camera.jpg"), 3531, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""uploadimg"">
								<div class=""uploadimg_overlay"">5 / 5</div>
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
#line 110 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n</div>\r\n\r\n<script>\r\n\tvar currentUser = \'");
#nullable restore
#line 115 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
                  Write(HttpContextAccessor.HttpContext.Session.GetString("USERID"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

	var clonedplaceholder = $('.uploadimg_container.EMPTY').clone();
	var placesleft = 5;

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
		var ext = $(this).v");
            WriteLiteral(@"al().split('.').pop().toLowerCase();
		if ($.inArray(ext, ['gif', 'png', 'jpg', 'jpeg']) == -1) {
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
		");
            WriteLiteral(@"	}
		}
	};

	$('input[type=""submit""]').click(function (e) {
		e.preventDefault();
		var
			edited_by = $(""#edited_by"").val(),
			edited_date = $(""#edited_date"").val(),
			item_id = $(""#item_id"").val(),
			item_name = $(""#item_name"").val(),
			item_salary = $(""#item_salary"").val(),
			item_location_id = $(""#item_location_id"").val(),
			cate_ids = $(""#cate_ids"").val(),
			item_content = $(""#item_content"").val(),
			is_publish = $(""#is_publish"").is("":checked"")
			;


		if (edited_by && edited_date && item_name && item_salary && item_location_id
		) {
			Swal.fire({
				text: ""Are You Sure?"",
				title: '");
#nullable restore
#line 202 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
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
					model.append('JOB.created_by', edited_by);
					model.append('JOB.created_date', edited_date);
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
							var File = $(input).prop('");
            WriteLiteral(@"files')[0];
							if (File) {
								model.append('FILES', File);
							}
						});
					}

					if ($('.uploadimg_container.ORI').length) {
						$('.uploadimg_container.ORI').each(function () {
							var prodimg_id = $(this).data('keptimg');
							model.append('ids_keptImg', prodimg_id);
						});
					}

					$.ajax({
						url: """);
#nullable restore
#line 245 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
                         Write(Url.Action("Create"));

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
#line 263 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Create.cshtml"
                                                                                  Write(baseUri.AbsolutePath);

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
