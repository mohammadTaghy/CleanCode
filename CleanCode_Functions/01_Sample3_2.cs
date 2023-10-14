using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_Functions
{
    partial class Sample3_2
    {
        public static String RenderPageWithSetupsAndTeardowns(
           PageData pageData,
           bool isSuite)
        {
            bool isTestPage = pageData.hasAttribute("Test");
            if (isTestPage)
            {
                WikiPage testPage = pageData.getWikiPage();
                StringBuilder newPageContent = new StringBuilder();
                includeSetupPages(testPage, newPageContent, isSuite);
                newPageContent.Append(pageData.getContent());
                includeTeardownPages(testPage, newPageContent, isSuite);
                pageData.setContent(newPageContent.ToString());
            }

            return pageData.getHtml();
        }
    }
}
