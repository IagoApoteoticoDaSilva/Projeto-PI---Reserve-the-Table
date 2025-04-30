namespace Projeto_P.I
{
    partial class FormCadastroMesas
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
            this.lblCadMesa = new System.Windows.Forms.Label();
            this.txtNumeroMesa = new Guna.UI2.WinForms.Guna2TextBox();
            this.nudCapacidade = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbSatatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSalvarMesa = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNumeroMesa = new System.Windows.Forms.Label();
            this.lblCapacidade = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidade)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadMesa
            // 
            this.lblCadMesa.AutoSize = true;
            this.lblCadMesa.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadMesa.ForeColor = System.Drawing.Color.White;
            this.lblCadMesa.Location = new System.Drawing.Point(285, 30);
            this.lblCadMesa.Name = "lblCadMesa";
            this.lblCadMesa.Size = new System.Drawing.Size(241, 37);
            this.lblCadMesa.TabIndex = 0;
            this.lblCadMesa.Text = "Cadastro de Mesas";
            this.lblCadMesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCadMesa.Click += new System.EventHandler(this.lblCadMesa_Click);
            // 
            // txtNumeroMesa
            // 
            this.txtNumeroMesa.BorderRadius = 8;
            this.txtNumeroMesa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroMesa.DefaultText = "";
            this.txtNumeroMesa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumeroMesa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumeroMesa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroMesa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroMesa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroMesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroMesa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroMesa.Location = new System.Drawing.Point(200, 150);
            this.txtNumeroMesa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroMesa.Name = "txtNumeroMesa";
            this.txtNumeroMesa.PlaceholderText = "Dígite o número da mesa";
            this.txtNumeroMesa.SelectedText = "";
            this.txtNumeroMesa.Size = new System.Drawing.Size(400, 40);
            this.txtNumeroMesa.TabIndex = 1;
            // 
            // nudCapacidade
            // 
            this.nudCapacidade.BackColor = System.Drawing.Color.Transparent;
            this.nudCapacidade.BorderRadius = 8;
            this.nudCapacidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudCapacidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCapacidade.Location = new System.Drawing.Point(200, 230);
            this.nudCapacidade.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCapacidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacidade.Name = "nudCapacidade";
            this.nudCapacidade.Size = new System.Drawing.Size(400, 40);
            this.nudCapacidade.TabIndex = 2;
            this.nudCapacidade.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nudCapacidade.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cbSatatus
            // 
            this.cbSatatus.BackColor = System.Drawing.Color.Transparent;
            this.cbSatatus.BorderRadius = 8;
            this.cbSatatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSatatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSatatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSatatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSatatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbSatatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSatatus.ItemHeight = 30;
            this.cbSatatus.Items.AddRange(new object[] {
            "Disponível",
            "Ocupada"});
            this.cbSatatus.Location = new System.Drawing.Point(200, 310);
            this.cbSatatus.Name = "cbSatatus";
            this.cbSatatus.Size = new System.Drawing.Size(400, 36);
            this.cbSatatus.TabIndex = 3;
            // 
            // btnSalvarMesa
            // 
            this.btnSalvarMesa.BorderRadius = 8;
            this.btnSalvarMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarMesa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvarMesa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvarMesa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalvarMesa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalvarMesa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSalvarMesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarMesa.ForeColor = System.Drawing.Color.White;
            this.btnSalvarMesa.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSalvarMesa.Location = new System.Drawing.Point(200, 380);
            this.btnSalvarMesa.Name = "btnSalvarMesa";
            this.btnSalvarMesa.Size = new System.Drawing.Size(400, 45);
            this.btnSalvarMesa.TabIndex = 4;
            this.btnSalvarMesa.Text = "Salvar Mesa";
            // 
            // panelHeader
            // 
            this.panelHeader.AutoScroll = true;
            this.panelHeader.AutoScrollMinSize = new System.Drawing.Size(0, 80);
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelHeader.Controls.Add(this.lblCadMesa);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 100);
            this.panelHeader.TabIndex = 5;
            // 
            // lblNumeroMesa
            // 
            this.lblNumeroMesa.AutoSize = true;
            this.lblNumeroMesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroMesa.Location = new System.Drawing.Point(200, 120);
            this.lblNumeroMesa.Name = "lblNumeroMesa";
            this.lblNumeroMesa.Size = new System.Drawing.Size(133, 21);
            this.lblNumeroMesa.TabIndex = 6;
            this.lblNumeroMesa.Text = "Número da Mesa:";
            // 
            // lblCapacidade
            // 
            this.lblCapacidade.AutoSize = true;
            this.lblCapacidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidade.Location = new System.Drawing.Point(200, 200);
            this.lblCapacidade.Name = "lblCapacidade";
            this.lblCapacidade.Size = new System.Drawing.Size(93, 21);
            this.lblCapacidade.TabIndex = 7;
            this.lblCapacidade.Text = "Capacidade:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(200, 280);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 21);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status:";
            // 
            // FormCadastroMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCapacidade);
            this.Controls.Add(this.lblNumeroMesa);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnSalvarMesa);
            this.Controls.Add(this.cbSatatus);
            this.Controls.Add(this.nudCapacidade);
            this.Controls.Add(this.txtNumeroMesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroMesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroMesas";
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidade)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadMesa;
        private Guna.UI2.WinForms.Guna2TextBox txtNumeroMesa;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudCapacidade;
        private Guna.UI2.WinForms.Guna2ComboBox cbSatatus;
        private Guna.UI2.WinForms.Guna2Button btnSalvarMesa;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblNumeroMesa;
        private System.Windows.Forms.Label lblCapacidade;
        private System.Windows.Forms.Label lblStatus;
    }
}