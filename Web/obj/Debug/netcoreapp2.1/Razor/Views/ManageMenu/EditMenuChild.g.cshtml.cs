#pragma checksum "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\EditMenuChild.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8e2d1da4b8c9c57410597dcc9c2f06affd26e4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageMenu_EditMenuChild), @"mvc.1.0.view", @"/Views/ManageMenu/EditMenuChild.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ManageMenu/EditMenuChild.cshtml", typeof(AspNetCore.Views_ManageMenu_EditMenuChild))]
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
#line 1 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8e2d1da4b8c9c57410597dcc9c2f06affd26e4d", @"/Views/ManageMenu/EditMenuChild.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_ManageMenu_EditMenuChild : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.ViewModels.EditMenuChildViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("lay-filter", new global::Microsoft.AspNetCore.Html.HtmlString("component-form-element"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\EditMenuChild.cshtml"
  
    ViewData["Title"] = "EditMenuChild";
    Layout = null;

#line default
#line hidden
            BeginContext(551, 43, true);
            WriteLiteral("\r\n    <div style=\"padding:15px;\">\r\n        ");
            EndContext();
            BeginContext(594, 2897, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1683e60517ad43f49472fb7fb9c46512", async() => {
                BeginContext(665, 280, true);
                WriteLiteral(@"
            <div class=""layui-form-item"">
                <div class=""layui-col-lg6"">
                    <label class=""layui-form-label"">菜单名称：</label>
                    <div class=""layui-input-block"">
                        <input type=""hidden"" name=""ManagerMenuChildID""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 945, "\"", 988, 1);
#line 23 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\EditMenuChild.cshtml"
WriteAttributeValue("", 953, Model.menuchild.ManagerMenuChildID, 953, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(989, 163, true);
                WriteLiteral(" />\r\n                        <input type=\"text\" name=\"MenuChildName\" id=\"MenuChildName\" lay-verify=\"required\" placeholder=\"\" autocomplete=\"off\" class=\"layui-input\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1152, "\"", 1190, 1);
#line 24 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\EditMenuChild.cshtml"
WriteAttributeValue("", 1160, Model.menuchild.MenuChildName, 1160, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1191, 393, true);
                WriteLiteral(@">
                    </div>
                </div>
            </div>
            <div class=""layui-row layui-col-space10 layui-form-item"">
                <label class=""layui-form-label"">链接地址：</label>
                <div class=""layui-input-block"">
                    <input type=""text"" name=""MenuChildHref"" lay-verify=""required"" placeholder="""" autocomplete=""off"" class=""layui-input""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1584, "\"", 1622, 1);
#line 31 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\EditMenuChild.cshtml"
WriteAttributeValue("", 1592, Model.menuchild.MenuChildHref, 1592, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1623, 305, true);
                WriteLiteral(@">
                </div>
            </div>
            <div class=""layui-form-item"">
                <label class=""layui-form-label"">父级菜单：</label>
                <div class=""layui-input-block menuchildforid"">
                    <select name=""ForMenuID"" lay-verify=""required"" lay-filter=""aihao"">
");
                EndContext();
#line 38 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\EditMenuChild.cshtml"
                         foreach (var item in Model.menulist)
                        {

#line default
#line hidden
                BeginContext(2018, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(2046, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f970dd5e5d6641949a87eddb70f37479", async() => {
                    BeginContext(2082, 13, false);
#line 40 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\EditMenuChild.cshtml"
                                                          Write(item.MenuName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 40 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\EditMenuChild.cshtml"
                               WriteLiteral(item.ManageMenuID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2104, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 41 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\EditMenuChild.cshtml"
                        }

#line default
#line hidden
                BeginContext(2133, 338, true);
                WriteLiteral(@"                    </select>
                </div>
            </div>
            <div class=""layui-form-item"">
                <label class=""layui-form-label"">数据名称：</label>
                <div class=""layui-input-block"">
                    <input type=""text"" name=""DataName"" placeholder="""" autocomplete=""off"" class=""layui-input""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2471, "\"", 2504, 1);
#line 48 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\EditMenuChild.cshtml"
WriteAttributeValue("", 2479, Model.menuchild.DataName, 2479, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2505, 340, true);
                WriteLiteral(@">
                </div>
            </div>
            <div class=""layui-form-item"">
                <label class=""layui-form-label"">是否禁用：</label>
                <div class=""layui-input-block"">
                    <input type=""checkbox"" name=""marriage"" lay-skin=""switch"" lay-text=""是|否"">
                </div>
            </div>
");
                EndContext();
                BeginContext(3142, 342, true);
                WriteLiteral(@"            <div class=""layui-form-item"">
                <div class=""layui-input-block"">
                    <button class=""layui-btn"" lay-submit lay-filter=""component-form-element"">立即提交</button>
                    <button type=""reset"" class=""layui-btn layui-btn-primary"">重置</button>
                </div>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3491, 16, true);
            WriteLiteral("\r\n    </div>\r\n\r\n");
            EndContext();
            BeginContext(3567, 341, true);
            WriteLiteral(@"    <script>
    layui.use(['tree', 'layer', 'table', 'form', 'laytpl'], function () {
        var $ = layui.$
            , layer = layui.layer
            , admin = layui.admin
            , table = layui.table
            , element = layui.element
            , form = layui.form
            , laytpl = layui.laytpl;
        if (");
            EndContext();
            BeginContext(3909, 25, false);
#line 82 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\EditMenuChild.cshtml"
       Write(Model.menuchild.ForMenuID);

#line default
#line hidden
            EndContext();
            BeginContext(3934, 65, true);
            WriteLiteral("!=null) {\r\n            $(\"[name=\'forparentid\'] option[value=\'\" + ");
            EndContext();
            BeginContext(4000, 25, false);
#line 83 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\EditMenuChild.cshtml"
                                                 Write(Model.menuchild.ForMenuID);

#line default
#line hidden
            EndContext();
            BeginContext(4025, 125, true);
            WriteLiteral(" + \"\']\").attr(\"selected\", \"true\");\r\n        }\r\n        form.render(null, \'component-form-element\');\r\n    });\r\n    </script>\r\n");
            EndContext();
            BeginContext(4172, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.ViewModels.EditMenuChildViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
