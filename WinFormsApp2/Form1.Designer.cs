namespace WinFormsApp2
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnRevisar = new System.Windows.Forms.Button();
            this.txtCidugov1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuentasB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(53, 296);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(161, 34);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnRevisar
            // 
            this.btnRevisar.Location = new System.Drawing.Point(53, 376);
            this.btnRevisar.Name = "btnRevisar";
            this.btnRevisar.Size = new System.Drawing.Size(161, 34);
            this.btnRevisar.TabIndex = 1;
            this.btnRevisar.Text = "Revisar datos";
            this.btnRevisar.UseVisualStyleBackColor = true;
            this.btnRevisar.Click += new System.EventHandler(this.btnRevisar_Click);
            // 
            // txtCidugov1
            // 
            this.txtCidugov1.Location = new System.Drawing.Point(64, 70);
            this.txtCidugov1.Name = "txtCidugov1";
            this.txtCidugov1.Size = new System.Drawing.Size(150, 31);
            this.txtCidugov1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cuentas Bancarias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo";
            // 
            // txtCuentasB
            // 
            this.txtCuentasB.Location = new System.Drawing.Point(64, 226);
            this.txtCuentasB.Name = "txtCuentasB";
            this.txtCuentasB.Size = new System.Drawing.Size(150, 31);
            this.txtCuentasB.TabIndex = 4;
            this.txtCuentasB.TextChanged += new System.EventHandler(this.txtCuentasB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(64, 146);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(150, 31);
            this.txtEdad.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(286, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(515, 343);
            this.dataGridView1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 9;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(852, 444);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCuentasB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCidugov1);
            this.Controls.Add(this.btnRevisar);
            this.Controls.Add(this.btnEnviar);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEnviar;
        private Button btnRevisar;
        private TextBox txtCidugov1;
        private Label label1;
        private Label label2;
        private TextBox txtCuentasB;
        private Label label3;
        private TextBox txtEdad;
        public DataGridView dataGridView1;
        private Label label4;
    }
}