using System.Collections.ObjectModel;

namespace TableTest.Models
{
    public class Humans2 : AyTableViewRowModel
    {
        public ObservableCollection<CellValue2> Data { get; set; }
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
        public Humans2()
        {
            Data = new ObservableCollection<CellValue2>();
        }
    }

}

