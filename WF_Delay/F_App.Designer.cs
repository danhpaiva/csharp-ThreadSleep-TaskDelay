namespace WF_Delay
{
    partial class F_App
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
            this.btnThreadSleep = new System.Windows.Forms.Button();
            this.btnTaskDelay = new System.Windows.Forms.Button();
            this.btnCancelarPausa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThreadSleep
            // 
            this.btnThreadSleep.Location = new System.Drawing.Point(67, 71);
            this.btnThreadSleep.Name = "btnThreadSleep";
            this.btnThreadSleep.Size = new System.Drawing.Size(150, 40);
            this.btnThreadSleep.TabIndex = 0;
            this.btnThreadSleep.Text = "Thread Sleep";
            this.btnThreadSleep.UseVisualStyleBackColor = true;
            this.btnThreadSleep.Click += new System.EventHandler(this.btnThreadSleep_Click);
            // 
            // btnTaskDelay
            // 
            this.btnTaskDelay.Location = new System.Drawing.Point(67, 123);
            this.btnTaskDelay.Name = "btnTaskDelay";
            this.btnTaskDelay.Size = new System.Drawing.Size(150, 40);
            this.btnTaskDelay.TabIndex = 1;
            this.btnTaskDelay.Text = "Task Delay";
            this.btnTaskDelay.UseVisualStyleBackColor = true;
            this.btnTaskDelay.Click += new System.EventHandler(this.btnTaskDelay_Click);
            // 
            // btnCancelarPausa
            // 
            this.btnCancelarPausa.Location = new System.Drawing.Point(67, 175);
            this.btnCancelarPausa.Name = "btnCancelarPausa";
            this.btnCancelarPausa.Size = new System.Drawing.Size(150, 40);
            this.btnCancelarPausa.TabIndex = 2;
            this.btnCancelarPausa.Text = "Cancelar Pausa";
            this.btnCancelarPausa.UseVisualStyleBackColor = true;
            this.btnCancelarPausa.Click += new System.EventHandler(this.btnCancelarPausa_Click);
            // 
            // F_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 303);
            this.Controls.Add(this.btnCancelarPausa);
            this.Controls.Add(this.btnTaskDelay);
            this.Controls.Add(this.btnThreadSleep);
            this.Name = "F_App";
            this.Text = "Thread.Sleep x Task.Delay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThreadSleep;
        private System.Windows.Forms.Button btnTaskDelay;
        private System.Windows.Forms.Button btnCancelarPausa;
    }
}

