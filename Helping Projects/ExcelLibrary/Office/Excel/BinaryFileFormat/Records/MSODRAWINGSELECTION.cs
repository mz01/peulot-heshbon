﻿namespace ExcelLibrary.BinaryFileFormat
{
    public partial class MSODRAWINGSELECTION : MSOCONTAINER
    {
        public MSODRAWINGSELECTION(Record record) : base(record) { }

        public MSODRAWINGSELECTION()
        {
            this.Type = RecordType.MSODRAWINGSELECTION;
        }
    }
}