using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolmRakendust_Tsybirev
{
        public partial class Login : Form
        {
        TextBox login = new TextBox { Location = new Point(200, 105),Height = 90, Width = 150 };
        TextBox password = new TextBox { Location = new Point(200, 165), Height = 90, Width = 150, UseSystemPasswordChar = true };

        public Login()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "Login";
            this.Size = new Size(500, 400);
            this.BackColor = Color.Gray;
            //asd

            Label label = new Label { Location = new Point(200, 30), Height = 50, Width = 170, Text = "Login vorm", };

            Label login2 = new Label { Location = new Point(50, 110), Height = 50, Width = 150, Text = "Login:" };

            Label pass = new Label { Location = new Point(50, 170), Height = 50, Width = 150, Text = "Password:" };

            Button loginbutton = new Button { Text = "Login", Location = new Point(250, 250), Width = 150, Height = 35, };

            Button regbutton = new Button { Text = "Register", Location = new Point(80, 250), Width = 150, Height = 35, };

            this.Controls.Add(label);
            this.Controls.Add(login);
            this.Controls.Add(pass);
            this.Controls.Add(login2);
            this.Controls.Add(password);
            this.Controls.Add(loginbutton);
            this.Controls.Add(regbutton);

            loginbutton.Click += Loginbutton_Click;
            regbutton.Click += Regbutton_Click;
        }

        private void Regbutton_Click(object? sender, EventArgs e)
        {
            Reg reg = new Reg();
            reg.ShowDialog();
        }

        private void Loginbutton_Click(object? sender, EventArgs e)
        {
            StartForm start = new StartForm();
            start.ShowDialog();
        
        }

    }
}
