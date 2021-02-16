using app2.Base;
using app2.Models;
using app2.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace app2.ViewModel
{
    public class RazaModel:ViewModelBase
    {
        RepositoryRaza repo;
        public RazaModel()
        {
            this.repo = new RepositoryRaza();
            this.Raza = new Raza();
        } 
        public Command InsetarRaza
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.InsertarRaza(this.Raza.Cod,
                        Raza.nombre, Raza.caracteristicas);
                });
            }
        }
        public Command ModificarRaza
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.ActualizarRaza(this.Raza.Cod,this.Raza.nombre, Raza.caracteristicas);

                });
            }
        }
        private Command EliminarRaza
        {
            get
            {
                return new Command(() =>
                {
                    this.repo.EliminarRaza(this.Raza.Cod);
                });
            }
        }
        private Raza _Raza;
        public Raza Raza
        {
            get { return this._Raza; }
            set
            {
                this._Raza = value;
                OnPropertyChanged("Raza");
            }
        }
    }
}
