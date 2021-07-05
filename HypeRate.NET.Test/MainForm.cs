using System;
using System.Windows.Forms;
using HypeRate.NET;

namespace HypeRate.NET.Test
{
    public partial class MainForm : Form
    {
        private HeartRate hypeRate = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void SubscribeButton_Click(object sender, EventArgs e)
        {
            if (hypeRate == null)
            {
                hypeRate = new HeartRate(SessionIDInput.Text);
                hypeRate.Subscribe();
            }
            else { MessageBox.Show("hypeRate is already defined! Did you mean to unsubscribe?"); }
        }

        private void UnsubscribeButton_Click(object sender, EventArgs e)
        {
            if (hypeRate != null)
            {
                hypeRate.Unsubscribe();
                hypeRate = null;
            }
            else { MessageBox.Show("hypeRate is undefined! Did you mean to subscribe?"); }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(hypeRate != null)
            {
                HRLabel.Text = hypeRate.HR.ToString();
            }
        }
    }
}
