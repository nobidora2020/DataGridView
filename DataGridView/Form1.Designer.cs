
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WidthAdjustBtn = new System.Windows.Forms.Button();
            this.addColumBtn = new System.Windows.Forms.Button();
            this.checkCountBtn = new System.Windows.Forms.Button();
            this.addCheckCoumCbx = new System.Windows.Forms.CheckBox();
            this.reverseCheckBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 315);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseClick);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.DataGridView1_CurrentCellChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(89, 384);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 31);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.WidthAdjustBtn.Location = new System.Drawing.Point(25, 422);
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
            this.addColumBtn.Location = new System.Drawing.Point(728, 338);
            this.addColumBtn.Name = "addColumBtn";
            this.addColumBtn.Size = new System.Drawing.Size(128, 58);
            this.addColumBtn.TabIndex = 21;
            this.addColumBtn.Text = "列を追加";
            this.addColumBtn.UseVisualStyleBackColor = true;
            this.addColumBtn.Click += new System.EventHandler(this.AddColumBtn_Click);
            // 
            // checkCountBtn
            // 
            this.checkCountBtn.Location = new System.Drawing.Point(873, 338);
            this.checkCountBtn.Name = "checkCountBtn";
            this.checkCountBtn.Size = new System.Drawing.Size(94, 72);
            this.checkCountBtn.TabIndex = 22;
            this.checkCountBtn.Text = "チェックを調べる";
            this.checkCountBtn.UseVisualStyleBackColor = true;
            this.checkCountBtn.Click += new System.EventHandler(this.CheckCountBtn_Click);
            // 
            // addCheckCoumCbx
            // 
            this.addCheckCoumCbx.Appearance = System.Windows.Forms.Appearance.Button;
            this.addCheckCoumCbx.Location = new System.Drawing.Point(593, 341);
            this.addCheckCoumCbx.Name = "addCheckCoumCbx";
            this.addCheckCoumCbx.Size = new System.Drawing.Size(128, 58);
            this.addCheckCoumCbx.TabIndex = 23;
            this.addCheckCoumCbx.Text = "チェック列add";
            this.addCheckCoumCbx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addCheckCoumCbx.UseVisualStyleBackColor = true;
            this.addCheckCoumCbx.CheckedChanged += new System.EventHandler(this.AddCheckCoumCbx_CheckedChanged);
            // 
            // reverseCheckBtn
            // 
            this.reverseCheckBtn.Location = new System.Drawing.Point(873, 446);
            this.reverseCheckBtn.Name = "reverseCheckBtn";
            this.reverseCheckBtn.Size = new System.Drawing.Size(94, 72);
            this.reverseCheckBtn.TabIndex = 22;
            this.reverseCheckBtn.Text = "チェックを反転";
            this.reverseCheckBtn.UseVisualStyleBackColor = true;
            this.reverseCheckBtn.Click += new System.EventHandler(this.ReverseCheckBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(355, 353);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 86);
            this.textBox1.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 59);
            this.button1.TabIndex = 25;
            this.button1.Text = "true";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(753, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 59);
            this.button2.TabIndex = 25;
            this.button2.Text = "false";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(633, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 69);
            this.button3.TabIndex = 26;
            this.button3.Text = "check状態";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(355, 454);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 86);
            this.textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 445);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 86);
            this.textBox3.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 543);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addCheckCoumCbx);
            this.Controls.Add(this.reverseCheckBtn);
            this.Controls.Add(this.checkCountBtn);
            this.Controls.Add(this.addColumBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WidthAdjustBtn);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("メイリオ", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WidthAdjustBtn;
        private System.Windows.Forms.Button addColumBtn;
        private System.Windows.Forms.Button checkCountBtn;
        private System.Windows.Forms.CheckBox addCheckCoumCbx;
        private System.Windows.Forms.Button reverseCheckBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

