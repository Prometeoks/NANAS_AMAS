using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaEntidad;
using CapaLogica;
//using SuperMarket_D.ALMACEN;

namespace NANAS_AMAS
{
    
    public partial class FormLogin : Form
    {
        private Timer timer;
        private Timer timer2;
        private int intentos = 3;
        public FormLogin()
        {
            InitializeComponent();

            timer = new Timer();
            
            timer.Interval = 300000; 
                                   
            timer.Tick += Timer_Tick;
            
            timer.Start();
        }
      


        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            timer2 = new Timer();
         
            timer2.Interval = 5000; 
                                  
            timer2.Tick += Timer2_Tick;
         
            timer2.Start();

            MessageBox.Show("Se vencio el tiempo de espera!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();

        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Placeholder or WaterMark
        //private void txtuser_Enter(object sender, EventArgs e)
        //{
        //    if (txtuser.Text == "Usuario")
        //    {
        //        txtuser.Text = "";
        //        //txtuser.ForeColor = Color.LightGray;
        //    }
        //}

        //private void txtuser_Leave(object sender, EventArgs e)
        //{
        //    if (txtuser.Text == "")
        //    {
        //        txtuser.Text = "Usuario";
        //        //txtuser.ForeColor = Color.Silver;
        //    }
        //}

        //private void txtpass_Enter(object sender, EventArgs e)
        //{
        //    if (txtpass.Text == "Contraseña")
        //    {
        //        txtpass.Text = "";
        //        //txtpass.ForeColor = Color.LightGray;
        //        txtpass.UseSystemPasswordChar = true;
        //    }
        //}

        //private void txtpass_Leave(object sender, EventArgs e)
        //{
        //    if (txtpass.Text == "")
        //    {
        //        txtpass.Text = "Contraseña";
        //        //txtpass.ForeColor = Color.Silver;
        //        txtpass.UseSystemPasswordChar = false;
        //    }
        //}

        #endregion 

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnlogin_Click_1(sender, e);
            }
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
          
            bool band = false;

            List<entUser> User = new List<entUser>();
            User = logUser.Instancia.ListarUser();

            for (int i = 0; i < User.LongCount(); i++)
            {
                if (txtuser.Text == User[i].username)
                {

                    if (txtpass.Text == User[i].contraseña)
                    {
                        timer.Stop();
                        FormMenu menu = new FormMenu();
                        //NotadeRequerimiento Nr = new NotadeRequerimiento();
                        //if (User[i].rolUsuario == 4)
                        //{
                        //    menu.UserLo = 'A';
                        //}
                        //else if (User[i].rolUsuario == 3)
                        //{
                        //    menu.UserLo = 'C';
                        //}
                        //else if (User[i].rolUsuario == 2)
                        //{
                        //    menu.UserLo = 'V';
                        //}
                        //menu.DniUser = User[i].dniUsuario;
                        //activo = User[i].activo;
                        //if (!activo)
                        //{
                        //    logUser.Instancia.LoginUser(User[i]);

                        menu.ShowDialog();
                        this.Visible = false;
                        //}
                        band = true;

                    }

                }
            }
            //if (activo)
            //{
            //    MessageBox.Show("EL USUARIO YA ESTA ACTIVO!");
            //    txtuser.Focus();
            //}

            if (band == false)
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA! \nNumero de intentos restantes: " + (intentos - 1), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtuser.Text = "";
                txtpass.Text = "";
                txtuser.Focus();
                intentos -= 1;
            }
            if (intentos == 0)
            {
                MessageBox.Show("SE HA ALCANZADO EL NUMERO MAXIMO DE INTENTOS!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();

            }
        }

        private void OjoCerrado_Click(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '\0';
            OjoCerrado.Visible = false;
        }

        private void btoncontras_Click(object sender, EventArgs e)
        {
            txtpass.PasswordChar = '*';
            OjoCerrado.Visible = true;
        }

      
    }
}
