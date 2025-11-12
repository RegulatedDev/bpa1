namespace CS_330_____
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
            exitButton = new Button();
            tabControl1 = new TabControl();
            unitTabs = new TabPage();
            gallonBox = new TextBox();
            quartBox = new TextBox();
            pintBox = new TextBox();
            literBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            weightPage = new TabPage();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            kgBox = new TextBox();
            ounceBox = new TextBox();
            tonBox = new TextBox();
            poundBox = new TextBox();
            tabControl1.SuspendLayout();
            unitTabs.SuspendLayout();
            weightPage.SuspendLayout();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(93, 300);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 0;
            exitButton.Text = "exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(unitTabs);
            tabControl1.Controls.Add(weightPage);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(244, 275);
            tabControl1.TabIndex = 1;
            tabControl1.KeyPress += tabControl1_KeyPress;
            // 
            // unitTabs
            // 
            unitTabs.Controls.Add(gallonBox);
            unitTabs.Controls.Add(quartBox);
            unitTabs.Controls.Add(pintBox);
            unitTabs.Controls.Add(literBox);
            unitTabs.Controls.Add(label4);
            unitTabs.Controls.Add(label3);
            unitTabs.Controls.Add(label2);
            unitTabs.Controls.Add(label1);
            unitTabs.Location = new Point(4, 24);
            unitTabs.Name = "unitTabs";
            unitTabs.Padding = new Padding(3);
            unitTabs.Size = new Size(236, 247);
            unitTabs.TabIndex = 0;
            unitTabs.Text = "Volume";
            unitTabs.UseVisualStyleBackColor = true;
            // 
            // gallonBox
            // 
            gallonBox.Location = new Point(64, 147);
            gallonBox.Name = "gallonBox";
            gallonBox.Size = new Size(100, 23);
            gallonBox.TabIndex = 7;
            // 
            // quartBox
            // 
            quartBox.Location = new Point(64, 103);
            quartBox.Name = "quartBox";
            quartBox.Size = new Size(100, 23);
            quartBox.TabIndex = 6;
            // 
            // pintBox
            // 
            pintBox.Location = new Point(64, 59);
            pintBox.Name = "pintBox";
            pintBox.Size = new Size(100, 23);
            pintBox.TabIndex = 5;
            // 
            // literBox
            // 
            literBox.Location = new Point(64, 15);
            literBox.Name = "literBox";
            literBox.Size = new Size(100, 23);
            literBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 173);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Gallon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 129);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Quart:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 85);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Pint:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 41);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Liter:";
            // 
            // weightPage
            // 
            weightPage.Controls.Add(label8);
            weightPage.Controls.Add(label7);
            weightPage.Controls.Add(label6);
            weightPage.Controls.Add(label5);
            weightPage.Controls.Add(kgBox);
            weightPage.Controls.Add(ounceBox);
            weightPage.Controls.Add(tonBox);
            weightPage.Controls.Add(poundBox);
            weightPage.Location = new Point(4, 24);
            weightPage.Name = "weightPage";
            weightPage.Padding = new Padding(3);
            weightPage.Size = new Size(236, 247);
            weightPage.TabIndex = 1;
            weightPage.Text = "Weight";
            weightPage.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(109, 179);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 7;
            label8.Text = "Ton:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(105, 135);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 6;
            label7.Text = "Ounce:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 91);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 5;
            label6.Text = "Kilogram:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 47);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 4;
            label5.Text = "Pound:";
            // 
            // kgBox
            // 
            kgBox.Location = new Point(72, 65);
            kgBox.Name = "kgBox";
            kgBox.Size = new Size(100, 23);
            kgBox.TabIndex = 3;
            // 
            // ounceBox
            // 
            ounceBox.Location = new Point(72, 109);
            ounceBox.Name = "ounceBox";
            ounceBox.Size = new Size(100, 23);
            ounceBox.TabIndex = 2;
            // 
            // tonBox
            // 
            tonBox.Location = new Point(72, 153);
            tonBox.Name = "tonBox";
            tonBox.Size = new Size(100, 23);
            tonBox.TabIndex = 1;
            // 
            // poundBox
            // 
            poundBox.Location = new Point(72, 21);
            poundBox.Name = "poundBox";
            poundBox.Size = new Size(100, 23);
            poundBox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 358);
            ControlBox = false;
            Controls.Add(tabControl1);
            Controls.Add(exitButton);
            Name = "Form1";
            Text = "Unit Conversion Utility";
            FormClosing += Form1_FormClosing;
            tabControl1.ResumeLayout(false);
            unitTabs.ResumeLayout(false);
            unitTabs.PerformLayout();
            weightPage.ResumeLayout(false);
            weightPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button exitButton;
        private TabControl tabControl1;
        private TabPage unitTabs;
        private TabPage weightPage;
        private TextBox gallonBox;
        private TextBox quartBox;
        private TextBox pintBox;
        private TextBox literBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox kgBox;
        private TextBox ounceBox;
        private TextBox tonBox;
        private TextBox poundBox;
    }
}
