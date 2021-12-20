
namespace DataGridViewUse
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.SizeColumnsCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WidthAdjustBtn = new System.Windows.Forms.Button();
            this.addColumBtn = new System.Windows.Forms.Button();
            this.checkCountBtn = new System.Windows.Forms.Button();
            this.addCheckCoumCbx = new System.Windows.Forms.CheckBox();
            this.reverseCheckBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trueBtn = new System.Windows.Forms.Button();
            this.falseBtn = new System.Windows.Forms.Button();
            this.CheckCheckStateBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(14, 18);
            this.GridView.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 51;
            this.GridView.RowTemplate.Height = 24;
            this.GridView.Size = new System.Drawing.Size(1022, 280);
            this.GridView.TabIndex = 17;
            this.GridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseClick);
            // 
            // SizeColumnsCmb
            // 
            this.SizeColumnsCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeColumnsCmb.FormattingEnabled = true;
            this.SizeColumnsCmb.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.SizeColumnsCmb.Location = new System.Drawing.Point(89, 384);
            this.SizeColumnsCmb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SizeColumnsCmb.Name = "SizeColumnsCmb";
            this.SizeColumnsCmb.Size = new System.Drawing.Size(236, 31);
            this.SizeColumnsCmb.TabIndex = 18;
            this.SizeColumnsCmb.SelectedIndexChanged += new System.EventHandler(this.SizeColumnsCmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "SizeColumnsMode";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // WidthAdjustBtn
            // 
            this.WidthAdjustBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WidthAdjustBtn.Location = new System.Drawing.Point(41, 457);
            this.WidthAdjustBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.WidthAdjustBtn.Name = "WidthAdjustBtn";
            this.WidthAdjustBtn.Size = new System.Drawing.Size(84, 35);
            this.WidthAdjustBtn.TabIndex = 20;
            this.WidthAdjustBtn.Text = "幅調整";
            this.WidthAdjustBtn.UseVisualStyleBackColor = true;
            this.WidthAdjustBtn.Click += new System.EventHandler(this.WidthAdjjustBtn_Click);
            // 
            // addColumBtn
            // 
            this.addColumBtn.Location = new System.Drawing.Point(109, 3);
            this.addColumBtn.Name = "addColumBtn";
            this.addColumBtn.Size = new System.Drawing.Size(100, 60);
            this.addColumBtn.TabIndex = 21;
            this.addColumBtn.Text = "列を追加";
            this.addColumBtn.UseVisualStyleBackColor = true;
            this.addColumBtn.Click += new System.EventHandler(this.AddColumBtn_Click);
            // 
            // checkCountBtn
            // 
            this.checkCountBtn.Location = new System.Drawing.Point(321, 3);
            this.checkCountBtn.Name = "checkCountBtn";
            this.checkCountBtn.Size = new System.Drawing.Size(100, 60);
            this.checkCountBtn.TabIndex = 22;
            this.checkCountBtn.Text = "チェックを調べる";
            this.checkCountBtn.UseVisualStyleBackColor = true;
            this.checkCountBtn.Click += new System.EventHandler(this.CheckCountBtn_Click);
            // 
            // addCheckCoumCbx
            // 
            this.addCheckCoumCbx.Appearance = System.Windows.Forms.Appearance.Button;
            this.addCheckCoumCbx.Location = new System.Drawing.Point(3, 3);
            this.addCheckCoumCbx.Name = "addCheckCoumCbx";
            this.addCheckCoumCbx.Size = new System.Drawing.Size(100, 60);
            this.addCheckCoumCbx.TabIndex = 23;
            this.addCheckCoumCbx.Text = "チェック列add";
            this.addCheckCoumCbx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addCheckCoumCbx.UseVisualStyleBackColor = true;
            this.addCheckCoumCbx.CheckedChanged += new System.EventHandler(this.AddCheckCoumCbx_CheckedChanged);
            // 
            // reverseCheckBtn
            // 
            this.reverseCheckBtn.Location = new System.Drawing.Point(3, 69);
            this.reverseCheckBtn.Name = "reverseCheckBtn";
            this.reverseCheckBtn.Size = new System.Drawing.Size(100, 60);
            this.reverseCheckBtn.TabIndex = 22;
            this.reverseCheckBtn.Text = "チェックを反転";
            this.reverseCheckBtn.UseVisualStyleBackColor = true;
            this.reverseCheckBtn.Click += new System.EventHandler(this.ReverseCheckBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 344);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 86);
            this.textBox1.TabIndex = 24;
            // 
            // trueBtn
            // 
            this.trueBtn.Location = new System.Drawing.Point(215, 69);
            this.trueBtn.Name = "trueBtn";
            this.trueBtn.Size = new System.Drawing.Size(100, 60);
            this.trueBtn.TabIndex = 25;
            this.trueBtn.Text = "true";
            this.trueBtn.UseVisualStyleBackColor = true;
            this.trueBtn.Click += new System.EventHandler(this.TrueBtn_Click);
            // 
            // falseBtn
            // 
            this.falseBtn.Location = new System.Drawing.Point(109, 69);
            this.falseBtn.Name = "falseBtn";
            this.falseBtn.Size = new System.Drawing.Size(100, 60);
            this.falseBtn.TabIndex = 25;
            this.falseBtn.Text = "false";
            this.falseBtn.UseVisualStyleBackColor = true;
            this.falseBtn.Click += new System.EventHandler(this.FalseBtn_Click);
            // 
            // CheckCheckStateBtn
            // 
            this.CheckCheckStateBtn.Location = new System.Drawing.Point(215, 3);
            this.CheckCheckStateBtn.Name = "CheckCheckStateBtn";
            this.CheckCheckStateBtn.Size = new System.Drawing.Size(100, 60);
            this.CheckCheckStateBtn.TabIndex = 26;
            this.CheckCheckStateBtn.Text = "check状態";
            this.CheckCheckStateBtn.UseVisualStyleBackColor = true;
            this.CheckCheckStateBtn.Click += new System.EventHandler(this.CheckCheckStateBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 445);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 86);
            this.textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(357, 445);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(205, 86);
            this.textBox3.TabIndex = 24;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addCheckCoumCbx);
            this.flowLayoutPanel1.Controls.Add(this.addColumBtn);
            this.flowLayoutPanel1.Controls.Add(this.CheckCheckStateBtn);
            this.flowLayoutPanel1.Controls.Add(this.checkCountBtn);
            this.flowLayoutPanel1.Controls.Add(this.reverseCheckBtn);
            this.flowLayoutPanel1.Controls.Add(this.falseBtn);
            this.flowLayoutPanel1.Controls.Add(this.trueBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(581, 317);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(426, 195);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 543);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SizeColumnsCmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WidthAdjustBtn);
            this.Controls.Add(this.GridView);
            this.Font = new System.Drawing.Font("メイリオ", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.ComboBox SizeColumnsCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WidthAdjustBtn;
        private System.Windows.Forms.Button addColumBtn;
        private System.Windows.Forms.Button checkCountBtn;
        private System.Windows.Forms.CheckBox addCheckCoumCbx;
        private System.Windows.Forms.Button reverseCheckBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button trueBtn;
        private System.Windows.Forms.Button falseBtn;
        private System.Windows.Forms.Button CheckCheckStateBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

