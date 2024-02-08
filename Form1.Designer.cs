namespace AcademiaPanel2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblResultadoImc = new System.Windows.Forms.Label();
            this.numAltura = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numPeso = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblResultadoCalorias = new System.Windows.Forms.Label();
            this.numPesoCalorias = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDuracao = new System.Windows.Forms.DateTimePicker();
            this.cmbAtividade = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numPesoHidratacao = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblResultadoHidratacao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoCalorias)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoHidratacao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.numAltura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numPeso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(419, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IMC";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Maroon;
            this.groupBox4.Controls.Add(this.lblResultadoImc);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(217, 33);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(197, 195);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado";
            // 
            // lblResultadoImc
            // 
            this.lblResultadoImc.AutoSize = true;
            this.lblResultadoImc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultadoImc.Font = new System.Drawing.Font("OCR A Extended", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoImc.Location = new System.Drawing.Point(2, 19);
            this.lblResultadoImc.Name = "lblResultadoImc";
            this.lblResultadoImc.Padding = new System.Windows.Forms.Padding(10);
            this.lblResultadoImc.Size = new System.Drawing.Size(20, 61);
            this.lblResultadoImc.TabIndex = 0;
            this.lblResultadoImc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numAltura
            // 
            this.numAltura.DecimalPlaces = 2;
            this.numAltura.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAltura.Location = new System.Drawing.Point(4, 120);
            this.numAltura.Margin = new System.Windows.Forms.Padding(2);
            this.numAltura.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numAltura.Name = "numAltura";
            this.numAltura.Size = new System.Drawing.Size(195, 35);
            this.numAltura.TabIndex = 1;
            this.numAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAltura.ValueChanged += new System.EventHandler(this.numPeso_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altura";
            // 
            // numPeso
            // 
            this.numPeso.DecimalPlaces = 2;
            this.numPeso.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPeso.Location = new System.Drawing.Point(4, 58);
            this.numPeso.Margin = new System.Windows.Forms.Padding(2);
            this.numPeso.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPeso.Name = "numPeso";
            this.numPeso.Size = new System.Drawing.Size(195, 35);
            this.numPeso.TabIndex = 0;
            this.numPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPeso.ValueChanged += new System.EventHandler(this.numPeso_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.numPesoCalorias);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateDuracao);
            this.groupBox2.Controls.Add(this.cmbAtividade);
            this.groupBox2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(430, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(419, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contador de Calorias";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Olive;
            this.groupBox5.Controls.Add(this.lblResultadoCalorias);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(217, 36);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(197, 195);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resultado";
            // 
            // lblResultadoCalorias
            // 
            this.lblResultadoCalorias.AutoSize = true;
            this.lblResultadoCalorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultadoCalorias.Font = new System.Drawing.Font("OCR A Extended", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCalorias.Location = new System.Drawing.Point(2, 19);
            this.lblResultadoCalorias.Name = "lblResultadoCalorias";
            this.lblResultadoCalorias.Padding = new System.Windows.Forms.Padding(10);
            this.lblResultadoCalorias.Size = new System.Drawing.Size(20, 61);
            this.lblResultadoCalorias.TabIndex = 1;
            this.lblResultadoCalorias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numPesoCalorias
            // 
            this.numPesoCalorias.DecimalPlaces = 2;
            this.numPesoCalorias.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPesoCalorias.Location = new System.Drawing.Point(4, 186);
            this.numPesoCalorias.Margin = new System.Windows.Forms.Padding(2);
            this.numPesoCalorias.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPesoCalorias.Name = "numPesoCalorias";
            this.numPesoCalorias.Size = new System.Drawing.Size(190, 35);
            this.numPesoCalorias.TabIndex = 2;
            this.numPesoCalorias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPesoCalorias.ValueChanged += new System.EventHandler(this.numPesoCalorias_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duração (min)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Peso";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Atividade";
            // 
            // dateDuracao
            // 
            this.dateDuracao.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDuracao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateDuracao.Location = new System.Drawing.Point(4, 120);
            this.dateDuracao.Margin = new System.Windows.Forms.Padding(2);
            this.dateDuracao.Name = "dateDuracao";
            this.dateDuracao.Size = new System.Drawing.Size(190, 35);
            this.dateDuracao.TabIndex = 1;
            this.dateDuracao.Value = new System.DateTime(2024, 2, 7, 0, 0, 0, 0);
            this.dateDuracao.ValueChanged += new System.EventHandler(this.numPesoCalorias_ValueChanged);
            // 
            // cmbAtividade
            // 
            this.cmbAtividade.Font = new System.Drawing.Font("OCR A Extended", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAtividade.FormattingEnabled = true;
            this.cmbAtividade.Items.AddRange(new object[] {
            "Caminhada",
            "Corrida",
            "Patinação",
            "Natação",
            "Abdominais",
            "Dança de Salão"});
            this.cmbAtividade.Location = new System.Drawing.Point(4, 50);
            this.cmbAtividade.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAtividade.Name = "cmbAtividade";
            this.cmbAtividade.Size = new System.Drawing.Size(190, 31);
            this.cmbAtividade.TabIndex = 0;
            this.cmbAtividade.SelectedIndexChanged += new System.EventHandler(this.numPesoCalorias_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.numPesoHidratacao);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 247);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(419, 193);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Metas de Hidratação";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Turquoise;
            this.groupBox6.Controls.Add(this.lblResultadoHidratacao);
            this.groupBox6.Location = new System.Drawing.Point(217, 15);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(197, 174);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resultado";
            // 
            // numPesoHidratacao
            // 
            this.numPesoHidratacao.DecimalPlaces = 2;
            this.numPesoHidratacao.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPesoHidratacao.Location = new System.Drawing.Point(4, 51);
            this.numPesoHidratacao.Margin = new System.Windows.Forms.Padding(2);
            this.numPesoHidratacao.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPesoHidratacao.Name = "numPesoHidratacao";
            this.numPesoHidratacao.Size = new System.Drawing.Size(195, 35);
            this.numPesoHidratacao.TabIndex = 0;
            this.numPesoHidratacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPesoHidratacao.ValueChanged += new System.EventHandler(this.numPesoHidratacao_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Peso";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Cornsilk;
            this.monthCalendar1.Location = new System.Drawing.Point(521, 266);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(6);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // lblResultadoHidratacao
            // 
            this.lblResultadoHidratacao.AutoSize = true;
            this.lblResultadoHidratacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultadoHidratacao.Font = new System.Drawing.Font("OCR A Extended", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoHidratacao.Location = new System.Drawing.Point(2, 19);
            this.lblResultadoHidratacao.Name = "lblResultadoHidratacao";
            this.lblResultadoHidratacao.Padding = new System.Windows.Forms.Padding(10);
            this.lblResultadoHidratacao.Size = new System.Drawing.Size(20, 61);
            this.lblResultadoHidratacao.TabIndex = 2;
            this.lblResultadoHidratacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(856, 443);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Painel Academia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoCalorias)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoHidratacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numAltura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numPesoCalorias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateDuracao;
        private System.Windows.Forms.ComboBox cmbAtividade;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.NumericUpDown numPesoHidratacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblResultadoImc;
        private System.Windows.Forms.Label lblResultadoCalorias;
        private System.Windows.Forms.Label lblResultadoHidratacao;
    }
}

