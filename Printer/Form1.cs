using System.Drawing.Printing;
using System.Windows.Forms;

namespace Printer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClientesComboBox.Items.Clear();
            foreach (string file in Directory.GetFiles("D:\\Virtual Machine"))
            {
                try
                {
                    string[] fileInfo = file.Split('-');
                    if (fileInfo.Length == 3)
                    {
                        //"Rei da pizza-5x-1";
                        string path = fileInfo[0];
                        string Size = fileInfo[1];
                        int PrinterId = int.Parse(fileInfo[2].Split('.')[0]);
                        string name = path.Split('\\').Last();
                        ClientesComboBox.Items.Add(name);
                    }

                }
                catch { }
            }
            foreach (string printname in PrinterSettings.InstalledPrinters)
            {
                //listBox1.Items.Add(printname);
            }
        }

        private void PrintButton_Click_1(object sender, EventArgs e)
        {
            if (NumeroDeCaixasTextBox.Text == "")
            {
                MessageBox.Show("Insira a quantidade de caixas!", "Erro");
                return;
            }

            short NumPerPrinter = (short)(float.Parse(NumeroDeCaixasTextBox.Text) / 2);

            NumPerPrinter = (short)(NumPerPrinter / 5);

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintPage;
            pd.PrinterSettings.Copies = NumPerPrinter;
            //pd.PrinterSettings.PrinterName = "YOUR_PRINTER";
            pd.Print();
        }
        private void PrintPage(object o, PrintPageEventArgs e)
        {
            System.Drawing.Image img = System.Drawing.Image.FromFile("D:\\Foto.png");
            Point loc = new Point(0, 0);
            e.Graphics.DrawImage(img, loc);

            e.PageSettings.PaperSize.RawKind = (int)PaperKind.Custom;
            PaperSize size = new PaperSize();

            size.Width = img.Width;
            size.Height = img.Height;
            e.PageSettings.PaperSize = size;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientesComboBox.Items.Clear();
            foreach (string file in Directory.GetFiles("D:\\Virtual Machine"))
            {
                try
                {
                    string[] fileInfo = file.Split('-');
                    if (fileInfo.Length == 3)
                    {
                        //"Rei da pizza-5x-1";
                        string path = fileInfo[0];
                        string Size = fileInfo[1];
                        int PrinterId = int.Parse(fileInfo[2].Split('.')[0]);
                        string name = path.Split('\\').Last();
                        ClientesComboBox.Items.Add(name);
                    }

                }
                catch { }
            }
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckbox1.Checked)
            {
                OFFSET1Textbox.Visible = true;
                OFFSET2Textbox.Visible = true;
            }
            else
            {
                OFFSET1Textbox.Visible = false;
                OFFSET2Textbox.Visible = false;
            }

        }
    }
}
