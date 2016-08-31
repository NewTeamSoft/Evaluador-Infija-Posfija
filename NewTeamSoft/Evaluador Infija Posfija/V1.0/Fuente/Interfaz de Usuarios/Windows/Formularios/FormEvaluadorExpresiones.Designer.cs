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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonMultiplicacion = new System.Windows.Forms.Button();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.buttonExponentes = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonResta = new System.Windows.Forms.Button();
            this.buttonParentesisCerrado = new System.Windows.Forms.Button();
            this.buttonParentesisAbierto = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonCln = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonOFF = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInfija
            // 
            this.textBoxInfija.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxInfija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxInfija.Location = new System.Drawing.Point(12, 52);
            this.textBoxInfija.Multiline = true;
            this.textBoxInfija.Name = "textBoxInfija";
            this.textBoxInfija.ReadOnly = true;
            this.textBoxInfija.Size = new System.Drawing.Size(259, 27);
            this.textBoxInfija.TabIndex = 0;
            this.textBoxInfija.Text = "0";
            this.textBoxInfija.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInfija_KeyPress);
            // 
            // textBoxPostfija
            // 
            this.textBoxPostfija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxPostfija.Location = new System.Drawing.Point(13, 105);
            this.textBoxPostfija.Multiline = true;
            this.textBoxPostfija.Name = "textBoxPostfija";
            this.textBoxPostfija.ReadOnly = true;
            this.textBoxPostfija.Size = new System.Drawing.Size(258, 27);
            this.textBoxPostfija.TabIndex = 1;
            // 
            // buttonEvaluarExpresiones
            // 
            this.buttonEvaluarExpresiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.buttonEvaluarExpresiones.Location = new System.Drawing.Point(232, 239);
            this.buttonEvaluarExpresiones.Name = "buttonEvaluarExpresiones";
            this.buttonEvaluarExpresiones.Size = new System.Drawing.Size(38, 110);
            this.buttonEvaluarExpresiones.TabIndex = 3;
            this.buttonEvaluarExpresiones.Text = "=";
            this.buttonEvaluarExpresiones.UseVisualStyleBackColor = true;
            this.buttonEvaluarExpresiones.Click += new System.EventHandler(this.buttonEvaluarExpresiones_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Expresion Infija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Expresion postfijo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(56, 237);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 34);
            this.button5.TabIndex = 14;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(100, 237);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(38, 34);
            this.button6.TabIndex = 13;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 34);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(56, 194);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(38, 34);
            this.button8.TabIndex = 17;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(100, 194);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(38, 34);
            this.button9.TabIndex = 16;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 194);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(38, 34);
            this.button7.TabIndex = 15;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(11, 316);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(80, 33);
            this.button0.TabIndex = 18;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonMultiplicacion
            // 
            this.buttonMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.buttonMultiplicacion.Location = new System.Drawing.Point(189, 317);
            this.buttonMultiplicacion.Name = "buttonMultiplicacion";
            this.buttonMultiplicacion.Size = new System.Drawing.Size(38, 32);
            this.buttonMultiplicacion.TabIndex = 21;
            this.buttonMultiplicacion.Text = "*";
            this.buttonMultiplicacion.UseVisualStyleBackColor = true;
            this.buttonMultiplicacion.Click += new System.EventHandler(this.buttonMultiplicacion_Click);
            // 
            // buttonSuma
            // 
            this.buttonSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.buttonSuma.Location = new System.Drawing.Point(100, 317);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(38, 32);
            this.buttonSuma.TabIndex = 20;
            this.buttonSuma.Text = "+";
            this.buttonSuma.UseVisualStyleBackColor = true;
            this.buttonSuma.Click += new System.EventHandler(this.buttonSuma_Click);
            // 
            // buttonExponentes
            // 
            this.buttonExponentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.buttonExponentes.Location = new System.Drawing.Point(188, 277);
            this.buttonExponentes.Name = "buttonExponentes";
            this.buttonExponentes.Size = new System.Drawing.Size(38, 34);
            this.buttonExponentes.TabIndex = 19;
            this.buttonExponentes.Text = "^";
            this.buttonExponentes.UseVisualStyleBackColor = true;
            this.buttonExponentes.Click += new System.EventHandler(this.buttonExponentes_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.buttonDivision.Location = new System.Drawing.Point(144, 277);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(38, 34);
            this.buttonDivision.TabIndex = 24;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // buttonResta
            // 
            this.buttonResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.buttonResta.Location = new System.Drawing.Point(144, 317);
            this.buttonResta.Name = "buttonResta";
            this.buttonResta.Size = new System.Drawing.Size(38, 32);
            this.buttonResta.TabIndex = 22;
            this.buttonResta.Text = "-";
            this.buttonResta.UseVisualStyleBackColor = true;
            this.buttonResta.Click += new System.EventHandler(this.buttonResta_Click);
            // 
            // buttonParentesisCerrado
            // 
            this.buttonParentesisCerrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonParentesisCerrado.Location = new System.Drawing.Point(188, 237);
            this.buttonParentesisCerrado.Name = "buttonParentesisCerrado";
            this.buttonParentesisCerrado.Size = new System.Drawing.Size(38, 34);
            this.buttonParentesisCerrado.TabIndex = 25;
            this.buttonParentesisCerrado.Text = ")";
            this.buttonParentesisCerrado.UseVisualStyleBackColor = true;
            this.buttonParentesisCerrado.Click += new System.EventHandler(this.buttonParentesisCerrado_Click);
            // 
            // buttonParentesisAbierto
            // 
            this.buttonParentesisAbierto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonParentesisAbierto.Location = new System.Drawing.Point(144, 237);
            this.buttonParentesisAbierto.Name = "buttonParentesisAbierto";
            this.buttonParentesisAbierto.Size = new System.Drawing.Size(38, 34);
            this.buttonParentesisAbierto.TabIndex = 26;
            this.buttonParentesisAbierto.Text = "(";
            this.buttonParentesisAbierto.UseVisualStyleBackColor = true;
            this.buttonParentesisAbierto.Click += new System.EventHandler(this.buttonParentesisAbierto_Click);
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxResultado.Location = new System.Drawing.Point(12, 160);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ReadOnly = true;
            this.textBoxResultado.Size = new System.Drawing.Size(259, 27);
            this.textBoxResultado.TabIndex = 27;
            // 
            // buttonCln
            // 
            this.buttonCln.BackColor = System.Drawing.Color.Red;
            this.buttonCln.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonCln.Location = new System.Drawing.Point(144, 194);
            this.buttonCln.Name = "buttonCln";
            this.buttonCln.Size = new System.Drawing.Size(38, 34);
            this.buttonCln.TabIndex = 29;
            this.buttonCln.Text = "CLN";
            this.buttonCln.UseVisualStyleBackColor = false;
            this.buttonCln.Click += new System.EventHandler(this.buttonCln_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Red;
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonDel.Location = new System.Drawing.Point(189, 194);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(38, 34);
            this.buttonDel.TabIndex = 28;
            this.buttonDel.Text = "DEL";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonOFF
            // 
            this.buttonOFF.BackColor = System.Drawing.Color.Red;
            this.buttonOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonOFF.Location = new System.Drawing.Point(233, 194);
            this.buttonOFF.Name = "buttonOFF";
            this.buttonOFF.Size = new System.Drawing.Size(38, 34);
            this.buttonOFF.TabIndex = 30;
            this.buttonOFF.Text = "OFF";
            this.buttonOFF.UseVisualStyleBackColor = false;
            this.buttonOFF.Click += new System.EventHandler(this.buttonOFF_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Edicion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(65, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Configuracion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.Location = new System.Drawing.Point(161, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Ayuda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label7.Location = new System.Drawing.Point(214, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Acerca";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.14953F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.85046F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(285, 21);
            this.tableLayoutPanel2.TabIndex = 33;
            // 
            // FormEvaluadorExpresiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(285, 364);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.buttonOFF);
            this.Controls.Add(this.buttonCln);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.buttonParentesisAbierto);
            this.Controls.Add(this.buttonParentesisCerrado);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonResta);
            this.Controls.Add(this.buttonMultiplicacion);
            this.Controls.Add(this.buttonSuma);
            this.Controls.Add(this.buttonExponentes);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEvaluarExpresiones);
            this.Controls.Add(this.textBoxPostfija);
            this.Controls.Add(this.textBoxInfija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEvaluadorExpresiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonMultiplicacion;
        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.Button buttonExponentes;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonResta;
        private System.Windows.Forms.Button buttonParentesisCerrado;
        private System.Windows.Forms.Button buttonParentesisAbierto;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonCln;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonOFF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

