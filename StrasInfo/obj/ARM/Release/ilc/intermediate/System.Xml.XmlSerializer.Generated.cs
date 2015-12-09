namespace System.Runtime.CompilerServices {
    internal class __BlockReflectionAttribute : Attribute { }
}

namespace Microsoft.Xml.Serialization.GeneratedAssembly {

    public class StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageRechercheCodeArretrechercherCodesArretsDepuisLibelleAsyncSystemStringInt32Request { }
    public class StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageRechercheCodeArretrechercherCodesArretsDepuisLibelleAsyncSystemStringInt32Response { }
    public class StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageArriveesAppliWebrechercheProchainesArriveesWebAsyncSystemStringInt32SystemStringInt32Request { }
    public class StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageArriveesAppliWebrechercheProchainesArriveesWebAsyncSystemStringInt32SystemStringInt32Response { }
    public class StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageFichesHorairesrechercheFichesHorairesAsyncSystemStringRequest { }
    public class StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageFichesHorairesrechercheFichesHorairesAsyncSystemStringResponse { }
    public class StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageInfosTraficinfosTraficAsyncRequest { }
    public class StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageInfosTraficinfosTraficAsyncResponse { }
    public class StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageDeviationsdeviationsAsyncRequest { }
    public class StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageDeviationsdeviationsAsyncResponse { }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationWriterTypeInfo : System.Xml.Serialization.XmlSerializationWriter {

        public void Write16_Item(object[] p, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"http://www.cts-strasbourg.fr/";
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"rechercherCodesArretsDepuisLibelle", defaultNamespace, null, false);
            if (pLength > 0) {
                string namespace1 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                WriteElementString(@"Saisie", namespace1, ((global::System.String)p[0]));
            }
            if (pLength > 1) {
                string namespace2 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                WriteElementStringRaw(@"NoPage", namespace2, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)p[1])));
            }
            WriteEndElement();
        }

        public void Write17_Item(object[] p, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"http://www.cts-strasbourg.fr/";
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"rechercherCodesArretsDepuisLibelleResponse", defaultNamespace, null, false);
            if (pLength > 0) {
                string namespace3 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                Write9_MessageRechercheCodeArret(@"rechercherCodesArretsDepuisLibelleResult", namespace3, ((global::StrasInfo.StrasServiceSoap.MessageRechercheCodeArret)p[0]), false, false, namespace3, @"http://www.cts-strasbourg.fr/");
            }
            WriteEndElement();
        }

        public void Write18_rechercheProchainesArriveesWeb(object[] p, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"http://www.cts-strasbourg.fr/";
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"rechercheProchainesArriveesWeb", defaultNamespace, null, false);
            if (pLength > 0) {
                string namespace4 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                WriteElementString(@"CodeArret", namespace4, ((global::System.String)p[0]));
            }
            if (pLength > 1) {
                string namespace5 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                WriteElementStringRaw(@"Mode", namespace5, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)p[1])));
            }
            if (pLength > 2) {
                string namespace6 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                WriteElementString(@"Heure", namespace6, ((global::System.String)p[2]));
            }
            if (pLength > 3) {
                string namespace7 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                WriteElementStringRaw(@"NbHoraires", namespace7, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)p[3])));
            }
            WriteEndElement();
        }

        public void Write19_Item(object[] p, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"http://www.cts-strasbourg.fr/";
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"rechercheProchainesArriveesWebResponse", defaultNamespace, null, false);
            if (pLength > 0) {
                string namespace8 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                Write12_MessageArriveesAppliWeb(@"rechercheProchainesArriveesWebResult", namespace8, ((global::StrasInfo.StrasServiceSoap.MessageArriveesAppliWeb)p[0]), false, false, namespace8, @"http://www.cts-strasbourg.fr/");
            }
            WriteEndElement();
        }

        public void Write20_rechercheFichesHoraires(object[] p, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"http://www.cts-strasbourg.fr/";
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"rechercheFichesHoraires", defaultNamespace, null, false);
            if (pLength > 0) {
                string namespace9 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                WriteElementString(@"CodeArret", namespace9, ((global::System.String)p[0]));
            }
            WriteEndElement();
        }

        public void Write21_Item(object[] p, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"http://www.cts-strasbourg.fr/";
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"rechercheFichesHorairesResponse", defaultNamespace, null, false);
            if (pLength > 0) {
                string namespace10 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                Write15_MessageFichesHoraires(@"rechercheFichesHorairesResult", namespace10, ((global::StrasInfo.StrasServiceSoap.MessageFichesHoraires)p[0]), false, false, namespace10, @"http://www.cts-strasbourg.fr/");
            }
            WriteEndElement();
        }

        public void Write22_infosTrafic(object[] p, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"http://www.cts-strasbourg.fr/";
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"infosTrafic", defaultNamespace, null, false);
            WriteEndElement();
        }

        public void Write23_infosTraficResponse(object[] p, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"http://www.cts-strasbourg.fr/";
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"infosTraficResponse", defaultNamespace, null, false);
            if (pLength > 0) {
                string namespace11 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                Write6_MessageInfosTrafic(@"infosTraficResult", namespace11, ((global::StrasInfo.StrasServiceSoap.MessageInfosTrafic)p[0]), false, false, namespace11, @"http://www.cts-strasbourg.fr/");
            }
            WriteEndElement();
        }

        public void Write24_deviations(object[] p, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"http://www.cts-strasbourg.fr/";
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"deviations", defaultNamespace, null, false);
            WriteEndElement();
        }

        public void Write25_deviationsResponse(object[] p, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"http://www.cts-strasbourg.fr/";
            WriteStartDocument();
            TopLevelElement();
            int pLength = p.Length;
            WriteStartElement(@"deviationsResponse", defaultNamespace, null, false);
            if (pLength > 0) {
                string namespace12 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                Write3_MessageDeviations(@"deviationsResult", namespace12, ((global::StrasInfo.StrasServiceSoap.MessageDeviations)p[0]), false, false, namespace12, @"http://www.cts-strasbourg.fr/");
            }
            WriteEndElement();
        }

        void Write3_MessageDeviations(string n, string ns, global::StrasInfo.StrasServiceSoap.MessageDeviations o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::StrasInfo.StrasServiceSoap.MessageDeviations)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"MessageDeviations", defaultNamespace);
            string namespace13 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            {
                global::StrasInfo.StrasServiceSoap.Deviation[] a = (global::StrasInfo.StrasServiceSoap.Deviation[])((global::StrasInfo.StrasServiceSoap.Deviation[])o.@Deviations);
                if (a != null){
                    WriteStartElement(@"Deviations", namespace13, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace14 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                        Write2_Deviation(@"Deviation", namespace14, ((global::StrasInfo.StrasServiceSoap.Deviation)a[ia]), true, false, namespace14, @"http://www.cts-strasbourg.fr/");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write2_Deviation(string n, string ns, global::StrasInfo.StrasServiceSoap.Deviation o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::StrasInfo.StrasServiceSoap.Deviation)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Deviation", defaultNamespace);
            string namespace15 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementStringRaw(@"ID", namespace15, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@ID)));
            string namespace16 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementString(@"Titre", namespace16, ((global::System.String)o.@Titre));
            string namespace17 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementString(@"Description", namespace17, ((global::System.String)o.@Description));
            string namespace18 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementStringRaw(@"Debut", namespace18, FromDateTime(((global::System.DateTime)o.@Debut)));
            string namespace19 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementStringRaw(@"Fin", namespace19, FromDateTime(((global::System.DateTime)o.@Fin)));
            string namespace20 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementString(@"Categorie", namespace20, ((global::System.String)o.@Categorie));
            string namespace21 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementStringRaw(@"Exergue", namespace21, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@Exergue)));
            string namespace22 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementStringRaw(@"Position", namespace22, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Position)));
            string namespace23 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            {
                global::System.String[] a = (global::System.String[])((global::System.String[])o.@Lignes);
                if (a != null){
                    WriteStartElement(@"Lignes", namespace23, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace24 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                        WriteNullableStringLiteral(@"string", namespace24, ((global::System.String)a[ia]));
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write6_MessageInfosTrafic(string n, string ns, global::StrasInfo.StrasServiceSoap.MessageInfosTrafic o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::StrasInfo.StrasServiceSoap.MessageInfosTrafic)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"MessageInfosTrafic", defaultNamespace);
            string namespace25 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            {
                global::StrasInfo.StrasServiceSoap.InfoTrafic[] a = (global::StrasInfo.StrasServiceSoap.InfoTrafic[])((global::StrasInfo.StrasServiceSoap.InfoTrafic[])o.@InfosTrafic);
                if (a != null){
                    WriteStartElement(@"InfosTrafic", namespace25, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace26 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                        Write5_InfoTrafic(@"InfoTrafic", namespace26, ((global::StrasInfo.StrasServiceSoap.InfoTrafic)a[ia]), true, false, namespace26, @"http://www.cts-strasbourg.fr/");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write5_InfoTrafic(string n, string ns, global::StrasInfo.StrasServiceSoap.InfoTrafic o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::StrasInfo.StrasServiceSoap.InfoTrafic)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"InfoTrafic", defaultNamespace);
            string namespace27 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementStringRaw(@"ID", namespace27, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@ID)));
            string namespace28 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementString(@"Titre", namespace28, ((global::System.String)o.@Titre));
            string namespace29 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementString(@"Description", namespace29, ((global::System.String)o.@Description));
            string namespace30 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementStringRaw(@"Debut", namespace30, FromDateTime(((global::System.DateTime)o.@Debut)));
            string namespace31 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementStringRaw(@"Fin", namespace31, FromDateTime(((global::System.DateTime)o.@Fin)));
            WriteEndElement(o);
        }

        void Write15_MessageFichesHoraires(string n, string ns, global::StrasInfo.StrasServiceSoap.MessageFichesHoraires o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::StrasInfo.StrasServiceSoap.MessageFichesHoraires)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"MessageFichesHoraires", defaultNamespace);
            string namespace32 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            {
                global::StrasInfo.StrasServiceSoap.FicheHoraire[] a = (global::StrasInfo.StrasServiceSoap.FicheHoraire[])((global::StrasInfo.StrasServiceSoap.FicheHoraire[])o.@FichesHoraires);
                if (a != null){
                    WriteStartElement(@"FichesHoraires", namespace32, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace33 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                        Write14_FicheHoraire(@"FicheHoraire", namespace33, ((global::StrasInfo.StrasServiceSoap.FicheHoraire)a[ia]), true, false, namespace33, @"http://www.cts-strasbourg.fr/");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write14_FicheHoraire(string n, string ns, global::StrasInfo.StrasServiceSoap.FicheHoraire o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::StrasInfo.StrasServiceSoap.FicheHoraire)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"FicheHoraire", defaultNamespace);
            string namespace34 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementString(@"LibelleDestination", namespace34, ((global::System.String)o.@LibelleDestination));
            string namespace35 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementString(@"Url", namespace35, ((global::System.String)o.@Url));
            string namespace36 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementStringRaw(@"DebutValidite", namespace36, FromDateTime(((global::System.DateTime)o.@DebutValidite)));
            string namespace37 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementStringRaw(@"FinValidite", namespace37, FromDateTime(((global::System.DateTime)o.@FinValidite)));
            string namespace38 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementStringRaw(@"TypePeriode", namespace38, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@TypePeriode)));
            string namespace39 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementString(@"LibellePeriode", namespace39, ((global::System.String)o.@LibellePeriode));
            string namespace40 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementString(@"CodeArret", namespace40, ((global::System.String)o.@CodeArret));
            string namespace41 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementString(@"Ligne", namespace41, ((global::System.String)o.@Ligne));
            WriteEndElement(o);
        }

        void Write12_MessageArriveesAppliWeb(string n, string ns, global::StrasInfo.StrasServiceSoap.MessageArriveesAppliWeb o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::StrasInfo.StrasServiceSoap.MessageArriveesAppliWeb)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"MessageArriveesAppliWeb", defaultNamespace);
            string namespace42 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            {
                global::StrasInfo.StrasServiceSoap.Arrivee[] a = (global::StrasInfo.StrasServiceSoap.Arrivee[])((global::StrasInfo.StrasServiceSoap.Arrivee[])o.@ListeArrivee);
                if (a != null){
                    WriteStartElement(@"ListeArrivee", namespace42, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace43 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                        Write11_Arrivee(@"Arrivee", namespace43, ((global::StrasInfo.StrasServiceSoap.Arrivee)a[ia]), true, false, namespace43, @"http://www.cts-strasbourg.fr/");
                    }
                    WriteEndElement();
                }
            }
            string namespace44 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementString(@"LibelleArret", namespace44, ((global::System.String)o.@LibelleArret));
            string namespace45 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementString(@"HeureDemande", namespace45, ((global::System.String)o.@HeureDemande));
            WriteEndElement(o);
        }

        void Write11_Arrivee(string n, string ns, global::StrasInfo.StrasServiceSoap.Arrivee o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::StrasInfo.StrasServiceSoap.Arrivee)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Arrivee", defaultNamespace);
            string namespace46 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementString(@"Mode", namespace46, ((global::System.String)o.@Mode));
            string namespace47 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementString(@"Destination", namespace47, ((global::System.String)o.@Destination));
            string namespace48 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementString(@"Horaire", namespace48, ((global::System.String)o.@Horaire));
            string namespace49 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementStringRaw(@"EstApresMinuit", namespace49, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@EstApresMinuit)));
            WriteEndElement(o);
        }

        void Write9_MessageRechercheCodeArret(string n, string ns, global::StrasInfo.StrasServiceSoap.MessageRechercheCodeArret o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::StrasInfo.StrasServiceSoap.MessageRechercheCodeArret)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"MessageRechercheCodeArret", defaultNamespace);
            string namespace50 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementStringRaw(@"Suite", namespace50, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@Suite)));
            string namespace51 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            {
                global::StrasInfo.StrasServiceSoap.Arret[] a = (global::StrasInfo.StrasServiceSoap.Arret[])((global::StrasInfo.StrasServiceSoap.Arret[])o.@ListeArret);
                if (a != null){
                    WriteStartElement(@"ListeArret", namespace51, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace52 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
                        Write8_Arret(@"Arret", namespace52, ((global::StrasInfo.StrasServiceSoap.Arret)a[ia]), true, false, namespace52, @"http://www.cts-strasbourg.fr/");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write8_Arret(string n, string ns, global::StrasInfo.StrasServiceSoap.Arret o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::StrasInfo.StrasServiceSoap.Arret)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Arret", defaultNamespace);
            string namespace53 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementString(@"Libelle", namespace53, ((global::System.String)o.@Libelle));
            string namespace54 = ( parentCompileTimeNs == @"http://www.cts-strasbourg.fr/" && parentRuntimeNs != null ) ? parentRuntimeNs : @"http://www.cts-strasbourg.fr/";
            WriteElementString(@"Code", namespace54, ((global::System.String)o.@Code));
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationReaderTypeInfo : System.Xml.Serialization.XmlSerializationReader {

        public object[] Read16_Item(string defaultNamespace = null) {
            Reader.MoveToContent();
            object[] p = new object[2];
            p[1] = new global::System.Int32();
            Reader.MoveToContent();
            int whileIterations0 = 0;
            int readerCount0 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id1_Item, id2_httpwwwctsstrasbourgfr)) {
                    bool[] paramsRead = new bool[2];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations1 = 0;
                    int readerCount1 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            if (!paramsRead[0] && ((object) Reader.LocalName == (object)id3_Saisie && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                {
                                    p[0] = Reader.ReadElementContentAsString();
                                }
                                paramsRead[0] = true;
                            }
                            else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id4_NoPage && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                {
                                    p[1] = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                                }
                                paramsRead[1] = true;
                            }
                            else {
                                UnknownNode((object)p, @"http://www.cts-strasbourg.fr/:Saisie, http://www.cts-strasbourg.fr/:NoPage");
                            }
                        }
                        else {
                            UnknownNode((object)p, @"http://www.cts-strasbourg.fr/:Saisie, http://www.cts-strasbourg.fr/:NoPage");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations1, ref readerCount1);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://www.cts-strasbourg.fr/:rechercherCodesArretsDepuisLibelle");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations0, ref readerCount0);
            }
            return p;
        }

        public object[] Read17_Item(string defaultNamespace = null) {
            Reader.MoveToContent();
            object[] p = new object[1];
            Reader.MoveToContent();
            int whileIterations2 = 0;
            int readerCount2 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id5_Item, id2_httpwwwctsstrasbourgfr)) {
                    bool[] paramsRead = new bool[1];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations3 = 0;
                    int readerCount3 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            if (!paramsRead[0] && ((object) Reader.LocalName == (object)id6_Item && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                p[0] = Read9_MessageRechercheCodeArret(false, true, defaultNamespace);
                                paramsRead[0] = true;
                            }
                            else {
                                UnknownNode((object)p, @"http://www.cts-strasbourg.fr/:rechercherCodesArretsDepuisLibelleResult");
                            }
                        }
                        else {
                            UnknownNode((object)p, @"http://www.cts-strasbourg.fr/:rechercherCodesArretsDepuisLibelleResult");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations3, ref readerCount3);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://www.cts-strasbourg.fr/:rechercherCodesArretsDepuisLibelleResponse");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations2, ref readerCount2);
            }
            return p;
        }

        public object[] Read18_rechercheProchainesArriveesWeb(string defaultNamespace = null) {
            Reader.MoveToContent();
            object[] p = new object[4];
            p[1] = new global::System.Int32();
            p[3] = new global::System.Int32();
            Reader.MoveToContent();
            int whileIterations4 = 0;
            int readerCount4 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id7_rechercheProchainesArriveesWeb, id2_httpwwwctsstrasbourgfr)) {
                    bool[] paramsRead = new bool[4];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations5 = 0;
                    int readerCount5 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            if (!paramsRead[0] && ((object) Reader.LocalName == (object)id8_CodeArret && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                {
                                    p[0] = Reader.ReadElementContentAsString();
                                }
                                paramsRead[0] = true;
                            }
                            else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id9_Mode && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                {
                                    p[1] = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                                }
                                paramsRead[1] = true;
                            }
                            else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id10_Heure && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                {
                                    p[2] = Reader.ReadElementContentAsString();
                                }
                                paramsRead[2] = true;
                            }
                            else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id11_NbHoraires && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                {
                                    p[3] = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                                }
                                paramsRead[3] = true;
                            }
                            else {
                                UnknownNode((object)p, @"http://www.cts-strasbourg.fr/:CodeArret, http://www.cts-strasbourg.fr/:Mode, http://www.cts-strasbourg.fr/:Heure, http://www.cts-strasbourg.fr/:NbHoraires");
                            }
                        }
                        else {
                            UnknownNode((object)p, @"http://www.cts-strasbourg.fr/:CodeArret, http://www.cts-strasbourg.fr/:Mode, http://www.cts-strasbourg.fr/:Heure, http://www.cts-strasbourg.fr/:NbHoraires");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations5, ref readerCount5);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://www.cts-strasbourg.fr/:rechercheProchainesArriveesWeb");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations4, ref readerCount4);
            }
            return p;
        }

        public object[] Read19_Item(string defaultNamespace = null) {
            Reader.MoveToContent();
            object[] p = new object[1];
            Reader.MoveToContent();
            int whileIterations6 = 0;
            int readerCount6 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id12_Item, id2_httpwwwctsstrasbourgfr)) {
                    bool[] paramsRead = new bool[1];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations7 = 0;
                    int readerCount7 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            if (!paramsRead[0] && ((object) Reader.LocalName == (object)id13_Item && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                p[0] = Read12_MessageArriveesAppliWeb(false, true, defaultNamespace);
                                paramsRead[0] = true;
                            }
                            else {
                                UnknownNode((object)p, @"http://www.cts-strasbourg.fr/:rechercheProchainesArriveesWebResult");
                            }
                        }
                        else {
                            UnknownNode((object)p, @"http://www.cts-strasbourg.fr/:rechercheProchainesArriveesWebResult");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations7, ref readerCount7);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://www.cts-strasbourg.fr/:rechercheProchainesArriveesWebResponse");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations6, ref readerCount6);
            }
            return p;
        }

        public object[] Read20_rechercheFichesHoraires(string defaultNamespace = null) {
            Reader.MoveToContent();
            object[] p = new object[1];
            Reader.MoveToContent();
            int whileIterations8 = 0;
            int readerCount8 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id14_rechercheFichesHoraires, id2_httpwwwctsstrasbourgfr)) {
                    bool[] paramsRead = new bool[1];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations9 = 0;
                    int readerCount9 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            if (!paramsRead[0] && ((object) Reader.LocalName == (object)id8_CodeArret && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                {
                                    p[0] = Reader.ReadElementContentAsString();
                                }
                                paramsRead[0] = true;
                            }
                            else {
                                UnknownNode((object)p, @"http://www.cts-strasbourg.fr/:CodeArret");
                            }
                        }
                        else {
                            UnknownNode((object)p, @"http://www.cts-strasbourg.fr/:CodeArret");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations9, ref readerCount9);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://www.cts-strasbourg.fr/:rechercheFichesHoraires");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations8, ref readerCount8);
            }
            return p;
        }

        public object[] Read21_Item(string defaultNamespace = null) {
            Reader.MoveToContent();
            object[] p = new object[1];
            Reader.MoveToContent();
            int whileIterations10 = 0;
            int readerCount10 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id15_Item, id2_httpwwwctsstrasbourgfr)) {
                    bool[] paramsRead = new bool[1];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations11 = 0;
                    int readerCount11 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            if (!paramsRead[0] && ((object) Reader.LocalName == (object)id16_rechercheFichesHorairesResult && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                p[0] = Read15_MessageFichesHoraires(false, true, defaultNamespace);
                                paramsRead[0] = true;
                            }
                            else {
                                UnknownNode((object)p, @"http://www.cts-strasbourg.fr/:rechercheFichesHorairesResult");
                            }
                        }
                        else {
                            UnknownNode((object)p, @"http://www.cts-strasbourg.fr/:rechercheFichesHorairesResult");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations11, ref readerCount11);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://www.cts-strasbourg.fr/:rechercheFichesHorairesResponse");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations10, ref readerCount10);
            }
            return p;
        }

        public object[] Read22_infosTrafic(string defaultNamespace = null) {
            Reader.MoveToContent();
            object[] p = new object[0];
            Reader.MoveToContent();
            int whileIterations12 = 0;
            int readerCount12 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id17_infosTrafic, id2_httpwwwctsstrasbourgfr)) {
                    bool[] paramsRead = new bool[0];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations13 = 0;
                    int readerCount13 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            UnknownNode((object)p, @"");
                        }
                        else {
                            UnknownNode((object)p, @"");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations13, ref readerCount13);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://www.cts-strasbourg.fr/:infosTrafic");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations12, ref readerCount12);
            }
            return p;
        }

        public object[] Read23_infosTraficResponse(string defaultNamespace = null) {
            Reader.MoveToContent();
            object[] p = new object[1];
            Reader.MoveToContent();
            int whileIterations14 = 0;
            int readerCount14 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id18_infosTraficResponse, id2_httpwwwctsstrasbourgfr)) {
                    bool[] paramsRead = new bool[1];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations15 = 0;
                    int readerCount15 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            if (!paramsRead[0] && ((object) Reader.LocalName == (object)id19_infosTraficResult && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                p[0] = Read6_MessageInfosTrafic(false, true, defaultNamespace);
                                paramsRead[0] = true;
                            }
                            else {
                                UnknownNode((object)p, @"http://www.cts-strasbourg.fr/:infosTraficResult");
                            }
                        }
                        else {
                            UnknownNode((object)p, @"http://www.cts-strasbourg.fr/:infosTraficResult");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations15, ref readerCount15);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://www.cts-strasbourg.fr/:infosTraficResponse");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations14, ref readerCount14);
            }
            return p;
        }

        public object[] Read24_deviations(string defaultNamespace = null) {
            Reader.MoveToContent();
            object[] p = new object[0];
            Reader.MoveToContent();
            int whileIterations16 = 0;
            int readerCount16 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id20_deviations, id2_httpwwwctsstrasbourgfr)) {
                    bool[] paramsRead = new bool[0];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations17 = 0;
                    int readerCount17 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            UnknownNode((object)p, @"");
                        }
                        else {
                            UnknownNode((object)p, @"");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations17, ref readerCount17);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://www.cts-strasbourg.fr/:deviations");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations16, ref readerCount16);
            }
            return p;
        }

        public object[] Read25_deviationsResponse(string defaultNamespace = null) {
            Reader.MoveToContent();
            object[] p = new object[1];
            Reader.MoveToContent();
            int whileIterations18 = 0;
            int readerCount18 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.IsStartElement(id21_deviationsResponse, id2_httpwwwctsstrasbourgfr)) {
                    bool[] paramsRead = new bool[1];
                    if (Reader.IsEmptyElement) { Reader.Skip(); Reader.MoveToContent(); continue; }
                    Reader.ReadStartElement();
                    Reader.MoveToContent();
                    int whileIterations19 = 0;
                    int readerCount19 = ReaderCount;
                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                            if (!paramsRead[0] && ((object) Reader.LocalName == (object)id22_deviationsResult && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                p[0] = Read3_MessageDeviations(false, true, defaultNamespace);
                                paramsRead[0] = true;
                            }
                            else {
                                UnknownNode((object)p, @"http://www.cts-strasbourg.fr/:deviationsResult");
                            }
                        }
                        else {
                            UnknownNode((object)p, @"http://www.cts-strasbourg.fr/:deviationsResult");
                        }
                        Reader.MoveToContent();
                        CheckReaderCount(ref whileIterations19, ref readerCount19);
                    }
                    ReadEndElement();
                }
                else {
                    UnknownNode(null, @"http://www.cts-strasbourg.fr/:deviationsResponse");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations18, ref readerCount18);
            }
            return p;
        }

        global::StrasInfo.StrasServiceSoap.MessageDeviations Read3_MessageDeviations(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id23_MessageDeviations && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::StrasInfo.StrasServiceSoap.MessageDeviations o;
            o = new global::StrasInfo.StrasServiceSoap.MessageDeviations();
            global::StrasInfo.StrasServiceSoap.Deviation[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            int state = 0;
            Reader.MoveToContent();
            int whileIterations20 = 0;
            int readerCount20 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    switch (state) {
                    case 0:
                        if (((object) Reader.LocalName == (object)id24_Deviations && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            if (!ReadNull()) {
                                global::StrasInfo.StrasServiceSoap.Deviation[] a_0_0 = null;
                                int ca_0_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations21 = 0;
                                    int readerCount21 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id25_Deviation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                                a_0_0 = (global::StrasInfo.StrasServiceSoap.Deviation[])EnsureArrayIndex(a_0_0, ca_0_0, typeof(global::StrasInfo.StrasServiceSoap.Deviation));a_0_0[ca_0_0++] = Read2_Deviation(true, true, defaultNamespace);
                                            }
                                            else {
                                                UnknownNode(null, @"http://www.cts-strasbourg.fr/:Deviation");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @"http://www.cts-strasbourg.fr/:Deviation");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations21, ref readerCount21);
                                    }
                                ReadEndElement();
                                }
                                o.@Deviations = (global::StrasInfo.StrasServiceSoap.Deviation[])ShrinkArray(a_0_0, ca_0_0, typeof(global::StrasInfo.StrasServiceSoap.Deviation), false);
                            }
                        }
                        else {
                            state = 1;
                        }
                        break;
                    default:
                        UnknownNode((object)o, null);
                        break;
                    }
                }
                else {
                    UnknownNode((object)o, null);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations20, ref readerCount20);
            }
            ReadEndElement();
            return o;
        }

        global::StrasInfo.StrasServiceSoap.Deviation Read2_Deviation(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id25_Deviation && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::StrasInfo.StrasServiceSoap.Deviation o;
            o = new global::StrasInfo.StrasServiceSoap.Deviation();
            global::System.String[] a_8 = null;
            int ca_8 = 0;
            bool[] paramsRead = new bool[9];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            int state = 0;
            Reader.MoveToContent();
            int whileIterations22 = 0;
            int readerCount22 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    switch (state) {
                    case 0:
                        if (((object) Reader.LocalName == (object)id26_ID && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@ID = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                            }
                        }
                        state = 1;
                        break;
                    case 1:
                        if (((object) Reader.LocalName == (object)id27_Titre && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Titre = Reader.ReadElementContentAsString();
                            }
                        }
                        state = 2;
                        break;
                    case 2:
                        if (((object) Reader.LocalName == (object)id28_Description && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Description = Reader.ReadElementContentAsString();
                            }
                        }
                        state = 3;
                        break;
                    case 3:
                        if (((object) Reader.LocalName == (object)id29_Debut && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Debut = ToDateTime(Reader.ReadElementContentAsString());
                            }
                        }
                        state = 4;
                        break;
                    case 4:
                        if (((object) Reader.LocalName == (object)id30_Fin && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Fin = ToDateTime(Reader.ReadElementContentAsString());
                            }
                        }
                        state = 5;
                        break;
                    case 5:
                        if (((object) Reader.LocalName == (object)id31_Categorie && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Categorie = Reader.ReadElementContentAsString();
                            }
                        }
                        state = 6;
                        break;
                    case 6:
                        if (((object) Reader.LocalName == (object)id32_Exergue && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Exergue = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                            }
                        }
                        state = 7;
                        break;
                    case 7:
                        if (((object) Reader.LocalName == (object)id33_Position && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Position = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                            }
                        }
                        state = 8;
                        break;
                    case 8:
                        if (((object) Reader.LocalName == (object)id34_Lignes && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            if (!ReadNull()) {
                                global::System.String[] a_8_0 = null;
                                int ca_8_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations23 = 0;
                                    int readerCount23 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id35_string && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                                if (ReadNull()) {
                                                    a_8_0 = (global::System.String[])EnsureArrayIndex(a_8_0, ca_8_0, typeof(global::System.String));a_8_0[ca_8_0++] = null;
                                                }
                                                else {
                                                    a_8_0 = (global::System.String[])EnsureArrayIndex(a_8_0, ca_8_0, typeof(global::System.String));a_8_0[ca_8_0++] = Reader.ReadElementContentAsString();
                                                }
                                            }
                                            else {
                                                UnknownNode(null, @"http://www.cts-strasbourg.fr/:string");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @"http://www.cts-strasbourg.fr/:string");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations23, ref readerCount23);
                                    }
                                ReadEndElement();
                                }
                                o.@Lignes = (global::System.String[])ShrinkArray(a_8_0, ca_8_0, typeof(global::System.String), false);
                            }
                        }
                        else {
                            state = 9;
                        }
                        break;
                    default:
                        UnknownNode((object)o, null);
                        break;
                    }
                }
                else {
                    UnknownNode((object)o, null);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations22, ref readerCount22);
            }
            ReadEndElement();
            return o;
        }

        global::StrasInfo.StrasServiceSoap.MessageInfosTrafic Read6_MessageInfosTrafic(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id36_MessageInfosTrafic && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::StrasInfo.StrasServiceSoap.MessageInfosTrafic o;
            o = new global::StrasInfo.StrasServiceSoap.MessageInfosTrafic();
            global::StrasInfo.StrasServiceSoap.InfoTrafic[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            int state = 0;
            Reader.MoveToContent();
            int whileIterations24 = 0;
            int readerCount24 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    switch (state) {
                    case 0:
                        if (((object) Reader.LocalName == (object)id37_InfosTrafic && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            if (!ReadNull()) {
                                global::StrasInfo.StrasServiceSoap.InfoTrafic[] a_0_0 = null;
                                int ca_0_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations25 = 0;
                                    int readerCount25 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id38_InfoTrafic && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                                a_0_0 = (global::StrasInfo.StrasServiceSoap.InfoTrafic[])EnsureArrayIndex(a_0_0, ca_0_0, typeof(global::StrasInfo.StrasServiceSoap.InfoTrafic));a_0_0[ca_0_0++] = Read5_InfoTrafic(true, true, defaultNamespace);
                                            }
                                            else {
                                                UnknownNode(null, @"http://www.cts-strasbourg.fr/:InfoTrafic");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @"http://www.cts-strasbourg.fr/:InfoTrafic");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations25, ref readerCount25);
                                    }
                                ReadEndElement();
                                }
                                o.@InfosTrafic = (global::StrasInfo.StrasServiceSoap.InfoTrafic[])ShrinkArray(a_0_0, ca_0_0, typeof(global::StrasInfo.StrasServiceSoap.InfoTrafic), false);
                            }
                        }
                        else {
                            state = 1;
                        }
                        break;
                    default:
                        UnknownNode((object)o, null);
                        break;
                    }
                }
                else {
                    UnknownNode((object)o, null);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations24, ref readerCount24);
            }
            ReadEndElement();
            return o;
        }

        global::StrasInfo.StrasServiceSoap.InfoTrafic Read5_InfoTrafic(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id38_InfoTrafic && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::StrasInfo.StrasServiceSoap.InfoTrafic o;
            o = new global::StrasInfo.StrasServiceSoap.InfoTrafic();
            bool[] paramsRead = new bool[5];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            int state = 0;
            Reader.MoveToContent();
            int whileIterations26 = 0;
            int readerCount26 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    switch (state) {
                    case 0:
                        if (((object) Reader.LocalName == (object)id26_ID && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@ID = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                            }
                        }
                        state = 1;
                        break;
                    case 1:
                        if (((object) Reader.LocalName == (object)id27_Titre && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Titre = Reader.ReadElementContentAsString();
                            }
                        }
                        state = 2;
                        break;
                    case 2:
                        if (((object) Reader.LocalName == (object)id28_Description && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Description = Reader.ReadElementContentAsString();
                            }
                        }
                        state = 3;
                        break;
                    case 3:
                        if (((object) Reader.LocalName == (object)id29_Debut && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Debut = ToDateTime(Reader.ReadElementContentAsString());
                            }
                        }
                        state = 4;
                        break;
                    case 4:
                        if (((object) Reader.LocalName == (object)id30_Fin && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Fin = ToDateTime(Reader.ReadElementContentAsString());
                            }
                        }
                        state = 5;
                        break;
                    default:
                        UnknownNode((object)o, null);
                        break;
                    }
                }
                else {
                    UnknownNode((object)o, null);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations26, ref readerCount26);
            }
            ReadEndElement();
            return o;
        }

        global::StrasInfo.StrasServiceSoap.MessageFichesHoraires Read15_MessageFichesHoraires(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id39_MessageFichesHoraires && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::StrasInfo.StrasServiceSoap.MessageFichesHoraires o;
            o = new global::StrasInfo.StrasServiceSoap.MessageFichesHoraires();
            global::StrasInfo.StrasServiceSoap.FicheHoraire[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            int state = 0;
            Reader.MoveToContent();
            int whileIterations27 = 0;
            int readerCount27 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    switch (state) {
                    case 0:
                        if (((object) Reader.LocalName == (object)id40_FichesHoraires && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            if (!ReadNull()) {
                                global::StrasInfo.StrasServiceSoap.FicheHoraire[] a_0_0 = null;
                                int ca_0_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations28 = 0;
                                    int readerCount28 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id41_FicheHoraire && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                                a_0_0 = (global::StrasInfo.StrasServiceSoap.FicheHoraire[])EnsureArrayIndex(a_0_0, ca_0_0, typeof(global::StrasInfo.StrasServiceSoap.FicheHoraire));a_0_0[ca_0_0++] = Read14_FicheHoraire(true, true, defaultNamespace);
                                            }
                                            else {
                                                UnknownNode(null, @"http://www.cts-strasbourg.fr/:FicheHoraire");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @"http://www.cts-strasbourg.fr/:FicheHoraire");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations28, ref readerCount28);
                                    }
                                ReadEndElement();
                                }
                                o.@FichesHoraires = (global::StrasInfo.StrasServiceSoap.FicheHoraire[])ShrinkArray(a_0_0, ca_0_0, typeof(global::StrasInfo.StrasServiceSoap.FicheHoraire), false);
                            }
                        }
                        else {
                            state = 1;
                        }
                        break;
                    default:
                        UnknownNode((object)o, null);
                        break;
                    }
                }
                else {
                    UnknownNode((object)o, null);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations27, ref readerCount27);
            }
            ReadEndElement();
            return o;
        }

        global::StrasInfo.StrasServiceSoap.FicheHoraire Read14_FicheHoraire(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id41_FicheHoraire && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::StrasInfo.StrasServiceSoap.FicheHoraire o;
            o = new global::StrasInfo.StrasServiceSoap.FicheHoraire();
            bool[] paramsRead = new bool[8];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            int state = 0;
            Reader.MoveToContent();
            int whileIterations29 = 0;
            int readerCount29 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    switch (state) {
                    case 0:
                        if (((object) Reader.LocalName == (object)id42_LibelleDestination && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@LibelleDestination = Reader.ReadElementContentAsString();
                            }
                        }
                        state = 1;
                        break;
                    case 1:
                        if (((object) Reader.LocalName == (object)id43_Url && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Url = Reader.ReadElementContentAsString();
                            }
                        }
                        state = 2;
                        break;
                    case 2:
                        if (((object) Reader.LocalName == (object)id44_DebutValidite && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@DebutValidite = ToDateTime(Reader.ReadElementContentAsString());
                            }
                        }
                        state = 3;
                        break;
                    case 3:
                        if (((object) Reader.LocalName == (object)id45_FinValidite && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@FinValidite = ToDateTime(Reader.ReadElementContentAsString());
                            }
                        }
                        state = 4;
                        break;
                    case 4:
                        if (((object) Reader.LocalName == (object)id46_TypePeriode && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@TypePeriode = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                            }
                        }
                        state = 5;
                        break;
                    case 5:
                        if (((object) Reader.LocalName == (object)id47_LibellePeriode && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@LibellePeriode = Reader.ReadElementContentAsString();
                            }
                        }
                        state = 6;
                        break;
                    case 6:
                        if (((object) Reader.LocalName == (object)id8_CodeArret && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@CodeArret = Reader.ReadElementContentAsString();
                            }
                        }
                        state = 7;
                        break;
                    case 7:
                        if (((object) Reader.LocalName == (object)id48_Ligne && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Ligne = Reader.ReadElementContentAsString();
                            }
                        }
                        state = 8;
                        break;
                    default:
                        UnknownNode((object)o, null);
                        break;
                    }
                }
                else {
                    UnknownNode((object)o, null);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations29, ref readerCount29);
            }
            ReadEndElement();
            return o;
        }

        global::StrasInfo.StrasServiceSoap.MessageArriveesAppliWeb Read12_MessageArriveesAppliWeb(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id49_MessageArriveesAppliWeb && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::StrasInfo.StrasServiceSoap.MessageArriveesAppliWeb o;
            o = new global::StrasInfo.StrasServiceSoap.MessageArriveesAppliWeb();
            global::StrasInfo.StrasServiceSoap.Arrivee[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            int state = 0;
            Reader.MoveToContent();
            int whileIterations30 = 0;
            int readerCount30 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    switch (state) {
                    case 0:
                        if (((object) Reader.LocalName == (object)id50_ListeArrivee && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            if (!ReadNull()) {
                                global::StrasInfo.StrasServiceSoap.Arrivee[] a_0_0 = null;
                                int ca_0_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations31 = 0;
                                    int readerCount31 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id51_Arrivee && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                                a_0_0 = (global::StrasInfo.StrasServiceSoap.Arrivee[])EnsureArrayIndex(a_0_0, ca_0_0, typeof(global::StrasInfo.StrasServiceSoap.Arrivee));a_0_0[ca_0_0++] = Read11_Arrivee(true, true, defaultNamespace);
                                            }
                                            else {
                                                UnknownNode(null, @"http://www.cts-strasbourg.fr/:Arrivee");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @"http://www.cts-strasbourg.fr/:Arrivee");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations31, ref readerCount31);
                                    }
                                ReadEndElement();
                                }
                                o.@ListeArrivee = (global::StrasInfo.StrasServiceSoap.Arrivee[])ShrinkArray(a_0_0, ca_0_0, typeof(global::StrasInfo.StrasServiceSoap.Arrivee), false);
                            }
                        }
                        else {
                            state = 1;
                        }
                        break;
                    case 1:
                        if (((object) Reader.LocalName == (object)id52_LibelleArret && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@LibelleArret = Reader.ReadElementContentAsString();
                            }
                        }
                        state = 2;
                        break;
                    case 2:
                        if (((object) Reader.LocalName == (object)id53_HeureDemande && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@HeureDemande = Reader.ReadElementContentAsString();
                            }
                        }
                        state = 3;
                        break;
                    default:
                        UnknownNode((object)o, null);
                        break;
                    }
                }
                else {
                    UnknownNode((object)o, null);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations30, ref readerCount30);
            }
            ReadEndElement();
            return o;
        }

        global::StrasInfo.StrasServiceSoap.Arrivee Read11_Arrivee(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id51_Arrivee && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::StrasInfo.StrasServiceSoap.Arrivee o;
            o = new global::StrasInfo.StrasServiceSoap.Arrivee();
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            int state = 0;
            Reader.MoveToContent();
            int whileIterations32 = 0;
            int readerCount32 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    switch (state) {
                    case 0:
                        if (((object) Reader.LocalName == (object)id9_Mode && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Mode = Reader.ReadElementContentAsString();
                            }
                        }
                        state = 1;
                        break;
                    case 1:
                        if (((object) Reader.LocalName == (object)id54_Destination && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Destination = Reader.ReadElementContentAsString();
                            }
                        }
                        state = 2;
                        break;
                    case 2:
                        if (((object) Reader.LocalName == (object)id55_Horaire && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Horaire = Reader.ReadElementContentAsString();
                            }
                        }
                        state = 3;
                        break;
                    case 3:
                        if (((object) Reader.LocalName == (object)id56_EstApresMinuit && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@EstApresMinuit = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                            }
                        }
                        state = 4;
                        break;
                    default:
                        UnknownNode((object)o, null);
                        break;
                    }
                }
                else {
                    UnknownNode((object)o, null);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations32, ref readerCount32);
            }
            ReadEndElement();
            return o;
        }

        global::StrasInfo.StrasServiceSoap.MessageRechercheCodeArret Read9_MessageRechercheCodeArret(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id57_MessageRechercheCodeArret && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::StrasInfo.StrasServiceSoap.MessageRechercheCodeArret o;
            o = new global::StrasInfo.StrasServiceSoap.MessageRechercheCodeArret();
            global::StrasInfo.StrasServiceSoap.Arret[] a_1 = null;
            int ca_1 = 0;
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            int state = 0;
            Reader.MoveToContent();
            int whileIterations33 = 0;
            int readerCount33 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    switch (state) {
                    case 0:
                        if (((object) Reader.LocalName == (object)id58_Suite && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Suite = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                            }
                        }
                        state = 1;
                        break;
                    case 1:
                        if (((object) Reader.LocalName == (object)id59_ListeArret && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            if (!ReadNull()) {
                                global::StrasInfo.StrasServiceSoap.Arret[] a_1_0 = null;
                                int ca_1_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations34 = 0;
                                    int readerCount34 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            if (((object) Reader.LocalName == (object)id60_Arret && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                                                a_1_0 = (global::StrasInfo.StrasServiceSoap.Arret[])EnsureArrayIndex(a_1_0, ca_1_0, typeof(global::StrasInfo.StrasServiceSoap.Arret));a_1_0[ca_1_0++] = Read8_Arret(true, true, defaultNamespace);
                                            }
                                            else {
                                                UnknownNode(null, @"http://www.cts-strasbourg.fr/:Arret");
                                            }
                                        }
                                        else {
                                            UnknownNode(null, @"http://www.cts-strasbourg.fr/:Arret");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations34, ref readerCount34);
                                    }
                                ReadEndElement();
                                }
                                o.@ListeArret = (global::StrasInfo.StrasServiceSoap.Arret[])ShrinkArray(a_1_0, ca_1_0, typeof(global::StrasInfo.StrasServiceSoap.Arret), false);
                            }
                        }
                        else {
                            state = 2;
                        }
                        break;
                    default:
                        UnknownNode((object)o, null);
                        break;
                    }
                }
                else {
                    UnknownNode((object)o, null);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations33, ref readerCount33);
            }
            ReadEndElement();
            return o;
        }

        global::StrasInfo.StrasServiceSoap.Arret Read8_Arret(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id60_Arret && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::StrasInfo.StrasServiceSoap.Arret o;
            o = new global::StrasInfo.StrasServiceSoap.Arret();
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            int state = 0;
            Reader.MoveToContent();
            int whileIterations35 = 0;
            int readerCount35 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    switch (state) {
                    case 0:
                        if (((object) Reader.LocalName == (object)id61_Libelle && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Libelle = Reader.ReadElementContentAsString();
                            }
                        }
                        state = 1;
                        break;
                    case 1:
                        if (((object) Reader.LocalName == (object)id62_Code && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_httpwwwctsstrasbourgfr))) {
                            {
                                o.@Code = Reader.ReadElementContentAsString();
                            }
                        }
                        state = 2;
                        break;
                    default:
                        UnknownNode((object)o, null);
                        break;
                    }
                }
                else {
                    UnknownNode((object)o, null);
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations35, ref readerCount35);
            }
            ReadEndElement();
            return o;
        }

        protected override void InitCallbacks() {
        }

        string id33_Position;
        string id5_Item;
        string id47_LibellePeriode;
        string id60_Arret;
        string id21_deviationsResponse;
        string id61_Libelle;
        string id39_MessageFichesHoraires;
        string id38_InfoTrafic;
        string id34_Lignes;
        string id28_Description;
        string id29_Debut;
        string id15_Item;
        string id24_Deviations;
        string id23_MessageDeviations;
        string id6_Item;
        string id35_string;
        string id56_EstApresMinuit;
        string id53_HeureDemande;
        string id43_Url;
        string id46_TypePeriode;
        string id51_Arrivee;
        string id26_ID;
        string id18_infosTraficResponse;
        string id13_Item;
        string id31_Categorie;
        string id19_infosTraficResult;
        string id8_CodeArret;
        string id30_Fin;
        string id17_infosTrafic;
        string id44_DebutValidite;
        string id54_Destination;
        string id36_MessageInfosTrafic;
        string id45_FinValidite;
        string id11_NbHoraires;
        string id22_deviationsResult;
        string id10_Heure;
        string id27_Titre;
        string id42_LibelleDestination;
        string id32_Exergue;
        string id62_Code;
        string id12_Item;
        string id4_NoPage;
        string id16_rechercheFichesHorairesResult;
        string id58_Suite;
        string id48_Ligne;
        string id59_ListeArret;
        string id14_rechercheFichesHoraires;
        string id41_FicheHoraire;
        string id9_Mode;
        string id2_httpwwwctsstrasbourgfr;
        string id20_deviations;
        string id49_MessageArriveesAppliWeb;
        string id25_Deviation;
        string id55_Horaire;
        string id7_rechercheProchainesArriveesWeb;
        string id52_LibelleArret;
        string id57_MessageRechercheCodeArret;
        string id37_InfosTrafic;
        string id40_FichesHoraires;
        string id50_ListeArrivee;
        string id3_Saisie;
        string id1_Item;

        protected override void InitIDs() {
            id33_Position = Reader.NameTable.Add(@"Position");
            id5_Item = Reader.NameTable.Add(@"rechercherCodesArretsDepuisLibelleResponse");
            id47_LibellePeriode = Reader.NameTable.Add(@"LibellePeriode");
            id60_Arret = Reader.NameTable.Add(@"Arret");
            id21_deviationsResponse = Reader.NameTable.Add(@"deviationsResponse");
            id61_Libelle = Reader.NameTable.Add(@"Libelle");
            id39_MessageFichesHoraires = Reader.NameTable.Add(@"MessageFichesHoraires");
            id38_InfoTrafic = Reader.NameTable.Add(@"InfoTrafic");
            id34_Lignes = Reader.NameTable.Add(@"Lignes");
            id28_Description = Reader.NameTable.Add(@"Description");
            id29_Debut = Reader.NameTable.Add(@"Debut");
            id15_Item = Reader.NameTable.Add(@"rechercheFichesHorairesResponse");
            id24_Deviations = Reader.NameTable.Add(@"Deviations");
            id23_MessageDeviations = Reader.NameTable.Add(@"MessageDeviations");
            id6_Item = Reader.NameTable.Add(@"rechercherCodesArretsDepuisLibelleResult");
            id35_string = Reader.NameTable.Add(@"string");
            id56_EstApresMinuit = Reader.NameTable.Add(@"EstApresMinuit");
            id53_HeureDemande = Reader.NameTable.Add(@"HeureDemande");
            id43_Url = Reader.NameTable.Add(@"Url");
            id46_TypePeriode = Reader.NameTable.Add(@"TypePeriode");
            id51_Arrivee = Reader.NameTable.Add(@"Arrivee");
            id26_ID = Reader.NameTable.Add(@"ID");
            id18_infosTraficResponse = Reader.NameTable.Add(@"infosTraficResponse");
            id13_Item = Reader.NameTable.Add(@"rechercheProchainesArriveesWebResult");
            id31_Categorie = Reader.NameTable.Add(@"Categorie");
            id19_infosTraficResult = Reader.NameTable.Add(@"infosTraficResult");
            id8_CodeArret = Reader.NameTable.Add(@"CodeArret");
            id30_Fin = Reader.NameTable.Add(@"Fin");
            id17_infosTrafic = Reader.NameTable.Add(@"infosTrafic");
            id44_DebutValidite = Reader.NameTable.Add(@"DebutValidite");
            id54_Destination = Reader.NameTable.Add(@"Destination");
            id36_MessageInfosTrafic = Reader.NameTable.Add(@"MessageInfosTrafic");
            id45_FinValidite = Reader.NameTable.Add(@"FinValidite");
            id11_NbHoraires = Reader.NameTable.Add(@"NbHoraires");
            id22_deviationsResult = Reader.NameTable.Add(@"deviationsResult");
            id10_Heure = Reader.NameTable.Add(@"Heure");
            id27_Titre = Reader.NameTable.Add(@"Titre");
            id42_LibelleDestination = Reader.NameTable.Add(@"LibelleDestination");
            id32_Exergue = Reader.NameTable.Add(@"Exergue");
            id62_Code = Reader.NameTable.Add(@"Code");
            id12_Item = Reader.NameTable.Add(@"rechercheProchainesArriveesWebResponse");
            id4_NoPage = Reader.NameTable.Add(@"NoPage");
            id16_rechercheFichesHorairesResult = Reader.NameTable.Add(@"rechercheFichesHorairesResult");
            id58_Suite = Reader.NameTable.Add(@"Suite");
            id48_Ligne = Reader.NameTable.Add(@"Ligne");
            id59_ListeArret = Reader.NameTable.Add(@"ListeArret");
            id14_rechercheFichesHoraires = Reader.NameTable.Add(@"rechercheFichesHoraires");
            id41_FicheHoraire = Reader.NameTable.Add(@"FicheHoraire");
            id9_Mode = Reader.NameTable.Add(@"Mode");
            id2_httpwwwctsstrasbourgfr = Reader.NameTable.Add(@"http://www.cts-strasbourg.fr/");
            id20_deviations = Reader.NameTable.Add(@"deviations");
            id49_MessageArriveesAppliWeb = Reader.NameTable.Add(@"MessageArriveesAppliWeb");
            id25_Deviation = Reader.NameTable.Add(@"Deviation");
            id55_Horaire = Reader.NameTable.Add(@"Horaire");
            id7_rechercheProchainesArriveesWeb = Reader.NameTable.Add(@"rechercheProchainesArriveesWeb");
            id52_LibelleArret = Reader.NameTable.Add(@"LibelleArret");
            id57_MessageRechercheCodeArret = Reader.NameTable.Add(@"MessageRechercheCodeArret");
            id37_InfosTrafic = Reader.NameTable.Add(@"InfosTrafic");
            id40_FichesHoraires = Reader.NameTable.Add(@"FichesHoraires");
            id50_ListeArrivee = Reader.NameTable.Add(@"ListeArrivee");
            id3_Saisie = Reader.NameTable.Add(@"Saisie");
            id1_Item = Reader.NameTable.Add(@"rechercherCodesArretsDepuisLibelle");
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReaderTypeInfo();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriterTypeInfo();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class ArrayOfObjectSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"rechercherCodesArretsDepuisLibelle", this.DefaultNamespace ?? @"http://www.cts-strasbourg.fr/");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterTypeInfo)writer).Write16_Item((object[])objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderTypeInfo)reader).Read16_Item();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class ArrayOfObjectSerializer1 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"rechercherCodesArretsDepuisLibelleResponse", this.DefaultNamespace ?? @"http://www.cts-strasbourg.fr/");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterTypeInfo)writer).Write17_Item((object[])objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderTypeInfo)reader).Read17_Item();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class ArrayOfObjectSerializer2 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"rechercheProchainesArriveesWeb", this.DefaultNamespace ?? @"http://www.cts-strasbourg.fr/");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterTypeInfo)writer).Write18_rechercheProchainesArriveesWeb((object[])objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderTypeInfo)reader).Read18_rechercheProchainesArriveesWeb();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class ArrayOfObjectSerializer3 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"rechercheProchainesArriveesWebResponse", this.DefaultNamespace ?? @"http://www.cts-strasbourg.fr/");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterTypeInfo)writer).Write19_Item((object[])objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderTypeInfo)reader).Read19_Item();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class ArrayOfObjectSerializer4 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"rechercheFichesHoraires", this.DefaultNamespace ?? @"http://www.cts-strasbourg.fr/");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterTypeInfo)writer).Write20_rechercheFichesHoraires((object[])objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderTypeInfo)reader).Read20_rechercheFichesHoraires();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class ArrayOfObjectSerializer5 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"rechercheFichesHorairesResponse", this.DefaultNamespace ?? @"http://www.cts-strasbourg.fr/");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterTypeInfo)writer).Write21_Item((object[])objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderTypeInfo)reader).Read21_Item();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class ArrayOfObjectSerializer6 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"infosTrafic", this.DefaultNamespace ?? @"http://www.cts-strasbourg.fr/");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterTypeInfo)writer).Write22_infosTrafic((object[])objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderTypeInfo)reader).Read22_infosTrafic();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class ArrayOfObjectSerializer7 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"infosTraficResponse", this.DefaultNamespace ?? @"http://www.cts-strasbourg.fr/");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterTypeInfo)writer).Write23_infosTraficResponse((object[])objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderTypeInfo)reader).Read23_infosTraficResponse();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class ArrayOfObjectSerializer8 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"deviations", this.DefaultNamespace ?? @"http://www.cts-strasbourg.fr/");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterTypeInfo)writer).Write24_deviations((object[])objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderTypeInfo)reader).Read24_deviations();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class ArrayOfObjectSerializer9 : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"deviationsResponse", this.DefaultNamespace ?? @"http://www.cts-strasbourg.fr/");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriterTypeInfo)writer).Write25_deviationsResponse((object[])objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReaderTypeInfo)reader).Read25_deviationsResponse();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReaderTypeInfo(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriterTypeInfo(); } }
        System.Collections.IDictionary readMethods = null;
        public override System.Collections.IDictionary ReadMethods {
            get {
                if (readMethods == null) {
                    System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, string>();
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageRechercheCodeArret] rechercherCodesArretsDepuisLibelleAsync(System.String, Int32):Request"] = @"Read16_Item";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageRechercheCodeArret] rechercherCodesArretsDepuisLibelleAsync(System.String, Int32):Response"] = @"Read17_Item";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageArriveesAppliWeb] rechercheProchainesArriveesWebAsync(System.String, Int32, System.String, Int32):Request"] = @"Read18_rechercheProchainesArriveesWeb";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageArriveesAppliWeb] rechercheProchainesArriveesWebAsync(System.String, Int32, System.String, Int32):Response"] = @"Read19_Item";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageFichesHoraires] rechercheFichesHorairesAsync(System.String):Request"] = @"Read20_rechercheFichesHoraires";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageFichesHoraires] rechercheFichesHorairesAsync(System.String):Response"] = @"Read21_Item";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageInfosTrafic] infosTraficAsync():Request"] = @"Read22_infosTrafic";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageInfosTrafic] infosTraficAsync():Response"] = @"Read23_infosTraficResponse";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageDeviations] deviationsAsync():Request"] = @"Read24_deviations";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageDeviations] deviationsAsync():Response"] = @"Read25_deviationsResponse";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System.Collections.IDictionary writeMethods = null;
        public override System.Collections.IDictionary WriteMethods {
            get {
                if (writeMethods == null) {
                    System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, string>();
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageRechercheCodeArret] rechercherCodesArretsDepuisLibelleAsync(System.String, Int32):Request"] = @"Write16_Item";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageRechercheCodeArret] rechercherCodesArretsDepuisLibelleAsync(System.String, Int32):Response"] = @"Write17_Item";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageArriveesAppliWeb] rechercheProchainesArriveesWebAsync(System.String, Int32, System.String, Int32):Request"] = @"Write18_rechercheProchainesArriveesWeb";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageArriveesAppliWeb] rechercheProchainesArriveesWebAsync(System.String, Int32, System.String, Int32):Response"] = @"Write19_Item";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageFichesHoraires] rechercheFichesHorairesAsync(System.String):Request"] = @"Write20_rechercheFichesHoraires";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageFichesHoraires] rechercheFichesHorairesAsync(System.String):Response"] = @"Write21_Item";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageInfosTrafic] infosTraficAsync():Request"] = @"Write22_infosTrafic";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageInfosTrafic] infosTraficAsync():Response"] = @"Write23_infosTraficResponse";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageDeviations] deviationsAsync():Request"] = @"Write24_deviations";
                    _tmp[@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageDeviations] deviationsAsync():Response"] = @"Write25_deviationsResponse";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System.Collections.IDictionary typedSerializers = null;
        public override System.Collections.IDictionary TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, System.Xml.Serialization.XmlSerializer>();
                    _tmp.Add(@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageRechercheCodeArret] rechercherCodesArretsDepuisLibelleAsync(System.String, Int32):Response", new ArrayOfObjectSerializer1());
                    _tmp.Add(@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageDeviations] deviationsAsync():Response", new ArrayOfObjectSerializer9());
                    _tmp.Add(@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageDeviations] deviationsAsync():Request", new ArrayOfObjectSerializer8());
                    _tmp.Add(@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageRechercheCodeArret] rechercherCodesArretsDepuisLibelleAsync(System.String, Int32):Request", new ArrayOfObjectSerializer());
                    _tmp.Add(@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageArriveesAppliWeb] rechercheProchainesArriveesWebAsync(System.String, Int32, System.String, Int32):Request", new ArrayOfObjectSerializer2());
                    _tmp.Add(@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageFichesHoraires] rechercheFichesHorairesAsync(System.String):Request", new ArrayOfObjectSerializer4());
                    _tmp.Add(@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageInfosTrafic] infosTraficAsync():Request", new ArrayOfObjectSerializer6());
                    _tmp.Add(@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageArriveesAppliWeb] rechercheProchainesArriveesWebAsync(System.String, Int32, System.String, Int32):Response", new ArrayOfObjectSerializer3());
                    _tmp.Add(@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageFichesHoraires] rechercheFichesHorairesAsync(System.String):Response", new ArrayOfObjectSerializer5());
                    _tmp.Add(@"StrasInfo.StrasServiceSoap.ServiceSoap:System.Threading.Tasks.Task`1[StrasInfo.StrasServiceSoap.MessageInfosTrafic] infosTraficAsync():Response", new ArrayOfObjectSerializer7());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::System.Reflection.TypeInfo)) return true;
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageRechercheCodeArretrechercherCodesArretsDepuisLibelleAsyncSystemStringInt32Request)) return true;
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageRechercheCodeArretrechercherCodesArretsDepuisLibelleAsyncSystemStringInt32Response)) return true;
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageArriveesAppliWebrechercheProchainesArriveesWebAsyncSystemStringInt32SystemStringInt32Request)) return true;
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageArriveesAppliWebrechercheProchainesArriveesWebAsyncSystemStringInt32SystemStringInt32Response)) return true;
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageFichesHorairesrechercheFichesHorairesAsyncSystemStringRequest)) return true;
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageFichesHorairesrechercheFichesHorairesAsyncSystemStringResponse)) return true;
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageInfosTraficinfosTraficAsyncRequest)) return true;
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageInfosTraficinfosTraficAsyncResponse)) return true;
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageDeviationsdeviationsAsyncRequest)) return true;
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageDeviationsdeviationsAsyncResponse)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageRechercheCodeArretrechercherCodesArretsDepuisLibelleAsyncSystemStringInt32Request)) return new ArrayOfObjectSerializer();
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageRechercheCodeArretrechercherCodesArretsDepuisLibelleAsyncSystemStringInt32Response)) return new ArrayOfObjectSerializer1();
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageArriveesAppliWebrechercheProchainesArriveesWebAsyncSystemStringInt32SystemStringInt32Request)) return new ArrayOfObjectSerializer2();
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageArriveesAppliWebrechercheProchainesArriveesWebAsyncSystemStringInt32SystemStringInt32Response)) return new ArrayOfObjectSerializer3();
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageFichesHorairesrechercheFichesHorairesAsyncSystemStringRequest)) return new ArrayOfObjectSerializer4();
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageFichesHorairesrechercheFichesHorairesAsyncSystemStringResponse)) return new ArrayOfObjectSerializer5();
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageInfosTraficinfosTraficAsyncRequest)) return new ArrayOfObjectSerializer6();
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageInfosTraficinfosTraficAsyncResponse)) return new ArrayOfObjectSerializer7();
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageDeviationsdeviationsAsyncRequest)) return new ArrayOfObjectSerializer8();
            if (type == typeof(StrasInfoStrasServiceSoapServiceSoapSystemThreadingTasksTask1StrasInfoStrasServiceSoapMessageDeviationsdeviationsAsyncResponse)) return new ArrayOfObjectSerializer9();
            return null;
        }
        public static global::System.Xml.Serialization.XmlSerializerImplementation GetXmlSerializerContract() { return new XmlSerializerContract(); }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public static class ActivatorHelper {
        public static object CreateInstance(System.Type type) {
            System.Reflection.TypeInfo ti = System.Reflection.IntrospectionExtensions.GetTypeInfo(type);
            foreach (System.Reflection.ConstructorInfo ci in ti.DeclaredConstructors) {
                if (!ci.IsStatic && ci.GetParameters().Length == 0) {
                    return ci.Invoke(null);
                }
            }
            return System.Activator.CreateInstance(type);
        }
    }
}
