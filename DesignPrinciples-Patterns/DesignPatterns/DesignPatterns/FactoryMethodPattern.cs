using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    //Abstract Product
    public interface IReport
    {
        void Generate();
    }

    //Concrete Products
    public class PDFReport : IReport
    {
        public void Generate()
        {
            Console.WriteLine("Generating PDF Report");
        }
    }

    public class ExcelReport : IReport
    {
        public void Generate()
        {
            Console.WriteLine("Generating Excel Report");
        }
    }

    public class WordReport : IReport
    {
        public void Generate()
        {
            Console.WriteLine("Generating Word Report");
        }
    }

    //Creator
    public abstract class ReportCreator
    {
        public abstract IReport CreateReport();

        public void GenerateReport()
        {
            IReport report = CreateReport();
            report.Generate();
        }
    }

    //Concrete Creators
    public class PDFReportCreator : ReportCreator
    {
        public override IReport CreateReport()
        {
            return new PDFReport();
        }
    }

    public class ExcelReportCreator : ReportCreator
    {
        public override IReport CreateReport()
        {
            return new ExcelReport();
        }
    }

    public class WordReportCreator : ReportCreator
    {
        public override IReport CreateReport()
        {
            return new WordReport();
        }
    }
}
