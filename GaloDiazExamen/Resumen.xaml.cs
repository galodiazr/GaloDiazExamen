using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GaloDiazExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, double total, string txtNombre)
        {
            InitializeComponent();
            txtUsuario.Text = usuario;
            txtEstudiante.Text = txtNombre;
            txtPagar.Text = total.ToString();
        }
    }
}