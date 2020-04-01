using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life0
{
   
    enum Gender
    {
        female = 0,
        male   = 1
    }

    enum LifeState
    {
        alive = 0,
        die   = 1
    }

    class Entity
    {
        int stepsGlobal = 0;        // Count of Entity steps during life
        int stepsLimit = 500;         // Limit of Entity global steps
        int stepsLeft = 20;          // Count of remainig steps
        int stepsLeftLimitUp = 100;   // Upper limit of remainig steps
        int stepsLeftLimitDown = 0; // Bottom limit of remainig steps
        int stepLen;            // Length of step in pixels
        // Entity direcion 0 up to 3 
        // up down left right
        int direction;                
        Gender gender;             // Entity gender: 0 feamle, 1 male
        Point pos;              // Entity position on the field
        Point target;           // Target point for Entity ( used for mind algorithms )
        LifeState state;        // Entity life state
        

        public Entity(Gender gender, Point pos, int stepLen)
        {
            this.gender = gender;
            this.pos = pos;
            this.stepLen = stepLen;
            state = LifeState.alive;
        }

        // 0 down
        // 1 up
        // 2 left
        // 3 right
        public void makeStep(int step)
        {
            if (step == 0)
                pos.Y += stepLen;
            else if (step == 1)
                pos.Y -= stepLen;
            else if (step == 2)
                pos.X -= stepLen;
            else if (step == 3)
                pos.X += stepLen;

            // Add stepst to steps global
            stepsGlobal += 1;
            // Substarct left steps
            stepsLeft -= 1;
            // Compute life state
            if (!stillAlive())
                state = LifeState.die;
        }

        // Call when entitiy eat meal 
        public void eat()
        {
            stepsLeft = Math.Min(stepsLeftLimitUp,stepsLeft + 20);
        }

        bool stillAlive()
        {
            return ! (stepsLeft == stepsLeftLimitDown || stepsGlobal == stepsLimit);
        }

        public Point getPos()
        {
            return pos;
        }
        
        public Gender getGender()
        {
            return gender;
        }

        public LifeState getState()
        {
            return state;
        }

        public int getStepsLeft()
        {
            return stepsLeft;
        }
    }
}
