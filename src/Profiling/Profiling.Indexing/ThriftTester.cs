﻿using System;
using System.Collections.Generic;
using Elasticsearch.Net.Connection.Thrift;
using Nest;

namespace Profiling.Indexing
{
	internal class ThriftTester : Tester, ITester
	{


		public void Run(string indexName, int port, int numMessages, int bufferSize)
		{
			var settings = this.CreateSettings(indexName, 9500);
			settings.SetMaximumAsyncConnections(25);
			var client = new ElasticClient(settings, new ThriftConnection(settings));

			Connect(client, settings);

			GenerateAndIndex(client, indexName, numMessages, bufferSize);
		}

		public void SearchUsingSingleClient(string indexName, int port, int numberOfSearches)
		{
			throw new NotImplementedException();
		}

		public void SearchUsingMultipleClients(string indexName, int port, int numberOfSearches)
		{
			throw new NotImplementedException();
		}
	}
}
