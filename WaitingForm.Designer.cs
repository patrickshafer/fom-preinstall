namespace fom_waiting
{
    partial class WaitingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitingForm));
            this.fodTitle = new System.Windows.Forms.Label();
            this.fodWaiting = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.Detail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fodTitle
            // 
            this.fodTitle.AutoSize = true;
            this.fodTitle.BackColor = System.Drawing.Color.Transparent;
            this.fodTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fodTitle.ForeColor = System.Drawing.Color.White;
            this.fodTitle.Location = new System.Drawing.Point(160, 9);
            this.fodTitle.Name = "fodTitle";
            this.fodTitle.Size = new System.Drawing.Size(416, 29);
            this.fodTitle.TabIndex = 0;
            this.fodTitle.Text = "Face of Mankind: Fall of the Dominion";
            // 
            // fodWaiting
            // 
            this.fodWaiting.BackColor = System.Drawing.Color.Transparent;
            this.fodWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fodWaiting.ForeColor = System.Drawing.Color.Silver;
            this.fodWaiting.Location = new System.Drawing.Point(192, 70);
            this.fodWaiting.Name = "fodWaiting";
            this.fodWaiting.Size = new System.Drawing.Size(268, 26);
            this.fodWaiting.TabIndex = 1;
            this.fodWaiting.Text = "Welcome, Kickstarter backers!";
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.ForeColor = System.Drawing.Color.PeachPuff;
            this.BtnExit.Location = new System.Drawing.Point(12, 496);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Detail
            // 
            this.Detail.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Detail.Location = new System.Drawing.Point(149, 147);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(427, 136);
            this.Detail.TabIndex = 3;
            this.Detail.Text = resources.GetString("Detail.Text");
            // 
            // WaitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(704, 531);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.fodWaiting);
            this.Controls.Add(this.fodTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WaitingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoM: Fall of Dominion";
            this.Load += new System.EventHandler(this.WaitingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fodTitle;
        private System.Windows.Forms.Label fodWaiting;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label Detail;
    }
}

