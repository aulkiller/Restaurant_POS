namespace GUI.StaffWorking
{
    partial class AddExtraDialog
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
            this.tvExtra = new System.Windows.Forms.NumericUpDown();
            this.btAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tvContent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tvExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // tvExtra
            // 
            this.tvExtra.BackColor = System.Drawing.Color.White;
            this.tvExtra.Location = new System.Drawing.Point(31, 183);
            this.tvExtra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvExtra.Maximum = new decimal(new int[] {
            -402653185,
            -1613725636,
            54210108,
            0});
            this.tvExtra.Name = "tvExtra";
            this.tvExtra.Size = new System.Drawing.Size(381, 22);
            this.tvExtra.TabIndex = 30;
            this.tvExtra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tvExtra_KeyUp);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btAdd.Location = new System.Drawing.Point(172, 230);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 28);
            this.btAdd.TabIndex = 27;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Extra Value";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Add Extra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Extra Content";
            // 
            // tvContent
            // 
            this.tvContent.Location = new System.Drawing.Point(35, 98);
            this.tvContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvContent.Name = "tvContent";
            this.tvContent.Size = new System.Drawing.Size(376, 22);
            this.tvContent.TabIndex = 32;
            // 
            // AddExtraDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 287);
            this.Controls.Add(this.tvContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tvExtra);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddExtraDialog";
            this.Text = "AddExtraDialog";
            ((System.ComponentModel.ISupportInitialize)(this.tvExtra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown tvExtra;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tvContent;
    }
}