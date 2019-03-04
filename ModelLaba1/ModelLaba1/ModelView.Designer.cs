namespace ModelLaba1
{
    partial class ModelView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ch_Simulation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bt_Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_OutputValue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_StateMechanism = new System.Windows.Forms.Label();
            this.tb_Dt = new System.Windows.Forms.TrackBar();
            this.textBox_DT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Simulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Dt)).BeginInit();
            this.SuspendLayout();
            // 
            // ch_Simulation
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_Simulation.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_Simulation.Legends.Add(legend1);
            this.ch_Simulation.Location = new System.Drawing.Point(12, 206);
            this.ch_Simulation.Name = "ch_Simulation";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ch_Simulation.Series.Add(series1);
            this.ch_Simulation.Size = new System.Drawing.Size(1034, 457);
            this.ch_Simulation.TabIndex = 0;
            this.ch_Simulation.Text = "Model output function";
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(874, 12);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(172, 62);
            this.bt_Start.TabIndex = 1;
            this.bt_Start.Text = "Start";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.Bt_Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(874, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 65);
            this.button1.TabIndex = 10;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbl_OutputValue
            // 
            this.lbl_OutputValue.AutoSize = true;
            this.lbl_OutputValue.BackColor = System.Drawing.Color.Transparent;
            this.lbl_OutputValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OutputValue.Location = new System.Drawing.Point(536, 108);
            this.lbl_OutputValue.Name = "lbl_OutputValue";
            this.lbl_OutputValue.Size = new System.Drawing.Size(35, 37);
            this.lbl_OutputValue.TabIndex = 14;
            this.lbl_OutputValue.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ModelLaba1.Properties.Resources.ModelLubKireev;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(235, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 215);
            this.panel1.TabIndex = 15;
            // 
            // lb_StateMechanism
            // 
            this.lb_StateMechanism.AutoSize = true;
            this.lb_StateMechanism.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_StateMechanism.Location = new System.Drawing.Point(51, 95);
            this.lb_StateMechanism.Name = "lb_StateMechanism";
            this.lb_StateMechanism.Size = new System.Drawing.Size(35, 37);
            this.lb_StateMechanism.TabIndex = 15;
            this.lb_StateMechanism.Text = "0";
            // 
            // tb_Dt
            // 
            this.tb_Dt.Location = new System.Drawing.Point(12, 135);
            this.tb_Dt.Maximum = 100;
            this.tb_Dt.Name = "tb_Dt";
            this.tb_Dt.Size = new System.Drawing.Size(121, 45);
            this.tb_Dt.TabIndex = 16;
            this.tb_Dt.Scroll += new System.EventHandler(this.Tb_Dt_Scroll);
            // 
            // textBox_DT
            // 
            this.textBox_DT.Location = new System.Drawing.Point(23, 172);
            this.textBox_DT.Name = "textBox_DT";
            this.textBox_DT.Size = new System.Drawing.Size(100, 20);
            this.textBox_DT.TabIndex = 17;
            this.textBox_DT.TextChanged += new System.EventHandler(this.TextBox_DT_TextChanged);
            this.textBox_DT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_DT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Входной сигнал";
            // 
            // ModelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 684);
            this.Controls.Add(this.lbl_OutputValue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_DT);
            this.Controls.Add(this.tb_Dt);
            this.Controls.Add(this.lb_StateMechanism);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Start);
            this.Controls.Add(this.ch_Simulation);
            this.Name = "ModelView";
            this.Text = "Model";
            ((System.ComponentModel.ISupportInitialize)(this.ch_Simulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Simulation;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_OutputValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_StateMechanism;
        private System.Windows.Forms.TrackBar tb_Dt;
        private System.Windows.Forms.TextBox textBox_DT;
        private System.Windows.Forms.Label label2;
    }
}

