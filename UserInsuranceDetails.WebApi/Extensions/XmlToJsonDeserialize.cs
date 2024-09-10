using System.Xml.Serialization;
using UserInsuranceDetails.WebApi.Models;

namespace UserInsuranceDetails.WebApi.Extensions
{
    public class XmlToJsonDeserialize<T> where T : class
    {
        public static T ConvertToJson(string xmlData)
        {
            T extractedData = null;

            using (StringReader sr = new StringReader(xmlData))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                extractedData = (T)xmlSerializer.Deserialize(sr)!;
            }

            return extractedData;
        }
    }
}
