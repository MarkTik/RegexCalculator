using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace RegexLearning
{
    [Serializable]
    public class MemoryManager
    {
        public MemoryManager()
        {
           
        }
        public string Pattern { get; set; }
        public string Input { get; set; }

        private XmlSerializer _serializer;
    }
}
