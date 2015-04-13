using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALL;
using ENTITY;

namespace BO
{
    public class CarBO
    {
        //int Speed;
        CarBasic objD = new CarBasic();

        public int getSpeed()
        {
            //int spd = objD.getSpeed();
            //int speed = Convert.ToInt32(sped);
            return objD.getSpeed();
        }

        public bool setSpeed(int s)
        {
            return objD.saveSpeed(s);//throw new NotImplementedException();
        }

        public Cars getDrawInfo()
        {
            return objD.getDrawInfo();
        }

       
    }
}
