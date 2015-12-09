using System;
using System.Runtime.InteropServices;
using Internal.Runtime.CompilerServices;
using System.Runtime.Serialization;

struct WcfSerializerEntry
{
    public int Key;
    public FixupRuntimeTypeHandle ItemType;
}

namespace System.Runtime.Serialization.Generated
{
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.Threading;
    using System.Xml;
    using System.Runtime.CompilerServices;

    // This file contains method that we use to inject WCF serializers.
    public static partial class DataContractSerializerHelper
    {
        static WcfSerializerEntry[] WcfSerializerEntryList { get { return s_wcfSerializerEntryList; } }

        public static void PopulateWcfSerializerDictionary(Dictionary<string, Type> wcfSerializers)
        {
            XmlDictionary xmlDict = new XmlDictionary();
            for (int i = 0; i < WcfSerializerEntryList.Length; i++)
            {
                string key = GetDictString(xmlDict, WcfSerializerEntryList[i].Key).Value;
                Type type = Type.GetTypeFromHandle(WcfSerializerEntryList[i].ItemType.RuntimeTypeHandle);
                wcfSerializers.Add(key, type);
            }
        }
    }
}
