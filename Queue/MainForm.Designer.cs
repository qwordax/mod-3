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

        private NumericUpDown upDown1;
        private NumericUpDown upDown2;

        private void InitializeComponent()
        {
            button = new Button();

            divider1 = new Label();
            divider2 = new Label();
            divider3 = new Label();

            upDown1 = new NumericUpDown();
            upDown2 = new NumericUpDown();

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
            divider3.Location = new Point(5, 358);
            divider3.Name = "divider3";
            divider3.Size = new Size(590, 2);

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
                upDown1,
                upDown2,
            });

            #endregion

            ResumeLayout(true);
        }
    }
}
