namespace WinFormsTabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            this.muestraTabla();
        }

        private void muestraTabla()
        {
            int n = Convert.ToInt32(this.textBoxNum.Text);
            string tabla = "";
            for (int i = 1; i <= 10; i++)
            {
                if (n == 8)
                {
                    tabla = "AGARRAME EL CHOCHOOO";
                }
                else
                {
                    tabla = tabla + n + " x " + i + " = " + (n * i) + "\n";
                }
            }
            this.richTextResultados.AppendText(tabla);
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
