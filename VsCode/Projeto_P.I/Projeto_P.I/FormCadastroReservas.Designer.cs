namespace Projeto_P.I
{
    partial class FormCadastroReservas
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
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCadReservas = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMesa = new System.Windows.Forms.Label();
            this.cbMesa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblDataReserva = new System.Windows.Forms.Label();
            this.dtpDataReserva = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblQtdPessoas = new System.Windows.Forms.Label();
            this.nudQtdPessoas = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnSalvarReserva = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelHeader.Controls.Add(this.lblCadReservas);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblCadReservas
            // 
            this.lblCadReservas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCadReservas.AutoSize = true;
            this.lblCadReservas.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadReservas.ForeColor = System.Drawing.Color.White;
            this.lblCadReservas.Location = new System.Drawing.Point(253, 31);
            this.lblCadReservas.Name = "lblCadReservas";
            this.lblCadReservas.Size = new System.Drawing.Size(268, 37);
            this.lblCadReservas.TabIndex = 1;
            this.lblCadReservas.Text = "Cadastro de Reservas";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(200, 120);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 21);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCliente.BorderRadius = 8;
            this.txtCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCliente.DefaultText = "";
            this.txtCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCliente.Location = new System.Drawing.Point(200, 150);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PlaceholderText = "Nome do Cliente";
            this.txtCliente.SelectedText = "";
            this.txtCliente.Size = new System.Drawing.Size(400, 40);
            this.txtCliente.TabIndex = 2;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.Location = new System.Drawing.Point(200, 200);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(50, 21);
            this.lblMesa.TabIndex = 3;
            this.lblMesa.Text = "Mesa:";
            // 
            // cbMesa
            // 
            this.cbMesa.BackColor = System.Drawing.Color.Transparent;
            this.cbMesa.BorderRadius = 8;
            this.cbMesa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMesa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMesa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMesa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMesa.ItemHeight = 30;
            this.cbMesa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMesa.Location = new System.Drawing.Point(200, 230);
            this.cbMesa.Name = "cbMesa";
            this.cbMesa.Size = new System.Drawing.Size(400, 36);
            this.cbMesa.TabIndex = 4;
            this.cbMesa.Tag = "";
            // 
            // lblDataReserva
            // 
            this.lblDataReserva.AutoSize = true;
            this.lblDataReserva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataReserva.Location = new System.Drawing.Point(200, 280);
            this.lblDataReserva.Name = "lblDataReserva";
            this.lblDataReserva.Size = new System.Drawing.Size(45, 21);
            this.lblDataReserva.TabIndex = 5;
            this.lblDataReserva.Text = "Data:";
            // 
            // dtpDataReserva
            // 
            this.dtpDataReserva.BorderRadius = 8;
            this.dtpDataReserva.Checked = true;
            this.dtpDataReserva.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dtpDataReserva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataReserva.Location = new System.Drawing.Point(200, 310);
            this.dtpDataReserva.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDataReserva.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDataReserva.Name = "dtpDataReserva";
            this.dtpDataReserva.Size = new System.Drawing.Size(180, 40);
            this.dtpDataReserva.TabIndex = 6;
            this.dtpDataReserva.Value = new System.DateTime(2025, 4, 28, 22, 4, 25, 51);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(425, 280);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(47, 21);
            this.lblHora.TabIndex = 7;
            this.lblHora.Text = "Hora:";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 8;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(421, 310);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(179, 40);
            this.guna2DateTimePicker1.TabIndex = 9;
            this.guna2DateTimePicker1.Value = new System.DateTime(2025, 4, 28, 22, 4, 25, 51);
            // 
            // lblQtdPessoas
            // 
            this.lblQtdPessoas.AutoSize = true;
            this.lblQtdPessoas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdPessoas.Location = new System.Drawing.Point(200, 353);
            this.lblQtdPessoas.Name = "lblQtdPessoas";
            this.lblQtdPessoas.Size = new System.Drawing.Size(173, 21);
            this.lblQtdPessoas.TabIndex = 10;
            this.lblQtdPessoas.Text = "Quantidade de Pessoas:";
            // 
            // nudQtdPessoas
            // 
            this.nudQtdPessoas.BackColor = System.Drawing.Color.Transparent;
            this.nudQtdPessoas.BorderRadius = 8;
            this.nudQtdPessoas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudQtdPessoas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtdPessoas.Location = new System.Drawing.Point(200, 377);
            this.nudQtdPessoas.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudQtdPessoas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtdPessoas.Name = "nudQtdPessoas";
            this.nudQtdPessoas.Size = new System.Drawing.Size(400, 40);
            this.nudQtdPessoas.TabIndex = 11;
            this.nudQtdPessoas.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nudQtdPessoas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSalvarReserva
            // 
            this.btnSalvarReserva.BorderRadius = 8;
            this.btnSalvarReserva.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvarReserva.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvarReserva.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalvarReserva.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalvarReserva.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSalvarReserva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarReserva.ForeColor = System.Drawing.Color.White;
            this.btnSalvarReserva.Location = new System.Drawing.Point(292, 435);
            this.btnSalvarReserva.Name = "btnSalvarReserva";
            this.btnSalvarReserva.Size = new System.Drawing.Size(180, 45);
            this.btnSalvarReserva.TabIndex = 12;
            this.btnSalvarReserva.Text = "Salvar Reserva";
            // 
            // FormCadastroReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.btnSalvarReserva);
            this.Controls.Add(this.nudQtdPessoas);
            this.Controls.Add(this.lblQtdPessoas);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.dtpDataReserva);
            this.Controls.Add(this.lblDataReserva);
            this.Controls.Add(this.cbMesa);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroReservas";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblCadReservas;
        private System.Windows.Forms.Label lblCliente;
        private Guna.UI2.WinForms.Guna2TextBox txtCliente;
        private System.Windows.Forms.Label lblMesa;
        private Guna.UI2.WinForms.Guna2ComboBox cbMesa;
        private System.Windows.Forms.Label lblDataReserva;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataReserva;
        private System.Windows.Forms.Label lblHora;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label lblQtdPessoas;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudQtdPessoas;
        private Guna.UI2.WinForms.Guna2Button btnSalvarReserva;
    }
}