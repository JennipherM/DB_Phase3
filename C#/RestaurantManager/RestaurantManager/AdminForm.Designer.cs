namespace RestaurantManager
{
    partial class AdminForm
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
            this.mmRemoveButton = new System.Windows.Forms.Button();
            this.mmAddButton = new System.Windows.Forms.Button();
            this.mmModifyButton = new System.Windows.Forms.Button();
            this.empMgmtAddBtn = new System.Windows.Forms.Button();
            this.empMgmtRmvBtn = new System.Windows.Forms.Button();
            this.addEmpGroup = new System.Windows.Forms.GroupBox();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_zip = new System.Windows.Forms.TextBox();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.tb_state = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_lName = new System.Windows.Forms.TextBox();
            this.tb_fName = new System.Windows.Forms.TextBox();
            this.tb_roleID = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.removeEmpGroup = new System.Windows.Forms.GroupBox();
            this.rmvEmpBtn = new System.Windows.Forms.Button();
            this.tb_rmvUserID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_empAdded = new System.Windows.Forms.Label();
            this.lb_empRemoved = new System.Windows.Forms.Label();
            this.addMenuGroup = new System.Windows.Forms.GroupBox();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_desc = new System.Windows.Forms.TextBox();
            this.tb_category = new System.Windows.Forms.TextBox();
            this.tb_itemName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lb_itemAdded = new System.Windows.Forms.Label();
            this.removeMenuGroup = new System.Windows.Forms.GroupBox();
            this.lb_itemRemoved = new System.Windows.Forms.Label();
            this.rmvItemBtn = new System.Windows.Forms.Button();
            this.tb_rmvItemID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.modMenuGroup = new System.Windows.Forms.GroupBox();
            this.lb_itemMod = new System.Windows.Forms.Label();
            this.modItemBtn = new System.Windows.Forms.Button();
            this.tb_modPrice = new System.Windows.Forms.TextBox();
            this.tb_modDesc = new System.Windows.Forms.TextBox();
            this.tb_modCat = new System.Windows.Forms.TextBox();
            this.tb_modItemName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_modItemID = new System.Windows.Forms.TextBox();
            this.addEmpGroup.SuspendLayout();
            this.removeEmpGroup.SuspendLayout();
            this.addMenuGroup.SuspendLayout();
            this.removeMenuGroup.SuspendLayout();
            this.modMenuGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(787, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admins";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Management:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Menu Management:";
            // 
            // mmRemoveButton
            // 
            this.mmRemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mmRemoveButton.FlatAppearance.BorderSize = 2;
            this.mmRemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mmRemoveButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmRemoveButton.Location = new System.Drawing.Point(410, 224);
            this.mmRemoveButton.Name = "mmRemoveButton";
            this.mmRemoveButton.Size = new System.Drawing.Size(107, 36);
            this.mmRemoveButton.TabIndex = 5;
            this.mmRemoveButton.Text = "Remove";
            this.mmRemoveButton.UseVisualStyleBackColor = true;
            this.mmRemoveButton.Click += new System.EventHandler(this.mmRemoveButton_Click);
            // 
            // mmAddButton
            // 
            this.mmAddButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mmAddButton.FlatAppearance.BorderSize = 2;
            this.mmAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mmAddButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmAddButton.Location = new System.Drawing.Point(297, 224);
            this.mmAddButton.Name = "mmAddButton";
            this.mmAddButton.Size = new System.Drawing.Size(107, 36);
            this.mmAddButton.TabIndex = 6;
            this.mmAddButton.Text = "Add";
            this.mmAddButton.UseVisualStyleBackColor = true;
            this.mmAddButton.Click += new System.EventHandler(this.mmAddButton_Click);
            // 
            // mmModifyButton
            // 
            this.mmModifyButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mmModifyButton.FlatAppearance.BorderSize = 2;
            this.mmModifyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mmModifyButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmModifyButton.Location = new System.Drawing.Point(523, 224);
            this.mmModifyButton.Name = "mmModifyButton";
            this.mmModifyButton.Size = new System.Drawing.Size(107, 36);
            this.mmModifyButton.TabIndex = 7;
            this.mmModifyButton.Text = "Modify";
            this.mmModifyButton.UseVisualStyleBackColor = true;
            this.mmModifyButton.Click += new System.EventHandler(this.mmModifyButton_Click);
            // 
            // empMgmtAddBtn
            // 
            this.empMgmtAddBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.empMgmtAddBtn.FlatAppearance.BorderSize = 2;
            this.empMgmtAddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.empMgmtAddBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empMgmtAddBtn.Location = new System.Drawing.Point(337, 119);
            this.empMgmtAddBtn.Name = "empMgmtAddBtn";
            this.empMgmtAddBtn.Size = new System.Drawing.Size(107, 36);
            this.empMgmtAddBtn.TabIndex = 8;
            this.empMgmtAddBtn.Text = "Add";
            this.empMgmtAddBtn.UseVisualStyleBackColor = true;
            this.empMgmtAddBtn.Click += new System.EventHandler(this.empMgmtAddBtn_Click);
            // 
            // empMgmtRmvBtn
            // 
            this.empMgmtRmvBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.empMgmtRmvBtn.FlatAppearance.BorderSize = 2;
            this.empMgmtRmvBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.empMgmtRmvBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empMgmtRmvBtn.Location = new System.Drawing.Point(450, 119);
            this.empMgmtRmvBtn.Name = "empMgmtRmvBtn";
            this.empMgmtRmvBtn.Size = new System.Drawing.Size(107, 36);
            this.empMgmtRmvBtn.TabIndex = 9;
            this.empMgmtRmvBtn.Text = "Remove";
            this.empMgmtRmvBtn.UseVisualStyleBackColor = true;
            this.empMgmtRmvBtn.Click += new System.EventHandler(this.empMgmtRmvBtn_Click);
            // 
            // addEmpGroup
            // 
            this.addEmpGroup.Controls.Add(this.lb_empAdded);
            this.addEmpGroup.Controls.Add(this.addEmpBtn);
            this.addEmpGroup.Controls.Add(this.tb_phone);
            this.addEmpGroup.Controls.Add(this.tb_zip);
            this.addEmpGroup.Controls.Add(this.tb_city);
            this.addEmpGroup.Controls.Add(this.tb_state);
            this.addEmpGroup.Controls.Add(this.tb_address);
            this.addEmpGroup.Controls.Add(this.tb_lName);
            this.addEmpGroup.Controls.Add(this.tb_fName);
            this.addEmpGroup.Controls.Add(this.tb_roleID);
            this.addEmpGroup.Controls.Add(this.tb_password);
            this.addEmpGroup.Controls.Add(this.label5);
            this.addEmpGroup.Controls.Add(this.label12);
            this.addEmpGroup.Controls.Add(this.label11);
            this.addEmpGroup.Controls.Add(this.label9);
            this.addEmpGroup.Controls.Add(this.label10);
            this.addEmpGroup.Controls.Add(this.label8);
            this.addEmpGroup.Controls.Add(this.label7);
            this.addEmpGroup.Controls.Add(this.label6);
            this.addEmpGroup.Controls.Add(this.label4);
            this.addEmpGroup.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.addEmpGroup.Location = new System.Drawing.Point(25, 293);
            this.addEmpGroup.Name = "addEmpGroup";
            this.addEmpGroup.Size = new System.Drawing.Size(787, 263);
            this.addEmpGroup.TabIndex = 10;
            this.addEmpGroup.TabStop = false;
            this.addEmpGroup.Text = "Add Employee";
            this.addEmpGroup.Visible = false;
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addEmpBtn.FlatAppearance.BorderSize = 2;
            this.addEmpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addEmpBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpBtn.Location = new System.Drawing.Point(614, 204);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(119, 36);
            this.addEmpBtn.TabIndex = 18;
            this.addEmpBtn.Text = "Add";
            this.addEmpBtn.UseVisualStyleBackColor = true;
            this.addEmpBtn.Click += new System.EventHandler(this.addEmpBtn_Click);
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(592, 36);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(129, 25);
            this.tb_phone.TabIndex = 17;
            // 
            // tb_zip
            // 
            this.tb_zip.Location = new System.Drawing.Point(326, 220);
            this.tb_zip.Name = "tb_zip";
            this.tb_zip.Size = new System.Drawing.Size(129, 25);
            this.tb_zip.TabIndex = 16;
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(326, 158);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(129, 25);
            this.tb_city.TabIndex = 15;
            // 
            // tb_state
            // 
            this.tb_state.Location = new System.Drawing.Point(326, 98);
            this.tb_state.Name = "tb_state";
            this.tb_state.Size = new System.Drawing.Size(129, 25);
            this.tb_state.TabIndex = 14;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(326, 36);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(129, 25);
            this.tb_address.TabIndex = 13;
            // 
            // tb_lName
            // 
            this.tb_lName.Location = new System.Drawing.Point(109, 218);
            this.tb_lName.Name = "tb_lName";
            this.tb_lName.Size = new System.Drawing.Size(129, 25);
            this.tb_lName.TabIndex = 12;
            // 
            // tb_fName
            // 
            this.tb_fName.Location = new System.Drawing.Point(109, 158);
            this.tb_fName.Name = "tb_fName";
            this.tb_fName.Size = new System.Drawing.Size(129, 25);
            this.tb_fName.TabIndex = 11;
            // 
            // tb_roleID
            // 
            this.tb_roleID.Location = new System.Drawing.Point(109, 100);
            this.tb_roleID.Name = "tb_roleID";
            this.tb_roleID.Size = new System.Drawing.Size(129, 25);
            this.tb_roleID.TabIndex = 10;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(109, 38);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(129, 25);
            this.tb_password.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Role ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(471, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Phone Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(258, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Zip:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(255, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "State:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(255, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "City:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(255, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password:";
            // 
            // removeEmpGroup
            // 
            this.removeEmpGroup.Controls.Add(this.lb_empRemoved);
            this.removeEmpGroup.Controls.Add(this.rmvEmpBtn);
            this.removeEmpGroup.Controls.Add(this.tb_rmvUserID);
            this.removeEmpGroup.Controls.Add(this.label13);
            this.removeEmpGroup.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.removeEmpGroup.Location = new System.Drawing.Point(175, 293);
            this.removeEmpGroup.Name = "removeEmpGroup";
            this.removeEmpGroup.Size = new System.Drawing.Size(400, 263);
            this.removeEmpGroup.TabIndex = 11;
            this.removeEmpGroup.TabStop = false;
            this.removeEmpGroup.Text = "Remove Employee";
            this.removeEmpGroup.Visible = false;
            // 
            // rmvEmpBtn
            // 
            this.rmvEmpBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rmvEmpBtn.FlatAppearance.BorderSize = 2;
            this.rmvEmpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rmvEmpBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmvEmpBtn.Location = new System.Drawing.Point(252, 204);
            this.rmvEmpBtn.Name = "rmvEmpBtn";
            this.rmvEmpBtn.Size = new System.Drawing.Size(107, 36);
            this.rmvEmpBtn.TabIndex = 10;
            this.rmvEmpBtn.Text = "Remove";
            this.rmvEmpBtn.UseVisualStyleBackColor = true;
            this.rmvEmpBtn.Click += new System.EventHandler(this.rmvEmpBtn_Click);
            // 
            // tb_rmvUserID
            // 
            this.tb_rmvUserID.Location = new System.Drawing.Point(140, 105);
            this.tb_rmvUserID.Name = "tb_rmvUserID";
            this.tb_rmvUserID.Size = new System.Drawing.Size(135, 25);
            this.tb_rmvUserID.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(67, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "UserID:";
            // 
            // lb_empAdded
            // 
            this.lb_empAdded.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lb_empAdded.Location = new System.Drawing.Point(610, 161);
            this.lb_empAdded.Name = "lb_empAdded";
            this.lb_empAdded.Size = new System.Drawing.Size(135, 23);
            this.lb_empAdded.TabIndex = 19;
            this.lb_empAdded.Text = "Employee Added!";
            this.lb_empAdded.Visible = false;
            // 
            // lb_empRemoved
            // 
            this.lb_empRemoved.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lb_empRemoved.Location = new System.Drawing.Point(228, 161);
            this.lb_empRemoved.Name = "lb_empRemoved";
            this.lb_empRemoved.Size = new System.Drawing.Size(153, 23);
            this.lb_empRemoved.TabIndex = 20;
            this.lb_empRemoved.Text = "Employee Removed!";
            this.lb_empRemoved.Visible = false;
            // 
            // addMenuGroup
            // 
            this.addMenuGroup.Controls.Add(this.lb_itemAdded);
            this.addMenuGroup.Controls.Add(this.addItemBtn);
            this.addMenuGroup.Controls.Add(this.tb_price);
            this.addMenuGroup.Controls.Add(this.tb_desc);
            this.addMenuGroup.Controls.Add(this.tb_category);
            this.addMenuGroup.Controls.Add(this.tb_itemName);
            this.addMenuGroup.Controls.Add(this.label24);
            this.addMenuGroup.Controls.Add(this.label21);
            this.addMenuGroup.Controls.Add(this.label22);
            this.addMenuGroup.Controls.Add(this.label23);
            this.addMenuGroup.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.addMenuGroup.Location = new System.Drawing.Point(175, 293);
            this.addMenuGroup.Name = "addMenuGroup";
            this.addMenuGroup.Size = new System.Drawing.Size(450, 263);
            this.addMenuGroup.TabIndex = 20;
            this.addMenuGroup.TabStop = false;
            this.addMenuGroup.Text = "Add Item";
            this.addMenuGroup.Visible = false;
            // 
            // addItemBtn
            // 
            this.addItemBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addItemBtn.FlatAppearance.BorderSize = 2;
            this.addItemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(333, 204);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(88, 36);
            this.addItemBtn.TabIndex = 18;
            this.addItemBtn.Text = "Add";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(121, 217);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(129, 25);
            this.tb_price.TabIndex = 12;
            // 
            // tb_desc
            // 
            this.tb_desc.Location = new System.Drawing.Point(121, 157);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.Size = new System.Drawing.Size(129, 25);
            this.tb_desc.TabIndex = 11;
            // 
            // tb_category
            // 
            this.tb_category.Location = new System.Drawing.Point(121, 98);
            this.tb_category.Name = "tb_category";
            this.tb_category.Size = new System.Drawing.Size(129, 25);
            this.tb_category.TabIndex = 10;
            // 
            // tb_itemName
            // 
            this.tb_itemName.Location = new System.Drawing.Point(121, 36);
            this.tb_itemName.Name = "tb_itemName";
            this.tb_itemName.Size = new System.Drawing.Size(129, 25);
            this.tb_itemName.TabIndex = 9;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(18, 100);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 20);
            this.label24.TabIndex = 8;
            this.label24.Text = "Category:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(18, 220);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 20);
            this.label21.TabIndex = 2;
            this.label21.Text = "Price:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(18, 160);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 20);
            this.label22.TabIndex = 1;
            this.label22.Text = "Description:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(18, 40);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 20);
            this.label23.TabIndex = 0;
            this.label23.Text = "Item Name:";
            // 
            // lb_itemAdded
            // 
            this.lb_itemAdded.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lb_itemAdded.Location = new System.Drawing.Point(329, 161);
            this.lb_itemAdded.Name = "lb_itemAdded";
            this.lb_itemAdded.Size = new System.Drawing.Size(101, 23);
            this.lb_itemAdded.TabIndex = 19;
            this.lb_itemAdded.Text = "Item Added!";
            this.lb_itemAdded.Visible = false;
            // 
            // removeMenuGroup
            // 
            this.removeMenuGroup.Controls.Add(this.lb_itemRemoved);
            this.removeMenuGroup.Controls.Add(this.rmvItemBtn);
            this.removeMenuGroup.Controls.Add(this.tb_rmvItemID);
            this.removeMenuGroup.Controls.Add(this.label15);
            this.removeMenuGroup.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.removeMenuGroup.Location = new System.Drawing.Point(175, 293);
            this.removeMenuGroup.Name = "removeMenuGroup";
            this.removeMenuGroup.Size = new System.Drawing.Size(400, 263);
            this.removeMenuGroup.TabIndex = 21;
            this.removeMenuGroup.TabStop = false;
            this.removeMenuGroup.Text = "Remove Item";
            this.removeMenuGroup.Visible = false;
            // 
            // lb_itemRemoved
            // 
            this.lb_itemRemoved.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lb_itemRemoved.Location = new System.Drawing.Point(248, 164);
            this.lb_itemRemoved.Name = "lb_itemRemoved";
            this.lb_itemRemoved.Size = new System.Drawing.Size(119, 23);
            this.lb_itemRemoved.TabIndex = 20;
            this.lb_itemRemoved.Text = "Item Removed!";
            this.lb_itemRemoved.Visible = false;
            // 
            // rmvItemBtn
            // 
            this.rmvItemBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rmvItemBtn.FlatAppearance.BorderSize = 2;
            this.rmvItemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rmvItemBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmvItemBtn.Location = new System.Drawing.Point(252, 204);
            this.rmvItemBtn.Name = "rmvItemBtn";
            this.rmvItemBtn.Size = new System.Drawing.Size(107, 36);
            this.rmvItemBtn.TabIndex = 10;
            this.rmvItemBtn.Text = "Remove";
            this.rmvItemBtn.UseVisualStyleBackColor = true;
            this.rmvItemBtn.Click += new System.EventHandler(this.rmvItemBtn_Click);
            // 
            // tb_rmvItemID
            // 
            this.tb_rmvItemID.Location = new System.Drawing.Point(140, 105);
            this.tb_rmvItemID.Name = "tb_rmvItemID";
            this.tb_rmvItemID.Size = new System.Drawing.Size(135, 25);
            this.tb_rmvItemID.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(67, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "ItemID:";
            // 
            // modMenuGroup
            // 
            this.modMenuGroup.Controls.Add(this.tb_modItemID);
            this.modMenuGroup.Controls.Add(this.label14);
            this.modMenuGroup.Controls.Add(this.lb_itemMod);
            this.modMenuGroup.Controls.Add(this.modItemBtn);
            this.modMenuGroup.Controls.Add(this.tb_modPrice);
            this.modMenuGroup.Controls.Add(this.tb_modDesc);
            this.modMenuGroup.Controls.Add(this.tb_modCat);
            this.modMenuGroup.Controls.Add(this.tb_modItemName);
            this.modMenuGroup.Controls.Add(this.label16);
            this.modMenuGroup.Controls.Add(this.label17);
            this.modMenuGroup.Controls.Add(this.label18);
            this.modMenuGroup.Controls.Add(this.label19);
            this.modMenuGroup.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.modMenuGroup.Location = new System.Drawing.Point(175, 293);
            this.modMenuGroup.Name = "modMenuGroup";
            this.modMenuGroup.Size = new System.Drawing.Size(500, 263);
            this.modMenuGroup.TabIndex = 21;
            this.modMenuGroup.TabStop = false;
            this.modMenuGroup.Text = "Modify Item";
            this.modMenuGroup.Visible = false;
            // 
            // lb_itemMod
            // 
            this.lb_itemMod.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.lb_itemMod.Location = new System.Drawing.Point(312, 161);
            this.lb_itemMod.Name = "lb_itemMod";
            this.lb_itemMod.Size = new System.Drawing.Size(118, 23);
            this.lb_itemMod.TabIndex = 19;
            this.lb_itemMod.Text = "Item Modified!";
            this.lb_itemMod.Visible = false;
            // 
            // modItemBtn
            // 
            this.modItemBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.modItemBtn.FlatAppearance.BorderSize = 2;
            this.modItemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.modItemBtn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modItemBtn.Location = new System.Drawing.Point(333, 204);
            this.modItemBtn.Name = "modItemBtn";
            this.modItemBtn.Size = new System.Drawing.Size(88, 36);
            this.modItemBtn.TabIndex = 18;
            this.modItemBtn.Text = "Modify";
            this.modItemBtn.UseVisualStyleBackColor = true;
            this.modItemBtn.Click += new System.EventHandler(this.modItemBtn_Click);
            // 
            // tb_modPrice
            // 
            this.tb_modPrice.Location = new System.Drawing.Point(333, 35);
            this.tb_modPrice.Name = "tb_modPrice";
            this.tb_modPrice.Size = new System.Drawing.Size(129, 25);
            this.tb_modPrice.TabIndex = 12;
            // 
            // tb_modDesc
            // 
            this.tb_modDesc.Location = new System.Drawing.Point(110, 217);
            this.tb_modDesc.Name = "tb_modDesc";
            this.tb_modDesc.Size = new System.Drawing.Size(129, 25);
            this.tb_modDesc.TabIndex = 11;
            // 
            // tb_modCat
            // 
            this.tb_modCat.Location = new System.Drawing.Point(110, 157);
            this.tb_modCat.Name = "tb_modCat";
            this.tb_modCat.Size = new System.Drawing.Size(129, 25);
            this.tb_modCat.TabIndex = 10;
            // 
            // tb_modItemName
            // 
            this.tb_modItemName.Location = new System.Drawing.Point(110, 97);
            this.tb_modItemName.Name = "tb_modItemName";
            this.tb_modItemName.Size = new System.Drawing.Size(129, 25);
            this.tb_modItemName.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 160);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "Category:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(269, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "Price:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(15, 220);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 20);
            this.label18.TabIndex = 1;
            this.label18.Text = "Description:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Item Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Item ID:";
            // 
            // tb_modItemID
            // 
            this.tb_modItemID.Location = new System.Drawing.Point(110, 38);
            this.tb_modItemID.Name = "tb_modItemID";
            this.tb_modItemID.Size = new System.Drawing.Size(129, 25);
            this.tb_modItemID.TabIndex = 21;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(835, 590);
            this.Controls.Add(this.modMenuGroup);
            this.Controls.Add(this.removeMenuGroup);
            this.Controls.Add(this.addMenuGroup);
            this.Controls.Add(this.removeEmpGroup);
            this.Controls.Add(this.addEmpGroup);
            this.Controls.Add(this.empMgmtRmvBtn);
            this.Controls.Add(this.empMgmtAddBtn);
            this.Controls.Add(this.mmModifyButton);
            this.Controls.Add(this.mmAddButton);
            this.Controls.Add(this.mmRemoveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.addEmpGroup.ResumeLayout(false);
            this.addEmpGroup.PerformLayout();
            this.removeEmpGroup.ResumeLayout(false);
            this.removeEmpGroup.PerformLayout();
            this.addMenuGroup.ResumeLayout(false);
            this.addMenuGroup.PerformLayout();
            this.removeMenuGroup.ResumeLayout(false);
            this.removeMenuGroup.PerformLayout();
            this.modMenuGroup.ResumeLayout(false);
            this.modMenuGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button mmRemoveButton;
        private System.Windows.Forms.Button mmAddButton;
        private System.Windows.Forms.Button mmModifyButton;
        private System.Windows.Forms.Button empMgmtAddBtn;
        private System.Windows.Forms.Button empMgmtRmvBtn;
        private System.Windows.Forms.GroupBox addEmpGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button addEmpBtn;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_zip;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.TextBox tb_state;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_lName;
        private System.Windows.Forms.TextBox tb_fName;
        private System.Windows.Forms.TextBox tb_roleID;
        private System.Windows.Forms.GroupBox removeEmpGroup;
        private System.Windows.Forms.Button rmvEmpBtn;
        private System.Windows.Forms.TextBox tb_rmvUserID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_empAdded;
        private System.Windows.Forms.Label lb_empRemoved;
        private System.Windows.Forms.GroupBox addMenuGroup;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_desc;
        private System.Windows.Forms.TextBox tb_category;
        private System.Windows.Forms.TextBox tb_itemName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lb_itemAdded;
        private System.Windows.Forms.GroupBox removeMenuGroup;
        private System.Windows.Forms.Label lb_itemRemoved;
        private System.Windows.Forms.Button rmvItemBtn;
        private System.Windows.Forms.TextBox tb_rmvItemID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox modMenuGroup;
        private System.Windows.Forms.Label lb_itemMod;
        private System.Windows.Forms.Button modItemBtn;
        private System.Windows.Forms.TextBox tb_modPrice;
        private System.Windows.Forms.TextBox tb_modDesc;
        private System.Windows.Forms.TextBox tb_modCat;
        private System.Windows.Forms.TextBox tb_modItemName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_modItemID;
        private System.Windows.Forms.Label label14;
    }
}