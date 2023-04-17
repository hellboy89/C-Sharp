using System.Runtime;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Windows.Forms;

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

        private void FillTree(TreeNode node, string path)
        {
            // Cria um objeto DirectoryInfo para o diretório atual
            DirectoryInfo directory = new DirectoryInfo(path);

            // Adiciona um nó para cada subdiretório
            foreach (DirectoryInfo subDirectory in directory.GetDirectories())
            {
                TreeNode subNode = new TreeNode(subDirectory.Name);

                // Adiciona o nó filho ao nó atual
                node.Nodes.Add(subNode);

                // Chama o método recursivo para preencher os subdiretórios deste subdiretório
                FillTree(subNode, subDirectory.FullName);
            }

            // Adiciona um nó para cada arquivo
            foreach (FileInfo file in directory.GetFiles())
            {
                TreeNode fileNode = new TreeNode(file.Name);

                // Adiciona o nó filho ao nó atual
                node.Nodes.Add(fileNode);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string diretorio = comboBox_listaBases.Text.ToString();

            treeView_diretorios.Nodes.Clear();

            TreeNode rootNode = new TreeNode(diretorio);

            treeView_diretorios.Nodes.Add(rootNode);

            FillTree(rootNode, diretorio);
        }

        private void treeView_diretorios_DoubleClick(object sender, EventArgs e)
        {
            string arquivoSelecionado = treeView_diretorios.SelectedNode.ToString();

            toolStripStatusLabel_dados.Text = arquivoSelecionado;

        }
    }

}
