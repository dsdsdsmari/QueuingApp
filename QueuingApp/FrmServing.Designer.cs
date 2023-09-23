namespace QueuingApp
{
    partial class FrmServing
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
            label1 = new Label();
            lblServingNum = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 0;
            label1.Text = "*NOW SERVING";
            // 
            // lblServingNum
            // 
            lblServingNum.AutoSize = true;
            lblServingNum.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblServingNum.Location = new Point(85, 54);
            lblServingNum.Name = "lblServingNum";
            lblServingNum.Size = new Size(33, 45);
            lblServingNum.TabIndex = 1;
            lblServingNum.Text = "-";
            // 
            // FrmServing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 165);
            Controls.Add(lblServingNum);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmServing";
            Load += FrmServing_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label lblServingNum;
    }
}