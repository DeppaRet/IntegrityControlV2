using System;
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

      result = Encoding.GetEncoding(1251).GetBytes(tmp);
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

      result = Encoding.GetEncoding(1251).GetBytes(tmp);
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
            getBinaryCycle(Input.Text);
            char throwed = '0';
            string dividend = Output.Lines[0];
            string divider = Polinom.Text;
            int registerSize = Polinom.Text.Length;
            int size = Output.Text.Length;
            int current = 0;
            string divInt = "";
            string afterDiv = "";
            char[] register = new char[registerSize];

            for (int i = 0; i < registerSize; i++)
            {
              register[i] = '0';
            }

            while (current < size)
            {
              //divInt = Convert.ToString(Convert.ToInt32(divInt) * 10);
              throwed = register[0];
              for (int i = 0; i < registerSize - 1; i++)
              {
                register[i] = register[i + 1]; //register[i] = register[i+1];
              }

              register[registerSize - 1] = dividend[current];
              //divInt = divInt + dividend[temp];
              if (throwed == '1')
              {
                afterDiv = Convert.ToString(Convert.ToInt32(divInt, 2) - Convert.ToInt32(divider, 2), 2);
                divInt = afterDiv;
                int tmpSize = divInt.Length - 1;
                for (int j = registerSize - 1; j >= 0; j--)
                {
                  if (tmpSize >= 0)
                  {
                    register[j] = divInt[tmpSize];
                    tmpSize--;
                  }
                  else
                  {
                    register[j] = '0';
                  }
                }
              }

              divInt += dividend[current];

              current++;
            }

            resultedText += afterDiv;
            Output.Text = resultedText;
          }
          else if (Action.Text == "Проверить полученное сообщение")
          {
            
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
  }
}
