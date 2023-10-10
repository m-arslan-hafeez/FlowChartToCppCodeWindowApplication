namespace Graphics_Test
{
    partial class MainForm
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
            this.button_circle = new System.Windows.Forms.Button();
            this.button_Rect = new System.Windows.Forms.Button();
            this.button_EndCircle = new System.Windows.Forms.Button();
            this.button_Pargram = new System.Windows.Forms.Button();
            this.button_PargramScan = new System.Windows.Forms.Button();
            this.PargramPrint = new System.Windows.Forms.Button();
            this.Condition = new System.Windows.Forms.Button();
            this.forLoop = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.viewCode = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_circle
            // 
            this.button_circle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_circle.Location = new System.Drawing.Point(12, 8);
            this.button_circle.Name = "button_circle";
            this.button_circle.Size = new System.Drawing.Size(149, 29);
            this.button_circle.TabIndex = 0;
            this.button_circle.Text = "Start Program";
            this.button_circle.UseVisualStyleBackColor = false;
            this.button_circle.Click += new System.EventHandler(this.button_circle_Click);
            // 
            // button_Rect
            // 
            this.button_Rect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Rect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Rect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Rect.Location = new System.Drawing.Point(12, 124);
            this.button_Rect.Name = "button_Rect";
            this.button_Rect.Size = new System.Drawing.Size(149, 33);
            this.button_Rect.TabIndex = 1;
            this.button_Rect.Text = "Process";
            this.button_Rect.UseVisualStyleBackColor = false;
            this.button_Rect.Click += new System.EventHandler(this.button_Rect_Click);
            // 
            // button_EndCircle
            // 
            this.button_EndCircle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_EndCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EndCircle.Location = new System.Drawing.Point(12, 290);
            this.button_EndCircle.Name = "button_EndCircle";
            this.button_EndCircle.Size = new System.Drawing.Size(149, 40);
            this.button_EndCircle.TabIndex = 2;
            this.button_EndCircle.Text = "End Program";
            this.button_EndCircle.UseVisualStyleBackColor = false;
            this.button_EndCircle.Click += new System.EventHandler(this.button_EndCircle_Click);
            // 
            // button_Pargram
            // 
            this.button_Pargram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Pargram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pargram.Location = new System.Drawing.Point(12, 43);
            this.button_Pargram.Name = "button_Pargram";
            this.button_Pargram.Size = new System.Drawing.Size(149, 34);
            this.button_Pargram.TabIndex = 3;
            this.button_Pargram.Text = "Variables";
            this.button_Pargram.UseVisualStyleBackColor = false;
            this.button_Pargram.Click += new System.EventHandler(this.button_Pargram_Click);
            // 
            // button_PargramScan
            // 
            this.button_PargramScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_PargramScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PargramScan.Location = new System.Drawing.Point(12, 83);
            this.button_PargramScan.Name = "button_PargramScan";
            this.button_PargramScan.Size = new System.Drawing.Size(149, 35);
            this.button_PargramScan.TabIndex = 4;
            this.button_PargramScan.Text = "Read Variables";
            this.button_PargramScan.UseVisualStyleBackColor = false;
            this.button_PargramScan.Click += new System.EventHandler(this.button_PargramScan_Click);
            // 
            // PargramPrint
            // 
            this.PargramPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PargramPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PargramPrint.Location = new System.Drawing.Point(12, 249);
            this.PargramPrint.Name = "PargramPrint";
            this.PargramPrint.Size = new System.Drawing.Size(149, 35);
            this.PargramPrint.TabIndex = 5;
            this.PargramPrint.Text = "Print";
            this.PargramPrint.UseVisualStyleBackColor = false;
            this.PargramPrint.Click += new System.EventHandler(this.PargramPrint_Click);
            // 
            // Condition
            // 
            this.Condition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Condition.Location = new System.Drawing.Point(12, 163);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(149, 37);
            this.Condition.TabIndex = 6;
            this.Condition.Text = "Condition";
            this.Condition.UseVisualStyleBackColor = false;
            this.Condition.Click += new System.EventHandler(this.Condition_Click);
            // 
            // forLoop
            // 
            this.forLoop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.forLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forLoop.Location = new System.Drawing.Point(12, 206);
            this.forLoop.Name = "forLoop";
            this.forLoop.Size = new System.Drawing.Size(149, 37);
            this.forLoop.TabIndex = 7;
            this.forLoop.Text = "For Loop";
            this.forLoop.UseVisualStyleBackColor = false;
            this.forLoop.Click += new System.EventHandler(this.forLoop_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(12, 349);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(149, 33);
            this.Edit.TabIndex = 8;
            this.Edit.Text = "Edit Node";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // viewCode
            // 
            this.viewCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.viewCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCode.Location = new System.Drawing.Point(12, 388);
            this.viewCode.Name = "viewCode";
            this.viewCode.Size = new System.Drawing.Size(149, 31);
            this.viewCode.TabIndex = 9;
            this.viewCode.Text = "Generate Code";
            this.viewCode.UseVisualStyleBackColor = false;
            this.viewCode.Click += new System.EventHandler(this.viewCode_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(12, 425);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(149, 33);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "Reset All";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(844, 479);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.viewCode);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.forLoop);
            this.Controls.Add(this.Condition);
            this.Controls.Add(this.PargramPrint);
            this.Controls.Add(this.button_PargramScan);
            this.Controls.Add(this.button_Pargram);
            this.Controls.Add(this.button_EndCircle);
            this.Controls.Add(this.button_Rect);
            this.Controls.Add(this.button_circle);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_circle;
        private System.Windows.Forms.Button button_Rect;
        private System.Windows.Forms.Button button_EndCircle;
        private System.Windows.Forms.Button button_Pargram;
        private System.Windows.Forms.Button button_PargramScan;
        private System.Windows.Forms.Button PargramPrint;
        private System.Windows.Forms.Button Condition;
        private System.Windows.Forms.Button forLoop;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button viewCode;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Reset;
    }
}

