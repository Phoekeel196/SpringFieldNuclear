namespace SpringFieldNuclear
{
    partial class Form1
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
            this.MasterLabel = new System.Windows.Forms.Label();
            this.Reactor1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Reactor2 = new System.Windows.Forms.Label();
            this.LeftBlue = new System.Windows.Forms.Label();
            this.RightBlue = new System.Windows.Forms.Label();
            this.Calm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MasterLabel
            // 
            this.MasterLabel.AccessibleDescription = "Title Label";
            this.MasterLabel.AutoSize = true;
            this.MasterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasterLabel.Location = new System.Drawing.Point(186, 18);
            this.MasterLabel.Name = "MasterLabel";
            this.MasterLabel.Size = new System.Drawing.Size(427, 44);
            this.MasterLabel.TabIndex = 0;
            this.MasterLabel.Text = "Nuclear Reactor Control";
            // 
            // Reactor1
            // 
            this.Reactor1.AccessibleDescription = "Reactor1";
            this.Reactor1.AccessibleName = "Reactor1";
            this.Reactor1.AutoSize = true;
            this.Reactor1.Font = new System.Drawing.Font("Millenium BdEx BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor1.Location = new System.Drawing.Point(152, 108);
            this.Reactor1.Name = "Reactor1";
            this.Reactor1.Size = new System.Drawing.Size(195, 30);
            this.Reactor1.TabIndex = 1;
            this.Reactor1.Text = "Reactor 1";
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "button 1";
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(353, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 111);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dont Push The Button";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Reactor2
            // 
            this.Reactor2.AccessibleDescription = "Reactor2";
            this.Reactor2.Font = new System.Drawing.Font("Millenium BdEx BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reactor2.Location = new System.Drawing.Point(456, 108);
            this.Reactor2.Name = "Reactor2";
            this.Reactor2.Size = new System.Drawing.Size(208, 30);
            this.Reactor2.TabIndex = 6;
            this.Reactor2.Text = "Reactor 2";
            // 
            // LeftBlue
            // 
            this.LeftBlue.BackColor = System.Drawing.Color.Blue;
            this.LeftBlue.Location = new System.Drawing.Point(154, 160);
            this.LeftBlue.Name = "LeftBlue";
            this.LeftBlue.Size = new System.Drawing.Size(195, 195);
            this.LeftBlue.TabIndex = 7;
            // 
            // RightBlue
            // 
            this.RightBlue.BackColor = System.Drawing.Color.Blue;
            this.RightBlue.Location = new System.Drawing.Point(456, 160);
            this.RightBlue.Name = "RightBlue";
            this.RightBlue.Size = new System.Drawing.Size(195, 195);
            this.RightBlue.TabIndex = 8;
            // 
            // Calm
            // 
            this.Calm.AutoSize = true;
            this.Calm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calm.Location = new System.Drawing.Point(176, 395);
            this.Calm.Name = "Calm";
            this.Calm.Size = new System.Drawing.Size(0, 31);
            this.Calm.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calm);
            this.Controls.Add(this.RightBlue);
            this.Controls.Add(this.LeftBlue);
            this.Controls.Add(this.Reactor2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Reactor1);
            this.Controls.Add(this.MasterLabel);
            this.Name = "Form1";
            this.Text = "SpringFieldNuclearPowerPlant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MasterLabel;
        private System.Windows.Forms.Label Reactor1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Reactor2;
        private System.Windows.Forms.Label LeftBlue;
        private System.Windows.Forms.Label RightBlue;
        private System.Windows.Forms.Label Calm;
    }
}

