#pragma checksum "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0626c70d1d20e4531e390aa34c2c00e5194c3ebc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0626c70d1d20e4531e390aa34c2c00e5194c3ebc", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5b851981696bbb8a6796b6f9236145b2f8858b", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyJobHunter.ViewModel.vm_Login_Index>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Login\Index.cshtml"
  
	ViewBag.Title = "Welcome";
	Layout = "~/Views/Shared/_Layout_Login.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Login\Index.cshtml"
 using (Html.BeginForm("", "", null, FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <div class=""input-group mb-3"">
    <input class=""form-control"" autocomplete=""off"" type=""text"" id=""USERID"" name=""USERID"" placeholder = ""User ID...""/>
    <div class=""input-group-append"">
      <div class=""input-group-text"">
        <span class=""fas fa-user""></span>
      </div>
    </div>
  </div>
");
            WriteLiteral(@"	<div class=""input-group mb-3"">
    <input class=""form-control"" autocomplete=""off"" type=""password"" id=""PASSWD"" name=""PASSWD"" placeholder=""Password..."" />
		<div class=""input-group-append"">
			<div class=""input-group-text"">
				<span class=""fas fa-lock""></span>
			</div>
		</div>
	</div>
");
            WriteLiteral("\t<div class=\"input-group mb-3\">\r\n\t\t<button type=\"submit\" class=\"btn bg-teal btn-block\" id=\"confirmBTN\">Log In</button>\r\n\t\t<p class=\"text-red\" id=\"\r\n\t\t\t \r\n\t\t\t \"></p>\r\n\t</div>\r\n");
            WriteLiteral("\t<div class=\"input-group mb-3\">\r\n\t\t<a class=\"btn btn-default btn-block\"");
            BeginWriteAttribute("href", " href=\"", 1048, "\"", 1078, 1);
#nullable restore
#line 34 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Login\Index.cshtml"
WriteAttributeValue("", 1055, Url.Action("Register"), 1055, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Register new account</a>\r\n\t</div>\r\n");
#nullable restore
#line 36 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Login\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
	$(document).ready(function () {
		$(""#divLoading"").hide();

		$('#PASSWD, #USERID').keyup(function () {
			$('#ErrorMessage').text(null);
		});

		$(""#USERID"").focus();

		$(""#USERID"").keyup(function () {
			//allow letter, numbers and underscore only
			//convert to uppercase as well
			//limit length = 50
			var val = $(this).val().toUpperCase().replace(/[^a-zA-Z0-9_]/g, '');
			val = val.substring(0, 50);
			$(this).val(val);
		});

		$(""#confirmBTN"").on('click', function (e) {
			e.preventDefault();
      var
        USERID = $(""#USERID"").val(),
        PASSWD = $(""#PASSWD"").val()
				;
			if (USERID && PASSWD) {
				loading();
				$(""#confirmBTN"").html('<span class=""spinner-grow spinner-grow-sm"" role=""status"" aria-hidden=""true""></span>Loading...');
				var form = $('form')[0];
				var data = new FormData(form);
				$.ajax({
					type: ""Post"",
					url: '");
#nullable restore
#line 70 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Login\Index.cshtml"
                     Write(Url.Action("Authenticate", "Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
					data: data,
					contentType: false,
					processData: false,
					success: function (response) {						
						$(""#confirmBTN"").html('Sign In');
						if (!stringIsEmptyOrWhitespace(response.errorMessage)) {
							$(""#divLoading"").hide();
							$('#ErrorMessage').text(response.errorMessage);
						}
						else {
							$('#ErrorMessage').text(null)
							var url = '");
#nullable restore
#line 82 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Login\Index.cshtml"
                                  Write(Url.Action("Index", "_Controller_"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'.replace('_Controller_', response.goto);
							window.location.href = url;
						}
					},
					error: function (xhr, ajaxOptions, thrownError) {
						$(""#divLoading"").hide();
						Swal.fire({
							type: 'error',
							title: 'Error',
							text: xhr.status + ' - ' + thrownError,
							showConfirmButton: false,
							timer: 2000
						});
					},
				});//end_$.ajax(....
			}
			else {
        $('#ErrorMessage').text(""Do not leave blank"");
			}



		})//end_$(""#confirmBTN"").on('click'....
	});//end_$(document).ready....
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyJobHunter.ViewModel.vm_Login_Index> Html { get; private set; }
    }
}
#pragma warning restore 1591
