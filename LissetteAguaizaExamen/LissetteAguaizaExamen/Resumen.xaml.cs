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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string totalP)
        {
            InitializeComponent();
            lblUsuario1.Text = "El nombre del estudiante es " + usuario;
            lblNombreEstudiante.Text = " " + nombre;
            lblTotal.Text = " " + totalP;
        }
    }
}