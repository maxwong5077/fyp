#pragma checksum "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92a5c1d22ff73a3df2cd885e351bf7dfdcf6d454"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobCategory_Edit), @"mvc.1.0.view", @"/Views/JobCategory/Edit.cshtml")]
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
#line 2 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92a5c1d22ff73a3df2cd885e351bf7dfdcf6d454", @"/Views/JobCategory/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5b851981696bbb8a6796b6f9236145b2f8858b", @"/Views/_ViewImports.cshtml")]
    public class Views_JobCategory_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyJobHunter.ViewModel.vm_Category_J>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
  
	ViewBag.Title = "Edit Job Category (#" + Model.CATEGORY.id + ")";
	Layout = "~/Views/Shared/_Layout.cshtml";
	bool HasImage = string.IsNullOrEmpty(Model.CATEGORY.file_path) ? false : true;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n  <h4 class=\"card-header bg-teal\">\r\n    ");
#nullable restore
#line 12 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </h4>\r\n  <div class=\"card-body\">\r\n");
#nullable restore
#line 15 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
     using (Html.BeginForm())
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("      <div class=\"form-horizontal\">\r\n        <a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 575, "\"", 602, 1);
#nullable restore
#line 19 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
WriteAttributeValue("", 582, Url.Action("Index"), 582, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"loading();\"><i class=\"fas fa-chevron-left mr-2\"></i>Back to List</a>\r\n        <hr />\r\n\r\n        <input hidden type=\"text\" id=\"edited_by\" name=\"edited_by\"");
            BeginWriteAttribute("value", " value=\"", 766, "\"", 834, 1);
#nullable restore
#line 22 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
WriteAttributeValue("", 774, HttpContextAccessor.HttpContext.Session.GetString("USERID"), 774, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input hidden type=\"text\" id=\"edited_date\" name=\"edited_date\"");
            BeginWriteAttribute("value", " value=\"", 909, "\"", 930, 1);
#nullable restore
#line 23 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
WriteAttributeValue("", 917, DateTime.Now, 917, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\t\t\t\t<div class=\"form-row\">\r\n\r\n\t\t\t\t\t<div class=\"form-group col-sm-6\">\r\n\t\t\t\t\t\t<label for=\"cateid\">Category ID</label>\r\n\t\t\t\t\t\t<input readonly class=\"form-control\" autocomplete=\"off\" type=\"text\" id=\"cateid\" name=\"cateid\"");
            BeginWriteAttribute("value", " value=\"", 1154, "\"", 1180, 1);
#nullable restore
#line 29 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
WriteAttributeValue("", 1162, Model.CATEGORY.id, 1162, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t<div class=\"form-group col-sm-6\">\r\n\t\t\t\t\t\t<label for=\"catename\">Category Name</label>\r\n\t\t\t\t\t\t<input class=\"form-control\" autocomplete=\"off\" type=\"text\" id=\"catename\" name=\"catename\"");
            BeginWriteAttribute("value", " value=\"", 1386, "\"", 1414, 1);
#nullable restore
#line 34 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
WriteAttributeValue("", 1394, Model.CATEGORY.name, 1394, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t<div class=\"form-group col-sm-6\">\r\n\t\t\t\t\t\t<div class=\"d-flex justify-content-start\">\r\n");
#nullable restore
#line 39 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
                             if (HasImage)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"uploadimg_container ORI\" data-keptimg=\"");
#nullable restore
#line 41 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
                                                                              Write(Model.CATEGORY.file_path);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 1659, "\"", 1690, 1);
#nullable restore
#line 42 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
WriteAttributeValue("", 1665, Model.CATEGORY.file_path, 1665, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"uploadimg\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"uploadimg_overlay\"><i class=\"fas fa-trash\"></i></div>\r\n\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 45 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<div class=\"uploadimg_container EMPTY\">\r\n\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 1874, "\"", 1916, 1);
#nullable restore
#line 47 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
WriteAttributeValue("", 1880, Url.Content("~" +"/img/camera.jpg"), 1880, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"uploadimg\">\r\n\t\t\t\t\t\t\t\t<div class=\"uploadimg_overlay\">");
#nullable restore
#line 48 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
                                                           Write(1- (HasImage ? 1 : 0));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" / 1</div>
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
#line 63 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n</div>\r\n\r\n\r\n<script>\r\n\tvar currentUser = \'");
#nullable restore
#line 69 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
                  Write(HttpContextAccessor.HttpContext.Session.GetString("USERID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n\r\n\tvar clonedplaceholder = $(\'.uploadimg_container.EMPTY\').clone();\r\n\tvar placesleft = ");
#nullable restore
#line 72 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
                 Write(1- (HasImage ? 1 : 0));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

	$(document).on('click', '.uploadimg_container.EMPTY .uploadimg_overlay', function () {
		if (placesleft > 0) {
			$(this).next().trigger('click');
		}
	});

	$(document).on('click', '.uploadimg_container:not(.EMPTY) .uploadimg_overlay', function () {
		placesleft++;
		$('.uploadimg_container.EMPTY .uploadimg_overlay').text(placesleft + ' / 1');
		$(this).closest('.uploadimg_container').remove();
	});

	$(document).on('change', '.uploadimg_container.EMPTY input', function () {
		var ext = $(this).val().split('.').pop().toLowerCase();
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
			$(this).closest('.uploadimg_container').find('.uploadimg_overlay').html('<i class=""fas f");
            WriteLiteral(@"a-trash""></i>');
			$(this).closest('.uploadimg_container').parent().append(clonedplaceholder.clone());
			placesleft--;
			$('.uploadimg_container.EMPTY .uploadimg_overlay').text(placesleft + ' / 1');
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

		var edited_by = $(""#edited_by"").val(),
			edited_date = $(""#edited_date"").val(),
			cateid = $(""#cateid"").val(),
			catename = $(""#catename"").val()
			;

		var model = new FormData();
		model.append('CATEGORY.id', cateid);
		model.append('CATEGORY.name', catename);
		if ($('.uploadimg_container:not(.EMPTY):not(.ORI)').length) {
			$('.uploadimg_container:not(.EMPTY):not(.ORI)').each(function () {
		");
            WriteLiteral(@"		var input = $(this).find('input');
				var File = $(input).prop('files')[0];
				if (File) {
					model.append('FILE', File);
				}
			});
		}
		
		var keptimg = $('.uploadimg_container.ORI').data('keptimg');
		if (keptimg != null) {
			model.append('CATEGORY.file_path', keptimg);
		}
		else {
			model.append('CATEGORY.file_path', '');
		}
		

		if (edited_by && edited_date && cateid && catename) {
			Swal.fire({
				text: ""Are You Sure?"",
				title: '");
#nullable restore
#line 151 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
                   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n\t\t\t\ttype: \"warning\",\r\n\t\t\t\tshowCancelButton: true,\r\n\t\t\t\tallowOutsideClick: false,\r\n\t\t\t}).then((result) => {\r\n\t\t\t\tif (result.value) {\r\n\t\t\t\t\tloading();\r\n\t\t\t\t\t$.ajax({\r\n\t\t\t\t\t\turl: \"");
#nullable restore
#line 159 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
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
#line 177 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCategory\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyJobHunter.ViewModel.vm_Category_J> Html { get; private set; }
    }
}
#pragma warning restore 1591
