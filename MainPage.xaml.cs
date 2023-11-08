namespace RegistroEstudiante
{
    public partial class MainPage : ContentPage
    {
        private string titulo = "Registro";
        public Estudiante MiEstudiante { get; set; }
        public MainPage()
        {
            InitializeComponent();
            MiEstudiante = new Estudiante();
            BindingContext = MiEstudiante;
        }

        private void ConfirmarBtn_Clicked(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var mensaje = $"{MiEstudiante.Nombres} sus datos se ingresaron correctamente.";

                DisplayAlert(titulo, mensaje, "Ok");
            }
            
        }
        private bool IsValid()
        {
            if (string.IsNullOrEmpty(MiEstudiante.Nombres))
            {
                DisplayAlert(titulo, "Debe Ingresar un Nombre", "Ok");
                return false;
            }

            if (string.IsNullOrEmpty(MiEstudiante.Apellidos))
            {
                DisplayAlert(titulo, "Debe Ingresar un Apellido", "Ok");
                return false;
            }

            if (string.IsNullOrEmpty(MiEstudiante.Materia))
            {
                DisplayAlert(titulo, "Debe Ingresar un Materia", "Ok");
                return false;
            }

            return true; 
        }
    }
}