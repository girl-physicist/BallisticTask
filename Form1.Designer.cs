namespace BallisticTask
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxV0 = new System.Windows.Forms.TextBox();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxHMax = new System.Windows.Forms.TextBox();
            this.textBoxLMax = new System.Windows.Forms.TextBox();
            this.textBoxTMax = new System.Windows.Forms.TextBox();
            this.textBoxHMaxTeor = new System.Windows.Forms.TextBox();
            this.textBoxLMaxTeor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Ballistic task";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 27);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Ballistic task";
            series1.MarkerBorderWidth = 5;
            series1.MarkerSize = 10;
            series1.Name = "Ballistic task";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(570, 357);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // textBoxV0
            // 
            this.textBoxV0.Location = new System.Drawing.Point(626, 75);
            this.textBoxV0.Name = "textBoxV0";
            this.textBoxV0.Size = new System.Drawing.Size(100, 22);
            this.textBoxV0.TabIndex = 1;
            this.textBoxV0.Text = "20";
            this.textBoxV0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxV0_KeyPress);
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(626, 112);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(100, 22);
            this.textBoxAlpha.TabIndex = 1;
            this.textBoxAlpha.Text = "45";
            this.textBoxAlpha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAlpha_KeyPress);
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(626, 140);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 22);
            this.textBoxR.TabIndex = 1;
            this.textBoxR.Text = "0";
            this.textBoxR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxR_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = " initial Velocity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(732, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "launch Angle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(732, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = " air Resistance";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(626, 201);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(626, 240);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(736, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "initial Height";
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(626, 39);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(100, 22);
            this.textBoxH.TabIndex = 6;
            this.textBoxH.Text = "0";
            this.textBoxH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxH_KeyPress);
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(626, 173);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(100, 22);
            this.textBoxT.TabIndex = 7;
            this.textBoxT.Text = "0,003";
            this.textBoxT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxT_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(739, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "drawing Speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "hmax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(601, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "lmax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(601, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "t";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(754, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "hmaxTeor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(754, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "lmaxTeor";
            // 
            // textBoxHMax
            // 
            this.textBoxHMax.Location = new System.Drawing.Point(646, 290);
            this.textBoxHMax.Name = "textBoxHMax";
            this.textBoxHMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxHMax.TabIndex = 12;
            // 
            // textBoxLMax
            // 
            this.textBoxLMax.Location = new System.Drawing.Point(642, 326);
            this.textBoxLMax.Name = "textBoxLMax";
            this.textBoxLMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxLMax.TabIndex = 12;
            // 
            // textBoxTMax
            // 
            this.textBoxTMax.Location = new System.Drawing.Point(642, 370);
            this.textBoxTMax.Name = "textBoxTMax";
            this.textBoxTMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxTMax.TabIndex = 12;
            // 
            // textBoxHMaxTeor
            // 
            this.textBoxHMaxTeor.Location = new System.Drawing.Point(828, 287);
            this.textBoxHMaxTeor.Name = "textBoxHMaxTeor";
            this.textBoxHMaxTeor.Size = new System.Drawing.Size(100, 22);
            this.textBoxHMaxTeor.TabIndex = 12;
            // 
            // textBoxLMaxTeor
            // 
            this.textBoxLMaxTeor.Location = new System.Drawing.Point(824, 320);
            this.textBoxLMaxTeor.Name = "textBoxLMaxTeor";
            this.textBoxLMaxTeor.Size = new System.Drawing.Size(100, 22);
            this.textBoxLMaxTeor.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(707, 201);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 14;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxLMaxTeor);
            this.Controls.Add(this.textBoxHMaxTeor);
            this.Controls.Add(this.textBoxTMax);
            this.Controls.Add(this.textBoxLMax);
            this.Controls.Add(this.textBoxHMax);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.textBoxAlpha);
            this.Controls.Add(this.textBoxV0);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxV0;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxHMax;
        private System.Windows.Forms.TextBox textBoxLMax;
        private System.Windows.Forms.TextBox textBoxTMax;
        private System.Windows.Forms.TextBox textBoxHMaxTeor;
        private System.Windows.Forms.TextBox textBoxLMaxTeor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button button2;
    }
}

