
namespace MagazinPizza
{
    partial class FinalizarePlata
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSumaPlata = new System.Windows.Forms.TextBox();
            this.txtSumaPlatita = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sumă de plată";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sumă oferită";
            // 
            // txtSumaPlata
            // 
            this.txtSumaPlata.Location = new System.Drawing.Point(125, 37);
            this.txtSumaPlata.Name = "txtSumaPlata";
            this.txtSumaPlata.Size = new System.Drawing.Size(127, 20);
            this.txtSumaPlata.TabIndex = 2;
            // 
            // txtSumaPlatita
            // 
            this.txtSumaPlatita.Location = new System.Drawing.Point(125, 91);
            this.txtSumaPlatita.Name = "txtSumaPlatita";
            this.txtSumaPlatita.Size = new System.Drawing.Size(127, 20);
            this.txtSumaPlatita.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Plată Realizată";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Plata_Click);
            // 
            // FinalizarePlata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSumaPlatita);
            this.Controls.Add(this.txtSumaPlata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FinalizarePlata";
            this.Text = "Finalizare Plata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSumaPlata;
        private System.Windows.Forms.TextBox txtSumaPlatita;
        private System.Windows.Forms.Button button1;
    }
}