using System.Collections.Generic;

namespace Nest
{
	public class Bucket<TBucketItem> : BucketAggregationBase
		where TBucketItem : IBucketItem
	{
		public IList<TBucketItem> Items { get; set; }
	}
	public class Bucket : IAggregation
	{
		public IEnumerable<IAggregation> Items { get; set; }
		public long? DocCountErrorUpperBound { get; set; }
	}
	
	public class BucketWithDocCount<TBucketItem> : BucketAggregationBase, IBucketWithCountAggregation
		where TBucketItem : IBucketItem
	{
		public IList<TBucketItem> Items { get; set; }

		public long DocCount { get; internal set; }
	}

	public class BucketWithDocCount : IAggregation
	{
		public long DocCount { get; set; }
		public IEnumerable<IAggregation> Items { get; set; }
	}
}