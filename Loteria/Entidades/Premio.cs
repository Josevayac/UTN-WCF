﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Services;

namespace Loteria.Entidades
{
    [DataContract]
    public class Premio
    {
        [DataMember]
        public int id { set; get; }


        [DataMember]
        public int premio { set; get; }

        [DataMember]
        public Double monto { set; get; }

       /* [DataMember]
        public  AgregarPremio { set; get; }
        */
    }
}