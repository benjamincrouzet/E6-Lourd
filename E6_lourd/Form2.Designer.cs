namespace E6_lourd
{
    partial class Form2
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
            NomDesTables = new CheckedListBox();
            button1 = new Button();
            AffichageDeLaTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)AffichageDeLaTable).BeginInit();
            SuspendLayout();
            // 
            // NomDesTables
            // 
            NomDesTables.FormattingEnabled = true;
            NomDesTables.Location = new Point(12, 12);
            NomDesTables.Name = "NomDesTables";
            NomDesTables.Size = new Size(120, 94);
            NomDesTables.TabIndex = 0;
            NomDesTables.SelectedIndexChanged += NomDesTables_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 112);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 1;
            button1.Text = "Gérer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AffichageDeLaTable
            // 
            AffichageDeLaTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AffichageDeLaTable.Location = new Point(151, 12);
            AffichageDeLaTable.Name = "AffichageDeLaTable";
            AffichageDeLaTable.Size = new Size(526, 310);
            AffichageDeLaTable.TabIndex = 2;
            AffichageDeLaTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AffichageDeLaTable);
            Controls.Add(button1);
            Controls.Add(NomDesTables);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)AffichageDeLaTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox NomDesTables;
        private Button button1;
        private DataGridView AffichageDeLaTable;
    }
}