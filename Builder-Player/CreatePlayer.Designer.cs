
namespace Builder_Player
{
    partial class CreatePlayer
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
            this.cbText = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.lsText = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbText
            // 
            this.cbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbText.FormattingEnabled = true;
            this.cbText.ItemHeight = 25;
            this.cbText.Location = new System.Drawing.Point(12, 37);
            this.cbText.Name = "cbText";
            this.cbText.Size = new System.Drawing.Size(174, 33);
            this.cbText.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(292, 31);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(242, 39);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Create new Player";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lsText
            // 
            this.lsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsText.FormattingEnabled = true;
            this.lsText.ItemHeight = 20;
            this.lsText.Location = new System.Drawing.Point(12, 79);
            this.lsText.Name = "lsText";
            this.lsText.Size = new System.Drawing.Size(789, 184);
            this.lsText.TabIndex = 2;
            // 
            // CreatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 291);
            this.Controls.Add(this.lsText);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.cbText);
            this.Name = "CreatePlayer";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbText;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ListBox lsText;
    }
}

