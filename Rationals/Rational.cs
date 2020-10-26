namespace Rationals
{
    public class Rational
    {
        private int _numerator;
        private int _denominator;

        public Rational(int numerator, int denominator)
        {
            if (denominator <= 0)
                throw new InvalidValueException("Value Negative");

            _numerator = numerator;
            _denominator = denominator;
        }

        public bool GreaterThan(Rational other) 
        {
            return GetNumerator() * (long)other.GetDenominator()
                > GetDenominator() * (long)other.GetNumerator();
        }

        public bool Equals(Rational other)
        {
            return GetNumerator() * (long)other.GetDenominator()
                == GetDenominator() * (long)other.GetNumerator();
        }

        public static Rational operator +(Rational first, Rational second)
        {
            if (first.GetDenominator() * second.GetDenominator() <= 0)
                throw new InvalidValueException("Value Overflow");

            return new Rational(
                (first.GetNumerator() * second.GetDenominator())
                + (second.GetNumerator() * first.GetNumerator()),
                first.GetDenominator() * second.GetDenominator());
        }

        public static Rational operator -(Rational first, Rational second)
        {
            if (first.GetDenominator() * second.GetDenominator() <= 0)
                throw new InvalidValueException("Value Overflow");

            return new Rational(
                (first.GetNumerator() * second.GetDenominator())
                - (second.GetNumerator() * first.GetNumerator()),
                first.GetDenominator() * second.GetDenominator());
        }

        public static Rational operator *(Rational first, Rational second)
        {
            if (first.GetDenominator() * second.GetDenominator() <= 0)
                throw new InvalidValueException("Value Overflow");

            return new Rational(
                first.GetNumerator() * second.GetNumerator(),
                first.GetDenominator() * second.GetDenominator());
        }

        public int GetNumerator()
        {
            return _numerator;
        }

        public int GetDenominator()
        {
            return _denominator;
        }

        override
        public string ToString()
        {
            return $"{GetNumerator()}/{GetDenominator()}";
        }
    }
}
