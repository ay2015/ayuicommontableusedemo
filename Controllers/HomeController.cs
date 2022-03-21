using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Ay.MvcFramework;
using AyTableViewDemo.Models;
using Ay.Framework.WPF.Controls;

namespace AyTableViewDemo.Controllers
{
    public class HomeController : Controller
    {
        private ObservableCollection<AyTreeViewItemModel> _LeftSubMenus = new ObservableCollection<AyTreeViewItemModel>();

        /// <summary>
        /// 主页 菜单
        /// </summary>
        public ObservableCollection<AyTreeViewItemModel> LeftSubMenus
        {
            get { return _LeftSubMenus; }
            set { Set(ref _LeftSubMenus, value); }
        }

        public HomeModel Model { get; set; }
        public HomeController() : base()
        {
            //AyTableViewDemo 1.0 功能列表
            //AyTreeViewItemModel root00 = new AyTreeViewItemModel("概述", "", null, false, "/Views/AyDataViewDemoIntro/AyDataViewDemoIntroView.xaml");

            AyTreeViewItemModel root202008 = new AyTreeViewItemModel("202008新增", "", null, true);
            AyTreeViewItemModel root202008_01 = new AyTreeViewItemModel("横排班", "", root202008, false, "/Views/HengPaiBan/HengPaiBanView.xaml");
            AyTreeViewItemModel root202008_02 = new AyTreeViewItemModel("竖排班", "", root202008, false, "/Views/ShuPaiBan/ShuPaiBanView.xaml");
            root202008_01.IsSelected = true;



            AyTreeViewItemModel root0121 = new AyTreeViewItemModel("历史新增", "", null, false);
            AyTreeViewItemModel root00120_0 = new AyTreeViewItemModel("滚动到底部加载", "", root0121, false, "/Views/ScrollToEndTableView/ScrollToEndTableViewView.xaml");
            AyTreeViewItemModel root00120_1 = new AyTreeViewItemModel("不可以手动拖动", "", root0121, false, "/Views/TestScrollviewer/TestScrollviewerView.xaml");
            AyTreeViewItemModel root00121_0 = new AyTreeViewItemModel("双击行", "", root0121, false, "/Views/DoubleClick/DoubleClickView.xaml");
            AyTreeViewItemModel root0121_0 = new AyTreeViewItemModel("单行Ctrl+C复制", "", root0121, false, "/Views/AyTableDemo23/AyTableDemo23View.xaml");
            AyTreeViewItemModel root0122_0 = new AyTreeViewItemModel("多行Ctrl+C复制", "", root0121, false, "/Views/AyTableDemo24/AyTableDemo24View.xaml");
            AyTreeViewItemModel root0123_0 = new AyTreeViewItemModel("多行Ctrl+C复制,粘贴", "", root0121, false, "/Views/AyTableDemo25/AyTableDemo25View.xaml");



            AyTreeViewItemModel root1 = new AyTreeViewItemModel("基本演示", "", null, false);
            AyTreeViewItemModel root1_0 = new AyTreeViewItemModel("基本表格", "", root1, false, "/Views/AyDataViewDemo2/AyDataViewDemo2View.xaml");
            AyTreeViewItemModel root01_0 = new AyTreeViewItemModel("百分比宽度1", "", root1, false, "/Views/AyTableDemo20/AyTableDemo20View.xaml");
            AyTreeViewItemModel root01_1 = new AyTreeViewItemModel("百分比宽度2", "", root1, false, "/Views/AyTableDemo21/AyTableDemo21View.xaml");

            AyTreeViewItemModel root1_1 = new AyTreeViewItemModel("行边框", "", root1, false, "/Views/AyDataViewDemo1/AyDataViewDemo1View.xaml");
            AyTreeViewItemModel root1_2 = new AyTreeViewItemModel("行选择", "", root1, false, "/Views/AyDataViewDemo0/AyDataViewDemo0View.xaml");
            AyTreeViewItemModel root1_3 = new AyTreeViewItemModel("复选框选择", "", root1, false, "/Views/AyDataViewDemo3/AyDataViewDemo3View.xaml");
            AyTreeViewItemModel root1_4 = new AyTreeViewItemModel("工具栏表格", "", root1, false, "/Views/AyDataViewDemo4/AyDataViewDemo4View.xaml");
            AyTreeViewItemModel root1_5 = new AyTreeViewItemModel("复杂工具栏", "", root1, false, "/Views/AyDataViewDemo5/AyDataViewDemo5View.xaml");

            AyTreeViewItemModel root2 = new AyTreeViewItemModel("二级难度", "", null, false);
            //AyTreeViewItemModel root2_1 = new AyTreeViewItemModel("本地行过滤", "", root2, false, "/Views/AyDataViewDemo6/AyDataViewDemo6View.xaml");
            //AyTreeViewItemModel root2_2 = new AyTreeViewItemModel("远程行过滤", "", root2, false, "/Views/AyDataViewDemo7/AyDataViewDemo7View.xaml");
            AyTreeViewItemModel root2_3 = new AyTreeViewItemModel("服务端分页,排序,换行", "", root2, false, "/Views/AyDataViewDemo8/AyDataViewDemo8View.xaml");

            //AyTreeViewItemModel root2_4 = new AyTreeViewItemModel("本地端分页", "", root2, false, "/Views/AyDataViewDemo9/AyDataViewDemo9View.xaml");
            //AyTreeViewItemModel root2_5 = new AyTreeViewItemModel("排序", "", root2, false, "/Views/AyDataViewDemo10/AyDataViewDemo10View.xaml");
            AyTreeViewItemModel root2_6 = new AyTreeViewItemModel("合并头冻结列", "", root2, false, "/Views/AyDataViewDemo11/AyDataViewDemo11View.xaml");

            AyTreeViewItemModel root2_7 = new AyTreeViewItemModel("列内容对齐", "", root2, false, "/Views/AyDataViewDemo12/AyDataViewDemo12View.xaml");
            AyTreeViewItemModel root2_9 = new AyTreeViewItemModel("格式化列", "", root2, false, "/Views/AyDataViewDemo14/AyDataViewDemo14View.xaml");
            AyTreeViewItemModel root01_2 = new AyTreeViewItemModel("动态列", "", root2, false, "/Views/AyTableDemo22/AyTableDemo22View.xaml");

            AyTreeViewItemModel root3 = new AyTreeViewItemModel("基础编辑", "", null, false);
            AyTreeViewItemModel root3_1 = new AyTreeViewItemModel("行详情", "", root3, false, "/Views/AyDataViewDemo15/AyDataViewDemo15View.xaml");
            //root3_1.IsSelected = true;
            AyTreeViewItemModel root3_2 = new AyTreeViewItemModel("行右键菜单", "", root3, false, "/Views/AyDataViewDemo19/AyDataViewDemo19View.xaml");

            AyTreeViewItemModel root3_3 = new AyTreeViewItemModel("行编辑验证", "", root3, false, "/Views/AyDataViewDemo17/AyDataViewDemo17View.xaml");
            //root3_3.IsSelected = true;

            //AyTreeViewItemModel root3_2 = new AyTreeViewItemModel("单元格编辑", "", root3, false, "/Views/AyDataViewDemo16/AyDataViewDemo16View.xaml");

            //AyTreeViewItemModel root3_3 = new AyTreeViewItemModel("行样式", "", root3, false, "/Views/AyDataViewDemo17/AyDataViewDemo17View.xaml");
            AyTreeViewItemModel root3_4 = new AyTreeViewItemModel("单元格样式", "", root3, false, "/Views/AyDataViewDemo18/AyDataViewDemo18View.xaml");
            //AyTreeViewItemModel root3_6 = new AyTreeViewItemModel("底行", "", root3, false, "/Views/AyDataViewDemo19/AyDataViewDemo19View.xaml");

            //AyTreeViewItemModel root3_7 = new AyTreeViewItemModel("合并单元格", "", root3, false, "/Views/AyDataViewDemo20/AyDataViewDemo20View.xaml");

            AyTreeViewItemModel root4 = new AyTreeViewItemModel("DIY风格", "", null, false);
            AyTreeViewItemModel root4_1 = new AyTreeViewItemModel("bootstrap风格", "", root4, false, "/Views/AyDataViewDiyBoostrap/AyDataViewDiyBoostrapView.xaml");

            //AyTreeViewItemModel root4_1 = new AyTreeViewItemModel("表头快捷菜单", "", root4, false, "/Views/AyDataViewDemo21/AyDataViewDemo21View.xaml");
            //AyTreeViewItemModel root4_2 = new AyTreeViewItemModel("卡片显示", "", root4, false, "/Views/AyDataViewDemo22/AyDataViewDemo22View.xaml");
            //AyTreeViewItemModel root4_3 = new AyTreeViewItemModel("大量数据", "", root4, false, "/Views/AyDataViewDemo23/AyDataViewDemo23View.xaml");

            //LeftSubMenus.Add(root00);

            LeftSubMenus.Add(root202008);
            LeftSubMenus.Add(root0121);
            LeftSubMenus.Add(root1);
            LeftSubMenus.Add(root2);
            LeftSubMenus.Add(root3);
            LeftSubMenus.Add(root4);



            TreeViewItemSelected = inParam =>
             {
                 //dynamic _can = inParam as object[];
                 //dynamic _0 = _can[0].DataContext;
                 AyTreeViewItemModel ami = inParam as AyTreeViewItemModel;
                 if (ami.IsNull()) return;
                 if (ami.ExtValue.IsNotNull())
                     SubPageSource = new Uri(ami.ExtValue.ToString(), UriKind.RelativeOrAbsolute);
             };
        }
        private Uri _SubPageSource;

        /// <summary>
        /// 子地址
        /// </summary>
        public Uri SubPageSource
        {
            get { return _SubPageSource; }
            set { Set(ref _SubPageSource, value); }
        }

        /// <summary>
        /// treeviewItem 选中事件
        /// </summary>
        public ActionResult TreeViewItemSelected { get; private set; }



    }
}
