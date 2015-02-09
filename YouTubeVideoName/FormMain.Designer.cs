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
      this.buttonCompute = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // buttonCompute
      // 
      this.buttonCompute.Location = new System.Drawing.Point(158, 22);
      this.buttonCompute.Name = "buttonCompute";
      this.buttonCompute.Size = new System.Drawing.Size(75, 23);
      this.buttonCompute.TabIndex = 0;
      this.buttonCompute.Text = "Compute";
      this.buttonCompute.UseVisualStyleBackColor = true;
      this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(15, 22);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(120, 732);
      this.listBox1.TabIndex = 1;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(304, 780);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.buttonCompute);
      this.Name = "FormMain";
      this.ShowIcon = false;
      this.Text = "Generate YouTube video names";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonCompute;
    private System.Windows.Forms.ListBox listBox1;
  }
}

