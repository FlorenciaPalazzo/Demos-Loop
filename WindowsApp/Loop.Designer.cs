namespace WindowsApp
{
    partial class Loop
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
            this.btnLoop_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoop_Click
            // 
            this.btnLoop_Click.Location = new System.Drawing.Point(225, 78);
            this.btnLoop_Click.Name = "btnLoop_Click";
            this.btnLoop_Click.Size = new System.Drawing.Size(75, 23);
            this.btnLoop_Click.TabIndex = 0;
            this.btnLoop_Click.Text = "Mostrar";
            this.btnLoop_Click.UseVisualStyleBackColor = true;
            this.btnLoop_Click.Click += new System.EventHandler(this.btnLoop_Click_Click);
            // 
            // Loop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 201);
            this.Controls.Add(this.btnLoop_Click);
            this.Name = "Loop";
            this.Text = "Loop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoop_Click;
    }
}