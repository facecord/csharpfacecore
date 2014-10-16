namespace faceView.UcControl
{
    partial class UcFaceCheck
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcFaceCheck));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlbg = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlcg = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlzc = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnldr = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.picSource = new System.Windows.Forms.PictureBox();
            this.picCheck = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.picSelect = new System.Windows.Forms.PictureBox();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlbg.SuspendLayout();
            this.pnlcg.SuspendLayout();
            this.pnlzc.SuspendLayout();
            this.pnldr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.pnlbg);
            this.flowLayoutPanel1.Controls.Add(this.pnlcg);
            this.flowLayoutPanel1.Controls.Add(this.pnlzc);
            this.flowLayoutPanel1.Controls.Add(this.pnldr);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 388);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(808, 166);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlbg
            // 
            this.pnlbg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlbg.BackgroundImage")));
            this.pnlbg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlbg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlbg.Controls.Add(this.label3);
            this.pnlbg.Location = new System.Drawing.Point(3, 3);
            this.pnlbg.Name = "pnlbg";
            this.pnlbg.Size = new System.Drawing.Size(195, 160);
            this.pnlbg.TabIndex = 0;
            this.toolTip1.SetToolTip(this.pnlbg, "双击检测");
            this.pnlbg.DoubleClick += new System.EventHandler(this.pnlbg_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(0, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "背光照";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlcg
            // 
            this.pnlcg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlcg.BackgroundImage")));
            this.pnlcg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlcg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlcg.Controls.Add(this.label4);
            this.pnlcg.Location = new System.Drawing.Point(204, 3);
            this.pnlcg.Name = "pnlcg";
            this.pnlcg.Size = new System.Drawing.Size(195, 160);
            this.pnlcg.TabIndex = 0;
            this.toolTip1.SetToolTip(this.pnlcg, "双击检测");
            this.pnlcg.DoubleClick += new System.EventHandler(this.pnlbg_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(0, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "侧光照";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlzc
            // 
            this.pnlzc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlzc.BackgroundImage")));
            this.pnlzc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlzc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlzc.Controls.Add(this.label5);
            this.pnlzc.Location = new System.Drawing.Point(405, 3);
            this.pnlzc.Name = "pnlzc";
            this.pnlzc.Size = new System.Drawing.Size(195, 160);
            this.pnlzc.TabIndex = 0;
            this.toolTip1.SetToolTip(this.pnlzc, "双击检测");
            this.pnlzc.DoubleClick += new System.EventHandler(this.pnlbg_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(0, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "正常照";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnldr
            // 
            this.pnldr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnldr.BackgroundImage")));
            this.pnldr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnldr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnldr.Controls.Add(this.label6);
            this.pnldr.Location = new System.Drawing.Point(606, 3);
            this.pnldr.Name = "pnldr";
            this.pnldr.Size = new System.Drawing.Size(195, 160);
            this.pnldr.TabIndex = 0;
            this.toolTip1.SetToolTip(this.pnldr, "双击检测");
            this.pnldr.DoubleClick += new System.EventHandler(this.pnlbg_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(0, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "多人照";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect.Location = new System.Drawing.Point(610, 6);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(95, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Visible = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            this.btnSelect.Enter += new System.EventHandler(this.btnSelect_Enter);
            this.btnSelect.Leave += new System.EventHandler(this.btnSelect_Leave);
            this.btnSelect.MouseEnter += new System.EventHandler(this.btnSelect_Enter);
            this.btnSelect.MouseLeave += new System.EventHandler(this.btnSelect_Leave);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(17, 35);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(559, 21);
            this.txtFilePath.TabIndex = 2;
            // 
            // picSource
            // 
            this.picSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.picSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSource.Location = new System.Drawing.Point(17, 62);
            this.picSource.Name = "picSource";
            this.picSource.Size = new System.Drawing.Size(372, 316);
            this.picSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSource.TabIndex = 3;
            this.picSource.TabStop = false;
            // 
            // picCheck
            // 
            this.picCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(230)))));
            this.picCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCheck.Location = new System.Drawing.Point(447, 62);
            this.picCheck.Name = "picCheck";
            this.picCheck.Size = new System.Drawing.Size(351, 316);
            this.picCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheck.TabIndex = 4;
            this.picCheck.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "原始图片";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(447, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "人脸识别照片";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(19, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(587, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "请选择图片地址，或手工输入图片的URL地址。图片格式：bmp,png,jpe,jpeg；下面四张图片双击可进行检测。";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(713, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(85, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            this.btnLoad.Enter += new System.EventHandler(this.btnLoad_Enter);
            this.btnLoad.Leave += new System.EventHandler(this.btnLoad_Leave);
            this.btnLoad.MouseEnter += new System.EventHandler(this.btnLoad_Enter);
            this.btnLoad.MouseLeave += new System.EventHandler(this.btnLoad_Leave);
            // 
            // picSelect
            // 
            this.picSelect.Location = new System.Drawing.Point(610, 32);
            this.picSelect.Name = "picSelect";
            this.picSelect.Size = new System.Drawing.Size(93, 26);
            this.picSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSelect.TabIndex = 8;
            this.picSelect.TabStop = false;
            this.picSelect.Click += new System.EventHandler(this.btnSelect_Click);
            this.picSelect.MouseEnter += new System.EventHandler(this.btnSelect_Enter);
            this.picSelect.MouseLeave += new System.EventHandler(this.btnSelect_Leave);
            // 
            // picLoad
            // 
            this.picLoad.Location = new System.Drawing.Point(717, 32);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(81, 26);
            this.picLoad.TabIndex = 9;
            this.picLoad.TabStop = false;
            this.picLoad.Click += new System.EventHandler(this.btnLoad_Click);
            this.picLoad.MouseEnter += new System.EventHandler(this.btnLoad_Enter);
            this.picLoad.MouseLeave += new System.EventHandler(this.btnLoad_Leave);
            // 
            // UcFaceCheck
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(248)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picLoad);
            this.Controls.Add(this.picSelect);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picCheck);
            this.Controls.Add(this.picSource);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UcFaceCheck";
            this.Size = new System.Drawing.Size(814, 557);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlbg.ResumeLayout(false);
            this.pnlcg.ResumeLayout(false);
            this.pnlzc.ResumeLayout(false);
            this.pnldr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.PictureBox picSource;
        private System.Windows.Forms.PictureBox picCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlbg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlcg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlzc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnldr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox picSelect;
        private System.Windows.Forms.PictureBox picLoad;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
