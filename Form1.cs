namespace Cuesta_prestamo_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            Double Monto, Tasa_Interes, Cuotas, Total, Porcentaje;
            int Anos;

            Monto = Double.Parse(txt_Monto.Text);
            Anos = int.Parse(txt_Anos.Text);
            Porcentaje = Double.Parse(txt_Porcentaje.Text);

            Tasa_Interes = ((Monto * Porcentaje) / 100) * Anos;

            Total = Monto + Tasa_Interes;
            Cuotas = Total / (Anos * 12);


            txt_Tasa_Interes.Text = Tasa_Interes.ToString();
            txt_Cuotas.Text = Cuotas.ToString();
            txt_Total.Text = Total.ToString();


            double Interes = 0;
            double T_interes = 0;
            double T_cuotas = 0;
            double Capital = 0;
            double Saldo = Monto;

            for (int i = 1; i < Anos + 1 * 12; i++)
            {

                Capital -= Monto;
                T_cuotas += Cuotas;
                Interes = Math.Round(Saldo * Tasa_Interes / 12, 2);
                T_interes = Total;

                Monto = Math.Round(Cuotas - Interes, 2);
                Saldo -= Interes;


                dgb_amortizacion.Rows.Add(i.ToString(), Math.Round(Cuotas, 2), Capital, Interes, Math.Round(Saldo, 2));

            }
        }
    }
}
