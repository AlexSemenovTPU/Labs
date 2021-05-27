
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTransport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridTransport
            // 
            this.DataGridTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTransport.Location = new System.Drawing.Point(6, 21);
            this.DataGridTransport.Name = "DataGridTransport";
            this.DataGridTransport.RowHeadersWidth = 51;
            this.DataGridTransport.RowTemplate.Height = 24;
            this.DataGridTransport.Size = new System.Drawing.Size(356, 154);
            this.DataGridTransport.TabIndex = 0;
            // 
            // AddTransport
            // 
            this.AddTransport.Location = new System.Drawing.Point(18, 202);
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
            this.RemoveTransport.Location = new System.Drawing.Point(206, 202);
            this.RemoveTransport.Name = "RemoveTransport";
            this.RemoveTransport.Size = new System.Drawing.Size(168, 25);
            this.RemoveTransport.TabIndex = 4;
            this.RemoveTransport.Text = "Удалить";
            this.RemoveTransport.UseVisualStyleBackColor = true;
            this.RemoveTransport.Click += new System.EventHandler(this.RemoveTransport_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 25);
            this.button3.TabIndex = 5;
            this.button3.Text = "Случайные данные";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(206, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 25);
            this.button4.TabIndex = 6;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 270);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RemoveTransport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddTransport);
            this.Name = "MainForm";
            this.Text = "Вычислятор";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTransport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridTransport;
        private System.Windows.Forms.Button AddTransport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoveTransport;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

