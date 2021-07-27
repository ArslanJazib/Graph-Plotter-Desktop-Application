using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VPAssignment6
{
    public partial class Line_Style : Form
    {
        GraphPlotter referencePlotter;

        public Line_Style(GraphPlotter plotterRef)
        {
            InitializeComponent();
            referencePlotter = plotterRef;

        }

        private void Line_Style_Load(object sender, EventArgs e)
        {
            for (int index = 0; index < referencePlotter.trigno_list.Items.Count; index++)
            {
                for (int index2 = 0; index2 < referencePlotter.trigno_list.CheckedItems.Count; index2++)
                {
                    if (referencePlotter.trigno_list.Items[index] == referencePlotter.trigno_list.CheckedItems[index2])
                    {
                        trigno_list.Items.Add(referencePlotter.trigno_list.Items[index]);
                        break;
                    }
                }

            }
            for (int index = 0; index < referencePlotter.other_list.Items.Count; index++)
            {
                for (int index2 = 0; index2 < referencePlotter.other_list.CheckedItems.Count; index2++)
                {
                    if (referencePlotter.other_list.Items[index] == referencePlotter.other_list.CheckedItems[index2])
                    {
                        other_list.Items.Add(referencePlotter.other_list.Items[index]);
                        break;
                    }
                }

            }
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            for (int index2 = 0; index2 < trigno_list.CheckedItems.Count; index2++)
            {
                for (int index = 0; index < referencePlotter.trigno_list.Items.Count; index++)
                {
                    if (referencePlotter.trigno_list.Items[index] == trigno_list.CheckedItems[index2])
                    {
                        if(solidLine.Checked)
                        {
                            GraphPlotter.TrigPens[index].DashStyle = DashStyle.Solid;
                            break;
                        }
                        else if(dashedLine.Checked)
                        {
                            GraphPlotter.TrigPens[index].DashStyle = DashStyle.Dash;
                            break;
                        }
                        else if (dotLine.Checked)
                        {
                            GraphPlotter.TrigPens[index].DashStyle = DashStyle.Dot;
                            break;
                        }
                    }
                }

            }
            for (int index2 = 0; index2 < other_list.CheckedItems.Count; index2++)
            {
                for (int index = 0; index < referencePlotter.other_list.Items.Count; index++)
                {
                    if (solidLine.Checked)
                    {
                        GraphPlotter.OtherPens[index].DashStyle = DashStyle.Solid;
                        break;
                    }
                    else if (dashedLine.Checked)
                    {
                        GraphPlotter.OtherPens[index].DashStyle = DashStyle.Dash;
                        break;
                    }
                    else if (dotLine.Checked)
                    {
                        GraphPlotter.OtherPens[index].DashStyle = DashStyle.Dot;
                        break;
                    }
                }

            }

            MessageBox.Show("To change Line Style of diffenet function please uncheck other options then click on the 'Generate Graph button on the plotter'", "Style Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
