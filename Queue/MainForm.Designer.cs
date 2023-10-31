using System.Drawing;
using System.Windows.Forms;

namespace Queue
{
    partial class MainForm
    {
        private void InitializeComponent()
        {
            SuspendLayout();

            #region this

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Queueing Model";

            #endregion

            ResumeLayout(true);
        }
    }
}
