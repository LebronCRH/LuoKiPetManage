#pragma checksum "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad6e0e3ebb3124bc83b14744c404a30717234789"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageMenu_Index), @"mvc.1.0.view", @"/Views/ManageMenu/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ManageMenu/Index.cshtml", typeof(AspNetCore.Views_ManageMenu_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad6e0e3ebb3124bc83b14744c404a30717234789", @"/Views/ManageMenu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_ManageMenu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.LuoKiPetModels.ManageMenu>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("lay-filter", new global::Microsoft.AspNetCore.Html.HtmlString("component-form-managemenu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("lay-filter", new global::Microsoft.AspNetCore.Html.HtmlString("component-form-element"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(82, 1419, true);
            WriteLiteral(@"
<title>部门管理</title>

<div class=""layui-card layadmin-header"">
    <div class=""layui-breadcrumb"" lay-filter=""breadcrumb"">
        <a lay-href="""">主页</a>
        <a><cite>部门管理</cite></a>
    </div>
</div>

<div class=""layui-fluid"" id=""LAY-app-table"">
    <div class=""layui-card layui-row layui-col-space15"" style=""padding: 15px;"">
        <div class=""orgbox layui-col-md2"">
            <ul id=""demo2""></ul>
        </div>
        <div class=""site-tips layui-col-md10"" id=""demo2-view"">
            <div id=""viewForm"">

            </div>
            <div id=""viewTable"">
                <div style=""padding-bottom: 10px;"">
                    <button class=""layui-btn layui-btn-normal BigEdit"" data-type=""add"">
                        <i class=""layui-icon"">&#xe654;</i>添加
                    </button>
                    <button class=""layui-btn layui-btn-danger BigEdit"" data-type=""batchdel"">
                        <i class=""layui-icon"">&#xe640;</i>删除
                    </button>
              ");
            WriteLiteral(@"      <button class=""layui-btn layui-btn-warm BigEdit"" data-type=""output"">
                        <i class=""layui-icon"">&#xe6a6;</i>导出
                    </button>
                </div>
                <table id=""LAY-mymenu-all"" lay-filter=""LAY-mymenu-all""></table>
            </div>
        </div>
    </div>
</div>
<script id=""formBoxMenu"" type=""text/html"">
    <div></div>
    ");
            EndContext();
            BeginContext(1501, 1865, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8e5e207490a420eaa3d153f5a64d0ae", async() => {
                BeginContext(1575, 1784, true);
                WriteLiteral(@"
        <div class=""layui-form-item"">
            <div class=""layui-col-lg6"">
                <label class=""layui-form-label"">菜单名称：</label>
                <div class=""layui-input-block"">
                    <input type=""hidden"" name=""ManageMenuID"" value=""{{d.manageMenuID}}"" />
                    <input type=""text"" name=""MenuName"" id=""MenuName"" lay-verify=""required"" placeholder="""" autocomplete=""off"" class=""layui-input"" value=""{{d.menuName}}"">
                </div>
            </div>
        </div>
        <div class=""layui-row layui-col-space10 layui-form-item"">
            <label class=""layui-form-label"">菜单图标：</label>
            <div class=""layui-input-block"">
                <input type=""text"" name=""MenuIcon"" id=""MenuIcon"" lay-verify=""required"" placeholder="""" autocomplete=""off"" class=""layui-input"" value=""{{d.menuIcon}}"">
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">数据名称：</label>
            <div class=""layui-input-b");
                WriteLiteral(@"lock"">
                <input type=""text"" name=""DataName"" placeholder="""" autocomplete=""off"" class=""layui-input"" value=""{{d.dataName}}"">
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">是否禁用：</label>
            <div class=""layui-input-block"">
                <input type=""checkbox"" name=""marriage"" lay-skin=""switch"" lay-text=""是|否"">
            </div>
        </div>
        <div class=""layui-form-item"">
            <div class=""layui-input-block"">
                <button class=""layui-btn"" lay-submit lay-filter=""component-form-managemenu"">立即提交</button>
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
            BeginContext(3366, 76, true);
            WriteLiteral("\r\n</script>\r\n\r\n<script id=\"formBox\" type=\"text/html\">\r\n    <div></div>\r\n    ");
            EndContext();
            BeginContext(3442, 5087, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75ed58f8e0c342c5bdcd4d506788833b", async() => {
                BeginContext(3513, 1154, true);
                WriteLiteral(@"
        <div class=""layui-form-item"">
            <div class=""layui-col-lg6"">
                <label class=""layui-form-label"">节点名称：</label>
                <div class=""layui-input-block"">
                    <input type=""hidden"" name=""ManagerMenuChildID"" value=""{{d.managerMenuChildID}}"" />
                    <input type=""text"" name=""MenuChildName"" id=""MenuChildName"" lay-verify=""required"" placeholder="""" autocomplete=""off"" class=""layui-input"" value=""{{d.menuChildName}}"">
                </div>
            </div>
        </div>
        <div class=""layui-row layui-col-space10 layui-form-item"">
            <label class=""layui-form-label"">链接地址：</label>
            <div class=""layui-input-block"">
                <input type=""text"" name=""MenuChildHref"" lay-verify=""required"" placeholder="""" autocomplete=""off"" class=""layui-input"" value=""{{d.menuChildHref}}"">
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">父级菜单：</label>
            <d");
                WriteLiteral("iv class=\"layui-input-block menuchildforid\">\r\n                <select name=\"ForMenuID\" lay-verify=\"required\" lay-filter=\"aihao\">\r\n");
                EndContext();
#line 103 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
                BeginContext(4792, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(4816, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838f7a62c9f948c99018fb893685129a", async() => {
                    BeginContext(4852, 13, false);
#line 105 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\Index.cshtml"
                                                      Write(item.MenuName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 105 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\Index.cshtml"
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
                BeginContext(4874, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 106 "C:\Users\Administrator\Desktop\NET Core学习\NetCoreEF7Test\Web\Views\ManageMenu\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(4899, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(7292, 643, true);
                WriteLiteral(@"
                </select>
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">数据名称：</label>
            <div class=""layui-input-block"">
                <input type=""text"" name=""DataName"" placeholder="""" autocomplete=""off"" class=""layui-input"" value=""{{d.dataName}}"">
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
                BeginContext(8208, 314, true);
                WriteLiteral(@"        <div class=""layui-form-item"">
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8529, 16643, true);
            WriteLiteral(@"
</script>

<style>
    .orgbox {
        display: inline-block;
        height: 510px;
        border: 1px solid #ddd;
        overflow: auto;
    }

    .site-tips {
        display: inline-block;
        vertical-align: top;
    }
</style>
<script>
    layui.use(['tree','layer','table','form','laytpl'], function(){
        var $ = layui.$
            ,layer = layui.layer
            ,admin = layui.admin
            ,table = layui.table
            ,element = layui.element
            , form = layui.form
            ,view = layui.view
            , laytpl = layui.laytpl;
        var formview = $(""#viewForm"");
        var tableview = $(""#viewTable"");
        var menuchildaddindex;
        var tplStatus = function (d) {
                return '<input type=""checkbox"" name=""status"" lay-skin=""switch"" lay-text=""正常|禁用"" checked=""false"">';
        };
        var tplOperate = function (d) {
            return '<div class=""opetate"">' +
                '<button class=""layui-btn layui-b");
            WriteLiteral(@"tn-xs""  lay-event=""edit"">编辑</button>' +
                '<button class=""layui-btn layui-btn-danger layui-btn-xs""  lay-event=""del"">删除</button>' +
                '</div>';
        };
        var active = {
            batchdel: function () {
                var checkStatus = table.checkStatus('LAY-mymenu-all')
                    , checkData = checkStatus.data; //得到选中的数据
                console.log(checkData);
                if (checkData.length === 0) {
                    return layer.msg('请选择数据');
                }
                layer.prompt({
                    formType: 1
                    , title: '敏感操作，请验证口令'
                }, function (value, index) {
                    if (value === ""123456"") {
                        layer.close(index);
                        layer.confirm('确定删除吗？', function (index) {
                            var deletelist = [];
                            checkData.forEach((item) => {
                                deletelist.push(item.child);
   ");
            WriteLiteral(@"                         });
                            $.ajax({
                                url: 'ManageMenu/DeleteMenuChildList',
                                //contentType: 'application/json',
                                type: ""post"",
                                data: { childlist: deletelist },
                                success: function (e) {
                                    if (e === true) {
                                        layer.msg(""批量删除成功"", { icon: 6 });
                                        layer.close(menuchildaddindex);
                                        table.reload('LAY-mymenu-all');
                                    } else {
                                        layer.msg('批量删除失败', { icon: 5 });
                                    }
                                },
                                error: function (e) {
                                    layer.msg('批量删除异常', { icon: 2 });
                                }
             ");
            WriteLiteral(@"               });
                        });
                    } else {
                        layer.msg('口令错误', { icon: 2 });
                    }
                });
            }
            ,getCheckData: function () { //获取选中数据
                var checkStatus = table.checkStatus('LAY-myClient-all')
                    , data = checkStatus.data;
                active.getId(data)

                layer.alert(JSON.stringify(data));
            }
            , getId: function (data) {
                var idArr = [];
                for (var i = 0; i < data.length; i++) {
                    console.log(data[i].id)
                    idArr.push(data[i].id)
                }
                console.log(idArr)
            }
            , getCheckLength: function () { //获取选中数目
                var checkStatus = table.checkStatus('LAY-myClient-all')
                    , data = checkStatus.data;
                layer.msg('选中了：' + data.length + ' 个');
            }
            , is");
            WriteLiteral(@"All: function () { //验证是否全选
                var checkStatus = table.checkStatus('LAY-myClient-all');
                layer.msg(checkStatus.isAll ? '全选' : '未全选');
            }
            , add: function () { // 增加一条列表
                $.ajax({//编辑页面为局部页面
                    url: 'ManageMenu/AddMenuChild',
                    type: ""get"",
                    success: function (e) {
                        e = ""<div>"" + e + ""</div>"";
                        menuchildaddindex = layer.open({
                            title: '添加节点',
                            type: 1,
                            shadeClose: false,
                            area: admin.screen() < 2 ? ['80%', '300px'] : ['750px', '450px'],
                            content: e
                        });
                        form.render(null, 'component-form-addmenuchild');
                    }
                });
            }
        };
        $.ajax({
            url: 'ManageMenu/GetManageMenuTree',
            ");
            WriteLiteral(@"type: ""get"",
            success: function (e) {
                layui.tree({
                    elem: '#demo2' //指定元素
                    , target: '_blank' //是否新选项卡打开（比如节点返回href才有效）
                    , click: function (item) { //点击节点回调
                        var data = item;
                        if (data.jibie === 2) {
                            tableview.hide();
                            formview.show();
                            $.ajax({
                                url: 'ManageMenu/GetMenuChildItem?id=' + item.id,
                                type: ""get"",
                                success: function (e) {
                                    var getTplForm = formBox.innerHTML, viewForm = document.getElementById('viewForm');
                                    laytpl(getTplForm).render(e, function (html) {
                                        viewForm.innerHTML = html;
                                    });
                                    $(""[name='ForMenuID");
            WriteLiteral(@"'] option[value='"" + e.forMenuID + ""']"").attr(""selected"", ""true"");
                                    form.render(null, 'component-form-element');
                                }
                            });
                            //$.ajax({//编辑页面为局部页面
                            //    url: 'ManageMenu/EditMenuChild?childid=' + data.id,                            
                            //    type: ""get"",
                            //    success: function (e) {
                            //        console.log(e);
                            //        e = ""<div>"" + e + ""</div>"";
                            //        viewForm.innerHTML = e;              
                            //        form.render(null, 'component-form-element');
                            //    }
                            //});
                            //layer.open({//编辑页面为完整的，以iframe形式
                            //    type: 2,
                            //    area: ['900px', '700px'],
         ");
            WriteLiteral(@"                   //    fixed: false,
                            //    maxmin: true,
                            //    content: 'ManageMenu/EditMenuChild?childid=' + data.id,
                            //}); // 打开弹窗
                            element.render('breadcrumb', 'breadcrumb');
                            // 可根据传入的参数，数据请求显示相应的数据
                        }
                        else if (data.jibie === 1) {
                            tableview.hide();
                            formview.show();
                            $.ajax({
                                url: 'ManageMenu/GetMenuItem?id=' + item.id,
                                type: ""get"",
                                success: function (e) {
                                    var getTplForm = formBoxMenu.innerHTML, viewForm = document.getElementById('viewForm');
                                    laytpl(getTplForm).render(e, function (html) {
                                        viewForm.innerHTML = html;
     ");
            WriteLiteral(@"                               });
                                    form.render(null, 'component-form-managemenu');
                                    $(""#MenuIcon"").click(function () {
                                        $.ajax({
                                            url: 'ManageMenu/SelectLayuiIcon',
                                            type: ""get"",
                                            success: function (e) {
                                                var iconindex = layer.open({
                                                    title: '选择图标',
                                                    type: 1,
                                                    shadeClose: false,
                                                    area: admin.screen() < 2 ? ['80%', '300px'] : ['700px', '600px'],
                                                    content: e
                                                });
                                                $("".site-d");
            WriteLiteral(@"oc-icon li"").dblclick(function () {
                                                    console.log($(this).find("".doc-icon-fontclass"").html());
                                                    layer.close(iconindex);
                                                    $(""#MenuIcon"").val($(this).find("".doc-icon-fontclass"").html());
                                                });
                                            },
                                            error: function (e) {
                                                return layer.msg(""图标ICON视图请求异常"");
                                            }
                                        });
                                    });
                                }
                            });
                        }
                        else if (data.jibie === 0) {
                            tableview.show();
                            formview.hide();
                        }
                    }
       ");
            WriteLiteral(@"             , nodes: e.tree
                });
            },
            error: function (e) {
                return layer.msg(""请求数据出现异常"");
            }
        });
        //节点数据表格渲染
        table.render({
            elem: '#LAY-mymenu-all'
            , url: '/ManageMenu/GetAllManageMenuTable' //模拟接口
            , cellMinWidth: 60 //全局定义常规单元格的最小宽度
            , page: true // 开启分页
            , cols: [[ // 表头
                { type: 'checkbox' }
                // , {type: 'numbers', title: '#'}
                , { field: 'menuChildName', title: '节点名称', edit: 'text', templet: '<div>{{d.child.menuChildName}}</div>'}
                , { field: 'menuChildHref', title: '节点链接', edit: 'text', templet: '<div>{{d.child.menuChildHref}}</div>'}
                , { field: 'managerMenuChildID', title: '节点ID', edit: 'text', templet: '<div>{{d.child.managerMenuChildID}}</div>'}
                , { field: 'dataNameself', title: '数据名称(自身)', edit: 'text', templet: '<div>{{d.child.dataName}}</div>'}
");
            WriteLiteral(@"                , { field: 'menuName', title: '所属父级', edit: 'text', templet: '<div>{{d.menu.menuName}}</div>'}
                , { field: 'manageMenuID', title: '父级ID', edit: 'text', templet: '<div>{{d.menu.manageMenuID}}</div>'}
                , { field: 'menuIcon', title: '父级图标', edit: 'text', templet: '<div>{{d.menu.menuIcon}}</div>'}
                , { field: 'dataNameparent', title: '数据名称(父级)', templet: '<div>{{d.menu.dataName}}</div>'}
                , { field: 'userState', title: '节点状态', templet: tplStatus }
                , { field: 'operate', title: '操作', templet: tplOperate, width: 180, align: 'center' }
            ]]
            , skin: 'line'
            , done: function (res, curr, count) {
                console.log(res);
                console.log(curr);

                //得到数据总量
                console.log(count);
            }
        });
        $('.BigEdit').on('click', function () {//添加 删除 导出按钮事件
            var type = $(this).data('type');
            active[type]");
            WriteLiteral(@" ? active[type].call(this) : '';
        });

        //单行列的数据操作
        table.on('tool(LAY-mymenu-all)', function (obj) {
            var layEvent = obj.event,
                data = obj.data;
            console.log(data);
            if (layEvent === 'edit') { //编辑
                $.ajax({//编辑页面为局部页面
                    url: 'ManageMenu/EditMenuChild?childid=' + data.child.managerMenuChildID,                            
                    type: ""get"",
                    success: function (e) {
                        e = ""<div>"" + e + ""</div>"";
                        var menuchildeditindex = layer.open({
                            title: '编辑节点',
                            type: 1,
                            shadeClose: false,
                            area: admin.screen() < 2 ? ['80%', '300px'] : ['750px', '450px'],
                            content: e
                        });      
                         form.render(null, 'component-form-element');
                    ");
            WriteLiteral(@" }
                 });
            } else if (layEvent === 'del') { //删除
                layer.confirm('确定这个节点吗？', { icon: 3, title: '提示信息' }, function (index) {
                    $.ajax({
                        url: 'ManageMenu/DeleteMenuChildItem',
                        //contentType: 'application/json',
                        type: ""post"",
                        data: { childitem: data.child },
                        success: function (e) {
                            if (e === true) {
                                layer.msg(data.child.menuChildName+""节点删除成功"", { icon: 6 });
                                layer.close(menuchildaddindex);
                                table.reload('LAY-mymenu-all');
                            } else {
                                layer.msg(data.child.menuChildName +'节点删除失败', { icon: 5 });
                            }
                        },
                        error: function (e) {
                            layer.msg(data.child.me");
            WriteLiteral(@"nuChildName +'节点删除异常', { icon: 2 });
                        }
                    });
                    layer.msg(""删除成功"");
                });
            };
        });
        //节点编辑表单提交逻辑事件
        form.on('submit(component-form-element)', function(data){
            //layer.msg(JSON.stringify(data.field));
            $.ajax({
                url: 'ManageMenu/UpdataMenuChild',
                type: ""post"",
                data: data.field,
                success: function (e) {
                    if (e === 1) {
                        layer.msg(""更新成功"",{ icon: 6 });
                    } else {
                        layer.msg('更新失败', { icon: 5 }); 
                    }
                },
                error: function (e) {
                    layer.msg('更新失败', { icon: 2 }); 
                }
            });
            return false;
        });
        //菜单编辑表单提交逻辑事件
        form.on('submit(component-form-managemenu)', function (data) {
            $.ajax({
        ");
            WriteLiteral(@"        url: 'ManageMenu/UpdataMenu',
                type: ""post"",
                data: data.field,
                success: function (e) {
                    if (e === 1) {
                        layer.msg(""更新成功"", { icon: 6 });
                    } else {
                        layer.msg('更新失败', { icon: 5 });
                    }
                },
                error: function (e) {
                    layer.msg('更新失败', { icon: 2 });
                }
            });
            return false;
        });
        //节点添加表单提交逻辑事件
        form.on('submit(component-form-addmenuchild)', function (data) {
            $.ajax({
                url: 'ManageMenu/AddMenuChild',
                type: ""post"",
                data: data.field,
                success: function (e) {
                    if (e === 1) {
                        layer.msg(""更新成功"", { icon: 6 });
                        layer.close(menuchildaddindex);
                    } else {
                        layer.m");
            WriteLiteral(@"sg('更新失败', { icon: 5 });
                    }
                },
                error: function (e) {
                    layer.msg('更新失败', { icon: 2 });
                }
            });
            return false;
        });
    });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.LuoKiPetModels.ManageMenu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
