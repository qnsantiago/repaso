using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace repaso
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        string usuario;
        public Page2(string usuario)
        {
            InitializeComponent();
            lblusuario.Text = "USUARIO CONECTADO:" + usuario;
            this.usuario = usuario;
        }

        private void txtDato_TextChanged(object sender, TextChangedEventArgs e)
        {
            //rango 1 -100
            try
            {
                double dato = Convert.ToDouble(txtDato.Text);
                if(dato > 100)
                {
                    DisplayAlert("Alerta", "Fuera de rango", "Cerrar");
                    txtDato.Text = "";
                }

            }
            catch (Exception)
            {

                
            }
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            double dato = Convert.ToDouble(txtDato.Text);
            string estudiante = pkEstudiante.SelectedItem.ToString();

            Navigation.PushAsync(new Page3(usuario, dato, estudiante));

        }
    }
}