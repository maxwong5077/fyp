#pragma checksum "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCarousel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc480374466918576a875f87a224c697cdb1c02a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobCarousel_Index), @"mvc.1.0.view", @"/Views/JobCarousel/Index.cshtml")]
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
#line 2 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCarousel\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc480374466918576a875f87a224c697cdb1c02a", @"/Views/JobCarousel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5b851981696bbb8a6796b6f9236145b2f8858b", @"/Views/_ViewImports.cshtml")]
    public class Views_JobCarousel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyJobHunter.ViewModel.vm_Carousel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCarousel\Index.cshtml"
  
	ViewBag.Title = "Job Carousel";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n\t<h4 class=\"card-header bg-teal\">\r\n\t\t");
#nullable restore
#line 11 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCarousel\Index.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</h4>\r\n\t<div class=\"card-body\">\r\n");
#nullable restore
#line 14 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCarousel\Index.cshtml"
         using (Html.BeginForm(null, null, FormMethod.Post, new { enctype = "multipart/form-data" }))
		{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"form-horizontal\">\r\n\r\n\r\n\t\t\t\t<div class=\"form-row\">\r\n\t\t\t\t\t<div class=\"form-group col-sm-12\">\r\n\t\t\t\t\t\t<label for=\"prod_desc\">Carousel Images</label>\r\n\t\t\t\t\t\t<a class=\"text-dark float-right\"");
            BeginWriteAttribute("href", " href=\"", 651, "\"", 685, 1);
#nullable restore
#line 23 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCarousel\Index.cshtml"
WriteAttributeValue("", 658, Url.Action("Index","Home"), 658, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"loading();\"><i class=\"fas fa-eye mr-2\"></i>Live view</a>\r\n\t\t\t\t\t\t<div class=\"d-flex justify-content-start\">\r\n\r\n");
#nullable restore
#line 26 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCarousel\Index.cshtml"
                             for (int i = 0; i < Model.cAROUSEL.Count; i++)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"uploadimg_container ORI\" data-keptimg=\"");
#nullable restore
#line 28 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCarousel\Index.cshtml"
                                                                              Write(Model.cAROUSEL[i].id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 969, "\"", 1003, 1);
#nullable restore
#line 29 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCarousel\Index.cshtml"
WriteAttributeValue("", 975, Model.cAROUSEL[i].file_path, 975, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"uploadimg\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"uploadimg_overlay\"><i class=\"fas fa-trash\"></i></div>\r\n\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 32 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCarousel\Index.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t<div class=\"uploadimg_container EMPTY\">\r\n\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 1189, "\"", 1231, 1);
#nullable restore
#line 35 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCarousel\Index.cshtml"
WriteAttributeValue("", 1195, Url.Content("~" +"/img/camera.jpg"), 1195, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"uploadimg\">\r\n\t\t\t\t\t\t\t\t<div class=\"uploadimg_overlay\">");
#nullable restore
#line 36 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCarousel\Index.cshtml"
                                                           Write(10- Model.cAROUSEL.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" / 10</div>
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
#line 53 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCarousel\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n</div>\r\n\r\n\r\n<script>\r\n\tvar currentUser = \'");
#nullable restore
#line 59 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCarousel\Index.cshtml"
                  Write(HttpContextAccessor.HttpContext.Session.GetString("USERID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n\r\n\tvar clonedplaceholder = $(\'.uploadimg_container.EMPTY\').clone();\r\n\tvar placesleft = ");
#nullable restore
#line 62 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCarousel\Index.cshtml"
                 Write(10- Model.cAROUSEL.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

	$(document).ready(function () {

	});//$(document).ready(function () {

	$(document).on('click', '.uploadimg_container.EMPTY .uploadimg_overlay', function () {
		if (placesleft > 0) {
			$(this).next().trigger('click');
		}
	});

	$(document).on('click', '.uploadimg_container:not(.EMPTY) .uploadimg_overlay', function () {
		placesleft++;
		$('.uploadimg_container.EMPTY .uploadimg_overlay').text(placesleft + ' / 10');
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
			$(this).cl");
            WriteLiteral(@"osest('.uploadimg_container').find('.uploadimg_overlay').html('<i class=""fas fa-trash""></i>');

			$(this).closest('.uploadimg_container').parent().append(clonedplaceholder.clone());
			placesleft--;
			$('.uploadimg_container.EMPTY .uploadimg_overlay').text(placesleft + ' / 10');
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

		Swal.fire({
				text: ""Are You Sure?"",
				title: '");
#nullable restore
#line 117 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCarousel\Index.cshtml"
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

					if ($('.uploadimg_container:not(.EMPTY):not(.ORI)').length) {
						$('.uploadimg_container:not(.EMPTY):not(.ORI)').each(function () {
							var input = $(this).find('input');
							var File = $(input).prop('files')[0];
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
#line 144 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\JobCarousel\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyJobHunter.ViewModel.vm_Carousel> Html { get; private set; }
    }
}
#pragma warning restore 1591
