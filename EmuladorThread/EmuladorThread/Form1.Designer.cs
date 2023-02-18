namespace EmuladorThread
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
            this.Label2 = new System.Windows.Forms.Label();
            this.txtNrThreadsFinalizadas = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtNrThreads = new System.Windows.Forms.TextBox();
            this.btnNovaThred = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(163, 91);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(140, 17);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Threads Finalizadas:";
            // 
            // txtNrThreadsFinalizadas
            // 
            this.txtNrThreadsFinalizadas.Location = new System.Drawing.Point(166, 114);
            this.txtNrThreadsFinalizadas.Name = "txtNrThreadsFinalizadas";
            this.txtNrThreadsFinalizadas.ReadOnly = true;
            this.txtNrThreadsFinalizadas.Size = new System.Drawing.Size(137, 22);
            this.txtNrThreadsFinalizadas.TabIndex = 8;
            this.txtNrThreadsFinalizadas.Text = "0";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(24, 91);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(124, 17);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Threads Iniciadas:";
            // 
            // txtNrThreads
            // 
            this.txtNrThreads.Location = new System.Drawing.Point(24, 114);
            this.txtNrThreads.Name = "txtNrThreads";
            this.txtNrThreads.ReadOnly = true;
            this.txtNrThreads.Size = new System.Drawing.Size(124, 22);
            this.txtNrThreads.TabIndex = 6;
            this.txtNrThreads.Text = "0";
            // 
            // btnNovaThred
            // 
            this.btnNovaThred.Location = new System.Drawing.Point(96, 24);
            this.btnNovaThred.Name = "btnNovaThred";
            this.btnNovaThred.Size = new System.Drawing.Size(135, 49);
            this.btnNovaThred.TabIndex = 5;
            this.btnNovaThred.Text = "Novas Threads";
            this.btnNovaThred.UseVisualStyleBackColor = true;
            this.btnNovaThred.Click += new System.EventHandler(this.btnNovaThred_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 162);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtNrThreadsFinalizadas);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtNrThreads);
            this.Controls.Add(this.btnNovaThred);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtNrThreadsFinalizadas;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtNrThreads;
        internal System.Windows.Forms.Button btnNovaThred;
    }
}

