﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PNGBuddy.Types
{
    public class InputRemoved
    {
        [JsonPropertyName("inputName")]
        public string? InputName { get; set; }
    }
}
