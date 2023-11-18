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

        private void InitializeComponent()
        {
            button = new Button();

            divider1 = new Label();
            divider2 = new Label();
            divider3 = new Label();

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
            });

            #endregion

            ResumeLayout(true);
        }
    }
}
