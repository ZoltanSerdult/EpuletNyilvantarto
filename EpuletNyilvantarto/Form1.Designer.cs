
namespace EpuletNyilvantarto
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
            this.listBox_Epuletek = new System.Windows.Forms.ListBox();
            this.button_Csaladi = new System.Windows.Forms.Button();
            this.button_Tombhaz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Torol = new System.Windows.Forms.Button();
            this.button_Modosit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Epuletek
            // 
            this.listBox_Epuletek.FormattingEnabled = true;
            this.listBox_Epuletek.Location = new System.Drawing.Point(13, 117);
            this.listBox_Epuletek.Name = "listBox_Epuletek";
            this.listBox_Epuletek.Size = new System.Drawing.Size(874, 303);
            this.listBox_Epuletek.TabIndex = 0;
            // 
            // button_Csaladi
            // 
            this.button_Csaladi.Location = new System.Drawing.Point(13, 12);
            this.button_Csaladi.Name = "button_Csaladi";
            this.button_Csaladi.Size = new System.Drawing.Size(170, 39);
            this.button_Csaladi.TabIndex = 1;
            this.button_Csaladi.Text = "Családiház";
            this.button_Csaladi.UseVisualStyleBackColor = true;
            this.button_Csaladi.Click += new System.EventHandler(this.button_Csaladi_Click);
            // 
            // button_Tombhaz
            // 
            this.button_Tombhaz.Location = new System.Drawing.Point(717, 12);
            this.button_Tombhaz.Name = "button_Tombhaz";
            this.button_Tombhaz.Size = new System.Drawing.Size(170, 38);
            this.button_Tombhaz.TabIndex = 2;
            this.button_Tombhaz.Text = "Tömbház";
            this.button_Tombhaz.UseVisualStyleBackColor = true;
            this.button_Tombhaz.Click += new System.EventHandler(this.button_Tombhaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(315, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Épület nyilvántartó";
            // 
            // button_Torol
            // 
            this.button_Torol.Location = new System.Drawing.Point(258, 60);
            this.button_Torol.Name = "button_Torol";
            this.button_Torol.Size = new System.Drawing.Size(170, 37);
            this.button_Torol.TabIndex = 4;
            this.button_Torol.Text = "Épület törlése";
            this.button_Torol.UseVisualStyleBackColor = true;
            this.button_Torol.Click += new System.EventHandler(this.button_Torol_Click);
            // 
            // button_Modosit
            // 
            this.button_Modosit.Location = new System.Drawing.Point(479, 60);
            this.button_Modosit.Name = "button_Modosit";
            this.button_Modosit.Size = new System.Drawing.Size(170, 37);
            this.button_Modosit.TabIndex = 5;
            this.button_Modosit.Text = "Épület modósitása";
            this.button_Modosit.UseVisualStyleBackColor = true;
            this.button_Modosit.Click += new System.EventHandler(this.button_Modosit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 436);
            this.Controls.Add(this.button_Modosit);
            this.Controls.Add(this.button_Torol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Tombhaz);
            this.Controls.Add(this.button_Csaladi);
            this.Controls.Add(this.listBox_Epuletek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Csaladi;
        public System.Windows.Forms.ListBox listBox_Epuletek;
        private System.Windows.Forms.Button button_Tombhaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Torol;
        private System.Windows.Forms.Button button_Modosit;
    }
}

