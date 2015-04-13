using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BO;
using ENTITY;
using System.Media;
//using RasterEdge.Imaging.Basic;
//using RasterEdge.Imaging.Basic.Core;
//using RasterEdge.Imaging.Processing;
//using RasterEdge.Imaging.Basic.Codec;

namespace ObjectMoving
{
    public partial class DrawCar : Form
    {
        CarBO objB=new CarBO();
        Cars objE = new Cars();
        
        enum Position
        {
            Left, Right, Up, Down,Stop
        }

        private int X;
        private int Y;
        private Position objPosition;
        private int _color = 0;
        private int Uspeed;
        int move_direction = 1;
      
        
        public DrawCar()
        {
            InitializeComponent();

            X = 10;
            Y = 250;
            objPosition = Position.Left;
           
            Uspeed=objE.ESpeed = objB.getSpeed();
            this.speedshow.Text = Convert.ToString(Uspeed)+" ms^-1";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            objE.CarBody(panel1, move_direction, _color);
        }
        private void FormView_Paint(object sender, PaintEventArgs e)
        {
                       panel1.Location = new Point(X, Y);
                      
        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            _color += 1;
           
            
            
            if (objPosition == Position.Right)
            {
               
                X += Uspeed;
                if (X >= 920)
                {
                    objPosition = Position.Stop;
                }
                if (X >= 300 && Y<=130)
                {
                    objPosition = Position.Stop;
                }
             }
            else if (objPosition == Position.Left)
            {
               
                X -= Uspeed;
               
                if (X <= 0)
                {
                    objPosition = Position.Stop;
                }
             }
            else if (objPosition == Position.Up)
            {
                
                Y -= Uspeed;

                if (Y <= 0)
                {
                    objPosition = Position.Stop;
                }
            }
            else if (objPosition == Position.Down)
            {
               
                Y += Uspeed;

                if (Y >= 60 && X<=250)
                    objPosition = Position.Stop;

            }

            if (objPosition == Position.Stop)
            {
                X = X;
                Y = Y;
                _color = 0;
            }

            Invalidate();
        }

        private void FormView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                move_direction = 1;
                objPosition = Position.Left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                objPosition = Position.Right;
                move_direction = 2; 
            }
            else if (e.KeyCode == Keys.Space)
            {
                objPosition = Position.Stop;
                //q.Dispose();
                timerColour.Stop();
                
            }
            else if (e.KeyCode == Keys.Up)
            {
                objPosition = Position.Up;

                move_direction = 3;

            }
            else if (e.KeyCode == Keys.Down)
            {
                objPosition = Position.Down;

                move_direction = 4;

            }
        }

        private void FormView_Load(object sender, EventArgs e)
        {

        }

        private void timerColour_Tick(object sender, EventArgs e)
        {
          
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
