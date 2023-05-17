namespace git_visual
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_1_user = new System.Windows.Forms.Button();
            this.btn_2_user = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(513, 115);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1230, 417);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btn_1_user
            // 
            this.btn_1_user.Location = new System.Drawing.Point(18, 43);
            this.btn_1_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_1_user.Name = "btn_1_user";
            this.btn_1_user.Size = new System.Drawing.Size(112, 35);
            this.btn_1_user.TabIndex = 1;
            this.btn_1_user.Text = "btn_1_user";
            this.btn_1_user.UseVisualStyleBackColor = true;
            // 
            // btn_2_user
            // 
            this.btn_2_user.Location = new System.Drawing.Point(140, 43);
            this.btn_2_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_2_user.Name = "btn_2_user";
            this.btn_2_user.Size = new System.Drawing.Size(112, 35);
            this.btn_2_user.TabIndex = 2;
            this.btn_2_user.Text = "btn_2_user";
            this.btn_2_user.UseVisualStyleBackColor = true;
            this.btn_2_user.Click += new System.EventHandler(this.btn_2_user_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(261, 43);
            this.btn_clr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(112, 35);
            this.btn_clr.TabIndex = 3;
            this.btn_clr.Text = "clr";
            this.btn_clr.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 115);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(354, 415);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1922, 692);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btn_2_user);
            this.Controls.Add(this.btn_1_user);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_1_user;
        private System.Windows.Forms.Button btn_2_user;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

