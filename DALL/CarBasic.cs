using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ENTITY;

namespace DALL
{
    public class CarBasic
    {
        Cars onjE = new Cars();
        
        public bool saveSpeed(int s)
        {
            try {
                onjE.ESpeed = s;
                StreamWriter write = new StreamWriter(@"D:\Pojects\ObjectMoving\speed.txt");
                write.WriteLine(onjE.ESpeed);
                write.Close();
                return true;
            }
            
            catch { 
                return false;
            }
        }
        
        
        
        public int getSpeed()
        {

            StreamReader read = new StreamReader(@"D:\Pojects\ObjectMoving\speed.txt");
            onjE.ESpeed=Convert.ToInt32(read.ReadLine());
            return onjE.ESpeed;
        }


        public Cars getDrawInfo()
        {
            Cars DrawCar = new Cars();

            StreamReader read = new StreamReader(@"D:\Pojects\ObjectMoving\DrawCar.txt");

            try{
                DrawCar.carstyle=read.ReadLine();
                DrawCar.name=read.ReadLine();
                DrawCar.colour=read.ReadLine();
                DrawCar.movingCapacity=read.ReadLine();
                DrawCar.controllBy=read.ReadLine();
                DrawCar.stopBy=read.ReadLine();
                DrawCar.extraQuality=read.ReadLine();

                read.Close();
                return DrawCar;
            }
            catch (Exception e)
            {
                return null;
            }
            
        }


       
    }
}
