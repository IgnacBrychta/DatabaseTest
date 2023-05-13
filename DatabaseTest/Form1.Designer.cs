namespace DatabaseTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_executeScript = new Button();
            comboBox_scripts = new ComboBox();
            label_volbaSkriptu = new Label();
            groupBox1 = new GroupBox();
            richTextBox_queryResult = new RichTextBox();
            groupBox2 = new GroupBox();
            dataGridView_scriptResult = new DataGridView();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_scriptResult).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button_executeScript
            // 
            button_executeScript.Location = new Point(1738, 31);
            button_executeScript.Name = "button_executeScript";
            button_executeScript.Size = new Size(377, 40);
            button_executeScript.TabIndex = 0;
            button_executeScript.Text = "Provést";
            button_executeScript.UseVisualStyleBackColor = true;
            button_executeScript.Click += button_executeScript_Click;
            // 
            // comboBox_scripts
            // 
            comboBox_scripts.FormattingEnabled = true;
            comboBox_scripts.Location = new Point(163, 32);
            comboBox_scripts.Name = "comboBox_scripts";
            comboBox_scripts.Size = new Size(1569, 40);
            comboBox_scripts.TabIndex = 1;
            // 
            // label_volbaSkriptu
            // 
            label_volbaSkriptu.AutoSize = true;
            label_volbaSkriptu.Location = new Point(6, 35);
            label_volbaSkriptu.Name = "label_volbaSkriptu";
            label_volbaSkriptu.Size = new Size(151, 32);
            label_volbaSkriptu.TabIndex = 2;
            label_volbaSkriptu.Text = "Zvolte skript:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_volbaSkriptu);
            groupBox1.Controls.Add(button_executeScript);
            groupBox1.Controls.Add(comboBox_scripts);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2121, 115);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // richTextBox_queryResult
            // 
            richTextBox_queryResult.Location = new Point(6, 38);
            richTextBox_queryResult.Name = "richTextBox_queryResult";
            richTextBox_queryResult.Size = new Size(1160, 806);
            richTextBox_queryResult.TabIndex = 4;
            richTextBox_queryResult.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox_queryResult);
            groupBox2.Location = new Point(29, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1189, 850);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Textový výsledek";
            groupBox2.Visible = false;
            // 
            // dataGridView_scriptResult
            // 
            dataGridView_scriptResult.AllowUserToDeleteRows = false;
            dataGridView_scriptResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_scriptResult.Location = new Point(6, 38);
            dataGridView_scriptResult.Name = "dataGridView_scriptResult";
            dataGridView_scriptResult.ReadOnly = true;
            dataGridView_scriptResult.RowHeadersWidth = 82;
            dataGridView_scriptResult.RowTemplate.Height = 41;
            dataGridView_scriptResult.Size = new Size(2103, 784);
            dataGridView_scriptResult.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView_scriptResult);
            groupBox3.Location = new Point(12, 110);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(2115, 828);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tabulkový výsledek";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(2145, 1004);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "DatabazeTest";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_scriptResult).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button_executeScript;
        private ComboBox comboBox_scripts;
        private Label label_volbaSkriptu;
        private GroupBox groupBox1;
        private RichTextBox richTextBox_queryResult;
        private GroupBox groupBox2;
        private DataGridView dataGridView_scriptResult;
        private GroupBox groupBox3;
    }
}