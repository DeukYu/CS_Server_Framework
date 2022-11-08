using System.Xml;

namespace PacketGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pdlPath = "../../../PDL.xml";
            XmlReaderSettings settings = new XmlReaderSettings()
            {
                IgnoreComments = true, // 주석 무시
                IgnoreWhitespace = true // 스페이스바 무시
            };

            if (args.Length > 0)
                pdlPath = args[0];

            using (XmlReader reader = XmlReader.Create(pdlPath, settings))
            {
                reader.MoveToContent();

                while (reader.Read())
                {
                    if (reader.Depth == 1 && reader.NodeType == XmlNodeType.Element)
                        ParsePacket(reader);
                }
            }
        }
        public static void ParsePacket(XmlReader _reader)
        {
            if (_reader.NodeType == XmlNodeType.EndElement)
                return;

            if (_reader.Name.ToLower() != "packet")
            {
                Console.WriteLine("Invalid packet node");
                return;
            }

            string packetName = _reader["name"];
            if (string.IsNullOrEmpty(packetName))
            {
                Console.WriteLine("Packet without name");
            }

            Tuple<string, string, string> t = ParseMembers(_reader);
        }
        public static Tuple<string, string, string> ParseMembers(XmlReader _reader)
        {
            string packetName = _reader["name"];

            string memberCode = "";
            string readCode = "";
            string writeCode = "";

            int depth = _reader.Depth + 1;
            while(_reader.Read())
            {
                if (_reader.Depth != depth)
                    break;

                string memberName = _reader["name"];
                if(string.IsNullOrEmpty(memberName))
                {
                    Console.WriteLine("Member without name");
                    return null;
                }

                if (string.IsNullOrEmpty(memberCode) == false)
                    memberCode += Environment.NewLine;
                if(string.IsNullOrEmpty(readCode) == false)
                    readCode += Environment.NewLine;
                if(string.IsNullOrEmpty(writeCode) == false)
                    writeCode += Environment.NewLine;

                string memberType = _reader.Name.ToLower();
                switch(memberType)
                {
                    case "byte":
                    case "sbyte":
                        break;
                    case "bool":
                    case "short":
                    case "ushort":
                    case "int":
                    case "long":
                    case "float":
                    case "double":
                        break;
                    case "string":
                        break;
                    case "list":
                        break;
                    default:
                        break;
                }
            }
            return new Tuple<string, string, string>(memberCode, readCode, writeCode);
        }
    }
}