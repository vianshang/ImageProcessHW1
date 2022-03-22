
namespace E24066462_hw1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.OpenFile_button = new System.Windows.Forms.Button();
            this.SaveFile_button = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.R_channel_extraction = new System.Windows.Forms.Button();
            this.G_channel_extraction = new System.Windows.Forms.Button();
            this.B_channel_extraction = new System.Windows.Forms.Button();
            this.GrayScale_change = new System.Windows.Forms.Button();
            this.MeanFilter = new System.Windows.Forms.Button();
            this.MedianFilter = new System.Windows.Forms.Button();
            this.HistogramEqualization = new System.Windows.Forms.Button();
            this.Thresholding = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SobelEdge_vertical = new System.Windows.Forms.Button();
            this.SobelEdge_horizontal = new System.Windows.Forms.Button();
            this.SobelEdge_combined = new System.Windows.Forms.Button();
            this.Binary_overlap = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.ImportFileB = new System.Windows.Forms.Button();
            this.ImageRegistraion = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.ImportFileA = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFile_button
            // 
            this.OpenFile_button.Location = new System.Drawing.Point(64, 19);
            this.OpenFile_button.Name = "OpenFile_button";
            this.OpenFile_button.Size = new System.Drawing.Size(105, 40);
            this.OpenFile_button.TabIndex = 0;
            this.OpenFile_button.Text = "Open File";
            this.OpenFile_button.UseVisualStyleBackColor = true;
            this.OpenFile_button.Click += new System.EventHandler(this.OpenFile_button_Click);
            // 
            // SaveFile_button
            // 
            this.SaveFile_button.Location = new System.Drawing.Point(194, 19);
            this.SaveFile_button.Name = "SaveFile_button";
            this.SaveFile_button.Size = new System.Drawing.Size(102, 40);
            this.SaveFile_button.TabIndex = 1;
            this.SaveFile_button.Text = "Save Result";
            this.SaveFile_button.UseVisualStyleBackColor = true;
            this.SaveFile_button.Click += new System.EventHandler(this.SaveFile_button_Click);
            // 
            // Undo
            // 
            this.Undo.Location = new System.Drawing.Point(438, 19);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(102, 40);
            this.Undo.TabIndex = 2;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // R_channel_extraction
            // 
            this.R_channel_extraction.Location = new System.Drawing.Point(1173, 186);
            this.R_channel_extraction.Name = "R_channel_extraction";
            this.R_channel_extraction.Size = new System.Drawing.Size(182, 30);
            this.R_channel_extraction.TabIndex = 3;
            this.R_channel_extraction.Text = "R_channel_extraction";
            this.R_channel_extraction.UseVisualStyleBackColor = true;
            this.R_channel_extraction.Click += new System.EventHandler(this.R_channel_extraction_Click);
            // 
            // G_channel_extraction
            // 
            this.G_channel_extraction.Location = new System.Drawing.Point(1173, 222);
            this.G_channel_extraction.Name = "G_channel_extraction";
            this.G_channel_extraction.Size = new System.Drawing.Size(182, 30);
            this.G_channel_extraction.TabIndex = 4;
            this.G_channel_extraction.Text = "G_channel_extraction";
            this.G_channel_extraction.UseVisualStyleBackColor = true;
            this.G_channel_extraction.Click += new System.EventHandler(this.G_channel_extraction_Click);
            // 
            // B_channel_extraction
            // 
            this.B_channel_extraction.Location = new System.Drawing.Point(1173, 258);
            this.B_channel_extraction.Name = "B_channel_extraction";
            this.B_channel_extraction.Size = new System.Drawing.Size(182, 30);
            this.B_channel_extraction.TabIndex = 5;
            this.B_channel_extraction.Text = "B_channel_extraction";
            this.B_channel_extraction.UseVisualStyleBackColor = true;
            this.B_channel_extraction.Click += new System.EventHandler(this.B_channel_extraction_Click);
            // 
            // GrayScale_change
            // 
            this.GrayScale_change.Location = new System.Drawing.Point(1173, 294);
            this.GrayScale_change.Name = "GrayScale_change";
            this.GrayScale_change.Size = new System.Drawing.Size(182, 30);
            this.GrayScale_change.TabIndex = 6;
            this.GrayScale_change.Text = "GrayScale_change";
            this.GrayScale_change.UseVisualStyleBackColor = true;
            this.GrayScale_change.Click += new System.EventHandler(this.GrayScale_change_Click);
            // 
            // MeanFilter
            // 
            this.MeanFilter.Location = new System.Drawing.Point(1173, 365);
            this.MeanFilter.Name = "MeanFilter";
            this.MeanFilter.Size = new System.Drawing.Size(182, 30);
            this.MeanFilter.TabIndex = 7;
            this.MeanFilter.Text = "MeanFilter";
            this.MeanFilter.UseVisualStyleBackColor = true;
            this.MeanFilter.Click += new System.EventHandler(this.MeanFilter_Click);
            // 
            // MedianFilter
            // 
            this.MedianFilter.Location = new System.Drawing.Point(1173, 401);
            this.MedianFilter.Name = "MedianFilter";
            this.MedianFilter.Size = new System.Drawing.Size(182, 30);
            this.MedianFilter.TabIndex = 8;
            this.MedianFilter.Text = "MedianFilter";
            this.MedianFilter.UseVisualStyleBackColor = true;
            this.MedianFilter.Click += new System.EventHandler(this.MedianFilter_Click);
            // 
            // HistogramEqualization
            // 
            this.HistogramEqualization.Location = new System.Drawing.Point(1173, 490);
            this.HistogramEqualization.Name = "HistogramEqualization";
            this.HistogramEqualization.Size = new System.Drawing.Size(182, 30);
            this.HistogramEqualization.TabIndex = 9;
            this.HistogramEqualization.Text = "HistogramEqualization";
            this.HistogramEqualization.UseVisualStyleBackColor = true;
            this.HistogramEqualization.Click += new System.EventHandler(this.HistogramEqualization_Click);
            // 
            // Thresholding
            // 
            this.Thresholding.Location = new System.Drawing.Point(1233, 585);
            this.Thresholding.Name = "Thresholding";
            this.Thresholding.Size = new System.Drawing.Size(122, 30);
            this.Thresholding.TabIndex = 10;
            this.Thresholding.Text = "Thresholding";
            this.Thresholding.UseVisualStyleBackColor = true;
            this.Thresholding.Click += new System.EventHandler(this.Thresholding_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(527, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 256);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1173, 585);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 29);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Original";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Result";
            
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(37, 542);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(323, 311);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(527, 542);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(320, 311);
            this.chart2.TabIndex = 17;
            this.chart2.Text = "chart2";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Original Histogram";
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Result Histogram";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1170, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "problem1";
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1170, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "problem2";
            
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1170, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "problem3";
            
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1170, 542);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "problem4";
            
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1170, 560);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Please enter a threshold(0~255)";
            
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1429, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 25;
            this.label10.Text = "problem5";
            
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1429, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "problem6";
            
            // 
            // SobelEdge_vertical
            // 
            this.SobelEdge_vertical.Location = new System.Drawing.Point(1431, 186);
            this.SobelEdge_vertical.Name = "SobelEdge_vertical";
            this.SobelEdge_vertical.Size = new System.Drawing.Size(182, 30);
            this.SobelEdge_vertical.TabIndex = 27;
            this.SobelEdge_vertical.Text = "SobelEdge_vertical_x";
            this.SobelEdge_vertical.UseVisualStyleBackColor = true;
            this.SobelEdge_vertical.Click += new System.EventHandler(this.SobelEdge_vertical_Click);
            // 
            // SobelEdge_horizontal
            // 
            this.SobelEdge_horizontal.Location = new System.Drawing.Point(1432, 222);
            this.SobelEdge_horizontal.Name = "SobelEdge_horizontal";
            this.SobelEdge_horizontal.Size = new System.Drawing.Size(181, 30);
            this.SobelEdge_horizontal.TabIndex = 28;
            this.SobelEdge_horizontal.Text = "SobelEdge_horizontal_y";
            this.SobelEdge_horizontal.UseVisualStyleBackColor = true;
            this.SobelEdge_horizontal.Click += new System.EventHandler(this.SobelEdge_horizontal_Click);
            // 
            // SobelEdge_combined
            // 
            this.SobelEdge_combined.Location = new System.Drawing.Point(1431, 259);
            this.SobelEdge_combined.Name = "SobelEdge_combined";
            this.SobelEdge_combined.Size = new System.Drawing.Size(182, 30);
            this.SobelEdge_combined.TabIndex = 29;
            this.SobelEdge_combined.Text = "SobelEdge_combined";
            this.SobelEdge_combined.UseVisualStyleBackColor = true;
            this.SobelEdge_combined.Click += new System.EventHandler(this.SobelEdge_combined_Click);
            // 
            // Binary_overlap
            // 
            this.Binary_overlap.Location = new System.Drawing.Point(1483, 383);
            this.Binary_overlap.Name = "Binary_overlap";
            this.Binary_overlap.Size = new System.Drawing.Size(130, 30);
            this.Binary_overlap.TabIndex = 30;
            this.Binary_overlap.Text = "Binary_overlap";
            this.Binary_overlap.UseVisualStyleBackColor = true;
            this.Binary_overlap.Click += new System.EventHandler(this.Binary_overlap_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1432, 383);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 29);
            this.textBox2.TabIndex = 31;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1429, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(227, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "Please enter a threshold(0~255)";
            //this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(37, 542);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(320, 256);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(527, 542);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(320, 256);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
     
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 517);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 18);
            this.label13.TabIndex = 35;
            this.label13.Text = "Result after SobelEdge";
            //this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(535, 517);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 18);
            this.label14.TabIndex = 36;
            this.label14.Text = "Result after thresholding";
            //this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(566, 19);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(116, 40);
            this.Clear.TabIndex = 37;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1429, 469);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 18);
            this.label15.TabIndex = 38;
            this.label15.Text = "problem7";
            //this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // ImportFileB
            // 
            this.ImportFileB.Location = new System.Drawing.Point(1528, 493);
            this.ImportFileB.Name = "ImportFileB";
            this.ImportFileB.Size = new System.Drawing.Size(85, 34);
            this.ImportFileB.TabIndex = 39;
            this.ImportFileB.Text = "Import B";
            this.ImportFileB.UseVisualStyleBackColor = true;
            this.ImportFileB.Click += new System.EventHandler(this.ImportFileB_Click);
            // 
            // ImageRegistraion
            // 
            this.ImageRegistraion.Location = new System.Drawing.Point(1432, 585);
            this.ImageRegistraion.Name = "ImageRegistraion";
            this.ImageRegistraion.Size = new System.Drawing.Size(181, 30);
            this.ImageRegistraion.TabIndex = 40;
            this.ImageRegistraion.Text = "ImageRegistration";
            this.ImageRegistraion.UseVisualStyleBackColor = true;
            this.ImageRegistraion.Click += new System.EventHandler(this.ImageRegistraion_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 18);
            this.label16.TabIndex = 41;
            this.label16.Text = "PictureA";
            //this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 517);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 18);
            this.label17.TabIndex = 42;
            this.label17.Text = "PictureB";
            //this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(27, 115);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(446, 330);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox5_Paint);
            this.pictureBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseDown);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(37, 542);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(413, 379);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 44;
            this.pictureBox6.TabStop = false;
            //this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            this.pictureBox6.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox6_Paint);
            this.pictureBox6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox6_MouseDown);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(527, 115);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(446, 330);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 45;
            this.pictureBox7.TabStop = false;
            //this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // ImportFileA
            // 
            this.ImportFileA.Location = new System.Drawing.Point(1432, 493);
            this.ImportFileA.Name = "ImportFileA";
            this.ImportFileA.Size = new System.Drawing.Size(85, 34);
            this.ImportFileA.TabIndex = 46;
            this.ImportFileA.Text = "Import A";
            this.ImportFileA.UseVisualStyleBackColor = true;
            this.ImportFileA.Click += new System.EventHandler(this.ImportFileA_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1429, 542);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(176, 18);
            this.label18.TabIndex = 47;
            this.label18.Text = "Please click four points ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1429, 560);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(255, 18);
            this.label19.TabIndex = 48;
            this.label19.Text = "at the picture A and B respectively.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 983);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ImportFileA);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ImageRegistraion);
            this.Controls.Add(this.ImportFileB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Binary_overlap);
            this.Controls.Add(this.SobelEdge_combined);
            this.Controls.Add(this.SobelEdge_horizontal);
            this.Controls.Add(this.SobelEdge_vertical);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Thresholding);
            this.Controls.Add(this.HistogramEqualization);
            this.Controls.Add(this.MedianFilter);
            this.Controls.Add(this.MeanFilter);
            this.Controls.Add(this.GrayScale_change);
            this.Controls.Add(this.B_channel_extraction);
            this.Controls.Add(this.G_channel_extraction);
            this.Controls.Add(this.R_channel_extraction);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.SaveFile_button);
            this.Controls.Add(this.OpenFile_button);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFile_button;
        private System.Windows.Forms.Button SaveFile_button;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button R_channel_extraction;
        private System.Windows.Forms.Button G_channel_extraction;
        private System.Windows.Forms.Button B_channel_extraction;
        private System.Windows.Forms.Button GrayScale_change;
        private System.Windows.Forms.Button MeanFilter;
        private System.Windows.Forms.Button MedianFilter;
        private System.Windows.Forms.Button HistogramEqualization;
        private System.Windows.Forms.Button Thresholding;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SobelEdge_vertical;
        private System.Windows.Forms.Button SobelEdge_horizontal;
        private System.Windows.Forms.Button SobelEdge_combined;
        private System.Windows.Forms.Button Binary_overlap;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ImportFileB;
        private System.Windows.Forms.Button ImageRegistraion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button ImportFileA;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}

