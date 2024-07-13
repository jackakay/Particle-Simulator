using Timer = System.Windows.Forms.Timer;

namespace Particle_Simulator
{
    public class Particle
    {
        public PictureBox ParticlePictureBox { get; set; }
        public int Direction { get; set; }
    }
        
    public partial class Form1 : Form
    {
        

        public const float IDEAL_GAS_CONSTANT = 8.314f;
        public const float MOLAR_MASS_OXYGEN = 0.016f;

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

            for (int i = 0; i < 20; i++)
            {
                PictureBox pic = new PictureBox { BackgroundImage = Image.FromFile("particle.png"), BackgroundImageLayout = ImageLayout.Stretch, Size = new Size(10, 10) };
                Particle p = new Particle();
                p.ParticlePictureBox = pic;
                p.Direction = rand.Next(0, 3);
            }
        }
        private void update(object sender, EventArgs e)
        {
            avgSpeed = Math.Sqrt((3 * trackBar1.Value * IDEAL_GAS_CONSTANT) / (2 * MOLAR_MASS_OXYGEN));//O2 so multiply by two
            label10.Text = "Average speed of particle: " + Math.Round(avgSpeed, 2).ToString() + "m/s";
        }
        private void Spawn()
        {
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                bool placed = false;
                if (!placed)
                {
                    int x = rand.Next(41, 30 + trackBar4.Value);
                    int y = rand.Next(64, 57 + trackBar4.Value);
                    Point loc = new Point(x, y);
                    foreach (PictureBox pic in pictureBoxes)
                    {
                        if (pic.Location != loc)
                        {
                            placed = true;
                            break;
                        }
                    }
                    pictureBox.Location = loc;
                    this.Controls.Add(pictureBox);
                    pictureBox.BringToFront();
                }

            }
        }
        private void MoveAllParticles()
        {
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                int direction = rand.Next(0, 3);
                switch (direction)
                {
                    case 0:
                        //up

                        break;
                    case 1:
                        //down
                        break;
                    case 2:
                        //right
                        break;
                    case 3:
                        //left
                        break;

                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

        }



        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            //timer.Stop();
            label6.Text = trackBar1.Value.ToString() + " K";
            int tickSpeed = Convert.ToInt32(Math.Round((1 / avgSpeed) * 10000));
            timer.Interval = tickSpeed;
            label2.Text = tickSpeed.ToString();
            timer.Start();
            avgSpeed = Math.Sqrt((3 * trackBar1.Value * IDEAL_GAS_CONSTANT) / (2 * MOLAR_MASS_OXYGEN));//O2 so multiply by two
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