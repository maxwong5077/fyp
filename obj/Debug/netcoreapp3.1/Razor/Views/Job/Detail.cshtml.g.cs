#pragma checksum "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98a4c8f8c9ad68e132744c9a850446745bdb1a76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Detail), @"mvc.1.0.view", @"/Views/Job/Detail.cshtml")]
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
#line 2 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
using EasyJobHunter.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
using EasyJobHunter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98a4c8f8c9ad68e132744c9a850446745bdb1a76", @"/Views/Job/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5b851981696bbb8a6796b6f9236145b2f8858b", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyJobHunter.ViewModel.vm_Job>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
  
	ViewBag.Title = "(Job) " + Model.JOB.name;
	Layout = "~/Views/Shared/_Layout_Mall.cshtml";

	List<tbl_location> location = ViewBag.location;
	List<tbl_category_j> category = ViewBag.category;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>


		.wrapper form {
			height: 167px;
			display: flex;
			cursor: pointer;
			margin: 30px 0;
			align-items: center;
			justify-content: center;
			flex-direction: column;
			border-radius: 5px;
			border: 2px dashed #6990F2;
		}

	form i {
		font-size: 50px;
	}

	form p {
		margin-top: 15px;
		font-size: 16px;
	}

	section .row {
		margin-bottom: 10px;
		background: #E9F0FF;
		list-style: none;
		padding: 15px 20px;
		border-radius: 5px;
		display: flex;
		align-items: center;
		justify-content: space-between;
	}

		section .row i {
			color: #6990F2;
			font-size: 30px;
		}

	section .details span {
		font-size: 14px;
	}

	.progress-area .row .content {
		width: 100%;
		margin-left: 15px;
	}

	.progress-area .details {
		display: flex;
		align-items: center;
		margin-bottom: 7px;
		justify-content: space-between;
	}

	.progress-area .content .progress-bar {
		height: 6px;
		width: 100%;
		margin-bottom: 4px;
		background: #fff;
		borde");
            WriteLiteral(@"r-radius: 30px;
	}

	.content .progress-bar .progress {
		height: 100%;
		width: 0%;
		background: #6990F2;
		border-radius: inherit;
	}

	.uploaded-area {
		max-height: 232px;
		overflow-y: scroll;
	}

		.uploaded-area.onprogress {
			max-height: 150px;
		}

		.uploaded-area::-webkit-scrollbar {
			width: 0px;
		}

		.uploaded-area .row .content {
			display: flex;
			align-items: center;
		}

		.uploaded-area .row .details {
			display: flex;
			margin-left: 15px;
			flex-direction: column;
		}

			.uploaded-area .row .details .size {
				color: #404040;
				font-size: 11px;
			}

		.uploaded-area i.fa-check {
			font-size: 16px;
		}
</style>
<div class=""row justify-content-center"">

	<div class=""card"" style=""max-width:80rem;min-width:80rem"">
		<div class=""card-body"">
			<div class=""row"">
				<div class=""col-12 col-sm-4"">
					<div class=""col-12"" style=""position: relative; text-align: center; color: white;"">
						<img");
            BeginWriteAttribute("src", " src=\"", 2415, "\"", 2459, 1);
#nullable restore
#line 125 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
WriteAttributeValue("", 2421, Model.imagesFilePath.FirstOrDefault(), 2421, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"product-image border\" alt=\"Product Image\">\r\n");
#nullable restore
#line 126 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
                         if (!Model.JOB.is_publish)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<div style=\"background-color:rgba(0,0,0,0.5);position: absolute; top: 50%; left: 50%; transform: translate(-50%, -50%);\"><h1>Unlisted</h1></div>\r\n");
#nullable restore
#line 129 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-12 product-image-thumbs card-deck justify-content-start\">\r\n");
#nullable restore
#line 132 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
                         foreach (var i in Model.imagesFilePath)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 2879, "\"", 2973, 3);
            WriteAttributeValue("", 2887, "card", 2887, 4, true);
            WriteAttributeValue(" ", 2891, "product-image-thumb", 2892, 20, true);
#nullable restore
#line 134 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
WriteAttributeValue(" ", 2911, i == Model.imagesFilePath.FirstOrDefault() ? "active" : "", 2912, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 2989, "\"", 2997, 1);
#nullable restore
#line 135 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
WriteAttributeValue("", 2995, i, 2995, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2998, "\"", 3019, 1);
#nullable restore
#line 135 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
WriteAttributeValue("", 3004, Model.JOB.name, 3004, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 137 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\r\n\t\t\t\t<div class=\"col-12 col-sm-8\">\r\n\r\n\t\t\t\t\t<!--Product Name-->\r\n\t\t\t\t\t<h3 class=\"my-3\">");
#nullable restore
#line 144 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
                                Write(Model.JOB.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\t\t\t\t\t<!--prices-->\r\n\t\t\t\t\t<div class=\"mt-4 ml-0 pl-0\">\r\n\t\t\t\t\t\t<h2 class=\"mb-0\">\r\n\t\t\t\t\t\t\tRM ");
#nullable restore
#line 149 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
                          Write(Model.JOB.salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</h2>\r\n\r\n\t\t\t\t\t</div>\r\n\r\n\r\n\t\t\t\t\t<!--Employer-->\r\n\t\t\t\t\t<div class=\"text-muted\">\r\n\t\t\t\t\t\t<span>Employer : </span>\r\n\t\t\t\t\t\t<a class=\"badge bg-success\"");
            BeginWriteAttribute("href", " href=\"", 3442, "\"", 3513, 1);
#nullable restore
#line 158 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
WriteAttributeValue("", 3449, Url.Action("Employer", "Job", new { id = Model.JOB.created_by}), 3449, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 159 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
                       Write(Model.JOB.created_by);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
						</a>
					</div>

					<br />


					<button type=""button"" style=""margin-left:15px"" class=""btn btn-lg bg-teal"" data-toggle=""modal"" data-target=""#applyjobinformationModal"">
						<i class=""fas fa-cart-plus fa-lg mr-2""></i>
						Apply Now
					</button>

					<div class=""modal fade"" id=""applyjobinformationModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
						<div class=""modal-dialog"" role=""document"">
							<div class=""modal-content"">
								<div class=""modal-header"">
									<h5 class=""modal-title"" id=""exampleModalLabel"">Submit Your Informations</h5>
									<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
										<span aria-hidden=""true"">&times;</span>
									</button>
								</div>
								<div class=""modal-body"">
									<form1>
										<div class=""form-group"">
											<label for=""name"">Name</label>
											<input type=""text"" class=""form-control"" id=""name"" placeholder=""Name"">
										<");
            WriteLiteral(@"/div>
										<div class=""form-group"">
											<label for=""exampleInputEmail1"">Email address</label>
											<input type=""email"" class=""form-control"" id=""exampleFormControlInput1"" placeholder=""xyz123@gmail.com"">
										</div>
										<div class=""form-group"">
											<label for=""phone"">Phone Number</label>
											<input type=""phone"" class=""form-control"" id=""phone"" placeholder=""0129941223"">
										</div>
										<div class=""control-group"">
											<label for=""dob-day"" class=""control-label"">Date of birth</label>
											<div class=""controls"">
												<select name=""dob-day"" id=""dob-day"">
													<option");
            BeginWriteAttribute("value", " value=\"", 5228, "\"", 5236, 0);
            EndWriteAttribute();
            WriteLiteral(">Day</option>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<option");
            BeginWriteAttribute("value", " value=\"", 5272, "\"", 5280, 0);
            EndWriteAttribute();
            WriteLiteral(@">---</option>
													<option value=""01"">01</option>
													<option value=""02"">02</option>
													<option value=""03"">03</option>
													<option value=""04"">04</option>
													<option value=""05"">05</option>
													<option value=""06"">06</option>
													<option value=""07"">07</option>
													<option value=""08"">08</option>
													<option value=""09"">09</option>
													<option value=""10"">10</option>
													<option value=""11"">11</option>
													<option value=""12"">12</option>
													<option value=""13"">13</option>
													<option value=""14"">14</option>
													<option value=""15"">15</option>
													<option value=""16"">16</option>
													<option value=""17"">17</option>
													<option value=""18"">18</option>
													<option value=""19"">19</option>
													<option value=""20"">20</option>
													<option value=""21"">21</option>
													<option value=""22"">22</option>
													<optio");
            WriteLiteral(@"n value=""23"">23</option>
													<option value=""24"">24</option>
													<option value=""25"">25</option>
													<option value=""26"">26</option>
													<option value=""27"">27</option>
													<option value=""28"">28</option>
													<option value=""29"">29</option>
													<option value=""30"">30</option>
													<option value=""31"">31</option>
												</select>
												<select name=""dob-month"" id=""dob-month"">
													<option");
            BeginWriteAttribute("value", " value=\"", 6788, "\"", 6796, 0);
            EndWriteAttribute();
            WriteLiteral(">Month</option>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<option");
            BeginWriteAttribute("value", " value=\"", 6834, "\"", 6842, 0);
            EndWriteAttribute();
            WriteLiteral(@">-----</option>
													<option value=""01"">January</option>
													<option value=""02"">February</option>
													<option value=""03"">March</option>
													<option value=""04"">April</option>
													<option value=""05"">May</option>
													<option value=""06"">June</option>
													<option value=""07"">July</option>
													<option value=""08"">August</option>
													<option value=""09"">September</option>
													<option value=""10"">October</option>
													<option value=""11"">November</option>
													<option value=""12"">December</option>
												</select>
												<select name=""dob-year"" id=""dob-year"">
													<option");
            BeginWriteAttribute("value", " value=\"", 7545, "\"", 7553, 0);
            EndWriteAttribute();
            WriteLiteral(">Year</option>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<option");
            BeginWriteAttribute("value", " value=\"", 7590, "\"", 7598, 0);
            EndWriteAttribute();
            WriteLiteral(@">----</option>
													<option value=""2012"">2012</option>
													<option value=""2011"">2011</option>
													<option value=""2010"">2010</option>
													<option value=""2009"">2009</option>
													<option value=""2008"">2008</option>
													<option value=""2007"">2007</option>
													<option value=""2006"">2006</option>
													<option value=""2005"">2005</option>
													<option value=""2004"">2004</option>
													<option value=""2003"">2003</option>
													<option value=""2002"">2002</option>
													<option value=""2001"">2001</option>
													<option value=""2000"">2000</option>
													<option value=""1999"">1999</option>
													<option value=""1998"">1998</option>
													<option value=""1997"">1997</option>
													<option value=""1996"">1996</option>
													<option value=""1995"">1995</option>
													<option value=""1994"">1994</option>
													<option value=""1993"">1993</option>
													<option value=""");
            WriteLiteral(@"1992"">1992</option>
													<option value=""1991"">1991</option>
													<option value=""1990"">1990</option>
													<option value=""1989"">1989</option>
													<option value=""1988"">1988</option>
													<option value=""1987"">1987</option>
													<option value=""1986"">1986</option>
													<option value=""1985"">1985</option>
													<option value=""1984"">1984</option>
													<option value=""1983"">1983</option>
													<option value=""1982"">1982</option>
													<option value=""1981"">1981</option>
													<option value=""1980"">1980</option>
													<option value=""1979"">1979</option>
													<option value=""1978"">1978</option>
													<option value=""1977"">1977</option>
													<option value=""1976"">1976</option>
													<option value=""1975"">1975</option>
													<option value=""1974"">1974</option>
													<option value=""1973"">1973</option>
													<option value=""1972"">1972</option>
													<option va");
            WriteLiteral(@"lue=""1971"">1971</option>
													<option value=""1970"">1970</option>
													<option value=""1969"">1969</option>
													<option value=""1968"">1968</option>
													<option value=""1967"">1967</option>
													<option value=""1966"">1966</option>
													<option value=""1965"">1965</option>
													<option value=""1964"">1964</option>
													<option value=""1963"">1963</option>
													<option value=""1962"">1962</option>
													<option value=""1961"">1961</option>
													<option value=""1960"">1960</option>
													<option value=""1959"">1959</option>
													<option value=""1958"">1958</option>
													<option value=""1957"">1957</option>
													<option value=""1956"">1956</option>
													<option value=""1955"">1955</option>
													<option value=""1954"">1954</option>
													<option value=""1953"">1953</option>
													<option value=""1952"">1952</option>
													<option value=""1951"">1951</option>
													<opti");
            WriteLiteral(@"on value=""1950"">1950</option>
													<option value=""1949"">1949</option>
													<option value=""1948"">1948</option>
													<option value=""1947"">1947</option>
													<option value=""1946"">1946</option>
													<option value=""1945"">1945</option>
													<option value=""1944"">1944</option>
													<option value=""1943"">1943</option>
													<option value=""1942"">1942</option>
													<option value=""1941"">1941</option>
													<option value=""1940"">1940</option>
													<option value=""1939"">1939</option>
													<option value=""1938"">1938</option>
													<option value=""1937"">1937</option>
													<option value=""1936"">1936</option>
													<option value=""1935"">1935</option>
													<option value=""1934"">1934</option>
													<option value=""1933"">1933</option>
													<option value=""1932"">1932</option>
													<option value=""1931"">1931</option>
													<option value=""1930"">1930</option>
													");
            WriteLiteral(@"<option value=""1929"">1929</option>
													<option value=""1928"">1928</option>
													<option value=""1927"">1927</option>
													<option value=""1926"">1926</option>
													<option value=""1925"">1925</option>
													<option value=""1924"">1924</option>
													<option value=""1923"">1923</option>
													<option value=""1922"">1922</option>
													<option value=""1921"">1921</option>
													<option value=""1920"">1920</option>
													<option value=""1919"">1919</option>
													<option value=""1918"">1918</option>
													<option value=""1917"">1917</option>
													<option value=""1916"">1916</option>
													<option value=""1915"">1915</option>
													<option value=""1914"">1914</option>
													<option value=""1913"">1913</option>
													<option value=""1912"">1912</option>
													<option value=""1911"">1911</option>
													<option value=""1910"">1910</option>
													<option value=""1909"">1909</option>
								");
            WriteLiteral(@"					<option value=""1908"">1908</option>
													<option value=""1907"">1907</option>
													<option value=""1906"">1906</option>
													<option value=""1905"">1905</option>
													<option value=""1904"">1904</option>
													<option value=""1903"">1903</option>
													<option value=""1901"">1901</option>
													<option value=""1900"">1900</option>
												</select>
											</div>
										</div>
										<div class=""form-group"">
											<label for=""inputAddress"">Address</label>
											<input type=""text"" class=""form-control"" id=""inputAddress"" placeholder=""06 Jalan Lintang"">
										</div>
										<div class=""form-group"">
											<label for=""inputAddress2"">Address 2</label>
											<input type=""text"" class=""form-control"" id=""inputAddress2"" placeholder=""Apartment, studio, or floor"">
										</div>
										<div class=""form-row"">
											<div class=""form-group col-md-6"">
												<label for=""inputCity"">City</label>
												<inp");
            WriteLiteral(@"ut type=""text"" class=""form-control"" id=""inputCity"">
											</div>
											<div class=""form-group col-md-4"">
												<label for=""inputState"">State</label>
												<input type=""text"" class=""form-control"" id=""inputState"">
											</div>
											<div class=""form-group col-md-2"">
												<label for=""inputPostCode"">Postcode</label>
												<input type=""text"" class=""form-control"" id=""inputPostcode"">
											</div>
										</div>

									</form1>
								</div>
								<div class=""modal-footer"">
									<button type=""button"" style=""height: 46px"" class=""btn btn-lg bg-teal"" data-dismiss=""modal"">Close</button>
									<button type=""button"" data-toggle=""modal"" data-target=""#applyjobModal"" data-dismiss=""modal"" class=""btn btn-lg bg-teal"">Next</button>
								</div>
							</div>
						</div>
					</div>




					<div class=""modal fade"" id=""applyjobModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
						<div class=""moda");
            WriteLiteral(@"l-dialog"" role=""document"">
							<div class=""modal-content"">
								<div class=""modal-header"">
									<h5 class=""modal-title"" id=""exampleModalLabel"">Submit Your Resume</h5>
									<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
										<span aria-hidden=""true"">&times;</span>
									</button>
								</div>
								<div class=""modal-body"">
									<form>
										<input class=""file-input"" type=""file"" name=""file"" hidden>
										<i class=""fas fa-cloud-upload-alt""></i>
										<p>Browse File to Upload</p>
									</form>
									<section class=""progress-area""></section>
									<section class=""uploaded-area""></section>
								</div>
								<div class=""modal-footer"">
									<button type=""button"" style=""height: 46px"" class=""btn btn-lg bg-teal"" data-dismiss=""modal"">Close</button>
									<button type=""button"" id=""search_apply"" class=""btn btn-lg bg-teal btnApplyNow"">Apply</button>
								</div>
							</div>
						</div>
					</div>

				");
            WriteLiteral(@"</div>
			</div>

			<div class=""row mt-4"">
				<nav class=""w-100"">
					<div class=""nav nav-tabs"" id=""product-tab"" role=""tablist"">
						<a class=""nav-item nav-link active"" id=""product-desc-tab"" data-toggle=""tab"" href=""#product-desc"" role=""tab"" aria-controls=""product-desc"" aria-selected=""true"">Description</a>
					</div>
				</nav>
				<div class=""tab-content p-3"" id=""nav-tabContent"" style=""display:block!important;width:100%!important"">
					<div class=""tab-pane fade show active"" id=""product-desc"" role=""tabpanel"" aria-labelledby=""product-desc-tab"">

						<label>Category</label>
						<h4>
");
#nullable restore
#line 442 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
                             foreach (var i in category.Where(x => Model.cate_ids.Contains(x.id)).Select(x => x.name).ToList())
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<span class=\"badge bg-teal mr-2\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 445 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</span>\r\n");
#nullable restore
#line 447 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</h4>\r\n\r\n\t\t\t\t\t\t<label>Location</label>\r\n\t\t\t\t\t\t<h4>\r\n\t\t\t\t\t\t\t<span class=\"badge bg-teal mr-2\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 453 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
                           Write(location.Where(x=>x.id == Model.JOB.location_id).FirstOrDefault().name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t</h4>\r\n\r\n\r\n\t\t\t\t\t\t<label>Description</label>\r\n\t\t\t\t\t\t<span class=\"neednewline\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 460 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
                       Write(Model.JOB.content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</span>\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<!-- /.card-body -->\r\n\t</div>\r\n\r\n</div><!--row-->\r\n\r\n<input hidden type=\"text\" id=\"edited_by\" name=\"edited_by\"");
            BeginWriteAttribute("value", " value=\"", 17095, "\"", 17163, 1);
#nullable restore
#line 473 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
WriteAttributeValue("", 17103, HttpContextAccessor.HttpContext.Session.GetString("USERID"), 17103, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input hidden type=\"text\" id=\"edited_date\" name=\"edited_date\"");
            BeginWriteAttribute("value", " value=\"", 17230, "\"", 17251, 1);
#nullable restore
#line 474 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
WriteAttributeValue("", 17238, DateTime.Now, 17238, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />


<script>

	const form = document.querySelector(""form""),
		fileInput = document.querySelector("".file-input""),
		progressArea = document.querySelector("".progress-area""),
		uploadedArea = document.querySelector("".uploaded-area"");

	form.addEventListener(""click"", () => {
		fileInput.click();
	});

	fileInput.onchange = ({ target }) => {
		let file = target.files[0];
		if (file) {
			let fileName = file.name;
			if (fileName.length >= 12) {
				let splitName = fileName.split('.');
				fileName = splitName[0].substring(0, 13) + ""... ."" + splitName[1];
			}
			uploadFile(fileName);
		}
	}

	function uploadFile(name) {
		let xhr = new XMLHttpRequest();
		xhr.open(""POST"", ""php/upload.php"");
		xhr.upload.addEventListener(""progress"", ({ loaded, total }) => {
			let fileLoaded = Math.floor((loaded / total) * 100);
			let fileTotal = Math.floor(total / 1000);
			let fileSize;
			(fileTotal < 1024) ? fileSize = fileTotal + "" KB"" : fileSize = (loaded / (1024 * 1024)).toFixed(2) + "" MB""");
            WriteLiteral(@";
			let progressHTML = `<li class=""row"">
                          <i class=""fas fa-file-alt""></i>
                          <div class=""content"">
                            <div class=""details"">
                              <span class=""name"">${name} • Uploading</span>
                              <span class=""percent"">${fileLoaded}%</span>
                            </div>
                            <div class=""progress-bar"">
                              <div class=""progress"" style=""width: ${fileLoaded}%""></div>
                            </div>
                          </div>
                        </li>`;
			uploadedArea.classList.add(""onprogress"");
			progressArea.innerHTML = progressHTML;
			if (loaded == total) {
				progressArea.innerHTML = """";
				let uploadedHTML = `<li class=""row"">
                            <div class=""content upload"">
                              <i class=""fas fa-file-alt""></i>
                              <div class=""details"">
                  ");
            WriteLiteral(@"              <span class=""name"">${name} • Uploaded</span>
                                <span class=""size"">${fileSize}</span>
                              </div>
                            </div>
                            <i class=""fas fa-check""></i>
                          </li>`;
				uploadedArea.classList.remove(""onprogress"");
				uploadedArea.insertAdjacentHTML(""afterbegin"", uploadedHTML);
			}
		});
		let data = new FormData(form);
		xhr.send(data);
	}


	var currentUser = '");
#nullable restore
#line 543 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
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
#line 568 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
                          Write(Url.Action("Index","Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n\t\t}\r\n\t\telse {\r\n\t\t\tloading();\r\n\t\t\tvar url = \'");
#nullable restore
#line 572 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
                  Write(Url.Action("Create","JobApplication",new { id = Model.JOB.id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n\t\t\t\t$.ajax({\r\n\t\t\t\t\turl: url,\r\n\t\t\t\t\ttype: \"POST\",\r\n\t\t\t\t\tdata:\r\n\t\t\t\t\t{\r\n\t\t\t\t\t\tid: \'");
#nullable restore
#line 578 "C:\Users\Asus\Desktop\Star Pattern In JavaScript\FYP2\fyp2\EasyJobHunter\EasyJobHunter\Views\Job\Detail.cshtml"
                        Write(Model.JOB.id);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyJobHunter.ViewModel.vm_Job> Html { get; private set; }
    }
}
#pragma warning restore 1591