﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemotingServer;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;

namespace WindowsRemotingClient
{
    public partial class Form1 : Form
    {
        Service remoteobj = new Service();
        public Form1()
        {

            InitializeComponent();

            //channel and services registration 

            remoteobj = (Service)Activator.GetObject(typeof(Service),

               "tcp://localhost:8089/OurFirstRemoteService");


        }
        private void btnHighest_Click(object sender, EventArgs e)

        {

            int n1 = Int32.Parse(textBox1.Text);

            int n2 = Int32.Parse(textBox2.Text);

            textResult.Text = (remoteobj.HighestNumber(n1, n2)).ToString();

        }

        private void btnSmallest_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(textBox1.Text);

            int n2 = Int32.Parse(textBox2.Text);

            textResult.Text = (remoteobj.SmallestNumber(n1, n2)).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(textBox1.Text);

            int n2 = Int32.Parse(textBox2.Text);

            textResult.Text = (remoteobj.Multiplication(n1, n2)).ToString();
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(textBox1.Text);

            int n2 = Int32.Parse(textBox2.Text);

            textResult.Text = (remoteobj.Reminder(n1, n2)).ToString();
        }
    }

}
