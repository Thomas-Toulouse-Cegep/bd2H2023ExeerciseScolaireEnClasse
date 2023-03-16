namespace wfa_casScolaireDepart
{
    partial class ParametreReturnOutputForm
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
            this.btnAppelStandard = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAppelStandard
            // 
            this.btnAppelStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppelStandard.Location = new System.Drawing.Point(95, 74);
            this.btnAppelStandard.Name = "btnAppelStandard";
            this.btnAppelStandard.Size = new System.Drawing.Size(170, 35);
            this.btnAppelStandard.TabIndex = 0;
            this.btnAppelStandard.Text = "Appel standard";
            this.btnAppelStandard.UseVisualStyleBackColor = true;
            this.btnAppelStandard.Click += new System.EventHandler(this.btnAppelStandard_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(95, 182);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(170, 35);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutput.Location = new System.Drawing.Point(95, 124);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(170, 35);
            this.btnOutput.TabIndex = 3;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // ParametreReturnOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 290);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAppelStandard);
            this.Name = "ParametreReturnOutputForm";
            this.Text = "ParametreReturnOutputForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAppelStandard;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnOutput;
    }
}