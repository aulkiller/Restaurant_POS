namespace GUI.SystemSetup.Seat
{
    partial class AreaAddDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAreaName = new System.Windows.Forms.TextBox();
            this.cbAddTable = new System.Windows.Forms.CheckBox();
            this.panelTable = new System.Windows.Forms.Panel();
            this.txtTableTo = new System.Windows.Forms.NumericUpDown();
            this.txtTableFrom = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a New Area";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Area name";
            // 
            // txtAreaName
            // 
            this.txtAreaName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAreaName.Location = new System.Drawing.Point(20, 95);
            this.txtAreaName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(341, 22);
            this.txtAreaName.TabIndex = 2;
            // 
            // cbAddTable
            // 
            this.cbAddTable.AutoSize = true;
            this.cbAddTable.Location = new System.Drawing.Point(20, 142);
            this.cbAddTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAddTable.Name = "cbAddTable";
            this.cbAddTable.Size = new System.Drawing.Size(97, 21);
            this.cbAddTable.TabIndex = 3;
            this.cbAddTable.Text = "Add tables";
            this.cbAddTable.UseVisualStyleBackColor = true;
            this.cbAddTable.CheckedChanged += new System.EventHandler(this.cbAddTable_CheckedChanged);
            // 
            // panelTable
            // 
            this.panelTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTable.Controls.Add(this.txtTableTo);
            this.panelTable.Controls.Add(this.txtTableFrom);
            this.panelTable.Controls.Add(this.label4);
            this.panelTable.Controls.Add(this.label3);
            this.panelTable.Enabled = false;
            this.panelTable.Location = new System.Drawing.Point(20, 171);
            this.panelTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(343, 57);
            this.panelTable.TabIndex = 4;
            // 
            // txtTableTo
            // 
            this.txtTableTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTableTo.Location = new System.Drawing.Point(197, 20);
            this.txtTableTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTableTo.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.txtTableTo.Name = "txtTableTo";
            this.txtTableTo.Size = new System.Drawing.Size(143, 22);
            this.txtTableTo.TabIndex = 4;
            // 
            // txtTableFrom
            // 
            this.txtTableFrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTableFrom.Location = new System.Drawing.Point(3, 20);
            this.txtTableFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTableFrom.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.txtTableFrom.Name = "txtTableFrom";
            this.txtTableFrom.Size = new System.Drawing.Size(143, 22);
            this.txtTableFrom.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Table to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Table from";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(92)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(141, 235);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AreaAddDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(379, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.cbAddTable);
            this.Controls.Add(this.txtAreaName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AreaAddDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a new area";
            this.panelTable.ResumeLayout(false);
            this.panelTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAreaName;
        private System.Windows.Forms.CheckBox cbAddTable;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.NumericUpDown txtTableFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtTableTo;
        private System.Windows.Forms.Button button1;
    }
}