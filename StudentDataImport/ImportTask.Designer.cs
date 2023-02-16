namespace StudentDataImport
{
    partial class ImportTask
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
            this.Browse = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.StudentItem = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentItem)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(633, 43);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(90, 35);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(664, 303);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(102, 56);
            this.SAVE.TabIndex = 1;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // StudentItem
            // 
            this.StudentItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentItem.Location = new System.Drawing.Point(66, 105);
            this.StudentItem.Name = "StudentItem";
            this.StudentItem.RowHeadersWidth = 62;
            this.StudentItem.RowTemplate.Height = 28;
            this.StudentItem.Size = new System.Drawing.Size(541, 280);
            this.StudentItem.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(541, 26);
            this.textBox1.TabIndex = 3;
            // 
            // ImportTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StudentItem);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.Browse);
            this.Name = "ImportTask";
            this.Text = "ImportTask";
            ((System.ComponentModel.ISupportInitialize)(this.StudentItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.DataGridView StudentItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}

