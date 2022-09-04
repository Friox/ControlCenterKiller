using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace GIGABYTE_Control_Center_Killer {
    public partial class Form1 : Form {
        Process[] ccProcess;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            timer1.Enabled = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void killBtn_Click(object sender, EventArgs e) {
            try {
                ccProcess[0].Kill();
                Environment.Exit(0);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            ccProcess = Process.GetProcessesByName("ControlCenter");
            if (ccProcess.Length != 0) {
                // 프로세스가 있어요
                detectingStr.Text = "Process Detected";
                findStr.Text = "Found";
                findStr.ForeColor = Color.Green;
                killBtn.Enabled = true;
            } else {
                // 프로세스가 안보여요 ㅠㅠ
                detectingStr.Text = "Detecting Process...";
                findStr.Text = "Not Found";
                findStr.ForeColor = Color.Red;
                killBtn.Enabled = false;
            }
        }
    }
}