using System.Drawing;

namespace Trabalho_Final_Verção_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox8.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //Menu
        private void button1_Click(object sender, EventArgs e)
        {
            barrapreta.Height = button1.Height;
            barrapreta.Top = button1.Top;
            groupBox1.Visible = true;


            //Por tudo o que n é serviço invisivel
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox8.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            barrapreta.Height = button2.Height;
            barrapreta.Top = button2.Top;
            groupBox2.Visible = true;


            //Por tudo o que n é serviço invisivel
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox8.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            barrapreta.Height = button3.Height;
            barrapreta.Top = button3.Top;
            groupBox3.Visible = true;


            //Por tudo o que n é produtos invisivel
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox8.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            barrapreta.Height = button4.Height;
            barrapreta.Top = button4.Top;


            //Por tudo o que n é carrinho invisivel
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;


            //Mostrar Coisas do Carrinho
            groupBox8.Visible = true;


            //Ocultar tudo o resto
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;


            //Verificar se o botão foi usado

            if (cla3.cont == 1)
            {
                groupBox9.Visible = true;
            }

            if (cla3.cont2 == 1)
            {
                groupBox10.Visible = true;
            }

            if (cla3.cont3 == 1)
            {
                groupBox11.Visible = true;
            }

            if (cla3.cont4 == 1)
            {
                groupBox12.Visible = true;
            }

            textBox1.Text = Convert.ToString(cla3.Total() + "€");
        }


        //Botão Acerca de...
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App feita por Tiago Condeço Cavalho 🐧 \n\n Trabalhador Mário Carvalho (Meu Pai)");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Instalacao instalacao = new Instalacao();
            instalacao.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Medicao medicao = new Medicao();
            medicao.Show();
        }


        Class3 cla3 = new Class3();


        //1
        private void button8_Click(object sender, EventArgs e)
        {
            cla3.valor = 12;

            button8.Enabled = false;

            numericUpDown1.Value = 1;

            cla3.cont = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            cla3.quant = (int)numericUpDown1.Value;

            cla3.Quantidade();

            if (cla3.quant == 0)
            {
                button8.Enabled = true;
                numericUpDown1.Enabled = false;

                cla3.valor = 0;
                cla3.cont = 0;
            }

            else if (cla3.quant != 0)
            {
                numericUpDown1.Enabled = true;
            }
        }



        //2
        private void button9_Click(object sender, EventArgs e)
        {
            cla3.valor2 = 2.5;

            button9.Enabled = false;

            numericUpDown2.Value = 1;

            cla3.cont2 = 1;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            cla3.quant2 = (int)numericUpDown2.Value;

            cla3.Quantidade2();

            if (cla3.quant2 == 0)
            {
                button9.Enabled = true;
                numericUpDown2.Enabled = false;

                cla3.valor2 = 0;
                cla3.cont2 = 0;
            }

            else if (cla3.quant2 != 0)
            {
                numericUpDown2.Enabled = true;
            }
        }



        //3
        private void button10_Click(object sender, EventArgs e)
        {
            cla3.valor3 = 3;

            button10.Enabled = false;

            numericUpDown3.Value = 1;

            cla3.cont3 = 1;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            cla3.quant3 = (int)numericUpDown3.Value;

            cla3.Quantidade3();

            if (cla3.quant3 == 0)
            {
                button10.Enabled = true;
                numericUpDown3.Enabled = false;

                cla3.valor3 = 0;
                cla3.cont3 = 0;
            }

            else if (cla3.quant3 != 0)
            {
                numericUpDown3.Enabled = true;
            }
        }



        //4
        private void button11_Click(object sender, EventArgs e)
        {
            cla3.valor4 = 9;

            button11.Enabled = false;

            numericUpDown4.Value = 1;

            cla3.cont4 = 1;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            cla3.quant4 = (int)numericUpDown4.Value;

            cla3.Quantidade4();

            if (cla3.quant4 == 0)
            {
                button11.Enabled = true;
                numericUpDown4.Enabled = false;

                cla3.valor4 = 0;
                cla3.cont4 = 0;
            }

            else if (cla3.quant4 != 0)
            {
                numericUpDown4.Enabled = true;
            }
        }



        //Remover
        private void button12_Click(object sender, EventArgs e)
        {
            groupBox9.Visible = false;

            cla3.total = Math.Round(cla3.Total() - cla3.valor, 2);

            textBox1.Text = Convert.ToString(cla3.total);

            numericUpDown1.Value = 0;
            cla3.valor = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            groupBox10.Visible = false;

            cla3.total = Math.Round(cla3.Total() - cla3.valor2, 2);

            textBox1.Text = Convert.ToString(cla3.total);

            numericUpDown2.Value = 0;
            cla3.valor2 = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            groupBox11.Visible = false;

            cla3.total = Math.Round(cla3.Total() - cla3.valor3, 2);

            textBox1.Text = Convert.ToString(cla3.total);

            numericUpDown3.Value = 0;
            cla3.valor3 = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            groupBox12.Visible = false;

            cla3.total = Math.Round(cla3.Total() - cla3.valor4, 2);

            textBox1.Text = Convert.ToString(cla3.total);

            numericUpDown4.Value = 0;
            cla3.valor4 = 0;
        }
    }
}