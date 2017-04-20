using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace java_fractal_conversion
{
    public partial class Form1 : Form
    {
        private const int MAX = 256;      // max iterations
        private const double SX = -2.025; // start value real
        private const double SY = -1.125; // start value imaginary
        private const double EX = 0.6;    // end value real
        private const double EY = 1.125;  // end value imaginary
        private const int ScaleUp = 255;
        private int j = 0; // sets colour of fractal
        private static int x1, y1, xs, ys, xe, ye;
        private static double xstart, ystart, xende, yende, xzoom, yzoom;
        private static bool action, rectangle, finished;
        private static float xy;
        private Graphics g1;
        private Cursor c1, c2;
        public Bitmap bitmap;
        private Pen pen;
        private int ticks; // timer in milliseconds
        private bool cycleForwards = true;


        public Form1()
        {
            this.InitializeComponent();
            finished = false;
            this.c1 = Cursors.WaitCursor;
            this.c2 = Cursors.Cross; // c1 = new Cursor(Cursor.WAIT_CURSOR); // djm
            x1 = this.picture.Width;  // x1 = getSize().width; // djm
            y1 = this.picture.Height;  // y1 = getSize().height; // djm     
            xy = (float)x1 / (float)y1;

            this.bitmap = new Bitmap(x1, y1); // picture = createImage(x1, y1); // djm
            this.g1 = Graphics.FromImage(this.bitmap); // g1 = picture.getGraphics(); // djm

            finished = true;
            this.start();
        }
        public void destroy() // delete all instances 
        {
            if (finished)
            {
                picture = null;
                g1 = null;
                c1 = null;
                c2 = null;
                GC.Collect(); // garbage collection
            }
        }
        public void start() // djm
        {
            action = false;
            rectangle = false;
            this.init();
            xzoom = (xende - xstart) / (double)x1;
            yzoom = (yende - ystart) / (double)y1;
            this.mandelbrot();
        }

        private void init() // reset start values // djm
        {
            xstart = SX;
            ystart = SY;
            xende = EX;
            yende = EY;
            if ((float)((xende - xstart) / (yende - ystart)) != xy) xstart = xende - (yende - ystart) * xy;
        }

        public void Update(Graphics g)
        {
            g.DrawImage(this.bitmap, 0, 0);
            if (rectangle)
            {
                this.pen = new Pen(Color.White); // use a new pen to prevent memory leak
                if (xs < xe)
                {
                    if (ys < ye) g.DrawRectangle(this.pen, xs, ys, (xe - xs), (ye - ys));
                    else g.DrawRectangle(this.pen, xs, ye, (xe - xs), (ys - ye));
                }
                else
                {
                    if (ys < ye)
                    {
                        g.DrawRectangle(this.pen, xe, ys, (xs - xe), (ye - ys));
                    }
                    else
                    {
                        g.DrawRectangle(this.pen, xe, ye, (xs - xe), (ys - ye));
                    }
                }

                this.pen.Dispose();  // Release all pen resources
            }
        }

        private void mandelbrot() // calculate all points // djm
        {
            int x, y;
            float h, b, alt = 0.0f;

            action = false;

            this.Cursor = Cursors.WaitCursor;

            //this.Cursor = this.c1;
            // setCursor(c1); // djm
            this.Text = "Mandelbrot-Set will be produced - please wait...";
            // showStatus("mandelbrot-Set will be produced - please wait..."); // djm
            for (x = 0; x < x1; x += 2)
                for (y = 0; y < y1; y++)
                {
                    h = this.pointcolour(xstart + xzoom * (double)x, ystart + yzoom * (double)y); // color value
                    if (h != alt)
                    {
                        b = 1.0f - h * h; // brightness

                        var customColour = new HSB(h * 255, 0.8f * 255, b * 255); // hsb colour
                        var convertedColour = HSB.FromHSB(customColour); // convert hsb to rgb

                        this.pen = new Pen(convertedColour);
                        alt = h;
                    }
                    this.g1.DrawLine(this.pen, x, y, x + 1, y);
                }
            this.Text = "Mandelbrot-Set ready - please select zoom area with pressed mouse.";
            // showStatus("mandelbrot-Set ready - please select zoom area with pressed mouse."); // djm

            this.Cursor = Cursors.Cross;
            //this.Cursor = this.c2;
            action = true;
        }

        private float pointcolour(double xwert, double ywert) // color value from 0.0 to 1.0 by iterations
        // djm 
        {
            double r = 0.0, i = 0.0, m = 0.0;

            var J = this.j;

            while ((J < MAX) && (m < 4.0)) // djm while ((j < MAX) && (m < 4.0))
            {
                J++; // j++
                m = r * r - i * i;
                i = 2.0 * r * i + ywert;
                r = m + xwert;
            }
            return (float)J / (float)MAX; // djm return (float)j / (float)MAX;
        }


        public void paint(Graphics g)
        {
            this.Update(g);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void picture_Paint(object sender, PaintEventArgs e)
        {
            //////////////////////// Draws the image on the window ///////////////////////////////
            this.paint(e.Graphics);
        }

        //////////////////////// Zoom functionality ////////////////////////////////////////
        private void picture_MouseDown(object sender, MouseEventArgs e) // public void mousePressed(MouseEvent e) // djm
        {
            // e.consume(); // djm not needed

            if (action && e.Button == MouseButtons.Left) // e.consume(); //
            {
                xs = e.X; // xs = e.getX(); // djm
                ys = e.Y; // ys = e.getY(); // djm
            }


        }

        private void picture_MouseUp(object sender, MouseEventArgs e) // public void mouseReleased(MouseEvent e) // djm
        {
            int z, w;

            if (action)
            {
                xe = e.X; // xe = e.getX(); // djm
                ye = e.Y; // ye = e.getY(); // djm
                if (xs > xe)
                {
                    z = xs;
                    xs = xe;
                    xe = z;
                }
                if (ys > ye)
                {
                    z = ys;
                    ys = ye;
                    ye = z;
                }
                w = (xe - xs);
                z = (ye - ys);
                if ((w < 2) && (z < 2)) this.init();
                else
                {
                    if (((float)w > (float)z * xy)) ye = (int)((float)ys + (float)w / xy);
                    else xe = (int)((float)xs + (float)z * xy);
                    xende = xstart + xzoom * (double)xe;
                    yende = ystart + yzoom * (double)ye;
                    xstart += xzoom * (double)xs;
                    ystart += yzoom * (double)ys;
                }
                xzoom = (xende - xstart) / (double)x1;
                yzoom = (yende - ystart) / (double)y1;
                this.mandelbrot();
                rectangle = false;

                //////////////////////////// Zooms and redraws the image /////////////////////////////////////////

                this.Refresh(); // repaint(); // djm
            }
        }

        private void picture_MouseMove(object sender, MouseEventArgs e) // public void mouseDragged(MouseEvent e) // djm
        {
            // e.consume(); // djm

            if (action && e.Button == MouseButtons.Left) // if (action); // djm
            {
                xe = e.X; // xe = e.getX(); // djm
                ye = e.Y; // ye = e.getY(); // djm
                rectangle = true;
                this.Refresh(); // repaint(); // djm
            }

        }

        private void picture_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void picture_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void saveStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "XML files (*.xml)|*.xml", // only allows xml as the file extension
                CreatePrompt = true,  // prompts for user confirmation
                FileName = ".xml"    // option to choose filename
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var converter = TypeDescriptor.GetConverter(typeof(Bitmap));
                    var image = Convert.ToBase64String((byte[])converter.ConvertTo(this.bitmap, typeof(byte[]))); // convert bitmap to byte array and convert array to string

                    var document = new XDocument(
                        new XElement("state",
                        new XElement("image", image),
                        new XElement("xstart", xstart),
                        new XElement("ystart", ystart),
                        new XElement("xzoom", xzoom),
                        new XElement("yzoom", yzoom),
                        new XElement("j", j)
                    ));

                    document.Save(saveFileDialog.FileName); // saves the xml file to the chosen path
                    MessageBox.Show(String.Format("The fractal has been saved at {0}", saveFileDialog.FileName)); // Display dialog box to confirm xml file is saved
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Failed to save fractal state: {0}", ex.Message)); // Display error message to show failure to save xml file
                }

            }

        }

        private void loadStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "XML files (*.xml)|*.xml", // only display xml files in directory
                DefaultExt = ""
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var streamReader = new StreamReader(openFileDialog.FileName); // using streamreader to read the xml file
                    using (streamReader)
                    {
                        var document = new XmlDocument();
                        document.Load(openFileDialog.OpenFile());
                        var xnList = document.SelectNodes("/state");
                        foreach (XmlNode xmlNode in xnList)
                        {
                            xstart = Convert.ToDouble(xmlNode["xstart"].InnerText);
                            ystart = Convert.ToDouble(xmlNode["ystart"].InnerText);
                            xzoom = Convert.ToDouble(xmlNode["xzoom"].InnerText);
                            yzoom = Convert.ToDouble(xmlNode["yzoom"].InnerText);
                            j = Convert.ToInt32(xmlNode["j"].InnerText);  //records coloured states
                        }
                        this.mandelbrot();
                        this.Refresh();  // repaints picture // repaint(); // djm
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Failed to load fractal state: {0}", ex.Message)); // Failed to load
                }
            }
        }
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.j = 0; // sets default colour to 0 (red)
            this.colourPaletteLabel.Text = "Selected Colour: Red";
            this.start(); // resets the program
            this.Refresh(); // Redraws the picture
        }

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the program
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("This a mandelbrot Fractal program. Created by Deepanjan Paul (c3442857)")); // Display dialog box to confirm xml file is saved
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "JPEG|*.JPG|PNG|*.PNG|BMP|*.BMP", // only allow png, bmp or jpg file extensions
                CreatePrompt = true, // prompts for user confirmation
                FileName = "" // option to choose filename
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileExtension = Path.GetExtension(saveFileDialog.FileName); // store the users selected extension 

                ImageFormat format;
                switch (selectedFileExtension)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    default:
                        format = ImageFormat.Png;
                        break;
                }

                try
                {
                    this.bitmap.Save(saveFileDialog.FileName, format); // save image using users file name and selected format
                    MessageBox.Show(String.Format("The fractal has been saved at {0}", saveFileDialog.FileName)); // Display dialog box to confirm xml file is saved
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Failed to save fractal state: {0}", ex.Message)); // Display error message to show failure to save xml file
                }
            }
        }

        // default form cursor 
        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        // colour palette selection
        private void colourPaletteRed_Click(object sender, EventArgs e)
        {
            this.j = 0;
            this.colourPaletteLabel.Text = "Selected Colour: Red";
            this.mandelbrot();
            this.Refresh(); // Redraws the picture
        }

        private void colourPaletteOrange_Click(object sender, EventArgs e)
        {
            this.j = 15;
            this.colourPaletteLabel.Text = "Selected Colour: Orange";
            this.mandelbrot();
            this.Refresh(); // Redraws the picture
        }

        private void colourPaletteYellow_Click(object sender, EventArgs e)
        {
            this.j = 30;
            this.colourPaletteLabel.Text = "Selected Colour: Yellow";
            this.mandelbrot();
            this.Refresh(); // Redraws the picture
        }

        private void colourPaletteGreen_Click(object sender, EventArgs e)
        {
            this.j = 60;
            this.colourPaletteLabel.Text = "Selected Colour: Green";
            this.mandelbrot();
            this.Refresh(); // Redraws the picture
        }

        private void colourPaletteTurquoise_Click(object sender, EventArgs e)
        {
            this.j = 120;
            this.colourPaletteLabel.Text = "Selected Colour: Turquoise";
            this.mandelbrot();
            this.Refresh(); // Redraws the picture
        }

        private void colourPaletteBlue_Click(object sender, EventArgs e)
        {
            this.j = 150;
            this.colourPaletteLabel.Text = "Selected Colour: Blue";
            this.mandelbrot();
            this.Refresh(); // Redraws the picture
        }

        private void colourPalettePurple_Click(object sender, EventArgs e)
        {
            this.j = 190;
            this.colourPaletteLabel.Text = "Selected Colour: Purple";
            this.mandelbrot();
            this.Refresh(); // Redraws the picture
        }

        // colour palette buttons - change cursor to hand on hover
        private void colourPalette_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        // colour palette buttons - change cursor to hand on click
        private void colourPalette_MouseClick(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        // colour palette buttons - change cursor to default pointer on leave
        private void colourPalette_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        // colour cycle checkbox
        private void checkBoxColourCycle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxColourCycle.Checked) // cycle checkbox selected
            {
                timer.Tick += (timer_Tick);
                timer.Interval = 10; // in miliseconds
                timer.Start();
                ticks = 0;
            }
            else
            {
                timer.Stop();
                timer.Dispose();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ticks++; // increment timer
            mandelbrot();
            Refresh(); // Redraws the picture

            if (j == 240) // if j reaches 240, then set variable to cycle backwards 
            {
                cycleForwards = false;
            }

            if (j == 0) // if j reaches 0, then set variable to cycle forwards 
            {
                cycleForwards = true;
            }

            if (cycleForwards)
            {
                j++; // cycle colours from light to dark
            }
            else
            {
                j--; // cycle colours from dark to light
            }

        }

    }
}