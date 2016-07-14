namespace InfragisticXamarinCharts.Models
{
    using System.ComponentModel;

    public class ChartTestViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        public EnergyProductionDataSample Data { get; set; }

        public ChartTestViewModel()
        {
            Data = new EnergyProductionDataSample();
        }
    }
}