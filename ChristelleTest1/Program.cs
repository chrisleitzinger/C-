using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChristelleTest1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"D:\FL_insurance_sample.csv"))
            {
                reader.ReadLine();
                var siteInsurances = new List<SiteInsurance>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    var siteInsurance = new SiteInsurance();
                    siteInsurance.PolicyId = int.Parse(values[0]);
                    siteInsurance.StateCode = values[1];
                    siteInsurance.County = values[2];
                    siteInsurance.EqSiteLimit = decimal.Parse(values[3]);
                    siteInsurance.HuSiteLimit = decimal.Parse(values[4]);
                    siteInsurance.FlSiteLimit = decimal.Parse(values[5]);
                    siteInsurance.FrSiteLimit = decimal.Parse(values[6]);
                    siteInsurance.Tiv2011 = decimal.Parse(values[7]);
                    siteInsurance.Tiv2012 = decimal.Parse(values[8]);
                    siteInsurance.EqSiteDeductible = decimal.Parse(values[9]);
                    siteInsurance.HuSiteDeductible = decimal.Parse(values[10]);
                    siteInsurance.FlSiteDeductible = decimal.Parse(values[11]);
                    siteInsurance.FrSiteDeductible = decimal.Parse(values[12]);
                    siteInsurance.PointLatitude = decimal.Parse(values[13]);
                    siteInsurance.PointLongitude = decimal.Parse(values[14]);
                    siteInsurance.Line = values[15];
                    siteInsurance.Construction = values[16];
                    siteInsurance.PointGranularity = int.Parse(values[17]);
                    siteInsurances.Add(siteInsurance);

                }

                CreateNewFile(siteInsurances);
            }

        }

        public static void CreateNewFile(List<SiteInsurance> siteInsurances)
        {
            //add a header
            //var header = new StringWriter();


            //header.WriteLine("Point granularity , Construction , Line , PointLongitude");
            //File.WriteAllText(@"D:\FL new insurance file.csv", "Point granularity" + "Construction" + " Line" + " PointLongitude");


            var csv = new StringBuilder();
            csv.AppendLine("Point granularity , Construction , Line, Point Longitude , Point Latitude , Fr Site Deductible , Fl Site Deductible , Hu Site Deductible , Eq Site Deductible , Tiv2012 , Tiv2011");

            foreach (var siteInsurance in siteInsurances)
            {
                var lineBuilder = new StringBuilder();
                lineBuilder.Append(siteInsurance.PointGranularity + ",");
                lineBuilder.Append(siteInsurance.Construction + ",");
                lineBuilder.Append(siteInsurance.Line + ",");
                lineBuilder.Append(siteInsurance.PointLongitude + ",");
                lineBuilder.Append(siteInsurance.PointLatitude + ",");
                lineBuilder.Append(siteInsurance.FrSiteDeductible + ",");
                lineBuilder.Append(siteInsurance.FlSiteDeductible + ",");
                lineBuilder.Append(siteInsurance.HuSiteDeductible + ",");
                lineBuilder.Append(siteInsurance.EqSiteDeductible + ",");
                lineBuilder.Append(siteInsurance.Tiv2012 + ",");
                lineBuilder.Append(siteInsurance.Tiv2011 + ",");
                lineBuilder.Append(siteInsurance.FrSiteLimit + ",");
                lineBuilder.Append(siteInsurance.FlSiteLimit + ",");
                lineBuilder.Append(siteInsurance.HuSiteLimit + ",");
                lineBuilder.Append(siteInsurance.EqSiteLimit + ",");
                lineBuilder.Append(siteInsurance.County + ",");
                lineBuilder.Append(siteInsurance.StateCode + ",");
                lineBuilder.Append(siteInsurance.PolicyId);

                csv.AppendLine(lineBuilder.ToString());
            }

            File.WriteAllText(@"D:\FL new insurance file.csv", csv.ToString());
        }
    }
}
