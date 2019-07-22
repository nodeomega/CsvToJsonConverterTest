using System;
using System.Collections.Generic;
using System.Text;

namespace CsvToJsonConverterTest.Settings
{
    public static class Constants
    {
        public const string FLine = "F";
        public const string OLine = "O";
        public const string BLine = "B";
        public const string LLine = "L";
        public const string TLine = "T";
        public const string ELine = "E";

        public const int RecordTypeOrdinal = 0;

        // this one is used in record types.
        public const int DateOrdinal = 1;

        public const int FileTypeOrdinal = 2;

        public const int OrderCodeOrdinal = 2;
        public const int OrderNumberOrdinal = 3;

        public const int BuyerNameOrdinal = 1;
        public const int BuyerStreetOrdinal = 2;
        public const int BuyerZipOrdinal = 3;

        public const int LineItemSkuOrdinal = 1;
        public const int LineItemQuantityOrdinal = 2;

        public const int TimingsStartOrdinal = 1;
        public const int TimingsStopOrdinal = 2;
        public const int TimingsGapOrdinal = 3;
        public const int TimingsOffsetOrdinal = 4;
        public const int TimingsPauseOrdinal = 5;

        public const int EnderProcessOrdinal = 1;
        public const int EnderPaidOrdinal = 2;
        public const int EnderCreatedOrdinal = 3;
    }
}
