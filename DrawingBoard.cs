using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
namespace VPAssignment6
{
    class DrawingBoard
    {
        private static Graphics graphics;
        Pen thin_pen;
        private double xmin;
        private double xmax;
        private double ymin;
        private double ymax;
        private float differenceY;
        private float differenceX;
        private double start_x;
        private double start_y;

        public DrawingBoard(PictureBox Chart, TextBox xMin, TextBox xMax, TextBox yMin, TextBox yMax,ref Bitmap Graph)
        {
            Graph = new Bitmap(Chart.ClientSize.Width, Chart.ClientSize.Height);
            graphics = Graphics.FromImage(Graph);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            thin_pen = new Pen(Color.Black, 0);
            xmin = double.Parse(xMin.Text) * Math.PI;
            xmax = double.Parse(xMax.Text) * Math.PI;
            ymin = double.Parse(yMin.Text);
            ymax = double.Parse(yMax.Text);
            start_x = Math.PI * ((int)(xmin - 1));
            start_y = (int)ymin - 1;
        }
        public void chart(PictureBox Chart)
        {
            graphics.Clear(Color.White);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Scale to make the area fit the PictureBox.
            RectangleF world_coordinates = new RectangleF
                ((float)xmin, (float)ymax,
                (float)(xmax - xmin), (float)(ymin - ymax));

            PointF[] device_coords =
            {
                    new PointF(0, 0),
                    new PointF(Chart.ClientSize.Width, 0),
                    new PointF(0, Chart.ClientSize.Height),
                };

            graphics.Transform = new Matrix(world_coordinates, device_coords);
        }
        public void DrawXAxis()
        {
            // Draw the X-axis.
            // Start at the multiple of Pi < xmin.
            start_x = Math.PI * ((int)(xmin - 1));
            graphics.DrawLine(thin_pen, (float)xmin, 0, (float)xmax, 0);
            differenceY = (float)((ymax - ymin) / 30.0);
            for (double x = start_x; x <= xmax; x += Math.PI)
            {
                graphics.DrawLine(thin_pen, (float)x, -2 * differenceY, (float)x, 2 * differenceY);
            }
            for (double x = start_x + Math.PI / 2.0; x <= xmax; x += Math.PI)
            {
                graphics.DrawLine(thin_pen, (float)x, -differenceY, (float)x, differenceY);
            }
        }
        public void DrawYAxis()
        {

            // Draw the Y-axis.
            // Start at the multiple of 1 < ymin.
            start_y = (int)ymin - 1;
            graphics.DrawLine(thin_pen, 0, (float)ymin, 0, (float)ymax);
            differenceX = (float)((xmax - xmin) / 60.0);
            for (double y = start_y; y <= ymax; y += 1.0)
            {
                graphics.DrawLine(thin_pen, -2 * differenceX, (float)y,
                    2 * differenceX, (float)y);
            }
            for (double y = start_y + 0.5; y <= ymax; y += 1.0)
            {
                graphics.DrawLine(thin_pen, -differenceX, (float)y, differenceX, (float)y);
            }
        }
        public void DrawTanAsymptotes()
        {
            // Draw vertical asymptotes.
            thin_pen.DashPattern = new float[] { 5, 5 };
            for (double x = start_x + Math.PI / 2.0; x <= xmax;
                x += Math.PI)
            {
                graphics.DrawLine(thin_pen, (float)x, (float)ymin,
                    (float)x, (float)ymax);
            }
        }
        public void DrawSinCosAsymptotes()
        {
            // Draw horizontal limits for sine and cosine.
            graphics.DrawLine(thin_pen, (float)xmin, 1, (float)xmax, 1);
            graphics.DrawLine(thin_pen, (float)xmin, -1, (float)xmax, -1);
            thin_pen.DashStyle = DashStyle.Solid;
        }
        public void pixelScaling()
        {
            // See how big a pixel is before scaling.
            Matrix inverse = graphics.Transform;
            inverse.Invert();
            PointF[] pixel_pts ={
                        new PointF(0, 0),
                        new PointF(1, 0),
                    };
            inverse.TransformPoints(pixel_pts);
            differenceX = pixel_pts[1].X - pixel_pts[0].X;
        }

        public void DrawSin()
        {
            // Sine
            List<PointF> sine_points = new List<PointF>();
            for (float x = (float)xmin; x <= xmax; x += differenceX)
            {
                sine_points.Add(new PointF(x, (float)Math.Sin(x)));
            }
            thin_pen.Color = GraphPlotter.TrigPens[0].Color;
            thin_pen.DashStyle = GraphPlotter.TrigPens[0].DashStyle;
            graphics.DrawLines(thin_pen, sine_points.ToArray());
        }

        public void DrawCosec()
        {
            // Cosec
            List<PointF> cosec_points = new List<PointF>();
            for (float x = (float)xmin; x <= xmax; x += differenceX)
            {
                cosec_points.Add(new PointF(x, (float)(1/Math.Sin(x))));
            }
            thin_pen.Color = GraphPlotter.TrigPens[3].Color;
            thin_pen.DashStyle = GraphPlotter.TrigPens[3].DashStyle;
            graphics.DrawLines(thin_pen, cosec_points.ToArray());
        }

        public void DrawArcsin()
        {
            // ArcSin
            List<PointF> temp_arcsin_points = new List<PointF>();
            List<PointF> arcsin_points = new List<PointF>();

            for (float x = (float)xmin; x <= xmax; x += differenceX)
            {
                temp_arcsin_points.Add(new PointF(x, (float)(Math.Atan(x / Math.Sqrt(-x * x + 1)))));
                
            }
            thin_pen.Color = GraphPlotter.TrigPens[6].Color;
            thin_pen.DashStyle = GraphPlotter.TrigPens[6].DashStyle;
            foreach (PointF value in temp_arcsin_points)
            {
                if (!Single.IsNaN(value.Y))
                {
                    arcsin_points.Add(value);
                }
            }
            graphics.DrawLines(thin_pen, arcsin_points.ToArray());
        }

        public void DrawCos()
        {
            // Cosine
            List<PointF> cosine_points = new List<PointF>();
            for (float x = (float)xmin; x <= xmax; x += differenceX)
            {
                cosine_points.Add(new PointF(x, (float)Math.Cos(x)));
            }
            thin_pen.Color = GraphPlotter.TrigPens[1].Color;
            thin_pen.DashStyle = GraphPlotter.TrigPens[1].DashStyle;
            graphics.DrawLines(thin_pen, cosine_points.ToArray());
        }

        public void DrawSec()
        {
            // Sec
            List<PointF> sec_points = new List<PointF>();
            for (float x = (float)xmin; x <= xmax; x += differenceX)
            {
                sec_points.Add(new PointF(x, (float)(1/Math.Cos(x))));
            }
            thin_pen.Color = GraphPlotter.TrigPens[4].Color;
            thin_pen.DashStyle = GraphPlotter.TrigPens[4].DashStyle;
            graphics.DrawLines(thin_pen, sec_points.ToArray());
        }

        public void DrawArccos()
        {
            // ArcCos
            List<PointF> temp_arcos_points = new List<PointF>();
            List<PointF> arccos_points = new List<PointF>();

            for (float x = (float)xmin; x <= xmax; x += differenceX)
            {
                temp_arcos_points.Add(new PointF(x, (float)(Math.Atan(-x / Math.Sqrt(-x * x + 1)) + 2 * Math.Atan(1))));

            }
            thin_pen.Color = GraphPlotter.TrigPens[7].Color;
            thin_pen.DashStyle = GraphPlotter.TrigPens[7].DashStyle;
            foreach (PointF value in temp_arcos_points)
            {
                if (!Single.IsNaN(value.Y))
                {
                    arccos_points.Add(value);
                }
            }
            graphics.DrawLines(thin_pen, arccos_points.ToArray());
        }

        public void DrawTan()
        {
            // Tangent.
            List<PointF> tangent_points = new List<PointF>();
            double old_value = Math.Tan(xmin);
            thin_pen.Color = GraphPlotter.TrigPens[2].Color;
            thin_pen.DashStyle = GraphPlotter.TrigPens[2].DashStyle;
            for (float x = (float)xmin; x <= xmax; x += differenceX)
            {
                // See if we're at a discontinuity.
                double new_value = Math.Tan(x);
                if ((Math.Abs(new_value - old_value) > 10) &&
                    (Math.Sign(new_value) != Math.Sign(old_value)))
                {
                    if (tangent_points.Count > 1)
                        graphics.DrawLines(thin_pen,
                            tangent_points.ToArray());
                    tangent_points = new List<PointF>();
                }
                else
                {
                    tangent_points.Add(new PointF(x,
                        (float)Math.Tan(x)));
                }
            }
            if (tangent_points.Count > 1)
                graphics.DrawLines(thin_pen, tangent_points.ToArray());
        }

        public void DrawCot()
        {
            // Cot
            List<PointF> cot_points = new List<PointF>();
            double old_value = (1/Math.Tan(xmin));
            thin_pen.Color = GraphPlotter.TrigPens[5].Color;
            thin_pen.DashStyle = GraphPlotter.TrigPens[5].DashStyle;
            for (float x = (float)xmin; x <= xmax; x += differenceX)
            {

                    cot_points.Add(new PointF(x, (float)(1/Math.Tan(x))));
                
            }
            if (cot_points.Count > 1)
                graphics.DrawLines(thin_pen, cot_points.ToArray());
        }

        public void DrawArctan()
        {
            // ArcCos
            List<PointF> temp_arctan_points = new List<PointF>();
            List<PointF> arctan_points = new List<PointF>();

            for (float x = (float)xmin; x <= xmax; x += differenceX)
            {
                temp_arctan_points.Add(new PointF(x, (float)(Math.Atan(x))));

            }
            thin_pen.Color = GraphPlotter.TrigPens[8].Color;
            thin_pen.DashStyle = GraphPlotter.TrigPens[8].DashStyle;
            foreach (PointF value in temp_arctan_points)
            {
                if (!Single.IsNaN(value.Y))
                {
                    arctan_points.Add(value);
                }
            }
            graphics.DrawLines(thin_pen, arctan_points.ToArray());
        }

        public void Drawexp()
        {
            // Expr
            List<PointF> exp_points = new List<PointF>();
            for (float x = (float)xmin ; x <= xmax; x += differenceX)
            {

                exp_points.Add(new PointF(x, (float)Math.Exp(x)));
            }
            thin_pen.Color = GraphPlotter.OtherPens[0].Color;
            thin_pen.DashStyle = GraphPlotter.OtherPens[0].DashStyle;
            graphics.DrawLines(thin_pen, exp_points.ToArray());
        }

        public void DrawlogBase(int choiceBase)
        {
            // Log base
            List<PointF> templogbase_points = new List<PointF>();
            List<PointF> logbase_points = new List<PointF>();
            for (float x = (float)xmin; x <= xmax; x += differenceX)
            {

                templogbase_points.Add(new PointF(x, (float)(Math.Log(x) / Math.Log(choiceBase))));
            }
            if(choiceBase==2)
            {
                thin_pen.Color = GraphPlotter.OtherPens[1].Color;
                thin_pen.DashStyle = GraphPlotter.OtherPens[1].DashStyle;
            }
            else
            {
                thin_pen.Color = GraphPlotter.OtherPens[2].Color;
                thin_pen.DashStyle = GraphPlotter.OtherPens[2].DashStyle;
            }
            foreach (PointF value in templogbase_points)
            {
                if (!Single.IsNaN(value.Y))
                {
                    logbase_points.Add(value);
                }
            }
            graphics.DrawLines(thin_pen, logbase_points.ToArray());
        }

        public void DrawPower(int choicePower)
        {
            // Power
            List<PointF> power_points = new List<PointF>();
            for (float x = (float)xmin; x <= xmax; x += differenceX)
            {

                power_points.Add(new PointF(x, (float)(Math.Pow(x, choicePower) )));
            }
            if (choicePower == 2)
            {
                thin_pen.Color = GraphPlotter.OtherPens[3].Color;
                thin_pen.DashStyle = GraphPlotter.OtherPens[3].DashStyle;
            }
            else
            {
                thin_pen.Color = GraphPlotter.OtherPens[4].Color;
                thin_pen.DashStyle = GraphPlotter.OtherPens[4].DashStyle;
            }
            graphics.DrawLines(thin_pen, power_points.ToArray());
        }


    }
}
