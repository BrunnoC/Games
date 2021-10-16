
namespace FormGame
{
    partial class FormInicial
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
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(221, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Olá! O que deseja jogar hoje";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel1.Location = new System.Drawing.Point(0, 430);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(646, 23);
            this.sidePanel1.TabIndex = 1;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(106, 97);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(143, 73);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Pedra Papel e Tesoura";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 453);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.label1);
            this.Name = "FormInicial";
            this.Text = "FormInicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}