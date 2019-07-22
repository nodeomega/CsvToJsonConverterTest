using System;
using System.IO;
using CsvToJsonConverterTest.Models;
using CsvToJsonConverterTest.Settings;
using Newtonsoft.Json;

namespace CsvToJsonConverterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converting CSV to JSON");

            CsvFileLine FileData = null;

            using (var reader = new StreamReader(@"data\input.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    var splitValues = line?.Split(',');

                    for(var i = 0; i < splitValues?.Length; i++)
                    {
                        splitValues[i] = splitValues[i].Replace("\"", string.Empty);
                    }

                    if (splitValues == null || splitValues.Length < 1)
                    {
                        Console.WriteLine("Empty line discovered.  Aborting.");
                        return;
                    }

                    switch (splitValues[Constants.RecordTypeOrdinal])
                    {
                        case Constants.FLine:
                        {
                            FileData = new CsvFileLine(splitValues[Constants.DateOrdinal], splitValues[Constants.FileTypeOrdinal]);
                            break;
                        }
                        case Constants.OLine:
                        {
                            FileData?.AddOrder(splitValues[Constants.DateOrdinal], splitValues[Constants.OrderCodeOrdinal], splitValues[Constants.OrderNumberOrdinal]);
                            break;
                        }
                        case Constants.BLine:
                        {
                            FileData?.MostRecentOrder?.SetBuyer(splitValues[Constants.BuyerNameOrdinal], splitValues[Constants.BuyerStreetOrdinal], splitValues[Constants.BuyerZipOrdinal]);
                            break;
                        }
                        case Constants.TLine:
                        {
                            FileData?.MostRecentOrder?.SetTimings(splitValues[Constants.TimingsStartOrdinal], splitValues[Constants.TimingsStopOrdinal], splitValues[Constants.TimingsGapOrdinal], splitValues[Constants.TimingsOffsetOrdinal], splitValues[Constants.TimingsPauseOrdinal]);
                            break;
                        }
                        case Constants.LLine:
                        {
                            FileData?.MostRecentOrder?.AddItemLine(splitValues[Constants.LineItemSkuOrdinal], splitValues[Constants.LineItemQuantityOrdinal]);
                            break;
                        }
                        case Constants.ELine:
                        {
                            FileData?.AddEnder(splitValues[Constants.EnderProcessOrdinal], splitValues[Constants.EnderPaidOrdinal], splitValues[Constants.EnderCreatedOrdinal]);
                            break;
                        }
                        default:
                            break;
                    }
                }

                if (!Directory.Exists("output"))
                {
                    Directory.CreateDirectory("output");
                }
                Console.WriteLine(JsonConvert.SerializeObject(FileData));

                File.WriteAllText(@"output\results.json", JsonConvert.SerializeObject(FileData));
            }
        }
    }
}
