using System.Xml;
using Newtonsoft.Json;
using Services;

namespace Convertors
{
    class Convertor() : IConvertor
    {
        public string JSONToXML(string json)
        {
            string result = JsonConvert.DeserializeXNode(json, "Root")?.ToString()!;
            string newResult = Service.AcceptXML(result);

            return XMLToJSON(newResult);
        }

        private static string XMLToJSON(string xml)
        {
            XmlDocument document = new();
            document.LoadXml(xml);

            return JsonConvert.SerializeXmlNode(document);
        }
    }
}