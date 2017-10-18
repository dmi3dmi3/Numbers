namespace Chisla2
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
            this.MainBtn = new System.Windows.Forms.Button();
            this.OutputLbl = new System.Windows.Forms.Label();
            this.InputTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainBtn
            // 
            this.MainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainBtn.Location = new System.Drawing.Point(358, 102);
            this.MainBtn.Name = "MainBtn";
            this.MainBtn.Size = new System.Drawing.Size(130, 40);
            this.MainBtn.TabIndex = 0;
            this.MainBtn.Text = "Перевести";
            this.MainBtn.UseVisualStyleBackColor = true;
            this.MainBtn.Click += new System.EventHandler(this.MainBtn_Click);
            // 
            // OutputLbl
            // 
            this.OutputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputLbl.Location = new System.Drawing.Point(12, 73);
            this.OutputLbl.MaximumSize = new System.Drawing.Size(340, 100);
            this.OutputLbl.Name = "OutputLbl";
            this.OutputLbl.Size = new System.Drawing.Size(340, 100);
            this.OutputLbl.TabIndex = 1;
            // 
            // InputTB
            // 
            this.InputTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTB.Location = new System.Drawing.Point(12, 12);
            this.InputTB.Name = "InputTB";
            this.InputTB.Size = new System.Drawing.Size(478, 40);
            this.InputTB.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 182);
            this.Controls.Add(this.InputTB);
            this.Controls.Add(this.OutputLbl);
            this.Controls.Add(this.MainBtn);
            this.Name = "MainForm";
            this.Text = "Числа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainBtn;
        private System.Windows.Forms.Label OutputLbl;
        private System.Windows.Forms.TextBox InputTB;
    }
}

