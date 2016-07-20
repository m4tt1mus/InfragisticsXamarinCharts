namespace InfragisticXamarinCharts.Models
{
    using System;
    using ReactiveUI;

    public class DataPoint : ReactiveObject
    {
        private double _value;
        public double Value
        {
            get { return _value; }
            set { this.RaiseAndSetIfChanged(ref _value, value); }
        }

        private DateTime _timestamp;
        public DateTime Timestamp
        {
            get { return _timestamp; }
            set { this.RaiseAndSetIfChanged(ref _timestamp, value); }
        }
    }
}
