using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace LissetteAguaizaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "El usuario conectado es " + usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double pago1 = Convert.ToDouble(txtPagoInicial.Text);
            if (pago1 < 100 & pago1 >2900) 
            {
                DisplayAlert("alerta", "valores correctos" , "CERRAR");
            } else
            {
                DisplayAlert("alerta", "los valores a ingresar deben ser mayores a 100 y menores a 2900", "CERRAR");
            }
            double valorfinal = 3000;
            double valorinteres = 3000 * 0.05;
            double pagoM;
            double pagomen;

            pagoM = pago1 / 5;
            pagomen = pagoM + valorinteres;

            lblPagomen.Text = "el pago mensual a pagar es de " + pagomen;

        }

        private async void btnGuardar_Clicked (object sender, EventArgs e)
        {
            await DisplayAlert("alerta", "Elemento guardado con exito", "CERRAR");

            await Navigation.PushAsync(new Resumen(txtNombre.Text, lblUsuario.Text, lblPagomen.Text));
        }
    }
}