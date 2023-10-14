using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_Functions
{
    partial class Sample3_3
    {
        public static String RenderPageWithSetupsAndTeardowns_SallerVersoin(
            PageData pageData,
            bool isSuite)
        {
            if (isTestPage(pageData))
                includeSetupAndTeardownPages(pageData, isSuite);
            return pageData.getHtml();
        }
    }
}
