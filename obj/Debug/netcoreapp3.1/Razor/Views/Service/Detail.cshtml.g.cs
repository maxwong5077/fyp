#pragma checksum "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b335644ca48626034f696443529feb2e76b33fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Detail), @"mvc.1.0.view", @"/Views/Service/Detail.cshtml")]
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
#line 2 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
using EasyJobHunter.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
using EasyJobHunter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b335644ca48626034f696443529feb2e76b33fd", @"/Views/Service/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5b851981696bbb8a6796b6f9236145b2f8858b", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyJobHunter.ViewModel.vm_Service>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
  
	ViewBag.Title = "(Micro Job) " + Model.SERVICE.name;
	Layout = "~/Views/Shared/_Layout_Mall.cshtml";

	List<tbl_location> location = ViewBag.location;
	List<tbl_category_s> category = ViewBag.category;

	var rated = Model.APPLICATION.Where(x => x.review != null && x.review != "").ToList();
	double avg = rated.Count == 0 ? 0 : rated.Average(x => x.rating);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row justify-content-center"">

	<div class=""card"" style=""max-width:80rem;min-width:80rem"">
		<div class=""card-body"">
			<div class=""row"">
				<div class=""col-12 col-sm-4"">
					<div class=""col-12"" style=""position: relative; text-align: center; color: white;"">
						<img");
            BeginWriteAttribute("src", " src=\"", 868, "\"", 912, 1);
#nullable restore
#line 23 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
WriteAttributeValue("", 874, Model.imagesFilePath.FirstOrDefault(), 874, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-image border\" alt=\"Product Image\">\r\n");
#nullable restore
#line 24 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                         if (!Model.SERVICE.is_publish)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<div style=\"background-color:rgba(0,0,0,0.5);position: absolute; top: 50%; left: 50%; transform: translate(-50%, -50%);\"><h1>Unlisted</h1></div>\r\n");
#nullable restore
#line 27 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-12 product-image-thumbs card-deck justify-content-start\">\r\n");
#nullable restore
#line 30 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                         foreach (var i in Model.imagesFilePath)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 1336, "\"", 1430, 3);
            WriteAttributeValue("", 1344, "card", 1344, 4, true);
            WriteAttributeValue(" ", 1348, "product-image-thumb", 1349, 20, true);
#nullable restore
#line 32 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
WriteAttributeValue(" ", 1368, i == Model.imagesFilePath.FirstOrDefault() ? "active" : "", 1369, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 1446, "\"", 1454, 1);
#nullable restore
#line 33 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
WriteAttributeValue("", 1452, i, 1452, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1455, "\"", 1480, 1);
#nullable restore
#line 33 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
WriteAttributeValue("", 1461, Model.SERVICE.name, 1461, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 35 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\r\n\t\t\t\t<div class=\"col-12 col-sm-8\">\r\n\r\n\t\t\t\t\t<!--Product Name-->\r\n\t\t\t\t\t<h3 class=\"my-3\">");
#nullable restore
#line 42 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                                Write(Model.SERVICE.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\t\t\t\t\t<!--rating & sales info-->\r\n\t\t\t\t\t<div class=\"justify-content-center h5\">\r\n\t\t\t\t\t\t<span class=\"badge border p-2 mr-3\">");
#nullable restore
#line 46 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                                                        Write(Math.Round(avg, 1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fas fa-star\"></i> </span>\r\n\t\t\t\t\t\t<span class=\"badge border p-2 mr-3\">");
#nullable restore
#line 47 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                                                       Write(rated.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" rating(s)</span>\r\n\t\t\t\t\t\t<span class=\"badge border p-2 mr-3\">");
#nullable restore
#line 48 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                                                        Write(Model.APPLICATION.Where(x => x.status == "D").Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("(s) Sold</span>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<hr>\r\n\r\n\t\t\t\t\t<!--prices-->\r\n\t\t\t\t\t<div class=\"mt-4 ml-0 pl-0\">\r\n\t\t\t\t\t\t<h2 class=\"mb-0\">\r\n\t\t\t\t\t\t\tRM ");
#nullable restore
#line 55 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                          Write(Model.SERVICE.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</h2>\r\n\r\n\t\t\t\t\t</div>\r\n\r\n\r\n\t\t\t\t\t<!--Employer-->\r\n\t\t\t\t\t<div class=\"text-muted\">\r\n\t\t\t\t\t\t<span>Provider : </span>\r\n\t\t\t\t\t\t<a class=\"badge bg-success\"");
            BeginWriteAttribute("href", " href=\"", 2306, "\"", 2385, 1);
#nullable restore
#line 64 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
WriteAttributeValue("", 2313, Url.Action("Provider", "Service", new { id = Model.SERVICE.created_by}), 2313, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 65 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                       Write(Model.SERVICE.created_by);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
						</a>
					</div>

					<br />

					<button class=""btn btn-lg bg-teal btnApplyNow"">
						<i class=""fas fa-cart-plus fa-lg mr-2""></i>
						Apply Now
					</button>


				</div>
			</div>

			<div class=""row mt-4"">
				<nav class=""w-100"">
					<div class=""nav nav-tabs"" id=""product-tab"" role=""tablist"">
						<a class=""nav-item nav-link active"" id=""product-desc-tab"" data-toggle=""tab"" href=""#product-desc"" role=""tab"" aria-controls=""product-desc"" aria-selected=""true"">Description</a>
						<a class=""nav-item nav-link"" id=""product-rating-tab"" data-toggle=""tab"" href=""#product-rating"" role=""tab"" aria-controls=""product-rating"" aria-selected=""false"">Rating</a>
					</div>
				</nav>
				<div class=""tab-content p-3"" id=""nav-tabContent"" style=""display:block!important;width:100%!important"">
					<div class=""tab-pane fade show active"" id=""product-desc"" role=""tabpanel"" aria-labelledby=""product-desc-tab"">

						<label>Category</label>
						<h4>
");
#nullable restore
#line 92 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                             foreach (var i in category.Where(x => Model.cate_ids.Contains(x.id)).Select(x => x.name).ToList())
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span class=\"badge bg-teal mr-2\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 95 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 97 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</h4>\r\n\r\n\t\t\t\t\t\t<label>Location</label>\r\n\t\t\t\t\t\t<h4>\r\n\t\t\t\t\t\t\t<span class=\"badge bg-teal mr-2\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 103 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                           Write(location.Where(x => x.id == Model.SERVICE.location_id).FirstOrDefault().name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t</h4>\r\n\r\n\r\n\t\t\t\t\t\t<label>Description</label>\r\n\t\t\t\t\t\t<span class=\"neednewline\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 110 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                       Write(Model.SERVICE.content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</span>\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"tab-pane fade\" id=\"product-rating\" role=\"tabpanel\" aria-labelledby=\"product-rating-tab\">\r\n\r\n");
#nullable restore
#line 116 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                         foreach (var i in rated)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<div class=\"post\">\r\n\t\t\t\t\t\t\t\t<div class=\"user-block\">\r\n\t\t\t\t\t\t\t\t\t<span class=\"text-bold\">");
#nullable restore
#line 120 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                                                       Write(i.created_by);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t<span class=\"ml-3 text-warning\">\r\n");
#nullable restore
#line 122 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                                          

											int fullstar = i.rating;
											int emptystar = 5 - i.rating;
											for (int k = 0; k < fullstar; k++)
											{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"fas fa-star\"></i>\r\n");
#nullable restore
#line 129 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
											}
											for (int k = 0; k < emptystar; k++)
											{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-star\"></i>\r\n");
#nullable restore
#line 133 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
											}
										

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t\t<span class=\"font-weight-light text-muted ml-5 float-right\">");
#nullable restore
#line 136 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                                                                                            Write(Convert.ToDateTime(i.edited_date).ToString("yyyy-MM-dd HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<p class=\"neednewline\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 139 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                               Write(i.review);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 142 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                         if (rated.Count() == 0)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<span>No ratings and reviews found</span>\r\n");
#nullable restore
#line 146 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<!-- /.card-body -->\r\n\t</div>\r\n\r\n</div><!--row-->\r\n\r\n<input hidden type=\"text\" id=\"edited_by\" name=\"edited_by\"");
            BeginWriteAttribute("value", " value=\"", 5126, "\"", 5194, 1);
#nullable restore
#line 156 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
WriteAttributeValue("", 5134, HttpContextAccessor.HttpContext.Session.GetString("USERID"), 5134, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input hidden type=\"text\" id=\"edited_date\" name=\"edited_date\"");
            BeginWriteAttribute("value", " value=\"", 5261, "\"", 5282, 1);
#nullable restore
#line 157 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
WriteAttributeValue("", 5269, DateTime.Now, 5269, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\r\n<script>\r\n\r\n\tvar currentUser = \'");
#nullable restore
#line 162 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                  Write(HttpContextAccessor.HttpContext.Session.GetString("USERID"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

	var width = $('.product-image').width();
	$('.product-image').height(width);
	$('.product-image').css({
		'object-fit': 'contain',
	});


	$('.product-image-thumb').on('click', function () {
		var image_element = $(this).find('img')
		$('.product-image').prop('src', $(image_element).attr('src'))
		$('.product-image-thumb.active').removeClass('active')
		$(this).addClass('active');
		//make sure big preview image is always square
		var width = $('.product-image').width();
		$('.product-image').height(width);
		$('.product-image').css({
			'object-fit': 'contain',
		});
	});

	$('.btnApplyNow').on('click', function (e) {
		e.preventDefault();
		if (currentUser == '') {
			window.location = '");
#nullable restore
#line 187 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                          Write(Url.Action("Index","Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n\t\t}\r\n\t\telse {\r\n\r\n\t\t\tloading();\r\n\t\t\tvar url = \'");
#nullable restore
#line 192 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                  Write(Url.Action("Create","ServiceApplication",new { id = Model.SERVICE.id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n\t\t\t\t$.ajax({\r\n\t\t\t\t\turl: url,\r\n\t\t\t\t\ttype: \"POST\",\r\n\t\t\t\t\tdata:\r\n\t\t\t\t\t{\r\n\t\t\t\t\t\tid: \'");
#nullable restore
#line 198 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Service\Detail.cshtml"
                        Write(Model.SERVICE.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
						userid:currentUser,
					},
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
							//refresh
							setTimeout(function () { loading(); window.location.reload(true);  }, 1000);
						}
					},
					error: function (err) {
						$(""#divLoading"").hide();
						console.log(err);
						swal.fire({ type: ""error"", title: ""Error""});
					}
				});

		}//session is ok
	});


	$(document).ready(function () {

	});//$(document).ready(function () {

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyJobHunter.ViewModel.vm_Service> Html { get; private set; }
    }
}
#pragma warning restore 1591
