using System.Windows.Input;

namespace WpfApp14._07._22
{
    public class WindowCommands
        {
            static WindowCommands()
            {
                PerformanceSumm = new RoutedCommand("PerformanceSumm", typeof(MainWindow));
                PerformanceSubstruction= new RoutedCommand("PerformanceSubstruction", typeof(MainWindow));
                PerformanceMultiply = new RoutedCommand("PerformanceMultiply", typeof(MainWindow));
                PerformanceDivision = new RoutedCommand("PerformanceDivision", typeof(MainWindow));
            }
            public static RoutedCommand PerformanceSumm { get; set; }
            public static RoutedCommand PerformanceSubstruction { get; set; }
            public static RoutedCommand PerformanceMultiply { get; set; }
            public static RoutedCommand PerformanceDivision { get; set; }

        }
}
