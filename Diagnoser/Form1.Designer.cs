
namespace Diagnoser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.index0 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.symptoms = new System.Windows.Forms.CheckedListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.external = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(121, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dr. J. Red Cares";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(165)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 757);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.external);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.index0);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.output);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.symptoms);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(89, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 544);
            this.panel2.TabIndex = 11;
            // 
            // index0
            // 
            this.index0.AutoSize = true;
            this.index0.Location = new System.Drawing.Point(543, 500);
            this.index0.Name = "index0";
            this.index0.Size = new System.Drawing.Size(35, 13);
            this.index0.TabIndex = 16;
            this.index0.Text = "label6";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(177, 484);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Learn";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(643, 479);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(52, 29);
            this.output.TabIndex = 14;
            this.output.Text = "asd";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(275, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ask Dr. Melzi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this.label4.Location = new System.Drawing.Point(321, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(430, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Check the symptoms/ailments you have today.";
            // 
            // symptoms
            // 
            this.symptoms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.symptoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptoms.FormattingEnabled = true;
            this.symptoms.Items.AddRange(new object[] {
            "Breathing Problem\t",
            "Fever\t",
            "Dry Cough\t",
            "Sore throat\t",
            "Running Nose\t",
            "Asthma\t",
            "Chronic Lung Disease\t",
            "Headache\t",
            "Heart Disease\t",
            "Diabetes\t",
            "Hyper Tension\t",
            "Fatigue \t",
            "Gastrointestinal \t"});
            this.symptoms.Location = new System.Drawing.Point(357, 60);
            this.symptoms.Name = "symptoms";
            this.symptoms.Size = new System.Drawing.Size(397, 168);
            this.symptoms.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 296);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this.label3.Location = new System.Drawing.Point(85, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "What ails you today?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(83, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Symptom Checker";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this.label5.Location = new System.Drawing.Point(121, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "The COVID-19 Checker";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this.button2.Location = new System.Drawing.Point(686, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 49);
            this.button2.TabIndex = 14;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this.button3.Location = new System.Drawing.Point(789, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 49);
            this.button3.TabIndex = 15;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this.label6.Location = new System.Drawing.Point(321, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(456, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Check external factors you were associated with.";
            // 
            // external
            // 
            this.external.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.external.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.external.FormattingEnabled = true;
            this.external.Items.AddRange(new object[] {
            "Abroad travel\t",
            "Contact with COVID Patient\t",
            "Attended Large Gathering\t",
            "Visited Public Exposed Places\t",
            "Family working in Public Exposed Places\t",
            "Wearing Masks\t",
            "Sanitization from Market\t"});
            this.external.Location = new System.Drawing.Point(357, 291);
            this.external.Name = "external";
            this.external.Size = new System.Drawing.Size(397, 168);
            this.external.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 882);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox symptoms;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label index0;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox external;
    }
}

