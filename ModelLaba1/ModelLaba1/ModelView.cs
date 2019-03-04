using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelLaba1
{
    public partial class ModelView : Form
    {
        public BLL.ObjectModel model { get; set; }
        public ModelView()
        {
            InitializeComponent();
            model = new BLL.ObjectModel(1);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ch_Simulation.Series[0].Points.AddXY(model.Time, model.GetValue());
            lbl_OutputValue.Text = model.GetValue().ToString();
        }

        private void Bt_Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Tb_Dt_Scroll(object sender, EventArgs e)
        {
            model.Input = tb_Dt.Value;
            lb_StateMechanism.Text = model.Input.ToString();
            textBox_DT.Text = tb_Dt.Value.ToString();
        }

        private void TextBox_DT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void TextBox_DT_TextChanged(object sender, EventArgs e)
        {
            if (textBox_DT.Text == "") textBox_DT.Text = "0";
            else tb_Dt.Value = Int32.Parse(textBox_DT.Text);
            model.Input = tb_Dt.Value;
            lb_StateMechanism.Text = model.Input.ToString();
        }
    }
}
