using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Life0
{
    
    enum GameState
    {
        doesntInit = 0,
        inProccess = 1,
        end        = 2
    }

    class Game
    {
        // Entity collors: 0 female, 1 male, 2 food
        static public Color[] colors = new Color[] { Color.Red, Color.Blue, Color.Green };
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
        Size entitySize;  // Entity size
        GameState state;  // Game state
        // Init food config
        MealsConfig mealsConf = new MealsConfig(100, 10, 100);
        int kidsRadiusMin = 30;  // Distance from first parent when Entity born
        int kidsRadiusMax = 100;
        int entityesLimits = 1000; // Entytyes can't spawn if it's count > than this limit
        int stepLenght = 5;
        
        public Game(PictureBox field, Size entitySize)
        {
            width = field.Width;
            height = field.Height;
            this.entitySize = entitySize;
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
            entityes.Add(new Entity(Gender.male, new Point(400, 300), stepLenght));
            // And one female
            entityes.Add(new Entity(Gender.female, new Point(405, 305), stepLenght));
            // Init steps count
            steps = 0;
            // Change game state
            state = GameState.inProccess;
        }

        // Compute next state of the game
        public void makeStep()
        {

            // Try to update food
            if (steps % mealsConf.stepsUpdate == 0)
                updateMeals();

            // Remove died entityes
            {
                var newEntityes = new List<Entity>();
                foreach (var e in entityes)
                {
                    // CHOOSE STRATEGY HERE
                    var step = mindNearestPartner(e);
                    e.makeStep(step);
                    // Add only alive antityes
                    if (e.getState() == LifeState.alive)
                        newEntityes.Add(e);
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
                                    newEntityes.Add(new Entity((Gender)(random.Next() % 2), newPos,stepLenght));

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
                foreach(var e in entityes)
                    if ( e.getGender() != gen)
                    {
                        partnerExist = true;
                        // if first target have same gender
                        if ( XOR(target.getGender() == gen, distance(pos, e.getPos()) < dst) )
                        {
                            dst = distance(pos, e.getPos());
                            target = e;                        
                        }                  
                    }

                entity.setTargetPartner(target);
            }
            if (!partnerExist)
                return mindRandom();

            return moveToTarget(pos, target.getPos());
        }

        // Go to nearest meal
        int mindNearestMeal(Entity entity)
        {
            if ( meals.Count != 0)
            {
                var pos = entity.getPos();
                var target = entity.getTargetMeal(); 
                // if Entity has't target
                if (target == null || ! meals.Contains(target))
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

                return moveToTarget(pos, target);
                
            }

            return mindRandom();
        }

        

        int moveToTarget(Point pos,Point target)
        {
            // Move to the target
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
        public Size getSize()
        {
            return entitySize;
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
     
    }
}
