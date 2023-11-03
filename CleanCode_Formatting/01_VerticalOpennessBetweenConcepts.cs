﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanCode_Formatting
{
    class BoldWidget
    {
        public static String REGEXP = "'''.+?'''";
        private static Pattern pattern = Pattern.compile("'''(.+?)'''", Pattern.MULTILINE + Pattern.DOTALL);
        public BoldWidget(ParentWidget parent, String text) { Matcher match = pattern.matcher(text); match.find(); addChildWidgets(match.group(1)); }
        private void addChildWidgets(object p) { sampleFunction(); throw new NotImplementedException(); }
        private void sampleFunction() { throw new NotImplementedException(); }
    }
    class BoldWidget_Clean
    {
        public static String REGEXP = "'''.+?'''";
        private static Pattern pattern = Pattern.compile("'''(.+?)'''",
            Pattern.MULTILINE + Pattern.DOTALL);

        public BoldWidget_Clean(ParentWidget parent, String text)
        {
            Matcher match = pattern.matcher(text);
            match.find();
            addChildWidgets(match.group(1));
        }

        private void addChildWidgets(object p)
        {
            sampleFunction();
            throw new NotImplementedException();
        }

        private void sampleFunction()
        {
            throw new NotImplementedException();
        }

        public String Render()
        {
            StringBuffer html = new StringBuffer("<b>");
            html.append(childHtml()).append("</b>");
            return html.ToString();
        }

        public String Render(string smapleText)
        {
            StringBuffer html = new StringBuffer("<b>");
            html.append(childHtml()).append("</b>");
            return html.ToString();
        }

        public String Render_alt()
        {
            StringBuffer html = new StringBuffer("<b>");
            html.append(childHtml()).append("</b>");
            return html.ToString();
        }

        public String Render_extended()
        {
            StringBuffer html = new StringBuffer("<b>");
            html.append(childHtml()).append("</b>");
            return html.ToString();
        }

        private object childHtml()
        {
            throw new NotImplementedException();
        }
    }
    
}
