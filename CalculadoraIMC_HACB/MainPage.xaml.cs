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
            if (!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Peso.Text)) 
            {
                var peso = float.Parse(Peso.Text);
                var altura = float.Parse(Altura.Text);

                var imc = peso / (altura * altura);

                IMC.Text = imc.ToString();

                string resultado = "";
                if (imc < 18.5)
                {
                    resultado = "Tiene bajo peso";
                }
                else if (imc >= 18.5 && imc <= 29.9)
                {
                    resultado = "Tu peso es normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resultado = "Tiene sobre peso";
                }
                else
                {
                    resultado = "Tienes obesidad, cuidarte";
                }
                DisplayAlert("Resultado: ", resultado, "Quitar");
            }
            else
            {
                DisplayAlert("Datos erroneos", "Por favol, llena todo la informacion", "Quitar");
            }

        }
    }
}
