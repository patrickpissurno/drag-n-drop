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
            this.draggableItem1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dragBox1 = new DragBox.DragBox();
            this.SuspendLayout();
            // 
            // draggableItem1
            // 
            this.draggableItem1.AutoSize = true;
            this.draggableItem1.BackColor = System.Drawing.Color.Transparent;
            this.draggableItem1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draggableItem1.ForeColor = System.Drawing.Color.White;
            this.draggableItem1.Location = new System.Drawing.Point(308, 173);
            this.draggableItem1.Name = "draggableItem1";
            this.draggableItem1.Size = new System.Drawing.Size(64, 25);
            this.draggableItem1.TabIndex = 1;
            this.draggableItem1.Tag = "draggable";
            this.draggableItem1.Text = "Item 1";
            this.draggableItem1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 3;
            this.label1.Tag = "draggable";
            this.label1.Text = "Item 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(533, 336);
            this.Controls.Add(this.dragBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.draggableItem1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label draggableItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private DragBox.DragBox dragBox1;
    }
}

