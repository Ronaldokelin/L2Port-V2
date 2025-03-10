
namespace L2PortsCommand
{
    partial class FormCommandLoop
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
            this.btnStartLoop = new System.Windows.Forms.Button();
            this.textBoxOpenTime = new System.Windows.Forms.TextBox();
            this.labelPortOpen = new System.Windows.Forms.Label();
            this.labelOpenTime = new System.Windows.Forms.Label();
            this.labelPortClose = new System.Windows.Forms.Label();
            this.labelCloseTime = new System.Windows.Forms.Label();
            this.textBoxCloseTime = new System.Windows.Forms.TextBox();
            this.textBoxLoopValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarOpen = new System.Windows.Forms.ProgressBar();
            this.progressBarClose = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnStartLoop
            // 
            this.btnStartLoop.Location = new System.Drawing.Point(239, 242);
            this.btnStartLoop.Name = "btnStartLoop";
            this.btnStartLoop.Size = new System.Drawing.Size(200, 35);
            this.btnStartLoop.TabIndex = 0;
            this.btnStartLoop.Text = "Start Loop";
            this.btnStartLoop.UseVisualStyleBackColor = true;
            this.btnStartLoop.Click += new System.EventHandler(this.btnStartLoop_Click);
            // 
            // textBoxOpenTime
            // 
            this.textBoxOpenTime.Location = new System.Drawing.Point(288, 16);
            this.textBoxOpenTime.Name = "textBoxOpenTime";
            this.textBoxOpenTime.Size = new System.Drawing.Size(150, 20);
            this.textBoxOpenTime.TabIndex = 1;
            this.textBoxOpenTime.Text = "2";
            // 
            // labelPortOpen
            // 
            this.labelPortOpen.AutoSize = true;
            this.labelPortOpen.Location = new System.Drawing.Point(21, 23);
            this.labelPortOpen.Name = "labelPortOpen";
            this.labelPortOpen.Size = new System.Drawing.Size(243, 13);
            this.labelPortOpen.TabIndex = 2;
            this.labelPortOpen.Text = "Set the time that should be used to open the door:";
            // 
            // labelOpenTime
            // 
            this.labelOpenTime.AutoSize = true;
            this.labelOpenTime.Location = new System.Drawing.Point(399, 70);
            this.labelOpenTime.Name = "labelOpenTime";
            this.labelOpenTime.Size = new System.Drawing.Size(12, 13);
            this.labelOpenTime.TabIndex = 3;
            this.labelOpenTime.Text = "s";
            // 
            // labelPortClose
            // 
            this.labelPortClose.AutoSize = true;
            this.labelPortClose.Location = new System.Drawing.Point(20, 113);
            this.labelPortClose.Name = "labelPortClose";
            this.labelPortClose.Size = new System.Drawing.Size(244, 13);
            this.labelPortClose.TabIndex = 4;
            this.labelPortClose.Text = "Set the time that should be used to close the door:";
            // 
            // labelCloseTime
            // 
            this.labelCloseTime.AutoSize = true;
            this.labelCloseTime.Location = new System.Drawing.Point(399, 169);
            this.labelCloseTime.Name = "labelCloseTime";
            this.labelCloseTime.Size = new System.Drawing.Size(12, 13);
            this.labelCloseTime.TabIndex = 6;
            this.labelCloseTime.Text = "s";
            // 
            // textBoxCloseTime
            // 
            this.textBoxCloseTime.Location = new System.Drawing.Point(288, 106);
            this.textBoxCloseTime.Name = "textBoxCloseTime";
            this.textBoxCloseTime.Size = new System.Drawing.Size(150, 20);
            this.textBoxCloseTime.TabIndex = 5;
            this.textBoxCloseTime.Text = "2";
            // 
            // textBoxLoopValor
            // 
            this.textBoxLoopValor.Location = new System.Drawing.Point(299, 204);
            this.textBoxLoopValor.Name = "textBoxLoopValor";
            this.textBoxLoopValor.Size = new System.Drawing.Size(140, 20);
            this.textBoxLoopValor.TabIndex = 7;
            this.textBoxLoopValor.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Set the number of turns the door should open and close:";
            // 
            // progressBarOpen
            // 
            this.progressBarOpen.Location = new System.Drawing.Point(23, 42);
            this.progressBarOpen.Name = "progressBarOpen";
            this.progressBarOpen.Size = new System.Drawing.Size(416, 25);
            this.progressBarOpen.TabIndex = 9;
            // 
            // progressBarClose
            // 
            this.progressBarClose.Location = new System.Drawing.Point(23, 141);
            this.progressBarClose.Name = "progressBarClose";
            this.progressBarClose.Size = new System.Drawing.Size(416, 25);
            this.progressBarClose.TabIndex = 10;
            // 
            // FormCommandLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 431);
            this.Controls.Add(this.progressBarClose);
            this.Controls.Add(this.progressBarOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLoopValor);
            this.Controls.Add(this.labelCloseTime);
            this.Controls.Add(this.textBoxCloseTime);
            this.Controls.Add(this.labelPortClose);
            this.Controls.Add(this.labelOpenTime);
            this.Controls.Add(this.labelPortOpen);
            this.Controls.Add(this.textBoxOpenTime);
            this.Controls.Add(this.btnStartLoop);
            this.Name = "FormCommandLoop";
            this.Text = "Port Configuration for L2AR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartLoop;
        private System.Windows.Forms.TextBox textBoxOpenTime;
        private System.Windows.Forms.Label labelPortOpen;
        private System.Windows.Forms.Label labelOpenTime;
        private System.Windows.Forms.Label labelPortClose;
        private System.Windows.Forms.Label labelCloseTime;
        private System.Windows.Forms.TextBox textBoxCloseTime;
        private System.Windows.Forms.TextBox textBoxLoopValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarOpen;
        private System.Windows.Forms.ProgressBar progressBarClose;
    }
}