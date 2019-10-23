namespace ChristelleTest1
{
    public class SiteInsurance
    {
        public SiteInsurance()
        {

        }

        public int PolicyId { get; set; }
        public string StateCode { get; set; }
        public string County { get; set; }
        public decimal EqSiteLimit { get; set; }
        public decimal HuSiteLimit { get; set; }
        public decimal FlSiteLimit { get; set; }
        public decimal FrSiteLimit { get; set; }
        public decimal Tiv2011 { get; set; }
        public decimal Tiv2012 { get; set; }
        public decimal EqSiteDeductible { get; set; }
        public decimal HuSiteDeductible { get; set; }
        public decimal FlSiteDeductible { get; set; }
        public decimal FrSiteDeductible { get; set; }
        public decimal PointLatitude { get; set; }
        public decimal PointLongitude { get; set; }
        public string Line { get; set; }
        public string Construction { get; set; }
        public int PointGranularity { get; set; }

        public static string Insurance { get; set; }
    }
}
