namespace Project_PRG2782_WMalan_EWalters_JBlignaut.Presentation_Layer
{
    partial class ManagingInfo
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
            this.btnManagingStudent = new System.Windows.Forms.Button();
            this.btnManagingModule = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 33);
            this.label1.TabIndex = 22;
            this.label1.Text = "Managing Info";
            // 
            // btnManagingStudent
            // 
            this.btnManagingStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnManagingStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagingStudent.ForeColor = System.Drawing.Color.White;
            this.btnManagingStudent.Location = new System.Drawing.Point(22, 82);
            this.btnManagingStudent.Name = "btnManagingStudent";
            this.btnManagingStudent.Size = new System.Drawing.Size(154, 55);
            this.btnManagingStudent.TabIndex = 23;
            this.btnManagingStudent.Text = "Managing Student Info";
            this.btnManagingStudent.UseVisualStyleBackColor = false;
            this.btnManagingStudent.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnManagingModule
            // 
            this.btnManagingModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.btnManagingModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagingModule.ForeColor = System.Drawing.Color.White;
            this.btnManagingModule.Location = new System.Drawing.Point(230, 82);
            this.btnManagingModule.Name = "btnManagingModule";
            this.btnManagingModule.Size = new System.Drawing.Size(154, 55);
            this.btnManagingModule.TabIndex = 24;
            this.btnManagingModule.Text = "Managing Module Info";
            this.btnManagingModule.UseVisualStyleBackColor = false;
            this.btnManagingModule.Click += new System.EventHandler(this.btnManagingModule_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(230, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 55);
            this.button1.TabIndex = 25;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(22, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 55);
            this.button2.TabIndex = 26;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ManagingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 285);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnManagingModule);
            this.Controls.Add(this.btnManagingStudent);
            this.Controls.Add(this.label1);
            this.Name = "ManagingInfo";
            this.Text = "ManagingInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManagingStudent;
        private System.Windows.Forms.Button btnManagingModule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}