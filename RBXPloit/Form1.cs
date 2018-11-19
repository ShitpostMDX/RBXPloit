using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace RBXPloit
{
    public partial class Form1 : Form
    {
        ExploitAPI api = new ExploitAPI();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string killplr = textBox1.Text;
            api.DoKill(killplr);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            api.DoKill("all");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            api.SetWalkSpeed("me", 16);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            api.SetWalkSpeed("me", 50);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string targetplr = textBox2.Text;
            api.DoBTools(targetplr);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string script = richTextBox1.Text;
            api.SendLimitedLuaScript(script);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string script1 = richTextBox1.Text;
            api.SendScript(script1);
        }
    }
}
