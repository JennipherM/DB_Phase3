namespace RestaurantManager
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.tb_userID = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.salesGroup = new System.Windows.Forms.GroupBox();
            this.topSalesBtn = new System.Windows.Forms.Button();
            this.rpViewRsvBtn = new System.Windows.Forms.Button();
            this.dgv_Sales = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.viewSalesBtn = new System.Windows.Forms.Button();
            this.tb_dateSales = new System.Windows.Forms.TextBox();
            this.viewReportsBtn = new System.Windows.Forms.Button();
            this.salesGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant Manager Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserID:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // tb_userID
            // 
            this.tb_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_userID.Location = new System.Drawing.Point(276, 113);
            this.tb_userID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_userID.Name = "tb_userID";
            this.tb_userID.Size = new System.Drawing.Size(188, 23);
            this.tb_userID.TabIndex = 3;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(276, 177);
            this.tb_password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(188, 23);
            this.tb_password.TabIndex = 4;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.submitButton.Location = new System.Drawing.Point(371, 232);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(93, 37);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // salesGroup
            // 
            this.salesGroup.Controls.Add(this.topSalesBtn);
            this.salesGroup.Controls.Add(this.rpViewRsvBtn);
            this.salesGroup.Controls.Add(this.dgv_Sales);
            this.salesGroup.Controls.Add(this.label4);
            this.salesGroup.Controls.Add(this.viewSalesBtn);
            this.salesGroup.Controls.Add(this.tb_dateSales);
            this.salesGroup.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.salesGroup.Location = new System.Drawing.Point(47, 288);
            this.salesGroup.Name = "salesGroup";
            this.salesGroup.Size = new System.Drawing.Size(632, 254);
            this.salesGroup.TabIndex = 7;
            this.salesGroup.TabStop = false;
            this.salesGroup.Text = "Reports";
            this.salesGroup.Visible = false;
            // 
            // topSalesBtn
            // 
            this.topSalesBtn.Location = new System.Drawing.Point(27, 82);
            this.topSalesBtn.Name = "topSalesBtn";
            this.topSalesBtn.Size = new System.Drawing.Size(135, 34);
            this.topSalesBtn.TabIndex = 6;
            this.topSalesBtn.Text = "Top 3 Sales";
            this.topSalesBtn.UseVisualStyleBackColor = true;
            this.topSalesBtn.Click += new System.EventHandler(this.topSalesBtn_Click);
            // 
            // rpViewRsvBtn
            // 
            this.rpViewRsvBtn.Location = new System.Drawing.Point(23, 35);
            this.rpViewRsvBtn.Name = "rpViewRsvBtn";
            this.rpViewRsvBtn.Size = new System.Drawing.Size(139, 34);
            this.rpViewRsvBtn.TabIndex = 5;
            this.rpViewRsvBtn.Text = "View Reservations";
            this.rpViewRsvBtn.UseVisualStyleBackColor = true;
            this.rpViewRsvBtn.Click += new System.EventHandler(this.rpViewRsvBtn_Click);
            // 
            // dgv_Sales
            // 
            this.dgv_Sales.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgv_Sales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sales.Location = new System.Drawing.Point(258, 12);
            this.dgv_Sales.Name = "dgv_Sales";
            this.dgv_Sales.Size = new System.Drawing.Size(363, 236);
            this.dgv_Sales.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date:";
            // 
            // viewSalesBtn
            // 
            this.viewSalesBtn.Location = new System.Drawing.Point(79, 200);
            this.viewSalesBtn.Name = "viewSalesBtn";
            this.viewSalesBtn.Size = new System.Drawing.Size(95, 34);
            this.viewSalesBtn.TabIndex = 0;
            this.viewSalesBtn.Text = "View Sales";
            this.viewSalesBtn.UseVisualStyleBackColor = true;
            this.viewSalesBtn.Click += new System.EventHandler(this.viewSalesBtn_Click);
            // 
            // tb_dateSales
            // 
            this.tb_dateSales.Location = new System.Drawing.Point(70, 169);
            this.tb_dateSales.Name = "tb_dateSales";
            this.tb_dateSales.Size = new System.Drawing.Size(131, 25);
            this.tb_dateSales.TabIndex = 2;
            // 
            // viewReportsBtn
            // 
            this.viewReportsBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.viewReportsBtn.Location = new System.Drawing.Point(253, 232);
            this.viewReportsBtn.Name = "viewReportsBtn";
            this.viewReportsBtn.Size = new System.Drawing.Size(107, 37);
            this.viewReportsBtn.TabIndex = 8;
            this.viewReportsBtn.Text = "View Reports";
            this.viewReportsBtn.UseVisualStyleBackColor = true;
            this.viewReportsBtn.Click += new System.EventHandler(this.viewReportsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(737, 554);
            this.Controls.Add(this.viewReportsBtn);
            this.Controls.Add(this.salesGroup);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_userID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Manager Login";
            this.salesGroup.ResumeLayout(false);
            this.salesGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_userID;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox salesGroup;
        private System.Windows.Forms.TextBox tb_dateSales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button viewSalesBtn;
        private System.Windows.Forms.Button viewReportsBtn;
        private System.Windows.Forms.DataGridView dgv_Sales;
        private System.Windows.Forms.Button rpViewRsvBtn;
        private System.Windows.Forms.Button topSalesBtn;
    }
}

