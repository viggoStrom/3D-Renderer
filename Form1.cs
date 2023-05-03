using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _3DRenderer
{
    public partial class Form1 : Form
    {
        private double[,] cube;
        private float[,] render;
        private double focalLength = 1D;
        private double angle = 0;
        private double angleDelta = 0.0002;
        private double xOffset, yOffset, zOffset;
        private Boolean showCircles;
        private Boolean doAutoRotate;
        private int fps = 120;
        private Bitmap canvas = new Bitmap(600, 600);
        private Pen blackPen = new Pen(Brushes.Black, 3);
        private Pen redPen = new Pen(Brushes.Red, 3);
        private Pen bluePen = new Pen(Brushes.Blue, 3);

        public Form1()
        {
            InitializeComponent();

            cube = new double[8, 3] {
                { -1D, -1D , +1D },
                { +1D, -1D , +1D },
                { -1D, +1D , +1D },
                { +1D, +1D , +1D },
                { -1D, -1D , -1D },
                { +1D, -1D , -1D },
                { -1D, +1D , -1D },
                { +1D, +1D , -1D }
            };

            render = new float[8, 2];

            Timer tmr = new Timer();
            tmr.Interval = (int)1000 / fps;
            tmr.Tick += Tmr_Tick;
            tmr.Start();

            this.DropdownMesh.Text = "cube";
        }

        private void ButtonResetRotateModel_Click(object sender, EventArgs e)
        {
            TrackBarRotateModel.Value = 0;
        }

        private double[] Rotate(double[] vertex, double degrees)
        {
            double radians = degrees * 180 / Math.PI;

            Matrix vector = new Matrix(
                (float)vertex[0], 0,
                (float)vertex[2], 0,
                0, 0
                );

            Matrix transMatrix = new Matrix(
                (float)Math.Cos(radians), (float)-Math.Sin(radians),
                (float)Math.Sin(radians), (float)Math.Cos(radians),
                0, 0
                );

            vector.Multiply(transMatrix);

            return new double[]
            {
                vector.Elements[0] - xOffset,
                vertex[1] - yOffset,
                vector.Elements[2] - zOffset - 5,
            };
        }


        private double[] Scale(double[] point)
        {
            return new double[2]
            {
                point[0] * canvas.Width + canvas.Width/2,
                point[1] * canvas.Height + canvas.Height/2
            };
        }
        private double[] Project(double[] vertex)
        {
            return new double[2] {
                (focalLength * vertex[0] / vertex[2]),
                (focalLength * vertex[1] / vertex[2])
            };
        }

        private void checkBoxShowCorners_CheckedChanged(object sender, EventArgs e)
        {
            showCircles = !showCircles;
        }
        private void autoRotate_CheckedChanged(object sender, EventArgs e)
        {
            doAutoRotate = !doAutoRotate;
        }

        private void NumericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            xOffset = (double)this.NumericUpDownX.Value;
        }

        private void NumericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            yOffset = (double)this.NumericUpDownY.Value;
        }

        private void NumericUpDownZ_ValueChanged(object sender, EventArgs e)
        {
            zOffset = (double)this.NumericUpDownZ.Value;
        }

        private void NumericUpDownFocalLength_ValueChanged(object sender, EventArgs e)
        {
            focalLength = (double)this.NumericUpDownFocalLength.Value;
        }

        private void anglePerSecondUpDown_ValueChanged(object sender, EventArgs e)
        {
            angleDelta = (double)this.anglePerSecondUpDown.Value / 1000 / fps;
        }

        private void Draw(double angle)
        {
            canvas = new Bitmap(600, 600);
            Graphics g = Graphics.FromImage(canvas);

            //vv Code that draws goes here vv

            for (int index = 0; index < cube.Length / 3; index++)
            {
                double[] vertex = new double[3] { cube[index, 0], cube[index, 1], cube[index, 2] };

                double[] point = Scale(Project(Rotate(vertex, angle)));
                render[index, 0] = (float)point[0];
                render[index, 1] = (float)point[1];

                double x = point[0];
                double y = point[1];

                if (!showCircles)
                {
                    g.DrawEllipse(blackPen, new Rectangle((int)x - 10, (int)y - 10, 20, 20));
                }
            }


            g.DrawLine(bluePen, render[0, 0], render[0, 1], render[1, 0], render[1, 1]);
            g.DrawLine(bluePen, render[3, 0], render[3, 1], render[2, 0], render[2, 1]);
            g.DrawLine(bluePen, render[3, 0], render[3, 1], render[1, 0], render[1, 1]);
            g.DrawLine(bluePen, render[2, 0], render[2, 1], render[0, 0], render[0, 1]);

            g.DrawLine(redPen, render[0 + 4, 0], render[0 + 4, 1], render[1 + 4, 0], render[1 + 4, 1]);
            g.DrawLine(redPen, render[3 + 4, 0], render[3 + 4, 1], render[2 + 4, 0], render[2 + 4, 1]);
            g.DrawLine(redPen, render[3 + 4, 0], render[3 + 4, 1], render[1 + 4, 0], render[1 + 4, 1]);
            g.DrawLine(redPen, render[2 + 4, 0], render[2 + 4, 1], render[0 + 4, 0], render[0 + 4, 1]);

            g.DrawLine(blackPen, render[0 + 4, 0], render[0 + 4, 1], render[0, 0], render[0, 1]);
            g.DrawLine(blackPen, render[1 + 4, 0], render[1 + 4, 1], render[1, 0], render[1, 1]);
            g.DrawLine(blackPen, render[2 + 4, 0], render[2 + 4, 1], render[2, 0], render[2, 1]);
            g.DrawLine(blackPen, render[3 + 4, 0], render[3 + 4, 1], render[3, 0], render[3, 1]);


            g.Flush();
            MeshRenderWindow.Image = canvas;
        }

        private void Tmr_Tick(object sender, EventArgs e)  //run this logic each timer tick
        {
            Draw(angle);

            if (!doAutoRotate)
            {
                angle += angleDelta;
                if (angle >= 720)
                {
                    angle = -720;
                }
            }
        }

    }
}
