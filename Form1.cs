using System.Windows.Forms;
using System.Xml.Serialization;
using ToDoList;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        private int NrFolder = 1;
        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        string currentfolderPath = "";
        string? IndexPath;
        private readonly List<AgendaItem> _agendaItemList = new List<AgendaItem>();

        public Form1()
        {
            InitializeComponent();

        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentfolderPath == "")
            {
                salvareCaToolStripMenuItem_Click(sender, e);
            }
            else
            {
                int ok = 0, nr = 1;
                var myObject = new AgendaItem();
                myObject.Nume = textBox1.Text;
                myObject.Descriere = textBox4.Text;
                myObject.Data = dateTimePicker1.Value;
                myObject.Prioritate = int.Parse(textBox4.Text);
                string filePath = currentfolderPath + @"\Nume" + nr.ToString();
                while (ok == 0)
                {
                    if (File.Exists(filePath))
                    {
                        ok = 0;
                        nr++;

                    }
                    else
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(AgendaItem));
                        using (TextWriter writer = new StreamWriter(filePath))
                        {
                            serializer.Serialize(writer, myObject);
                        }
                        ok = 1;
                    }
                    filePath = currentfolderPath + @"\Sarcina" + nr.ToString();
                }
                LoadLista();
                button1_Click(sender, e);
            }
        }

        private void nouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String PathFolder = folderPath + @"\Fisier " + NrFolder.ToString();
            while (Directory.Exists(PathFolder))
            {
                NrFolder++;
                PathFolder = folderPath + @"\Fisier " + NrFolder.ToString();
            }
            Directory.CreateDirectory(PathFolder);
            currentfolderPath = PathFolder;
            NrFolder++;
            LoadLista();
            ReadOnly();
        }

        private void adaugaSarcinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ok = 0, nr = 1;
            var myObject = new AgendaItem();
            myObject.Nume = "Sarcina " + nr.ToString();
            myObject.Descriere = "NULL";
            myObject.Data = DateTime.Now;
            myObject.Prioritate = -1;
            if (currentfolderPath == "")
            {
                MessageBox.Show("Nu poti avea o sarcina fara sa selectezi un fisier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string filePath = currentfolderPath + @"\Sarcina " + nr.ToString();
                while (ok == 0)
                {
                    if (File.Exists(filePath))
                    {
                        ok = 0;
                        nr++;
                    }
                    else
                    {
                        myObject.Nume = "Sarcina " + nr.ToString();
                        XmlSerializer serializer = new XmlSerializer(typeof(AgendaItem));
                        using (TextWriter writer = new StreamWriter(filePath))
                        {
                            serializer.Serialize(writer, myObject);
                        }
                        ok = 1;
                    }
                    filePath = currentfolderPath + @"\Sarcina " + nr.ToString();
                }
                LoadLista();
                ReadOnly();

            }
        }

        private void deschidereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.SelectedPath = folderPath;
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    currentfolderPath = folderDialog.SelectedPath;
                }
            }
            LoadLista();
            label6.Text = currentfolderPath;
        }

        private void editatiSarcinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox4.ReadOnly = false;
            dateTimePicker1.Enabled = true;
            textBox4.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentfolderPath == "")
                salvareCaToolStripMenuItem_Click(sender, e);

            if (textBox1.Text == "")
            {
                MessageBox.Show("Nu poti avea o sarcina fara nume", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                var myObject = new AgendaItem();
                myObject.Nume = textBox1.Text;
                myObject.Descriere = textBox4.Text;
                myObject.Data = dateTimePicker1.Value;

                if (File.Exists(IndexPath))
                {
                    File.Delete(IndexPath);
                }

                try
                {
                    myObject.Prioritate = int.Parse(textBox4.Text);
                }
                catch (Exception)
                {
                    myObject.Prioritate = -1;
                }

                XmlSerializer serializer = new XmlSerializer(typeof(AgendaItem));
                using (TextWriter writer = new StreamWriter(currentfolderPath + @"\" + textBox1.Text))
                {
                    serializer.Serialize(writer, myObject);
                }

                LoadLista();
                ReadOnly();
            }
        }

        private void LoadLista()
        {
            listBox1.Items.Clear();
            var directory = currentfolderPath;
            var files = Directory.GetFiles(directory);

            var agendaItems = new List<AgendaItem>();
            var serializer = new XmlSerializer(typeof(AgendaItem));

            foreach (var file in files)
            {
                using (var stream = new FileStream(file, FileMode.Open))
                {
                    var agendaItem = (AgendaItem)serializer.Deserialize(stream);
                    agendaItems.Add(agendaItem);
                }
            }

            var sortedAgendaItems = agendaItems.OrderBy(x => x.Data).ToList();

            foreach (var item in sortedAgendaItems)
            {
                listBox1.Items.Add(item.Nume);
            }
            label6.Text = currentfolderPath;
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexPath = currentfolderPath + @"\" + listBox1.SelectedItem.ToString();

            XmlSerializer serializer = new XmlSerializer(typeof(AgendaItem));

            using (FileStream fileStream = new FileStream(IndexPath, FileMode.Open))
            {
                AgendaItem? agendaItem = (AgendaItem?)serializer.Deserialize(fileStream);
                if (agendaItem.Prioritate != -1)
                {

                    textBox4.Text = agendaItem.Descriere.ToString();
                    dateTimePicker1.Value = agendaItem.Data;
                    textBox4.Text = agendaItem.Prioritate.ToString();
                }
                else
                    button1_Click(sender, e);

                textBox1.Text = agendaItem.Nume.ToString();
                dateTimePicker1.Value = agendaItem.Data;

            }
            LoadLista();
            ReadOnly();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox4.Clear();
        }

        private void sterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(IndexPath) && (currentfolderPath != ""))
            {
                File.Delete(IndexPath);
                LoadLista();
            }
            else
            {
                MessageBox.Show("Nu ati selectat un folder/Nu ati selectat o sacrina", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The program allows the user to create and manage a simple agenda of tasks or to-do items. It achieves this by allowing the user to create a new folder on their Desktop where they can store their tasks as XML files. The program then displays the contents of the folder in a ListBox, allowing the user to view, edit, and add new tasks.\r\n\r\nThe program uses the System.Xml.Serialization namespace to serialize and deserialize instances of a custom AgendaItem class. This class includes properties such as Nume (name), Descriere (description), Data (date), and Prioritate (priority) which are used to store information about each task.");
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salvareCaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolder = dialog.SelectedPath;
                string nume = "";
                nume = Microsoft.VisualBasic.Interaction.InputBox("Nume Folder", "Nume:");
                Directory.CreateDirectory(selectedFolder + @"\" + nume);
                currentfolderPath = selectedFolder + @"\" + nume;
                LoadLista();
                ReadOnly();
            }

        }
        private void ReadOnly()
        {
            textBox1.ReadOnly = true;
            textBox4.ReadOnly = true;
            dateTimePicker1.Enabled = false;
            textBox4.ReadOnly = true;
        }
        private void label6_TextChanged(object sender, EventArgs e)
        {
            label6.Show();
        }
    }
}
