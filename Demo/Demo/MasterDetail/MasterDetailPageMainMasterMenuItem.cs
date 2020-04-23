using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo.MasterDetail
{

    public class MasterDetailPageMainMasterMenuItem : INotifyPropertyChanged
    {
        public MasterDetailPageMainMasterMenuItem()
        {
            TargetType = typeof(MasterDetailPageMainMasterMenuItem);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get; set; }
        public string Title { get; set; }
        public bool isActive { get; set; }
        public Type TargetType { get; set; }
    }
}