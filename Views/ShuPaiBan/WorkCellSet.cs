using Ay.Framework.WPF;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using TableTest.Models;

namespace TableTest.Controls
{

    [ContentProperty("Items")]
    [DefaultProperty("Items")]
    public class WorkCellSet : Button
    {
        public static readonly DependencyProperty PlacementProperty;
        static WorkCellSet()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WorkCellSet), new FrameworkPropertyMetadata(typeof(WorkCellSet)));
            PlacementProperty = ContextMenuService.PlacementProperty.AddOwner(typeof(WorkCellSet), new FrameworkPropertyMetadata(PlacementMode.Bottom, new PropertyChangedCallback(OnPlacementChanged)));
            IsContextMenuOpenProperty = DependencyProperty.Register("IsContextMenuOpen", typeof(bool), typeof(WorkCellSet), new FrameworkPropertyMetadata(false, new PropertyChangedCallback(OnIsContextMenuOpenChanged)));
        }


        public WorkCellSet()
        {
            Loaded += WorkSet_Loaded;
        }
        private void WorkSet_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= WorkSet_Loaded;
            if (this.ContextMenu != null)
            {

                foreach (var m1 in this.ContextMenu.Items)
                {
                    if (m1 is MenuItem m)
                    {
                        if (Value != "0")
                        {
                            if (m.Tag.ToString() == Value)
                            {
                                Content = m.Header.ToString();
                            }
                        }
                        else
                        {
                            Content = "";
                        }

                    }
                }
            }
            //第一次get值时候，不要触发修改
            firstInitialize = false;
        }

        public int ShiftType
        {
            get { return (int)GetValue(ShiftTypeProperty); }
            set { SetValue(ShiftTypeProperty, value); }
        }

        public static readonly DependencyProperty ShiftTypeProperty =
            DependencyProperty.Register("ShiftType", typeof(int), typeof(WorkCellSet), new PropertyMetadata(-2, new PropertyChangedCallback(OnShiftTypeChanged)));

        private static void OnShiftTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WorkCellSet cell)
            {
                var _addMenuItem1 = new MenuItem { Header = "不设置", Tag = "0" };
                _addMenuItem1.Click += cell.M_Click;
                var _addMenuItem2 = new MenuItem { Header = "停诊", Tag = "-1" };
                _addMenuItem2.Click += cell.M_Click;
                cell.Items.Add(_addMenuItem1);
                cell.Items.Add(_addMenuItem2);
                var shiftype = e.NewValue.ToString();
                List<SelectListItem> curr = null;
                if (shiftype == "1")
                {
                    curr = ShiftData.Instance.ShangWu;

                }
                else if (shiftype == "2")
                {
                    curr = ShiftData.Instance.XiaWu;

                }
                else if (shiftype == "3")
                {
                    curr = ShiftData.Instance.WanShang;

                }
                if (curr == null) return;
                foreach (var item in curr)
                {
                    var _addMenuItem = new MenuItem { Header = item.Text, Tag = item.Value };
                    _addMenuItem.Click += cell.M_Click;
                    cell.Items.Add(_addMenuItem);
                }
            }
        }

        private static void OnIsContextMenuOpenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            WorkCellSet s = (WorkCellSet)d;
            s.EnsureContextMenuIsValid();

            if (!s.ContextMenu.HasItems)
                return;

            bool value = (bool)e.NewValue;

            if (value && !s.ContextMenu.IsOpen)
                s.ContextMenu.IsOpen = true;
            else if (!value && s.ContextMenu.IsOpen)
                s.ContextMenu.IsOpen = false;
        }

        private static void OnPlacementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            WorkCellSet s = d as WorkCellSet;
            if (s == null) return;
            s.EnsureContextMenuIsValid();
            s.ContextMenu.Placement = (PlacementMode)e.NewValue;
        }

        //public WorkCellSet()
        //{
        //    Loaded += WorkSet_Loaded;
        //}
        public ItemCollection Items
        {
            get
            {
                if (WpfTreeHelper.IsInDesignMode)
                {
                    this.ContextMenu = new ContextMenu();
                    return this.ContextMenu.Items;
                }
                else
                {
                    EnsureContextMenuIsValid();
                    return this.ContextMenu.Items;
                }

            }
        }


        protected override void OnClick()
        {
            if (!this.ContextMenu.HasItems)
                return;

            var _menucount = this.ContextMenu.Items.Count;
            if (_menucount < 2) return;
            int idindex = 0;
            for (int i = 0; i < _menucount; i++)
            {
                if (this.ContextMenu.Items[i] is MenuItem m)
                {
                    var _1 = m.Tag.ToString();
                    if (_1 == Value)
                    {
                        idindex = i;
                        break;
                    }
                }
            }
            MenuItem _mi = null;
            if (idindex == _menucount - 1)
            {
                _mi = (this.ContextMenu.Items[0] as MenuItem);

            }
            else
            {
                _mi = (this.ContextMenu.Items[idindex + 1] as MenuItem);
            }
            var _tm = _mi.Header.ToString();
            if (_tm == "不设置")
            {
                this.Content = "";
                this.Value = _mi.Tag.ToString();
            }
            else
            {
                this.Content = _tm;
                this.Value = _mi.Tag.ToString();
            }

        }

        public bool IsContextMenuOpen
        {
            get { return (bool)GetValue(IsContextMenuOpenProperty); }
            set { SetValue(IsContextMenuOpenProperty, value); }
        }
        public static readonly DependencyProperty IsContextMenuOpenProperty;
        private void EnsureContextMenuIsValid()
        {
            if (this.ContextMenu == null)
            {
                this.ContextMenu = new ContextMenu();
                this.ContextMenu.PlacementTarget = this;
                this.ContextMenu.Placement = Placement;

                this.ContextMenu.Opened += ((sender, routedEventArgs) => IsContextMenuOpen = true);
                this.ContextMenu.Closed += ((sender, routedEventArgs) => IsContextMenuOpen = false);
            }
        }
        public PlacementMode Placement
        {
            get { return (PlacementMode)GetValue(PlacementProperty); }
            set { SetValue(PlacementProperty, value); }
        }



        private void M_Click(object sender, RoutedEventArgs e)
        {
            if (sender is MenuItem mi)
            {
                var _ts = mi.Header.ToString();
                if (_ts != "不设置")
                {
                    this.Content = _ts;
                    this.Value = mi.Tag.ToString();
                }
                else
                {
                    this.Content = "";
                    this.Value = "0";
                }

            }
        }


        public string Value
        {
            get { return (string)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(string), typeof(WorkCellSet), new PropertyMetadata("0", new PropertyChangedCallback(OnValueChanged)));

        bool firstInitialize = true;
        public void RaiseOnValueChanged(string oldValue,string newValue)
        {
            if (firstInitialize) return;
            // TODO 提交你的业务逻辑
            var _cellValue = DataContext as CellValue;
            //判断是新增 还是 修改 还是删除
            if (_cellValue.Schedule.Count > 0)
            {
                var _getsc = _cellValue.Schedule.FirstOrDefault(x => x.ShiftType == ShiftType);
                if (_getsc == null)
                {
                    //新增
                    Random ds = new Random();
                    //新增
                    Schedule news = new Schedule();
                    news.ScheduleId = ds.Next(1, 100000);
                    news.ScheduleTime = _cellValue.Date;
                    news.DoctorName = _cellValue.DoctorName;
                    news.DoctorId = _cellValue.DoctorId.ToInt();
                    news.ShiftType = ShiftType;
                    news.ShiftTypeName = ShiftData.Instance.GetShiftTypeName(news.ShiftType);
                    news.ShiftId = ds.Next(1, 100000);
                    news.ShiftName = Content.ToString();
                    news.IsStop = newValue == "-1";
                    try
                    {
                        MessageBox.Show("新增:" + news.ScheduleId.ToString() + " 医生:" + news.DoctorName + " 类型:" + news.ShiftTypeName + " (" + news.ShiftName + ") shiftid:" + news.ShiftId + ",IsStop=" + news.IsStop.ToString());
                    }
                    catch 
                    {

                      
                    }
                    
                }
                else
                {
                    try
                    {
                        if (newValue == "0")
                        {
                            //删除
                            MessageBox.Show("删除班次, 排班的唯一ID=:" + _getsc.ScheduleId);
                        }
                        else
                        {
                            //修改
                            MessageBox.Show("修改班次, 排班的唯一ID=:" + _getsc.ScheduleId + ",旧值shiftid:" + oldValue + ",新的shiftid" + newValue);
                        }
                    }
                    catch
                    {

                      
                    }
                   
                }
            }
            else
            {
                Random ds = new Random();
                //新增
                Schedule news = new Schedule();
                news.ScheduleId = ds.Next(1, 100000);
                news.ScheduleTime = _cellValue.Date;
                news.DoctorName = _cellValue.DoctorName;
                news.DoctorId = _cellValue.DoctorId.ToInt();
                news.ShiftType = ShiftType;
                news.ShiftTypeName = ShiftData.Instance.GetShiftTypeName(news.ShiftType);
                news.ShiftId = ds.Next(1, 100000);
                news.ShiftName = Content.ToString();
                news.IsStop = newValue == "-1";

                MessageBox.Show("新增:" + news.ScheduleId.ToString() + " 医生:" + news.DoctorName + " 类型:" + news.ShiftTypeName + " (" + news.ShiftName + ") shiftid:" + news.ShiftId + ",IsStop=" + news.IsStop.ToString());
            }
        }
        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WorkCellSet wc)
            {
                wc.RaiseOnValueChanged(e.OldValue.ToObjectString(), e.NewValue.ToObjectString());
            }
        }
    }
}
