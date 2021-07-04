using System;
using System.Collections.Generic;

namespace QueryBuilder
{
    public class QueryBuilder
    {
        private Dictionary<string,string> _queryDictionary = new();
        public QueryBuilder() => this.Reset();
        private void Reset() => this._queryDictionary = new();
        public QueryBuilder Query<T>(string paramterName, T parameterValue) where T : IComparable
        {
            _queryDictionary.Add(paramterName, parameterValue.ToString());
            return this;
        }
        public override string ToString()
        {
            List<string> queries = new();
            foreach (var item in _queryDictionary)
                queries.Add($"{item.Key}{item.Value}");
            return string.Join('&',queries);
        }
    }
}
