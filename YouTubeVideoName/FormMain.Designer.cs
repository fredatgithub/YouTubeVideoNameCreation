namespace YouTubeVideoName
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.buttonGenerate = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // buttonGenerate
      // 
      this.buttonGenerate.Location = new System.Drawing.Point(211, 27);
      this.buttonGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.buttonGenerate.Name = "buttonGenerate";
      this.buttonGenerate.Size = new System.Drawing.Size(100, 28);
      this.buttonGenerate.TabIndex = 0;
      this.buttonGenerate.Text = "Generate";
      this.buttonGenerate.UseVisualStyleBackColor = true;
      this.buttonGenerate.Click += new System.EventHandler(this.buttonCompute_Click);
      // 
      // listBox1
      // 
      this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 16;
      this.listBox1.Location = new System.Drawing.Point(20, 27);
      this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(159, 484);
      this.listBox1.TabIndex = 1;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(405, 533);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.buttonGenerate);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "FormMain";
      this.ShowIcon = false;
      this.Text = "Generate YouTube video names";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonGenerate;
    private System.Windows.Forms.ListBox listBox1;
  }
}

