namespace InfragisticXamarinCharts.Pages
{
    using Models;
    using Xamarin.Forms;

    public partial class LineChart : ContentPage
    {
        private ChartTestViewModel _viewModel { get; set; }

        public LineChart()
        {
            _viewModel = new ChartTestViewModel();
            this.BindingContext = _viewModel;

            InitializeComponent();
        }
    }
}

