﻿namespace _0128_Vibrometer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.tChart1 = new Steema.TeeChart.TChart();
            this.lineWave = new Steema.TeeChart.Styles.Line();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tChart2 = new Steema.TeeChart.TChart();
            this.lineFFT = new Steema.TeeChart.Styles.Line();
            this.tChart3 = new Steema.TeeChart.TChart();
            this.lineP2P = new Steema.TeeChart.Styles.Line();
            this.lineRMS = new Steema.TeeChart.Styles.Line();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartBtn.Location = new System.Drawing.Point(412, 2);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(207, 87);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StopBtn.Location = new System.Drawing.Point(655, 5);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(193, 87);
            this.StopBtn.TabIndex = 1;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Axes.Bottom.Labels.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            this.tChart1.Axes.Bottom.Labels.Separation = 5;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Bottom.RelativePosition = 50D;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Axes.Bottom.Title.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Bottom.Title.Font.Size = 11;
            this.tChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Axes.Depth.Labels.Brush.Solid = true;
            this.tChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.tChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Depth.Labels.Font.Size = 9;
            this.tChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Axes.Depth.Title.Brush.Solid = true;
            this.tChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            this.tChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Depth.Title.Font.Size = 11;
            this.tChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.DepthTop.Labels.Font.Size = 9;
            this.tChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Axes.DepthTop.Title.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.DepthTop.Title.Font.Size = 11;
            this.tChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Axes.Left.Labels.Brush.Solid = true;
            this.tChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            this.tChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Left.Labels.Font.Size = 9;
            this.tChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Axes.Left.Title.Brush.Solid = true;
            this.tChart1.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Left.Title.Font.Brush.Solid = true;
            this.tChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Left.Title.Font.Size = 11;
            this.tChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Axes.Right.Labels.Brush.Solid = true;
            this.tChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            this.tChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Right.Labels.Font.Size = 9;
            this.tChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Axes.Right.Title.Brush.Solid = true;
            this.tChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Right.Title.Font.Brush.Solid = true;
            this.tChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Right.Title.Font.Size = 11;
            this.tChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Axes.Top.Labels.Brush.Solid = true;
            this.tChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            this.tChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Top.Labels.Font.Size = 9;
            this.tChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Axes.Top.Title.Brush.Solid = true;
            this.tChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Top.Title.Font.Brush.Solid = true;
            this.tChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Top.Title.Font.Size = 11;
            this.tChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.tChart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Footer.Brush.Solid = true;
            this.tChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChart1.Footer.Font.Brush.Solid = true;
            this.tChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Footer.Font.Shadow.Brush.Solid = true;
            this.tChart1.Footer.Font.Shadow.Brush.Visible = true;
            this.tChart1.Footer.Font.Size = 8;
            this.tChart1.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Footer.ImageBevel.Brush.Solid = true;
            this.tChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Footer.Shadow.Brush.Solid = true;
            this.tChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart1.Header.Brush.Solid = true;
            this.tChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Header.Font.Brush.Solid = true;
            this.tChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Header.Font.Shadow.Brush.Solid = true;
            this.tChart1.Header.Font.Shadow.Brush.Visible = true;
            this.tChart1.Header.Font.Size = 12;
            this.tChart1.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Header.ImageBevel.Brush.Solid = true;
            this.tChart1.Header.ImageBevel.Brush.Visible = true;
            this.tChart1.Header.Lines = new string[] {
        "Vibrometer"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart1.Header.Shadow.Brush.Solid = true;
            this.tChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Legend.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Legend.Brush.Solid = true;
            this.tChart1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Legend.Font.Brush.Solid = true;
            this.tChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Legend.Font.Shadow.Brush.Solid = true;
            this.tChart1.Legend.Font.Shadow.Brush.Visible = true;
            this.tChart1.Legend.Font.Size = 9;
            this.tChart1.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Legend.ImageBevel.Brush.Solid = true;
            this.tChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Legend.Shadow.Brush.Solid = true;
            this.tChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            this.tChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Legend.Title.Brush.Solid = true;
            this.tChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.tChart1.Legend.Title.Font.Brush.Solid = true;
            this.tChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.tChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.tChart1.Legend.Title.Font.Size = 8;
            this.tChart1.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            this.tChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Legend.Title.Shadow.Brush.Solid = true;
            this.tChart1.Legend.Title.Shadow.Brush.Visible = true;
            this.tChart1.Legend.Visible = false;
            this.tChart1.Location = new System.Drawing.Point(3, 3);
            this.tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Brush.Solid = true;
            this.tChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Panel.ImageBevel.Brush.Solid = true;
            this.tChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Panel.Shadow.Brush.Solid = true;
            this.tChart1.Panel.Shadow.Brush.Visible = true;
            this.tChart1.Series.Add(this.lineWave);
            this.tChart1.Size = new System.Drawing.Size(1198, 411);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.SubFooter.Brush.Solid = true;
            this.tChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChart1.SubFooter.Font.Brush.Solid = true;
            this.tChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            this.tChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            this.tChart1.SubFooter.Font.Size = 8;
            this.tChart1.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.SubFooter.ImageBevel.Brush.Solid = true;
            this.tChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.SubFooter.Shadow.Brush.Solid = true;
            this.tChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart1.SubHeader.Brush.Solid = true;
            this.tChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.SubHeader.Font.Brush.Solid = true;
            this.tChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            this.tChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            this.tChart1.SubHeader.Font.Size = 12;
            this.tChart1.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.SubHeader.ImageBevel.Brush.Solid = true;
            this.tChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart1.SubHeader.Shadow.Brush.Solid = true;
            this.tChart1.SubHeader.Shadow.Brush.Visible = true;
            this.tChart1.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Walls.Back.Brush.Solid = true;
            this.tChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            this.tChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Walls.Back.Shadow.Brush.Solid = true;
            this.tChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Walls.Bottom.Brush.Solid = true;
            this.tChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.tChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            this.tChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChart1.Walls.Left.Brush.Solid = true;
            this.tChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            this.tChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Walls.Left.Shadow.Brush.Solid = true;
            this.tChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChart1.Walls.Right.Brush.Solid = true;
            this.tChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            this.tChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Walls.Right.Shadow.Brush.Solid = true;
            this.tChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.tChart1.Zoom.Brush.Solid = true;
            this.tChart1.Zoom.Brush.Visible = true;
            // 
            // lineWave
            // 
            // 
            // 
            // 
            this.lineWave.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.lineWave.Brush.Solid = true;
            this.lineWave.Brush.Visible = true;
            this.lineWave.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.lineWave.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineWave.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.lineWave.Legend.Brush.Color = System.Drawing.Color.White;
            this.lineWave.Legend.Brush.Solid = true;
            this.lineWave.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.lineWave.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.lineWave.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.lineWave.Legend.Font.Brush.Solid = true;
            this.lineWave.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineWave.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.lineWave.Legend.Font.Shadow.Brush.Solid = true;
            this.lineWave.Legend.Font.Shadow.Brush.Visible = true;
            this.lineWave.Legend.Font.Size = 8;
            this.lineWave.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineWave.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.lineWave.Legend.ImageBevel.Brush.Solid = true;
            this.lineWave.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineWave.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.lineWave.Legend.Shadow.Brush.Solid = true;
            this.lineWave.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.lineWave.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineWave.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.lineWave.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lineWave.Marks.Brush.Solid = true;
            this.lineWave.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.lineWave.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.lineWave.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.lineWave.Marks.Font.Brush.Solid = true;
            this.lineWave.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineWave.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.lineWave.Marks.Font.Shadow.Brush.Solid = true;
            this.lineWave.Marks.Font.Shadow.Brush.Visible = true;
            this.lineWave.Marks.Font.Size = 8;
            this.lineWave.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineWave.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.lineWave.Marks.ImageBevel.Brush.Solid = true;
            this.lineWave.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineWave.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.lineWave.Marks.Shadow.Brush.Solid = true;
            this.lineWave.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineWave.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.lineWave.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.lineWave.Marks.Symbol.Brush.Solid = true;
            this.lineWave.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineWave.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.lineWave.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.lineWave.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineWave.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.lineWave.Marks.Symbol.Shadow.Brush.Solid = true;
            this.lineWave.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.lineWave.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
            this.lineWave.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.lineWave.Marks.TailParams.Margin = 0F;
            this.lineWave.Marks.TailParams.PointerHeight = 8D;
            this.lineWave.Marks.TailParams.PointerWidth = 8D;
            this.lineWave.OriginalCursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineWave.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.lineWave.Pointer.Brush.Solid = true;
            this.lineWave.Pointer.Brush.Visible = true;
            this.lineWave.Pointer.SizeDouble = 0D;
            this.lineWave.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.lineWave.Title = "lineWave";
            this.lineWave.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.lineWave.XValues.DataMember = "X";
            this.lineWave.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineWave.YValues.DataMember = "Y";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 1265);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tChart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tChart2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tChart3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1204, 1265);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tChart2
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Axes.Bottom.Labels.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Bottom.Labels.Font.Size = 9;
            this.tChart2.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.Axes.Bottom.Title.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Bottom.Title.Font.Size = 11;
            this.tChart2.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Axes.Depth.Labels.Brush.Solid = true;
            this.tChart2.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.tChart2.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Depth.Labels.Font.Size = 9;
            this.tChart2.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.Axes.Depth.Title.Brush.Solid = true;
            this.tChart2.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Axes.Depth.Title.Font.Brush.Solid = true;
            this.tChart2.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Depth.Title.Font.Size = 11;
            this.tChart2.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Axes.DepthTop.Labels.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.DepthTop.Labels.Font.Size = 9;
            this.tChart2.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.Axes.DepthTop.Title.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.DepthTop.Title.Font.Size = 11;
            this.tChart2.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Axes.Left.Labels.Brush.Solid = true;
            this.tChart2.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.Axes.Left.Labels.Font.Brush.Solid = true;
            this.tChart2.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Left.Labels.Font.Size = 9;
            this.tChart2.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.Axes.Left.Title.Brush.Solid = true;
            this.tChart2.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Axes.Left.Title.Font.Brush.Solid = true;
            this.tChart2.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Left.Title.Font.Size = 11;
            this.tChart2.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Axes.Right.Labels.Brush.Solid = true;
            this.tChart2.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.Axes.Right.Labels.Font.Brush.Solid = true;
            this.tChart2.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Right.Labels.Font.Size = 9;
            this.tChart2.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.tChart2.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.Axes.Right.Title.Brush.Solid = true;
            this.tChart2.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Axes.Right.Title.Font.Brush.Solid = true;
            this.tChart2.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Right.Title.Font.Size = 11;
            this.tChart2.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Axes.Top.Labels.Brush.Solid = true;
            this.tChart2.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.Axes.Top.Labels.Font.Brush.Solid = true;
            this.tChart2.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Top.Labels.Font.Size = 9;
            this.tChart2.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart2.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.Axes.Top.Title.Brush.Solid = true;
            this.tChart2.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Axes.Top.Title.Font.Brush.Solid = true;
            this.tChart2.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Top.Title.Font.Size = 11;
            this.tChart2.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.tChart2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.Footer.Brush.Solid = true;
            this.tChart2.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChart2.Footer.Font.Brush.Solid = true;
            this.tChart2.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Footer.Font.Shadow.Brush.Solid = true;
            this.tChart2.Footer.Font.Shadow.Brush.Visible = true;
            this.tChart2.Footer.Font.Size = 8;
            this.tChart2.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Footer.ImageBevel.Brush.Solid = true;
            this.tChart2.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Footer.Shadow.Brush.Solid = true;
            this.tChart2.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart2.Header.Brush.Solid = true;
            this.tChart2.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Header.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.Header.Font.Brush.Solid = true;
            this.tChart2.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Header.Font.Shadow.Brush.Solid = true;
            this.tChart2.Header.Font.Shadow.Brush.Visible = true;
            this.tChart2.Header.Font.Size = 12;
            this.tChart2.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Header.ImageBevel.Brush.Solid = true;
            this.tChart2.Header.ImageBevel.Brush.Visible = true;
            this.tChart2.Header.Lines = new string[] {
        "FFT"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart2.Header.Shadow.Brush.Solid = true;
            this.tChart2.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Legend.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Legend.Brush.Solid = true;
            this.tChart2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Legend.Font.Brush.Solid = true;
            this.tChart2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Legend.Font.Shadow.Brush.Solid = true;
            this.tChart2.Legend.Font.Shadow.Brush.Visible = true;
            this.tChart2.Legend.Font.Size = 9;
            this.tChart2.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Legend.ImageBevel.Brush.Solid = true;
            this.tChart2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart2.Legend.Shadow.Brush.Solid = true;
            this.tChart2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Legend.Symbol.Shadow.Brush.Solid = true;
            this.tChart2.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Legend.Title.Brush.Solid = true;
            this.tChart2.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.tChart2.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.tChart2.Legend.Title.Font.Brush.Solid = true;
            this.tChart2.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.tChart2.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.tChart2.Legend.Title.Font.Size = 8;
            this.tChart2.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Legend.Title.ImageBevel.Brush.Solid = true;
            this.tChart2.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Legend.Title.Shadow.Brush.Solid = true;
            this.tChart2.Legend.Title.Shadow.Brush.Visible = true;
            this.tChart2.Legend.Visible = false;
            this.tChart2.Location = new System.Drawing.Point(3, 420);
            this.tChart2.Name = "tChart2";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart2.Panel.Brush.Solid = true;
            this.tChart2.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Panel.ImageBevel.Brush.Solid = true;
            this.tChart2.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Panel.Shadow.Brush.Solid = true;
            this.tChart2.Panel.Shadow.Brush.Visible = true;
            this.tChart2.Series.Add(this.lineFFT);
            this.tChart2.Size = new System.Drawing.Size(1198, 411);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.SubFooter.Brush.Solid = true;
            this.tChart2.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChart2.SubFooter.Font.Brush.Solid = true;
            this.tChart2.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.SubFooter.Font.Shadow.Brush.Solid = true;
            this.tChart2.SubFooter.Font.Shadow.Brush.Visible = true;
            this.tChart2.SubFooter.Font.Size = 8;
            this.tChart2.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.SubFooter.ImageBevel.Brush.Solid = true;
            this.tChart2.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.SubFooter.Shadow.Brush.Solid = true;
            this.tChart2.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart2.SubHeader.Brush.Solid = true;
            this.tChart2.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.SubHeader.Font.Brush.Solid = true;
            this.tChart2.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.SubHeader.Font.Shadow.Brush.Solid = true;
            this.tChart2.SubHeader.Font.Shadow.Brush.Visible = true;
            this.tChart2.SubHeader.Font.Size = 12;
            this.tChart2.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.SubHeader.ImageBevel.Brush.Solid = true;
            this.tChart2.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart2.SubHeader.Shadow.Brush.Solid = true;
            this.tChart2.SubHeader.Shadow.Brush.Visible = true;
            this.tChart2.TabIndex = 5;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.Walls.Back.Brush.Solid = true;
            this.tChart2.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Walls.Back.ImageBevel.Brush.Solid = true;
            this.tChart2.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Walls.Back.Shadow.Brush.Solid = true;
            this.tChart2.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Walls.Bottom.Brush.Solid = true;
            this.tChart2.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.tChart2.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Walls.Bottom.Shadow.Brush.Solid = true;
            this.tChart2.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChart2.Walls.Left.Brush.Solid = true;
            this.tChart2.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Walls.Left.ImageBevel.Brush.Solid = true;
            this.tChart2.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Walls.Left.Shadow.Brush.Solid = true;
            this.tChart2.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart2.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChart2.Walls.Right.Brush.Solid = true;
            this.tChart2.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Walls.Right.ImageBevel.Brush.Solid = true;
            this.tChart2.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Walls.Right.Shadow.Brush.Solid = true;
            this.tChart2.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.tChart2.Zoom.Brush.Solid = true;
            this.tChart2.Zoom.Brush.Visible = true;
            // 
            // lineFFT
            // 
            // 
            // 
            // 
            this.lineFFT.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.lineFFT.Brush.Solid = true;
            this.lineFFT.Brush.Visible = true;
            this.lineFFT.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.lineFFT.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineFFT.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.lineFFT.Legend.Brush.Color = System.Drawing.Color.White;
            this.lineFFT.Legend.Brush.Solid = true;
            this.lineFFT.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.lineFFT.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.lineFFT.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.lineFFT.Legend.Font.Brush.Solid = true;
            this.lineFFT.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineFFT.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.lineFFT.Legend.Font.Shadow.Brush.Solid = true;
            this.lineFFT.Legend.Font.Shadow.Brush.Visible = true;
            this.lineFFT.Legend.Font.Size = 8;
            this.lineFFT.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineFFT.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.lineFFT.Legend.ImageBevel.Brush.Solid = true;
            this.lineFFT.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineFFT.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.lineFFT.Legend.Shadow.Brush.Solid = true;
            this.lineFFT.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.lineFFT.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineFFT.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.lineFFT.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lineFFT.Marks.Brush.Solid = true;
            this.lineFFT.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.lineFFT.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.lineFFT.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.lineFFT.Marks.Font.Brush.Solid = true;
            this.lineFFT.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineFFT.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.lineFFT.Marks.Font.Shadow.Brush.Solid = true;
            this.lineFFT.Marks.Font.Shadow.Brush.Visible = true;
            this.lineFFT.Marks.Font.Size = 8;
            this.lineFFT.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineFFT.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.lineFFT.Marks.ImageBevel.Brush.Solid = true;
            this.lineFFT.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineFFT.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.lineFFT.Marks.Shadow.Brush.Solid = true;
            this.lineFFT.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineFFT.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.lineFFT.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.lineFFT.Marks.Symbol.Brush.Solid = true;
            this.lineFFT.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineFFT.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.lineFFT.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.lineFFT.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineFFT.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.lineFFT.Marks.Symbol.Shadow.Brush.Solid = true;
            this.lineFFT.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.lineFFT.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
            this.lineFFT.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.lineFFT.Marks.TailParams.Margin = 0F;
            this.lineFFT.Marks.TailParams.PointerHeight = 8D;
            this.lineFFT.Marks.TailParams.PointerWidth = 8D;
            this.lineFFT.OriginalCursor = null;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineFFT.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.lineFFT.Pointer.Brush.Solid = true;
            this.lineFFT.Pointer.Brush.Visible = true;
            this.lineFFT.Pointer.SizeDouble = 0D;
            this.lineFFT.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.lineFFT.Title = "line_fft";
            this.lineFFT.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.lineFFT.XValues.DataMember = "X";
            this.lineFFT.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineFFT.YValues.DataMember = "Y";
            // 
            // tChart3
            // 
            // 
            // 
            // 
            this.tChart3.Aspect.ColorPaletteIndex = -1;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart3.Axes.Bottom.Labels.Brush.Solid = true;
            this.tChart3.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart3.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart3.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.tChart3.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart3.Axes.Bottom.Labels.Font.Size = 8;
            this.tChart3.Axes.Bottom.Labels.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.tChart3.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart3.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart3.Axes.Bottom.Title.Brush.Solid = true;
            this.tChart3.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart3.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart3.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.tChart3.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.tChart3.Axes.Bottom.Title.Font.Size = 8;
            this.tChart3.Axes.Bottom.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.tChart3.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart3.Axes.Depth.Labels.Brush.Solid = true;
            this.tChart3.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart3.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart3.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.tChart3.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart3.Axes.Depth.Labels.Font.Size = 8;
            this.tChart3.Axes.Depth.Labels.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.tChart3.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart3.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart3.Axes.Depth.Title.Brush.Solid = true;
            this.tChart3.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart3.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart3.Axes.Depth.Title.Font.Brush.Solid = true;
            this.tChart3.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.tChart3.Axes.Depth.Title.Font.Size = 8;
            this.tChart3.Axes.Depth.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.tChart3.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart3.Axes.DepthTop.Labels.Brush.Solid = true;
            this.tChart3.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart3.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart3.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.tChart3.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart3.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart3.Axes.DepthTop.Labels.Font.Size = 8;
            this.tChart3.Axes.DepthTop.Labels.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.tChart3.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.tChart3.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart3.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart3.Axes.DepthTop.Title.Brush.Solid = true;
            this.tChart3.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart3.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart3.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.tChart3.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.tChart3.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.tChart3.Axes.DepthTop.Title.Font.Size = 8;
            this.tChart3.Axes.DepthTop.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.tChart3.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.tChart3.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Left.Grid.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart3.Axes.Left.Labels.Brush.Solid = true;
            this.tChart3.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart3.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart3.Axes.Left.Labels.Font.Brush.Solid = true;
            this.tChart3.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart3.Axes.Left.Labels.Font.Size = 8;
            this.tChart3.Axes.Left.Labels.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.tChart3.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.tChart3.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart3.Axes.Left.Title.Brush.Solid = true;
            this.tChart3.Axes.Left.Title.Brush.Visible = true;
            this.tChart3.Axes.Left.Title.Caption = "Lms";
            // 
            // 
            // 
            this.tChart3.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart3.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart3.Axes.Left.Title.Font.Brush.Solid = true;
            this.tChart3.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.tChart3.Axes.Left.Title.Font.Size = 8;
            this.tChart3.Axes.Left.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.tChart3.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            this.tChart3.Axes.Left.Title.Lines = new string[] {
        "Lms"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Right.Grid.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart3.Axes.Right.Labels.Brush.Solid = true;
            this.tChart3.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart3.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart3.Axes.Right.Labels.Font.Brush.Solid = true;
            this.tChart3.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart3.Axes.Right.Labels.Font.Size = 8;
            this.tChart3.Axes.Right.Labels.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.tChart3.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.tChart3.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart3.Axes.Right.Title.Brush.Solid = true;
            this.tChart3.Axes.Right.Title.Brush.Visible = true;
            this.tChart3.Axes.Right.Title.Caption = "Peak";
            // 
            // 
            // 
            this.tChart3.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart3.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart3.Axes.Right.Title.Font.Brush.Solid = true;
            this.tChart3.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.tChart3.Axes.Right.Title.Font.Size = 8;
            this.tChart3.Axes.Right.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.tChart3.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            this.tChart3.Axes.Right.Title.Lines = new string[] {
        "Peak"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart3.Axes.Top.Labels.Brush.Solid = true;
            this.tChart3.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart3.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart3.Axes.Top.Labels.Font.Brush.Solid = true;
            this.tChart3.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart3.Axes.Top.Labels.Font.Size = 8;
            this.tChart3.Axes.Top.Labels.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.tChart3.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart3.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart3.Axes.Top.Title.Brush.Solid = true;
            this.tChart3.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart3.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart3.Axes.Top.Title.Font.Brush.Solid = true;
            this.tChart3.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.tChart3.Axes.Top.Title.Font.Size = 8;
            this.tChart3.Axes.Top.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.tChart3.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.tChart3.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.tChart3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tChart3.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.tChart3.Footer.Brush.Solid = true;
            this.tChart3.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.tChart3.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChart3.Footer.Font.Brush.Solid = true;
            this.tChart3.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Footer.Font.Shadow.Brush.Solid = true;
            this.tChart3.Footer.Font.Shadow.Brush.Visible = true;
            this.tChart3.Footer.Font.Size = 8;
            this.tChart3.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Footer.ImageBevel.Brush.Solid = true;
            this.tChart3.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Footer.Shadow.Brush.Solid = true;
            this.tChart3.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.tChart3.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart3.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart3.Header.Brush.Gradient.SigmaFocus = 0F;
            this.tChart3.Header.Brush.Gradient.SigmaScale = 0F;
            this.tChart3.Header.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart3.Header.Brush.Solid = true;
            this.tChart3.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Header.Font.Bold = false;
            // 
            // 
            // 
            this.tChart3.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart3.Header.Font.Brush.Solid = true;
            this.tChart3.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Header.Font.Shadow.Brush.Solid = true;
            this.tChart3.Header.Font.Shadow.Brush.Visible = true;
            this.tChart3.Header.Font.Size = 8;
            this.tChart3.Header.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Header.ImageBevel.Brush.Solid = true;
            this.tChart3.Header.ImageBevel.Brush.Visible = true;
            this.tChart3.Header.Lines = new string[] {
        "Trend"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart3.Header.Shadow.Brush.Solid = true;
            this.tChart3.Header.Shadow.Brush.Visible = true;
            this.tChart3.Header.Shadow.Height = 0;
            this.tChart3.Header.Shadow.Width = 0;
            // 
            // 
            // 
            this.tChart3.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
            // 
            // 
            // 
            this.tChart3.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tChart3.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.tChart3.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart3.Legend.Brush.Gradient.SigmaFocus = 0F;
            this.tChart3.Legend.Brush.Gradient.SigmaScale = 0F;
            this.tChart3.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tChart3.Legend.Brush.Gradient.Visible = true;
            this.tChart3.Legend.Brush.Solid = true;
            this.tChart3.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.tChart3.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart3.Legend.Font.Brush.Solid = true;
            this.tChart3.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Legend.Font.Shadow.Brush.Solid = true;
            this.tChart3.Legend.Font.Shadow.Brush.Visible = true;
            this.tChart3.Legend.Font.Size = 8;
            this.tChart3.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Legend.ImageBevel.Brush.Solid = true;
            this.tChart3.Legend.ImageBevel.Brush.Visible = true;
            this.tChart3.Legend.LegendStyle = Steema.TeeChart.LegendStyles.Series;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart3.Legend.Shadow.Brush.Solid = true;
            this.tChart3.Legend.Shadow.Brush.Visible = true;
            this.tChart3.Legend.Shadow.Width = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Legend.Symbol.Shadow.Brush.Solid = true;
            this.tChart3.Legend.Symbol.Shadow.Brush.Visible = true;
            this.tChart3.Legend.TextSymbolGap = -4;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.tChart3.Legend.Title.Brush.Solid = true;
            this.tChart3.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.tChart3.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.tChart3.Legend.Title.Font.Brush.Solid = true;
            this.tChart3.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.tChart3.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.tChart3.Legend.Title.Font.Size = 8;
            this.tChart3.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Legend.Title.ImageBevel.Brush.Solid = true;
            this.tChart3.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Legend.Title.Shadow.Brush.Solid = true;
            this.tChart3.Legend.Title.Shadow.Brush.Visible = true;
            this.tChart3.Legend.VertSpacing = 9;
            this.tChart3.Location = new System.Drawing.Point(3, 834);
            this.tChart3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tChart3.Name = "tChart3";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Raised;
            // 
            // 
            // 
            this.tChart3.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            // 
            // 
            // 
            this.tChart3.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tChart3.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart3.Panel.Brush.Gradient.SigmaFocus = 0F;
            this.tChart3.Panel.Brush.Gradient.SigmaScale = 0F;
            this.tChart3.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tChart3.Panel.Brush.Gradient.UseMiddle = false;
            this.tChart3.Panel.Brush.Gradient.Visible = true;
            this.tChart3.Panel.Brush.Solid = true;
            this.tChart3.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Panel.ImageBevel.Brush.Solid = true;
            this.tChart3.Panel.ImageBevel.Brush.Visible = true;
            this.tChart3.Panel.MarginLeft = 4D;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Panel.Shadow.Brush.Solid = true;
            this.tChart3.Panel.Shadow.Brush.Visible = true;
            this.tChart3.Series.Add(this.lineP2P);
            this.tChart3.Series.Add(this.lineRMS);
            this.tChart3.Size = new System.Drawing.Size(1198, 428);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.tChart3.SubFooter.Brush.Solid = true;
            this.tChart3.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.tChart3.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChart3.SubFooter.Font.Brush.Solid = true;
            this.tChart3.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.SubFooter.Font.Shadow.Brush.Solid = true;
            this.tChart3.SubFooter.Font.Shadow.Brush.Visible = true;
            this.tChart3.SubFooter.Font.Size = 8;
            this.tChart3.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.SubFooter.ImageBevel.Brush.Solid = true;
            this.tChart3.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.SubFooter.Shadow.Brush.Solid = true;
            this.tChart3.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart3.SubHeader.Brush.Solid = true;
            this.tChart3.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart3.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.tChart3.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart3.SubHeader.Font.Brush.Solid = true;
            this.tChart3.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.SubHeader.Font.Shadow.Brush.Solid = true;
            this.tChart3.SubHeader.Font.Shadow.Brush.Visible = true;
            this.tChart3.SubHeader.Font.Size = 12;
            this.tChart3.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.SubHeader.ImageBevel.Brush.Solid = true;
            this.tChart3.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart3.SubHeader.Shadow.Brush.Solid = true;
            this.tChart3.SubHeader.Shadow.Brush.Visible = true;
            this.tChart3.TabIndex = 6;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.tChart3.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.tChart3.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart3.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tChart3.Walls.Back.Brush.Solid = true;
            this.tChart3.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Walls.Back.ImageBevel.Brush.Solid = true;
            this.tChart3.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Walls.Back.Shadow.Brush.Solid = true;
            this.tChart3.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tChart3.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart3.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart3.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
            this.tChart3.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
            this.tChart3.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart3.Walls.Bottom.Brush.Solid = true;
            this.tChart3.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.tChart3.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Walls.Bottom.Shadow.Brush.Solid = true;
            this.tChart3.Walls.Bottom.Shadow.Brush.Visible = true;
            this.tChart3.Walls.Bottom.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            // 
            // 
            // 
            this.tChart3.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart3.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart3.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
            this.tChart3.Walls.Left.Brush.Gradient.SigmaScale = 0F;
            this.tChart3.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart3.Walls.Left.Brush.Solid = true;
            this.tChart3.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Walls.Left.ImageBevel.Brush.Solid = true;
            this.tChart3.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Walls.Left.Shadow.Brush.Solid = true;
            this.tChart3.Walls.Left.Shadow.Brush.Visible = true;
            this.tChart3.Walls.Left.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart3.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.tChart3.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart3.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart3.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
            this.tChart3.Walls.Right.Brush.Gradient.SigmaScale = 0F;
            this.tChart3.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart3.Walls.Right.Brush.Solid = true;
            this.tChart3.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart3.Walls.Right.ImageBevel.Brush.Solid = true;
            this.tChart3.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart3.Walls.Right.Shadow.Brush.Solid = true;
            this.tChart3.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart3.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.tChart3.Zoom.Brush.Solid = true;
            this.tChart3.Zoom.Brush.Visible = true;
            // 
            // lineP2P
            // 
            // 
            // 
            // 
            this.lineP2P.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(90)))));
            // 
            // 
            // 
            this.lineP2P.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(245)))), ((int)(((byte)(189)))));
            this.lineP2P.Gradient.MiddleColor = System.Drawing.Color.Empty;
            this.lineP2P.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(90)))));
            this.lineP2P.Brush.Solid = true;
            this.lineP2P.Brush.Visible = true;
            this.lineP2P.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(90)))));
            this.lineP2P.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineP2P.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.lineP2P.Legend.Brush.Color = System.Drawing.Color.White;
            this.lineP2P.Legend.Brush.Solid = true;
            this.lineP2P.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.lineP2P.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.lineP2P.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.lineP2P.Legend.Font.Brush.Solid = true;
            this.lineP2P.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineP2P.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.lineP2P.Legend.Font.Shadow.Brush.Solid = true;
            this.lineP2P.Legend.Font.Shadow.Brush.Visible = true;
            this.lineP2P.Legend.Font.Size = 8;
            this.lineP2P.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineP2P.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.lineP2P.Legend.ImageBevel.Brush.Solid = true;
            this.lineP2P.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineP2P.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.lineP2P.Legend.Shadow.Brush.Solid = true;
            this.lineP2P.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.lineP2P.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(90)))), ((int)(((byte)(132)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineP2P.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.lineP2P.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.lineP2P.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lineP2P.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineP2P.Marks.Brush.Gradient.SigmaFocus = 0F;
            this.lineP2P.Marks.Brush.Gradient.SigmaScale = 0F;
            this.lineP2P.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lineP2P.Marks.Brush.Solid = true;
            this.lineP2P.Marks.Brush.Visible = false;
            // 
            // 
            // 
            this.lineP2P.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.lineP2P.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lineP2P.Marks.Font.Brush.Solid = true;
            this.lineP2P.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineP2P.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.lineP2P.Marks.Font.Shadow.Brush.Solid = true;
            this.lineP2P.Marks.Font.Shadow.Brush.Visible = true;
            this.lineP2P.Marks.Font.Size = 8;
            this.lineP2P.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineP2P.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.lineP2P.Marks.ImageBevel.Brush.Solid = true;
            this.lineP2P.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.lineP2P.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(207)))), ((int)(((byte)(81)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineP2P.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.lineP2P.Marks.Shadow.Brush.Solid = true;
            this.lineP2P.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineP2P.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.lineP2P.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.lineP2P.Marks.Symbol.Brush.Solid = true;
            this.lineP2P.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineP2P.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.lineP2P.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.lineP2P.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineP2P.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.lineP2P.Marks.Symbol.Shadow.Brush.Solid = true;
            this.lineP2P.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.lineP2P.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
            this.lineP2P.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos2")));
            this.lineP2P.Marks.TailParams.Margin = 0F;
            this.lineP2P.Marks.TailParams.PointerHeight = 8D;
            this.lineP2P.Marks.TailParams.PointerWidth = 8D;
            this.lineP2P.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.None;
            this.lineP2P.Marks.Transparent = true;
            this.lineP2P.OriginalCursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineP2P.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(90)))));
            this.lineP2P.Pointer.Brush.Solid = true;
            this.lineP2P.Pointer.Brush.Visible = true;
            this.lineP2P.Pointer.SizeDouble = 0D;
            this.lineP2P.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.lineP2P.Title = "P2P";
            this.lineP2P.UseExtendedNumRange = false;
            this.lineP2P.Visible = false;
            // 
            // 
            // 
            this.lineP2P.XValues.DataMember = "X";
            this.lineP2P.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineP2P.YValues.DataMember = "Y";
            // 
            // lineRMS
            // 
            // 
            // 
            // 
            this.lineRMS.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            // 
            // 
            // 
            this.lineRMS.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(245)))), ((int)(((byte)(189)))));
            this.lineRMS.Gradient.MiddleColor = System.Drawing.Color.Empty;
            this.lineRMS.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(90)))));
            this.lineRMS.Brush.Solid = true;
            this.lineRMS.Brush.Visible = true;
            this.lineRMS.Color = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.lineRMS.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineRMS.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.lineRMS.Legend.Brush.Color = System.Drawing.Color.White;
            this.lineRMS.Legend.Brush.Solid = true;
            this.lineRMS.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.lineRMS.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.lineRMS.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.lineRMS.Legend.Font.Brush.Solid = true;
            this.lineRMS.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineRMS.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.lineRMS.Legend.Font.Shadow.Brush.Solid = true;
            this.lineRMS.Legend.Font.Shadow.Brush.Visible = true;
            this.lineRMS.Legend.Font.Size = 8;
            this.lineRMS.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineRMS.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.lineRMS.Legend.ImageBevel.Brush.Solid = true;
            this.lineRMS.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineRMS.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.lineRMS.Legend.Shadow.Brush.Solid = true;
            this.lineRMS.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.lineRMS.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(90)))), ((int)(((byte)(132)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineRMS.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.lineRMS.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
            // 
            // 
            // 
            this.lineRMS.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lineRMS.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineRMS.Marks.Brush.Gradient.SigmaFocus = 0F;
            this.lineRMS.Marks.Brush.Gradient.SigmaScale = 0F;
            this.lineRMS.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lineRMS.Marks.Brush.Solid = true;
            this.lineRMS.Marks.Brush.Visible = false;
            // 
            // 
            // 
            this.lineRMS.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.lineRMS.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lineRMS.Marks.Font.Brush.Solid = true;
            this.lineRMS.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineRMS.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.lineRMS.Marks.Font.Shadow.Brush.Solid = true;
            this.lineRMS.Marks.Font.Shadow.Brush.Visible = true;
            this.lineRMS.Marks.Font.Size = 8;
            this.lineRMS.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineRMS.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.lineRMS.Marks.ImageBevel.Brush.Solid = true;
            this.lineRMS.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.lineRMS.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(207)))), ((int)(((byte)(81)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineRMS.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.lineRMS.Marks.Shadow.Brush.Solid = true;
            this.lineRMS.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineRMS.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.lineRMS.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.lineRMS.Marks.Symbol.Brush.Solid = true;
            this.lineRMS.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineRMS.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.lineRMS.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.lineRMS.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineRMS.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.lineRMS.Marks.Symbol.Shadow.Brush.Solid = true;
            this.lineRMS.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.lineRMS.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
            this.lineRMS.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos3")));
            this.lineRMS.Marks.TailParams.Margin = 0F;
            this.lineRMS.Marks.TailParams.PointerHeight = 8D;
            this.lineRMS.Marks.TailParams.PointerWidth = 8D;
            this.lineRMS.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.None;
            this.lineRMS.Marks.Transparent = true;
            this.lineRMS.OriginalCursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineRMS.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.lineRMS.Pointer.Brush.Solid = true;
            this.lineRMS.Pointer.Brush.Visible = true;
            this.lineRMS.Pointer.SizeDouble = 0D;
            this.lineRMS.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.lineRMS.Title = "RMS";
            this.lineRMS.UseExtendedNumRange = false;
            this.lineRMS.Visible = false;
            // 
            // 
            // 
            this.lineRMS.XValues.DataMember = "X";
            this.lineRMS.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineRMS.YValues.DataMember = "Y";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.StopBtn);
            this.panel2.Controls.Add(this.StartBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1204, 99);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(957, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 87);
            this.button1.TabIndex = 2;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 1364);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private Steema.TeeChart.TChart tChart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Steema.TeeChart.TChart tChart2;
        private Steema.TeeChart.TChart tChart3;
        private Steema.TeeChart.Styles.Line lineP2P;
        private Steema.TeeChart.Styles.Line lineRMS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Steema.TeeChart.Styles.Line lineWave;
        private Steema.TeeChart.Styles.Line lineFFT;
        private System.Windows.Forms.Timer timer1;
    }
}

