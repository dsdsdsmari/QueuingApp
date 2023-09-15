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
            lblQueue.BackColor = SystemColors.Control;
            lblQueue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblQueue.ForeColor = Color.Black;
            lblQueue.Location = new Point(255, 127);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(20, 25);
            lblQueue.TabIndex = 7;
            lblQueue.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(194, 61);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 6;
            label2.Text = "Position in Queue";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(31, 188);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 5;
            label1.Text = "*Click to get a number";
            // 
            // btnCashier
            // 
            btnCashier.Location = new Point(31, 61);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(131, 116);
            btnCashier.TabIndex = 8;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 275);
            Controls.Add(btnCashier);
            Controls.Add(lblQueue);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QueuingForm";
            Text = "QueuingForm";
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