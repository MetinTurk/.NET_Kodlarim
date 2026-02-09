using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OOP_Tekrari.NesnelerinInterneti
{
    internal interface ICihaz
    {
        bool AcikMi { get; set; }
        Guid SeriNo { get; set; }

    }
}
