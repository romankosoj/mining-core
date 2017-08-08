﻿using System;
using System.Threading.Tasks;
using MiningCore.Blockchain;
using MiningCore.Configuration;

namespace MiningCore.Mining
{
    public interface IMiningPool
    {
	    void Configure(PoolConfig poolConfig, ClusterConfig clusterConfig);
	    Task StartAsync();
	    IObservable<IShare> Shares { get; }
		PoolConfig Config { get; }
	    PoolStats PoolStats { get; }
		BlockchainStats NetworkStats { get; }
	}
}
