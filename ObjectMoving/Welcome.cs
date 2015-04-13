using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ENTITY;
using BO;

namespace ObjectMoving
{
    public partial class Welcome : Form
    {
        Cars objE = new Cars();
        CarBO objBO = new CarBO();
        public Welcome()
        {
            InitializeComponent();
        }
        public void setSpeed()
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            
        }

        private void DRun_Click(object sender, EventArgs e)
        {
            int s = objE.ESpeed = Convert.ToInt32(txtSpeed.Text);
            objBO.setSpeed(s);
            DrawCar p = new DrawCar();

            p.Show();
        }

        private void PRun_Click(object sender, EventArgs e)
        {
            int k = objE.ESpeed = Convert.ToInt32(txtSpeed.Text);
            objBO.setSpeed(k);
            FormView l = new FormView();
            l.Show();
        }

        private void txtSpeed_TextChanged(object sender, EventArgs e)
        {
            String a = txtSpeed.Text;
            char[] b = a.ToCharArray();
            for (int i = 0; i < b.Length; i++)
            {
                if(b[i]<48 || b[i]>57)
                {
                    MessageBox.Show("Please Input an Integer Number as Speed");
                }
            }
        }

        


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
