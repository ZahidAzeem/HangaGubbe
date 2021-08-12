
namespace HangaGubbe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSvar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxGubbe = new System.Windows.Forms.PictureBox();
            this.pictureBoxMark = new System.Windows.Forms.PictureBox();
            this.textBoxVisa = new System.Windows.Forms.TextBox();
            this.textBoxGissa = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGubbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMark)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(150, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rätt svar";
            // 
            // textBoxSvar
            // 
            this.textBoxSvar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSvar.Location = new System.Drawing.Point(138, 92);
            this.textBoxSvar.Name = "textBoxSvar";
            this.textBoxSvar.Size = new System.Drawing.Size(164, 45);
            this.textBoxSvar.TabIndex = 1;
            this.textBoxSvar.TextChanged += new System.EventHandler(this.textBoxSvar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.pictureBoxGubbe);
            this.panel1.Controls.Add(this.pictureBoxMark);
            this.panel1.Location = new System.Drawing.Point(79, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 387);
            this.panel1.TabIndex = 2;
            // 
            // pictureBoxGubbe
            // 
            this.pictureBoxGubbe.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGubbe.Image")));
            this.pictureBoxGubbe.Location = new System.Drawing.Point(66, 3);
            this.pictureBoxGubbe.Name = "pictureBoxGubbe";
            this.pictureBoxGubbe.Size = new System.Drawing.Size(157, 100);
            this.pictureBoxGubbe.TabIndex = 1;
            this.pictureBoxGubbe.TabStop = false;
            // 
            // pictureBoxMark
            // 
            this.pictureBoxMark.BackColor = System.Drawing.Color.Green;
            this.pictureBoxMark.Location = new System.Drawing.Point(3, 309);
            this.pictureBoxMark.Name = "pictureBoxMark";
            this.pictureBoxMark.Size = new System.Drawing.Size(297, 75);
            this.pictureBoxMark.TabIndex = 0;
            this.pictureBoxMark.TabStop = false;
            // 
            // textBoxVisa
            // 
            this.textBoxVisa.Enabled = false;
            this.textBoxVisa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxVisa.Location = new System.Drawing.Point(79, 558);
            this.textBoxVisa.Name = "textBoxVisa";
            this.textBoxVisa.Size = new System.Drawing.Size(300, 45);
            this.textBoxVisa.TabIndex = 3;
            // 
            // textBoxGissa
            // 
            this.textBoxGissa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGissa.Location = new System.Drawing.Point(150, 621);
            this.textBoxGissa.Name = "textBoxGissa";
            this.textBoxGissa.Size = new System.Drawing.Size(150, 45);
            this.textBoxGissa.TabIndex = 4;
            this.textBoxGissa.TextChanged += new System.EventHandler(this.textBoxGissa_TextChanged);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.Location = new System.Drawing.Point(92, 681);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(280, 41);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "Gissa på en bokstav";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 743);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxGissa);
            this.Controls.Add(this.textBoxVisa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxSvar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hänga gubbe, typ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGubbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxGubbe;
        private System.Windows.Forms.PictureBox pictureBoxMark;
        private System.Windows.Forms.TextBox textBoxVisa;
        private System.Windows.Forms.TextBox textBoxGissa;
        private System.Windows.Forms.Label labelInfo;
    }
}

