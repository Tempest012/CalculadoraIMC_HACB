using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMC_HACB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var peso = float.Parse(Peso.Text);
            var altura = float.Parse(Altura.Text);

            var imc=peso/(altura*altura);

            IMC.Text = imc.ToString();

        }
    }
}
