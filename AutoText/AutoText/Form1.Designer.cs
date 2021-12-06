
namespace AutoText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.keyWordTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.replaceTb = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitBt = new System.Windows.Forms.Button();
            this.updateBt = new System.Windows.Forms.Button();
            this.deleteBt = new System.Windows.Forms.Button();
            this.addBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key Word";
            // 
            // keyWordTb
            // 
            this.keyWordTb.Location = new System.Drawing.Point(41, 39);
            this.keyWordTb.Multiline = true;
            this.keyWordTb.Name = "keyWordTb";
            this.keyWordTb.Size = new System.Drawing.Size(121, 37);
            this.keyWordTb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Replaced By";
            // 
            // replaceTb
            // 
            this.replaceTb.Location = new System.Drawing.Point(295, 39);
            this.replaceTb.Multiline = true;
            this.replaceTb.Name = "replaceTb";
            this.replaceTb.Size = new System.Drawing.Size(285, 37);
            this.replaceTb.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView.Location = new System.Drawing.Point(41, 82);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(539, 198);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Key Word";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mean";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // exitBt
            // 
            this.exitBt.Image = global::AutoText.Properties.Resources.Logout_icon;
            this.exitBt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitBt.Location = new System.Drawing.Point(490, 300);
            this.exitBt.Name = "exitBt";
            this.exitBt.Size = new System.Drawing.Size(90, 37);
            this.exitBt.TabIndex = 8;
            this.exitBt.Text = "Exit";
            this.exitBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitBt.UseVisualStyleBackColor = true;
            this.exitBt.Click += new System.EventHandler(this.exitBt_Click);
            // 
            // updateBt
            // 
            this.updateBt.Image = global::AutoText.Properties.Resources.edit_validated_icon;
            this.updateBt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateBt.Location = new System.Drawing.Point(191, 300);
            this.updateBt.Name = "updateBt";
            this.updateBt.Size = new System.Drawing.Size(90, 37);
            this.updateBt.TabIndex = 7;
            this.updateBt.Text = "Update";
            this.updateBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateBt.UseVisualStyleBackColor = true;
            this.updateBt.Click += new System.EventHandler(this.updateBt_Click);
            // 
            // deleteBt
            // 
            this.deleteBt.Image = global::AutoText.Properties.Resources.Actions_edit_delete_icon;
            this.deleteBt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBt.Location = new System.Drawing.Point(341, 300);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(90, 37);
            this.deleteBt.TabIndex = 6;
            this.deleteBt.Text = "Delete";
            this.deleteBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBt.UseVisualStyleBackColor = true;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // addBt
            // 
            this.addBt.Image = global::AutoText.Properties.Resources.add_icon1;
            this.addBt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBt.Location = new System.Drawing.Point(41, 300);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(90, 37);
            this.addBt.TabIndex = 5;
            this.addBt.Text = "Add";
            this.addBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 353);
            this.Controls.Add(this.exitBt);
            this.Controls.Add(this.updateBt);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.replaceTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyWordTb);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 400);
            this.MinimumSize = new System.Drawing.Size(640, 400);
            this.Name = "Form1";
            this.Text = "AutoText";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyWordTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox replaceTb;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.Button updateBt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button exitBt;
    }
}

