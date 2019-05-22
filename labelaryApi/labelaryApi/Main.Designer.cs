namespace labelaryApi
{
    partial class Main
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_right_preview = new System.Windows.Forms.GroupBox();
            this.pictureBox_preview = new System.Windows.Forms.PictureBox();
            this.groupBox_left_zpl = new System.Windows.Forms.GroupBox();
            this.txt_zpl = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_analysis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_dpmm = new System.Windows.Forms.ComboBox();
            this.nud_width = new System.Windows.Forms.NumericUpDown();
            this.nud_height = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_right_preview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
            this.groupBox_left_zpl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_height)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.89848F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.10152F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_right_preview, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_left_zpl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1139, 743);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox_right_preview
            // 
            this.groupBox_right_preview.Controls.Add(this.pictureBox_preview);
            this.groupBox_right_preview.Controls.Add(this.panel2);
            this.groupBox_right_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_right_preview.Location = new System.Drawing.Point(457, 3);
            this.groupBox_right_preview.Name = "groupBox_right_preview";
            this.groupBox_right_preview.Size = new System.Drawing.Size(679, 737);
            this.groupBox_right_preview.TabIndex = 1;
            this.groupBox_right_preview.TabStop = false;
            this.groupBox_right_preview.Text = "预览图";
            // 
            // pictureBox_preview
            // 
            this.pictureBox_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_preview.Location = new System.Drawing.Point(3, 55);
            this.pictureBox_preview.Name = "pictureBox_preview";
            this.pictureBox_preview.Size = new System.Drawing.Size(673, 679);
            this.pictureBox_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_preview.TabIndex = 0;
            this.pictureBox_preview.TabStop = false;
            // 
            // groupBox_left_zpl
            // 
            this.groupBox_left_zpl.Controls.Add(this.txt_zpl);
            this.groupBox_left_zpl.Controls.Add(this.panel1);
            this.groupBox_left_zpl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_left_zpl.Location = new System.Drawing.Point(3, 3);
            this.groupBox_left_zpl.Name = "groupBox_left_zpl";
            this.groupBox_left_zpl.Size = new System.Drawing.Size(448, 737);
            this.groupBox_left_zpl.TabIndex = 0;
            this.groupBox_left_zpl.TabStop = false;
            this.groupBox_left_zpl.Text = "ZPL指令";
            // 
            // txt_zpl
            // 
            this.txt_zpl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_zpl.Location = new System.Drawing.Point(3, 17);
            this.txt_zpl.Multiline = true;
            this.txt_zpl.Name = "txt_zpl";
            this.txt_zpl.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_zpl.Size = new System.Drawing.Size(442, 674);
            this.txt_zpl.TabIndex = 1;
            this.txt_zpl.Text = resources.GetString("txt_zpl.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_analysis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 691);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 43);
            this.panel1.TabIndex = 0;
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.Location = new System.Drawing.Point(335, 6);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(104, 31);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_analysis
            // 
            this.btn_analysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_analysis.Location = new System.Drawing.Point(225, 6);
            this.btn_analysis.Name = "btn_analysis";
            this.btn_analysis.Size = new System.Drawing.Size(104, 31);
            this.btn_analysis.TabIndex = 0;
            this.btn_analysis.Text = "解析";
            this.btn_analysis.UseVisualStyleBackColor = true;
            this.btn_analysis.Click += new System.EventHandler(this.btn_analysis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "打印密度(DPMM):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "标签尺寸(宽X高):";
            // 
            // cbx_dpmm
            // 
            this.cbx_dpmm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_dpmm.FormattingEnabled = true;
            this.cbx_dpmm.Location = new System.Drawing.Point(106, 8);
            this.cbx_dpmm.Name = "cbx_dpmm";
            this.cbx_dpmm.Size = new System.Drawing.Size(140, 20);
            this.cbx_dpmm.TabIndex = 3;
            // 
            // nud_width
            // 
            this.nud_width.Location = new System.Drawing.Point(353, 8);
            this.nud_width.Name = "nud_width";
            this.nud_width.Size = new System.Drawing.Size(52, 21);
            this.nud_width.TabIndex = 4;
            this.nud_width.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nud_height
            // 
            this.nud_height.Location = new System.Drawing.Point(422, 8);
            this.nud_height.Name = "nud_height";
            this.nud_height.Size = new System.Drawing.Size(52, 21);
            this.nud_height.TabIndex = 5;
            this.nud_height.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbx_dpmm);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nud_height);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nud_width);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 38);
            this.panel2.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1139, 743);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "labelaryApi";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_right_preview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).EndInit();
            this.groupBox_left_zpl.ResumeLayout(false);
            this.groupBox_left_zpl.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_height)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_right_preview;
        private System.Windows.Forms.PictureBox pictureBox_preview;
        private System.Windows.Forms.GroupBox groupBox_left_zpl;
        private System.Windows.Forms.TextBox txt_zpl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_analysis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_height;
        private System.Windows.Forms.NumericUpDown nud_width;
        private System.Windows.Forms.ComboBox cbx_dpmm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

