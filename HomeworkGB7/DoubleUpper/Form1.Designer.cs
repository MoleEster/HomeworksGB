namespace DoubleUpper
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
            this.bAdd = new System.Windows.Forms.Button();
            this.bMultiply = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bPlay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lCounter = new System.Windows.Forms.Label();
            this.lGame = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(473, 104);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "+1";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bMultiply
            // 
            this.bMultiply.Location = new System.Drawing.Point(473, 155);
            this.bMultiply.Name = "bMultiply";
            this.bMultiply.Size = new System.Drawing.Size(75, 23);
            this.bMultiply.TabIndex = 1;
            this.bMultiply.Text = "x2";
            this.bMultiply.UseVisualStyleBackColor = true;
            this.bMultiply.Click += new System.EventHandler(this.bMultiply_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(473, 208);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 2;
            this.bReset.Text = "Сброс";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // bPlay
            // 
            this.bPlay.Location = new System.Drawing.Point(473, 276);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(95, 38);
            this.bPlay.TabIndex = 4;
            this.bPlay.Text = "Играть";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество итераций:";
            // 
            // lCounter
            // 
            this.lCounter.AutoSize = true;
            this.lCounter.Location = new System.Drawing.Point(177, 425);
            this.lCounter.Name = "lCounter";
            this.lCounter.Size = new System.Drawing.Size(13, 13);
            this.lCounter.TabIndex = 6;
            this.lCounter.Text = "0";
            // 
            // lGame
            // 
            this.lGame.AutoSize = true;
            this.lGame.Location = new System.Drawing.Point(328, 33);
            this.lGame.Name = "lGame";
            this.lGame.Size = new System.Drawing.Size(0, 13);
            this.lGame.TabIndex = 7;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(566, 208);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "Oтменить";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.lGame);
            this.Controls.Add(this.lCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bMultiply);
            this.Controls.Add(this.bAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bMultiply;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lCounter;
        private System.Windows.Forms.Label lGame;
        private System.Windows.Forms.Button bCancel;
    }
}

