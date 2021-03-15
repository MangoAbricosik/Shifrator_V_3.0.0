
namespace Shifrator_V_3._0._0
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.DimGray;
      this.textBox1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.ForeColor = System.Drawing.Color.DarkRed;
      this.textBox1.Location = new System.Drawing.Point(0, 33);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(284, 21);
      this.textBox1.TabIndex = 0;
      // 
      // textBox2
      // 
      this.textBox2.BackColor = System.Drawing.Color.DimGray;
      this.textBox2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold);
      this.textBox2.ForeColor = System.Drawing.Color.DarkRed;
      this.textBox2.Location = new System.Drawing.Point(0, 79);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(170, 21);
      this.textBox2.TabIndex = 1;
      // 
      // textBox3
      // 
      this.textBox3.BackColor = System.Drawing.Color.DimGray;
      this.textBox3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold);
      this.textBox3.ForeColor = System.Drawing.Color.DarkRed;
      this.textBox3.Location = new System.Drawing.Point(0, 125);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(284, 21);
      this.textBox3.TabIndex = 2;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Black;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold);
      this.button1.ForeColor = System.Drawing.Color.DarkRed;
      this.button1.Location = new System.Drawing.Point(0, 152);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(100, 51);
      this.button1.TabIndex = 3;
      this.button1.Text = "Encrypt";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.Black;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold);
      this.button2.ForeColor = System.Drawing.Color.DarkRed;
      this.button2.Location = new System.Drawing.Point(157, 197);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(127, 47);
      this.button2.TabIndex = 4;
      this.button2.Text = "Ex Version";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Black;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.label1.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.DarkRed;
      this.label1.Location = new System.Drawing.Point(7, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 19);
      this.label1.TabIndex = 5;
      this.label1.Text = "word";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Black;
      this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.label2.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold);
      this.label2.ForeColor = System.Drawing.Color.DarkRed;
      this.label2.Location = new System.Drawing.Point(7, 57);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(42, 19);
      this.label2.TabIndex = 6;
      this.label2.Text = "key";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.Color.Black;
      this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.label3.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold);
      this.label3.ForeColor = System.Drawing.Color.DarkRed;
      this.label3.Location = new System.Drawing.Point(7, 103);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(163, 19);
      this.label3.TabIndex = 7;
      this.label3.Text = "encrypted word";
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.Black;
      this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.button3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold);
      this.button3.ForeColor = System.Drawing.Color.DarkRed;
      this.button3.Location = new System.Drawing.Point(0, 209);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(100, 23);
      this.button3.TabIndex = 8;
      this.button3.Text = "Close";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // Form1
      // 
      this.AcceptButton = this.button1;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(296, 263);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button3;
  }
}

