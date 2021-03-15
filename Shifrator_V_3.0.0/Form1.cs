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
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string preSlovo = "";
      try
      {
        preSlovo = textBox1.Text;
      }
      catch (Exception)
      {
        exMet();
      }
      ushort key = 0;
      try
      {
        key = Convert.ToUInt16(textBox2.Text);
      }
      catch (Exception)
      {
        exMet();
      }

      Shifrovka(preSlovo, key);
    }
    public void exMet()
    {
      Form4 excepForm = new Form4();
      excepForm.Show();
    }
    public void Shifrovka (string preSlovo, ushort key)
    {
      string newSlovo = "";
      foreach (var item in preSlovo)
      {
        newSlovo += Podgotovka(key, item);
      }
      textBox3.Text = newSlovo;
    }
    public char Podgotovka(ushort key, char item)
    {
      char ch = (char)(item ^ key);
      return ch;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Hide();
      Form2 exForm = new Form2();
      exForm.Show();
    }



    private void button3_Click(object sender, EventArgs e)
    {
      Form2 exForm = new Form2();
      exForm.Close();
      Form3 passForm = new Form3();
      passForm.Close();
      Close();
    }
  }
}
