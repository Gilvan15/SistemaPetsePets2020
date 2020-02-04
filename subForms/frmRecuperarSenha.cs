using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Entidades;
using Model;
using SistemaPet.Utils;

namespace SistemaPet.subForms
{
    public partial class frmRecuperarSenha : Form
    {

        string pasta_aplicacao = "";
        public frmRecuperarSenha()
        {
            InitializeComponent();
            pasta_aplicacao = Application.StartupPath + @"\";

        }
        private void Fechar_Click_1(object sender, EventArgs e)
        {
            sound1();
            frmLogin frmLog = new frmLogin();
            this.Close();
            frmLog.Show();
        }
        public void sound1()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\click.wav");
            player.Play();
        }

        public void sound2()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\aviso.wav");
            player.Play();
        }
        public void sound3()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\salvar.wav");
            player.Play();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (FormatCnpjCpf.ValidarEmail(textEmail.Text) == false)
            {
                sound2();
                MessageBox.Show("Email com formato incorreto!","Aviso!!!", MessageBoxButtons.OK);
                return;
            }
            MailMessage mail = new MailMessage();
            string Textemail =  textEmail.Text;

            UsuarioEnt obj = new UsuarioEnt();
            obj.Email = Textemail;

            obj = new UsuarioModel().RecoverEmail(obj);

            if (obj.Email == null)
            {
                sound2();
                MessageBox.Show("Email inexistente!", "Aviso!", MessageBoxButtons.OK);
                return;
            }
            else 
            {
               // MessageBox.Show("Result: " + obj.Senha);
                try
                {
                    mail.From = new MailAddress("contatopetsepetsam@gmail.com");
                    mail.To.Add(Textemail); // para
                    mail.Subject = "Pets e Pets Recuperação Login"; // assunto
                    mail.Body = "Seu nome de Usuário é: " + obj.Username + ", sua Senha é: " + obj.Senha; // mensagem

                    using (var smtp = new SmtpClient("smtp.gmail.com"))
                    {
                        smtp.EnableSsl = true; // GMail requer SSL
                        smtp.Port = 587;       // porta para SSL
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
                        smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

                        // seu usuário e senha para autenticação
                        smtp.Credentials = new NetworkCredential("contatopetsepetsam@gmail.com", "!@#123petsepets");
                        // envia o e-mail
                        smtp.Send(mail);

                        sound3();
                        MessageBox.Show("Dados de LOGIN enviado para o Email informado!!!", "Aviso!!!", MessageBoxButtons.OK);
                        textEmail.Text = null;
                    }
                }
                catch (Exception ex)
                {
                    sound2();
                    MessageBox.Show("Error de envio:", ex.Message);
                }
                // em caso de anexos
                //mail.Attachments.Add(new Attachment(@"C:\teste.txt"));
            }
        }
        
    }
}
