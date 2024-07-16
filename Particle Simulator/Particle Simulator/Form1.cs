using Timer = System.Windows.Forms.Timer;

namespace Particle_Simulator
{
    public class Particle
    {
        public PictureBox ParticlePictureBox { get; set; }
        public List<double>  direction { get; set; }
    }
        
    public partial class Form1 : Form
    {

        public const int MAX_MOVEMENT = 4;
        public const float IDEAL_GAS_CONSTANT = 8.314f;
        public const float MOLAR_MASS_OXYGEN = 0.016f;
        public const int MAX_PARTICLES = 30;
        public const int PARTICLE_SIZE = 15;

        double avgSpeed;
        Random rand = new Random();

        Timer timer = new Timer();
        List<Particle> particles = new List<Particle>();

        public Form1()
        {
            InitializeComponent();

            label6.Text = "0 K";
            label7.Text = "0 Pa";


        }
        private void Form1_Load(object sender, EventArgs e)
        {

            timer.Tick += new EventHandler(update);

            for (int i = 0; i < MAX_PARTICLES; i++)
            {
                PictureBox pic = new PictureBox { BackgroundImage = Image.FromFile("particle.png"), BackgroundImageLayout = ImageLayout.Stretch, Size = new Size(PARTICLE_SIZE, PARTICLE_SIZE),  };
                Particle p = new Particle();
                p.ParticlePictureBox = pic;
                particles.Add(p);
                
            }
        }
        private void update(object sender, EventArgs e)
        {
            avgSpeed = Math.Sqrt((3 * trackBar1.Value * IDEAL_GAS_CONSTANT) / (2 * MOLAR_MASS_OXYGEN));//O2 so multiply by two
            label10.Text = "Average speed of particle: " + Math.Round(avgSpeed, 2).ToString() + "m/s";
            MoveAllParticles();
        }
        private void Spawn()
        {
            
            foreach (Particle p in particles)
            {
                bool placed = false;
                if (!placed)
                {
                    int x = rand.Next(41, 30 + trackBar4.Value);
                    int y = rand.Next(64, 57 + trackBar4.Value);
                    Point loc = new Point(x, y);
                    foreach (Particle p1 in particles)
                    {
                        if (p1.ParticlePictureBox.Location != loc)
                        {
                            placed = true;
                            break;
                        }
                    }
                    p.ParticlePictureBox.Location = loc;
                    this.Controls.Add(p.ParticlePictureBox);
                    p.ParticlePictureBox.BringToFront();
                    p.direction = GetDirection();
                }

            }
        }

        private List<double> GetDirection()
        {
            double MIN_VALUE = - MAX_MOVEMENT;
            double MAX_VALUE = MAX_MOVEMENT;

            double x = rand.NextDouble() * (MAX_VALUE - MIN_VALUE) + MIN_VALUE;
            double y = rand.NextDouble() * (MAX_VALUE - MIN_VALUE) + MIN_VALUE;
            
            return new List<double> { x, y };
        }

        private void MoveAllParticles()
        {
           foreach(Particle p in particles)
            {
                Point currentLocation = p.ParticlePictureBox.Location;
                Point newLocation = new Point();
                //check if collidng with the borders
                
                if ((currentLocation.X < panel1.Location.X + MAX_MOVEMENT) || ((currentLocation.X > panel1.Location.X - MAX_MOVEMENT) && (currentLocation.X < panel1.Location.X + MAX_MOVEMENT)) || ((currentLocation.X < panel1.Location.X + panel1.Size.Width + MAX_MOVEMENT) && (currentLocation.X > panel1.Location.X + panel1.Size.Width - MAX_MOVEMENT)) || (currentLocation.X > panel1.Location.X + panel1.Size.Width - MAX_MOVEMENT)) p.direction[0] *= -1;
                if ((currentLocation.Y < panel1.Location.Y + MAX_MOVEMENT) || ((currentLocation.Y > panel1.Location.Y - MAX_MOVEMENT) && (currentLocation.Y < panel1.Location.Y + MAX_MOVEMENT)) || ((currentLocation.Y < panel1.Location.Y + panel1.Size.Height + MAX_MOVEMENT) && (currentLocation.Y > panel1.Location.Y + panel1.Size.Height - MAX_MOVEMENT)) || (currentLocation.Y > panel1.Location.Y + panel1.Size.Height - MAX_MOVEMENT)) p.direction[1] *= -1;
                //check if colliding with other particles
                var collidedParticle = isColliding(p);
                if(collidedParticle != null)
                {
                    List<double> v1 = p.direction;
                    List<double> v2 = collidedParticle.direction;
                    p.direction = v2;
                    collidedParticle.direction = v1;
                    
                }

                //move the particle with its new direction
                newLocation.X = currentLocation.X + Convert.ToInt32(p.direction[0] * (MAX_MOVEMENT));
                newLocation.Y = currentLocation.Y + Convert.ToInt32(p.direction[1] * (MAX_MOVEMENT));
                p.ParticlePictureBox.Location = newLocation;
                
            }
        }

        private Particle? isColliding(Particle p)
        {
            foreach (Particle p1 in particles)
            {
                if (p.ParticlePictureBox.Bounds.IntersectsWith(p1.ParticlePictureBox.Bounds) && p != p1)
                {
                    return p1;
                }
                
            }
            return null;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

        }



        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            avgSpeed = Math.Sqrt((3 * trackBar1.Value * IDEAL_GAS_CONSTANT) / (2 * MOLAR_MASS_OXYGEN));//O2 so multiply by two
            //timer.Stop();
            label6.Text = trackBar1.Value.ToString() + " K";
            int tickSpeed = Convert.ToInt32(Math.Round((1 / avgSpeed) * 10000));
            timer.Interval = tickSpeed;
            label2.Text = tickSpeed.ToString();
            timer.Start();
            
            label10.Text = "Average speed of particle: " + Math.Round(avgSpeed, 2).ToString() + "m/s";
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = trackBar2.Value.ToString() + " Pa";
        }

        private void panel1_Resize(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label8.Text = trackBar4.Value.ToString() + " m";
            panel1.Size = new Size(trackBar4.Value, trackBar4.Value);
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            label8.Text = trackBar4.Value.ToString() + " m";
            panel1.Size = new Size(trackBar4.Value, trackBar4.Value);
            Spawn();
        }
    }
}