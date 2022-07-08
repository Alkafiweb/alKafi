using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class SanadPrintSetting
    {
        public int Id { get; set; }
        public string FieldName { get; set; }
        public double Xc { get; set; }
        public double Yc { get; set; }
        public double Width { get; set; }
        public double Hight { get; set; }
        public string FieldBind { get; set; }
    }
}
