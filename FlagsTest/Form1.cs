using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagsTest
{
    public partial class FrmFlags : Form
    {
        public FrmFlags()
        {
            InitializeComponent();
        }

        /*
         * Button event handlers
         */
        private void btnFrance_Click(object sender, EventArgs e)
        {
            panelFlag.Invalidate();
            panelFlag.Paint += new PaintEventHandler(Panel1_France);
        }

        private void btnBelgium_Click(object sender, EventArgs e)
        {
            panelFlag.Invalidate();
            panelFlag.Paint += new PaintEventHandler(Panel1_Belgium);
        }

        private void btnRome_Click(object sender, EventArgs e)
        {
            panelFlag.Invalidate();
            panelFlag.Paint += new PaintEventHandler(Panel1_Rome);
        }

        private void btnNorthumbria_Click(object sender, EventArgs e)
        {
            panelFlag.Invalidate();
            panelFlag.Paint += new PaintEventHandler(Panel1_Northumbria);
        }

        private void btnUkraine_Click(object sender, EventArgs e)
        {
            panelFlag.Invalidate();
            panelFlag.Paint += new PaintEventHandler(Panel1_Ukraine);
        }

        private void btnPoland_Click(object sender, EventArgs e)
        {
            panelFlag.Invalidate();
            panelFlag.Paint += new PaintEventHandler(Panel1_Poland);
        }

        private void btnGermany_Click(object sender, EventArgs e)
        {
            panelFlag.Invalidate();
            panelFlag.Paint += new PaintEventHandler(Panel1_Germany);
        }

        private void btnMauritius_Click(object sender, EventArgs e)
        {
            panelFlag.Invalidate();
            panelFlag.Paint += new PaintEventHandler(Panel1_Mauritius);
        }


        private void btnColombia_Click(object sender, EventArgs e)
        {
            panelFlag.Invalidate();
            panelFlag.Paint += new PaintEventHandler(Panel1_Colombia);
        }

        private void btnLatvia_Click(object sender, EventArgs e)
        {
            panelFlag.Invalidate();
            panelFlag.Paint += new PaintEventHandler(Panel1_Latvia);
        }


        /*
         * Draw the Flag of France
         */
        private void Panel1_France(object sender, PaintEventArgs e)
        {
            // Get the graphics object to draw on the panel and clear anything there
            Graphics g = e.Graphics;
            g.Clear(panelFlag.BackColor);

            // Dimensions for the blue, white and red rectangles (three equal sections)
            int width = panelFlag.Width / 3;
            int height = panelFlag.Height;

            // Create brushes for the colours of the French flag
            Brush blueBrush = new SolidBrush(Color.Blue);
            Brush whiteBrush = new SolidBrush(Color.White);
            Brush redBrush = new SolidBrush(Color.Red);

            // Draw the three sections of the flag
            // Arguments are: starting x-coord, y-coord, rectangle width, rectangle height
            g.FillRectangle(blueBrush, 0, 0, width, height); // Left - Blue
            g.FillRectangle(whiteBrush, width, 0, width, height); // Middle - White
            g.FillRectangle(redBrush, 2 * width, 0, width, height); // Right - Red

            // Clean up brushes
            blueBrush.Dispose();
            whiteBrush.Dispose();
            redBrush.Dispose();
        }

        /*
         * Draw the flag of Belgium
         */
        private void Panel1_Belgium(object sender, PaintEventArgs e)
        {
            // write your code to draw the Belgian flag here
        }

      
        /*
         * Draw the flag of Rome
         */
        private void Panel1_Rome(object sender, PaintEventArgs e)
        {
            // Add your code to draw the flag of Rome here
        }


        /*
         * Draw the flag of Northumbria
         */
        private void Panel1_Northumbria(object sender, PaintEventArgs e)
        {
            // Add your code to draw the flag of Northumbria here
        }


        /*
         * Draw the flag of Ukraine
         */
        private void Panel1_Ukraine(object sender, PaintEventArgs e)
        {
            // Get the graphics object to draw on the panel
            Graphics g = e.Graphics;
            g.Clear(panelFlag.BackColor);

            // Set up the size of the flag (two equal sections)
            int width = panelFlag.Width;
            int height = panelFlag.Height / 2;

            // Create brushes for the colors of the Ukranian flag
            Brush blueBrush = new SolidBrush(Color.Blue);
            Brush yellowBrush = new SolidBrush(Color.Yellow);

            // Draw the two sections of the flag
            // Arguments are: starting x-coord, y-coord, rectangle width, rectangle height
            g.FillRectangle(blueBrush, 0, 0, width, height);  // Top - blue
            g.FillRectangle(yellowBrush, 0, height, width, height); // Bottom - yellow

            // Clean up brushes
            blueBrush.Dispose();
            yellowBrush.Dispose();
        }


        /*
         * Draw the flag of Poland
         */
        private void Panel1_Poland(object sender, PaintEventArgs e)
        {
            // Add your code to draw the Polish flag here
        }


        /*
         * Draw the flag of Germany
         */
        private void Panel1_Germany(object sender, PaintEventArgs e)
        {
            // write your code to draw the German flag here
        }


        /*
         * Draw the flag of Mauritius
         */
        private void Panel1_Mauritius(object sender, PaintEventArgs e)
        {
            // write your code to draw the flag of Mauritius here
        }

        /*
         * Draw the flag of Colombia
         */
        private void Panel1_Colombia(object sender, PaintEventArgs e)
        {
            // write your code to draw the Colombian flag here
        }

        /*
         * Draw the flag of Latvia
         */
        private void Panel1_Latvia(object sender, PaintEventArgs e)
        {
            // write your code to draw the Latvian flag here
        }

        /*
         * Draw the flag of Gambia
         */
        private void Panel1_Gambia(object sender, PaintEventArgs e)
        {
            // write your code to draw the Gambian flag here
        }
    }
}
