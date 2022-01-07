
namespace MagazinPizza
{
    partial class CasaMarc
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
            this.components = new System.ComponentModel.Container();
            this.lbProduseSelectate = new System.Windows.Forms.ListBox();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ButonDelete = new System.Windows.Forms.Button();
            this.ButonPlata = new System.Windows.Forms.Button();
            this.PretTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProduseSelectate
            // 
            this.lbProduseSelectate.FormattingEnabled = true;
            this.lbProduseSelectate.Location = new System.Drawing.Point(351, 36);
            this.lbProduseSelectate.Name = "lbProduseSelectate";
            this.lbProduseSelectate.Size = new System.Drawing.Size(227, 251);
            this.lbProduseSelectate.TabIndex = 0;
            this.lbProduseSelectate.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.FormatList);
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataSource = typeof(GestiuneMagazin.Produse);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(333, 251);
            this.tabControl1.TabIndex = 1;
            // 
            // ButonDelete
            // 
            this.ButonDelete.BackColor = System.Drawing.Color.Red;
            this.ButonDelete.Location = new System.Drawing.Point(351, 321);
            this.ButonDelete.Name = "ButonDelete";
            this.ButonDelete.Size = new System.Drawing.Size(115, 65);
            this.ButonDelete.TabIndex = 2;
            this.ButonDelete.Text = "ȘTERGE";
            this.ButonDelete.UseVisualStyleBackColor = false;
            this.ButonDelete.Click += new System.EventHandler(this.Delete);
            // 
            // ButonPlata
            // 
            this.ButonPlata.BackColor = System.Drawing.Color.LawnGreen;
            this.ButonPlata.Location = new System.Drawing.Point(12, 321);
            this.ButonPlata.Name = "ButonPlata";
            this.ButonPlata.Size = new System.Drawing.Size(333, 65);
            this.ButonPlata.TabIndex = 3;
            this.ButonPlata.Text = "PLĂTEȘTE";
            this.ButonPlata.UseVisualStyleBackColor = false;
            this.ButonPlata.Click += new System.EventHandler(this.DeschidePlata);
            // 
            // PretTotal
            // 
            this.PretTotal.Location = new System.Drawing.Point(472, 321);
            this.PretTotal.Multiline = true;
            this.PretTotal.Name = "PretTotal";
            this.PretTotal.Size = new System.Drawing.Size(106, 65);
            this.PretTotal.TabIndex = 4;
            // 
            // CasaMarc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 415);
            this.Controls.Add(this.PretTotal);
            this.Controls.Add(this.ButonPlata);
            this.Controls.Add(this.ButonDelete);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbProduseSelectate);
            this.Name = "CasaMarc";
            this.Text = "Casa de Marcat";
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProduseSelectate;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button ButonDelete;
        private System.Windows.Forms.Button ButonPlata;
        private System.Windows.Forms.TextBox PretTotal;
    }
}