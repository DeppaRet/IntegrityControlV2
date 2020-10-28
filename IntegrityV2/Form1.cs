using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IntegrityV2
{
  public partial class MainWindow : Form
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    public void getBinaryCode(string input)
    {
      Output.Text = "";
      string str = Input.Text;
      char[] tmp = new char[str.Length];
      byte[] result;
      for (int i = 0; i < str.Length; i++)
      {
        tmp[i] = str[i];
      }

      result = Encoding.GetEncoding("cp866").GetBytes(tmp);
      for (int i = 0; i < result.Length; i++)
      {
        Output.Text += Convert.ToString(result[i], 2) + '\n';
      }
    }

    public void getBinaryCycle(string input)
    {
      Output.Text = "";
      string str = Input.Text;
      char[] tmp = new char[str.Length];
      byte[] result;
      for (int i = 0; i < str.Length; i++)
      {
        tmp[i] = str[i];
      }

      result = Encoding.GetEncoding("cp866").GetBytes(tmp);
      for (int i = 0; i < result.Length; i++)
      {
        Output.Text += Convert.ToString(result[i], 2);
      }
    }

    private void Start_Click(object sender, EventArgs e)
    {
      try
      {
        string temp = " ";
        int rows = 0, columns = 0, resTmp = 0;
        string resultedText = "";


        if (Method.Text == "Контроль по паритету")
        {
          if (Action.Text == "Отправить сообщение")
          {
            getBinaryCode(Input.Text);
            temp = Output.Lines[1].ToString();
            columns = (temp.Length - 1);
            rows = Output.Lines.Length - 1;
            int tempXOR = 0;
            int[,] input = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
              temp = Output.Lines[i].ToString();
              tempXOR = temp[0];
              if (temp.Length < 8)
              {
                for (int j = 0; j < temp.Length - 1; j++)
                {
                  int second = temp[j + 1];
                  tempXOR = tempXOR ^ second;
                  if (tempXOR == 0)
                  {
                    tempXOR = 48;
                  }
                  else if (tempXOR == 1)
                  {
                    tempXOR = 49;
                  }
                }
                resultedText += temp + " КС: " + Convert.ToChar(tempXOR) + "\n";
                continue;
              }

              for (int j = 0; j < columns; j++)
              {
                int second = temp[j + 1];
                tempXOR = tempXOR ^ second;
                if (tempXOR == 0)
                {
                  tempXOR = 48;
                }
                else if (tempXOR == 1)
                {
                  tempXOR = 49;
                }
              }
              resultedText += temp + " КС: " + Convert.ToChar(tempXOR) + "\n";
            }

            Output.Text = resultedText;
          }
          else if (Action.Text == "Проверить полученное сообщение")
          {
            getBinaryCode(Input.Text);
            temp = Output.Lines[1].ToString();
            string control = "";
            columns = (temp.Length - 1);
            rows = Output.Lines.Length - 1;
            int tempXOR = 0;
            int[,] input = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
              temp = Output.Lines[i].ToString();
              tempXOR = temp[0];
              if (temp.Length < 8)
              {
                for (int j = 0; j < temp.Length - 1; j++)
                {
                  int second = temp[j + 1];
                  tempXOR = tempXOR ^ second;
                  if (tempXOR == 0)
                  {
                    tempXOR = 48;
                  }
                  else if (tempXOR == 1)
                  {
                    tempXOR = 49;
                  }
                }
                resultedText += temp + " КС: " + Convert.ToChar(tempXOR) + "\n";
                continue;
              }

              for (int j = 0; j < columns; j++)
              {
                int second = temp[j + 1];
                tempXOR = tempXOR ^ second;
                if (tempXOR == 0)
                {
                  tempXOR = 48;
                }
                else if (tempXOR == 1)
                {
                  tempXOR = 49;
                }
              }
              resultedText += temp + " КС: " + Convert.ToChar(tempXOR) + "\n";
              control += Convert.ToChar(tempXOR);
            }
            Output.Text = resultedText;
            if (control == ControlSum.Text)
            {
              Output.Text += "\n Сообщение передано без ошибок!";
            }
            else
            {
              Output.Text += "\n Сообщение передано c ошибкой!";
            }
          }
        }

        else if (Method.Text == "Вертикальный и горизонтальный контроль")
        {
          if (Action.Text == "Отправить сообщение")
          {
            getBinaryCode(Input.Text);
            temp = Output.Lines[1].ToString();
            columns = (temp.Length - 1);
            rows = Output.Lines.Length - 1;
            int tempXOR = 0;

            int[,] input = new int[rows, columns+1];

            for (int i = 0; i < rows; i++)
            {
              temp = Output.Lines[i].ToString();
              for (int j = 0; j < columns+1; j++)
              {
                input[i, j] = temp[j];
              }
            }

            for (int i = 0; i < rows; i++)
            {
              temp = Output.Lines[i].ToString();
              tempXOR = temp[0];
              for (int j = 0; j < columns; j++)
              {
                int second = temp[j + 1];
                tempXOR = tempXOR ^ second;
                if (tempXOR == 0)
                {
                  tempXOR = 48;
                }
                else if (tempXOR == 1)
                {
                  tempXOR = 49;
                }
              }

              resultedText += temp + " КС: " + Convert.ToChar(tempXOR) + "\n";
            }

            int current = 0;

            for (int j = 0; j < 8; j++)
            {
              temp = Output.Lines[0].ToString();
              tempXOR = input[0, j];
              for (int i = 0; i < rows - 1; i++)
              {
                int second = input[i+1, j];
                tempXOR = tempXOR ^ second;
                if (tempXOR == 0)
                {
                  tempXOR = 48;
                }
                else if (tempXOR == 1)
                {
                  tempXOR = 49;
                }
              }

              char res = Convert.ToChar(tempXOR);
              resultedText += res; 
            }

            Output.Text = resultedText + " :КС";
          }

          else if (Action.Text == "Проверить полученное сообщение")
          {
            getBinaryCode(Input.Text);
            string control = "";
            string verticalControl = "";
            temp = Output.Lines[1].ToString();
            columns = (temp.Length - 1);
            rows = Output.Lines.Length - 1;
            int tempXOR = 0;

            int[,] input = new int[rows, columns + 1];

            for (int i = 0; i < rows; i++)
            {
              temp = Output.Lines[i].ToString();
              for (int j = 0; j < columns + 1; j++)
              {
                input[i, j] = temp[j];
              }
            }

            for (int i = 0; i < rows; i++)
            {
              temp = Output.Lines[i].ToString();
              tempXOR = temp[0];
              for (int j = 0; j < columns; j++)
              {
                int second = temp[j + 1];
                tempXOR = tempXOR ^ second;
                if (tempXOR == 0)
                {
                  tempXOR = 48;
                }
                else if (tempXOR == 1)
                {
                  tempXOR = 49;
                }
              }

              resultedText += temp + " КС: " + Convert.ToChar(tempXOR) + "\n";
              control += Convert.ToChar(tempXOR);
            }

            int current = 0;

            for (int j = 0; j < 8; j++)
            {
              temp = Output.Lines[0].ToString();
              tempXOR = input[0, j];
              for (int i = 0; i < rows - 1; i++)
              {
                int second = input[i + 1, j];
                tempXOR = tempXOR ^ second;
                if (tempXOR == 0)
                {
                  tempXOR = 48;
                }
                else if (tempXOR == 1)
                {
                  tempXOR = 49;
                }
              }

              char res = Convert.ToChar(tempXOR);
              resultedText += res;
              verticalControl += res;
            }

            Output.Text = resultedText + " :КС";
            if ((control == ControlSum.Text) && (verticalControl == VerticalControlSum.Text))
            {
              Output.Text += "\n Сообщение передано без ошибок!";
            }
            else
            {
              Output.Text += "\n Сообщение передано c ошибкой!";
            }
          }
          else
          {
            MessageBox.Show("Вы не выбрали действие");
            return;
          }
        }
        else if (Method.Text == "Цикличесйкий избыточный контроль")
        {
          Polinom.Visible = true;
          Polinom.Enabled = true;
          PolinomText.Visible = true;
          if (Action.Text == "Отправить сообщение")
          {
            Test();
          }
          else if (Action.Text == "Проверить полученное сообщение")
          {
            Test();
            string control = Output.Lines[2];
            if (control == ControlSum.Text)
            {
              Output.Text += "\n Сообщение передано без ошибок!";
            }
            else
            {
              Output.Text += "\n Сообщение передано c ошибкой!";
            }
          }
          else
          {
            MessageBox.Show("Вы не выбрали действие");
            return;
          }
        }
        else
        {
          MessageBox.Show("Не выбран ни один из методов");
          return;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Что-то пошло не так... \nПроверьте введенные данные");
      }
    }

    private void Method_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (Method.Text == "Контроль по паритету")
      {
        Polinom.Visible = false;
        Polinom.Enabled = false;
        PolinomText.Visible = false;
      }
      else if (Method.Text == "Вертикальный и горизонтальный контроль")
      {
        Polinom.Visible = false;
        Polinom.Enabled = false;
        PolinomText.Visible = false;
      }
      else if (Method.Text == "Цикличесйкий избыточный контроль")
      {
        Polinom.Visible = true;
        Polinom.Enabled = true;
        PolinomText.Visible = true;
      }
    }

    private void MainWindow_Load(object sender, EventArgs e)
    {

    }

    private void Action_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (Action.Text == "Отправить сообщение")
      {
        ControlSum.Visible = false;
        ControlSumText.Visible = false;
        VerticalControlSum.Visible = false;
        VerticalControlSumText.Visible = false;
      }
      else if (Action.Text == "Проверить полученное сообщение")
      {
        ControlSum.Visible = true;
        ControlSumText.Visible = true;
        VerticalControlSum.Visible = true;
        VerticalControlSumText.Visible = true;
      }
    }

    public void Test()
    {
      getBinaryCycle(Input.Text);
      string dividend = Output.Lines[0];
      string divider = Polinom.Text;
      int size = dividend.Length;
      int current = 0;
      int throwed = 0;
      int regiSize = divider.Length - 1;
      List<int> regi = new List<int>();
      List<int> ish = new List<int>(); //Output.Lines.Select(x => int.Parse(x))
      for (int i = 0; i < regiSize; i++)
      {
        regi.Add(0);
      }

      for (int i = 0; i < size; i++)
      {
        if (dividend[i] == 48)
        {
          ish.Add(0);
        }
        else if (dividend[i] == 49)
        {
          ish.Add(1);
        }
        
      }

      Queue<int> register = new Queue<int>();
      for (int i = 0; i < regiSize; i++)
      {
        register.Enqueue(0);
      }

      while (current < ish.Count)
      {
        throwed = register.Dequeue();
        register.Enqueue(ish[current]);
        if (throwed == 0 || throwed == 48) //0
        {
          current++;
          continue;
        }
        else if (throwed == 1 || throwed == 49) //1
        {
          for (int i = 0; i < register.Count; i++)
          {
            int tempre = register.Dequeue();
            tempre = tempre ^ Convert.ToInt32(divider[i + 1]);
            if (tempre == 48)
            {
              register.Enqueue(0);
            }
            else if (tempre == 49)
            {
              register.Enqueue(1);
            }
            
          }
        }
        current++;
      }

      string result = "";
      Output.Text += "\nОстаток от деления: \n";
      for (int i = 0; i < register.Count; i++)
      {
        result += register.Dequeue();
      }

      Output.Text += new string(result.Reverse().ToArray());
    }

  }
}
