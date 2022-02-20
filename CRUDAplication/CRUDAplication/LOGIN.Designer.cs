namespace CRUDAplication
{
    partial class LOGIN
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
            this.Userbox = new System.Windows.Forms.TextBox();
            this.Emailbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 230);
            this.label1.MinimumSize = new System.Drawing.Size(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            // 
            // Userbox
            // 
            this.Userbox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Userbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Userbox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Userbox.Location = new System.Drawing.Point(219, 349);
            this.Userbox.Multiline = true;
            this.Userbox.Name = "Userbox";
            this.Userbox.Size = new System.Drawing.Size(188, 34);
            this.Userbox.TabIndex = 1;
            this.Userbox.Text = "Username";
            this.Userbox.Enter += new System.EventHandler(this.Userbox_Enter);
            this.Userbox.Leave += new System.EventHandler(this.Userbox_Leave);
            // 
            // Emailbox
            // 
            this.Emailbox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Emailbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Emailbox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Emailbox.Location = new System.Drawing.Point(219, 410);
            this.Emailbox.Multiline = true;
            this.Emailbox.Name = "Emailbox";
            this.Emailbox.Size = new System.Drawing.Size(188, 34);
            this.Emailbox.TabIndex = 2;
            this.Emailbox.Text = "add@yahoo.com";
            this.Emailbox.TextChanged += new System.EventHandler(this.Emailbox_TextChanged);
            this.Emailbox.Enter += new System.EventHandler(this.Emailbox_Enter);
            this.Emailbox.Leave += new System.EventHandler(this.Emailbox_leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(253, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(746, 9);
            this.label2.MinimumSize = new System.Drawing.Size(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CRUDAplication.Properties.Resources.d7c3412d99205b3a27faf60a713c3aa6;
            this.ClientSize = new System.Drawing.Size(797, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Emailbox);
            this.Controls.Add(this.Userbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Userbox;
        private System.Windows.Forms.TextBox Emailbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}