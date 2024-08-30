
namespace laba_nomer4_part2
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
            this.tBoxA = new System.Windows.Forms.TextBox();
            this.numUpA = new System.Windows.Forms.NumericUpDown();
            this.tBarA = new System.Windows.Forms.TrackBar();
            this.tBarB = new System.Windows.Forms.TrackBar();
            this.numUpB = new System.Windows.Forms.NumericUpDown();
            this.tBoxB = new System.Windows.Forms.TextBox();
            this.tBarC = new System.Windows.Forms.TrackBar();
            this.numUpC = new System.Windows.Forms.NumericUpDown();
            this.tBoxC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpC)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxA
            // 
            this.tBoxA.Location = new System.Drawing.Point(27, 76);
            this.tBoxA.Name = "tBoxA";
            this.tBoxA.Size = new System.Drawing.Size(120, 22);
            this.tBoxA.TabIndex = 0;
            this.tBoxA.Text = "0";
            this.tBoxA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxA_KeyDown);
            this.tBoxA.Leave += new System.EventHandler(this.tBoxA_Leave);
            // 
            // numUpA
            // 
            this.numUpA.Location = new System.Drawing.Point(27, 119);
            this.numUpA.Name = "numUpA";
            this.numUpA.Size = new System.Drawing.Size(120, 22);
            this.numUpA.TabIndex = 1;
            this.numUpA.ValueChanged += new System.EventHandler(this.numUpA_ValueChanged);
            this.numUpA.Leave += new System.EventHandler(this.numUpA_Leave);
            // 
            // tBarA
            // 
            this.tBarA.Location = new System.Drawing.Point(27, 167);
            this.tBarA.Maximum = 100;
            this.tBarA.Name = "tBarA";
            this.tBarA.Size = new System.Drawing.Size(120, 56);
            this.tBarA.TabIndex = 2;
            this.tBarA.ValueChanged += new System.EventHandler(this.tBarA_ValueChanged);
            // 
            // tBarB
            // 
            this.tBarB.Location = new System.Drawing.Point(248, 167);
            this.tBarB.Maximum = 100;
            this.tBarB.Name = "tBarB";
            this.tBarB.Size = new System.Drawing.Size(120, 56);
            this.tBarB.TabIndex = 5;
            this.tBarB.ValueChanged += new System.EventHandler(this.tBarB_ValueChanged);
            // 
            // numUpB
            // 
            this.numUpB.Location = new System.Drawing.Point(248, 119);
            this.numUpB.Name = "numUpB";
            this.numUpB.Size = new System.Drawing.Size(120, 22);
            this.numUpB.TabIndex = 4;
            this.numUpB.ValueChanged += new System.EventHandler(this.numUpB_ValueChanged);
            this.numUpB.Leave += new System.EventHandler(this.numUpB_Leave);
            // 
            // tBoxB
            // 
            this.tBoxB.Location = new System.Drawing.Point(248, 76);
            this.tBoxB.Name = "tBoxB";
            this.tBoxB.Size = new System.Drawing.Size(120, 22);
            this.tBoxB.TabIndex = 3;
            this.tBoxB.Text = "0";
            this.tBoxB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxB_KeyDown);
            this.tBoxB.Leave += new System.EventHandler(this.tBoxB_Leave);
            // 
            // tBarC
            // 
            this.tBarC.Location = new System.Drawing.Point(457, 167);
            this.tBarC.Maximum = 100;
            this.tBarC.Name = "tBarC";
            this.tBarC.Size = new System.Drawing.Size(120, 56);
            this.tBarC.TabIndex = 8;
            this.tBarC.ValueChanged += new System.EventHandler(this.tBarC_ValueChanged);
            // 
            // numUpC
            // 
            this.numUpC.Location = new System.Drawing.Point(457, 119);
            this.numUpC.Name = "numUpC";
            this.numUpC.Size = new System.Drawing.Size(120, 22);
            this.numUpC.TabIndex = 7;
            this.numUpC.ValueChanged += new System.EventHandler(this.numUpC_ValueChanged);
            this.numUpC.Leave += new System.EventHandler(this.numUpC_Leave);
            // 
            // tBoxC
            // 
            this.tBoxC.Location = new System.Drawing.Point(457, 76);
            this.tBoxC.Name = "tBoxC";
            this.tBoxC.Size = new System.Drawing.Size(120, 22);
            this.tBoxC.TabIndex = 6;
            this.tBoxC.Text = "0";
            this.tBoxC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxC_KeyDown);
            this.tBoxC.Leave += new System.EventHandler(this.tBoxC_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 67);
            this.label1.TabIndex = 9;
            this.label1.Text = "A    <=  B  <=    C";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBarC);
            this.Controls.Add(this.numUpC);
            this.Controls.Add(this.tBoxC);
            this.Controls.Add(this.tBarB);
            this.Controls.Add(this.numUpB);
            this.Controls.Add(this.tBoxB);
            this.Controls.Add(this.tBarA);
            this.Controls.Add(this.numUpA);
            this.Controls.Add(this.tBoxA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUpA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxA;
        private System.Windows.Forms.NumericUpDown numUpA;
        private System.Windows.Forms.TrackBar tBarA;
        private System.Windows.Forms.TrackBar tBarB;
        private System.Windows.Forms.NumericUpDown numUpB;
        private System.Windows.Forms.TextBox tBoxB;
        private System.Windows.Forms.TrackBar tBarC;
        private System.Windows.Forms.NumericUpDown numUpC;
        private System.Windows.Forms.TextBox tBoxC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

