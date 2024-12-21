﻿using Azure;
using Azure.Data.Tables;

namespace ActivityRegistrator.Models.DanceStudio;
public class Person : ITableEntity
{   
    public string PartitionKey { get; set; } = string.Empty;
    public string RowKey {  get; set; } = string.Empty;
    public string Name {  get; set; } = string.Empty;
    public DateTimeOffset? Timestamp { get; set; }
    public ETag ETag { get; set; }
}
