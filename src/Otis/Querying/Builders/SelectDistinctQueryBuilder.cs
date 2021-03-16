﻿using Otis.Factories;
using System;
using System.Linq.Expressions;

namespace Otis.Querying.Builders
{
  internal class SelectDistinctQueryBuilder<T> : SelectQueryBuilder<T>
  {
    protected override string Keyword { get; } = "SELECT DISTNCT";

    public SelectDistinctQueryBuilder(ITableFactory factory, Expression<Func<T, object>>[] selectColumns = null) : base(factory, selectColumns) { }
  }
}