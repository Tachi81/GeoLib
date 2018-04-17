﻿using System.Runtime.Serialization;

namespace GeoLib.Contract
{
    [DataContract]
    public class ZipCodeData
    {
        [DataMember] public string City { get; set; }

        [DataMember] public string State { get; set; }

        [DataMember] public string ZipCode { get; set; }
    }
}
