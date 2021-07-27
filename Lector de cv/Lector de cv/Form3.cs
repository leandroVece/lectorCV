using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Lector_de_cv
{
    public partial class Form3 : Form
    {

        List<string> mailAcep = new List<string>();
        List<string> mailRech = new List<string>();
        List<string> mailPend = new List<string>();
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(List<string> mAcep, List<string> mRech, List<string> mPend)
        {
            InitializeComponent();

            mailAcep = mAcep;
            mailPend = mPend;
            mailRech = mPend;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //llamar a la funcion envio 3 veces y listo
            if (mailAcep.Count > 0)
            {   
                foreach(string correo in mailAcep)
                {
                    envios(correo,mensaje_a.Text);
                }

            }
            if (mailPend.Count > 0)
            {

                //envios(mensaje_p.Text, mailPend);

            }
            if (mailAcep.Count > 0)
            {
                //envios(mensaje_r.Text, mailRech);

            }

        }
        void envios(string mail,string body)
        {
            MailMessage correo = new MailMessage();
            correo.To.Add(mail);
            correo.From = new MailAddress(textBox1.Text);
            correo.Subject = textBox3.Text;
            correo.IsBodyHtml = checkBox1.Checked;
            correo.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(textBox1.Text, textBox2.Text);
            smtp.EnableSsl = checkBox2.Checked;
            smtp.Send(correo);


            //MailMessage email = new MailMessage(textBox1.Text,mail,textBox3.Text,body);
            //email.From = new MailAddress(textBox1.Text, textBox3.Text);

            /*foreach (string to in destinatarios)
            {
                email.To.Add(to);
            }

            email.Subject = textBox4.Text;
            email.SubjectEncoding = System.Text.Encoding.UTF8;

            email.Body = mensaje;
            email.BodyEncoding = System.Text.Encoding.UTF8;
            */
            /*email.IsBodyHtml = checkBox1.Checked;

            SmtpClient cliente = new SmtpClient("smtp.gmail.com");
            cliente.Credentials = new NetworkCredential(textBox1.Text, textBox2.PasswordChar.ToString());
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.EnableSsl = checkBox2.Checked;
            cliente.UseDefaultCredentials = false;
            cliente.Host = "smtp.gmail.com";
            cliente.Port = 587;*/

            try
            {

                smtp.Send(correo);
                smtp.Dispose();
            }
            catch(Exception e)
            {
                //MessageBox.Show("Error inesperado \r\n verifique que el Correo este escrito correctamente");
                //MessageBox.Show(e.ToString());
                mensaje_a.Text = e.ToString();
            }

        }

    }


}
