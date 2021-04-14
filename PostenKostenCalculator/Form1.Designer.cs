namespace PostenKostenCalculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.UitslagValue = new System.Windows.Forms.Label();
            this.uitslagText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UD_end = new System.Windows.Forms.NumericUpDown();
            this.UD_Start = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UD_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_Start)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 109);
            this.button1.TabIndex = 15;
            this.button1.Text = "Update!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UitslagValue
            // 
            this.UitslagValue.AutoSize = true;
            this.UitslagValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UitslagValue.Location = new System.Drawing.Point(92, 295);
            this.UitslagValue.Name = "UitslagValue";
            this.UitslagValue.Size = new System.Drawing.Size(671, 95);
            this.UitslagValue.TabIndex = 14;
            this.UitslagValue.Text = "Voer waardes in!";
            // 
            // uitslagText
            // 
            this.uitslagText.AutoSize = true;
            this.uitslagText.Location = new System.Drawing.Point(57, 224);
            this.uitslagText.Name = "uitslagText";
            this.uitslagText.Size = new System.Drawing.Size(308, 17);
            this.uitslagText.TabIndex = 13;
            this.uitslagText.Text = "Het bouwen van de opgegeven gebouwen kost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "tot en met";
            // 
            // UD_end
            // 
            this.UD_end.Location = new System.Drawing.Point(413, 104);
            this.UD_end.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UD_end.Name = "UD_end";
            this.UD_end.Size = new System.Drawing.Size(120, 22);
            this.UD_end.TabIndex = 11;
            this.UD_end.ValueChanged += new System.EventHandler(this.UD_end_ValueChanged);
            // 
            // UD_Start
            // 
            this.UD_Start.Location = new System.Drawing.Point(209, 102);
            this.UD_Start.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.UD_Start.Name = "UD_Start";
            this.UD_Start.Size = new System.Drawing.Size(120, 22);
            this.UD_Start.TabIndex = 10;
            this.UD_Start.ValueChanged += new System.EventHandler(this.UD_Start_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ik wil berekenen voor post:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UitslagValue);
            this.Controls.Add(this.uitslagText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UD_end);
            this.Controls.Add(this.UD_Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Meldkamerspel Kosten Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.UD_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UD_Start)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label UitslagValue;
        private System.Windows.Forms.Label uitslagText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown UD_end;
        private System.Windows.Forms.NumericUpDown UD_Start;
        private System.Windows.Forms.Label label1;
    }
}

