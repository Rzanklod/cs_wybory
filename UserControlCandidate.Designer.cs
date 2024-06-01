
namespace Wybory
{
    partial class UserControlCandidate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxCandidate = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.groupBoxCandidate.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(102, 37);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.ReadOnly = true;
            this.textBoxImie.Size = new System.Drawing.Size(130, 20);
            this.textBoxImie.TabIndex = 0;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(102, 63);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.ReadOnly = true;
            this.textBoxNazwisko.Size = new System.Drawing.Size(130, 20);
            this.textBoxNazwisko.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwisko";
            // 
            // groupBoxCandidate
            // 
            this.groupBoxCandidate.Controls.Add(this.buttonRemove);
            this.groupBoxCandidate.Controls.Add(this.button1);
            this.groupBoxCandidate.Controls.Add(this.textBoxNazwisko);
            this.groupBoxCandidate.Controls.Add(this.textBoxImie);
            this.groupBoxCandidate.Controls.Add(this.label2);
            this.groupBoxCandidate.Controls.Add(this.label1);
            this.groupBoxCandidate.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCandidate.Name = "groupBoxCandidate";
            this.groupBoxCandidate.Size = new System.Drawing.Size(240, 124);
            this.groupBoxCandidate.TabIndex = 6;
            this.groupBoxCandidate.TabStop = false;
            this.groupBoxCandidate.Text = "Kandydat";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zaglosuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(21, 94);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(50, 21);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Usun";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // UserControlCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxCandidate);
            this.Name = "UserControlCandidate";
            this.Size = new System.Drawing.Size(247, 131);
            this.groupBoxCandidate.ResumeLayout(false);
            this.groupBoxCandidate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxCandidate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRemove;
    }
}
