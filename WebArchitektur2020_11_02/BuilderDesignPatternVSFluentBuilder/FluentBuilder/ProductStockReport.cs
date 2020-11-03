﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPatternVSFluentBuilder.FluentBuilder
{
    public class ProductStockReport
    {
        public string HeaderPart { get; set; }
        public string BodyPart { get; set; }
        public string FooterPart { get; set; }
        public override string ToString() =>
            new StringBuilder()
            .AppendLine(HeaderPart)
            .AppendLine(BodyPart)
            .AppendLine(FooterPart)
            .ToString();
    }
}
