#pragma checksum "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d805f442ac6d3ac1e28cd8ec2cc484521bfdabc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d805f442ac6d3ac1e28cd8ec2cc484521bfdabc", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5b851981696bbb8a6796b6f9236145b2f8858b", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyJobHunter.Models.tbl_user_profile>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Profile\Index.cshtml"
  
	ViewBag.Title = "My Profile (" + Model.real_name + ")";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n\t<h4 class=\"card-header bg-teal\">\r\n\t\t");
#nullable restore
#line 9 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Profile\Index.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</h4>\r\n\t<div class=\"card-body\">\r\n");
#nullable restore
#line 12 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Profile\Index.cshtml"
         using (Html.BeginForm())
		{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"form-horizontal\">\r\n\r\n\t\t\t<input hidden type=\"text\" id=\"edited_by\" name=\"edited_by\"");
            BeginWriteAttribute("value", " value=\"", 395, "\"", 416, 1);
#nullable restore
#line 17 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Profile\Index.cshtml"
WriteAttributeValue("", 403, Model.userid, 403, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t<input hidden type=\"text\" id=\"edited_date\" name=\"edited_date\"");
            BeginWriteAttribute("value", " value=\"", 486, "\"", 507, 1);
#nullable restore
#line 18 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Profile\Index.cshtml"
WriteAttributeValue("", 494, DateTime.Now, 494, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\r\n\t\t\t<div class=\"form-row\">\r\n\r\n\t\t\t\t<div class=\"form-group col-sm-3\">\r\n\t\t\t\t\t<label for=\"userid\">Userid</label>\r\n\t\t\t\t\t<input readonly class=\"form-control\" autocomplete=\"off\" type=\"text\" id=\"userid\" name=\"userid\"");
            BeginWriteAttribute("value", " value=\"", 725, "\"", 746, 1);
#nullable restore
#line 24 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Profile\Index.cshtml"
WriteAttributeValue("", 733, Model.userid, 733, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t</div>\r\n\r\n\t\t\t\t<div class=\"form-group col-sm-3\">\r\n\t\t\t\t\t<label for=\"password\">Password</label>\r\n\t\t\t\t\t<div class=\"input-group\">\r\n\t\t\t\t\t\t<input class=\"form-control\" autocomplete=\"off\" type=\"password\" id=\"password\" name=\"password\"");
            BeginWriteAttribute("value", " value=\"", 980, "\"", 1003, 1);
#nullable restore
#line 30 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Profile\Index.cshtml"
WriteAttributeValue("", 988, Model.password, 988, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
						<span class=""input-group-btn"">
							<button type=""button"" class=""btn btn-default"" id=""showPW""><i class=""far fa-eye-slash""></i></button>
						</span>
					</div>
				</div>

				<div class=""form-group col-sm-3"">
					<label for=""email"">Email</label>
					<input class=""form-control"" autocomplete=""off"" type=""text"" id=""email"" name=""email""");
            BeginWriteAttribute("value", " value=\"", 1362, "\"", 1382, 1);
#nullable restore
#line 39 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Profile\Index.cshtml"
WriteAttributeValue("", 1370, Model.email, 1370, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t</div>\r\n\r\n\t\t\t\t<div class=\"form-group col-sm-3\">\r\n\t\t\t\t\t<label for=\"real_name\">Name</label>\r\n\t\t\t\t\t<input class=\"form-control\" autocomplete=\"off\" type=\"text\" id=\"real_name\" name=\"real_name\"");
            BeginWriteAttribute("value", " value=\"", 1578, "\"", 1602, 1);
#nullable restore
#line 44 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Profile\Index.cshtml"
WriteAttributeValue("", 1586, Model.real_name, 1586, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t</div>\r\n\r\n\t\t\t\t<div class=\"form-group col-sm-3\">\r\n\t\t\t\t\t<label for=\"contactno\">Contact No.</label>\r\n\t\t\t\t\t<input class=\"form-control\" autocomplete=\"off\" type=\"text\" id=\"contactno\" name=\"contactno\"");
            BeginWriteAttribute("value", " value=\"", 1805, "\"", 1829, 1);
#nullable restore
#line 49 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Profile\Index.cshtml"
WriteAttributeValue("", 1813, Model.contactno, 1813, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t</div>\r\n\r\n\t\t\t\t<div class=\"form-group col-sm-9\">\r\n\t\t\t\t\t<label for=\"address\">Address</label>\r\n\t\t\t\t\t<input class=\"form-control\" autocomplete=\"off\" type=\"text\" id=\"address\" name=\"address\"");
            BeginWriteAttribute("value", " value=\"", 2022, "\"", 2044, 1);
#nullable restore
#line 54 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Profile\Index.cshtml"
WriteAttributeValue("", 2030, Model.address, 2030, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\t\t\t\t</div>\r\n\r\n\t\t\t</div><!--form-row-->\r\n\r\n\t\t\t<div class=\"form-row\">\r\n\t\t\t\t<div class=\"form-group col-sm-12\">\r\n\t\t\t\t\t<input type=\"submit\" value=\"Save\" class=\"btn bg-teal\" />\r\n\t\t\t\t</div>\r\n\t\t\t</div><!--form-row-->\r\n\r\n\t\t</div>\r\n");
#nullable restore
#line 66 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Profile\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n</div>\r\n\r\n\r\n<script>\r\n\tvar currentUser = \'");
#nullable restore
#line 72 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Profile\Index.cshtml"
                  Write(Model.userid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

	$(""#userid"").keyup(function () {
		//allow letter, numbers and underscore only
		//convert to uppercase as well
		//limit length = 50
		var val = $(this).val().toUpperCase().replace(/[^a-zA-Z0-9_]/g, '');
		val = val.substring(0, 50);
		$(this).val(val);
	});

	$(""#showPW"").on('click', function () {
		var vis = $('#password').data(""vis"");
		if (vis == null) vis = false;
		if (vis) {
			$('#password').clone().attr('type', 'password').insertAfter('#password').prev().remove();
			$('#password').data(""vis"", false);
			$(this).html('<i class=""far fa-eye-slash""></i>');
		}
		else {
			$('#password').clone().attr('type', 'text').insertAfter('#password').prev().remove();
			$('#password').data(""vis"", true);
			$(this).html('<i class=""far fa-eye""></i>');
		}
		//How does .attr() work on the cloned element but not on the element itself?
		//Because the cloned element is not injected to the DOM yet, while the element itself is already in the DOM.
	});

	$(document).ready(function () {
");
            WriteLiteral(@"


	});//$(document).ready(function () {

	$('input[type=""submit""]').click(function (e) {
		e.preventDefault();

		var edited_by = $(""#edited_by"").val(),
			edited_date = $(""#edited_date"").val(),
			userid = $(""#userid"").val(),
			password = $(""#password"").val(),
			real_name = $(""#real_name"").val(),
			contactno = $(""#contactno"").val(),
			email = $(""#email"").val(),
			address = $(""#address"").val()
			;
		if (edited_by && edited_date && userid && password && contactno && address && email) {
			Swal.fire({
				text: ""Are You Sure?"",
				title: 'Save Changes',
				type: ""warning"",
				showCancelButton: true,
				allowOutsideClick: false,
			}).then((result) => {
				if (result.value) {
					loading();
					$.ajax({
						url: """);
#nullable restore
#line 129 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Profile\Index.cshtml"
                         Write(Url.Action("Edit"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
						type: ""POST"",
						dataType: ""text"",
						data: {
							id: edited_by,//userid
							edited_by: edited_by,
							edited_date: edited_date,
							userid: userid,
							password: password,
							real_name: real_name,
							contactno: contactno,
							email: email,
							address: address,
						},
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
				} else if (result.dismiss === Swal.DismissReason.cancel");
            WriteLiteral(") {\r\n\t\t\t\t\t//do nothing\r\n\t\t\t\t}\r\n\t\t\t});\r\n\t\t}\r\n\t\telse {\r\n\t\t\tswal.fire(\"Do not leave blank\");\r\n\t\t}\r\n\r\n\t});\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyJobHunter.Models.tbl_user_profile> Html { get; private set; }
    }
}
#pragma warning restore 1591
