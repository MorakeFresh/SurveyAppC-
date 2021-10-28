
namespace SurveyTest
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
            this.btn_Survey = new System.Windows.Forms.Button();
            this.btn_Results = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Survey
            // 
            this.btn_Survey.Location = new System.Drawing.Point(201, 88);
            this.btn_Survey.Name = "btn_Survey";
            this.btn_Survey.Size = new System.Drawing.Size(400, 100);
            this.btn_Survey.TabIndex = 0;
            this.btn_Survey.Text = "Fill out survey";
            this.btn_Survey.UseVisualStyleBackColor = true;
            this.btn_Survey.Click += new System.EventHandler(this.btn_Survey_Click);
            // 
            // btn_Results
            // 
            this.btn_Results.Location = new System.Drawing.Point(201, 292);
            this.btn_Results.Name = "btn_Results";
            this.btn_Results.Size = new System.Drawing.Size(400, 100);
            this.btn_Results.TabIndex = 1;
            this.btn_Results.Text = "View survey results";
            this.btn_Results.UseVisualStyleBackColor = true;
            this.btn_Results.Click += new System.EventHandler(this.btn_Results_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btn_Results);
            this.Controls.Add(this.btn_Survey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Survey;
        private System.Windows.Forms.Button btn_Results;
    }
}

