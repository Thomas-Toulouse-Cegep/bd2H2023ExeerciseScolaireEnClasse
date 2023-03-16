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
            this.lbSession = new System.Windows.Forms.Label();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAppelStandard
            // 
            this.btnAppelStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppelStandard.Location = new System.Drawing.Point(95, 74);
            this.btnAppelStandard.Name = "btnAppelStandard";
            this.btnAppelStandard.Size = new System.Drawing.Size(177, 35);
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
            this.btnReturn.Size = new System.Drawing.Size(177, 35);
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
            this.btnOutput.Size = new System.Drawing.Size(177, 35);
            this.btnOutput.TabIndex = 3;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // lbSession
            // 
            this.lbSession.AutoSize = true;
            this.lbSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSession.Location = new System.Drawing.Point(12, 22);
            this.lbSession.Name = "lbSession";
            this.lbSession.Size = new System.Drawing.Size(83, 25);
            this.lbSession.TabIndex = 4;
            this.lbSession.Text = "Session";
            // 
            // txtSession
            // 
            this.txtSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSession.Location = new System.Drawing.Point(102, 22);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(170, 30);
            this.txtSession.TabIndex = 5;
            this.txtSession.Text = "H23";
            // 
            // ParametreReturnOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 290);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.lbSession);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAppelStandard);
            this.Name = "ParametreReturnOutputForm";
            this.Text = "ParametreReturnOutputForm";
            this.Load += new System.EventHandler(this.ParametreReturnOutputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAppelStandard;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label lbSession;
        private System.Windows.Forms.TextBox txtSession;
    }
}