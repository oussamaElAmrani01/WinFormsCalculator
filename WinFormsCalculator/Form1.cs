using Microsoft.VisualBasic.ApplicationServices;
using WinFormsCalculator.Model;

namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        private Calculatrice calculaor = new Calculatrice();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CButton_Click(object sender, EventArgs e)
        {
            if (UserInput.Text.Length < UserInput.SelectionStart + 1) 
                return;
            UserInput.Text = UserInput.Text.Remove(UserInput.SelectionStart, 1);

        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            UserInput.Text = string.Empty;
            calculaor.A = 0;
            calculaor.B = 0;
            calculaor.Operation = null;
            FocusInputText();
        }

        private void ModuloButton_Click(object sender, EventArgs e)
        {
            if (calculaor.Operation != null)
            {
                CalculateEquation();
            }

            calculaor.Operation = "%";
            InsertTextValue("%");
            FocusInputText();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (calculaor.Operation != null)
            {
                CalculateEquation();
            }

            calculaor.Operation = "/";
            InsertTextValue("/");
            FocusInputText();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");

            FocusInputText();
        }

        private void NineButtonClick(object sender, EventArgs e)
        {
            InsertTextValue("9");

            FocusInputText();
        }

        private void FourButton_CLick(object sender, EventArgs e)
        {
            InsertTextValue("4");

            FocusInputText();
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            if (calculaor.Operation != null)
            {
                CalculateEquation();
            }

            calculaor.Operation = "*";
            InsertTextValue("*");
            FocusInputText();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");

            FocusInputText();
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");

            FocusInputText();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");

            FocusInputText();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");

            FocusInputText();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");

            FocusInputText();
        }

        private void FiveButtom_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");

            FocusInputText();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");

            FocusInputText();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");

            FocusInputText();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (calculaor.Operation != null)
            {
                CalculateEquation();
            }

            calculaor.Operation = "-";
            InsertTextValue("-");
            FocusInputText();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
                
            if (calculaor.Operation != null)
            {
                CalculateEquation();
            }

            calculaor.Operation = "+";
            InsertTextValue("+");
            FocusInputText();
        }

        private void ResultButtom_Click(object sender, EventArgs e)
        {
            
            CalculateEquation();
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FocusInputText()
        {
            UserInput.Focus();
        }

        private void InsertTextValue(string value)
        {
            int selectionStart = UserInput.SelectionStart;

            UserInput.Text = UserInput.Text.Insert(UserInput.SelectionStart, value);

            UserInput.SelectionStart = selectionStart + value.Length;

            UserInput.SelectionLength = 0;
        }

        private void CalculateEquation()
        {
            var inputSplit = UserInput.Text.Split(calculaor.Operation);
            calculaor.A = int.Parse(inputSplit[0]);
            calculaor.B = int.Parse(inputSplit[1]);
            UserInput.Text = string.Empty;
            InsertTextValue(calculaor.calculate().ToString());
            calculaor.A = calculaor.calculate();
        }

        private bool verificationOperation()
        {
            return UserInput.Text.Split(calculaor.Operation).Length == 2 ;
        }
    }
}