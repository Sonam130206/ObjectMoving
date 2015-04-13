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
//using RasterEdge.Imaging.Basic;
//using RasterEdge.Imaging.Basic.Core;
//using RasterEdge.Imaging.Processing;
//using RasterEdge.Imaging.Basic.Codec;

namespace ObjectMoving
{
    public partial class FormView : Form
    {
        Cars e = new Cars();
        CarBO b=new CarBO();
        enum Position
        {
            Left, Right, Up, Down, Stop
        }

        private int _x;
        private int _y;
        private Position _objPosition;
        private int Mspeed;


        public FormView()
        {
            InitializeComponent();

            _x = 20;
            _y =250;
            _objPosition = Position.Down;
            Mspeed = e.ESpeed = b.getSpeed();
            this.spedshow.Text = Convert.ToString(Mspeed)+" ms^-1 ";

            //zquanghoangz@gmail.com
        }

        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.BlueViolet, _x, _y, 100, 100);
            e.Graphics.DrawImage(new Bitmap("a1.png"), _x, _y, 250, 260);
        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            if (_x == 0)
            {
                _x += 10;
            }

            else if (_y == 0)
            {
                _y += 10;
            }
            else if (_x == 620)
            {
                _x -= 10;
            }

            else if (_y == 520)
            {
                _y -= 10;
            }

           

            if (_objPosition == Position.Right)
            {
                _x += Mspeed;
                if (_x == 520)
                {
                    _objPosition = Position.Stop;
                }
            }
            else if (_objPosition == Position.Left)
            {
                _x -= Mspeed;
                if (_x == 0)
                {
                    _objPosition = Position.Stop;
                }
            }
            /*else if (_objPosition == Position.Up)
            {
                _y -= 10;
            }
            else if (_objPosition == Position.Down)
            {
                _y += 10;
            }*/

            Invalidate();
        }

        private void FormView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _objPosition = Position.Left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                _objPosition = Position.Right;
            }
           /* else if (e.KeyCode == Keys.Up)
            {
                _objPosition = Position.Up;
            }
            else if (e.KeyCode == Keys.Down)
            {
                _objPosition = Position.Down;
            }*/
            else if (e.KeyCode==Keys.Space)
            {
                _objPosition = Position.Stop;
            }
        }

        private void FormView_Load(object sender, EventArgs e)
        {

        }

    }
}
