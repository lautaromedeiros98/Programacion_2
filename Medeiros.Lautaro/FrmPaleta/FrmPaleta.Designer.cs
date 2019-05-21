namespace FrmPaleta
{
  partial class FrmPaleta
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
			this.lstLista = new System.Windows.Forms.ListBox();
			this.btnMas = new System.Windows.Forms.Button();
			this.btnMenos = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstLista
			// 
			this.lstLista.FormattingEnabled = true;
			this.lstLista.Location = new System.Drawing.Point(13, 13);
			this.lstLista.MultiColumn = true;
			this.lstLista.Name = "lstLista";
			this.lstLista.Size = new System.Drawing.Size(446, 225);
			this.lstLista.TabIndex = 0;
			this.lstLista.DoubleClick += new System.EventHandler(this.lstLista_DoubleClick);
			// 
			// btnMas
			// 
			this.btnMas.Location = new System.Drawing.Point(150, 244);
			this.btnMas.Name = "btnMas";
			this.btnMas.Size = new System.Drawing.Size(75, 23);
			this.btnMas.TabIndex = 1;
			this.btnMas.Text = "+";
			this.btnMas.UseVisualStyleBackColor = true;
			this.btnMas.Click += new System.EventHandler(this.btnMas_Click_1);
			// 
			// btnMenos
			// 
			this.btnMenos.Location = new System.Drawing.Point(240, 244);
			this.btnMenos.Name = "btnMenos";
			this.btnMenos.Size = new System.Drawing.Size(75, 23);
			this.btnMenos.TabIndex = 2;
			this.btnMenos.Text = "-";
			this.btnMenos.UseVisualStyleBackColor = true;
			this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
			// 
			// FrmPaleta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 279);
			this.Controls.Add(this.btnMenos);
			this.Controls.Add(this.btnMas);
			this.Controls.Add(this.lstLista);
			this.Name = "FrmPaleta";
			this.Text = "FrmPaleta";
			this.Load += new System.EventHandler(this.FrmPaleta_Load);
			this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lstLista;
    private System.Windows.Forms.Button btnMas;
    private System.Windows.Forms.Button btnMenos;
  }
}

