using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_Functions
{
    internal class SampleOfOutputArguments
    {
       // private SampleReport sampleReport;
        public SampleOfOutputArguments()
        {
            //sampleReport=new SampleReport();
        }
        void MakeReport()
        {
            StringBuilder sb = new StringBuilder();
            appendFooter(sb);

            //sampleReport.AppendFooter();
        }
        void appendFooter(StringBuilder stringBuilder)
        {
            stringBuilder.Append("some footer");
        }
        //string appendFooter()
        //{

        //    return "some footer";
        //}
    }
    public class SampleReport
    {
        private StringBuilder reportContent;

        public SampleReport()
        {
            reportContent=new StringBuilder();
        }
        public void AppendFooter()
        {
            reportContent.Append("\n");
        }
    }
}
