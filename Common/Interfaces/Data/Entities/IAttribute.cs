using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public interface IAttribute
    {
        public int Id { get; set; }
        public bool IsRequired { get; set; }
        public int MaxValue { get; set; }
        public int MinValue { get; set; }
        public bool IsDecimal { get; set; }
        public string FileFormat{ get; set; }
        public int MaxFileSize { get; set; }
        public DateTime DateMax { get; set; }
        public DateTime DateMin { get; set; }
    }
}
