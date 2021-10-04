namespace CalcPi
{
    partial class FormMain
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelCountSquare = new System.Windows.Forms.Label();
            this.labelCountCircle = new System.Windows.Forms.Label();
            this.labelPi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(241, 496);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Поехали!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelCountSquare
            // 
            this.labelCountSquare.AutoSize = true;
            this.labelCountSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountSquare.Location = new System.Drawing.Point(23, 24);
            this.labelCountSquare.Name = "labelCountSquare";
            this.labelCountSquare.Size = new System.Drawing.Size(29, 31);
            this.labelCountSquare.TabIndex = 1;
            this.labelCountSquare.Text = "0";
            // 
            // labelCountCircle
            // 
            this.labelCountCircle.AutoSize = true;
            this.labelCountCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountCircle.Location = new System.Drawing.Point(534, 24);
            this.labelCountCircle.Name = "labelCountCircle";
            this.labelCountCircle.Size = new System.Drawing.Size(29, 31);
            this.labelCountCircle.TabIndex = 2;
            this.labelCountCircle.Text = "0";
            // 
            // labelPi
            // 
            this.labelPi.AutoSize = true;
            this.labelPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPi.Location = new System.Drawing.Point(266, 24);
            this.labelPi.Name = "labelPi";
            this.labelPi.Size = new System.Drawing.Size(29, 31);
            this.labelPi.TabIndex = 3;
            this.labelPi.Text = "0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.labelPi);
            this.Controls.Add(this.labelCountCircle);
            this.Controls.Add(this.labelCountSquare);
            this.Controls.Add(this.buttonStart);
            this.Name = "FormMain";
            this.Text = "Вычисление числа Pi";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelCountSquare;
        private System.Windows.Forms.Label labelCountCircle;
        private System.Windows.Forms.Label labelPi;
    }
}

