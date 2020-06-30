namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Datapriema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datauvolneniya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblMonthes = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Трудовой стаж работника";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(63, 413);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(112, 36);
            this.btn1.TabIndex = 15;
            this.btn1.Text = "Добавить ещё";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(238, 413);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(112, 36);
            this.btn2.TabIndex = 16;
            this.btn2.Text = "Рассчитать";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(587, 426);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 17;
            this.btn3.Text = "Выход";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datapriema,
            this.Datauvolneniya,
            this.GG,
            this.MM,
            this.DD});
            this.dataGridView1.Location = new System.Drawing.Point(63, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 232);
            this.dataGridView1.TabIndex = 18;
            // 
            // Datapriema
            // 
            this.Datapriema.HeaderText = "Дата приёма на работу";
            this.Datapriema.Name = "Datapriema";
            // 
            // Datauvolneniya
            // 
            this.Datauvolneniya.HeaderText = "Дата увольнения";
            this.Datauvolneniya.Name = "Datauvolneniya";
            // 
            // GG
            // 
            this.GG.HeaderText = "ГГ";
            this.GG.Name = "GG";
            // 
            // MM
            // 
            this.MM.HeaderText = "ММ";
            this.MM.Name = "MM";
            // 
            // DD
            // 
            this.DD.HeaderText = "ДД";
            this.DD.Name = "DD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(264, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата увольнения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(60, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата приёма на работу";
            // 
            // txtB1
            // 
            this.txtB1.Location = new System.Drawing.Point(63, 108);
            this.txtB1.Multiline = true;
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(167, 23);
            this.txtB1.TabIndex = 19;
            this.txtB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB1_KeyPress);
            // 
            // txtB2
            // 
            this.txtB2.Location = new System.Drawing.Point(267, 108);
            this.txtB2.Multiline = true;
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(149, 23);
            this.txtB2.TabIndex = 20;
            this.txtB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB2_KeyPress);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.Location = new System.Drawing.Point(441, 63);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(212, 20);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Итоговый стаж работника:";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYears.Location = new System.Drawing.Point(477, 83);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(47, 20);
            this.lblYears.TabIndex = 22;
            this.lblYears.Text = "Лет :";
            // 
            // lblMonthes
            // 
            this.lblMonthes.AutoSize = true;
            this.lblMonthes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMonthes.Location = new System.Drawing.Point(441, 103);
            this.lblMonthes.Name = "lblMonthes";
            this.lblMonthes.Size = new System.Drawing.Size(83, 20);
            this.lblMonthes.TabIndex = 23;
            this.lblMonthes.Text = "Месяцев :";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDays.Location = new System.Drawing.Point(468, 123);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(56, 20);
            this.lblDays.TabIndex = 24;
            this.lblDays.Text = "Дней :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 471);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblMonthes);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datapriema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datauvolneniya;
        private System.Windows.Forms.DataGridViewTextBoxColumn GG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblMonthes;
        private System.Windows.Forms.Label lblDays;
    }
}

