namespace InfragisticXamarinCharts.Pages
{
    using Models;
    using Infragistics.XF.Controls;
    using Infragistics.XF;
    using Xamarin.Forms;

    public partial class LineChartInCode : ContentPage
    {
        private ChartTestViewModel _viewModel { get; set; }

        public LineChartInCode()
        {
            InitializeComponent();

            _viewModel = new ChartTestViewModel();
            this.BindingContext = _viewModel;

            var xAxis = new CategoryXAxis();
            xAxis.ItemsSource = _viewModel.Data;
            xAxis.Label = "County";
            var yAxis = new NumericYAxis();

            var series = new AreaSeries();
            series.ValueMemberPath = "Coal";
            series.ItemsSource = _viewModel.Data;
            series.XAxis = xAxis;
            series.YAxis = yAxis;

            var chart = new XFDataChart();
            chart.Axes.Add(xAxis);
            chart.Axes.Add(yAxis);
            chart.Series.Add(series);

            this.Content = chart;
        }
    }
}
