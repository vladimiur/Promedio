using System.Reflection.PortableExecutable;

namespace Promedio;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    // El codigo nos ayuda a sumar las 5 notas y las divide en 5 
    private void btncalcular_Clicked(object sender, EventArgs e)
    {
		if(!String.IsNullOrEmpty(nota1.Text) && !String.IsNullOrEmpty(nota2.Text) 
            && !String.IsNullOrEmpty(nota3.Text) && !String.IsNullOrEmpty(nota4.Text)
            && !String.IsNullOrEmpty(nota5.Text))
		{
            var ValorA = Convert.ToInt32(nota1.Text);
            var ValorB = Convert.ToInt32(nota2.Text);
            var ValorC = Convert.ToInt32(nota3.Text);
            var ValorD = Convert.ToInt32(nota4.Text);
            var ValorE = Convert.ToInt32(nota5.Text);
            double Resultado = (ValorA + ValorB + ValorC + ValorD + ValorE) / 5;
            final.Text = Convert.ToString(Resultado);
        }
		else
        {
            DisplayAlert("Error", "Introduce todos los numeros", "Ok");
        }
    }
}

