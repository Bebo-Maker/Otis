﻿using Otis.Attributes;
using System;
using System.Reflection;

namespace Otis.Utils
{
  public static class AliasUtils
  {
    public static string GetTableName(Type type) => type.GetCustomAttribute<TableAttribute>()?.Alias ?? type.Name;
    public static string GetColumnName(PropertyInfo prop) => prop.GetCustomAttribute<ColumnAttribute>()?.Alias ?? prop.Name;
  }
}
