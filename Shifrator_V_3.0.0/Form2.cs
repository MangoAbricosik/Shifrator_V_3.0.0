using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shifrator_V_3._0._0
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }
    private void button1_Click(object sender, EventArgs e)
    {
      ulong key = 0;
      try
      {
        key = Convert.ToUInt64(textBox2.Text);
      }
      catch (Exception)
      {
        exMet();
      }
      string preSlovo = textBox1.Text;
      try
      {
        preSlovo = textBox1.Text;
      }
      catch (Exception)
      {
        exMet();
      }

      Shifrovka(preSlovo, ref key);
    }
    public void exMet()
    {
      Form4 excepForm = new Form4();
      excepForm.Show();
    }
    public void Shifrovka(string preSlovo,ref ulong key)
    {
      string newSlovo = "";
      foreach (var item in preSlovo)
      {
        newSlovo += Podgotovka(ref key, item);
      }
      textBox3.Text = newSlovo;
    }
    public char Podgotovka(ref ulong key, char item)
    {
      char ch = (char)(item ^ key);
      key /= 2;
      if (key <= 10)
      {
        Random rand = new Random();
        key *= Convert.ToUInt64(rand.Next(1000, 10000));
      }
      return ch;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Hide();
      Form1 defForm = new Form1();
      defForm.Show();
    }
    private void button3_Click(object sender, EventArgs e)
    {
      Form1 defForm = new Form1();
      defForm.Close();
      Form3 passForm = new Form3();
      passForm.Close();
      Close();
    }
  }
}
