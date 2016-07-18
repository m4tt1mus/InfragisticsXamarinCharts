namespace InfragisticXamarinCharts.Models
{
    public class EnergyProduction
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string Year { get; set; }
        // Non-Renewable Energy Sources
        private double _nuclear;
        public double Nuclear { get { return _nuclear; } set { _nuclear = value; UpdateValues(); } }
        private double _coal;
        public double Coal { get { return _coal; } set { _coal = value; UpdateValues(); } }
        private double _oil;
        public double Oil { get { return _oil; } set { _oil = value; UpdateValues(); } }
        private double _gas;
        public double Gas { get { return _gas; } set { _gas = value; UpdateValues(); } }
        // Renewable Energy Sources
        private double _hydro;
        public double Hydro { get { return _hydro; } set { _hydro = value; UpdateValues(); } }
        private double _geoThermal;
        public double GeoThermal { get { return _geoThermal; } set { _geoThermal = value; UpdateValues(); } }
        private double _solar;
        public double Solar { get { return _solar; } set { _solar = value; UpdateValues(); } }
        private double _wind;
        public double Wind { get { return _wind; } set { _wind = value; UpdateValues(); } }
        public double Total { get; set; }
        public double Renewable { get; set; }
        public double NonRenewable { get; set; }
        public void UpdateValues()
        {
            this.Renewable = Hydro + GeoThermal + Wind + Solar;
            this.NonRenewable = Coal + Oil + Gas + Nuclear;
            this.Total = this.Renewable + this.NonRenewable;
        }
    }
}