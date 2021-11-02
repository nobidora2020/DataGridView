
namespace DataGridView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WidthAdjustBtn = new System.Windows.Forms.Button();
            this.addColumBtn = new System.Windows.Forms.Button();
            this.checkCountBtn = new System.Windows.Forms.Button();
            this.addCheckCoumCbx = new System.Windows.Forms.CheckBox();
            this.reverseCheckBtn = new System.Windows.Forms.Button();
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
            this.WidthAdjustBtn.Location = new System.Drawing.Point(91, 451);
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
            this.addColumBtn.Location = new System.Drawing.Point(454, 356);
            this.addColumBtn.Name = "addColumBtn";
            this.addColumBtn.Size = new System.Drawing.Size(147, 74);
            this.addColumBtn.TabIndex = 21;
            this.addColumBtn.Text = "列を追加";
            this.addColumBtn.UseVisualStyleBackColor = true;
            this.addColumBtn.Click += new System.EventHandler(this.AddColumBtn_Click);
            // 
            // checkCountBtn
            // 
            this.checkCountBtn.Location = new System.Drawing.Point(862, 366);
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
            this.addCheckCoumCbx.Location = new System.Drawing.Point(664, 358);
            this.addCheckCoumCbx.Name = "addCheckCoumCbx";
            this.addCheckCoumCbx.Size = new System.Drawing.Size(128, 80);
            this.addCheckCoumCbx.TabIndex = 23;
            this.addCheckCoumCbx.Text = "チェック列add";
            this.addCheckCoumCbx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addCheckCoumCbx.UseVisualStyleBackColor = true;
            this.addCheckCoumCbx.CheckedChanged += new System.EventHandler(this.AddCheckCoumCbx_CheckedChanged);
            // 
            // reverseCheckBtn
            // 
            this.reverseCheckBtn.Location = new System.Drawing.Point(862, 451);
            this.reverseCheckBtn.Name = "reverseCheckBtn";
            this.reverseCheckBtn.Size = new System.Drawing.Size(94, 72);
            this.reverseCheckBtn.TabIndex = 22;
            this.reverseCheckBtn.Text = "チェックを反転";
            this.reverseCheckBtn.UseVisualStyleBackColor = true;
            this.reverseCheckBtn.Click += new System.EventHandler(this.ReverseCheckBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 543);
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
    }
}

