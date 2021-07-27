using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace VPAssignment6
{
    public partial class GraphPlotter : Form
    {
        private Bitmap GraphImage;
        DrawingBoard draw;
        public List<int> selectedTrignomatric = new List<int>();
        public List<int> selectedOther = new List<int>();
        static public List<Pen> TrigPens = new List<Pen>();
        static public List<Pen> OtherPens = new List<Pen>();
        bool sincosAsymptoteFlag;
        bool tanAsymptoteFlag;
        public GraphPlotter()
        {
            InitializeComponent();
            xMin.GotFocus += OnxMinFocus;
            xMin.LostFocus += OnxMinDefocus;
            xMax.GotFocus += OnxMaxFocus;
            xMax.LostFocus += OnxMaxDefocus;
            yMin.GotFocus += OnyMinFocus;
            yMin.LostFocus += OnyMinDefocus;
            yMax.GotFocus += OnyMaxFocus;
            yMax.LostFocus += OnyMaxDefocus;
        }

        private void GraphPlotter_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < (trigno_list.Items.Count); x++) 
            {
                Pen newPen= new Pen(Color.Black, 0);
                TrigPens.Add(newPen);
            }
            for (int x = 0; x < (other_list.Items.Count); x++)
            {
                Pen newPen = new Pen(Color.Black, 0);
                OtherPens.Add(newPen);
            }
        }

        private void OnyMaxDefocus(object sender, EventArgs e)
        {
            if (yMax.Text.Length == 0)
            {
                yMax.ForeColor = Color.DodgerBlue;
                yMax.Text = "Y-MAX";
            }
        }
        private void OnyMaxFocus(object sender, EventArgs e)
        {
            yMax.Text = "";
            yMax.ForeColor = Color.Black;
        }
        private void OnyMinDefocus(object sender, EventArgs e)
        {
            if (yMin.Text.Length == 0)
            {
                yMin.ForeColor = Color.DodgerBlue;
                yMin.Text = "Y-MIN";
            }
        }
        private void OnyMinFocus(object sender, EventArgs e)
        {
            yMin.Text = "";
            yMin.ForeColor = Color.Black;
        }
        private void OnxMaxDefocus(object sender, EventArgs e)
        {
            if (xMax.Text.Length == 0)
            {
                xMax.ForeColor = Color.DodgerBlue;
                xMax.Text = "X-MAX";
            }
        }
        private void OnxMaxFocus(object sender, EventArgs e)
        {
            xMax.Text = "";
            xMax.ForeColor = Color.Black;
        }
        private void OnxMinDefocus(object sender, EventArgs e)
        {
            if (xMin.Text.Length == 0)
            {
                xMin.ForeColor = Color.DodgerBlue;
                xMin.Text = "X-MIN";
            }
        }
        private void OnxMinFocus(object sender, EventArgs e)
        {
            xMin.Text = "";
            xMin.ForeColor = Color.Black;
        }

        private void generate_btn_Click(object sender, EventArgs e)
        {
            selectedTrignomatric = new List<int>();
            selectedOther = new List<int>();
            GraphImage = null;
            Graph_pbox.Image = null;
            draw = new DrawingBoard(Graph_pbox, xMin, xMax, yMin, yMax, ref GraphImage);
            draw.chart(Graph_pbox);
            draw.DrawXAxis();
            draw.DrawYAxis();
            getTrignoIndexes();
            getOtherIndexes();
            if (selectedTrignomatric.Count > 0)
            {
                drawTrignomatric();
            }
            if (selectedOther.Count > 0)
            {
                drawOther();
            }
            draw.pixelScaling();
            Graph_pbox.Image = GraphImage;
        }
        public void getTrignoIndexes()
        {
            for (int index = 0; index < trigno_list.Items.Count; index++)
            {
                if (trigno_list.CheckedIndices.Contains(index))
                {
                    selectedTrignomatric.Add(index);
                }
            }
        }
        public void getOtherIndexes()
        {
            for (int index = 0; index < other_list.Items.Count; index++)
            {
                if (other_list.CheckedIndices.Contains(index))
                {
                    selectedOther.Add(index);
                }
            }
        }

        public void drawTrignomatric()
        {
            for (int index = 0; index < selectedTrignomatric.Count; index++)
            {
                if (selectedTrignomatric[index] == 0)
                {
                    //Sin
                    draw.DrawSin();
                    sincosAsymptoteFlag = true;
                }
                if (selectedTrignomatric[index] == 1)
                {
                    //Cos
                    draw.DrawCos();
                    sincosAsymptoteFlag = true;
                }
                if (selectedTrignomatric[index] == 2)
                {
                    //Tan
                    draw.DrawTan();
                    tanAsymptoteFlag = true;
                }
                if (selectedTrignomatric[index] == 3)
                {
                    //Cosec
                    draw.DrawCosec();
                }
                if (selectedTrignomatric[index] == 4)
                {
                    //Sec
                    draw.DrawSec();
                }
                if (selectedTrignomatric[index] == 5)
                {
                    //Cotan
                    draw.DrawCot();
                }
                if (selectedTrignomatric[index] == 6)
                {
                    //arcsin
                    draw.DrawArcsin();
                }
                if (selectedTrignomatric[index] == 7)
                {
                    //arccos
                    draw.DrawArccos();
                }
                if (selectedTrignomatric[index] == 8)
                {
                    //arctan
                    draw.DrawArctan();
                }
            }
            if (sincosAsymptoteFlag == true && tanAsymptoteFlag == true)
            {
                draw.DrawTanAsymptotes();
                draw.DrawSinCosAsymptotes();
            }
            else if (sincosAsymptoteFlag == false && tanAsymptoteFlag == true)
            {
                draw.DrawTanAsymptotes();

            }
            else if (sincosAsymptoteFlag == true && tanAsymptoteFlag == false)
            {
                draw.DrawSinCosAsymptotes();
            }
        }
        public void drawOther()
        {
            for (int index = 0; index < selectedOther.Count; index++)
            {
                if (selectedOther[index] == 0)
                {
                    draw.Drawexp();
                }
                if (selectedOther[index] == 1)
                {
                    draw.DrawlogBase(2);
                }
                if (selectedOther[index] == 2)
                {
                    draw.DrawlogBase(10);
                }
                if (selectedOther[index] == 3)
                {
                    draw.DrawPower(2);
                }
                if (selectedOther[index] == 4)
                {
                    draw.DrawPower(3);
                }
            }
        }

        private void LineColor_Click(object sender, EventArgs e)
        {
            Line_Color color = new Line_Color(this);
            color.Show();
        }

        private void Graph_pbox_Click(object sender, EventArgs e)
        {

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            Graph_pbox.Image = null;
        }

        private void LineStyle_Click(object sender, EventArgs e)
        {
            Line_Style style = new Line_Style(this);
            style.Show();
        }
    }
}

