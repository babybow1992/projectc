namespace reallyreallylast
{
    partial class AddItems
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCategoryInAdd = new System.Windows.Forms.ComboBox();
            this.txtNameItems = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPriceItems = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuanitityItems = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listitems = new System.Windows.Forms.DataGridView();
            this.btnadditem = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHistoryInAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogoutInAdd = new System.Windows.Forms.LinkLabel();
            this.btnExitInAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnRemoveItemsInAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateItemsInAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddItems = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrderInAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listitems)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.listitems);
            this.panel2.Controls.Add(this.btnadditem);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(211, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 514);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCategoryInAdd);
            this.groupBox1.Controls.Add(this.txtNameItems);
            this.groupBox1.Controls.Add(this.txtPriceItems);
            this.groupBox1.Controls.Add(this.txtQuanitityItems);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(29, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 320);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // txtCategoryInAdd
            // 
            this.txtCategoryInAdd.FormattingEnabled = true;
            this.txtCategoryInAdd.Location = new System.Drawing.Point(42, 70);
            this.txtCategoryInAdd.Name = "txtCategoryInAdd";
            this.txtCategoryInAdd.Size = new System.Drawing.Size(239, 28);
            this.txtCategoryInAdd.TabIndex = 11;
            // 
            // txtNameItems
            // 
            this.txtNameItems.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameItems.DefaultText = "";
            this.txtNameItems.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameItems.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameItems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameItems.DisabledState.Parent = this.txtNameItems;
            this.txtNameItems.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameItems.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameItems.FocusedState.Parent = this.txtNameItems;
            this.txtNameItems.ForeColor = System.Drawing.Color.Black;
            this.txtNameItems.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameItems.HoverState.Parent = this.txtNameItems;
            this.txtNameItems.Location = new System.Drawing.Point(44, 144);
            this.txtNameItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameItems.Name = "txtNameItems";
            this.txtNameItems.PasswordChar = '\0';
            this.txtNameItems.PlaceholderText = "";
            this.txtNameItems.SelectedText = "";
            this.txtNameItems.ShadowDecoration.Parent = this.txtNameItems;
            this.txtNameItems.Size = new System.Drawing.Size(237, 31);
            this.txtNameItems.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNameItems.TabIndex = 8;
            this.txtNameItems.TextChanged += new System.EventHandler(this.txtNameItems_TextChanged);
            // 
            // txtPriceItems
            // 
            this.txtPriceItems.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriceItems.DefaultText = "";
            this.txtPriceItems.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriceItems.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPriceItems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceItems.DisabledState.Parent = this.txtPriceItems;
            this.txtPriceItems.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceItems.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceItems.FocusedState.Parent = this.txtPriceItems;
            this.txtPriceItems.ForeColor = System.Drawing.Color.Black;
            this.txtPriceItems.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceItems.HoverState.Parent = this.txtPriceItems;
            this.txtPriceItems.Location = new System.Drawing.Point(42, 274);
            this.txtPriceItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPriceItems.Name = "txtPriceItems";
            this.txtPriceItems.PasswordChar = '\0';
            this.txtPriceItems.PlaceholderText = "";
            this.txtPriceItems.SelectedText = "";
            this.txtPriceItems.ShadowDecoration.Parent = this.txtPriceItems;
            this.txtPriceItems.Size = new System.Drawing.Size(239, 31);
            this.txtPriceItems.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPriceItems.TabIndex = 9;
            // 
            // txtQuanitityItems
            // 
            this.txtQuanitityItems.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuanitityItems.DefaultText = "";
            this.txtQuanitityItems.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuanitityItems.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuanitityItems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuanitityItems.DisabledState.Parent = this.txtQuanitityItems;
            this.txtQuanitityItems.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuanitityItems.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuanitityItems.FocusedState.Parent = this.txtQuanitityItems;
            this.txtQuanitityItems.ForeColor = System.Drawing.Color.Black;
            this.txtQuanitityItems.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuanitityItems.HoverState.Parent = this.txtQuanitityItems;
            this.txtQuanitityItems.Location = new System.Drawing.Point(44, 212);
            this.txtQuanitityItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuanitityItems.Name = "txtQuanitityItems";
            this.txtQuanitityItems.PasswordChar = '\0';
            this.txtQuanitityItems.PlaceholderText = "";
            this.txtQuanitityItems.SelectedText = "";
            this.txtQuanitityItems.ShadowDecoration.Parent = this.txtQuanitityItems;
            this.txtQuanitityItems.Size = new System.Drawing.Size(239, 31);
            this.txtQuanitityItems.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtQuanitityItems.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quanitity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(45, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(45, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // listitems
            // 
            this.listitems.AllowUserToAddRows = false;
            this.listitems.AllowUserToDeleteRows = false;
            this.listitems.BackgroundColor = System.Drawing.Color.White;
            this.listitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listitems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listitems.Location = new System.Drawing.Point(355, 81);
            this.listitems.Name = "listitems";
            this.listitems.ReadOnly = true;
            this.listitems.RowHeadersWidth = 62;
            this.listitems.RowTemplate.Height = 28;
            this.listitems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listitems.Size = new System.Drawing.Size(406, 345);
            this.listitems.TabIndex = 16;
            this.listitems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listitems_CellContentClick);
            // 
            // btnadditem
            // 
            this.btnadditem.BackColor = System.Drawing.Color.Magenta;
            this.btnadditem.CheckedState.Parent = this.btnadditem;
            this.btnadditem.CustomImages.Parent = this.btnadditem;
            this.btnadditem.FillColor = System.Drawing.Color.Orange;
            this.btnadditem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnadditem.ForeColor = System.Drawing.Color.White;
            this.btnadditem.HoverState.Parent = this.btnadditem;
            this.btnadditem.Location = new System.Drawing.Point(127, 419);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.ShadowDecoration.Parent = this.btnadditem;
            this.btnadditem.Size = new System.Drawing.Size(145, 45);
            this.btnadditem.TabIndex = 15;
            this.btnadditem.Text = "Add Items";
            this.btnadditem.Click += new System.EventHandler(this.btnadditem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(280, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Items";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnHistoryInAdd);
            this.panel1.Controls.Add(this.btnLogoutInAdd);
            this.panel1.Controls.Add(this.btnExitInAdd);
            this.panel1.Controls.Add(this.btnRemoveItemsInAdd);
            this.panel1.Controls.Add(this.btnUpdateItemsInAdd);
            this.panel1.Controls.Add(this.btnAddItems);
            this.panel1.Controls.Add(this.btnOrderInAdd);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 514);
            this.panel1.TabIndex = 17;
            // 
            // btnHistoryInAdd
            // 
            this.btnHistoryInAdd.BackColor = System.Drawing.Color.Magenta;
            this.btnHistoryInAdd.CheckedState.Parent = this.btnHistoryInAdd;
            this.btnHistoryInAdd.CustomImages.Parent = this.btnHistoryInAdd;
            this.btnHistoryInAdd.FillColor = System.Drawing.Color.Orange;
            this.btnHistoryInAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHistoryInAdd.ForeColor = System.Drawing.Color.White;
            this.btnHistoryInAdd.HoverState.Parent = this.btnHistoryInAdd;
            this.btnHistoryInAdd.Location = new System.Drawing.Point(13, 333);
            this.btnHistoryInAdd.Name = "btnHistoryInAdd";
            this.btnHistoryInAdd.ShadowDecoration.Parent = this.btnHistoryInAdd;
            this.btnHistoryInAdd.Size = new System.Drawing.Size(180, 45);
            this.btnHistoryInAdd.TabIndex = 5;
            this.btnHistoryInAdd.Text = "History";
            this.btnHistoryInAdd.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnLogoutInAdd
            // 
            this.btnLogoutInAdd.AutoSize = true;
            this.btnLogoutInAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnLogoutInAdd.LinkColor = System.Drawing.Color.Orange;
            this.btnLogoutInAdd.Location = new System.Drawing.Point(85, 444);
            this.btnLogoutInAdd.Name = "btnLogoutInAdd";
            this.btnLogoutInAdd.Size = new System.Drawing.Size(59, 20);
            this.btnLogoutInAdd.TabIndex = 4;
            this.btnLogoutInAdd.TabStop = true;
            this.btnLogoutInAdd.Text = "Logout";
            this.btnLogoutInAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogout_LinkClicked);
            // 
            // btnExitInAdd
            // 
            this.btnExitInAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnExitInAdd.CheckedState.Parent = this.btnExitInAdd;
            this.btnExitInAdd.CustomImages.Parent = this.btnExitInAdd;
            this.btnExitInAdd.FillColor = System.Drawing.Color.Orange;
            this.btnExitInAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExitInAdd.ForeColor = System.Drawing.Color.White;
            this.btnExitInAdd.HoverState.Parent = this.btnExitInAdd;
            this.btnExitInAdd.Location = new System.Drawing.Point(0, 0);
            this.btnExitInAdd.Name = "btnExitInAdd";
            this.btnExitInAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExitInAdd.ShadowDecoration.Parent = this.btnExitInAdd;
            this.btnExitInAdd.Size = new System.Drawing.Size(41, 40);
            this.btnExitInAdd.TabIndex = 0;
            this.btnExitInAdd.Text = "X";
            this.btnExitInAdd.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemoveItemsInAdd
            // 
            this.btnRemoveItemsInAdd.BackColor = System.Drawing.Color.Magenta;
            this.btnRemoveItemsInAdd.CheckedState.Parent = this.btnRemoveItemsInAdd;
            this.btnRemoveItemsInAdd.CustomImages.Parent = this.btnRemoveItemsInAdd;
            this.btnRemoveItemsInAdd.FillColor = System.Drawing.Color.Orange;
            this.btnRemoveItemsInAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveItemsInAdd.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItemsInAdd.HoverState.Parent = this.btnRemoveItemsInAdd;
            this.btnRemoveItemsInAdd.Location = new System.Drawing.Point(13, 271);
            this.btnRemoveItemsInAdd.Name = "btnRemoveItemsInAdd";
            this.btnRemoveItemsInAdd.ShadowDecoration.Parent = this.btnRemoveItemsInAdd;
            this.btnRemoveItemsInAdd.Size = new System.Drawing.Size(180, 45);
            this.btnRemoveItemsInAdd.TabIndex = 3;
            this.btnRemoveItemsInAdd.Text = "Remove Items";
            this.btnRemoveItemsInAdd.Click += new System.EventHandler(this.btnRemoveItems_Click);
            // 
            // btnUpdateItemsInAdd
            // 
            this.btnUpdateItemsInAdd.BackColor = System.Drawing.Color.Magenta;
            this.btnUpdateItemsInAdd.CheckedState.Parent = this.btnUpdateItemsInAdd;
            this.btnUpdateItemsInAdd.CustomImages.Parent = this.btnUpdateItemsInAdd;
            this.btnUpdateItemsInAdd.FillColor = System.Drawing.Color.Orange;
            this.btnUpdateItemsInAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateItemsInAdd.ForeColor = System.Drawing.Color.White;
            this.btnUpdateItemsInAdd.HoverState.Parent = this.btnUpdateItemsInAdd;
            this.btnUpdateItemsInAdd.Location = new System.Drawing.Point(13, 210);
            this.btnUpdateItemsInAdd.Name = "btnUpdateItemsInAdd";
            this.btnUpdateItemsInAdd.ShadowDecoration.Parent = this.btnUpdateItemsInAdd;
            this.btnUpdateItemsInAdd.Size = new System.Drawing.Size(180, 45);
            this.btnUpdateItemsInAdd.TabIndex = 2;
            this.btnUpdateItemsInAdd.Text = "Update Items";
            this.btnUpdateItemsInAdd.Click += new System.EventHandler(this.btnUpdateItems_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(175)))), ((int)(((byte)(91)))));
            this.btnAddItems.CheckedState.Parent = this.btnAddItems;
            this.btnAddItems.CustomImages.Parent = this.btnAddItems;
            this.btnAddItems.FillColor = System.Drawing.Color.Orange;
            this.btnAddItems.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddItems.ForeColor = System.Drawing.Color.White;
            this.btnAddItems.HoverState.Parent = this.btnAddItems;
            this.btnAddItems.Location = new System.Drawing.Point(13, 146);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.ShadowDecoration.Parent = this.btnAddItems;
            this.btnAddItems.Size = new System.Drawing.Size(180, 45);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add items";
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnOrderInAdd
            // 
            this.btnOrderInAdd.BackColor = System.Drawing.Color.Magenta;
            this.btnOrderInAdd.CheckedState.Parent = this.btnOrderInAdd;
            this.btnOrderInAdd.CustomImages.Parent = this.btnOrderInAdd;
            this.btnOrderInAdd.FillColor = System.Drawing.Color.Orange;
            this.btnOrderInAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrderInAdd.ForeColor = System.Drawing.Color.White;
            this.btnOrderInAdd.HoverState.Parent = this.btnOrderInAdd;
            this.btnOrderInAdd.Location = new System.Drawing.Point(13, 82);
            this.btnOrderInAdd.Name = "btnOrderInAdd";
            this.btnOrderInAdd.ShadowDecoration.Parent = this.btnOrderInAdd;
            this.btnOrderInAdd.Size = new System.Drawing.Size(180, 45);
            this.btnOrderInAdd.TabIndex = 0;
            this.btnOrderInAdd.Text = "Order";
            this.btnOrderInAdd.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItems";
            this.Text = "AddItems";
            this.Load += new System.EventHandler(this.AddItems_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listitems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnadditem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtQuanitityItems;
        private Guna.UI2.WinForms.Guna2TextBox txtNameItems;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtPriceItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel btnLogoutInAdd;
        private Guna.UI2.WinForms.Guna2CircleButton btnExitInAdd;
        private Guna.UI2.WinForms.Guna2Button btnRemoveItemsInAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdateItemsInAdd;
        private Guna.UI2.WinForms.Guna2Button btnAddItems;
        private Guna.UI2.WinForms.Guna2Button btnOrderInAdd;
        private Guna.UI2.WinForms.Guna2Button btnHistoryInAdd;
        private System.Windows.Forms.DataGridView listitems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtCategoryInAdd;
    }
}