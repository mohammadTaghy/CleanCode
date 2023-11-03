using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanCode_Formatting
{
    internal class _05_HorizontalOpennessAndDensity
    {
        int lineCount = 0;
        private void measureLine(string line)
        {
            lineCount++;
            int lineSize = line.Length;
            totalChars += lineSize;
            lineWidthHistogram.addLine(lineSize, lineCount);
            recordWidestLine(lineSize);
        }
        public class Quadratic
        {
            public static double root1(double a, double b, double c)
            {
                double determinant = determinant(a, b, c);
                return (-b + Math.sqrt(determinant)) / (2 * a);
            }
            public static double root2(int a, int b, int c)
            {
                double determinant = determinant(a, b, c);
                return (-b - Math.sqrt(determinant)) / (2 * a);
            }
            private static double determinant(double a, double b, double c)
            {
                return b * b - 4 * a * c;
            }
        }
        //Alignment
        public class FitNesseExpediter
        {
            //private     Socket          socket;
            //private     InputStream     input;
            //private     OutputStream    output;
            //private     Request         request;
            //private     Response        response;
            //private     FitNesseContext context;
            //private     FitNesseContext context;
            //protected   long            requestParsingTimeLimit;
            //private     long            requestProgress;
            //private     long            requestParsingDeadline;
            //private     boolean         hasError;
            //public FitNesseExpediter(Socket s,
            // FitNesseContext context)
            //{
            //    this.context = context;
            //    socket = s;
            //    input = s.getInputStream();
            //    output = s.getOutputStream();
            //    requestParsingTimeLimit = 10000;
            //}
        }
    }
}