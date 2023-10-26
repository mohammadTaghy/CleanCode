using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_Functions
{
    internal class _09_CommandQuerySeparation
    {
        
        public string Delete_With_ErrorCode(Page page)
        {
            if (deletePage(page) == "E_OK")
            {
                if (registry.deleteReference(page.name) == "E_OK")
                {
                    if (configKeys.deleteKey(page.name) == "E_OK")
                    {
                        logger.log("page deleted");
                    }
                    else
                    {
                        logger.log("configKey not deleted");
                    }
                    return "E_ERROR";
                }
                else
                {
                    logger.log("deleteReference from registry failed");
                    return "E_OK";
                }
            }
            else
            {
                logger.log("delete failed");
                return "E_ERROR";
            }
        }

        public void Delete_Not_Refactored(Page page)
        {
            try
            {
                deletePage(page);
                registry.deleteReference(page.name);
                configKeys.deleteKey(page.name);
            }
            catch (Exception e)
            {
                logger.log(e.Message);
            }
        }

        public void Delete(Page page)
        {
            try
            {
                DeletePageAndAllReferences(page);
            }
            catch (Exception e)
            {
                LogError(e);
            }
        }

        private void DeletePageAndAllReferences(Page page)
        {
            deletePage(page);
            registry.deleteReference(page.name);
            configKeys.deleteKey(page.name);
        }
        private string deletePage(Page page)
        {
            throw new NotImplementedException();
        }
        private void LogError(Exception e)
        {
            logger.log(e.Message);
        }
    }
}
