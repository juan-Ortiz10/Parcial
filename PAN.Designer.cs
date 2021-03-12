
namespace Parcial
{
    partial class PAN
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
            this.btnComp = new System.Windows.Forms.Button();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComp
            // 
            this.btnComp.BackColor = System.Drawing.Color.Black;
            this.btnComp.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComp.Location = new System.Drawing.Point(120, 109);
            this.btnComp.Name = "btnComp";
            this.btnComp.Size = new System.Drawing.Size(89, 33);
            this.btnComp.TabIndex = 12;
            this.btnComp.Text = "Comprobar";
            this.btnComp.UseVisualStyleBackColor = false;
            this.btnComp.Click += new System.EventHandler(this.btnComp_Click);
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.Location = new System.Drawing.Point(95, 66);
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(244, 20);
            this.txtEnunciado.TabIndex = 10;
            this.txtEnunciado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnunciado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enunciado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Comprobar Pangramas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(351, 157);
            this.Controls.Add(this.btnComp);
            this.Controls.Add(this.txtEnunciado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PAN";
            this.Text = "Pangramas";
            this.Load += new System.EventHandler(this.PAN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComp;
        private System.Windows.Forms.TextBox txtEnunciado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}