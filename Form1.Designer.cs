namespace Cuesta_prestamo_2._0
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
            dgb_amortizacion = new DataGridView();
            no = new DataGridViewTextBoxColumn();
            cuota = new DataGridViewTextBoxColumn();
            capital = new DataGridViewTextBoxColumn();
            interes = new DataGridViewTextBoxColumn();
            saldo = new DataGridViewTextBoxColumn();
            txt_Porcentaje = new TextBox();
            lbl_Porcentaje = new Label();
            label2 = new Label();
            txt_Total = new TextBox();
            lbl_Total = new Label();
            txt_Anos = new TextBox();
            txt_Cuotas = new TextBox();
            txt_Tasa_Interes = new TextBox();
            txt_Monto = new TextBox();
            btn_Salir = new Button();
            btn_Limpiar = new Button();
            btn_Calcular = new Button();
            lbl_Cuotas = new Label();
            lbl_Anos = new Label();
            lbl_Tasa_Interes = new Label();
            lbl_Monto = new Label();
            ((System.ComponentModel.ISupportInitialize)dgb_amortizacion).BeginInit();
            SuspendLayout();
            // 
            // dgb_amortizacion
            // 
            dgb_amortizacion.AllowUserToAddRows = false;
            dgb_amortizacion.AllowUserToDeleteRows = false;
            dgb_amortizacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgb_amortizacion.Columns.AddRange(new DataGridViewColumn[] { no, cuota, capital, interes, saldo });
            dgb_amortizacion.Location = new Point(-51, 300);
            dgb_amortizacion.Name = "dgb_amortizacion";
            dgb_amortizacion.ReadOnly = true;
            dgb_amortizacion.Size = new Size(903, 150);
            dgb_amortizacion.TabIndex = 33;
            // 
            // no
            // 
            no.HeaderText = "No";
            no.Name = "no";
            no.ReadOnly = true;
            // 
            // cuota
            // 
            cuota.HeaderText = "Cuota";
            cuota.Name = "cuota";
            cuota.ReadOnly = true;
            cuota.Width = 200;
            // 
            // capital
            // 
            capital.HeaderText = "Capital";
            capital.Name = "capital";
            capital.ReadOnly = true;
            capital.Width = 200;
            // 
            // interes
            // 
            interes.HeaderText = "Interes";
            interes.Name = "interes";
            interes.ReadOnly = true;
            interes.Width = 200;
            // 
            // saldo
            // 
            saldo.HeaderText = "Saldo";
            saldo.Name = "saldo";
            saldo.ReadOnly = true;
            saldo.Width = 200;
            // 
            // txt_Porcentaje
            // 
            txt_Porcentaje.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txt_Porcentaje.Location = new Point(198, 166);
            txt_Porcentaje.Name = "txt_Porcentaje";
            txt_Porcentaje.Size = new Size(100, 26);
            txt_Porcentaje.TabIndex = 32;
            // 
            // lbl_Porcentaje
            // 
            lbl_Porcentaje.AutoSize = true;
            lbl_Porcentaje.Font = new Font("Times New Roman", 12F, FontStyle.Italic);
            lbl_Porcentaje.Location = new Point(50, 173);
            lbl_Porcentaje.Name = "lbl_Porcentaje";
            lbl_Porcentaje.Size = new Size(79, 19);
            lbl_Porcentaje.TabIndex = 31;
            lbl_Porcentaje.Text = "Porcentaje";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            label2.Location = new Point(2, 9);
            label2.Name = "label2";
            label2.Size = new Size(211, 31);
            label2.TabIndex = 30;
            label2.Text = "Cuota_Prestamo";
            // 
            // txt_Total
            // 
            txt_Total.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txt_Total.Location = new Point(198, 262);
            txt_Total.Name = "txt_Total";
            txt_Total.Size = new Size(100, 26);
            txt_Total.TabIndex = 29;
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Font = new Font("Times New Roman", 12F, FontStyle.Italic);
            lbl_Total.Location = new Point(54, 262);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(42, 19);
            lbl_Total.TabIndex = 28;
            lbl_Total.Text = "Total";
            // 
            // txt_Anos
            // 
            txt_Anos.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txt_Anos.Location = new Point(198, 209);
            txt_Anos.Name = "txt_Anos";
            txt_Anos.Size = new Size(100, 26);
            txt_Anos.TabIndex = 27;
            // 
            // txt_Cuotas
            // 
            txt_Cuotas.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txt_Cuotas.Location = new Point(563, 300);
            txt_Cuotas.Name = "txt_Cuotas";
            txt_Cuotas.Size = new Size(100, 26);
            txt_Cuotas.TabIndex = 26;
            // 
            // txt_Tasa_Interes
            // 
            txt_Tasa_Interes.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txt_Tasa_Interes.Location = new Point(198, 121);
            txt_Tasa_Interes.Name = "txt_Tasa_Interes";
            txt_Tasa_Interes.Size = new Size(100, 26);
            txt_Tasa_Interes.TabIndex = 25;
            // 
            // txt_Monto
            // 
            txt_Monto.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txt_Monto.Location = new Point(198, 67);
            txt_Monto.Name = "txt_Monto";
            txt_Monto.Size = new Size(100, 26);
            txt_Monto.TabIndex = 24;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = SystemColors.GradientActiveCaption;
            btn_Salir.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_Salir.Location = new Point(349, 255);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(82, 34);
            btn_Salir.TabIndex = 23;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = SystemColors.GradientActiveCaption;
            btn_Limpiar.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_Limpiar.Location = new Point(349, 193);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(82, 34);
            btn_Limpiar.TabIndex = 22;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // btn_Calcular
            // 
            btn_Calcular.BackColor = SystemColors.GradientActiveCaption;
            btn_Calcular.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_Calcular.Location = new Point(349, 130);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(82, 34);
            btn_Calcular.TabIndex = 21;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = false;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // lbl_Cuotas
            // 
            lbl_Cuotas.AutoSize = true;
            lbl_Cuotas.Font = new Font("Times New Roman", 12F, FontStyle.Italic);
            lbl_Cuotas.Location = new Point(415, 300);
            lbl_Cuotas.Name = "lbl_Cuotas";
            lbl_Cuotas.Size = new Size(55, 19);
            lbl_Cuotas.TabIndex = 20;
            lbl_Cuotas.Text = "Cuotas";
            // 
            // lbl_Anos
            // 
            lbl_Anos.AutoSize = true;
            lbl_Anos.Font = new Font("Times New Roman", 12F, FontStyle.Italic);
            lbl_Anos.Location = new Point(55, 216);
            lbl_Anos.Name = "lbl_Anos";
            lbl_Anos.Size = new Size(41, 19);
            lbl_Anos.TabIndex = 19;
            lbl_Anos.Text = "Anos";
            // 
            // lbl_Tasa_Interes
            // 
            lbl_Tasa_Interes.AutoSize = true;
            lbl_Tasa_Interes.Font = new Font("Times New Roman", 12F, FontStyle.Italic);
            lbl_Tasa_Interes.Location = new Point(50, 112);
            lbl_Tasa_Interes.Name = "lbl_Tasa_Interes";
            lbl_Tasa_Interes.Size = new Size(90, 19);
            lbl_Tasa_Interes.TabIndex = 18;
            lbl_Tasa_Interes.Text = "Tasa_Interes";
            // 
            // lbl_Monto
            // 
            lbl_Monto.AutoSize = true;
            lbl_Monto.Font = new Font("Times New Roman", 12F, FontStyle.Italic);
            lbl_Monto.Location = new Point(50, 70);
            lbl_Monto.Name = "lbl_Monto";
            lbl_Monto.Size = new Size(51, 19);
            lbl_Monto.TabIndex = 17;
            lbl_Monto.Text = "Monto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(911, 427);
            Controls.Add(dgb_amortizacion);
            Controls.Add(txt_Porcentaje);
            Controls.Add(lbl_Porcentaje);
            Controls.Add(label2);
            Controls.Add(txt_Total);
            Controls.Add(lbl_Total);
            Controls.Add(txt_Anos);
            Controls.Add(txt_Cuotas);
            Controls.Add(txt_Tasa_Interes);
            Controls.Add(txt_Monto);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Calcular);
            Controls.Add(lbl_Cuotas);
            Controls.Add(lbl_Anos);
            Controls.Add(lbl_Tasa_Interes);
            Controls.Add(lbl_Monto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgb_amortizacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgb_amortizacion;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn cuota;
        private DataGridViewTextBoxColumn capital;
        private DataGridViewTextBoxColumn interes;
        private DataGridViewTextBoxColumn saldo;
        private TextBox txt_Porcentaje;
        private Label lbl_Porcentaje;
        private Label label2;
        private TextBox txt_Total;
        private Label lbl_Total;
        private TextBox txt_Anos;
        private TextBox txt_Cuotas;
        private TextBox txt_Tasa_Interes;
        private TextBox txt_Monto;
        private Button btn_Salir;
        private Button btn_Limpiar;
        private Button btn_Calcular;
        private Label lbl_Cuotas;
        private Label lbl_Anos;
        private Label lbl_Tasa_Interes;
        private Label lbl_Monto;
    }
}
