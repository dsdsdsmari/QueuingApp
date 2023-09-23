namespace QueuingApp
{
    partial class QueuingForm
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
            lblQueue = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCashier = new Button();
            SuspendLayout();
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.BackColor = Color.Transparent;
            lblQueue.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblQueue.ForeColor = Color.Black;
            lblQueue.Location = new Point(198, 105);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(0, 37);
            lblQueue.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(175, 76);
            label2.Name = "label2";
            label2.Size = new Size(147, 22);
            label2.TabIndex = 6;
            label2.Text = "Position in Queue:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(28, 180);
            label1.Name = "label1";
            label1.Size = new Size(136, 18);
            label1.TabIndex = 5;
            label1.Text = "*Click to get a number";
            // 
            // btnCashier
            // 
            btnCashier.BackColor = Color.SteelBlue;
            btnCashier.Cursor = Cursors.Hand;
            btnCashier.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btnCashier.ForeColor = Color.Black;
            btnCashier.Location = new Point(31, 61);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(131, 116);
            btnCashier.TabIndex = 8;
            btnCashier.Text = "Cashier No.";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(387, 275);
            Controls.Add(btnCashier);
            Controls.Add(lblQueue);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QueuingForm";
            Text = "Queuing App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQueue;
        private Label label2;
        private Label label1;
        private Button btnCashier;
    }
}