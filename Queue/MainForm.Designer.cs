using System;
using System.Drawing;
using System.Windows.Forms;

namespace Queue
{
    partial class MainForm
    {
        private Button button;

        private Label divider1;
        private Label divider2;
        private Label divider3;
        private Label divider4;

        private NumericUpDown upDown1;
        private NumericUpDown upDown2;
        private NumericUpDown upDown3;

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;

        private void InitializeComponent()
        {
            button = new Button();

            divider1 = new Label();
            divider2 = new Label();
            divider3 = new Label();
            divider4 = new Label();

            upDown1 = new NumericUpDown();
            upDown2 = new NumericUpDown();
            upDown3 = new NumericUpDown();

            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();

            SuspendLayout();

            #region button

            button.Click += ButtonClick;
            button.Location = new Point(5, 365);
            button.Name = "button";
            button.Size = new Size(590, 30);
            button.Text = "Generate";

            #endregion

            #region divider1

            divider1.AutoSize = false;
            divider1.BorderStyle = BorderStyle.Fixed3D;
            divider1.Location = new Point(5, 75);
            divider1.Name = "divider1";
            divider1.Size = new Size(590, 2);

            #endregion

            #region divider2

            divider2.AutoSize = false;
            divider2.BorderStyle = BorderStyle.Fixed3D;
            divider2.Location = new Point(5, 152);
            divider2.Name = "divider2";
            divider2.Size = new Size(590, 2);

            #endregion

            #region divider3

            divider3.AutoSize = false;
            divider3.BorderStyle = BorderStyle.Fixed3D;
            divider3.Location = new Point(5, 316);
            divider3.Name = "divider3";
            divider3.Size = new Size(590, 2);

            #endregion

            #region divider4

            divider4.AutoSize = false;
            divider4.BorderStyle = BorderStyle.Fixed3D;
            divider4.Location = new Point(5, 358);
            divider4.Name = "divider4";
            divider4.Size = new Size(590, 2);

            #endregion

            #region upDown1

            upDown1.DecimalPlaces = 1;
            upDown1.Increment = (Decimal)0.1;
            upDown1.Location = new Point(400, 5);
            upDown1.Maximum = (Decimal)1.0;
            upDown1.Minimum = (Decimal)0.0;
            upDown1.Name = "upDown1";
            upDown1.Size = new Size(195, 30);
            upDown1.TextAlign = HorizontalAlignment.Right;
            upDown1.UpDownAlign = LeftRightAlignment.Right;

            upDown1.Value = (Decimal)0.5;

            #endregion

            #region upDown2

            upDown2.DecimalPlaces = 1;
            upDown2.Increment = (Decimal)0.1;
            upDown2.Location = new Point(400, 40);
            upDown2.Maximum = (Decimal)1.0;
            upDown2.Minimum = (Decimal)0.0;
            upDown2.Name = "upDown2";
            upDown2.Size = new Size(195, 30);
            upDown2.TextAlign = HorizontalAlignment.Right;
            upDown2.UpDownAlign = LeftRightAlignment.Right;

            upDown2.Value = (Decimal)0.5;

            #endregion

            #region upDown3

            upDown3.Location = new Point(400, 324);
            upDown3.Maximum = 10000000;
            upDown3.Minimum = 1;
            upDown3.Name = "upDown3";
            upDown3.Size = new Size(195, 30);
            upDown3.TextAlign = HorizontalAlignment.Right;
            upDown3.UpDownAlign = LeftRightAlignment.Right;

            upDown3.Value = 10000;

            #endregion

            #region textBox1

            textBox1.Location = new Point(400, 82);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(195, 30);
            textBox1.TabStop = false;
            textBox1.TextAlign = HorizontalAlignment.Right;

            #endregion

            #region textBox2

            textBox2.Location = new Point(400, 117);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(195, 30);
            textBox2.TabStop = false;
            textBox2.TextAlign = HorizontalAlignment.Right;

            #endregion

            #region textBox3

            textBox3.Location = new Point(400, 159);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(195, 30);
            textBox3.TabStop = false;
            textBox3.TextAlign = HorizontalAlignment.Right;

            #endregion

            #region textBox4

            textBox4.Location = new Point(400, 194);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(195, 30);
            textBox4.TabStop = false;
            textBox4.TextAlign = HorizontalAlignment.Right;

            #endregion

            #region textBox5

            textBox5.Location = new Point(400, 229);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(195, 30);
            textBox5.TabStop = false;
            textBox5.TextAlign = HorizontalAlignment.Right;

            #endregion

            #region this

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Queueing Model";

            Controls.AddRange(new Control[]
            {
                button,
                divider1,
                divider2,
                divider3,
                divider4,
                upDown1,
                upDown2,
                upDown3,
                textBox1,
                textBox2,
                textBox3,
                textBox4,
                textBox5,
            });

            #endregion

            ResumeLayout(true);
        }
    }
}
