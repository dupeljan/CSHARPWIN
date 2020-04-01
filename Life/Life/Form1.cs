using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life {
    public partial class Form1 : Form {

        public static Size size = new Size(20, 20);  //  Entity size
        List<Entity> allPerson = new List<Entity>();
        List<Point> allFood = new List<Point>();
        List<Entity> allDeadPerson = new List<Entity>();
        Graphics g;
        public int maxEntity = 500, countAteFood = 0;
        public static List<Color> colors = new List<Color>() { Color.Blue, Color.Red, Color.Green };
        readonly Random random = new Random();
        long step = 0;
        DateTime timeStart;

        public Form1() {
            InitializeComponent();
        }

        public void generateFood() {
            Point p;
            allFood.Clear();
            int countFood = random.Next(10,100);
            for (int i = 0; i < countFood; i++) {
                p = new Point(random.Next(size.Width, board.Width - size.Width), random.Next(size.Height, board.Height - size.Height));
                allFood.Add(p);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            timeStart = DateTime.Now;
            board.Size = new Size(800, 600);
            timer1.Enabled = true;
            allPerson.Add(new Entity(new Point(385, 285),colors[0]));
            allPerson.Add(new Entity(new Point(400, 300),colors[1]));
        }

        private void board_Paint(object sender, PaintEventArgs e) {
            g = e.Graphics;
            foreach (Entity entity in allPerson) {
                g.FillEllipse(new SolidBrush(entity.gender), new Rectangle(entity.position, size));
            }
            if (step % 100 == 0) generateFood();
            foreach (Point p in allFood)
                g.FillEllipse(new SolidBrush(colors[2]), new Rectangle(p, size));
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            step++;
            List<Entity> children = new List<Entity>();
            foreach (Entity entity in allPerson) {
                entity.Run(board);
                List<Point> ateFoot = new List<Point>();
                foreach (Point posFood in allFood) {
                    if (entity.isPersonalSpaceFood(posFood)) ateFoot.Add(posFood);
                }
                countAteFood += ateFoot.Count;
                foreach (Point p in ateFoot) {
                    allFood.Remove(p);
                    if (entity.countIteration < 80) entity.countIteration += 20;
                }
                if (entity.countIteration == 0 || entity.countIterationInLife == 0) allDeadPerson.Add(entity);
            }
            List<Entity> allPersonCopy = allPerson.GetRange(0,allPerson.Count);
            int i = 0;
            while(allPersonCopy.Count != 0) {
                Entity entityIntersection = allPersonCopy[i].isPersonalSpaceEntity(allPersonCopy);
                if (entityIntersection != null) {
                    Rectangle R = new Rectangle(Math.Min(entityIntersection.position.X, allPersonCopy[i].position.X), Math.Min(entityIntersection.position.Y, allPersonCopy[i].position.Y), 2 * size.Width, 2 * size.Height);
                    if (entityIntersection.countIteration <= 20 && allPersonCopy[i].countIteration <= 20) {
                        children.Add(new Entity(new Point(R.X, R.Y), colors[random.Next(2)]));
//                        children.Add(new Entity(new Point(R.Right, R.Bottom), colors[random.Next(2)]));
                    }
                    if (entityIntersection.countIteration <= 10 || allPersonCopy[i].countIteration <= 10) {
                        children.Add(new Entity(new Point(R.X, R.Y), colors[random.Next(2)]));
                    }
                    if (entityIntersection.countIteration <= 40 || allPersonCopy[i].countIteration <= 40) {
                        children.Add(new Entity(new Point(R.X, R.Y), colors[random.Next(2)]));
//                        children.Add(new Entity(new Point(R.Right, R.Bottom), colors[random.Next(2)]));
//                        children.Add(new Entity(new Point(R.X, R.Bottom), colors[random.Next(2)]));
                    }
                    if (entityIntersection.countIteration <= 60 && allPersonCopy[i].countIteration <= 60) {
                        children.Add(new Entity(new Point(R.X, R.Y), colors[random.Next(2)]));
//                        children.Add(new Entity(new Point(R.Right, R.Bottom), colors[random.Next(2)]));
//                        children.Add(new Entity(new Point(R.X, R.Bottom), colors[random.Next(2)]));
//                        children.Add(new Entity(new Point(R.Right, R.Y), colors[random.Next(2)]));
                    }
                    allPersonCopy.Remove(entityIntersection);
                }
                allPersonCopy.RemoveAt(i);
            }
            foreach (Entity entity1 in allDeadPerson) allPerson.Remove(entity1);
            foreach (Entity entity1 in children) allPerson.Add(entity1);
            allDeadPerson.Clear();
            board.Refresh();
            if (allPerson.Count >= maxEntity || allPerson.Count == 0) {
                timer1.Enabled = false;
                int countM = 0, countW = 0;
                foreach (Entity entity1 in allPerson) {
                    if (entity1.gender == Color.Red) countW++;
                    else countM++;
                }
                MessageBox.Show("Потрачено времени = " + Math.Round((DateTime.Now - timeStart).TotalSeconds,3) + "\nКоличество женщин = " + countM + "\nКоличество мужчин = " + countW + "\nКоличество съеденной еды = " + countAteFood);
            }
        }
    }

    public class Entity {
        readonly List<Point> orientations = new List<Point>() { new Point(0, -1), new Point(-1, 0), new Point(0, 1), new Point(1, 0) };
        public Point position;
        public int countIterationInLife = 500;
        public int countIteration = 200;
        private static readonly Random random = new Random();
        public Color gender;
        public int radius = Form1.size.Width;
        public int countSteps = 5;

        public Entity(Point position, Color gender) {
            this.position = position;
            this.gender = gender;
        }

        public void Run(PictureBox board) {
            Point orientation = orientations[random.Next(orientations.Count)];
            position.X += orientation.X * countSteps;
            position.Y += orientation.Y * countSteps;
            if (position.X + radius > board.Width) {
                position.X = 2 * radius + position.X - board.Width;
            }
            if (position.X - radius < 0) {
                position.X = board.Width + position.X - 2 * radius;
            }
            if (position.Y + radius > board.Height) {
                position.Y = 2 * radius + position.Y - board.Height;
            }
            if (position.Y - radius < 0) {
                position.Y = board.Height + position.Y - 2 * radius;
            }
            countIteration--;
            countIterationInLife--;
        }

        public Entity isPersonalSpaceEntity(List<Entity> entities) {
            for (int i = 0; i < entities.Count; i++) {
                if (entities[i] != this && entities[i].gender != gender) {
                    Point distance = new Point(Math.Abs(entities[i].position.X - position.X), Math.Abs(entities[i].position.Y - position.Y));
                    if (distance.X < radius && distance.Y < radius) {
                        return entities[i];
                    }
                }
            }
            return null;
        }
        public bool isPersonalSpaceFood(Point food) {
            Point distance = new Point(Math.Abs(food.X - position.X), Math.Abs(food.Y - position.Y));
            if (distance.X < radius && distance.Y < radius) return true;
            else return false;
        }
    }
}
