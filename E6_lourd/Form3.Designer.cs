namespace E6_lourd
{
    partial class Form3
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(19, 132);
            button1.Name = "button1";
            button1.Size = new Size(109, 48);
            button1.TabIndex = 0;
            button1.Text = "Modifier";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnModify_Click;
            // 
            // button2
            // 
            button2.Location = new Point(145, 132);
            button2.Name = "button2";
            button2.Size = new Size(109, 48);
            button2.TabIndex = 1;
            button2.Text = "Annuler";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCancel_Click;
            // 
            // button3
            // 
            button3.Location = new Point(19, 210);
            button3.Name = "button3";
            button3.Size = new Size(109, 48);
            button3.TabIndex = 2;
            button3.Text = "Ajouter";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnAdd_Click;
            // 
            // button4
            // 
            button4.Location = new Point(145, 210);
            button4.Name = "button4";
            button4.Size = new Size(109, 48);
            button4.TabIndex = 3;
            button4.Text = "Supprimer";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnDelete_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Silver;
            flowLayoutPanel1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(275, 57);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(513, 366);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}