using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace TableTest.Models
{
    public class Humans : AyTableViewRowModel
    {
        public ObservableCollection<CellValue> Data { get; set; }
        public string ID { get; set; }

        private string _UserName;

        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName
        {
            get { return _UserName; }
            set { Set(ref _UserName, value); }
        }
        public Humans()
        {
            Data = new ObservableCollection<CellValue>();
        }
    }

}

