namespace WinDbTestApp
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnMySQL = new System.Windows.Forms.Button();
            this.BtnMsSql = new System.Windows.Forms.Button();
            this.BtnSqLite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMySQL
            // 
            this.BtnMySQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMySQL.Location = new System.Drawing.Point(13, 13);
            this.BtnMySQL.Name = "BtnMySQL";
            this.BtnMySQL.Size = new System.Drawing.Size(163, 46);
            this.BtnMySQL.TabIndex = 0;
            this.BtnMySQL.Text = "MySQL";
            this.BtnMySQL.UseVisualStyleBackColor = true;
            this.BtnMySQL.Click += new System.EventHandler(this.BtnMySQL_Click);
            // 
            // BtnMsSql
            // 
            this.BtnMsSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMsSql.Location = new System.Drawing.Point(13, 83);
            this.BtnMsSql.Name = "BtnMsSql";
            this.BtnMsSql.Size = new System.Drawing.Size(163, 46);
            this.BtnMsSql.TabIndex = 1;
            this.BtnMsSql.Text = "MS SQL";
            this.BtnMsSql.UseVisualStyleBackColor = true;
            this.BtnMsSql.Click += new System.EventHandler(this.BtnMsSql_Click);
            // 
            // BtnSqLite
            // 
            this.BtnSqLite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSqLite.Location = new System.Drawing.Point(12, 147);
            this.BtnSqLite.Name = "BtnSqLite";
            this.BtnSqLite.Size = new System.Drawing.Size(163, 46);
            this.BtnSqLite.TabIndex = 2;
            this.BtnSqLite.Text = "SQLite";
            this.BtnSqLite.UseVisualStyleBackColor = true;
            this.BtnSqLite.Click += new System.EventHandler(this.BtnSqLite_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 205);
            this.Controls.Add(this.BtnSqLite);
            this.Controls.Add(this.BtnMsSql);
            this.Controls.Add(this.BtnMySQL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinDbTestApp";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMySQL;
        private System.Windows.Forms.Button BtnMsSql;
        private System.Windows.Forms.Button BtnSqLite;
    }
}

