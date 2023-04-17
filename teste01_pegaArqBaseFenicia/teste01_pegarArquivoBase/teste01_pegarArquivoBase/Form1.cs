using System.Runtime;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Diagnostics;
using System.Threading.Tasks;

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

            toolStripStatusLabel1.Text = "TESTE";
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

        public string fullPath;
        
        public void pegaArquivoListTree()
        {
            if (treeView_diretorios.SelectedNode != null)
            {
                // Cria uma lista para armazenar os nós selecionados
                List<string> nodes = new List<string>();

                // Adiciona o nome do nó selecionado à lista
                nodes.Add(treeView_diretorios.SelectedNode.Text);

                // Percorre os nós pai e adiciona seus nomes à lista
                TreeNode node = treeView_diretorios.SelectedNode.Parent;
                while (node != null)
                {
                    nodes.Insert(0, node.Text);
                    node = node.Parent;
                }

                // Cria uma string com o caminho completo do arquivo
                fullPath = Path.Combine(comboBox_listaBases.Text.ToString(), Path.Combine(nodes.ToArray()));

                // Exibe o caminho completo na barra de status
                // toolStripStatusLabel_dados.Text = fullPath;
            }
        }

        private void treeView_diretorios_DoubleClick(object sender, EventArgs e)
        {
            pegaArquivoListTree();

        }

        //private void button_download(object sender, EventArgs e)
        //{
        //    pegaArquivoListTree();

        //    string directory = "gdrive_tempUpload:";
        //    string caminhoPasta = fullPath;
        //    string command = $"C:\\script\\rclone-v1.58.1-windows-amd64\\rclone.exe copy {caminhoPasta} {directory} --drive-public-link";
        //    ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
        //    processInfo.CreateNoWindow = true;
        //    processInfo.UseShellExecute = false;
        //    processInfo.RedirectStandardOutput = true;

        //    Process process = new Process();
        //    process.StartInfo = processInfo;
        //    process.Start();

        //    string output = process.StandardOutput.ReadToEnd();

        //    string caminho = fullPath;
        //    string nomeDoArquivo = Path.GetFileName(caminho);


        //    geraLinkDrive();



        //}


        public void geraLinkDrive()
        {

            string caminho = fullPath;
            string nomeDoArquivo = Path.GetFileName(caminho);

            string directory = "gdrive_tempUpload:";
            string caminhoPasta = fullPath;
            // string command = $"C:\\script\\rclone-v1.58.1-windows-amd64\\rclone.exe link {directory} --include \"{nomeDoArquivo}\"";
            string command = $"C:\\script\\rclone-v1.58.1-windows-amd64\\rclone.exe link {directory}{nomeDoArquivo}";
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;

            Process process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();

            textBox_linkGdrive.Text = output;

        }

        private void button_download2_Click(object sender, EventArgs e)
        {
            pegaArquivoListTree();

            toolStripStatusLabel1.Text = String.Format("Fazendo UPLOAD do arquivo {0}, AGUARDE!...", nomeDoArquivo);


            string directory = "gdrive_tempUpload:";
            string caminhoPasta = fullPath;
            string command = $"C:\\script\\rclone-v1.58.1-windows-amd64\\rclone.exe copy {caminhoPasta} {directory}";
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;

            Process process = new Process();
            process.StartInfo = processInfo;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();

            string caminho = fullPath;
            string nomeDoArquivo = Path.GetFileName(caminho);

            Thread.Sleep(2000);

            geraLinkDrive();
        }

        private void button_copiarLink_Click(object sender, EventArgs e)
        {

        }
    }
}
