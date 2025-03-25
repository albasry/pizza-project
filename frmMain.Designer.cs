namespace PizzaProject
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnMainStart = new System.Windows.Forms.Button();
            this.btnMainExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMainStart
            // 
            this.btnMainStart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnMainStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainStart.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainStart.ForeColor = System.Drawing.Color.White;
            this.btnMainStart.Location = new System.Drawing.Point(493, 412);
            this.btnMainStart.Name = "btnMainStart";
            this.btnMainStart.Size = new System.Drawing.Size(67, 47);
            this.btnMainStart.TabIndex = 0;
            this.btnMainStart.Text = "Pizza";
            this.btnMainStart.UseVisualStyleBackColor = false;
            this.btnMainStart.Click += new System.EventHandler(this.btnMainStart_Click);
            // 
            // btnMainExit
            // 
            this.btnMainExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMainExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainExit.Font = new System.Drawing.Font("Cooper Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainExit.ForeColor = System.Drawing.Color.White;
            this.btnMainExit.Location = new System.Drawing.Point(566, 412);
            this.btnMainExit.Name = "btnMainExit";
            this.btnMainExit.Size = new System.Drawing.Size(67, 47);
            this.btnMainExit.TabIndex = 1;
            this.btnMainExit.Text = "Exit";
            this.btnMainExit.UseVisualStyleBackColor = false;
            this.btnMainExit.Click += new System.EventHandler(this.btnMainExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaProject.Properties.Resources.MainForm;
            this.ClientSize = new System.Drawing.Size(709, 471);
            this.Controls.Add(this.btnMainExit);
            this.Controls.Add(this.btnMainStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainStart;
        private System.Windows.Forms.Button btnMainExit;
    }
}

