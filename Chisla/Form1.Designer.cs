namespace Chisla
{
    partial class Form1
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
            this.MainBtn = new System.Windows.Forms.Button();
            this.OutputLBL = new System.Windows.Forms.Label();
            this.InputTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainBtn
            // 
            this.MainBtn.Location = new System.Drawing.Point(244, 12);
            this.MainBtn.Name = "MainBtn";
            this.MainBtn.Size = new System.Drawing.Size(75, 23);
            this.MainBtn.TabIndex = 0;
            this.MainBtn.Text = "Перевести";
            this.MainBtn.UseVisualStyleBackColor = true;
            this.MainBtn.Click += new System.EventHandler(this.MainBtn_Click);
            // 
            // OutputLBL
            // 
            this.OutputLBL.AutoSize = true;
            this.OutputLBL.Location = new System.Drawing.Point(9, 56);
            this.OutputLBL.MaximumSize = new System.Drawing.Size(200, 100);
            this.OutputLBL.Name = "OutputLBL";
            this.OutputLBL.Size = new System.Drawing.Size(157, 26);
            this.OutputLBL.TabIndex = 1;
            this.OutputLBL.Text = "ß = b, ö = o, ü = u,                     Пробелы не учитываются";
            this.OutputLBL.TextChanged += new System.EventHandler(this.OutputLBL_TextChanged);
            // 
            // InputTB
            // 
            this.InputTB.Location = new System.Drawing.Point(12, 12);
            this.InputTB.Name = "InputTB";
            this.InputTB.Size = new System.Drawing.Size(198, 20);
            this.InputTB.TabIndex = 2;
            this.InputTB.TextChanged += new System.EventHandler(this.InputTB_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 126);
            this.Controls.Add(this.InputTB);
            this.Controls.Add(this.OutputLBL);
            this.Controls.Add(this.MainBtn);
            this.Name = "Form1";
            this.Text = "Переводчик";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainBtn;
        private System.Windows.Forms.Label OutputLBL;
        private System.Windows.Forms.TextBox InputTB;
    }
}

