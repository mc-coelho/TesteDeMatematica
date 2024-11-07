namespace TesteDeMatematica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timeLbl = new Label();
            label1 = new Label();
            plusLeftLbl = new Label();
            igualSomaLbl = new Label();
            plusRightLbl = new Label();
            plusLbl = new Label();
            soma = new NumericUpDown();
            diferenca = new NumericUpDown();
            minusLbl = new Label();
            minusRightLbl = new Label();
            igualDiferencaLbl = new Label();
            minusLeftLbl = new Label();
            produto = new NumericUpDown();
            timesLbl = new Label();
            timesRightLbl = new Label();
            igualProdutoLbl = new Label();
            timesLeftLbl = new Label();
            quociente = new NumericUpDown();
            dividedLbl = new Label();
            dividedRightLbl = new Label();
            igualQuocienteLbl = new Label();
            dividedLeftLbl = new Label();
            startBtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)soma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diferenca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quociente).BeginInit();
            SuspendLayout();
            // 
            // timeLbl
            // 
            timeLbl.BorderStyle = BorderStyle.FixedSingle;
            timeLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeLbl.Location = new Point(272, 9);
            timeLbl.Name = "timeLbl";
            timeLbl.Size = new Size(200, 30);
            timeLbl.TabIndex = 0;
            timeLbl.Click += timeLbl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 1;
            label1.Text = "Time left";
            // 
            // plusLeftLbl
            // 
            plusLeftLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plusLeftLbl.Location = new Point(50, 75);
            plusLeftLbl.Name = "plusLeftLbl";
            plusLeftLbl.Size = new Size(60, 50);
            plusLeftLbl.TabIndex = 2;
            plusLeftLbl.Text = "?";
            plusLeftLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // igualSomaLbl
            // 
            igualSomaLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            igualSomaLbl.Location = new Point(248, 75);
            igualSomaLbl.Name = "igualSomaLbl";
            igualSomaLbl.Size = new Size(60, 50);
            igualSomaLbl.TabIndex = 3;
            igualSomaLbl.Text = "=";
            igualSomaLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLbl
            // 
            plusRightLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plusRightLbl.Location = new Point(182, 75);
            plusRightLbl.Name = "plusRightLbl";
            plusRightLbl.Size = new Size(60, 50);
            plusRightLbl.TabIndex = 4;
            plusRightLbl.Text = "?";
            plusRightLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusLbl
            // 
            plusLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plusLbl.Location = new Point(116, 75);
            plusLbl.Name = "plusLbl";
            plusLbl.Size = new Size(60, 50);
            plusLbl.TabIndex = 5;
            plusLbl.Text = "+";
            plusLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // soma
            // 
            soma.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            soma.Location = new Point(314, 86);
            soma.Name = "soma";
            soma.Size = new Size(100, 39);
            soma.TabIndex = 1;
            soma.Click += Answer_Enter;
            soma.Enter += Answer_Enter;
            // 
            // diferenca
            // 
            diferenca.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diferenca.Location = new Point(314, 139);
            diferenca.Name = "diferenca";
            diferenca.Size = new Size(100, 39);
            diferenca.TabIndex = 2;
            diferenca.ValueChanged += diferenca_ValueChanged;
            diferenca.Click += Answer_Enter;
            diferenca.Enter += Answer_Enter;
            // 
            // minusLbl
            // 
            minusLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minusLbl.Location = new Point(116, 128);
            minusLbl.Name = "minusLbl";
            minusLbl.Size = new Size(60, 50);
            minusLbl.TabIndex = 10;
            minusLbl.Text = "-";
            minusLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLbl
            // 
            minusRightLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minusRightLbl.Location = new Point(182, 128);
            minusRightLbl.Name = "minusRightLbl";
            minusRightLbl.Size = new Size(60, 50);
            minusRightLbl.TabIndex = 9;
            minusRightLbl.Text = "?";
            minusRightLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // igualDiferencaLbl
            // 
            igualDiferencaLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            igualDiferencaLbl.Location = new Point(248, 128);
            igualDiferencaLbl.Name = "igualDiferencaLbl";
            igualDiferencaLbl.Size = new Size(60, 50);
            igualDiferencaLbl.TabIndex = 8;
            igualDiferencaLbl.Text = "=";
            igualDiferencaLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLeftLbl
            // 
            minusLeftLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minusLeftLbl.Location = new Point(50, 128);
            minusLeftLbl.Name = "minusLeftLbl";
            minusLeftLbl.Size = new Size(60, 50);
            minusLeftLbl.TabIndex = 7;
            minusLeftLbl.Text = "?";
            minusLeftLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // produto
            // 
            produto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            produto.Location = new Point(314, 191);
            produto.Name = "produto";
            produto.Size = new Size(100, 39);
            produto.TabIndex = 3;
            produto.Click += Answer_Enter;
            produto.Enter += Answer_Enter;
            // 
            // timesLbl
            // 
            timesLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timesLbl.Location = new Point(116, 180);
            timesLbl.Name = "timesLbl";
            timesLbl.Size = new Size(60, 50);
            timesLbl.TabIndex = 15;
            timesLbl.Text = "×";
            timesLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLbl
            // 
            timesRightLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timesRightLbl.Location = new Point(182, 180);
            timesRightLbl.Name = "timesRightLbl";
            timesRightLbl.Size = new Size(60, 50);
            timesRightLbl.TabIndex = 14;
            timesRightLbl.Text = "?";
            timesRightLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // igualProdutoLbl
            // 
            igualProdutoLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            igualProdutoLbl.Location = new Point(248, 180);
            igualProdutoLbl.Name = "igualProdutoLbl";
            igualProdutoLbl.Size = new Size(60, 50);
            igualProdutoLbl.TabIndex = 13;
            igualProdutoLbl.Text = "=";
            igualProdutoLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLbl
            // 
            timesLeftLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timesLeftLbl.Location = new Point(50, 180);
            timesLeftLbl.Name = "timesLeftLbl";
            timesLeftLbl.Size = new Size(60, 50);
            timesLeftLbl.TabIndex = 12;
            timesLeftLbl.Text = "?";
            timesLeftLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quociente
            // 
            quociente.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quociente.Location = new Point(314, 241);
            quociente.Name = "quociente";
            quociente.Size = new Size(100, 39);
            quociente.TabIndex = 4;
            quociente.Click += Answer_Enter;
            quociente.Enter += Answer_Enter;
            // 
            // dividedLbl
            // 
            dividedLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dividedLbl.Location = new Point(116, 230);
            dividedLbl.Name = "dividedLbl";
            dividedLbl.Size = new Size(60, 50);
            dividedLbl.TabIndex = 20;
            dividedLbl.Text = "÷";
            dividedLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLbl
            // 
            dividedRightLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dividedRightLbl.Location = new Point(182, 230);
            dividedRightLbl.Name = "dividedRightLbl";
            dividedRightLbl.Size = new Size(60, 50);
            dividedRightLbl.TabIndex = 19;
            dividedRightLbl.Text = "?";
            dividedRightLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // igualQuocienteLbl
            // 
            igualQuocienteLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            igualQuocienteLbl.Location = new Point(248, 230);
            igualQuocienteLbl.Name = "igualQuocienteLbl";
            igualQuocienteLbl.Size = new Size(60, 50);
            igualQuocienteLbl.TabIndex = 18;
            igualQuocienteLbl.Text = "=";
            igualQuocienteLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLbl
            // 
            dividedLeftLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dividedLeftLbl.Location = new Point(50, 230);
            dividedLeftLbl.Name = "dividedLeftLbl";
            dividedLeftLbl.Size = new Size(60, 50);
            dividedLeftLbl.TabIndex = 17;
            dividedLeftLbl.Text = "?";
            dividedLeftLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            startBtn.AutoSize = true;
            startBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            startBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startBtn.Location = new Point(173, 314);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(135, 35);
            startBtn.TabIndex = 0;
            startBtn.Text = "Iniciar o teste";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(startBtn);
            Controls.Add(quociente);
            Controls.Add(dividedLbl);
            Controls.Add(dividedRightLbl);
            Controls.Add(igualQuocienteLbl);
            Controls.Add(dividedLeftLbl);
            Controls.Add(produto);
            Controls.Add(timesLbl);
            Controls.Add(timesRightLbl);
            Controls.Add(igualProdutoLbl);
            Controls.Add(timesLeftLbl);
            Controls.Add(diferenca);
            Controls.Add(minusLbl);
            Controls.Add(minusRightLbl);
            Controls.Add(igualDiferencaLbl);
            Controls.Add(minusLeftLbl);
            Controls.Add(soma);
            Controls.Add(plusLbl);
            Controls.Add(plusRightLbl);
            Controls.Add(igualSomaLbl);
            Controls.Add(plusLeftLbl);
            Controls.Add(label1);
            Controls.Add(timeLbl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Teste de Matemática";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)soma).EndInit();
            ((System.ComponentModel.ISupportInitialize)diferenca).EndInit();
            ((System.ComponentModel.ISupportInitialize)produto).EndInit();
            ((System.ComponentModel.ISupportInitialize)quociente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLbl;
        private Label label1;
        private Label plusLeftLbl;
        private Label igualSomaLbl;
        private Label plusRightLbl;
        private Label plusLbl;
        private NumericUpDown soma;
        private NumericUpDown diferenca;
        private Label minusLbl;
        private Label minusRightLbl;
        private Label igualDiferencaLbl;
        private Label minusLeftLbl;
        private NumericUpDown produto;
        private Label timesLbl;
        private Label timesRightLbl;
        private Label igualProdutoLbl;
        private Label timesLeftLbl;
        private NumericUpDown quociente;
        private Label dividedLbl;
        private Label dividedRightLbl;
        private Label igualQuocienteLbl;
        private Label dividedLeftLbl;
        private Button startBtn;
        private System.Windows.Forms.Timer timer1;
    }
}
