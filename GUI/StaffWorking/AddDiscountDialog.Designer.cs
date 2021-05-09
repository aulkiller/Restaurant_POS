namespace GUI.StaffWorking
{
    partial class AddDiscountDialog
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
            this.btAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPercent = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.tvDiscount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tvDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btAdd.ForeColor = System.Drawing.Color.Black;
            this.btAdd.Location = new System.Drawing.Point(157, 177);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 28);
            this.btAdd.TabIndex = 21;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Discounted Value";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Add Discount";
            // 
            // rbPercent
            // 
            this.rbPercent.AutoSize = true;
            this.rbPercent.Checked = true;
            this.rbPercent.Location = new System.Drawing.Point(16, 59);
            this.rbPercent.Margin = new System.Windows.Forms.Padding(4);
            this.rbPercent.Name = "rbPercent";
            this.rbPercent.Size = new System.Drawing.Size(190, 21);
            this.rbPercent.TabIndex = 22;
            this.rbPercent.TabStop = true;
            this.rbPercent.Text = "Discount Percentages(%)";
            this.rbPercent.UseVisualStyleBackColor = true;
            this.rbPercent.CheckedChanged += new System.EventHandler(this.rbPercent_CheckedChanged);
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(233, 59);
            this.rbCash.Margin = new System.Windows.Forms.Padding(4);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(153, 21);
            this.rbCash.TabIndex = 23;
            this.rbCash.Text = "Cash Discount(IDR)";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // tvDiscount
            // 
            this.tvDiscount.Location = new System.Drawing.Point(16, 130);
            this.tvDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.tvDiscount.Maximum = new decimal(new int[] {
            -402653185,
            -1613725636,
            54210108,
            0});
            this.tvDiscount.Name = "tvDiscount";
            this.tvDiscount.Size = new System.Drawing.Size(381, 22);
            this.tvDiscount.TabIndex = 24;
            // 
            // AddDiscountDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 231);
            this.Controls.Add(this.tvDiscount);
            this.Controls.Add(this.rbCash);
            this.Controls.Add(this.rbPercent);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddDiscountDialog";
            this.Text = "AddDiscountDialog";
            ((System.ComponentModel.ISupportInitialize)(this.tvDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPercent;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.NumericUpDown tvDiscount;
    }
}