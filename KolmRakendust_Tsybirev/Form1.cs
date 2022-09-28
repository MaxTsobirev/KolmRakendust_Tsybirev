using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace KolmRakendust_Tsybirev
{
    public partial class Form1 : Form
    {
        TableLayoutPanel table;
        PictureBox pict;
        OpenFileDialog openFile = new OpenFileDialog
        {
            Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*",
            Title = "Select a Picture",
        };
        ColorDialog colorDialog = new ColorDialog{};
        public Form1()
        {
            this.Size = new Size(800, 600);
            table = new TableLayoutPanel
            {

                Dock = DockStyle.Fill,
                ColumnStyles = { new ColumnStyle(SizeType.Percent, 15), new ColumnStyle(SizeType.Percent, 85) },
                RowStyles = { new RowStyle(SizeType.Percent, 90), new RowStyle(SizeType.Percent, 10) }

            };
            pict = new PictureBox {
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.Fixed3D
            };
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();


            Button button1 = new Button{Text = "Close",AutoSize = true,};
            Button button2 = new Button{Text = "Set BG",AutoSize = true};
            Button button3 = new Button{Text = "Clear the picture",AutoSize = true};
            Button button4 = new Button{Text = "Show a picture",AutoSize = true};

            flowLayoutPanel.Controls.Add(button1);
            flowLayoutPanel.Controls.Add(button2);
            flowLayoutPanel.Controls.Add(button3);
            flowLayoutPanel.Controls.Add(button4);

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;

            table.Controls.Add(pict);
            table.Controls.Add(flowLayoutPanel);
            table.SetCellPosition(flowLayoutPanel, new TableLayoutPanelCellPosition(1, 1));
            this.Controls.Add(table);
            
        }

        private void Button4_Click(object? sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pict.Load(openFile.FileName);
            }
        }

        private void Button3_Click(object? sender, EventArgs e)
        {
            pict.Image = null;
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                pict.BackColor = colorDialog.Color;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pict.Load(openFile.FileName);
            }
        }
    }
}