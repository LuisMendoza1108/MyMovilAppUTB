using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyMovilApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(string nombre, string apellido, string correo, string telefono)
        {
            InitializeComponent();
            UserName.Text = $"Nombre: {nombre}";
            UserLastName.Text = $"Apellido: {apellido}";
            Email.Text = $"Correo: {correo}";
            cellphone.Text = $"Telefono: {telefono}";
        }
    }
}