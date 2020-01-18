﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPet.subForms;
using System.Media;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace SistemaPet
{
    public partial class frmPrincipal : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        string pasta_aplicacao = "";
        public frmPrincipal()
        {
            InitializeComponent();
            pasta_aplicacao = Application.StartupPath + @"\";
        }
        private void ocutarPaineis()
        {
            panelSubMenuCadastrar.Visible = false;
            panelSubVendas.Visible = false;
            panelSubRelatorio.Visible = false;
            panelSubValores.Visible = false;

        }

        private void AbrirFormWrapper(object formwapper) 
        {
            if (this.panelWrapper.Controls.Count > 0)
                this.panelWrapper.Controls.RemoveAt(0);

            Form fh = formwapper as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelWrapper.Controls.Add(fh);
            this.panelWrapper.Tag = fh;
            fh.Show();
        }

        private void btnMenuCadastro_Click(object sender, EventArgs e)
        {
            if (panelSubMenuCadastrar.Visible == false)
            {
                showSubMenu(panelSubMenuCadastrar);
            }
            else
            {
                  hideSubMenu();    
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                bunifuT.Show(subMenu);
            }
            else
            {
                bunifuT.HideSync(subMenu);
            }
        }

        private void hideSubMenu() 
        {
            if (panelSubMenuCadastrar.Visible == true)
                 bunifuT.HideSync(panelSubMenuCadastrar);

            if (panelSubVendas.Visible == true)
                bunifuT.HideSync(panelSubVendas);

            if (panelSubRelatorio.Visible == true)
                bunifuT.HideSync(panelSubRelatorio);

            if (panelSubValores.Visible == true)
                bunifuT.HideSync(panelSubValores);
        }
        private void showSubmenu(Panel subMenu)
        { 
            if(subMenu.Visible == false) 
            {
                hideSubMenu();
                //subMenu.Visible = true;
                bunifuT.Show(subMenu);
            }
            else 
            {
                //subMenu.Visible = false;
                bunifuT.HideSync(subMenu);
            }
        }
        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
                                   
            if (panelSubVendas.Visible == false)
            {
               showSubMenu(panelSubVendas);    
                //panelSubMenuCadastrar.Visible = true;
                //bunifuT.Show(panelSubConfig);
            }
            else 
            {
                hideSubMenu();
                //panelSubConfig.Visible = false;
                //bunifuT.HideSync(panelSubConfig);
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string str = "" +  Convert.ToChar(174);
            lblFooter.Text = "PETS E PETS RAÇÕES E ACESSÓRIOS " + str + " CNPJ: 33.555.177/0001-03 | Fone: (92) 98433-8895";
            //string tmp = "0";
            //label1.Text = Convert.ToString($"Pets " + tmp.Replace("0","e" ) + " Pets");
            ocutarPaineis();
            bunifuTLog.Show(pictlogo);
            sond1();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmLogin frmLog = new frmLogin();
            this.Close();
            frmLog.Show();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AbrirFormWrapper(new frmUsuario());
        }
        private void sond1() 
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\Entrada.wav");
            player.Play();
        }        
        private void textPetsePets_Click_1(object sender, EventArgs e)
        {
            AbrirFormWrapper(new frmLogo());
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AbrirFormWrapper(new frmCliente());
        }
        private void btnMenuValores_Click(object sender, EventArgs e)
        {
            if (panelSubValores.Visible == false)
            {
                showSubMenu(panelSubValores);
            }
            else
            {
                hideSubMenu();
            }
        }
        private void btnMenuRelatorio_Click(object sender, EventArgs e)
        {
            if (panelSubRelatorio.Visible == false)
            {
                showSubMenu(panelSubRelatorio);
            }
            else
            {
                hideSubMenu();
            }
        }
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void bunifuFlatButton18_Click(object sender, EventArgs e)
        {
            AbrirFormWrapper(new frmRecibo());
        }
        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            AbrirFormWrapper(new frmCamera());
        }
        private void btnMenuFuncao_Click(object sender, EventArgs e)
        {
            AbrirFormWrapper(new frmFuncao());
        }
        private void btnMenuUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormWrapper(new frmUsuario());
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            frmLogin frmLog = new frmLogin();
            this.Close();
            frmLog.Show();
        }
        private void minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void restaurar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            maximizar.Visible = true;
            restaurar.Visible = false;
        }

        private void maximizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            restaurar.Visible = true;
        }
        private void bunifuFlatButton5_Click_1(object sender, EventArgs e)
        {
            AbrirFormWrapper(new frmCadastroPet());
        }
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            AbrirFormWrapper(new frmCliente());
        }

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.GreenYellow;
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.White;
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            ocutarPaineis();
            AbrirFormWrapper(new frmLogo());
        }
        
    }
}