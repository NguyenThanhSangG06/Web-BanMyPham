#pragma checksum "C:\Users\84967\OneDrive\Desktop\Store\Store\Views\Shared\_FooterPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "171bc6fa968900089ecef854bafcde34ddce51e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FooterPartialView), @"mvc.1.0.view", @"/Views/Shared/_FooterPartialView.cshtml")]
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
#line 1 "C:\Users\84967\OneDrive\Desktop\Store\Store\Views\_ViewImports.cshtml"
using Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\84967\OneDrive\Desktop\Store\Store\Views\_ViewImports.cshtml"
using Store.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"171bc6fa968900089ecef854bafcde34ddce51e5", @"/Views/Shared/_FooterPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bf4e815b3c664a1a42b413716bf96a575e49a98", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FooterPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer id=""footer"">
    <div class=""newsletter-section"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12 col-sm-12 col-md-12 col-lg-7 w-100 d-flex justify-content-start align-items-center"">
                    <div class=""display-table"">
                        <div class=""display-table-cell footer-newsletter"">
                            <div class=""section-header text-center"">
                                <label class=""h2""><span>sign up for </span>newsletter</label>
                            </div>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "171bc6fa968900089ecef854bafcde34ddce51e54487", async() => {
                WriteLiteral("\n                                <div class=\"input-group\">\n                                    <input type=\"email\" class=\"input-group__field newsletter__input\" name=\"EMAIL\"");
                BeginWriteAttribute("value", " value=\"", 792, "\"", 800, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Email address\"");
                BeginWriteAttribute("required", " required=\"", 829, "\"", 840, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    <span class=""input-group__btn"">
                                        <button type=""submit"" class=""btn newsletter__submit"" name=""commit"" id=""Subscribe""><span class=""newsletter__submit-text--large"">Subscribe</span></button>
                                    </span>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col-12 col-sm-12 col-md-12 col-lg-5 d-flex justify-content-end align-items-center"">
                    <div class=""footer-social"">
                        <ul class=""list--inline site-footer__social-icons social-icons"">
                            <li><a class=""social-icons__link"" href=""#"" target=""_blank"" title=""Belle Multipurpose Bootstrap 4 Template on Facebook""><i class=""icon icon-facebook""></i></a></li>
                            <li><a class=""social-icons__link"" href=""#"" target=""_blank"" title=""Belle Multipurpose Bootstrap 4 Template on Twitter""><i class=""icon icon-twitter""></i> <span class=""icon__fallback-text"">Twitter</span></a></li>
                            <li><a class=""social-icons__link"" href=""#"" target=""_blank"" title=""Belle Multipurpose Bootstrap 4 Template on Pinterest""><i class=""icon icon-pinterest""></i> <span class=""icon__fallback-text"">Pinterest</span></a></li>
                    ");
            WriteLiteral(@"        <li><a class=""social-icons__link"" href=""#"" target=""_blank"" title=""Belle Multipurpose Bootstrap 4 Template on Instagram""><i class=""icon icon-instagram""></i> <span class=""icon__fallback-text"">Instagram</span></a></li>
                            <li><a class=""social-icons__link"" href=""#"" target=""_blank"" title=""Belle Multipurpose Bootstrap 4 Template on Tumblr""><i class=""icon icon-tumblr-alt""></i> <span class=""icon__fallback-text"">Tumblr</span></a></li>
                            <li><a class=""social-icons__link"" href=""#"" target=""_blank"" title=""Belle Multipurpose Bootstrap 4 Template on YouTube""><i class=""icon icon-youtube""></i> <span class=""icon__fallback-text"">YouTube</span></a></li>
                            <li><a class=""social-icons__link"" href=""#"" target=""_blank"" title=""Belle Multipurpose Bootstrap 4 Template on Vimeo""><i class=""icon icon-vimeo-alt""></i> <span class=""icon__fallback-text"">Vimeo</span></a></li>
                        </ul>
                    </div>
                </div>
       ");
            WriteLiteral(@"     </div>
        </div>
    </div>
    <div class=""site-footer"">
        <div class=""container"">
            <!--Footer Links-->
            <div class=""footer-top"">
                <div class=""row"">
                    <div class=""col-12 col-sm-12 col-md-3 col-lg-3 footer-links"">
                        <h4 class=""h4"">Quick Shop</h4>
                        <ul>
                            <li><a href=""#"">Women</a></li>
                            <li><a href=""#"">Men</a></li>
                            <li><a href=""#"">Kids</a></li>
                            <li><a href=""#"">Sportswear</a></li>
                            <li><a href=""#"">Sale</a></li>
                        </ul>
                    </div>
                    <div class=""col-12 col-sm-12 col-md-3 col-lg-3 footer-links"">
                        <h4 class=""h4"">Informations</h4>
                        <ul>
                            <li><a href=""#"">About us</a></li>
                            <li><a href=""#"">Careers</a></li>
           ");
            WriteLiteral(@"                 <li><a href=""#"">Privacy policy</a></li>
                            <li><a href=""#"">Terms &amp; condition</a></li>
                            <li><a href=""#"">My Account</a></li>
                        </ul>
                    </div>
                    <div class=""col-12 col-sm-12 col-md-3 col-lg-3 footer-links"">
                        <h4 class=""h4"">Customer Services</h4>
                        <ul>
                            <li><a href=""#"">Request Personal Data</a></li>
                            <li><a href=""#"">FAQ's</a></li>
                            <li><a href=""#"">Contact Us</a></li>
                            <li><a href=""#"">Orders and Returns</a></li>
                            <li><a href=""#"">Support Center</a></li>
                        </ul>
                    </div>
                    <div class=""col-12 col-sm-12 col-md-3 col-lg-3 contact-box"">
                        <h4 class=""h4"">Contact Us</h4>
                        <ul class=""addressFooter"">
                ");
            WriteLiteral(@"            <li><i class=""icon anm anm-map-marker-al""></i><p>55 Gallaxy Enque,<br>2568 steet, 23568 NY</p></li>
                            <li class=""phone""><i class=""icon anm anm-phone-s""></i><p>(440) 000 000 0000</p></li>
                            <li class=""email""><i class=""icon anm anm-envelope-l""></i><p>sales@yousite.com</p></li>
                        </ul>
                    </div>
                </div>
            </div>
            <!--End Footer Links-->
            <hr>
            <div class=""footer-bottom"">
                <div class=""row"">
                    <!--Footer Copyright-->
                    <div class=""col-12 col-sm-12 col-md-6 col-lg-6 order-1 order-md-0 order-lg-0 order-sm-1 copyright text-sm-center text-md-left text-lg-left""><span></span> <a href=""templateshub.net"">Templates Hub</a></div>
                    <!--End Footer Copyright-->
                    <!--Footer Payment Icon-->
                    <div class=""col-12 col-sm-12 col-md-6 col-lg-6 order-0 order-md-1 order-lg");
            WriteLiteral(@"-1 order-sm-0 payment-icons text-right text-md-center"">
                        <ul class=""payment-icons list--inline"">
                            <li><i class=""icon fa fa-cc-visa"" aria-hidden=""true""></i></li>
                            <li><i class=""icon fa fa-cc-mastercard"" aria-hidden=""true""></i></li>
                            <li><i class=""icon fa fa-cc-discover"" aria-hidden=""true""></i></li>
                            <li><i class=""icon fa fa-cc-paypal"" aria-hidden=""true""></i></li>
                            <li><i class=""icon fa fa-cc-amex"" aria-hidden=""true""></i></li>
                            <li><i class=""icon fa fa-credit-card"" aria-hidden=""true""></i></li>
                        </ul>
                    </div>
                    <!--End Footer Payment Icon-->
                </div>
            </div>
        </div>
    </div>
</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
