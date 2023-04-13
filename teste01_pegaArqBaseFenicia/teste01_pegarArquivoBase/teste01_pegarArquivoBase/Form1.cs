using System.Runtime;

namespace teste01_pegarArquivoBase
{
    public partial class Form1 : Form
    {

        List<string> listaDiretoriosAcessados = new List<string>();

        public Form1()
        {
            InitializeComponent();

            string[] diretorios = Directory.GetDirectories("D:\\", "*", SearchOption.TopDirectoryOnly).Where(d => !d.StartsWith("D:\\FTP") && !d.StartsWith("D:\\Unimake_") && !d.StartsWith("D:\\_Instaladores") && !d.StartsWith("D:\\System") && !d.StartsWith("D:\\$R") && !d.StartsWith("D:\\Sua_")).ToArray();

            foreach (string listar in diretorios)
            {
                comboBox_listaBases.Items.Add(listar);
            }
        }

        private void comboBox_listaBases_SelectedValueChanged(object sender, EventArgs e)
        {
            string baseSelecionada = comboBox_listaBases.SelectedItem.ToString();

            listaDiretoriosAcessados.Add(baseSelecionada + @"\");

            toolStripStatusLabel_dados.Text = baseSelecionada;

            string[] diretorios = Directory.GetDirectories(baseSelecionada, "*", SearchOption.TopDirectoryOnly);
            string[] arquivos = Directory.GetFiles(baseSelecionada, "*", SearchOption.TopDirectoryOnly);

            listBox_listarDiretorio.Items.Clear();

            foreach (string listar in diretorios)
            {
                string[] ultimoNome = listar.Split('\\');

                listBox_listarDiretorio.Items.Add(ultimoNome[ultimoNome.Length - 1]);
            }

            foreach (string listar in arquivos)
            {
                listBox_listarDiretorio.Items.Add(Path.GetFileName(listar));
            }
        }


        private void listBox_listarDiretorio_DoubleClick(object sender, EventArgs e)
        {
            string caminhoRaiz = listaDiretoriosAcessados[listaDiretoriosAcessados.Count - 1];

            string selecao = listBox_listarDiretorio.SelectedItem.ToString();

            string valorSelecionado = caminhoRaiz + @"\" + selecao;

            toolStripStatusLabel_dados.Text = valorSelecionado;

            // Condicional abaixo serve para filtrar não gerar erro caso clique 2 vezes em um arquivo, pois não é um diretório.

            if (Path.GetExtension(valorSelecionado) == string.Empty)
            {

                string[] diretorios = Directory.GetDirectories(valorSelecionado, "*", SearchOption.TopDirectoryOnly);
                string[] arquivos = Directory.GetFiles(valorSelecionado, "*", SearchOption.TopDirectoryOnly);

                listaDiretoriosAcessados.Add(valorSelecionado);

                listBox_listarDiretorio.Items.Clear();

                foreach (string listar in diretorios)
                {
                    string[] ultimoNome = listar.Split('\\');

                    listBox_listarDiretorio.Items.Add(ultimoNome[ultimoNome.Length - 1]);
                }

                foreach (string listar in arquivos)
                {
                    listBox_listarDiretorio.Items.Add(Path.GetFileName(listar));
                }

                toolStripStatusLabel_dados.Text = valorSelecionado;
            }
            else
            {
                string diretorio = listaDiretoriosAcessados[listaDiretoriosAcessados.Count - 1];

                toolStripStatusLabel_dados.Text = valorSelecionado;
            }
        }


        private void button_voltar_Click(object sender, EventArgs e)
        {

            string valorSelecionado = listaDiretoriosAcessados[listaDiretoriosAcessados.Count - 2];

            string[] diretorios = Directory.GetDirectories(valorSelecionado, "*", SearchOption.TopDirectoryOnly);
            string[] arquivos = Directory.GetFiles(valorSelecionado, "*", SearchOption.TopDirectoryOnly);

            listaDiretoriosAcessados.Add(valorSelecionado);

            listBox_listarDiretorio.Items.Clear();

            foreach (string listar in diretorios)
            {
                string[] ultimoNome = listar.Split('\\');

                listBox_listarDiretorio.Items.Add(ultimoNome[ultimoNome.Length - 1]);
            }

            foreach (string listar in arquivos)
            {
                listBox_listarDiretorio.Items.Add(Path.GetFileName(listar));
            }

            toolStripStatusLabel_dados.Text = valorSelecionado;

        }

        private void button_mostraGlobal_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Mostrando valor para test");
        }

        private void button_fileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Selecione um arquivo";

            openFileDialog1.Filter = "Arquivo de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";

            openFileDialog1.InitialDirectory = @"D:\";

            toolStripStatusLabel_dados.Text = openFileDialog1.FileName;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            return;
        }
    }
}


