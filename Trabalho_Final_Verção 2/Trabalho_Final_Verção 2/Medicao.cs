using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final_Verção_2
{
    public partial class Medicao : Form
    {
        Serviços2 cla2 = new Serviços2();

        public Medicao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cla2.Nome = Convert.ToString(textBox1.Text);
                cla2.Gmail = Convert.ToString(textBox2.Text);
                cla2.Morada = Convert.ToString(textBox4.Text);
                cla2.Tele = Convert.ToInt32(textBox3.Text);

                DialogResult result = MessageBox.Show(cla2.Meng(cla2.Nome, cla2.Gmail), "Formulário Marcação", MessageBoxButtons.OK, MessageBoxIcon.Information);


                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Erro ao finalizar pedido", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
