namespace cliente
{
    partial class client
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txthost = new System.Windows.Forms.TextBox();
            this.butsend = new System.Windows.Forms.Button();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.labdirec = new System.Windows.Forms.Label();
            this.labmess = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labdirec);
            this.groupBox1.Controls.Add(this.labmess);
            this.groupBox1.Controls.Add(this.txtmessage);
            this.groupBox1.Controls.Add(this.txthost);
            this.groupBox1.Controls.Add(this.butsend);
            this.groupBox1.Location = new System.Drawing.Point(236, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 145);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UDP";
            // 
            // txthost
            // 
            this.txthost.Location = new System.Drawing.Point(58, 61);
            this.txthost.Name = "txthost";
            this.txthost.Size = new System.Drawing.Size(100, 20);
            this.txthost.TabIndex = 1;
            // 
            // butsend
            // 
            this.butsend.Location = new System.Drawing.Point(58, 32);
            this.butsend.Name = "butsend";
            this.butsend.Size = new System.Drawing.Size(75, 23);
            this.butsend.TabIndex = 0;
            this.butsend.Text = "Send";
            this.butsend.UseVisualStyleBackColor = true;
            this.butsend.Click += new System.EventHandler(this.butsend_Click);
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(58, 87);
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(100, 20);
            this.txtmessage.TabIndex = 2;
            // 
            // labdirec
            // 
            this.labdirec.AutoSize = true;
            this.labdirec.Location = new System.Drawing.Point(3, 64);
            this.labdirec.Name = "labdirec";
            this.labdirec.Size = new System.Drawing.Size(49, 13);
            this.labdirec.TabIndex = 6;
            this.labdirec.Text = "Direción:";
            // 
            // labmess
            // 
            this.labmess.AutoSize = true;
            this.labmess.Location = new System.Drawing.Point(2, 90);
            this.labmess.Name = "labmess";
            this.labmess.Size = new System.Drawing.Size(50, 13);
            this.labmess.TabIndex = 7;
            this.labmess.Text = "Mensaje:";
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "client";
            this.Text = "Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butsend;
        private System.Windows.Forms.TextBox txthost;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.Label labdirec;
        private System.Windows.Forms.Label labmess;
    }
}

