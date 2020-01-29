namespace _0128_Vibrometer
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
            this.line_buffer = new Steema.TeeChart.Styles.Line();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tChart2 = new Steema.TeeChart.TChart();
            this.line_fft = new Steema.TeeChart.Styles.Line();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartBtn.Location = new System.Drawing.Point(397, 3);
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
            this.StopBtn.Location = new System.Drawing.Point(640, 6);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(193, 87);
            this.StopBtn.TabIndex = 1;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // tChart1
            // 
            this.tChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            this.tChart1.Location = new System.Drawing.Point(0, 0);
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
            this.tChart1.Series.Add(this.line_buffer);
            this.tChart1.Size = new System.Drawing.Size(1174, 441);
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
            // line_buffer
            // 
            // 
            // 
            // 
            this.line_buffer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.line_buffer.Brush.Solid = true;
            this.line_buffer.Brush.Visible = true;
            this.line_buffer.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.line_buffer.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_buffer.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line_buffer.Legend.Brush.Color = System.Drawing.Color.White;
            this.line_buffer.Legend.Brush.Solid = true;
            this.line_buffer.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.line_buffer.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.line_buffer.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.line_buffer.Legend.Font.Brush.Solid = true;
            this.line_buffer.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_buffer.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line_buffer.Legend.Font.Shadow.Brush.Solid = true;
            this.line_buffer.Legend.Font.Shadow.Brush.Visible = true;
            this.line_buffer.Legend.Font.Size = 8;
            this.line_buffer.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_buffer.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line_buffer.Legend.ImageBevel.Brush.Solid = true;
            this.line_buffer.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_buffer.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line_buffer.Legend.Shadow.Brush.Solid = true;
            this.line_buffer.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.line_buffer.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_buffer.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line_buffer.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line_buffer.Marks.Brush.Solid = true;
            this.line_buffer.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.line_buffer.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.line_buffer.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.line_buffer.Marks.Font.Brush.Solid = true;
            this.line_buffer.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_buffer.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line_buffer.Marks.Font.Shadow.Brush.Solid = true;
            this.line_buffer.Marks.Font.Shadow.Brush.Visible = true;
            this.line_buffer.Marks.Font.Size = 8;
            this.line_buffer.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_buffer.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line_buffer.Marks.ImageBevel.Brush.Solid = true;
            this.line_buffer.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_buffer.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.line_buffer.Marks.Shadow.Brush.Solid = true;
            this.line_buffer.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_buffer.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line_buffer.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.line_buffer.Marks.Symbol.Brush.Solid = true;
            this.line_buffer.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_buffer.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line_buffer.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.line_buffer.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_buffer.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line_buffer.Marks.Symbol.Shadow.Brush.Solid = true;
            this.line_buffer.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.line_buffer.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
            this.line_buffer.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.line_buffer.Marks.TailParams.Margin = 0F;
            this.line_buffer.Marks.TailParams.PointerHeight = 8D;
            this.line_buffer.Marks.TailParams.PointerWidth = 8D;
            this.line_buffer.OriginalCursor = null;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_buffer.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.line_buffer.Pointer.Brush.Solid = true;
            this.line_buffer.Pointer.Brush.Visible = true;
            this.line_buffer.Pointer.SizeDouble = 0D;
            this.line_buffer.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line_buffer.Title = "line_buffer";
            this.line_buffer.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.line_buffer.XValues.DataMember = "X";
            this.line_buffer.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.line_buffer.YValues.DataMember = "Y";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tChart2);
            this.panel1.Controls.Add(this.tChart1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 829);
            this.panel1.TabIndex = 3;
            // 
            // tChart2
            // 
            this.tChart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tChart2.Location = new System.Drawing.Point(0, 447);
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
            this.tChart2.Series.Add(this.line_fft);
            this.tChart2.Size = new System.Drawing.Size(1174, 382);
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
            // line_fft
            // 
            // 
            // 
            // 
            this.line_fft.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.line_fft.Brush.Solid = true;
            this.line_fft.Brush.Visible = true;
            this.line_fft.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.line_fft.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_fft.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line_fft.Legend.Brush.Color = System.Drawing.Color.White;
            this.line_fft.Legend.Brush.Solid = true;
            this.line_fft.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.line_fft.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.line_fft.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.line_fft.Legend.Font.Brush.Solid = true;
            this.line_fft.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_fft.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line_fft.Legend.Font.Shadow.Brush.Solid = true;
            this.line_fft.Legend.Font.Shadow.Brush.Visible = true;
            this.line_fft.Legend.Font.Size = 8;
            this.line_fft.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_fft.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line_fft.Legend.ImageBevel.Brush.Solid = true;
            this.line_fft.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_fft.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line_fft.Legend.Shadow.Brush.Solid = true;
            this.line_fft.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.line_fft.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_fft.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line_fft.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line_fft.Marks.Brush.Solid = true;
            this.line_fft.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.line_fft.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.line_fft.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.line_fft.Marks.Font.Brush.Solid = true;
            this.line_fft.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_fft.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line_fft.Marks.Font.Shadow.Brush.Solid = true;
            this.line_fft.Marks.Font.Shadow.Brush.Visible = true;
            this.line_fft.Marks.Font.Size = 8;
            this.line_fft.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_fft.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line_fft.Marks.ImageBevel.Brush.Solid = true;
            this.line_fft.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_fft.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.line_fft.Marks.Shadow.Brush.Solid = true;
            this.line_fft.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_fft.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line_fft.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.line_fft.Marks.Symbol.Brush.Solid = true;
            this.line_fft.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_fft.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line_fft.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.line_fft.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_fft.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line_fft.Marks.Symbol.Shadow.Brush.Solid = true;
            this.line_fft.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.line_fft.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
            this.line_fft.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.line_fft.Marks.TailParams.Margin = 0F;
            this.line_fft.Marks.TailParams.PointerHeight = 8D;
            this.line_fft.Marks.TailParams.PointerWidth = 8D;
            this.line_fft.OriginalCursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line_fft.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.line_fft.Pointer.Brush.Solid = true;
            this.line_fft.Pointer.Brush.Visible = true;
            this.line_fft.Pointer.SizeDouble = 0D;
            this.line_fft.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line_fft.Title = "line_fft";
            this.line_fft.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.line_fft.XValues.DataMember = "X";
            this.line_fft.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.line_fft.YValues.DataMember = "Y";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.StopBtn);
            this.panel2.Controls.Add(this.StartBtn);
            this.panel2.Location = new System.Drawing.Point(0, 829);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 100);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 929);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private Steema.TeeChart.TChart tChart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private Steema.TeeChart.Styles.Line line_buffer;
        private Steema.TeeChart.TChart tChart2;
        private Steema.TeeChart.Styles.Line line_fft;
    }
}

