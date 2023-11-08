using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante
{
    public class Estudiante: INotifyPropertyChanged
    {
        private string nombres;
        private string apellidos;
        private string materia;

        public string Nombres
        {
            get => nombres; set
            {
                nombres = value;
                this.OnPropertyChanged("Nombres");
            }
        }
        public string Apellidos
        {
            get => apellidos; set
            {
                apellidos = value;
                this.OnPropertyChanged("Apellidos");
            }
        }
        public string Materia
        {
            get => materia; set
            {
                materia = value;
                this.OnPropertyChanged(nameof(Materia));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propName)
        {
            this.PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propName));
        }
    }
}
