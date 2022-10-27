using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LissetteAguaizaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Loging : ContentPage
    {
        public Loging()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string usu = "Lissette2022";
            string contra = "uisrael2022";

            string tusu = txtUsuario.Text;
            string tcontra = txtContraseña.Text;

            if (usu == tusu & contra == tcontra)
            {

                await DisplayAlert("EROR", "USUARIO CORRECTO", "CERRAR");
                await Navigation.PushAsync(new Registro(txtUsuario.Text));
            }

            else
            {
                await DisplayAlert("EROR", "USUARIO O CONTRASEÑA INCORRECTA", "CERRAR");
            }
        }
    }
}