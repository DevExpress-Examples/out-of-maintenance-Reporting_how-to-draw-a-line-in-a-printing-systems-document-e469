namespace LineBrickAndDrawLine {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.ps = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.btnDrawBrick = new System.Windows.Forms.Button();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.printControl1 = new DevExpress.XtraPrinting.Control.PrintControl();
            ((System.ComponentModel.ISupportInitialize)(this.ps)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDrawBrick
            // 
            this.btnDrawBrick.Location = new System.Drawing.Point(100, 12);
            this.btnDrawBrick.Name = "btnDrawBrick";
            this.btnDrawBrick.Size = new System.Drawing.Size(82, 40);
            this.btnDrawBrick.TabIndex = 5;
            this.btnDrawBrick.Text = "DrawBrick";
            this.btnDrawBrick.UseVisualStyleBackColor = true;
            this.btnDrawBrick.Click += new System.EventHandler(this.btnDrawBrick_Click);
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.Location = new System.Drawing.Point(12, 12);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(82, 40);
            this.btnDrawLine.TabIndex = 4;
            this.btnDrawLine.Text = "DrawLine";
            this.btnDrawLine.UseVisualStyleBackColor = true;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // printControl1
            // 
            this.printControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.printControl1.ForeColor = System.Drawing.Color.White;
            this.printControl1.IsMetric = false;
            this.printControl1.Location = new System.Drawing.Point(12, 74);
            this.printControl1.Name = "printControl1";
            this.printControl1.PrintingSystem = this.ps;
            this.printControl1.Size = new System.Drawing.Size(669, 379);
            this.printControl1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 465);
            this.Controls.Add(this.printControl1);
            this.Controls.Add(this.btnDrawBrick);
            this.Controls.Add(this.btnDrawLine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPrinting.PrintingSystem ps;
        private System.Windows.Forms.Button btnDrawBrick;
        private System.Windows.Forms.Button btnDrawLine;
        private DevExpress.XtraPrinting.Control.PrintControl printControl1;
    }
}

