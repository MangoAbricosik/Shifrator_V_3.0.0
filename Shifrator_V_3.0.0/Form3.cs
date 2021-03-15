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
  public partial class Form3 : Form
  {
    public Form3()
    {
      InitializeComponent();
    }
    private void button1_Click(object sender, EventArgs e)
    {
      proverka();
    }
    public void proverka()
    {
      string tryPass = "";
      try
      {
        tryPass = textBox1.Text;
      }
      catch (Exception)
      {
        label1.Text = "Invalid input";
        throw;
      }

      string pass = "password";

      if (tryPass == pass)
      {
        Hide();
        Form1 defForm = new Form1();
        defForm.Show();
      }
      else
      {
        label1.Text = "Invalid password";
      }
    }
    private void button2_Click(object sender, EventArgs e)
    {
      Form2 exForm = new Form2();
      exForm.Close();
      Form1 defForm = new Form1();
      defForm.Close();
      Close();
    }
  }
}
