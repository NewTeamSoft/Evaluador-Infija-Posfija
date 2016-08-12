namespace WindowsFormsApplication1
{
    partial class FormEvaluadorExpresiones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInfija = new System.Windows.Forms.TextBox();
            this.textBoxPostfija = new System.Windows.Forms.TextBox();
            this.buttonEvaluarExpresiones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxInfija
            // 
            this.textBoxInfija.Location = new System.Drawing.Point(15, 25);
            this.textBoxInfija.Multiline = true;
            this.textBoxInfija.Name = "textBoxInfija";
            this.textBoxInfija.Size = new System.Drawing.Size(161, 27);
            this.textBoxInfija.TabIndex = 0;
            // 
            // textBoxPostfija
            // 
            this.textBoxPostfija.Location = new System.Drawing.Point(15, 71);
            this.textBoxPostfija.Multiline = true;
            this.textBoxPostfija.Name = "textBoxPostfija";
            this.textBoxPostfija.ReadOnly = true;
            this.textBoxPostfija.Size = new System.Drawing.Size(165, 27);
            this.textBoxPostfija.TabIndex = 1;
            // 
            // buttonEvaluarExpresiones
            // 
            this.buttonEvaluarExpresiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.buttonEvaluarExpresiones.Location = new System.Drawing.Point(101, 315);
            this.buttonEvaluarExpresiones.Name = "buttonEvaluarExpresiones";
            this.buttonEvaluarExpresiones.Size = new System.Drawing.Size(81, 32);
            this.buttonEvaluarExpresiones.TabIndex = 3;
            this.buttonEvaluarExpresiones.Text = "=";
            this.buttonEvaluarExpresiones.UseVisualStyleBackColor = true;
            this.buttonEvaluarExpresiones.Click += new System.EventHandler(this.buttonEvaluarExpresiones_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Expresion infija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Expresion postfijo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(100, 197);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 34);
            this.button5.TabIndex = 10;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(56, 197);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(38, 34);
            this.button6.TabIndex = 11;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(57, 237);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(38, 34);
            this.button7.TabIndex = 14;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(101, 237);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(38, 34);
            this.button8.TabIndex = 13;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(13, 237);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(38, 34);
            this.button9.TabIndex = 12;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(57, 277);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(38, 34);
            this.button10.TabIndex = 17;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(101, 277);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(38, 34);
            this.button11.TabIndex = 16;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(13, 277);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(38, 34);
            this.button12.TabIndex = 15;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 30);
            this.button3.TabIndex = 18;
            this.button3.Text = "0";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.button4.Location = new System.Drawing.Point(101, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 34);
            this.button4.TabIndex = 21;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.button13.Location = new System.Drawing.Point(144, 199);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(38, 34);
            this.button13.TabIndex = 20;
            this.button13.Text = "+";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.button14.Location = new System.Drawing.Point(14, 157);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(38, 34);
            this.button14.TabIndex = 19;
            this.button14.Text = "^";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.button15.Location = new System.Drawing.Point(57, 157);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(38, 34);
            this.button15.TabIndex = 24;
            this.button15.Text = "/";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.button17.Location = new System.Drawing.Point(145, 157);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(38, 34);
            this.button17.TabIndex = 22;
            this.button17.Text = "-";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button16.Location = new System.Drawing.Point(144, 277);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(38, 34);
            this.button16.TabIndex = 25;
            this.button16.Text = ")";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button18.Location = new System.Drawing.Point(144, 239);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(38, 34);
            this.button18.TabIndex = 26;
            this.button18.Text = "(";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(15, 123);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ReadOnly = true;
            this.textBoxResultado.Size = new System.Drawing.Size(165, 27);
            this.textBoxResultado.TabIndex = 27;
            // 
            // FormEvaluadorExpresiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 360);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEvaluarExpresiones);
            this.Controls.Add(this.textBoxPostfija);
            this.Controls.Add(this.textBoxInfija);
            this.Name = "FormEvaluadorExpresiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfija;
        private System.Windows.Forms.TextBox textBoxPostfija;
        private System.Windows.Forms.Button buttonEvaluarExpresiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TextBox textBoxResultado;
    }
}

