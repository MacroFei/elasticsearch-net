﻿using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	[JsonFormatter(typeof(SortOrderFormatter<TermsOrder>))]
	public class TermsOrder : ISortOrder
	{
		public static TermsOrder CountAscending => new TermsOrder { Key = "_count", Order = SortOrder.Ascending };
		public static TermsOrder CountDescending => new TermsOrder { Key = "_count", Order = SortOrder.Descending };

		public string Key { get; set; }

		public static TermsOrder KeyAscending => new TermsOrder { Key = "_key", Order = SortOrder.Ascending };
		public static TermsOrder KeyDescending => new TermsOrder { Key = "_key", Order = SortOrder.Descending };
		public SortOrder Order { get; set; }
	}
}
