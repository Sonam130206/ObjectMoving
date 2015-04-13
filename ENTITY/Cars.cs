using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.Drawing;
using System.Windows.Forms;
namespace ENTITY
{
    public class Cars 
    {
        public int ESpeed;
        public string carstyle;
        public string name;
        public string colour;
        public string movingCapacity;
        public string controllBy;
        public string stopBy;
        public string extraQuality;

        Pen p;
        Pen q = new Pen(Color.Red, 4);


        public void CarBody(Panel panel1, int move_direction, int _color){

             Graphics carBody = panel1.CreateGraphics();
            Graphics Wheel = panel1.CreateGraphics();

              Pen q = new Pen(Color.Red, 4);

             if (move_direction == 1)
             {
                 panel1.Height = 200;
                 panel1.Width = 480;
                 p = new Pen(Color.Maroon, 5);
                 carBody.DrawLine(p, new Point(400, 110), new Point(415, 150));
                 carBody.DrawLine(p, new Point(400, 110), new Point(390, 100));
                 carBody.DrawLine(p, new Point(390, 100), new Point(370, 100));
                 carBody.DrawLine(p, new Point(370, 100), new Point(260, 70));
                 carBody.DrawLine(p, new Point(260, 70), new Point(240, 70));
                 carBody.DrawLine(p, new Point(240, 70), new Point(180, 100));
                 carBody.DrawLine(p, new Point(180, 100), new Point(100, 120));
                 carBody.DrawLine(p, new Point(100, 120), new Point(90, 125));
                 carBody.DrawLine(p, new Point(90, 125), new Point(80, 150));
                 carBody.DrawLine(p, new Point(80, 150), new Point(90, 155));
                 carBody.DrawLine(p, new Point(90, 155), new Point(150, 155));

                 carBody.DrawLine(p, new Point(415, 150), new Point(405, 155));
                 carBody.DrawLine(p, new Point(405, 155), new Point(370, 155));
                 carBody.DrawLine(p, new Point(200, 155), new Point(320, 155));

                 carBody.DrawLine(p, new Point(360, 105), new Point(250, 75));
                 carBody.DrawLine(p, new Point(190, 105), new Point(250, 75));

                 carBody.DrawLine(p, new Point(190, 105), new Point(360, 105));

                 carBody.FillRectangle(Brushes.Red, 95, 120, 25, 15);
                 carBody.FillRectangle(Brushes.Red, 390, 110, 10, 15);



                 p = new Pen(Color.DarkBlue, 11);
                 q = new Pen(Color.Black, 11);

                 if (_color == 0)
                 {

                     Wheel.DrawEllipse(p, 150, 120, 50, 50);
                     Wheel.DrawEllipse(p, 320, 120, 50, 50);




                 }
                 else if ((_color % 2) == 1)
                 {


                     Wheel.DrawEllipse(q, 150, 120, 50, 50);
                     Wheel.DrawEllipse(q, 320, 120, 50, 50);



                 }
                 else
                 {
                     Wheel.DrawEllipse(p, 150, 120, 50, 50);
                     Wheel.DrawEllipse(p, 320, 120, 50, 50);


                 }

                




              

             }



             else if (move_direction == 2)
             {
                  panel1.Height = 200;
                panel1.Width = 480;
                p = new Pen(Color.Maroon, 5);
                carBody.DrawLine(p, new Point(100, 110), new Point(85, 150));
                carBody.DrawLine(p, new Point(100, 110), new Point(110, 100));
                carBody.DrawLine(p, new Point(110, 100), new Point(130, 100));
                carBody.DrawLine(p, new Point(130, 100), new Point(220, 70));
                carBody.DrawLine(p, new Point(220, 70), new Point(240, 70));
                carBody.DrawLine(p, new Point(240, 70), new Point(320, 100));
                carBody.DrawLine(p, new Point(320, 100), new Point(400, 120));
                carBody.DrawLine(p, new Point(400, 120), new Point(410, 125));
                carBody.DrawLine(p, new Point(410, 125), new Point(420, 150));
                carBody.DrawLine(p, new Point(420, 150), new Point(410, 155));
                carBody.DrawLine(p, new Point(360, 155), new Point(410, 155));
                carBody.DrawLine(p, new Point(85, 150), new Point(95, 155));
                carBody.DrawLine(p, new Point(135, 155), new Point(95, 155));
                carBody.DrawLine(p, new Point(160, 100), new Point(220, 80));
                carBody.DrawLine(p, new Point(160, 100), new Point(165, 105));
                carBody.DrawLine(p, new Point(300, 105), new Point(165, 105));
                carBody.DrawLine(p, new Point(300, 105), new Point(220, 80));
                carBody.DrawLine(p, new Point(190, 155), new Point(310, 155));



                carBody.FillRectangle(Brushes.Red, 95, 110, 10, 15);
                carBody.FillRectangle(Brushes.Red, 390, 120, 20, 15);
              


                //car wheel
                p = new Pen(Color.DarkBlue, 11);
                q = new Pen(Color.Black, 11);
                
                if (_color == 0)
                {

                    Wheel.DrawEllipse(p, 140, 120, 50, 50);
                    Wheel.DrawEllipse(p, 310, 120, 50, 50);
           
                   
                    
                }
                else if ((_color % 2) == 1)
                {

                    Wheel.DrawEllipse(q, 140, 120, 50, 50);
                    Wheel.DrawEllipse(q, 310, 120, 50, 50);
           
                    


                }
                else
                {

                    Wheel.DrawEllipse(p, 140, 120, 50, 50);
                    Wheel.DrawEllipse(p, 310, 120, 50, 50);
                }

                


               
            }


                 
             

             else if (move_direction == 3)
             {
                 panel1.Height = 400;
                 panel1.Width = 350;

                 //moving up
                 p = new Pen(Color.Maroon, 3);
                 //car front glass
                 carBody.DrawLine(p, new Point(180, 190), new Point(300, 190));
                 carBody.DrawLine(p, new Point(180, 190), new Point(180, 280));
                 carBody.DrawLine(p, new Point(180, 280), new Point(300, 280));
                 carBody.DrawLine(p, new Point(300, 190), new Point(300, 280));
                 carBody.DrawLine(p, new Point(180, 190), new Point(160, 170));
                 carBody.DrawLine(p, new Point(180, 280), new Point(160, 300));
                 carBody.DrawLine(p, new Point(300, 190), new Point(320, 170));
                 carBody.DrawLine(p, new Point(300, 280), new Point(320, 300));
                 carBody.DrawLine(p, new Point(160, 300), new Point(320, 300));
                 carBody.DrawLine(p, new Point(320, 170), new Point(160, 170));
                 carBody.DrawLine(p, new Point(160, 170), new Point(160, 300));
                 carBody.DrawLine(p, new Point(320, 170), new Point(320, 300));



                 carBody.DrawLine(p, new Point(160, 170), new Point(160, 70));
                 carBody.DrawLine(p, new Point(160, 70), new Point(170, 65));
                 carBody.DrawLine(p, new Point(320, 170), new Point(320, 70));
                 carBody.DrawLine(p, new Point(320, 70), new Point(310, 65));
                 carBody.DrawLine(p, new Point(310, 65), new Point(170, 65));

                 carBody.DrawLine(p, new Point(160, 300), new Point(160, 350));
                 carBody.DrawLine(p, new Point(320, 300), new Point(320, 350));
                 carBody.DrawLine(p, new Point(160, 350), new Point(170, 355));
                 carBody.DrawLine(p, new Point(320, 350), new Point(310, 355));
                 carBody.DrawLine(p, new Point(170, 355), new Point(310, 355));







             }
             else if (move_direction == 4)
             {

                 panel1.Height = 500;
                 panel1.Width = 400;
                 //moving to down
                 p = new Pen(Color.Maroon, 3);
                 carBody.DrawLine(p, new Point(180, 190), new Point(300, 190));
                 carBody.DrawLine(p, new Point(180, 190), new Point(180, 280));
                 carBody.DrawLine(p, new Point(180, 280), new Point(300, 280));
                 carBody.DrawLine(p, new Point(300, 190), new Point(300, 280));
                 carBody.DrawLine(p, new Point(180, 190), new Point(160, 170));
                 carBody.DrawLine(p, new Point(180, 280), new Point(160, 300));
                 carBody.DrawLine(p, new Point(300, 190), new Point(320, 170));
                 carBody.DrawLine(p, new Point(300, 280), new Point(320, 300));
                 carBody.DrawLine(p, new Point(160, 300), new Point(320, 300));
                 carBody.DrawLine(p, new Point(320, 170), new Point(160, 170));
                 carBody.DrawLine(p, new Point(160, 170), new Point(160, 300));
                 carBody.DrawLine(p, new Point(320, 170), new Point(320, 300));

                 carBody.DrawLine(p, new Point(160, 170), new Point(160, 120));
                 carBody.DrawLine(p, new Point(320, 170), new Point(320, 120));
                 carBody.DrawLine(p, new Point(170, 115), new Point(160, 120));
                 carBody.DrawLine(p, new Point(320, 120), new Point(310, 115));
                 carBody.DrawLine(p, new Point(310, 115), new Point(170, 115));

                 carBody.DrawLine(p, new Point(320, 300), new Point(320, 400));

                 carBody.DrawLine(p, new Point(160, 300), new Point(160, 400));
                 carBody.DrawLine(p, new Point(160, 400), new Point(170, 405));
                 carBody.DrawLine(p, new Point(320, 400), new Point(310, 405));
                 carBody.DrawLine(p, new Point(310, 405), new Point(170, 405));

          

             }


          }

       
    }
}
