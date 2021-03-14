using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace BuscadorDatos
{
    public class Alumno: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string nombre = string.Empty;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (nombre == value)
                {
                    return;
                }
                nombre = value;
                onPropertyChanged(nameof(Nombre));
                onPropertyChanged(nameof(Mostrarnombre));
            }
        }
        public string Mostrarnombre => $"Nombre Ingresado:{Nombre}";

        void onPropertyChanged(string nombre)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

    }
}
