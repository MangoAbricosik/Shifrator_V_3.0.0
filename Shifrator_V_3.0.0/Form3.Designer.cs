
namespace Shifrator_V_3._0._0
{
  partial class Form3
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.DimGray;
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.ForeColor = System.Drawing.Color.DarkRed;
      this.textBox1.Location = new System.Drawing.Point(18, 57);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(145, 22);
      this.textBox1.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Black;
      this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.Color.DarkRed;
      this.button1.Location = new System.Drawing.Point(36, 85);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(97, 41);
      this.button1.TabIndex = 1;
      this.button1.Text = "login";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Black;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.label1.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.DarkRed;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(151, 33);
      this.label1.TabIndex = 2;
      this.label1.Text = "Password";
      // 
      // button2
      // 
      this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold);
      this.button2.ForeColor = System.Drawing.Color.DarkRed;
      this.button2.Location = new System.Drawing.Point(36, 132);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(100, 23);
      this.button2.TabIndex = 3;
      this.button2.Text = "Close";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // Form3
      // 
      this.AcceptButton = this.button1;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(179, 185);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form3";
      this.Text = "Form3";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button2;
  }
}