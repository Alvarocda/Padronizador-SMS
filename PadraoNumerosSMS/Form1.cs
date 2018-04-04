using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadraoNumerosSMS
{
    public partial class Form1 : Form
    {
        public String NumerosCorrigidos { get; set; }
        public int QuantidadeNumeros { get; set; }
        public String MensagemPadronizada { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void PadronizaNumerosEMensagem(object sender, EventArgs e)
        {
            QuantidadeNumeros = TxtNumerosEntrada.Text.Split('\n').Length;
            NumerosCorrigidos = TxtNumerosEntrada.Text.Replace(System.Environment.NewLine, " ");
            TxtNumeroSaida.Text = NumerosCorrigidos;
            LabelTotalNumerosCorrigidos.Text = QuantidadeNumeros.ToString();
            byte[] byteTemporario;
            byteTemporario = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(TxtMensagemEntrada.Text);
            TxtMensagemSaida.Text = System.Text.Encoding.UTF8.GetString(byteTemporario);            
        }
        private void CopiaConteudoCorrigido(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(TxtNumeroSaida.Text);
            }catch(Exception)
            {
                MessageBox.Show("Você deve primeiro padronizar os numeros antes de tentar copialos","erro",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void CopiaMensagemPadronizada(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(TxtMensagemEntrada.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Você deve primeiro padronizar a mensagem antes de tentar copia-la", "erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void limparNumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtNumerosEntrada.Text = "";
        }

        private void limparMensagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtMensagemEntrada.Text = "";
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Ajuda().Show();
        }
    }
}
