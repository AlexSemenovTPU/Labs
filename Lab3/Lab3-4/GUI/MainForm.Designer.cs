
namespace GUI
{
    partial class MainForm
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
            this.DataGridTransport = new System.Windows.Forms.DataGridView();
            this.AddTransport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoveTransport = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTransport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridTransport
            // 
            this.DataGridTransport.AllowUserToAddRows = false;
            this.DataGridTransport.AllowUserToDeleteRows = false;
            this.DataGridTransport.AllowUserToResizeColumns = false;
            this.DataGridTransport.AllowUserToResizeRows = false;
            this.DataGridTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTransport.Location = new System.Drawing.Point(6, 21);
            this.DataGridTransport.Name = "DataGridTransport";
            this.DataGridTransport.ReadOnly = true;
            this.DataGridTransport.RowHeadersVisible = false;
            this.DataGridTransport.RowHeadersWidth = 51;
            this.DataGridTransport.RowTemplate.Height = 24;
            this.DataGridTransport.Size = new System.Drawing.Size(356, 154);
            this.DataGridTransport.TabIndex = 0;
            // 
            // AddTransport
            // 
            this.AddTransport.Location = new System.Drawing.Point(386, 33);
            this.AddTransport.Name = "AddTransport";
            this.AddTransport.Size = new System.Drawing.Size(168, 25);
            this.AddTransport.TabIndex = 1;
            this.AddTransport.Text = "Добавить";
            this.AddTransport.UseVisualStyleBackColor = true;
            this.AddTransport.Click += new System.EventHandler(this.AddTransport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGridTransport);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о затраченном транспортом топливе";
            // 
            // RemoveTransport
            // 
            this.RemoveTransport.Location = new System.Drawing.Point(386, 67);
            this.RemoveTransport.Name = "RemoveTransport";
            this.RemoveTransport.Size = new System.Drawing.Size(168, 25);
            this.RemoveTransport.TabIndex = 4;
            this.RemoveTransport.Text = "Удалить";
            this.RemoveTransport.UseVisualStyleBackColor = true;
            this.RemoveTransport.Click += new System.EventHandler(this.RemoveTransport_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(386, 101);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(168, 25);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(386, 133);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(168, 25);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 200);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.RemoveTransport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddTransport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Вычисление затраченного транспортом топлива";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTransport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridTransport;
        private System.Windows.Forms.Button AddTransport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoveTransport;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

