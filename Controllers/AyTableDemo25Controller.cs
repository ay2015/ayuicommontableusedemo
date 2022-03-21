using AyTableViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Ay.MvcFramework;
using Ay.Framework.WPF.Controls;
using Ay.Framework.DataCreaters;

namespace AyTableViewDemo.Controllers
{
    public class AyTableDemo25Controller : Controller
    {
        public ObservableCollection<AyPerson> Datas { get; set; } = new ObservableCollection<AyPerson>();
        public AyTableDemo25Controller()
        {
            for (int i = 0; i < 10; i++)
            {
                AyPerson Model = new AyPerson();
                Model.Name = "杨洋" + i.ToString();

                Model.Sex = AyCommon.Rnd.Next(5);
                Model.Telphone = AyPhone.PhoneNumber();
                Model.Address = AyAddress.Address();
                Datas.Add(Model);

            }
            TestCopy = inParam =>
            {
                var _2 = inParam.GetRouteArgs<AyTableViewRowsEventArgs>();
                if (_2.IsNotNull())
                {
                    var _3 = _2.Datas as List<object>;
                    StringBuilder sb = new StringBuilder();
                    foreach (var item in _3)
                    {
                        if (item is AyPerson p)
                        {
                            if (p.Sex == 0 || p.Sex == 1)
                                sb.AppendFormat("{0}\t{1}\t{2}\t{3}", p.Name, "男", p.Telphone, p.Address);
                            else if (p.Sex == 2)
                                sb.AppendFormat("{0}\t{1}\t{2}\t{3}", p.Name, "女", p.Telphone, p.Address);
                            else if (p.Sex == 3)
                                sb.AppendFormat("{0}\t{1}\t{2}\t{3}", p.Name, "不男不女", p.Telphone, p.Address);
                            else
                                sb.AppendFormat("{0}\t{1}\t{2}\t{3}", p.Name, "未知", p.Telphone, p.Address);
                            sb.AppendLine();
                        }

                    }
                    Clipboard.Clear();
                    Clipboard.SetData(DataFormats.Text, sb);
                }
            };
            TestPaste = inParam =>
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (iData.GetDataPresent(DataFormats.Text))
                {
                    string clipboardText = (string)iData.GetData(DataFormats.Text);
                    if (string.IsNullOrEmpty(clipboardText))
                    {
                        return;
                    }
                    //校验数据
                    //int colnum = 0;
                    //int rownum = 0;
                    //for (int i = 0; i < clipboardText.Length; i++)
                    //{
                    //    if (clipboardText.Substring(i, 1) == "\t")
                    //    {
                    //        colnum++;
                    //    }
                    //    if (clipboardText.Substring(i, 1) == "\n")
                    //    {
                    //        rownum++;
                    //    }
                    //}
                    //colnum = colnum / rownum + 1;
                    //int selectedRowIndex, selectedColIndex;

                    //selectedRowIndex = this.dataGridView1.CurrentRow.Index;
                    //selectedColIndex = this.dataGridView1.CurrentCell.ColumnIndex;
                    //if (selectedRowIndex + rownum > dataGridView1.RowCount || selectedColIndex + colnum > dataGridView1.ColumnCount)
                    //{
                    //    MessageBox.Show("粘贴区域大小不一致");
                    //    return;
                    //}
                    List<AyPerson> pps = new List<AyPerson>();
                    try
                    {
                        List<string> excelrows = clipboardText.Split(new string[] { "\n" }, StringSplitOptions.None).ToList();
          
                        //每一行按照\t分割
                        foreach (var item in excelrows)
                        {
                            if (item.IsNullAndTrimAndEmpty()) continue;
                            List<string> excelcols = item.Split(new string[] { "\t" }, StringSplitOptions.None).ToList();
                            AyPerson Model = new AyPerson();
                            Model.Name = excelcols[0];
                            if (excelcols[1] == "男")
                                Model.Sex = 1;
                            else if (excelcols[1] == "女")
                                Model.Sex = 2;
                            else if (excelcols[1] == "不男不女")
                                Model.Sex = 3;
                            else
                                Model.Sex = 4;

                            Model.Telphone = excelcols[2];
                            Model.Address = excelcols[3];
                            pps.Add(Model);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("剪切板的数据不符合格式", "错误");
                        return;
                    }
                    //设置取消选中
                    foreach (var item in Datas)
                    {
                        item.Selected = false;
                    }
                    foreach (var item in pps)
                    {
                        Datas.Add(item);
                        item.Selected = true;
                    }
   
                }
                else
                {
                    MessageBox.Show("剪贴板中数据不可转换为文本", "错误");
                }
            };
        }


        public ActionResult TestPaste { get; private set; }
        public ActionResult TestCopy { get; private set; }
    }
}