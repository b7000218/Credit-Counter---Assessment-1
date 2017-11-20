namespace Credit_Counter
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
            this.groupBox_Coins_Entered = new System.Windows.Forms.GroupBox();
            this.groupBox_Coins = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBox_Coins_Entered
            // 
            this.groupBox_Coins_Entered.BackColor = System.Drawing.Color.White;
            this.groupBox_Coins_Entered.Location = new System.Drawing.Point(503, 2);
            this.groupBox_Coins_Entered.Name = "groupBox_Coins_Entered";
            this.groupBox_Coins_Entered.Size = new System.Drawing.Size(152, 303);
            this.groupBox_Coins_Entered.TabIndex = 0;
            this.groupBox_Coins_Entered.TabStop = false;
            this.groupBox_Coins_Entered.Text = "Coins Entered";
            // 
            // groupBox_Coins
            // 
            this.groupBox_Coins.BackColor = System.Drawing.Color.White;
            this.groupBox_Coins.Location = new System.Drawing.Point(10, 7);
            this.groupBox_Coins.Name = "groupBox_Coins";
            this.groupBox_Coins.Size = new System.Drawing.Size(269, 288);
            this.groupBox_Coins.TabIndex = 1;
            this.groupBox_Coins.TabStop = false;
            this.groupBox_Coins.Text = "Coins";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(658, 307);
            this.Controls.Add(this.groupBox_Coins);
            this.Controls.Add(this.groupBox_Coins_Entered);
            this.Name = "Form1";
            this.Text = "Money Counter v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Coins_Entered;
        private System.Windows.Forms.GroupBox groupBox_Coins;
    }
}

