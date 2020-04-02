using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life0
{
    
    enum GameState
    {
        doesntInit = 0,
        inProccess = 1,
        end        = 2
    }

    enum MindState
    {
        random,
        nearestPartner,
        nearestMeal,
        clever
    }

    class Game
    {
        // Entity collors: 0 female, 1 male, 2 food
        static public Color[] colors = new Color[] { Color.Red, Color.Blue, Color.Green };
        // Statistic struct
        public struct GameStatistic
        {
            public int alive;  // Count of alive entityes
            public int died;   // Count of died entityes
            public int step;   // current step
            public int eatenMeals; // Count of eaten meals
            public int agesSum; // Sum of all alive entityes ages
            public int healthSum; // Sum of all alive entityes health
            public MindState mindState; // Current mindstate
        }

        // Struct for meals config
        struct MealsConfig
        {
            public int stepsUpdate;    // Steps count to update food 
            public int countLimitUp;   // Upper limit of meals on field
            public int countLimitDown; // Bottom limit of meals on field

            public MealsConfig(int stepsUpdate, int countLimitDown, int countLimitUp)
            {
                this.stepsUpdate = stepsUpdate; 
                this.countLimitUp = countLimitUp;
                this.countLimitDown = countLimitDown;
            }

        };


        Random random = new Random(); // random handler
        List<Entity> entityes; // List of all entityes
        List<Point> meals;     // List of all instance of meals
        int steps;         // Game steps count  
        int width;        // Game field width
        int height;       // Game field height
        int died;         // Count of died entityes
        int eatenMeals; // Count of eaten meals
        int sumEntityAges; // Age sum of alive entity
        int sumEntityHealth; // Health sum of alive entity
        Size entitySize;  // Entity size
        GameState state;  // Game state
        MindState mindState; // Mind state


        // Init food config
        MealsConfig mealsConf = new MealsConfig(100, 10, 100);
        int kidsRadiusMin = 30;  // Distance from first parent when Entity born
        int kidsRadiusMax = 100;
        int entityesLimits; // Entytyes can't spawn if it's count > than this limit
        int stepLenght = 5;
        int EntityStepsLimit = 500; // Steps limits for each entity
        int EntityHealthLimit = 100; // Health limits for each entity


        public Game(PictureBox field, Size entitySize,MindState mindState, int spawnLimit)
        {
            width = field.Width;
            height = field.Height;
            this.entitySize = entitySize;
            this.mindState = mindState;
            this.entityesLimits = spawnLimit;
            state = GameState.doesntInit;
        }

        // Init new game according to 
        // Init life game rulles
        public void initNewGame()
        {
            // Init lists
            entityes = new List<Entity>();
            meals = new List<Point>();
           
            // Add one male
            entityes.Add(new Entity(Gender.male, new Point(400, 300), stepLenght,EntityStepsLimit, EntityHealthLimit));
            // And one female
            entityes.Add(new Entity(Gender.female, new Point(405, 305), stepLenght, EntityStepsLimit, EntityHealthLimit));
            // Init counters
            steps = 0;
            died = 0;
            eatenMeals = 0;
            sumEntityAges = 0;

            // Change game state
            state = GameState.inProccess;
        }

        // Compute next state of the game
        public void makeStep()
        {

            // Try to update food
            if (steps % mealsConf.stepsUpdate == 0)
                updateMeals();

            if (entityes.Count == 0)
            {
                state = GameState.end;
                return;
            }
            // Remove died entityes
            {
                var newEntityes = new List<Entity>();

                // Init sum of age
                sumEntityAges = 0;
                // Init sum of health
                sumEntityHealth = 0;
                foreach (var e in entityes)
                {
                   
                    // Add only alive antityes
                    if (e.getState() == LifeState.alive)
                    {
                        // CHOOSE STRATEGY HERE
                        int step;
                        if (mindState == MindState.random)
                            step = mindRandom();
                        else if (mindState == MindState.nearestMeal)
                            step = mindNearestMeal(e);
                        else if (mindState == MindState.nearestPartner)
                            step = mindNearestPartner(e);
                        else if (mindState == MindState.clever)
                            step = mindClever(e);
                        else
                            step = mindRandom();

                        e.makeStep(step);

                        newEntityes.Add(e);
                        sumEntityAges += e.getSteps();
                        sumEntityHealth += e.getStepsLeft();
                    }   
                    else
                        died += 1;
                }
 
                // Return to entityes
                entityes = newEntityes;
            }


            // Try to find meals close to the Entity
            {
                var newMeals = new List<Point>();
                foreach (var m in meals)
                    newMeals.Add(m);
                foreach (var e in entityes)
                    foreach (var m in meals)
                        if (isClose(e.getPos(), m))
                        {
                            e.eat();
                            eatenMeals += 1;
                            newMeals.Remove(m);
                        }

                // Return to meals
                meals = newMeals;

            }

            if( entityes.Count < entityesLimits)
            {
                var newEntityes = new List<Entity>();
                // Try to find male Entity near female
                for (int i = 0; i < entityes.Count; i++) { 
                    for (int j = i + 1; j < entityes.Count; j++)
                        if (entityes[i].getGender() != entityes[j].getGender())
                            if (isClose(entityes[i].getPos(), entityes[j].getPos()))
                            {
                                // Make a baby
                                var babyCount = kidsCount(entityes[i].getStepsLeft(), entityes[j].getStepsLeft());
                                for (int k = 0; k < babyCount; k++)
                                {
                                    // Choose position for new baby
                                    Point newPos = new Point(entityes[i].getPos().X, entityes[i].getPos().Y);
                                    // gets angle to put baby
                                    double fi = random.Next(40000) / 1e4 ; 
                                    var r = random.Next(kidsRadiusMin, kidsRadiusMax);
                                    newPos = new Point(newPos.X + (int)( r * Math.Cos(fi)),
                                         newPos.Y + (int)(r * Math.Sin(fi)));
                                    newEntityes.Add(new Entity((Gender)(random.Next() % 2), newPos,stepLenght, EntityStepsLimit, EntityHealthLimit));

                                }
                            }
                    // Add existing entity
                    newEntityes.Add(entityes[i]);
                }
                // Return to entityes
                entityes = newEntityes;
            }
           

            // Inc global steps
            steps += 1;
        }
        
        // Euclidian distance between points
        int distance(Point a, Point b)
        {
            return (int)Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        // True if points are close to each other
        bool isClose(Point a, Point b)
        {
            var dst = distance(a,b);
            return dst <= stepLenght;
        }

        // Kids count depending on
        // How mush steps is left both of parents
        int kidsCount(int a,int b)
        {
            if (a <= 10 || b <= 10)
                return 1;
            if (a <= 20 && b <= 20)
                return 2;
            if (a <= 40 || b <= 40)
                return 3;
            if (a <= 60 && b <= 60)
                return 4;
            else
                return 5;
        }
        // Update list of meals
        void updateMeals()
        {
            
            Point p;
            meals.Clear();
            int countFood = random.Next(mealsConf.countLimitDown, mealsConf.countLimitUp);
            for (int i = 0; i < countFood; i++)
            {
                p = new Point(random.Next(entitySize.Width, width - entitySize.Width), random.Next(entitySize.Height, height - entitySize.Height));
                meals.Add(p);
            }

        }

        // Mind algorithms
        bool XOR(bool a, bool b)
        {
            return a && !b || !a && b;
        }
        // Chaotic movements
        int mindRandom()
        {
            return random.Next(4);
        }

        int mindNearestPartner(Entity entity)
        {
            var target = nearestPartner(entity);
            if (target == null)
                return mindRandom();
            return moveToTarget(entity.getPos(), target.getPos());
        }

        // Go to nearest meal
        int mindNearestMeal(Entity entity)
        {
            if ( meals.Count != 0)
            { 
                var target = nearestMeal(entity);
                return moveToTarget(entity.getPos(), target);
            }
            return mindRandom();
        }

        
        // Go to nearest meal or partner depending on distance
        int mindClever(Entity entity)
        {
            var meal = nearestMeal(entity);
            var partner = nearestPartner(entity);
            var pos = entity.getPos();
            var contain = meals.Contains(meal);
            if (!contain && partner == null)
                return mindRandom();
            else if (!contain)
                return moveToTarget(pos, partner.getPos());
            else if (partner == null)
                return moveToTarget(pos, meal);
            else
            {
                if (distance(pos, meal) < distance(pos, partner.getPos()))
                    return moveToTarget(pos, meal);
                return moveToTarget(pos, partner.getPos());
            }
        }

        // Return direction to move from pos to target
        int moveToTarget(Point pos,Point target)
        {
           
            var deltaX = target.X - pos.X;
            var deltaY = target.Y - pos.Y;

            if (deltaX <= 0 && deltaY <= 0) // Second period
            {
                if (-deltaX < -deltaY)
                    return 1;// Turn Up
                else
                    return 2; // Turn Left
            }
            else if (deltaX <= 0 && deltaY >= 0) // Third perios
            {
                if (-deltaX < deltaY)
                    return 0; // Trun down
                else
                    return 2; // Turn left
            }
            else if (deltaX >= 0 && deltaY <= 0) // First period
            {
                if (deltaX < -deltaY)
                    return 1; // Turn up
                else
                    return 3; // Trun right
            }
            else                              // Fourth period
            {
                if (deltaX < deltaY)
                    return 0; // Turn down
                else
                    return 3; // Turn right
            }
        }


        // Get nearest meal
        Point nearestMeal(Entity entity)
        {
            if (meals.Count != 0)
            {
                var pos = entity.getPos();
                var target = entity.getTargetMeal();
                // if Entity has't target
                if (target == null || !meals.Contains(target))
                {
                    // Get nearest meal
                    target = meals[0];
                    int dst = distance(pos, target);
                    foreach (var m in meals)
                    {
                        var locDist = distance(m, pos);
                        if (locDist < dst)
                        {
                            target = m;
                            dst = locDist;
                        }
                    }
                    entity.setTargetMeal(target);
                }
                return target;
            }
            return entity.getPos();
        }

        // Get nearest partner
        Entity nearestPartner(Entity entity)
        {
            var pos = entity.getPos();
            var gen = entity.getGender();
            var target = entity.getTargetPartner();
            bool partnerExist = true;
            // If target isn't alive
            // Got nearest
            if (target == null || !entityes.Contains(target))
            {
                // Get fisrt entity
                partnerExist = false;
                target = entityes[0];
                int dst = distance(pos, target.getPos());
                foreach (var e in entityes)
                    if (e.getGender() != gen)
                    {
                        partnerExist = true;
                        // if first target have same gender
                        if (XOR(target.getGender() == gen, distance(pos, e.getPos()) < dst))
                        {
                            dst = distance(pos, e.getPos());
                            target = e;
                        }
                    }

                entity.setTargetPartner(target);
            }
            if (!partnerExist)
                return null;

            return target;
        }

        // Return statistic
        public GameStatistic getStatistic()
        {
            var g = new GameStatistic();
            g.alive = entityes.Count;
            g.died = died;
            g.eatenMeals = eatenMeals;
            g.step = steps;
            g.mindState = mindState;
            g.agesSum = sumEntityAges;
            g.healthSum = sumEntityHealth;
            return g;
        }
        public Size getSize()
        {
            return entitySize;
        }


        public int getEntityLimit()
        {
            return entityesLimits;
        }

        public List<Entity> GetEntities()
        {
            return entityes;
        }

        public List<Point> GetMeals()
        {
            return meals;
        }
        
        public GameState getState()
        {
            return state;
        }
     
        public void setMind(MindState m)
        {
            this.mindState = m;
        }

        public int getEntityStepsLimit()
        {
            return EntityStepsLimit;
        }
        
        public int getEntityHealthLimit()
        {
            return EntityHealthLimit;
        }

        public void setentityesLimits(int count)
        {
            this.entityesLimits = count;
        }
        public void addMale(Point pos)
        {
            entityes.Add(new Entity(Gender.male, pos, stepLenght, EntityStepsLimit, EntityHealthLimit));
        }

        public void addFemale(Point pos)
        {
            entityes.Add(new Entity(Gender.female, pos, stepLenght, EntityStepsLimit, EntityHealthLimit));
        }

        public void addFood(Point pos)
        {
            meals.Add(pos);
        }
    }
}
