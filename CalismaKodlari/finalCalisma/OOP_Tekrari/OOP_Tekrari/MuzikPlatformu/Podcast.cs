using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tekrari.MuzikPlatformu
{
    internal class Podcast : MedyaOgesi<Guid>
    {
        public string Konuk { get; set; }
    }
}
