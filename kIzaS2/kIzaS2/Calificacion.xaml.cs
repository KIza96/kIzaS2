using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kIzaS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calificacion : ContentPage
    {
        public Calificacion()
        {
            InitializeComponent();
        }

        private void Btncalculo_Clicked(object sender, EventArgs e)
        {
            double seguimiento1 = Convert.ToDouble(txtseguimiento1.Text) * 0.3;
            double examen1 = Convert.ToDouble(txtexamen1.Text) * 0.2;
            double parcial1 = seguimiento1 + examen1;
            txtparcial1.Text = parcial1.ToString();

            double seguimiento2 = Convert.ToDouble(txtseguimiento2.Text) * 0.3;
            double examen2 = Convert.ToDouble(txtexamen2.Text) * 0.2;
            double parcial2 = seguimiento2 + examen2;
            txtparcial2.Text = parcial2.ToString();

            double resultado = parcial1 + parcial2;
            txtnotafinal.Text = resultado.ToString();

            if (resultado >= 0.1 && resultado <= 4.9)
            {
                lblestado.Text = "Perdio semestre";
            }
            else if (resultado >= 5 && resultado <= 6.9)
            {
                lblestado.Text = "Complementario";
            }
            else if (resultado >= 7 && resultado <= 10)
            {
                lblestado.Text = "Aprobado";
            }
            else
            {
                    
            }
            
        }

        private void Txtseguimiento1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtseguimiento1.Text) > 10)
                {
                    DisplayAlert("MENSAJE", "SOLO NUMEROS DE 1 A 10", "ACEPTAR");
                }
            }
            catch (Exception)
            {

               
            }
        }

        private void Txtexamen1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtexamen1.Text) > 10)
                {
                    DisplayAlert("MENSAJE", "SOLO NUMEROS DE 1 A 10", "ACEPTAR");
                }
            }
            catch (Exception)
            {


            }
        }

        private void Txtseguimiento2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtseguimiento2.Text) > 10)
                {
                    DisplayAlert("MENSAJE", "SOLO NUMEROS DE 1 A 10", "ACEPTAR");
                }
            }
            catch (Exception)
            {


            }
        }

        private void Txtexamen2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtexamen2.Text) > 10)
                {
                    DisplayAlert("MENSAJE", "SOLO NUMEROS DE 1 A 10", "ACEPTAR");
                }
            }
            catch (Exception)
            {


            }
        }
    }
}