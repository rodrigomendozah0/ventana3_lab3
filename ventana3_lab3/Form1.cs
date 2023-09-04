namespace ventana3_lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad, adivinanzas;
            float premio, premio_total;

            edad = int.Parse(txtName.Text);
            adivinanzas = int.Parse(txtAdi.Text);
            premio = 0.0f;

            if (edad <= 17)
            {
                if (adivinanzas < 3)
                {
                    premio = 50f;
                }
                else
                {
                    premio = 80f;
                }
            }
            else if (edad >= 18)
            {
                if (adivinanzas < 3)
                {
                    premio = 30f;
                }
                else
                {
                    premio = 50f;
                }
            }
            premio_total = premio + (edad * 5) + (adivinanzas * 2);

            txtPremio.Text = Convert.ToString(premio_total);
        }
    }
}