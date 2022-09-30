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
    public partial class Form2 : Form
    {
        TableLayoutPanel table;
        TextBox text;
        Label label;
        Label label2;
        Label l;
        Button start;
        public Form2()
        {
            table = new TableLayoutPanel
            {

                Dock = DockStyle.Fill,
                ColumnStyles = { new ColumnStyle(SizeType.Percent, 15), new ColumnStyle(SizeType.Percent, 75) },
                RowStyles = { new RowStyle(SizeType.Percent, 90), new RowStyle(SizeType.Percent, 10) },
                BorderStyle = BorderStyle.Fixed3D,
                AutoSize = false,
                

            };

            Button button = new Button { Text = "Math Quiz", Location = new Point(200, 50), BackColor = Color.White };
            Label label = new Label { Text = "Time Left", AutoSize = true, };
            label.Location = new Point(15, 15);
            Label label2 = new Label { BorderStyle = BorderStyle.FixedSingle, AutoSize = false, };
            label2.Location = new Point(80, 12);

            l_nimed = new string[5, 4];
            for (int i = 0; i < 4; i++)
            {
                table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
                for(int j = 0; j<5; j++)
                {
                    table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
                    var l_nimi = "L" + j.ToString() + i.ToString();
                    l_nimed[j, i] = l_nimi;
                    if (j == 1) { text = tehed[i]; }
                    else if (j == 3) { text = "="; }
                    else if (j == 4) { text = "vastus"; }
                    else { text = l_nimi; }
                    label l = new Label { Text = text };
                    table.Controls.Add(l, j, i);
                }
            }



            this.Controls.Add(start);
            this.Controls.Add(label);
            this.Controls.Add(label2);
            this.Controls.Add(table);
        }
    }
}
