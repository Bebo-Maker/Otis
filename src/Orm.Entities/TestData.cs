﻿using Orm.Attributes;
using System;

namespace Orm.Entities
{
  [Table("TestTable")]
  public class TestData
  {
    public int Id { get; set; }
    public DateTime Datetime { get; set; }
    public int Number { get; set; }
    public string Name { get; set; }

    [Column("LongText")]
    public string LongggText { get; set; }
  }
}
