﻿namespace Gaudit
{
    partial class GilFondObjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GilFondObjects));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCurrObjID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grdGFObjects = new System.Windows.Forms.DataGridView();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.lblCurrPorch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetPomesch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdPomesch = new System.Windows.Forms.DataGridView();
            this.grdPorch = new System.Windows.Forms.DataGridView();
            this.btnDeletePorch = new System.Windows.Forms.Button();
            this.btnGetPorch = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnNegilDelete = new System.Windows.Forms.Button();
            this.btnNegilAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grdNegil = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGFObjects)).BeginInit();
            this.tabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPomesch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPorch)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNegil)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1324, 642);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.lblCurrObjID);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnGetSave);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.grdGFObjects);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1316, 616);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Объекты жил. фонда";
            // 
            // lblCurrObjID
            // 
            this.lblCurrObjID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrObjID.AutoSize = true;
            this.lblCurrObjID.Location = new System.Drawing.Point(1122, 189);
            this.lblCurrObjID.Name = "lblCurrObjID";
            this.lblCurrObjID.Size = new System.Drawing.Size(10, 13);
            this.lblCurrObjID.TabIndex = 25;
            this.lblCurrObjID.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Характеристики объектов жил. фонда";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Image = global::Gaudit.Properties.Resources.ChangeQueryType_deletequery_274_32;
            this.btnDelete.Location = new System.Drawing.Point(1125, 125);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 45);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Удалить выбранный объект";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnGetSave
            // 
            this.btnGetSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetSave.Image = ((System.Drawing.Image)(resources.GetObject("btnGetSave.Image")));
            this.btnGetSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetSave.Location = new System.Drawing.Point(1125, 65);
            this.btnGetSave.Name = "btnGetSave";
            this.btnGetSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGetSave.Size = new System.Drawing.Size(170, 45);
            this.btnGetSave.TabIndex = 16;
            this.btnGetSave.Text = "Сохранить данные объектов жил.фонда";
            this.btnGetSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetSave.UseVisualStyleBackColor = true;
            this.btnGetSave.Click += new System.EventHandler(this.btnGetSave_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 1, 1, 1);
            this.label2.Size = new System.Drawing.Size(1292, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Реестр объектов жил. фонда: https://my.dom.gosuslugi.ru/organization-cabinet/#!/h" +
    "ouse/list";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grdGFObjects
            // 
            this.grdGFObjects.AllowUserToAddRows = false;
            this.grdGFObjects.AllowUserToDeleteRows = false;
            this.grdGFObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdGFObjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdGFObjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdGFObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGFObjects.Location = new System.Drawing.Point(9, 65);
            this.grdGFObjects.MultiSelect = false;
            this.grdGFObjects.Name = "grdGFObjects";
            this.grdGFObjects.ReadOnly = true;
            this.grdGFObjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdGFObjects.Size = new System.Drawing.Size(1089, 527);
            this.grdGFObjects.TabIndex = 0;
            this.grdGFObjects.SelectionChanged += new System.EventHandler(this.grdGFObjects_SelectionChanged);
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage11.Controls.Add(this.lblCurrPorch);
            this.tabPage11.Controls.Add(this.label4);
            this.tabPage11.Controls.Add(this.btnGetPomesch);
            this.tabPage11.Controls.Add(this.label3);
            this.tabPage11.Controls.Add(this.label1);
            this.tabPage11.Controls.Add(this.grdPomesch);
            this.tabPage11.Controls.Add(this.grdPorch);
            this.tabPage11.Controls.Add(this.btnDeletePorch);
            this.tabPage11.Controls.Add(this.btnGetPorch);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(1316, 616);
            this.tabPage11.TabIndex = 5;
            this.tabPage11.Text = "Подъезды и помещения";
            // 
            // lblCurrPorch
            // 
            this.lblCurrPorch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrPorch.AutoSize = true;
            this.lblCurrPorch.Location = new System.Drawing.Point(1118, 184);
            this.lblCurrPorch.Name = "lblCurrPorch";
            this.lblCurrPorch.Size = new System.Drawing.Size(10, 13);
            this.lblCurrPorch.TabIndex = 28;
            this.lblCurrPorch.Text = "-";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(15, 1, 1, 1);
            this.label4.Size = new System.Drawing.Size(1301, 30);
            this.label4.TabIndex = 27;
            this.label4.Text = "Подъезды и квартиры: https://my.dom.gosuslugi.ru/organization-cabinet/#!/house/ca" +
    "rd?houseCardGuid...";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGetPomesch
            // 
            this.btnGetPomesch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetPomesch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetPomesch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetPomesch.Image = ((System.Drawing.Image)(resources.GetObject("btnGetPomesch.Image")));
            this.btnGetPomesch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetPomesch.Location = new System.Drawing.Point(1121, 258);
            this.btnGetPomesch.Name = "btnGetPomesch";
            this.btnGetPomesch.Size = new System.Drawing.Size(170, 45);
            this.btnGetPomesch.TabIndex = 26;
            this.btnGetPomesch.Text = "     Сохранить данные  помещений";
            this.btnGetPomesch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetPomesch.UseVisualStyleBackColor = true;
            this.btnGetPomesch.Click += new System.EventHandler(this.btnGetPomesch_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Помещения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Подъезды";
            // 
            // grdPomesch
            // 
            this.grdPomesch.AllowDrop = true;
            this.grdPomesch.AllowUserToAddRows = false;
            this.grdPomesch.AllowUserToDeleteRows = false;
            this.grdPomesch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPomesch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPomesch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPomesch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPomesch.Location = new System.Drawing.Point(12, 258);
            this.grdPomesch.Name = "grdPomesch";
            this.grdPomesch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPomesch.Size = new System.Drawing.Size(1080, 345);
            this.grdPomesch.TabIndex = 21;
            // 
            // grdPorch
            // 
            this.grdPorch.AllowUserToAddRows = false;
            this.grdPorch.AllowUserToDeleteRows = false;
            this.grdPorch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPorch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPorch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPorch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPorch.Location = new System.Drawing.Point(12, 61);
            this.grdPorch.Name = "grdPorch";
            this.grdPorch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPorch.Size = new System.Drawing.Size(1080, 158);
            this.grdPorch.TabIndex = 20;
            this.grdPorch.SelectionChanged += new System.EventHandler(this.grdPorch_SelectionChanged);
            // 
            // btnDeletePorch
            // 
            this.btnDeletePorch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePorch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeletePorch.Image = global::Gaudit.Properties.Resources.ChangeQueryType_deletequery_274_32;
            this.btnDeletePorch.Location = new System.Drawing.Point(1121, 125);
            this.btnDeletePorch.Name = "btnDeletePorch";
            this.btnDeletePorch.Size = new System.Drawing.Size(170, 45);
            this.btnDeletePorch.TabIndex = 19;
            this.btnDeletePorch.Text = "   Удалить выбранный подъезд";
            this.btnDeletePorch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletePorch.UseVisualStyleBackColor = true;
            this.btnDeletePorch.Click += new System.EventHandler(this.btnDeletePorch_Click);
            // 
            // btnGetPorch
            // 
            this.btnGetPorch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetPorch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetPorch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetPorch.Image = ((System.Drawing.Image)(resources.GetObject("btnGetPorch.Image")));
            this.btnGetPorch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetPorch.Location = new System.Drawing.Point(1121, 61);
            this.btnGetPorch.Name = "btnGetPorch";
            this.btnGetPorch.Size = new System.Drawing.Size(170, 45);
            this.btnGetPorch.TabIndex = 18;
            this.btnGetPorch.Text = "   Сохранить данные  подъездов";
            this.btnGetPorch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetPorch.UseVisualStyleBackColor = true;
            this.btnGetPorch.Click += new System.EventHandler(this.btnGetPorch_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage2.Controls.Add(this.btnNegilDelete);
            this.tabPage2.Controls.Add(this.btnNegilAdd);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.grdNegil);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1316, 616);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Нежилые помещения";
            // 
            // btnNegilDelete
            // 
            this.btnNegilDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNegilDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNegilDelete.Image = global::Gaudit.Properties.Resources.ChangeQueryType_deletequery_274_32;
            this.btnNegilDelete.Location = new System.Drawing.Point(1119, 89);
            this.btnNegilDelete.Name = "btnNegilDelete";
            this.btnNegilDelete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNegilDelete.Size = new System.Drawing.Size(170, 45);
            this.btnNegilDelete.TabIndex = 26;
            this.btnNegilDelete.Text = "Удалить нежилые помещения";
            this.btnNegilDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNegilDelete.UseVisualStyleBackColor = true;
            this.btnNegilDelete.Click += new System.EventHandler(this.btnNegilDelete_Click);
            // 
            // btnNegilAdd
            // 
            this.btnNegilAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNegilAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNegilAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNegilAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnNegilAdd.Image")));
            this.btnNegilAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNegilAdd.Location = new System.Drawing.Point(1119, 29);
            this.btnNegilAdd.Name = "btnNegilAdd";
            this.btnNegilAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNegilAdd.Size = new System.Drawing.Size(170, 45);
            this.btnNegilAdd.TabIndex = 25;
            this.btnNegilAdd.Text = "Сохранить данные нежилых помещений";
            this.btnNegilAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNegilAdd.UseVisualStyleBackColor = true;
            this.btnNegilAdd.Click += new System.EventHandler(this.btnNegilAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Нежилые помещения";
            // 
            // grdNegil
            // 
            this.grdNegil.AllowUserToAddRows = false;
            this.grdNegil.AllowUserToDeleteRows = false;
            this.grdNegil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdNegil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdNegil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdNegil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNegil.Location = new System.Drawing.Point(13, 29);
            this.grdNegil.Name = "grdNegil";
            this.grdNegil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdNegil.Size = new System.Drawing.Size(1080, 569);
            this.grdNegil.TabIndex = 21;
            // 
            // GilFondObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1344, 662);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "GilFondObjects";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объекты жилищного фонда";
            this.Load += new System.EventHandler(this.GilFondObjects_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGFObjects)).EndInit();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPomesch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPorch)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNegil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdGFObjects;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetPomesch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdPomesch;
        private System.Windows.Forms.DataGridView grdPorch;
        private System.Windows.Forms.Button btnDeletePorch;
        private System.Windows.Forms.Button btnGetPorch;
        private System.Windows.Forms.Label lblCurrObjID;
        private System.Windows.Forms.Label lblCurrPorch;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnNegilDelete;
        private System.Windows.Forms.Button btnNegilAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdNegil;
    }
}