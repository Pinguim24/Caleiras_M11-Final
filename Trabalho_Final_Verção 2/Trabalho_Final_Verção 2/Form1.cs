using System.Drawing;
using System.Windows.Forms;

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
            panel2.Visible = false;
            panel4.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string nomePasta = "Faturas";

            string pastaProg = Environment.CurrentDirectory;

            string caminhoPasta = Path.Combine(pastaProg, nomePasta);

            if (!Directory.Exists(caminhoPasta))
            {
                Directory.CreateDirectory(caminhoPasta);
            }
            else
            {

            }
        }

        //Menu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                barrapreta.Height = button1.Height;
                barrapreta.Top = button1.Top;
                groupBox1.Visible = true;


                //Por tudo o que n é serviço invisivel
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox8.Visible = false;
            }
            catch
            {
                MessageBox.Show("Erro no Início", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                barrapreta.Height = button2.Height;
                barrapreta.Top = button2.Top;
                groupBox2.Visible = true;


                //Por tudo o que n é serviço invisivel
                groupBox1.Visible = false;
                groupBox3.Visible = false;
                groupBox8.Visible = false;
            }
            catch
            {
                MessageBox.Show("Erro em Serviços", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                barrapreta.Height = button3.Height;
                barrapreta.Top = button3.Top;
                groupBox3.Visible = true;


                //Por tudo o que n é produtos invisivel
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox8.Visible = false;
            }
            catch
            {
                MessageBox.Show("Erro em Produtos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("Erro no Carrinho", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //Botão Acerca de...
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("App feita por Tiago Condeço Cavalho 🐧 \n\n Trabalhador Mário Carvalho (Meu Pai)", "Acerca de...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro no Acerca de...", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Instalacao instalacao = new Instalacao();
                instalacao.Show();
            }
            catch
            {
                MessageBox.Show("Erro ao fazer o pedido", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Medicao medicao = new Medicao();
                medicao.Show();
            }
            catch
            {
                MessageBox.Show("Erro ao fazer pedido", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        Class3 cla3 = new Class3();


        //1
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                cla3.valor = 12;

                button8.Enabled = false;

                numericUpDown1.Value = 1;

                cla3.cont = 1;
            }
            catch
            {
                MessageBox.Show("Erro ao adicionar ao carrinho", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            try
            {
                cla3.valor2 = 2.5;

                button9.Enabled = false;

                numericUpDown2.Value = 1;

                cla3.cont2 = 1;
            }
            catch
            {
                MessageBox.Show("Erro ao adicionar ao carrinho", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            try
            {
                cla3.valor3 = 3;

                button10.Enabled = false;

                numericUpDown3.Value = 1;

                cla3.cont3 = 1;
            }
            catch
            {
                MessageBox.Show("Erro ao adicionar ao carrinho", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            try
            {
                cla3.valor4 = 9;

                button11.Enabled = false;

                numericUpDown4.Value = 1;

                cla3.cont4 = 1;
            }
            catch
            {
                MessageBox.Show("Erro ao adicionar ao carrinho", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            try
            {
                groupBox9.Visible = false;

                cla3.total = Math.Round(cla3.Total() - cla3.valor, 2);

                textBox1.Text = Convert.ToString(cla3.total + "€");

                numericUpDown1.Value = 0;
                cla3.valor = 0;
            }
            catch
            {
                MessageBox.Show("Erro ao remover", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox10.Visible = false;

                cla3.total = Math.Round(cla3.Total() - cla3.valor2, 2);

                textBox1.Text = Convert.ToString(cla3.total + "€");

                numericUpDown2.Value = 0;
                cla3.valor2 = 0;
            }
            catch
            {
                MessageBox.Show("Erro ao remover", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox11.Visible = false;

                cla3.total = Math.Round(cla3.Total() - cla3.valor3, 2);

                textBox1.Text = Convert.ToString(cla3.total + "€");

                numericUpDown3.Value = 0;
                cla3.valor3 = 0;
            }
            catch
            {
                MessageBox.Show("Erro ao remover", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox12.Visible = false;

                cla3.total = Math.Round(cla3.Total() - cla3.valor4, 2);

                textBox1.Text = Convert.ToString(cla3.total + "€");

                numericUpDown4.Value = 0;
                cla3.valor4 = 0;
            }
            catch
            {
                MessageBox.Show("Erro ao remover", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Botão pag_utilizador
        private void button17_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel5.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        //--------------------------------Página UTILIZADOR----------------------------


        private void button18_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        //feedback
        private void button21_Click(object sender, EventArgs e)
        {

            barrapreta2.Height = button21.Height;
            barrapreta2.Top = button21.Top;

            panel5.Visible = true;
            panel4.Visible = false;
        }

        public int i = 0;

        //enviar feedback
        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Ups parece que não escreveu nada no seu feedback", ":/", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //Nome do Ficheiro
                    i += 1;

                    string feedb = "FeedBack(" + i + ")";

                    string pastaProg = Environment.CurrentDirectory; //Serve pa encontrar o caminho em que o programa está a ser executado

                    //Para por tudo num caminho só
                    string caminhoFicheiro = Path.Combine(pastaProg, feedb + ".txt");


                    FileStream fs = new FileStream(caminhoFicheiro, FileMode.OpenOrCreate);

                    string texto = textBox2.Text;

                    if (fs.Length == 0)
                    {//ficheiro vazio

                        MessageBox.Show("A enviar...", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        StreamWriter sw = new StreamWriter(fs);

                        sw.Write(texto);

                        sw.Close();
                    }

                    fs.Close();

                    textBox2.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("\n\nErro ao enviar dados!!", "Erro");
                textBox2.Clear();
            }
        }

        //Faturas
        private void button20_Click(object sender, EventArgs e)
        {
            barrapreta2.Height = button20.Height;
            barrapreta2.Top = button20.Top;

            panel5.Visible = false;
            panel4.Visible = true;
        }

        //Botão finalizar pedido
        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                if (cla3.cont == 1 || cla3.cont2 == 1 || cla3.cont3 == 1 || cla3.cont4 == 1)
                {
                    i += 1;

                    string prod1 = "", prod2 = "", prod3 = "", prod4 = "";
                    double totalFat = cla3.Total();


                    if (cla3.cont == 1)
                    {
                        prod1 = "\n\nCaleira - Alumíno   12€ / metro" + "\nQuantidade:" + cla3.quant;
                    }
                    else if (cla3.cont == 0)
                    {
                        totalFat -= cla3.Quantidade();
                    }


                    if (cla3.cont2 == 1)
                    {
                        prod2 = "\n\nSuporte - Alto Inox   2,50€" + "\nQuantidade:" + cla3.quant2;
                    }
                    else if (cla3.cont2 == 0)
                    {
                        totalFat -= cla3.Quantidade2();
                    }


                    if (cla3.cont3 == 1)
                    {
                        prod3 = "\n\nPar de Topos -Alumínio   3€" + "\nQuantidade:" + cla3.quant3;
                    }
                    else if (cla3.cont3 == 0)
                    {
                        totalFat -= cla3.Quantidade3();
                    }


                    if (cla3.cont4 == 1)
                    {
                        prod4 = "\n\nTubo - Alumínio   9€ / metro" + "\nQuantidade:" + cla3.quant4;
                    }
                    else if (cla3.cont4 == 0)
                    {
                        totalFat -= cla3.Quantidade4();
                    }



                    //Nome do Ficheiro e da pasta
                    string fatura = "Fatura(" + i + ")";
                    string nomePasta = "Faturas";

                    string pastaProg = Environment.CurrentDirectory; //caminho da pasta onde está a ser executado

                    //Para por tudo num caminho só
                    string caminhoFinal = Path.Combine(pastaProg, nomePasta);
                    string caminhoFicheiro = Path.Combine(caminhoFinal, fatura + ".txt");

                    FileStream fs = new FileStream(caminhoFicheiro, FileMode.OpenOrCreate);

                    string texto = "\tMc Caleiras" + prod1 + prod2 + prod3 + prod4 + "\n\n\nTotal: " + totalFat + "€" + "\n\nObrigado pela sua compra :)";

                    if (fs.Length == 0)
                    {//ficheiro vazio
                        StreamWriter sw = new StreamWriter(fs);

                        MessageBox.Show("Compra finalizado com sucesso !!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        sw.Write(texto);

                        sw.Close();

                        //FAZER RESET
                        groupBox9.Visible = false;
                        groupBox10.Visible = false;
                        groupBox11.Visible = false;
                        groupBox12.Visible = false;

                        textBox1.Clear();

                        numericUpDown1.Value = 0;
                        numericUpDown2.Value = 0;
                        numericUpDown3.Value = 0;
                        numericUpDown4.Value = 0;

                        cla3.cont = 0;
                        cla3.cont2 = 0;
                        cla3.cont3 = 0;
                        cla3.cont4 = 0;
                    }
                    fs.Close();

                    dataGridView1.Rows.Add(fatura);
                }
                else
                {
                    MessageBox.Show("Impossível finalizar compra não tem nada no carrinho", "Erro catastrófico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("\n\nErro ao finalizar pedido!!", "Erro");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifica se a célula clicada é válida
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Obtém o valor da célula clicada
                    string valorCelula = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                    string nomePasta = "Faturas";

                    string pastaProg = Environment.CurrentDirectory; //caminho da pasta onde está a ser executado

                    //Para por tudo num caminho só
                    string caminhoFinal = Path.Combine(pastaProg, nomePasta);
                    string caminhoFicheiro = Path.Combine(caminhoFinal, valorCelula + ".txt");


                    if (valorCelula != null)
                    {
                        FileStream fs = new FileStream(caminhoFicheiro, FileMode.Open);

                        if (fs.Length != 0)
                        {//ficheiro não está vazio

                            StreamReader sr = new StreamReader(fs);

                            string texto;

                            texto = sr.ReadToEnd();

                            richTextBox1.Text = texto;

                            sr.Close();
                        }
                    }
                    else
                    {
                        // Se o valor da célula for nulo, limpa a TextBox
                        richTextBox1.Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro, essa célula já não deve existir");
            }

        }

        private void button23_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            dataGridView1.ClearSelection();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Eliminar uma fatura é ILEGAL", "SEU BURRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (textBox4.Text == "")
                    {
                        MessageBox.Show("Tem introduzir o nome da pasta !!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string nomePasta = "Faturas";

                        string pastaProg = Environment.CurrentDirectory; //caminho da pasta onde está a ser executado

                        string apagarF = textBox4.Text;

                        //Para por tudo num caminho só
                        string caminhoFinal = Path.Combine(pastaProg, nomePasta);
                        string caminhoFicheiro = Path.Combine(caminhoFinal, apagarF + ".txt");

                        if (File.Exists(caminhoFicheiro))
                        {
                            File.Delete(caminhoFicheiro);
                            MessageBox.Show("Ficheiro eliminado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("O ficheiro não existe.");
                        }

                        dataGridView1.Rows.Clear();
                        richTextBox1.Clear();
                        textBox4.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Boa escolha ;)", "Uff");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("\n\nErro ao eliminar o ficheiro!!" + "Erro");
            }
        }
    }
}
