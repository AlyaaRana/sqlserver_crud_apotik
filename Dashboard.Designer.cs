namespace sqlserver_crud_apotik
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.navHistory = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labeltext = new System.Windows.Forms.Label();
            this.navDashboard = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTxt = new System.Windows.Forms.Label();
            this.labelTxt = new System.Windows.Forms.Label();
            this.addComment = new Bunifu.Framework.UI.BunifuCards();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navDashboard)).BeginInit();
            this.panel2.SuspendLayout();
            this.addComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.navHistory);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labeltext);
            this.panel1.Controls.Add(this.navDashboard);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 819);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(33, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Medicine";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(71, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "History";
            // 
            // navHistory
            // 
            this.navHistory.Image = global::sqlserver_crud_apotik.Properties.Resources.icons8_note_50;
            this.navHistory.Location = new System.Drawing.Point(25, 286);
            this.navHistory.Name = "navHistory";
            this.navHistory.Size = new System.Drawing.Size(39, 41);
            this.navHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.navHistory.TabIndex = 3;
            this.navHistory.TabStop = false;
            this.navHistory.Click += new System.EventHandler(this.navHistory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sqlserver_crud_apotik.Properties.Resources.icons8_medicine_32;
            this.pictureBox1.Location = new System.Drawing.Point(50, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labeltext
            // 
            this.labeltext.AutoSize = true;
            this.labeltext.BackColor = System.Drawing.Color.Transparent;
            this.labeltext.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltext.ForeColor = System.Drawing.Color.Transparent;
            this.labeltext.Location = new System.Drawing.Point(71, 224);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(80, 17);
            this.labeltext.TabIndex = 2;
            this.labeltext.Text = "Dashboard";
            this.labeltext.Click += new System.EventHandler(this.labeltext_Click);
            // 
            // navDashboard
            // 
            this.navDashboard.Image = global::sqlserver_crud_apotik.Properties.Resources.icons8_dashboard_48__1_;
            this.navDashboard.Location = new System.Drawing.Point(25, 214);
            this.navDashboard.Name = "navDashboard";
            this.navDashboard.Size = new System.Drawing.Size(39, 38);
            this.navDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.navDashboard.TabIndex = 1;
            this.navDashboard.TabStop = false;
            this.navDashboard.Click += new System.EventHandler(this.navDashboard_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(928, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 24);
            this.button2.TabIndex = 18;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(178, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 88);
            this.panel2.TabIndex = 19;
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Location = new System.Drawing.Point(203, 142);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(0, 16);
            this.lblTxt.TabIndex = 20;
            // 
            // labelTxt
            // 
            this.labelTxt.AutoSize = true;
            this.labelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTxt.Location = new System.Drawing.Point(37, 41);
            this.labelTxt.Name = "labelTxt";
            this.labelTxt.Size = new System.Drawing.Size(286, 29);
            this.labelTxt.TabIndex = 21;
            this.labelTxt.Text = "Selamat Pagi, Alyaa !!";
            // 
            // addComment
            // 
            this.addComment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addComment.BorderRadius = 30;
            this.addComment.BottomSahddow = true;
            this.addComment.BottomShadow = true;
            this.addComment.color = System.Drawing.Color.Transparent;
            this.addComment.Controls.Add(this.label3);
            this.addComment.Controls.Add(this.pictureBox2);
            this.addComment.Controls.Add(this.labelTxt);
            this.addComment.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.addComment.IndicatorColor = System.Drawing.Color.Transparent;
            this.addComment.LeftSahddow = false;
            this.addComment.LeftShadow = false;
            this.addComment.Location = new System.Drawing.Point(206, 142);
            this.addComment.Name = "addComment";
            this.addComment.RightSahddow = true;
            this.addComment.RightShadow = true;
            this.addComment.ShadowDepth = 20;
            this.addComment.Size = new System.Drawing.Size(909, 147);
            this.addComment.TabIndex = 59;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(707, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(541, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "Explore the ease of filling patient data on our pharmacy dashboard. Automated pro" +
    "cesses \r\nwill make your job easier. Start the first step towards efficient patie" +
    "nt data management!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Statistik data pasien";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Actions";
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Transparent;
            this.chart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(206, 524);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(909, 265);
            this.chart.TabIndex = 62;
            this.chart.Text = "chart1";
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 816);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addComment);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navDashboard)).EndInit();
            this.panel2.ResumeLayout(false);
            this.addComment.ResumeLayout(false);
            this.addComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labeltext;
        private System.Windows.Forms.PictureBox navDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox navHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTxt;
        private System.Windows.Forms.Label labelTxt;
        private Bunifu.Framework.UI.BunifuCards addComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}