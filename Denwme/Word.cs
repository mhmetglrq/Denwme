﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denwme
{
    public class Word
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Meaning { get; set; }
        public string ImgUrl { get; set; }
        public ICollection<Sentence> Sentences { get; set; }
        public ICollection<Synonmys> Synonmys { get; set; }
    }
}
