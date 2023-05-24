
namespace Вариант_4
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
        protected override void Dispose (bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent ()
        {
            this.answer = new System.Windows.Forms.Label();
            this.Options = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Symbol = new System.Windows.Forms.TextBox();
            this.Line = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.AddNewLine = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            this.SuspendLayout();
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.Location = new System.Drawing.Point(208, 7);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(0, 17);
            this.answer.TabIndex = 0;
            // 
            // Options
            // 
            this.Options.FormattingEnabled = true;
            this.Options.Items.AddRange(new object[] {
            "Массив символов",
            "Массив чисел",
            "Массив строк"});
            this.Options.Location = new System.Drawing.Point(12, 31);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(121, 21);
            this.Options.TabIndex = 2;
            this.Options.SelectedIndexChanged += new System.EventHandler(this.Options_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Группировать по";
            // 
            // Symbol
            // 
            this.Symbol.Location = new System.Drawing.Point(12, 172);
            this.Symbol.Name = "Symbol";
            this.Symbol.Size = new System.Drawing.Size(120, 20);
            this.Symbol.TabIndex = 5;
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(12, 211);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(120, 20);
            this.Line.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Символ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Строка";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(12, 133);
            this.number.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(120, 20);
            this.number.TabIndex = 10;
            // 
            // AddNewLine
            // 
            this.AddNewLine.Location = new System.Drawing.Point(12, 237);
            this.AddNewLine.Name = "AddNewLine";
            this.AddNewLine.Size = new System.Drawing.Size(120, 23);
            this.AddNewLine.TabIndex = 11;
            this.AddNewLine.Text = "Добавить";
            this.AddNewLine.UseVisualStyleBackColor = true;
            this.AddNewLine.Click += new System.EventHandler(this.AddNewLine_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Добавление элемента";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddNewLine);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Symbol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.answer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.ComboBox Options;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Symbol;
        private System.Windows.Forms.TextBox Line;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.Button AddNewLine;
        private System.Windows.Forms.Label label5;
    }
}

