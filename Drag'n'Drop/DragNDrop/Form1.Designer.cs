namespace DragNDrop
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dragBox1 = new DragBox.DragBox();
            this.dragLabel1 = new DragBox.DragLabel();
            this.dragLabel2 = new DragBox.DragLabel();
            this.SuspendLayout();
            // 
            // dragBox1
            // 
            this.dragBox1.BackColor = System.Drawing.Color.White;
            this.dragBox1.Color = System.Drawing.Color.White;
            this.dragBox1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dragBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.dragBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.dragBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dragBox1.Location = new System.Drawing.Point(219, 68);
            this.dragBox1.Name = "dragBox1";
            this.dragBox1.Size = new System.Drawing.Size(91, 41);
            this.dragBox1.TabIndex = 4;
            this.dragBox1.UseVisualStyleBackColor = false;
            // 
            // dragLabel1
            // 
            this.dragLabel1.AutoSize = true;
            this.dragLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dragLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragLabel1.ForeColor = System.Drawing.Color.White;
            this.dragLabel1.LastLocation = new System.Drawing.Point(0, 0);
            this.dragLabel1.LinkedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(13)))));
            this.dragLabel1.Location = new System.Drawing.Point(377, 115);
            this.dragLabel1.Name = "dragLabel1";
            this.dragLabel1.NormalColor = System.Drawing.Color.Empty;
            this.dragLabel1.Size = new System.Drawing.Size(59, 25);
            this.dragLabel1.TabIndex = 5;
            this.dragLabel1.Text = "Item1";
            this.dragLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dragLabel2
            // 
            this.dragLabel2.AutoSize = true;
            this.dragLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dragLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragLabel2.ForeColor = System.Drawing.Color.White;
            this.dragLabel2.LastLocation = new System.Drawing.Point(0, 0);
            this.dragLabel2.LinkedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(13)))));
            this.dragLabel2.Location = new System.Drawing.Point(237, 156);
            this.dragLabel2.Name = "dragLabel2";
            this.dragLabel2.NormalColor = System.Drawing.Color.Empty;
            this.dragLabel2.Size = new System.Drawing.Size(59, 25);
            this.dragLabel2.TabIndex = 6;
            this.dragLabel2.Text = "Item2";
            this.dragLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(533, 336);
            this.Controls.Add(this.dragLabel2);
            this.Controls.Add(this.dragLabel1);
            this.Controls.Add(this.dragBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private DragBox.DragBox dragBox1;
        private DragBox.DragLabel dragLabel1;
        private DragBox.DragLabel dragLabel2;
    }
}

