namespace Pauta_Tarea_1
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (txtLado.Text is null || txtLado.Text == "") {
                    DisplayAlert("ADVERTENCIA", "Debe ingresar el valor del lado del cuadrado", "Aceptar");
                } else
                {
                    double lado = double.Parse(txtLado.Text);
                    double area = lado * lado;
                    txtResultado.Text = $"Area del cuadrado: {area} cm";
                }
            } catch (Exception ex) {
                DisplayAlert("ERROR", ex.Message, "Aceptar");
            }
        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            txtLado.Text = "";
            txtResultado.Text = "";
        }

        private void btnCalcularAC_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (txtRadio.Text is null || txtRadio.Text == "")
                {
                    DisplayAlert("ADVERTENCIA", "Debe ingresar el valor del radio", "Aceptar");
                } else
                {
                    double radio = double.Parse(txtRadio.Text);
                    double area = Math.PI * Math.Pow(radio, 2);

                    txtResultadoAC.Text = $"Area del círculo: {area} cm";
                }

            } catch (Exception ex )
            {
                DisplayAlert("ERROR", ex.Message, "Aceptar");
            }
        }

        private void btnLimpiarAC_Clicked(object sender, EventArgs e)
        {
            txtRadio.Text = "";
            txtResultadoAC.Text = "";
        }

        private void btnCalcularAR_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (txtBase.Text is null || txtBase.Text == "")
                {
                    warning("Debe ingresar el valor de la base");
                } else if(txtAltura.Text is null || txtAltura.Text == "")
                {
                    warning("Debe ingresar el valor de la altura");
                } else
                {
                    double area = double.Parse(txtBase.Text) * double.Parse(txtAltura.Text);
                    txtResultadoAR.Text = $"Area del rectángulo: {area} cm";
                }
            } catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Aceptar");
            }
        }

        private void btnLimpiarAR_Clicked(object sender, EventArgs e)
        {
            txtBase.Text = "";
            txtAltura.Text = "";
            txtResultadoAR.Text = "";
        }

        private void warning(string mensaje)
        {
            DisplayAlert("ADVERTENCIA", mensaje, "Aceptar");
        }
    }

}
