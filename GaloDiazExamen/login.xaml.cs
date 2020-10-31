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
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
            btnLogin.Clicked += BtnLogin_Clicked;
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            //variables para conprobar usuario y contraseña
            string user_validacion = "estudiante2020";
            string pass_validacion = "uisrael2020";

            if (user == user_validacion & pass == pass_validacion)
            {
                await Navigation.PushAsync(new Rgistro(user));

            }
            else
            {
                ErrorLabel.Text = "Usuario y contraseña invalidos";
            }
        }
    }
}