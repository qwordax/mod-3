using System;
using System.Windows.Forms;

namespace Queue
{
    /// <summary>
    /// Represents the main window of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonClick(Object sender, EventArgs args)
        {
            Double first = (Double)upDown1.Value;
            Double second = (Double)upDown2.Value;

            Queue queue = new Queue(first, second);

            Int32 ticks = (Int32)upDown3.Value;

            for (Int32 i = 0; i < ticks; i++)
            {
                queue.NextState();
            }

            textBox1.Text = String.Format("{0:0.000}", (Double)queue.FailureCount / queue.RequestCount);
            textBox2.Text = String.Format("{0:0.000}", (Double)queue.QueueCount / queue.RequestCount);

            textBox3.Text = String.Format("{0}", queue.RequestCount);
            textBox4.Text = String.Format("{0}", queue.FailureCount);
            textBox5.Text = String.Format("{0}", queue.QueueCount);
        }
    }
}
