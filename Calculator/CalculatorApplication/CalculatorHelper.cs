namespace CalculatorTest
{
    public class CalculatorHelper
    {
        public static int Operand1 { get; set; }

        public string DisplayText
        {
            get { return Operand1.ToString(); }
        }

        public void HandleButton1()
        {
            Operand1 = 1;
        }
    }
}