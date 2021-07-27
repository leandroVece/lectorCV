using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lector_de_cv
{
    public partial class Form1 : Form
    {
        //string Carpeta;
        private List<string> directorios = new List<string>();
        List<string> aceptados = new List<string>();
        List<string> rechazados = new List<string>();
        List<string> pendientes = new List<string>();
        List<string> mailAcep = new List<string>();
        List<string> mailRech = new List<string>();
        List<string> mailPend = new List<string>();


        public List<string> Aceptados1 { get => aceptados; set => aceptados = value; }
        public List<string> Rechazados1 { get => rechazados; set => rechazados = value; }
        public List<string> Pendientes1 { get => pendientes; set => pendientes = value; }
        public List<string> MailAcep { get => mailAcep; set => mailAcep = value; }
        public List<string> MailRech { get => mailRech; set => mailRech = value; }
        public List<string> MailPend { get => mailPend; set => mailPend = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_carpeta_Click(object sender, EventArgs e)
        {


            using (FolderBrowserDialog cajaDialogo = new FolderBrowserDialog())
            {

                //OpenFileDialog cajaDialogo = new OpenFileDialog();
                //cajaDialogo.AcceptFiles = false;

                DialogResult resultado = cajaDialogo.ShowDialog();


                if (!Directory.Exists(cajaDialogo.SelectedPath + "\\Aceptados"))
                {
                    Directory.CreateDirectory(cajaDialogo.SelectedPath + "\\Aceptados");
                    Directory.CreateDirectory(cajaDialogo.SelectedPath + "\\Pendientes");
                }

                textBox1.Text = cajaDialogo.SelectedPath;
                List<string> archivos = new List<string>();

                if (Directory.GetFiles(@textBox1.Text) == null)
                {
                    MessageBox.Show("carpeta vacia");
                }
                else
                {
                    foreach (string arch in Directory.GetFiles(@textBox1.Text))
                    {
                        if (Path.GetExtension(arch).ToLower() == ".pdf")
                        {
                            directorios.Add(arch);
                            string[] aux = arch.Split('\\');
                            archivos.Add(aux[aux.Length - 1]);

                        }
                    }

                    listaCv.DataSource = archivos;
                    archivos.Clear();
                }
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            Form2 pdf = new Form2(directorios);
            this.Hide();
            pdf.ShowDialog();
            directorios.Clear();
            Aceptados1 = nombre(pdf.Acep);
            Rechazados1 = nombre(pdf.Rech);
            Pendientes1 = nombre(pdf.Pend);
            MailAcep = pdf.MailAcep;
            MailPend = pdf.MailPend;
            MailRech = pdf.MailRech;


            list_acep.DataSource = Aceptados1;
            list_pend.DataSource = Pendientes1;
            list_desc.DataSource = Rechazados1;
            this.Show();
            pdf.Close();


        }

        private void list_acep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public List<string> nombre(List<string> lista)
        {
            List<string> retornar = new List<string>();
            foreach (string arch in lista)
            {
                string[] aux = arch.Split('\\');
                retornar.Add(aux[aux.Length - 1]);

            }
            return retornar;
        }

        private void btn_sig_Click(object sender, EventArgs e)
        {
            if (Aceptados1 != null)
            {
                mover(Aceptados1, @"\Aceptados\");
            }
            if (Pendientes1 != null)
            {
                mover(Pendientes1, @"\Pendientes\");
            }
            if (Rechazados1 != null)
            {
                eliminar(Rechazados1);
            }
            Form3 form = new Form3(MailAcep, MailRech, MailPend);
            this.Hide();
            form.ShowDialog();
            this.Show();
            //this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void mover(List<string> lista, string nueva)
        {
            foreach (string arch in lista)
            {
                //File.Copy(textBox1.Text + "\\" + arch, textBox1.Text + nueva + arch, true);
                File.Move(textBox1.Text + "\\" + arch, textBox1.Text + nueva + arch);

            }
        }

        public void eliminar(List<string> lista)
        {
            foreach (string arch in lista)
            {
                File.Delete(textBox1.Text + "\\" + arch);
            }
        }

        private void listaCv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
