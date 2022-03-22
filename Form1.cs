using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace E24066462_hw1
{
    public partial class Form1 : Form
    {
        // variable declare
        Bitmap openImg;
        Bitmap resultImg;
        //For problem 6
        Bitmap Sobel_resultImg;
        Bitmap Threshold_resultImg;
        Bitmap overlapImg;
        //For porblem 7
        Bitmap transImg;
        Bitmap scaledImg;
        List<Point> PointsData_A;//declare
        List<Point> PointsData_B;//declare

        public Form1()
        {
            PointsData_A = new List<Point>();//initialize
            PointsData_B = new List<Point>();//initialize
            InitializeComponent();
            chart1.Visible = false;
            chart2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Read File
        private void OpenFile_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            chart1.Visible = false;
            chart2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            //openFileDialog1.InitialDirectory="C:";
            openFileDialog1.Filter = "All Files|*.*|Bitmap Files( .bmp)|*.bmp|Jpeg File( .jpg)|*.jpg";
            //choose what type of file will be open
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //declare the bitmap of image
                openImg = new Bitmap(openFileDialog1.FileName);
                resultImg = new Bitmap(openFileDialog1.FileName);
                //for problem 6
                Sobel_resultImg = new Bitmap(openFileDialog1.FileName);
                Threshold_resultImg = new Bitmap(openFileDialog1.FileName);
                overlapImg = new Bitmap(openFileDialog1.FileName);
                //show the image on pictureBox
                pictureBox1.Image = openImg;
            }
        }
        //Save File
        private void SaveFile_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "All Files|*.*|Bitmap Files( .bmp)|*.bmp|Jpeg File( .jpg)|*.jpg";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                resultImg.Save(sfd.FileName);
            }

        }
        //Undo button
        private void Undo_Click(object sender, EventArgs e)
        {
            resultImg = openImg;
            pictureBox2.Image = resultImg;
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox5.Refresh();
            pictureBox6.Refresh();
            pictureBox7.Refresh();
            chart1.Visible = false;
            chart2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            PointsData_A.Clear();
            PointsData_B.Clear();
        }

        ////////////////openFile/saveFile declare/////////////////
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

       

        ////////////Functions of Methods Declare//////////////
        ////*problem 1*/
        //Extract R
        private void R_channel_extraction_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < openImg.Height; y++)
            {
                for (int x = 0; x < openImg.Width; x++)
                {
                    //read the (x,y) RGB data on the image plane
                    Color RGB = openImg.GetPixel(x, y);
                    //RGB is the class in VS can read the color data
                    int R = RGB.R;
                    resultImg.SetPixel(x, y, Color.FromArgb(R, R, R));

                }
            }
            //display the result
            pictureBox2.Image = resultImg;
        }
        //Extract G
        private void G_channel_extraction_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < openImg.Height; y++)
            {
                for (int x = 0; x < openImg.Width; x++)
                {

                    //read the (x,y) RGB data on the image plane
                    Color RGB = openImg.GetPixel(x, y);
                    //RGB is the class in VS can read the color data
                    int G = RGB.G;
                    resultImg.SetPixel(x, y, Color.FromArgb(G, G, G));

                }
            }
            //display the result
            pictureBox2.Image = resultImg;
        }
        //Extract B
        private void B_channel_extraction_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < openImg.Height; y++)
            {
                for (int x = 0; x < openImg.Width; x++)
                {
                    //read the (x,y) RGB data on the image plane
                    Color RGB = openImg.GetPixel(x, y);
                    //RGB is the class in VS can read the color data
                    int B = RGB.B;
                    resultImg.SetPixel(x, y, Color.FromArgb(B, B, B));

                }
            }
            //display the result
            pictureBox2.Image = resultImg;
        }
        //Gray Scale
        private void GrayScale_change_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < openImg.Height; y++)
            {
                for (int x = 0; x < openImg.Width; x++)
                {
                    //read the (x,y) RGB data on the image plane
                    Color RGB = openImg.GetPixel(x, y);
                    //RGB is the class in VS can read the color data

                    int gray = (299 * RGB.R + 587 * RGB.G + 114 * RGB.B) / 1000;

                    resultImg.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            //display the result
            pictureBox2.Image = resultImg;
        }

        /*problem 2*/
        //implement a 3*3 mask
        private void MeanFilter_Click(object sender, EventArgs e)
        {
            for (int y = 1; y < openImg.Height - 1; y++)
            {
                for (int x = 1; x < openImg.Width - 1; x++)
                {

                    int mean = (openImg.GetPixel(x - 1, y - 1).R + openImg.GetPixel(x, y - 1).R + openImg.GetPixel(x + 1, y - 1).R +
                                 openImg.GetPixel(x - 1, y).R + openImg.GetPixel(x, y).R + openImg.GetPixel(x + 1, y).R +
                                 openImg.GetPixel(x - 1, y + 1).R + openImg.GetPixel(x, y + 1).R + openImg.GetPixel(x + 1, y + 1).R) / 9;

                    resultImg.SetPixel(x, y, Color.FromArgb(mean, mean, mean));
                }
            }
            //display the result
            pictureBox2.Image = resultImg;
        }
        private void MedianFilter_Click(object sender, EventArgs e)
        {
            //|   |   |   |
            //=============
            //|   |x,y|   |
            //=============
            //|   |   |   |

            List<int> sortarray = new List<int>();//new a sortarray

            for (int y = 1; y < openImg.Height - 1; y++)
            {
                for (int x = 1; x < openImg.Width - 1; x++)
                {
                    sortarray.Add(openImg.GetPixel(x - 1, y - 1).R);
                    sortarray.Add(openImg.GetPixel(x, y - 1).R);
                    sortarray.Add(openImg.GetPixel(x + 1, y - 1).R);
                    sortarray.Add(openImg.GetPixel(x - 1, y).R);
                    sortarray.Add(openImg.GetPixel(x, y).R);
                    sortarray.Add(openImg.GetPixel(x + 1, y).R);
                    sortarray.Add(openImg.GetPixel(x - 1, y + 1).R);
                    sortarray.Add(openImg.GetPixel(x, y + 1).R);
                    sortarray.Add(openImg.GetPixel(x + 1, y + 1).R);
                    //object median = sortarray[4];
                    int[] after_sorting = sortarray.ToArray();
                    sortarray.Clear();
                    Array.Sort<int>(after_sorting); //依大小排序並存進after_sorting
                    //Array.Reverse(terms);
                    int median = after_sorting[4];
                    resultImg.SetPixel(x, y, Color.FromArgb(median, median, median));
                }
            }
            //display the result
            pictureBox2.Image = resultImg;
        }

        /*problem 3*/
        private void HistogramEqualization_Click(object sender, EventArgs e)
        {

            chart1.Visible = true;
            chart2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            int grayLevel = 256;
            double[] CountingTimes = new double[grayLevel];//counting the intensity appearing times from 0~255
            double[] SumCounting = new double[grayLevel];//the summation of appearing times
            double[] Probability = new double[grayLevel];//the probability that the summation inflects
            int pixelNum = 0;

            for (int y = 0; y < openImg.Height; y++) //scan all the pixels and count how many pixel in the picture
            {
                for (int x = 0; x < openImg.Width; x++)
                {
                    CountingTimes[openImg.GetPixel(x, y).R]++;//count the intensity appearing times in CountingTimes array
                    pixelNum++;
                }
            }

            for (int i = 0; i < grayLevel; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, CountingTimes[i]);//draw original image histogram
                if (i == 0)
                {//處理第一個前面沒有值的問題
                    SumCounting[i] = CountingTimes[i];
                    Probability[i] = Math.Round(SumCounting[i] * 255 / pixelNum);
                }
                else
                {//累加
                    SumCounting[i] = SumCounting[i - 1] + CountingTimes[i];
                    Probability[i] = Math.Round(SumCounting[i] * 255 / pixelNum); //normalized
                }
            }

            for (int y = 0; y < openImg.Height; y++)
            {
                for (int x = 0; x < openImg.Width; x++)
                {
                    int s = (int)Math.Round(Probability[openImg.GetPixel(x, y).R]);
                    resultImg.SetPixel(x, y, Color.FromArgb(s, s, s));

                }
            }

            //draw the result histogram
            for (int i = 0; i < grayLevel; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, CountingTimes[i]);//draw original image histogram
                chart2.Series[0].Points.AddXY(Probability[i], CountingTimes[i]);
            }
            pictureBox2.Image = resultImg;
        }

        /*problem 4*/
        //threshold method implement
        private void Thresholding_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("請輸入臨界值0~255!", "Warnings!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int threshold_t = int.Parse(textBox1.Text);

                for (int y = 0; y < openImg.Height; y++)
                {
                    for (int x = 0; x < openImg.Width; x++)
                    {
                        Color getColor = openImg.GetPixel(x, y);
                        if (getColor.R < threshold_t)//小於閾值就設為0
                        {
                            resultImg.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        }
                        else
                        {
                            resultImg.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        }

                    }
                }
                //display the result
                pictureBox2.Image = resultImg;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*problem 5*/
        private void SobelEdge_vertical_Click(object sender, EventArgs e)
        {

            int[,] maskVertical = new int[,] { { -1,-2,-1, },
                                               {  0, 0, 0, },
                                               {  1, 2, 1  } };

            for (int y = 1; y < openImg.Height - 1; y++)
            {
                for (int x = 1; x < openImg.Width - 1; x++)
                {
                    int maskdata1 = (openImg.GetPixel(x - 1, y - 1).R);
                    int maskdata2 = (openImg.GetPixel(x, y - 1).R);
                    int maskdata3 = (openImg.GetPixel(x + 1, y - 1).R);
                    int maskdata4 = (openImg.GetPixel(x - 1, y).R);
                    int maskdata5 = (openImg.GetPixel(x, y).R);
                    int maskdata6 = (openImg.GetPixel(x + 1, y).R);
                    int maskdata7 = (openImg.GetPixel(x - 1, y + 1).R);
                    int maskdata8 = (openImg.GetPixel(x, y + 1).R);
                    int maskdata9 = (openImg.GetPixel(x + 1, y + 1).R);

                    int vertical = maskVertical[0, 0] * maskdata1 + maskVertical[1, 0] * maskdata2 + maskVertical[2, 0] * maskdata3
                                 + maskVertical[0, 1] * maskdata4 + maskVertical[1, 1] * maskdata5 + maskVertical[2, 1] * maskdata6
                                 + maskVertical[0, 2] * maskdata7 + maskVertical[1, 2] * maskdata8 + maskVertical[2, 2] * maskdata9;
                    if (vertical < 0)
                    {
                        vertical = -vertical;
                    }

                    if (vertical > 255)
                    {
                        vertical = 255;
                    }

                    resultImg.SetPixel(x, y, Color.FromArgb(vertical, vertical, vertical));
                }
            }
            pictureBox2.Image = resultImg;

        }
        private void SobelEdge_horizontal_Click(object sender, EventArgs e)
        {

            int[,] maskHorizontal = new int[,] { { -1, 0, 1, },
                                                 { -2, 0, 2, },
                                                 { -1, 0, 1  } };
            for (int y = 1; y < openImg.Height - 1; y++)
            {
                for (int x = 1; x < openImg.Width - 1; x++)
                {
                    int maskdata1 = (openImg.GetPixel(x - 1, y - 1).R);
                    int maskdata2 = (openImg.GetPixel(x, y - 1).R);
                    int maskdata3 = (openImg.GetPixel(x + 1, y - 1).R);
                    int maskdata4 = (openImg.GetPixel(x - 1, y).R);
                    int maskdata5 = (openImg.GetPixel(x, y).R);
                    int maskdata6 = (openImg.GetPixel(x + 1, y).R);
                    int maskdata7 = (openImg.GetPixel(x - 1, y + 1).R);
                    int maskdata8 = (openImg.GetPixel(x, y + 1).R);
                    int maskdata9 = (openImg.GetPixel(x + 1, y + 1).R);

                    int horizontal = maskHorizontal[0, 0] * maskdata1 + maskHorizontal[1, 0] * maskdata2 + maskHorizontal[2, 0] * maskdata3
                                   + maskHorizontal[0, 1] * maskdata4 + maskHorizontal[1, 1] * maskdata5 + maskHorizontal[2, 1] * maskdata6
                                   + maskHorizontal[0, 2] * maskdata7 + maskHorizontal[1, 2] * maskdata8 + maskHorizontal[2, 2] * maskdata9;
                    if (horizontal < 0)
                    {
                        horizontal = -horizontal;
                    }

                    if (horizontal > 255)
                    {
                        horizontal = 255;
                    }
                    resultImg.SetPixel(x, y, Color.FromArgb(horizontal, horizontal, horizontal));
                }
            }
            pictureBox2.Image = resultImg;
        }
        private void SobelEdge_combined_Click(object sender, EventArgs e)
        {
            int[,] maskVertical = new int[,] { { -1,-2,-1, },
                                               {  0, 0, 0, },
                                               {  1, 2, 1  } };
            int[,] maskHorizontal = new int[,] { { -1, 0, 1, },
                                                 { -2, 0, 2, },
                                                 { -1, 0, 1  } };

            for (int y = 1; y < openImg.Height - 1; y++)
            {
                for (int x = 1; x < openImg.Width - 1; x++)
                {
                    int maskdata1 = (openImg.GetPixel(x - 1, y - 1).R);
                    int maskdata2 = (openImg.GetPixel(x, y - 1).R);
                    int maskdata3 = (openImg.GetPixel(x + 1, y - 1).R);
                    int maskdata4 = (openImg.GetPixel(x - 1, y).R);
                    int maskdata5 = (openImg.GetPixel(x, y).R);
                    int maskdata6 = (openImg.GetPixel(x + 1, y).R);
                    int maskdata7 = (openImg.GetPixel(x - 1, y + 1).R);
                    int maskdata8 = (openImg.GetPixel(x, y + 1).R);
                    int maskdata9 = (openImg.GetPixel(x + 1, y + 1).R);

                    int vertical = maskVertical[0, 0] * maskdata1 + maskVertical[1, 0] * maskdata2 + maskVertical[2, 0] * maskdata3
                                 + maskVertical[0, 1] * maskdata4 + maskVertical[1, 1] * maskdata5 + maskVertical[2, 1] * maskdata6
                                 + maskVertical[0, 2] * maskdata7 + maskVertical[1, 2] * maskdata8 + maskVertical[2, 2] * maskdata9;

                    int horizontal = maskHorizontal[0, 0] * maskdata1 + maskHorizontal[1, 0] * maskdata2 + maskHorizontal[2, 0] * maskdata3
                                   + maskHorizontal[0, 1] * maskdata4 + maskHorizontal[1, 1] * maskdata5 + maskHorizontal[2, 1] * maskdata6
                                   + maskHorizontal[0, 2] * maskdata7 + maskHorizontal[1, 2] * maskdata8 + maskHorizontal[2, 2] * maskdata9;
                    int combined = (int)Math.Sqrt(Math.Pow(vertical, 2) + Math.Pow(horizontal, 2));
                    if (combined < 0)
                    {
                        combined = -combined;
                    }

                    if (combined > 255)
                    {
                        combined = 255;
                    }

                    resultImg.SetPixel(x, y, Color.FromArgb(combined, combined, combined));
                }
            }
            pictureBox2.Image = resultImg;
        }

        /*problem 6*/
        private void Binary_overlap_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            if (textBox2.Text == "")
            {
                MessageBox.Show("請輸入臨界值0~255!", "Warnings!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //
                int[,] maskVertical = new int[,] { { -1,-2,-1, },
                                                   {  0, 0, 0, },
                                                   {  1, 2, 1  } };
                int[,] maskHorizontal = new int[,] { { -1, 0, 1, },
                                                     { -2, 0, 2, },
                                                     { -1, 0, 1  } };

                for (int y = 1; y < openImg.Height - 1; y++)
                {
                    for (int x = 1; x < openImg.Width - 1; x++)
                    {
                        int maskdata1 = (openImg.GetPixel(x - 1, y - 1).R);
                        int maskdata2 = (openImg.GetPixel(x, y - 1).R);
                        int maskdata3 = (openImg.GetPixel(x + 1, y - 1).R);
                        int maskdata4 = (openImg.GetPixel(x - 1, y).R);
                        int maskdata5 = (openImg.GetPixel(x, y).R);
                        int maskdata6 = (openImg.GetPixel(x + 1, y).R);
                        int maskdata7 = (openImg.GetPixel(x - 1, y + 1).R);
                        int maskdata8 = (openImg.GetPixel(x, y + 1).R);
                        int maskdata9 = (openImg.GetPixel(x + 1, y + 1).R);

                        int vertical = maskVertical[0, 0] * maskdata1 + maskVertical[1, 0] * maskdata2 + maskVertical[2, 0] * maskdata3
                                     + maskVertical[0, 1] * maskdata4 + maskVertical[1, 1] * maskdata5 + maskVertical[2, 1] * maskdata6
                                     + maskVertical[0, 2] * maskdata7 + maskVertical[1, 2] * maskdata8 + maskVertical[2, 2] * maskdata9;

                        int horizontal = maskHorizontal[0, 0] * maskdata1 + maskHorizontal[1, 0] * maskdata2 + maskHorizontal[2, 0] * maskdata3
                                       + maskHorizontal[0, 1] * maskdata4 + maskHorizontal[1, 1] * maskdata5 + maskHorizontal[2, 1] * maskdata6
                                       + maskHorizontal[0, 2] * maskdata7 + maskHorizontal[1, 2] * maskdata8 + maskHorizontal[2, 2] * maskdata9;
                        int combined = (int)Math.Sqrt(Math.Pow(vertical, 2) + Math.Pow(horizontal, 2));
                        if (combined < 0)
                        {
                            combined = -combined;
                        }

                        if (combined > 255)
                        {
                            combined = 255;
                        }

                        Sobel_resultImg.SetPixel(x, y, Color.FromArgb(combined, combined, combined));
                    }
                }
                pictureBox3.Image = Sobel_resultImg;

                int threshold_t = int.Parse(textBox2.Text);

                for (int y = 0; y < Sobel_resultImg.Height; y++)
                {
                    for (int x = 0; x < Sobel_resultImg.Width; x++)
                    {
                        Color getColor = Sobel_resultImg.GetPixel(x, y);
                        if (getColor.R < threshold_t)//小於閾值就設為0
                        {
                            Threshold_resultImg.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        }
                        else
                        {
                            Threshold_resultImg.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        }

                    }
                }
                //display the result
                pictureBox4.Image = Threshold_resultImg;
            }
            for (int y = 0; y < Threshold_resultImg.Height; y++)
            {
                for (int x = 0; x < Threshold_resultImg.Width; x++)
                {
                    // 讀取影像平面上(x,y)的RGB資訊
                    if (Threshold_resultImg.GetPixel(x, y).R < int.Parse(textBox2.Text))
                    {
                        overlapImg.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        overlapImg.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }

                    if (overlapImg.GetPixel(x, y).R == 255)
                    {
                        resultImg.SetPixel(x, y, Color.FromArgb(0, 255, 0));//green color
                    }
                }
            }
            pictureBox2.Image = resultImg;

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /*problem 7*/
        // mark the four points in picture A
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g_a = ((PictureBox)sender).CreateGraphics();//create a graphic board
            g_a.FillEllipse(Brushes.Red, e.X, e.Y, 10, 10);
            Point pt_a = new Point(e.X, e.Y);
            PointsData_A.Add(pt_a);
            //g.Dispose();
        }
        // Paint事件
        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {
            Graphics g_a = e.Graphics;
            foreach (Point pt_a in PointsData_A)
            {
                g_a.FillEllipse(Brushes.Red, pt_a.X, pt_a.Y, 10, 10);
            }
            //g.Dispose();
        }
        // mark the four points in picture B
        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g_b = ((PictureBox)sender).CreateGraphics();//create a graphic board
            g_b.FillEllipse(Brushes.Red, e.X, e.Y, 10, 10);
            Point pt_b = new Point(e.X, e.Y);
            PointsData_B.Add(pt_b);//store the point xy in list
        }
        private void pictureBox6_Paint(object sender, PaintEventArgs e)
        {
            Graphics g_b = e.Graphics;
            foreach (Point pt_b in PointsData_B)
            {
                g_b.FillEllipse(Brushes.Red, pt_b.X, pt_b.Y, 10, 10);
            }
        }
        private void ImportFileA_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            chart1.Visible = false;
            chart2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            //openFileDialog1.InitialDirectory="C:";
            openFileDialog1.Filter = "All Files|*.*|Bitmap Files( .bmp)|*.bmp|Jpeg File( .jpg)|*.jpg";
            //choose what type of file will be open
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label16.Visible = true;
                openImg = new Bitmap(openFileDialog1.FileName);
                pictureBox5.Image = openImg;
            }


        }
        private void ImportFileB_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            chart1.Visible = false;
            chart2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            //openFileDialog1.InitialDirectory="C:";
            openFileDialog1.Filter = "All Files|*.*|Bitmap Files( .bmp)|*.bmp|Jpeg File( .jpg)|*.jpg";
            //choose what type of file will be open
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                label17.Visible = true;
                transImg = new Bitmap(openFileDialog1.FileName);
                pictureBox6.Image = transImg;
            }
        }
        private void ImageRegistraion_Click(object sender, EventArgs e)
        {

            if (PointsData_A[3].IsEmpty == true && PointsData_B[3].IsEmpty == true)
            {
                MessageBox.Show("請檢察是否已在A B圖內各取四個點以便做圖片轉換!", "Warnings!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                int scaledWidth = 0;
                int scaledHeight = 0;

                double LongSide_A = Math.Round((Math.Sqrt(Math.Pow((PointsData_A[1].X - PointsData_A[0].X), 2) + Math.Pow((PointsData_A[1].Y - PointsData_A[0].Y), 2))),5);
                double ShortSide_A =Math.Round(( Math.Sqrt(Math.Pow((PointsData_A[2].X - PointsData_A[0].X), 2) + Math.Pow((PointsData_A[2].Y - PointsData_A[0].Y), 2))),5);

                double LongSide_B = Math.Round((Math.Sqrt(Math.Pow((PointsData_B[1].X - PointsData_B[0].X), 2) + Math.Pow((PointsData_B[1].Y - PointsData_B[0].Y), 2))),5);
                double ShortSide_B =Math.Round(( Math.Sqrt(Math.Pow((PointsData_B[2].X - PointsData_B[0].X), 2) + Math.Pow((PointsData_B[2].Y - PointsData_B[0].Y), 2))),5);

                double scaleX = LongSide_A / LongSide_B;
                double scaleY = ShortSide_A / ShortSide_B;
          
                double[,] scalingArray = new double[,]{
                        {scaleX, 0, 0},
                        {0, scaleY, 0},
                        {0, 0, 1}
                    };
                int[] originalSize = new int[]{
                        transImg.Width, transImg.Height, 1
                    };

                //矩陣乘法
                for (int i = 0; i < 3; i++)
                {
                    scaledWidth += (int)(originalSize[i] * scalingArray[0, i]);
                }
                for (int i = 0; i < 3; i++)
                {
                    scaledHeight += (int)(originalSize[i] * scalingArray[1, i]);
                }


                scaledImg = new Bitmap(scaledWidth, scaledHeight);

                for (int y = 0; y < scaledHeight; y++)
                {
                    for (int x = 0; x < scaledWidth; x++)
                    {
                        // 讀取影像平面上(x,y)的RGB資訊

                        int pixelX = (int)(x / scaleX);
                        int pixelY = (int)(y / scaleY);
                        Color scaledColor = transImg.GetPixel(pixelX, pixelY);

                        scaledImg.SetPixel(x, y, Color.FromArgb(scaledColor.R, scaledColor.G, scaledColor.B));

                    }

                }
                
                ///////////////////rotate//////////////////////
                //find the angle from horizontal line
                double m_ARad = Math.Atan2((PointsData_A[1].X - PointsData_A[0].X), (PointsData_A[1].Y - PointsData_A[0].Y));
                double m_BRad = Math.Atan2((PointsData_B[1].X - PointsData_B[0].X), (PointsData_B[1].Y - PointsData_B[0].Y));
                //double rotateRad =-30.0 * 0.01745329252;
                //calculate the difference rad between A and B 
                double rotateRad = m_BRad - m_ARad;

                //從scaling後的height and width 找新的width and height
                int resultWidth = GetNewWidth(scaledWidth, scaledHeight, rotateRad);
                int resultHeight = GetNewHeight(scaledWidth, scaledHeight, rotateRad);
                resultImg = new Bitmap(resultWidth, resultHeight);

                double halfLastWidth = 0.5 * (scaledWidth);
                double halfLastHeight = 0.5 * (scaledHeight);
                double halfResultWidth = 0.5 * (resultWidth);
                double halfResultHeight = 0.5 * (resultHeight);

                // 做逆轉換
                double shiftX = -halfResultWidth * Math.Cos(rotateRad) - halfResultHeight * Math.Sin(rotateRad) + halfLastWidth;
                double shiftY = halfResultWidth * Math.Sin(rotateRad) - halfResultHeight * Math.Cos(rotateRad) + halfLastHeight;
                for (int y = 0; y < resultHeight; ++y)
                {
                    for (int x = 0; x < resultWidth; ++x)
                    {
                        int pixelX = (int)(x * Math.Cos(rotateRad) + y * Math.Sin(rotateRad) + shiftX);
                        int pixelY = (int)(-x * Math.Sin(rotateRad) + y * Math.Cos(rotateRad) + shiftY);
                        // 寫入
                        if (pixelY >= 0 && pixelY < scaledHeight && pixelX >= 0 && pixelX < scaledWidth)
                        {
                            Color resultColor = scaledImg.GetPixel(pixelX, pixelY);
                            resultImg.SetPixel(x, y, Color.FromArgb(resultColor.R, resultColor.G, resultColor.B));
                        }

                    }
                }
                pictureBox7.Image = resultImg;
            }

        }
        private int GetNewHeight(int width, int height, double rotateRad)
        {
            double x_bound1 = 0;
            double y_bound1 = 0;

            double x_bound2 = width;
            double y_bound2 = 0;

            double x_bound3 = width;
            double y_bound3 = height;

            double x_bound4 = 0;
            double y_bound4 = height;

            // 旋轉後四個角點
            // nx=(int)(vcos*x - vsin*y);
            double ny_bound1 = Math.Sin(rotateRad) * x_bound1 + Math.Cos(rotateRad) * y_bound1;
            double ny_bound2 = Math.Sin(rotateRad) * x_bound2 + Math.Cos(rotateRad) * y_bound2;
            double ny_bound3 = Math.Sin(rotateRad) * x_bound3 + Math.Cos(rotateRad) * y_bound3;
            double ny_bound4 = Math.Sin(rotateRad) * x_bound4 + Math.Cos(rotateRad) * y_bound4;


            double y_max = Math.Max(ny_bound1, Math.Max(ny_bound2, Math.Max(ny_bound3, ny_bound4)));//取最大Y
            double y_min = Math.Min(ny_bound1, Math.Min(ny_bound2, Math.Min(ny_bound3, ny_bound4)));//取最小Y

            return (int)(y_max - y_min);
        }
        private int GetNewWidth(int width, int height, double rotateRad)
        {
            double x_bound1 = 0;
            double y_bound1 = 0;

            double x_bound2 = width;
            double y_bound2 = 0;

            double x_bound3 = width;
            double y_bound3 = height;

            double x_bound4 = 0;
            double y_bound4 = height;

            // 旋轉後
            double nx_bound1 = Math.Cos(rotateRad) * x_bound1 - Math.Sin(rotateRad) * y_bound1;
            double nx_bound2 = Math.Cos(rotateRad) * x_bound2 - Math.Sin(rotateRad) * y_bound2;
            double nx_bound3 = Math.Cos(rotateRad) * x_bound3 - Math.Sin(rotateRad) * y_bound3;
            double nx_bound4 = Math.Cos(rotateRad) * x_bound4 - Math.Sin(rotateRad) * y_bound4;

            double x_max = Math.Max(nx_bound1, Math.Max(nx_bound2, Math.Max(nx_bound3, nx_bound4)));//取最大X
            double x_min = Math.Min(nx_bound1, Math.Min(nx_bound2, Math.Min(nx_bound3, nx_bound4)));//取最小X

            return (int)(x_max - x_min);

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var mouseArgs = (MouseEventArgs)e;// coordinates are now available in mouseArgs.X and mouseArgs.Y 
        }
        
    }
}
