using app2.Base;
using app2.Models;
using app2.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace app2.ViewModel
{
    public class RazaViewmodel: ViewModelBase
    {
        public RazaViewmodel()
        {
            RepositoryRaza repo = new RepositoryRaza();
            List<Raza> lista = repo.GetRazas();
            this.Razas = new ObservableCollection<Raza>(lista);
        }
        private ObservableCollection<Raza> _Razas;

        public ObservableCollection<Raza> Razas
        {
            get
            {
                return this._Razas;
            }
            set
            {
                this._Razas = value;
                OnPropertyChanged("Razas");
            }
        }
    }
}
