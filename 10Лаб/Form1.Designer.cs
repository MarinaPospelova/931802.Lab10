
namespace _10Лаб
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
            this.Rule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.your_score = new System.Windows.Forms.NumericUpDown();
            this.comp_score = new System.Windows.Forms.NumericUpDown();
            this.throw_cube = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.your_brick1 = new System.Windows.Forms.NumericUpDown();
            this.your_brick2 = new System.Windows.Forms.NumericUpDown();
            this.comp_brick2 = new System.Windows.Forms.NumericUpDown();
            this.comp_brick1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.your_score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.your_brick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.your_brick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_brick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_brick1)).BeginInit();
            this.SuspendLayout();
            // 
            // Rule
            // 
            this.Rule.BackColor = System.Drawing.Color.LavenderBlush;
            this.Rule.ForeColor = System.Drawing.Color.Maroon;
            this.Rule.Location = new System.Drawing.Point(12, 12);
            this.Rule.Name = "Rule";
            this.Rule.Size = new System.Drawing.Size(116, 46);
            this.Rule.TabIndex = 0;
            this.Rule.Text = "Правила";
            this.Rule.UseVisualStyleBackColor = false;
            this.Rule.Click += new System.EventHandler(this.Rule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(374, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Игра в кости";
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.Color.LavenderBlush;
            this.Generate.Location = new System.Drawing.Point(641, 84);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(152, 57);
            this.Generate.TabIndex = 2;
            this.Generate.Text = "Разыграть число";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(440, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Счет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Компьютер";
            // 
            // your_score
            // 
            this.your_score.BackColor = System.Drawing.Color.LavenderBlush;
            this.your_score.Enabled = false;
            this.your_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.your_score.ForeColor = System.Drawing.Color.Maroon;
            this.your_score.Location = new System.Drawing.Point(325, 196);
            this.your_score.Name = "your_score";
            this.your_score.Size = new System.Drawing.Size(120, 26);
            this.your_score.TabIndex = 9;
            // 
            // comp_score
            // 
            this.comp_score.BackColor = System.Drawing.Color.LavenderBlush;
            this.comp_score.Enabled = false;
            this.comp_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comp_score.ForeColor = System.Drawing.Color.Maroon;
            this.comp_score.Location = new System.Drawing.Point(494, 196);
            this.comp_score.Name = "comp_score";
            this.comp_score.Size = new System.Drawing.Size(120, 26);
            this.comp_score.TabIndex = 10;
            // 
            // throw_cube
            // 
            this.throw_cube.BackColor = System.Drawing.Color.LavenderBlush;
            this.throw_cube.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.throw_cube.Location = new System.Drawing.Point(401, 497);
            this.throw_cube.Name = "throw_cube";
            this.throw_cube.Size = new System.Drawing.Size(155, 75);
            this.throw_cube.TabIndex = 11;
            this.throw_cube.Text = "Кинуть кубики";
            this.throw_cube.UseVisualStyleBackColor = false;
            this.throw_cube.Click += new System.EventHandler(this.throw_cube_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.LavenderBlush;
            this.close.Location = new System.Drawing.Point(828, 557);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(133, 49);
            this.close.TabIndex = 14;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // num
            // 
            this.num.Enabled = false;
            this.num.ForeColor = System.Drawing.Color.Maroon;
            this.num.Location = new System.Drawing.Point(799, 100);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(120, 26);
            this.num.TabIndex = 16;
            // 
            // your_brick1
            // 
            this.your_brick1.BackColor = System.Drawing.Color.LavenderBlush;
            this.your_brick1.Enabled = false;
            this.your_brick1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.your_brick1.ForeColor = System.Drawing.Color.Maroon;
            this.your_brick1.Location = new System.Drawing.Point(245, 325);
            this.your_brick1.Name = "your_brick1";
            this.your_brick1.Size = new System.Drawing.Size(120, 26);
            this.your_brick1.TabIndex = 17;
            // 
            // your_brick2
            // 
            this.your_brick2.BackColor = System.Drawing.Color.LavenderBlush;
            this.your_brick2.Enabled = false;
            this.your_brick2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.your_brick2.ForeColor = System.Drawing.Color.Maroon;
            this.your_brick2.Location = new System.Drawing.Point(245, 381);
            this.your_brick2.Name = "your_brick2";
            this.your_brick2.Size = new System.Drawing.Size(120, 26);
            this.your_brick2.TabIndex = 18;
            // 
            // comp_brick2
            // 
            this.comp_brick2.BackColor = System.Drawing.Color.LavenderBlush;
            this.comp_brick2.Enabled = false;
            this.comp_brick2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comp_brick2.ForeColor = System.Drawing.Color.Maroon;
            this.comp_brick2.Location = new System.Drawing.Point(641, 381);
            this.comp_brick2.Name = "comp_brick2";
            this.comp_brick2.Size = new System.Drawing.Size(120, 26);
            this.comp_brick2.TabIndex = 19;
            // 
            // comp_brick1
            // 
            this.comp_brick1.BackColor = System.Drawing.Color.LavenderBlush;
            this.comp_brick1.Enabled = false;
            this.comp_brick1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comp_brick1.ForeColor = System.Drawing.Color.Maroon;
            this.comp_brick1.Location = new System.Drawing.Point(641, 325);
            this.comp_brick1.Name = "comp_brick1";
            this.comp_brick1.Size = new System.Drawing.Size(120, 26);
            this.comp_brick1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(973, 618);
            this.Controls.Add(this.comp_brick1);
            this.Controls.Add(this.comp_brick2);
            this.Controls.Add(this.your_brick2);
            this.Controls.Add(this.your_brick1);
            this.Controls.Add(this.num);
            this.Controls.Add(this.close);
            this.Controls.Add(this.throw_cube);
            this.Controls.Add(this.comp_score);
            this.Controls.Add(this.your_score);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rule);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Form1";
            this.Text = "Игра в кости";
            ((System.ComponentModel.ISupportInitialize)(this.your_score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.your_brick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.your_brick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_brick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comp_brick1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown your_score;
        private System.Windows.Forms.NumericUpDown comp_score;
        private System.Windows.Forms.Button throw_cube;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.NumericUpDown your_brick1;
        private System.Windows.Forms.NumericUpDown your_brick2;
        private System.Windows.Forms.NumericUpDown comp_brick2;
        private System.Windows.Forms.NumericUpDown comp_brick1;
    }
}

