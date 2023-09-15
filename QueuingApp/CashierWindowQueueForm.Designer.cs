﻿namespace QueuingApp
{
    partial class CashierWindowQueue
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
            btnRefresh = new Button();
            btnNext = new Button();
            listCashierQueue = new ListView();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(12, 14);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 31);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.Control;
            btnNext.ForeColor = SystemColors.ControlText;
            btnNext.Location = new Point(12, 51);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(116, 31);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // listCashierQueue
            // 
            listCashierQueue.Location = new Point(133, 16);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(193, 233);
            listCashierQueue.TabIndex = 2;
            listCashierQueue.UseCompatibleStateImageBehavior = false;
            // 
            // CashierWindowQueue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 261);
            Controls.Add(listCashierQueue);
            Controls.Add(btnNext);
            Controls.Add(btnRefresh);
            Name = "CashierWindowQueue";
            Text = "CashierWindowQueueForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private Button btnNext;
        private ListView listCashierQueue;
    }
}