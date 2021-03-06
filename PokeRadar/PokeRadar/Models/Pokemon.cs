﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carfinance.PokeRadar.Models {
    public class Pokemon {
        public int Number { get; set; }
        public string Name { get; set; }
        [JsonProperty("Type I")]
        public string[] TypeI { get; set; }
        [JsonProperty("Type II")]
        public string[] TypeII { get; set; }
        public string[] Weaknesses { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
    }
}