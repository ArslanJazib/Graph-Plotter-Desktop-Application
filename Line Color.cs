using System;
using System.Windows.Forms;
using System.Drawing;

namespace VPAssignment6
{
    public partial class Line_Color : Form
    {
        
        GraphPlotter referencePlotter;
        public Line_Color(GraphPlotter plotterRef)
        {
            InitializeComponent();
            referencePlotter = plotterRef;

        }

        private void coloMixer_Load(object sender, EventArgs e)
        {
            for(int index=0; index<referencePlotter.trigno_list.Items.Count;index++)
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
                        GraphPlotter.TrigPens[index].Color= Color.FromArgb(coloMixer.redValue,coloMixer.greenValue,coloMixer.blueValue);
                        break;
                    }
                }

            }
            for (int index2 = 0; index2 < other_list.CheckedItems.Count; index2++)
            {
                for (int index = 0; index < referencePlotter.other_list.Items.Count; index++)
                {
                    if (referencePlotter.other_list.Items[index] == other_list.CheckedItems[index2])
                    {
                        GraphPlotter.OtherPens[index].Color = Color.FromArgb(coloMixer.redValue, coloMixer.greenValue, coloMixer.blueValue);
                    }
                }

            }

            MessageBox.Show("To change Line Color of diffenet function please uncheck other options then click on the 'Generate Graph button on the plotter'", "Color Changed",  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trigno_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Line_Color_Load(object sender, EventArgs e)
        {

        }
    }
}
