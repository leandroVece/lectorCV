using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lector_de_cv
{
    public partial class Form2 : Form
    {
        List<string> lista = new List<string>();
        List<string> acep = new List<string>();
        List<string> rech = new List<string>();
        List<string> pend = new List<string>();
        List<string> mailAcep = new List<string>();
        List<string> mailRech = new List<string>();
        List<string> mailPend = new List<string>();


        int i = 0, cont;



        public Form2()
        {
            InitializeComponent();

        }

        public Form2(List<string> pdf)
        {
            InitializeComponent();
            Lista = pdf;
            cont = pdf.Count;
            axAcroPDF1.src = Lista[i];
            leerPdf(Lista[i]);


        }

        public List<string> Lista { get => lista; set => lista = value; }
        public List<string> Acep { get => acep; set => acep = value; }
        public List<string> Rech { get => rech; set => rech = value; }
        public List<string> Pend { get => pend; set => pend = value; }
        public List<string> MailAcep { get => mailAcep; set => mailAcep = value; }
        public List<string> MailRech { get => mailRech; set => mailRech = value; }
        public List<string> MailPend { get => mailPend; set => mailPend = value; }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_acep_Click(object sender, EventArgs e)
        {
            Acep.Add(Lista[i]);
            MailAcep.Add(leerPdf(Lista[i]));
            i++;
            if (i < cont)
            {
                axAcroPDF1.src = Lista[i];
            }
            else
            {
                MessageBox.Show("No hay mas archivos");
                //Form1 form = new Form1();
                //form.Show();
                this.Close();
            }
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Rech.Add(Lista[i]);
            MailRech.Add(leerPdf(Lista[i]));
            i++;
            if (i < cont)
            {
                axAcroPDF1.src = Lista[i];
            }
            else
            {
                MessageBox.Show("No hay mas archivos");
                //Form1 form = new Form1(Acep, Rech, Pend, MailAcep, MailRech, MailPend);
                //form.Show();
                this.Close();
            }
        }

        private void btn_sig_Click(object sender, EventArgs e)
        {
            Pend.Add(Lista[i]);
            MailPend.Add(leerPdf(Lista[i]));
            i++;
            if (i < cont)
            {
                axAcroPDF1.src = Lista[i];
            }
            else
            {
                MessageBox.Show("No hay mas archivos");
                //Form1 form = new Form1(Acep, Rech, Pend, MailAcep, MailRech, MailPend);
                //form.Show();
                this.Close();
            }
        }

        //buscar el email de un pdf, solucion actual, pasar la primera pagina a un archivo txt
        //y de esa manera leerlo buscando la linea mail, (¿optimo?)
        string leerPdf(string directorio)
        {
            string[] array;

            string mail = "";

            var pdf = new PdfDocument(new PdfReader(directorio));
            var strategy = new LocationTextExtractionStrategy();


            string text = PdfTextExtractor.GetTextFromPage(pdf.GetPage(1));
            array = text.Split(' ');

            foreach (var a in array)
            {
                if (reconocerMail(a.Replace("\r\n", "").Replace("\n", "").Replace("\r", "")))
                {
                    mail = a.Replace("\r\n", "").Replace("\n", "").Replace("\r", "");
                    break;
                }
            }
            textBox1.Text = mail;
            pdf.Close();
            return mail;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private Boolean reconocerMail(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


    }
}
