namespace EventosAssincronosESincronos
{
    partial class FrmPrincipal
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
            this.BtnProcessarAsync = new System.Windows.Forms.Button();
            this.LblNumeroProcessos = new System.Windows.Forms.Label();
            this.LblProgresso = new System.Windows.Forms.Label();
            this.TxtNumeroProcessos = new System.Windows.Forms.MaskedTextBox();
            this.BtnProcessarSincrono = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProcessarAsync
            // 
            this.BtnProcessarAsync.Location = new System.Drawing.Point(154, 71);
            this.BtnProcessarAsync.Name = "BtnProcessarAsync";
            this.BtnProcessarAsync.Size = new System.Drawing.Size(123, 23);
            this.BtnProcessarAsync.TabIndex = 1;
            this.BtnProcessarAsync.Text = "Processar Assíncrono";
            this.BtnProcessarAsync.UseVisualStyleBackColor = true;
            this.BtnProcessarAsync.Click += new System.EventHandler(this.BtnProcessarAsync_Click);
            // 
            // LblNumeroProcessos
            // 
            this.LblNumeroProcessos.AutoSize = true;
            this.LblNumeroProcessos.Location = new System.Drawing.Point(12, 9);
            this.LblNumeroProcessos.Name = "LblNumeroProcessos";
            this.LblNumeroProcessos.Size = new System.Drawing.Size(111, 13);
            this.LblNumeroProcessos.TabIndex = 2;
            this.LblNumeroProcessos.Text = "Número de Processos";
            // 
            // LblProgresso
            // 
            this.LblProgresso.AutoSize = true;
            this.LblProgresso.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblProgresso.Location = new System.Drawing.Point(88, 45);
            this.LblProgresso.Name = "LblProgresso";
            this.LblProgresso.Size = new System.Drawing.Size(113, 13);
            this.LblProgresso.TabIndex = 3;
            this.LblProgresso.Text = "Processamento 0 de 0";
            this.LblProgresso.Visible = false;
            // 
            // TxtNumeroProcessos
            // 
            this.TxtNumeroProcessos.Location = new System.Drawing.Point(125, 13);
            this.TxtNumeroProcessos.Mask = "0#";
            this.TxtNumeroProcessos.Name = "TxtNumeroProcessos";
            this.TxtNumeroProcessos.Size = new System.Drawing.Size(171, 20);
            this.TxtNumeroProcessos.TabIndex = 4;
            // 
            // BtnProcessarSincrono
            // 
            this.BtnProcessarSincrono.Location = new System.Drawing.Point(25, 71);
            this.BtnProcessarSincrono.Name = "BtnProcessarSincrono";
            this.BtnProcessarSincrono.Size = new System.Drawing.Size(123, 23);
            this.BtnProcessarSincrono.TabIndex = 5;
            this.BtnProcessarSincrono.Text = "Processar Síncrono";
            this.BtnProcessarSincrono.UseVisualStyleBackColor = true;
            this.BtnProcessarSincrono.Click += new System.EventHandler(this.BtnProcessarSincrono_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(91, 109);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(123, 23);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 143);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnProcessarSincrono);
            this.Controls.Add(this.TxtNumeroProcessos);
            this.Controls.Add(this.LblProgresso);
            this.Controls.Add(this.LblNumeroProcessos);
            this.Controls.Add(this.BtnProcessarAsync);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos Assíncronos x Síncronos";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnProcessarAsync;
        private System.Windows.Forms.Label LblNumeroProcessos;
        private System.Windows.Forms.Label LblProgresso;
        private System.Windows.Forms.MaskedTextBox TxtNumeroProcessos;
        private System.Windows.Forms.Button BtnProcessarSincrono;
        private System.Windows.Forms.Button BtnCancelar;
    }
}

