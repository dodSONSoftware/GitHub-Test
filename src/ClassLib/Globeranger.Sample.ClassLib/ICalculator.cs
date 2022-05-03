namespace Globeranger.Sample.ClassLib {

    /// <summary>
    /// Defines basic calculator functionality
    /// </summary>
    public interface ICalculator {

        double Add ( double a, double b );

        double Subtract ( double a, double b );

        double Multiply ( double a, double b );

        double Divide ( double a, double b );

        double Modulus ( double a, double b );
    }
}
