namespace WindowsFormsApp1
{
    partial class LoginUserType
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
            this.rdbGeneral = new System.Windows.Forms.RadioButton();
            this.rdbStudent = new System.Windows.Forms.RadioButton();
            this.rdbPolice = new System.Windows.Forms.RadioButton();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your log in user type";
            // 
            // rdbGeneral
            // 
            this.rdbGeneral.AutoSize = true;
            this.rdbGeneral.Location = new System.Drawing.Point(209, 86);
            this.rdbGeneral.Name = "rdbGeneral";
            this.rdbGeneral.Size = new System.Drawing.Size(62, 17);
            this.rdbGeneral.TabIndex = 1;
            this.rdbGeneral.TabStop = true;
            this.rdbGeneral.Text = "General";
            this.rdbGeneral.UseVisualStyleBackColor = true;
            this.rdbGeneral.CheckedChanged += new System.EventHandler(this.rdbGeneral_CheckedChanged);
            // 
            // rdbStudent
            // 
            this.rdbStudent.AutoSize = true;
            this.rdbStudent.Location = new System.Drawing.Point(284, 86);
            this.rdbStudent.Name = "rdbStudent";
            this.rdbStudent.Size = new System.Drawing.Size(62, 17);
            this.rdbStudent.TabIndex = 2;
            this.rdbStudent.TabStop = true;
            this.rdbStudent.Text = "Student";
            this.rdbStudent.UseVisualStyleBackColor = true;
            // 
            // rdbPolice
            // 
            this.rdbPolice.AutoSize = true;
            this.rdbPolice.Location = new System.Drawing.Point(364, 86);
            this.rdbPolice.Name = "rdbPolice";
            this.rdbPolice.Size = new System.Drawing.Size(54, 17);
            this.rdbPolice.TabIndex = 3;
            this.rdbPolice.TabStop = true;
            this.rdbPolice.Text = "Police";
            this.rdbPolice.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGo.ForeColor = System.Drawing.Color.Black;
            this.btnGo.Location = new System.Drawing.Point(237, 127);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(129, 31);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // LoginUserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(587, 241);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.rdbPolice);
            this.Controls.Add(this.rdbStudent);
            this.Controls.Add(this.rdbGeneral);
            this.Controls.Add(this.label1);
            this.Name = "LoginUserType";
            this.Text = "SearchResult";
            this.Load += new System.EventHandler(this.SearchResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbGeneral;
        private System.Windows.Forms.RadioButton rdbStudent;
        private System.Windows.Forms.RadioButton rdbPolice;
        private System.Windows.Forms.Button btnGo;
    }
}