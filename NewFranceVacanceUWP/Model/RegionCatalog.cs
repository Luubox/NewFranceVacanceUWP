using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFranceVacanceUWP.Model
{
    class RegionCatalog
    {
        private static RegionCatalog _instance = new RegionCatalog();
        public static RegionCatalog Instance
        {
            get { return _instance; }
        }

        public ObservableCollection<Region> RegionList { get; set; }

        public RegionCatalog()
        {
            RegionList = new ObservableCollection<Region>();
            //TODO: get from somewhere?
        }

        public void Add(string seværdigheder, string valuta, string info)
        {
            RegionList.Add(new Region(seværdigheder, valuta, info));
        }
    }
}
