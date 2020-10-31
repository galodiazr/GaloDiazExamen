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
    public partial class Rgistro : ContentPage
    {
        public double total;
        public string usuario;
        public double costo=1800;
        public Rgistro(string user)
        {
            InitializeComponent();
            this.usuario = user;

        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double inicial = Convert.ToDouble(txtInicial.Text);
            double cuota = ((this.costo - inicial) / 3) * 1.05;
            txtPmensual.Text = cuota.ToString();
            this.total = cuota * 3;
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Resumen(this.usuario, this.total, txtNombre.Text));
        }
    }
}