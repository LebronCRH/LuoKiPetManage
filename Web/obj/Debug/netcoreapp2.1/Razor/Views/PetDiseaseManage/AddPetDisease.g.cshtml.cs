#pragma checksum "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\PetDiseaseManage\AddPetDisease.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82ee5cd373909ae130f11873c7510b7e8aeb0f61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PetDiseaseManage_AddPetDisease), @"mvc.1.0.view", @"/Views/PetDiseaseManage/AddPetDisease.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PetDiseaseManage/AddPetDisease.cshtml", typeof(AspNetCore.Views_PetDiseaseManage_AddPetDisease))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82ee5cd373909ae130f11873c7510b7e8aeb0f61", @"/Views/PetDiseaseManage/AddPetDisease.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_PetDiseaseManage_AddPetDisease : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.LuoKiPetModels.PetDisease>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("lay-filter", new global::Microsoft.AspNetCore.Html.HtmlString("disease-form-add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\PetDiseaseManage\AddPetDisease.cshtml"
  
    ViewData["Title"] = "AddPetDisease";
    Layout = null;

#line default
#line hidden
            BeginContext(110, 35, true);
            WriteLiteral("\r\n<div style=\"padding:15px;\">\r\n    ");
            EndContext();
            BeginContext(145, 5956, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21f018150ddb4868940b97bcf2d314fa", async() => {
                BeginContext(200, 214, true);
                WriteLiteral("\r\n        <div class=\"layui-form-item\">\r\n            <div class=\"layui-col-lg6\">\r\n                <label class=\"layui-form-label\">疾病名称：</label>\r\n                <div class=\"layui-input-block\">\r\n                    ");
                EndContext();
                BeginContext(415, 30, false);
#line 13 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\PetDiseaseManage\AddPetDisease.cshtml"
               Write(Html.HiddenFor(m=>m.DiseaseId));

#line default
#line hidden
                EndContext();
                BeginContext(445, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(677, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(698, 150, false);
#line 16 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\PetDiseaseManage\AddPetDisease.cshtml"
               Write(Html.EditorFor(model => model.DiseaseName, new { htmlAttributes = new { placeholder = "请输入疾病名称", @class = "layui-input", @lay_verify = "required" } }));

#line default
#line hidden
                EndContext();
                BeginContext(848, 254, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"layui-form-item\">\r\n            <div class=\"layui-col-lg6\">\r\n                <label class=\"layui-form-label\">字母搜索：</label>\r\n                <div class=\"layui-input-block\">\r\n");
                EndContext();
                BeginContext(1255, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1276, 145, false);
#line 25 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\PetDiseaseManage\AddPetDisease.cshtml"
               Write(Html.EditorFor(model => model.ForEn, new { htmlAttributes = new { placeholder = "请输入英文首字母", @class = "layui-input", @lay_verify = "required" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1421, 233, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"layui-row layui-col-space10 layui-form-item\">\r\n            <label class=\"layui-form-label\">疾病科属：</label>\r\n            <div class=\"layui-input-block\">\r\n");
                EndContext();
                BeginContext(1804, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1821, 145, false);
#line 33 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\PetDiseaseManage\AddPetDisease.cshtml"
           Write(Html.EditorFor(model => model.Genera, new { htmlAttributes = new { placeholder = "请输入疾病科属", @class = "layui-input", @lay_verify = "required" } }));

#line default
#line hidden
                EndContext();
                BeginContext(1966, 209, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"layui-row layui-col-space10 layui-form-item\">\r\n            <label class=\"layui-form-label\">疾病症状：</label>\r\n            <div class=\"layui-input-block\">\r\n");
                EndContext();
                BeginContext(2327, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(2344, 146, false);
#line 40 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\PetDiseaseManage\AddPetDisease.cshtml"
           Write(Html.EditorFor(model => model.Symptom, new { htmlAttributes = new { placeholder = "请输入疾病症状", @class = "layui-input", @lay_verify = "required" } }));

#line default
#line hidden
                EndContext();
                BeginContext(2490, 1256, true);
                WriteLiteral(@"
            </div>
        </div>
        <div class=""layui-form-item"">
            <div class=""layui-inline"">
                <label class=""layui-form-label"">宠物种类：</label>
                <div class=""layui-input-block menuchildforid"">
                    <select name=""ForPetCaegoryId"" id=""ForPetCaegoryId"" lay-verify=""required"" lay-filter=""ForPetCaegoryId""></select>
                </div>
            </div>
            <div class=""layui-inline"">
                <label class=""layui-form-label"">所属部位：</label>
                <div class=""layui-input-block menuchildforid"">
                    <select name=""ForPositionID"" id=""ForPositionID"" lay-verify=""required"" lay-filter=""ForPositionID""></select>
                </div>
            </div>
            <div class=""layui-inline"">
                <label class=""layui-form-label"">所属症状：</label>
                <div class=""layui-input-block menuchildforid"">
                    <select name=""ForSymptomId"" id=""ForSymptomId"" lay-verify=""required"" lay-filt");
                WriteLiteral("er=\"ForSymptomId\"></select>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"layui-form-item\">\r\n            <label class=\"layui-form-label\">疾病概述：</label>\r\n            <div class=\"layui-input-block\">\r\n");
                EndContext();
                BeginContext(3862, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(3879, 118, false);
#line 67 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\PetDiseaseManage\AddPetDisease.cshtml"
           Write(Html.TextAreaFor(m=>m.Summary,  new { placeholder = "请输入疾病概述", @class = "layui-textarea", @lay_verify = "required" } ));

#line default
#line hidden
                EndContext();
                BeginContext(3997, 181, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"layui-form-item\">\r\n            <label class=\"layui-form-label\">发病原因：</label>\r\n            <div class=\"layui-input-block\">\r\n");
                EndContext();
                BeginContext(4304, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(4321, 123, false);
#line 74 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\PetDiseaseManage\AddPetDisease.cshtml"
           Write(Html.TextAreaFor(m => m.DiseaseCause, new { placeholder = "请输入发病原因", @class = "layui-textarea", @lay_verify = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(4444, 181, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"layui-form-item\">\r\n            <label class=\"layui-form-label\">主要症状：</label>\r\n            <div class=\"layui-input-block\">\r\n");
                EndContext();
                BeginContext(4749, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(4766, 122, false);
#line 81 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\PetDiseaseManage\AddPetDisease.cshtml"
           Write(Html.TextAreaFor(m => m.MainSymptom, new { placeholder = "请输入主要症状", @class = "layui-textarea", @lay_verify = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(4888, 181, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"layui-form-item\">\r\n            <label class=\"layui-form-label\">诊断标准：</label>\r\n            <div class=\"layui-input-block\">\r\n");
                EndContext();
                BeginContext(5179, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(5196, 115, false);
#line 88 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\PetDiseaseManage\AddPetDisease.cshtml"
           Write(Html.TextAreaFor(m => m.Zdbz, new { placeholder = "请输入发病原因", @class = "layui-textarea", @lay_verify = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(5311, 181, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"layui-form-item\">\r\n            <label class=\"layui-form-label\">治疗方法：</label>\r\n            <div class=\"layui-input-block\">\r\n");
                EndContext();
                BeginContext(5612, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(5629, 119, false);
#line 95 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\PetDiseaseManage\AddPetDisease.cshtml"
           Write(Html.TextAreaFor(m => m.Treatment,new { placeholder = "请输入治疗方法", @class = "layui-textarea", @lay_verify = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(5748, 346, true);
                WriteLiteral(@"
            </div>
        </div>
        <div class=""layui-form-item"">
            <div class=""layui-input-block"">
                <button class=""layui-btn"" lay-submit lay-filter=""disease-form-add"">立即提交</button>
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6101, 2743, true);
            WriteLiteral(@"
</div>


<script>
    layui.use(['layer', 'form', 'laydate', 'upload', 'cityselect'], function () {
        var $ = layui.$
            , layer = layui.layer
            , index = parent.layer.getFrameIndex(window.name) //获取窗口索引
            , element = layui.element
            , laydate = layui.laydate
            , upload = layui.upload
            , cityselect = layui.cityselect
            , form = layui.form;
        setTimeout(function () {
                cityselect.render({
                    elem: [""#ForPetCaegoryId"", ""#ForPositionID"", ""#ForSymptomId""],
                    elembox: 'disease-form-add',
                    url: 'PetDiseaseManage/GetPetDiseaseSelect',
                    Tips: [""请选择种类"", ""请选择部位"", ""请选择相应的症状""]
                });
        }, 600);


        form.render(null, 'disease-form-add');
        laydate.render({
            elem: '#LAY-informationAdd-modifyTime'
        });

        /* 自定义验证规则 */
        form.verify({
            title: function (val");
            WriteLiteral(@"ue) {
                if (value.length < 5) {
                    return '标题至少得5个字符啊';
                }
            }
            , pass: [/(.+){6,12}$/, '密码必须6到12位']
            , content: function (value) {
                layedit.sync(editIndex);
            }
        });

        /* 监听提交 */
        form.on('submit(component-form-demo1)', function (data) {
            console.log(JSON.stringify(data.field));
            var oldData = parent.layui.table.cache[""LAY-app-table-all""];
            var data1 = JSON.stringify(data.field);
            oldData.push(data1);
            parent.layui.table.reload('LAY-app-table-all', {
                data: oldData
            });

            parent.layer.close(index);
            return false;
        });

        form.on('submit(disease-form-add)', function (data) {
            $.ajax({
                url: 'PetDiseaseManage/AddPetdisease',
                type: ""post"",
                data: data.field,
                success: functio");
            WriteLiteral(@"n (e) {
                    if (e === 1) {
                        layer.msg(""添加成功"", { icon: 6 });
                        layer.close(menuchildaddindex);
                    } else {
                        layer.msg('添加失败', { icon: 5 });
                    }
                },
                error: function (e) {
                    layer.msg('添加失败', { icon: 2 });
                }
            });
            return false;
        });

        $('.layui-btn-container .layui-btn').on('click', function () {
            var othis = $(this)
                , type = othis.data('type');
            active[type] && active[type].call(this);
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.LuoKiPetModels.PetDisease> Html { get; private set; }
    }
}
#pragma warning restore 1591