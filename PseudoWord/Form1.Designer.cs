namespace PseudoWord
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewDoc = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItlic = new System.Windows.Forms.Button();
            this.btnUnderLine = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnNewDoc
            // 
            this.btnNewDoc.Location = new System.Drawing.Point(12, 12);
            this.btnNewDoc.Name = "btnNewDoc";
            this.btnNewDoc.Size = new System.Drawing.Size(88, 36);
            this.btnNewDoc.TabIndex = 0;
            this.btnNewDoc.Text = "New Document";
            this.btnNewDoc.UseVisualStyleBackColor = true;
            this.btnNewDoc.Click += new System.EventHandler(this.btnNewDoc_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(129, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(88, 36);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(250, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBold
            // 
            this.btnBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBold.Location = new System.Drawing.Point(12, 72);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(88, 36);
            this.btnBold.TabIndex = 3;
            this.btnBold.Text = "Bold";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItlic
            // 
            this.btnItlic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnItlic.Location = new System.Drawing.Point(129, 72);
            this.btnItlic.Name = "btnItlic";
            this.btnItlic.Size = new System.Drawing.Size(88, 36);
            this.btnItlic.TabIndex = 4;
            this.btnItlic.Text = "Italic";
            this.btnItlic.UseVisualStyleBackColor = true;
            this.btnItlic.Click += new System.EventHandler(this.btnItlic_Click);
            // 
            // btnUnderLine
            // 
            this.btnUnderLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnderLine.Location = new System.Drawing.Point(250, 72);
            this.btnUnderLine.Name = "btnUnderLine";
            this.btnUnderLine.Size = new System.Drawing.Size(88, 36);
            this.btnUnderLine.TabIndex = 5;
            this.btnUnderLine.Text = "Underline";
            this.btnUnderLine.UseVisualStyleBackColor = true;
            this.btnUnderLine.Click += new System.EventHandler(this.btnUnderLine_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(775, 323);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnUnderLine);
            this.Controls.Add(this.btnItlic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnNewDoc);
            this.Name = "Form1";
            this.Text = "text";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewDoc;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItlic;
        private System.Windows.Forms.Button btnUnderLine;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

