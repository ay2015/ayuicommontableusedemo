using System;
using System.Collections.ObjectModel;
using Ay.Framework.WPF.Controls;
using Ay.MvcFramework;
using AyTableViewDemo.Models;

namespace AyTableViewDemo.Controllers
{
    public class ViewStartController : Controller
    {
        private ObservableCollection<AyTreeViewItemModel> _LeftMenus = new ObservableCollection<AyTreeViewItemModel>();

        /// <summary>
        /// 主页 菜单
        /// </summary>
        public ObservableCollection<AyTreeViewItemModel> LeftMenus
        {
            get { return _LeftMenus; }
            set { Set(ref _LeftMenus, value); }
        }

        public ViewStartModel Model { get; set; }

        public ViewStartController() : base()
        {
            Model = new ViewStartModel();
            //AyTableViewDemo 1.0 功能列表
            AyTreeViewItemModel root1 = new AyTreeViewItemModel("基础服务", "", null, true);
            AyTreeViewItemModel root1_1 = new AyTreeViewItemModel("运行监控", "path_dashboard", root1, false, "/Views/Home/HomeView.xaml");
            //AyTreeViewItemModel root1_1 = new AyTreeViewItemModel("运行监控", "path_dashboard", root1, false, "/Views/RunMonitor/RunMonitorView.xaml");
            root1_1.IsSelected = true;
            AyTreeViewItemModel root1_2 = new AyTreeViewItemModel("字典管理", "path_jz", root1, false, "/Views/DicMgr/DicMgrView.xaml");
            AyTreeViewItemModel root1_3 = new AyTreeViewItemModel("缓存管理", "path_hc", root1, false, "/Views/CacheMgr/CacheMgrView.xaml");
            AyTreeViewItemModel root1_4 = new AyTreeViewItemModel("服务管理", "path_fw", root1, false, "/Views/ServiceMgr/ServiceMgrView.xaml");

            AyTreeViewItemModel root2 = new AyTreeViewItemModel("数据业务", "", null, false);
            AyTreeViewItemModel root2_1 = new AyTreeViewItemModel("项目管理", "path_xm", root2, false, "/Views/ServerProjectMgr/ServerProjectMgrView.xaml");
            AyTreeViewItemModel root2_2 = new AyTreeViewItemModel("数据接口", "path_sjjk", root2, false, "/Views/ApiMgr/ApiMgrView.xaml");
            AyTreeViewItemModel root2_3 = new AyTreeViewItemModel("文档管理", "path_wd", root2, false, "/Views/DocMgr/DocMgrView.xaml");

            AyTreeViewItemModel root3 = new AyTreeViewItemModel("服务支持", "", null, false);
            AyTreeViewItemModel root3_1 = new AyTreeViewItemModel("定时任务", "path_dsrw", root3, false, "/Views/TaskQz/TaskQzView.xaml");
            AyTreeViewItemModel root3_2 = new AyTreeViewItemModel("消息队列", "path_xxdl", root3, false, "/Views/MQMgr/MQMgrView.xaml");
            AyTreeViewItemModel root3_3 = new AyTreeViewItemModel("分布式存储", "path_fdfs", root3, false, "/Views/FdfsStorage/FdfsStorageView.xaml");
            AyTreeViewItemModel root3_4 = new AyTreeViewItemModel("节点管理", "path_nodemgr", root3, false, "/Views/MQMgr/MQMgrView.xaml");
            AyTreeViewItemModel root3_5 = new AyTreeViewItemModel("配置同步", "path_syncconfig", root3, false, "/Views/SyncConfig/SyncConfigView.xaml");

            AyTreeViewItemModel root4 = new AyTreeViewItemModel("安全中心", "", null, false);
            AyTreeViewItemModel root4_1 = new AyTreeViewItemModel("应用授权", "path_yysq", root4, false, "/Views/AppAuthoration/AppAuthorationView.xaml");
            AyTreeViewItemModel root4_2 = new AyTreeViewItemModel("拦截管理", "path_lanjie", root4, false, "/Views/ForbiddenMgr/ForbiddenMgrView.xaml");
            AyTreeViewItemModel root4_3 = new AyTreeViewItemModel("票据管理", "path_token", root4, false, "/Views/TokenMgr/TokenMgrView.xaml");
            AyTreeViewItemModel root4_4 = new AyTreeViewItemModel("日志查看", "path_logmgr", root4, false, "/Views/LogMgr/LogMgrView.xaml");
            LeftMenus.Add(root1);
            LeftMenus.Add(root2);
            LeftMenus.Add(root3);
            LeftMenus.Add(root4);












            ////系统1 AyTableViewDemo  存在服务器，  准备2台服务器，测试用的的ip和 正式服务器的ip
            //LeftMenus.Add(new ViewStartLeftMenuModel { Icon = "path_dashboard", Title = "运行状态" }); //首页看板，可以添加很多状态信息的快速浏览。
            //LeftMenus.Add(new ViewStartLeftMenuModel { Icon = "path_db", Title = "数据业务" }); //通过SQL处理业务 （脚本管理（新建(备注脚本)/修改/删除/复制/只读分享/测试发布/正式发布(高级权限) /
            //                                                                                //状态()）/数据库配置）
            //                                                                                //默认 AyTableViewDemo文件夹下的的脚本是 对客户端使用的脚本，提供系统2的服务
            //LeftMenus.Add(new ViewStartLeftMenuModel { Icon = "path_tasklist", Title = "定时任务" }); //手动管理任务，新建任务，立即执行
            //LeftMenus.Add(new ViewStartLeftMenuModel { Icon = "path_msg", Title = "消息队列" });//手动管理消息，把rabbitmq的web版本局部功能迁移cs版本。
            //LeftMenus.Add(new ViewStartLeftMenuModel { Icon = "path_cachepolicy", Title = "缓存管理" }); //手动管理缓存，管理缓存服务器，状态监测
            //LeftMenus.Add(new ViewStartLeftMenuModel { Icon = "path_filefdfs", Title = "分式存储" }); //分布式文件服务器  配置，状态监测，文件管理，上传/下载服务 启动关闭在服务管理中管理
            //                                                                                      //LeftMenus.Add(new ViewStartLeftMenuModel { Icon = "path_pcservicemgr", Title = "服务管理" }); //windows服务，快速管理   系统服务/windows服务
            //                                                                                      // LeftMenus.Add(new ViewStartLeftMenuModel { Icon = "path_pcservicemgr", Title = "FTP管理" }); //远程管理FTP，可选
            //                                                                                      //LeftMenus.Add(new ViewStartLeftMenuModel { Icon = "path_sessionmgr", Title = "会话管理" }); //管理用户登录与授权
            //LeftMenus.Add(new ViewStartLeftMenuModel { Icon = "path_secritymgr", Title = "安全中心" }); //ip黑名单，应用授权,
            //LeftMenus.Add(new ViewStartLeftMenuModel { Icon = "path_dicmgr", Title = "字典管理" }); //字典管理


            ////系统2 AYCT   可以客户端任意使用      ，默认提供全局的 I.M聊天功能，消息右下角弹窗，抖动 ，后期文件收发,发送邮件
            ////大致流程：   新建项目-> 会议讨论/新建接口 (PM的备注)-> 指派接口或者散派 -> 开发接口 -> 测试: 进入api生命周期 (待测试,已通过,不通过) ,正式发布
            ////产品经理 ,登陆AYCT，接口由AyTableViewDemo提供的。
            ////菜单:用户管理,项目管理,会议管理,接口管理（命名,备注,新建接口清单->加入安排会议)        接口操作=>指派,散派,编辑,删除，分享（给其他产品经理））
            ////流程管理 //系统配置， 测试服务器ip+端口    正式服务器 测试+端口
            //LeftMenus.Add(new ViewStartLeftMenuModel { Icon = "path_usermgr", Title = "用户管理" });//用户，用户组，权限，在这里统一提供 企业内部人员
            ////产品经理的 个人中心是 会议信息,项目信息
            //// 开发人员登陆系统，通过个人中心,可以查看分配的api任务
            ////接口任务,会议信息,项目信息, （开发,在AYCT中写脚本,上传截图,日志, 点击完成任务 (进入下一环节,基本是测试环节,也可以通过系统配置中，
            ////删除此环节，删除后，完成按钮变成发布测试，本地调试用的，如果状态是发布测试,可以发布正式。)）
            //LeftMenus.Add(new ViewStartLeftMenuModel { Icon = "path_personalcenter", Title = "个人中心" });
            //LeftMenus.Add(new ViewStartLeftMenuModel { Icon = "path_apishare", Title = "我的分享" });//接口/文件分享给其他开发人员，快速管理
            //LeftMenus.Add(new ViewStartLeftMenuModel { Icon = "path_filemy", Title = "我的文件" });//接收和发送的文件，快速管理,可以手动上传文件到 fdfs
            //LeftMenus.Add(new ViewStartLeftMenuModel { Icon = "path_versionmgr", Title = "持续发布" });//由管理人员登陆系统，选择项目，管理版本，升级策略。
            ////关于IM 中聊天面板       好友分组，组聊 两种，好友管理



        }


    }

}
