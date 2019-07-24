namespace Gaudit
{
    partial class DogUpravl
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
            this.grdDogUpravl = new System.Windows.Forms.DataGridView();
            this.grdUslugi = new System.Windows.Forms.DataGridView();
            this.lblCurrDogovor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPerech = new System.Windows.Forms.Button();
            this.btnClipBoard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grdFiles = new System.Windows.Forms.DataGridView();
            this.btnFiles = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelObj = new System.Windows.Forms.Button();
            this.btnDelFiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDogUpravl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUslugi)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDogUpravl
            // 
            this.grdDogUpravl.AllowUserToAddRows = false;
            this.grdDogUpravl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDogUpravl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDogUpravl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDogUpravl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDogUpravl.Location = new System.Drawing.Point(11, 69);
            this.grdDogUpravl.MultiSelect = false;
            this.grdDogUpravl.Name = "grdDogUpravl";
            this.grdDogUpravl.ReadOnly = true;
            this.grdDogUpravl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDogUpravl.ShowCellErrors = false;
            this.grdDogUpravl.ShowEditingIcon = false;
            this.grdDogUpravl.ShowRowErrors = false;
            this.grdDogUpravl.Size = new System.Drawing.Size(1099, 144);
            this.grdDogUpravl.TabIndex = 0;
            this.grdDogUpravl.SelectionChanged += new System.EventHandler(this.grdDogUpravl_SelectionChanged);
            // 
            // grdUslugi
            // 
            this.grdUslugi.AllowUserToAddRows = false;
            this.grdUslugi.AllowUserToDeleteRows = false;
            this.grdUslugi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUslugi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdUslugi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdUslugi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUslugi.Location = new System.Drawing.Point(12, 241);
            this.grdUslugi.Name = "grdUslugi";
            this.grdUslugi.ReadOnly = true;
            this.grdUslugi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUslugi.Size = new System.Drawing.Size(551, 367);
            this.grdUslugi.TabIndex = 5;
            // 
            // lblCurrDogovor
            // 
            this.lblCurrDogovor.AutoSize = true;
            this.lblCurrDogovor.Location = new System.Drawing.Point(965, 375);
            this.lblCurrDogovor.Name = "lblCurrDogovor";
            this.lblCurrDogovor.Size = new System.Drawing.Size(35, 13);
            this.lblCurrDogovor.TabIndex = 6;
            this.lblCurrDogovor.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnDelFiles);
            this.panel1.Controls.Add(this.btnDelObj);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnFiles);
            this.panel1.Controls.Add(this.grdFiles);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCurrDogovor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPerech);
            this.panel1.Controls.Add(this.grdUslugi);
            this.panel1.Controls.Add(this.btnClipBoard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.grdDogUpravl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 611);
            this.panel1.TabIndex = 17;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = global::Gaudit.Properties.Resources.ChangeQueryType_deletequery_274_32;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(1116, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 48);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Удалить договоры управления";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Коммунальные и дополнительные услуги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Договоры управления";
            // 
            // btnPerech
            // 
            this.btnPerech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerech.Image = global::Gaudit.Properties.Resources.ResultstoGrid_9947_32;
            this.btnPerech.Location = new System.Drawing.Point(1116, 241);
            this.btnPerech.Name = "btnPerech";
            this.btnPerech.Size = new System.Drawing.Size(155, 48);
            this.btnPerech.TabIndex = 2;
            this.btnPerech.Text = "Сохранить комм. и доп. услуги";
            this.btnPerech.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerech.UseVisualStyleBackColor = true;
            this.btnPerech.Click += new System.EventHandler(this.btnPerech_Click);
            // 
            // btnClipBoard
            // 
            this.btnClipBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClipBoard.Image = global::Gaudit.Properties.Resources.ResultstoGrid_9947_32;
            this.btnClipBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClipBoard.Location = new System.Drawing.Point(1116, 69);
            this.btnClipBoard.Name = "btnClipBoard";
            this.btnClipBoard.Size = new System.Drawing.Size(155, 48);
            this.btnClipBoard.TabIndex = 1;
            this.btnClipBoard.Text = "Получить и сохранить договоры управления";
            this.btnClipBoard.UseVisualStyleBackColor = true;
            this.btnClipBoard.Click += new System.EventHandler(this.btnClipBoard_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 1, 1, 1);
            this.label2.Size = new System.Drawing.Size(1272, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Договоры управления: https://my.dom.gosuslugi.ru/organization-cabinet/#!/agreemen" +
    "ts";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grdFiles
            // 
            this.grdFiles.AllowUserToAddRows = false;
            this.grdFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFiles.Location = new System.Drawing.Point(579, 241);
            this.grdFiles.Name = "grdFiles";
            this.grdFiles.Size = new System.Drawing.Size(531, 367);
            this.grdFiles.TabIndex = 18;
            // 
            // btnFiles
            // 
            this.btnFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiles.Image = global::Gaudit.Properties.Resources.ResultstoGrid_9947_32;
            this.btnFiles.Location = new System.Drawing.Point(1116, 305);
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Size = new System.Drawing.Size(155, 48);
            this.btnFiles.TabIndex = 19;
            this.btnFiles.Text = "Сохранить  прикрепленные файлы";
            this.btnFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiles.UseVisualStyleBackColor = true;
            this.btnFiles.Click += new System.EventHandler(this.btnFiles_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Прикрепленные файлы";
            // 
            // btnDelObj
            // 
            this.btnDelObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelObj.Image = global::Gaudit.Properties.Resources.ChangeQueryType_deletequery_274_32;
            this.btnDelObj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelObj.Location = new System.Drawing.Point(1116, 449);
            this.btnDelObj.Name = "btnDelObj";
            this.btnDelObj.Size = new System.Drawing.Size(155, 48);
            this.btnDelObj.TabIndex = 21;
            this.btnDelObj.Text = "Удалить комм. и доп. услуги";
            this.btnDelObj.UseVisualStyleBackColor = true;
            this.btnDelObj.Click += new System.EventHandler(this.btnDelObj_Click);
            // 
            // btnDelFiles
            // 
            this.btnDelFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelFiles.Image = global::Gaudit.Properties.Resources.ChangeQueryType_deletequery_274_32;
            this.btnDelFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelFiles.Location = new System.Drawing.Point(1116, 521);
            this.btnDelFiles.Name = "btnDelFiles";
            this.btnDelFiles.Size = new System.Drawing.Size(155, 48);
            this.btnDelFiles.TabIndex = 22;
            this.btnDelFiles.Text = "Удалить прикрепленные файлы\r\n";
            this.btnDelFiles.UseVisualStyleBackColor = true;
            this.btnDelFiles.Click += new System.EventHandler(this.btnDelFiles_Click);
            // 
            // DogUpravl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1295, 650);
            this.Controls.Add(this.panel1);
            this.Name = "DogUpravl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договоры управления";
            this.Load += new System.EventHandler(this.DogUpravl_Load);
            this.Resize += new System.EventHandler(this.DogUpravl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grdDogUpravl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUslugi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDogUpravl;
        private System.Windows.Forms.Button btnClipBoard;
        private System.Windows.Forms.Button btnPerech;
        private System.Windows.Forms.DataGridView grdUslugi;
        private System.Windows.Forms.Label lblCurrDogovor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView grdFiles;
        private System.Windows.Forms.Button btnFiles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelFiles;
        private System.Windows.Forms.Button btnDelObj;
    }
}