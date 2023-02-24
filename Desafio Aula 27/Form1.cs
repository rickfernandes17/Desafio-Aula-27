namespace Desafio_Aula_27
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e) => TxtMedia.Text = CalcularMedia().ToString();

        private float CalcularMedia()
        {
            float media, n1,n2;
            n1 = float.Parse(txtN1.Text);
            n2 = float.Parse(txtN2.Text);
            media = (n1+n2)/2;
            return media;
        }
    }
}