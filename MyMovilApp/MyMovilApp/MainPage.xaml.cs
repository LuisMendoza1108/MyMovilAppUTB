using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyMovilApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            
        }
        private void lbl_nombre_Completed(object sender, EventArgs e)
        {
            progress.ProgressTo(.25, 250, Easing.Linear);
            lbl_progress.Text = "25%";
        }
        private void lbl_apellido_Completed(object sender, EventArgs e)
        {
            progress.ProgressTo(.5, 250, Easing.Linear);
            lbl_progress.Text = "50%";
        }
        private void lbl_correo_Completed(object sender, EventArgs e)
        {
            progress.ProgressTo(.75, 250, Easing.Linear);
            lbl_progress.Text = "75%";
        }
        private void lbl_telefono_Completed(object sender, EventArgs e)
        {
            progress.ProgressTo(1, 250, Easing.Linear);
            lbl_progress.Text = "100%";
        }
        private void lbl_apellido_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        private void lbl_correo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void lbl_telefono_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void lbl_nombre_TextChanged(object sender, TextChangedEventArgs e)
        {
            String nombre = lbl_nombre.Text.ToString();
            string cadena = $"Bienvenido {nombre}, complete el formulario";
            lbl_principal.Text = cadena;
        }
        private void cbox_terminos_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if(cbox_terminos.IsChecked)
                btn_registrar.IsEnabled = true;
            else
                btn_registrar.IsEnabled = false;
        }
        private void btn_registrar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Registro exitoso",$"Bienvenido {lbl_nombre.Text}", "Aceptar");
            Navigation.PushAsync(new Page1(lbl_nombre.Text, lbl_apellido.Text, lbl_correo.Text, lbl_telefono.Text));

        }
        private void limpiarRegistro()
        {
            lbl_nombre.Text = "";
            lbl_correo.Text = "";
            lbl_telefono.Text = "";
            lbl_correo.Text = "";
            progress.ProgressTo(0,250,Easing.Linear);


        }
    };
}
