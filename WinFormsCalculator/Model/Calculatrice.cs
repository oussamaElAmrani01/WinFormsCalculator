namespace WinFormsCalculator.Model
{
    public class Calculatrice
    {
        public double A { get; set; }
        public double B { get; set; }
        public string Operation { get; set; }

        public double calculate()
        {
            switch (Operation)
            {
                case "*":
                    return A * B;
                case "+":
                    return A + B;
                case "/":
                    return(double) A / B;
                case "%":
                    return A % B;
            }

            return 0;
        }



    }
}
