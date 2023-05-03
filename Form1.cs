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
        private double F = 5D;
        private double B = 7D;
        private double focalLength = 1D;
        private double verticalOffset = 0D;
        private double angle = 0;
        private Bitmap canvas = new Bitmap(671, 525);
        private Pen blackPen = new Pen(Brushes.Black, 3);
        private Pen redPen = new Pen(Brushes.Red, 3);
        private Pen bluePen = new Pen(Brushes.Blue, 3);

        public Form1()
        {
            InitializeComponent();

            cube = new double[8, 3] {
                { -1D, -1D ,F },
                { +1D, -1D ,F },
                { -1D, +1D ,F },
                { +1D, +1D ,F },
                { -1D, -1D ,B },
                { +1D, -1D ,B },
                { -1D, +1D ,B },
                { +1D, +1D ,B }
            };

            render = new float[8, 2];

            Timer tmr = new Timer();
            tmr.Interval = 10;
            tmr.Tick += Tmr_Tick;
            tmr.Start();
        }

        private void ButtonResetRotateModel_Click(object sender, EventArgs e)
        {
            TrackBarRotateModel.Value = 0;
        }

        // Stolen from stack overflow: https://stackoverflow.com/questions/6311309/how-can-i-multiply-two-matrices-in-c
        private double[,] MatrixMult(double[,] matrixA, double[,] matrixB)
        {
            int rowsA = matrixA.GetLength(0);
            int columnsA = matrixA.GetLength(1);
            int rowsB = matrixB.GetLength(0);
            int columnsB = matrixB.GetLength(1);

            if (columnsA != rowsB)
            {
                Console.WriteLine("Matrices can't be multiplied. Matrix A columns don't match matrix B's rows");
                return new double[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            }
            else
            {
                double _;
                double[,] result = new double[rowsA, columnsB];

                for (int i = 0; i < rowsA; i++)
                {
                    for (int j = 0; j < columnsB; j++)
                    {
                        _ = 0;
                        for (int k = 0; k < columnsA; k++)
                        {
                            _ += matrixA[i, k] * matrixB[k, j];
                        }
                        result[i, j] = _;
                    }
                }
                return result;
            }
        }

        private double[] Rotate(double[] vertex, double degrees)
        {

            double[,] transMatrix = new double[,]
            {
                //{ 0, -1, 0 },
                //{ 1, 0, 0 },
                //{ 0, 0, 1 }
                { 0, -1, 0 },
                { 1, 0, 0 },
                { 0, 0, 1 }
            };

            double[,] t = transMatrix;
            double x = vertex[0];
            double y = vertex[1];
            double z = vertex[2];

            double[] finalVertex = new double[]
            {
                x * t[0, 0] + y * t[0, 1] + z * t[0, 2],
                x * t[1, 0] + y * t[1, 1] + z * t[1, 2],
                x * t[2, 0] + y * t[2, 1] + z * t[2, 2]
            };

            Matrix matrixVertex = new Matrix(
                (float)finalVertex[0], 0, // 0 
                (float)finalVertex[1], 0, // 0
                (float)finalVertex[2], 0  // 1
            );

            matrixVertex.Rotate((float)degrees);

            double[] transformedVertex = new double[]
            {
                matrixVertex.Elements[0],
                matrixVertex.Elements[2],
                matrixVertex.Elements[4]
            };

            //Matrix vector = new Matrix(
            //    (float)vertex[0], 0, // 0 
            //    (float)vertex[1], 0, // 0
            //    (float)vertex[2], 0  // 1
            //    );

            //vector.Rotate((float)degrees);

            //double[] transformedVertex = new double[]
            // {
            //    matrixVertex.Elements[0],
            //    matrixVertex.Elements[2],
            //    matrixVertex.Elements[4]
            // };

            //Matrix vector2 = new Matrix(
            //        vector.Elements[2], 0,
            //        vector.Elements[4], 0,
            //        vector.Elements[0], 0
            //        );

            //vector2.Rotate(90f);

            //double[] finalVertex = new double[]
            //{
            //    vector2.Elements[2],
            //    vector2.Elements[4],
            //    vector2.Elements[0],
            //};

            double radians = degrees * 180 / Math.PI;

            //double[,] transMatrix = new double[,]
            //{
            //    { 1, 0, 0 },
            //    { 0, Math.Cos(radians), -Math.Sin(radians) },
            //    { 0, Math.Sin(radians), Math.Cos(radians) }
            //};

            //double[,] t = transMatrix;
            //double x = vertex[0];
            //double y = vertex[1];
            //double z = vertex[2];

            //double[] vertex2 = new double[]
            //{
            //    x * t[0, 0] + y * t[0, 1] + z * t[0, 2],
            //    x * t[1, 0] + y * t[1, 1] + z * t[1, 2],
            //    x * t[2, 0] + y * t[2, 1] + z * t[2, 2]
            //};



            return transformedVertex;
        }
        //private double[] RotateV2(double[] vertex, double degrees)
        //{
        //    double radians = degrees * Math.PI / 180;

        //    double[,] matrixVertex = new double[,] {
        //        {(float)vertex[0], 0, 0},
        //        {(float)vertex[1], 0, 0},
        //        {(float)vertex[2], 0, 0}
        //        };

        //    //double[,] transMatrix = new double[,]
        //    //{
        //    //    { Math.Cos(radians), 0, Math.Sin(radians) },
        //    //    { 0, 1, 0 },
        //    //    { -Math.Sin(radians), 0, Math.Cos(radians) }
        //    //};

        //    double[,] transMatrix = new double[,]
        //    {
        //        { 1, 0, 0 },
        //        { 0, Math.Cos(radians), -Math.Sin(radians) },
        //        { 0, Math.Sin(radians), Math.Cos(radians) }
        //    };

        //    double[,] transformedVertex = MatrixMult(matrixVertex, transMatrix);

        //    return new double[]
        //    {
        //        transformedVertex[0,0] + transformedVertex[0,2],
        //        transformedVertex[1,0] + transformedVertex[1,2],
        //        transformedVertex[2,0] + transformedVertex[2,2],
        //    };
        //}

        private double[] Scale(double[] point)
        {
            return new double[2]
            {
                point[0] * canvas.Width + canvas.Width/2,
                point[1] * canvas.Height + canvas.Height/2 + verticalOffset
            };
        }
        private double[] Project(double[] vertex)
        {
            return new double[2] {
                (focalLength * vertex[0] / vertex[2]),
                (focalLength * vertex[1] / vertex[2])
            };
        }
        private void Draw(double angle)
        {
            canvas = new Bitmap(671, 525);
            Graphics g = Graphics.FromImage(canvas);
            g.FillRectangle(Brushes.White, 0, 0, canvas.Width, canvas.Height);

            //vv Code that draws goes here vv

            for (int index = 0; index < cube.Length / 3; index++)
            {
                double[] vertex = new double[3] { cube[index, 0], cube[index, 1], cube[index, 2] };

                double[] point = Scale(Project(Rotate(vertex, angle)));
                render[index, 0] = (float)point[0];
                render[index, 1] = (float)point[1];

                double x = point[0];
                double y = point[1];

                g.DrawEllipse(blackPen, new Rectangle((int)x - 10, (int)y - 10, 20, 20));
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
            //angle += 0.2;
            angle = 10;
        }

    }
}
