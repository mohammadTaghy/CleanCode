using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_Formatting
{
    public class ReporterConfig
    {
        /// <summary>
        /// something
        /// </summary>
        private List<Property> m_properties = new List<Property>();

        /**
         * The class name of the reporter listener */
        private String m_className;

        public void addProperty(Property property)
        {
            m_properties.Add(property);
        }
    }
    public class ReporterConfig_Clean
    {
        private String m_className;
        private List<Property> m_properties = new List<Property>();

        public void addProperty(Property property)
        {
            m_properties.Add(property);
        }
    }
}
