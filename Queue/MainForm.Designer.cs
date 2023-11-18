using System.Drawing;
using System.Windows.Forms;

namespace Queue
{
    partial class MainForm
    {
        private Button button;

        private void InitializeComponent()
        {
            button = new Button();

            SuspendLayout();

            #region button

            button.Click += ButtonClick;
            button.Location = new Point(5, 365);
            button.Name = "button";
            button.Size = new Size(590, 30);
            button.Text = "Generate";

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
                button
            });

            #endregion

            ResumeLayout(true);
        }
    }
}
