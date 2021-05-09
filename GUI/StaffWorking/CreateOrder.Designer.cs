namespace GUI.StaffWorking
{
    partial class CreateOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnVAT = new System.Windows.Forms.Button();
            this.btnExtra = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnChangeTable = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbVAT = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTable = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFoodPrice = new System.Windows.Forms.Label();
            this.flowLayoutPanelRight = new System.Windows.Forms.FlowLayoutPanel();
            this.lbExtra = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.layoutButton = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.layoutButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 576);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(81, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(849, 536);
            this.tabControl.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(841, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnVAT
            // 
            this.btnVAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(92)))));
            this.btnVAT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVAT.FlatAppearance.BorderSize = 0;
            this.btnVAT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.btnVAT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnVAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVAT.ForeColor = System.Drawing.Color.White;
            this.btnVAT.Location = new System.Drawing.Point(96, 0);
            this.btnVAT.Margin = new System.Windows.Forms.Padding(0);
            this.btnVAT.Name = "btnVAT";
            this.btnVAT.Size = new System.Drawing.Size(82, 59);
            this.btnVAT.TabIndex = 0;
            this.btnVAT.Text = "Add VAT";
            this.btnVAT.UseVisualStyleBackColor = false;
            this.btnVAT.Click += new System.EventHandler(this.btnVAT_Click);
            // 
            // btnExtra
            // 
            this.btnExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(92)))));
            this.btnExtra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExtra.FlatAppearance.BorderSize = 0;
            this.btnExtra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.btnExtra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtra.ForeColor = System.Drawing.Color.White;
            this.btnExtra.Location = new System.Drawing.Point(96, 59);
            this.btnExtra.Margin = new System.Windows.Forms.Padding(0);
            this.btnExtra.Name = "btnExtra";
            this.btnExtra.Size = new System.Drawing.Size(82, 58);
            this.btnExtra.TabIndex = 1;
            this.btnExtra.Text = "Add extra";
            this.btnExtra.UseVisualStyleBackColor = false;
            this.btnExtra.Click += new System.EventHandler(this.btnExtra_Click_1);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(92)))));
            this.btnDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiscount.FlatAppearance.BorderSize = 0;
            this.btnDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.btnDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Location = new System.Drawing.Point(0, 0);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(0);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(96, 59);
            this.btnDiscount.TabIndex = 2;
            this.btnDiscount.Text = "Add Discount";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click_1);
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(92)))));
            this.btnChangeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeTable.FlatAppearance.BorderSize = 0;
            this.btnChangeTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.btnChangeTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.btnChangeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeTable.ForeColor = System.Drawing.Color.White;
            this.btnChangeTable.Location = new System.Drawing.Point(0, 59);
            this.btnChangeTable.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(96, 58);
            this.btnChangeTable.TabIndex = 3;
            this.btnChangeTable.Text = "Change table";
            this.btnChangeTable.UseVisualStyleBackColor = false;
            this.btnChangeTable.Click += new System.EventHandler(this.btnChangeTable_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Discount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDiscount
            // 
            this.lbDiscount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(621, 55);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(21, 13);
            this.lbDiscount.TabIndex = 27;
            this.lbDiscount.Text = "0%";
            this.lbDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVAT
            // 
            this.lbVAT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbVAT.AutoSize = true;
            this.lbVAT.Location = new System.Drawing.Point(620, 85);
            this.lbVAT.Name = "lbVAT";
            this.lbVAT.Size = new System.Drawing.Size(21, 13);
            this.lbVAT.TabIndex = 25;
            this.lbVAT.Text = "0%";
            this.lbVAT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbArea
            // 
            this.lbArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(47, 85);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(32, 13);
            this.lbArea.TabIndex = 22;
            this.lbArea.Text = "Area:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Total";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTable
            // 
            this.lbTable.AutoSize = true;
            this.lbTable.Location = new System.Drawing.Point(47, 104);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(37, 13);
            this.lbTable.TabIndex = 21;
            this.lbTable.Text = "Table:";
            this.lbTable.Click += new System.EventHandler(this.lbTable_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(620, 100);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(30, 13);
            this.lbTotal.TabIndex = 31;
            this.lbTotal.Text = "Rp 0";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.Location = new System.Drawing.Point(12, 38);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(132, 20);
            this.txtCustomerName.TabIndex = 20;
            this.txtCustomerName.Text = "Pelanggan";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Food";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Guest:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Extra";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "VAT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbFoodPrice
            // 
            this.lbFoodPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbFoodPrice.AutoSize = true;
            this.lbFoodPrice.Location = new System.Drawing.Point(620, 38);
            this.lbFoodPrice.Name = "lbFoodPrice";
            this.lbFoodPrice.Size = new System.Drawing.Size(30, 13);
            this.lbFoodPrice.TabIndex = 33;
            this.lbFoodPrice.Text = "Rp 0";
            // 
            // flowLayoutPanelRight
            // 
            this.flowLayoutPanelRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelRight.AutoScroll = true;
            this.flowLayoutPanelRight.Location = new System.Drawing.Point(222, 15);
            this.flowLayoutPanelRight.Name = "flowLayoutPanelRight";
            this.flowLayoutPanelRight.Size = new System.Drawing.Size(326, 119);
            this.flowLayoutPanelRight.TabIndex = 17;
            // 
            // lbExtra
            // 
            this.lbExtra.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbExtra.AutoSize = true;
            this.lbExtra.Location = new System.Drawing.Point(620, 71);
            this.lbExtra.Name = "lbExtra";
            this.lbExtra.Size = new System.Drawing.Size(33, 13);
            this.lbExtra.TabIndex = 29;
            this.lbExtra.Text = "Rp 0 ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel2.Controls.Add(this.lbExtra);
            this.panel2.Controls.Add(this.flowLayoutPanelRight);
            this.panel2.Controls.Add(this.lbFoodPrice);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Controls.Add(this.lbTotal);
            this.panel2.Controls.Add(this.lbTable);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbArea);
            this.panel2.Controls.Add(this.lbVAT);
            this.panel2.Controls.Add(this.lbDiscount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 582);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 147);
            this.panel2.TabIndex = 1;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(138)))), ((int)(((byte)(2)))));
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(150)))), ((int)(((byte)(2)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Location = new System.Drawing.Point(0, 58);
            this.btnPay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(88, 59);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.AutoSize = true;
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(163)))), ((int)(((byte)(17)))));
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(138)))), ((int)(((byte)(2)))));
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(150)))), ((int)(((byte)(2)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Location = new System.Drawing.Point(0, 0);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(88, 58);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnOrder, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPay, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(908, 597);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(88, 117);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // layoutButton
            // 
            this.layoutButton.ColumnCount = 2;
            this.layoutButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.3247F));
            this.layoutButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.89177F));
            this.layoutButton.Controls.Add(this.btnChangeTable, 0, 1);
            this.layoutButton.Controls.Add(this.btnDiscount, 0, 0);
            this.layoutButton.Controls.Add(this.btnExtra, 1, 1);
            this.layoutButton.Controls.Add(this.btnVAT, 1, 0);
            this.layoutButton.Location = new System.Drawing.Point(730, 597);
            this.layoutButton.Margin = new System.Windows.Forms.Padding(0);
            this.layoutButton.Name = "layoutButton";
            this.layoutButton.RowCount = 2;
            this.layoutButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.layoutButton.Size = new System.Drawing.Size(178, 117);
            this.layoutButton.TabIndex = 24;
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.layoutButton);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateOrder";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateOrder";
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.layoutButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVAT;
        private System.Windows.Forms.Button btnExtra;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnChangeTable;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRight;
        private System.Windows.Forms.Label lbExtra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbVAT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbFoodPrice;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel layoutButton;
    }
}