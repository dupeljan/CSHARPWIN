﻿using System;
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
        int stepsLimit;         // Limit of Entity global steps
        int stepsLeft = 20;          // Count of remainig steps
        int stepsLeftLimitUp;   // Upper limit of remainig steps
        int stepsLeftLimitDown = 0; // Bottom limit of remainig steps
        int stepLen;            // Length of step in pixels
        // Entity direcion 0 up to 3 
        // up down left right
        Gender gender;             // Entity gender: 0 feamle, 1 male
        Point pos;              // Entity position on the field
        Point targetMeal;           // Target meal point for Entity ( used for mind algorithms )
        Entity targetPartner;           // Target partner point for Entity ( used for mind algorithms )
        LifeState state;        // Entity life state
        

        public Entity(Gender gender, Point pos, int stepLen,int stepsLimit, int stepsLeftLimitUp)
        {
            this.gender = gender;
            this.pos = pos;
            this.stepLen = stepLen;
            this.stepsLimit = stepsLimit;
            this.stepsLeftLimitUp = stepsLeftLimitUp;
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

        public Point getTargetMeal()
        {
            return targetMeal;
        }
        
        public void setTargetMeal(Point target)
        {
            this.targetMeal = target;
        }

        public Entity getTargetPartner()
        {
            return targetPartner;
        }

        public void setTargetPartner(Entity target)
        {
            this.targetPartner = target;
        }

        public int getSteps()
        {
            return stepsGlobal;
        }

    }
}
