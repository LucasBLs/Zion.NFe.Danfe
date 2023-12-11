﻿using System;
using System.Xml.Serialization;
using Zion.NFe.Danfe.Tools.Extensions;

namespace Zion.NFe.Danfe.Dacte.DacteSharp.Modelo
{
    public class infDocRef
    {
        private decimal? _vDoc;
        public string nDoc { get; set; }
        public short serie { get; set; }
        public short? subserie { get; set; }
        public bool subserieSpecified { get { return subserie.HasValue; } }

        [XmlIgnore]
        public DateTime dEmi { get; set; }

        [XmlElement(ElementName = "dEmi")]
        public string ProxydEmi { get { return dEmi.ParaDataString(); } set { dEmi = Convert.ToDateTime(value); } }

        public decimal? vDoc
        {
            get { return _vDoc.Arredondar(2); }
            set { _vDoc = value.Arredondar(2); }
        }

        public bool vDocSpecified { get { return vDoc.HasValue; } }
    }
}
