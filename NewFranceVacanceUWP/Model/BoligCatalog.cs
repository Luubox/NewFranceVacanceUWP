using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewFranceVacanceUWP.Persistency;

namespace NewFranceVacanceUWP.Model
{
    class BoligCatalog : PersistencyService
    {
        private static BoligCatalog _instance = new BoligCatalog();

        public static BoligCatalog Instance
        {
            get { return _instance; }
        }

        public ObservableCollection<Bolig> BoligListe { get; set; }

        private BoligCatalog()
        {
            BoligListe = new ObservableCollection<Bolig>();
            LoadBoligListeAsync();
        }

        private async void LoadBoligListeAsync()
        {
            var boligListe = await LoadBoligFromJsonAsync();
            if (boligListe != null)
            {
                foreach (var b in boligListe)
                {
                    BoligListe.Add(b);
                }
            }
            else
            {
                Bolig defaultBolig1 = new Bolig(2, 1, "Lejlighed", 1, 40, "testvej 1, 1234 testcity", 5.0, false);
                Bolig defaultBolig2 = new Bolig(4, 3, "Hytte", 2, 70, "testvej 2, 1234 testcity", 3.5, true);
                BoligListe.Add(defaultBolig1);
                BoligListe.Add(defaultBolig2);

                SaveBoligAsJsonAsync(BoligListe);
            }
        }

        public void Add(int antalPersoner, int antalSoveværelser, string type,
            int antalBadeværelser, int kvadratmeter, string adresse,
            double rating, bool husdyr)
        {
            BoligListe.Add(new Bolig(antalPersoner, antalSoveværelser, type,
                antalBadeværelser, kvadratmeter, adresse, rating, husdyr));
        }
    }
}
