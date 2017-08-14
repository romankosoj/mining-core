﻿using Newtonsoft.Json;

namespace MiningCore.Blockchain.Bitcoin.DaemonResponses
{
    public class GetBlockResponse
    {
        public uint Version { get; set; }
        public string Hash { get; set; }
        public string PreviousBlockhash { get; set; }
        public ulong Time { get; set; }
        public uint Height { get; set; }
        public string Bits { get; set; }
        public double Difficulty { get; set; }
        public ulong Nonce { get; set; }
        public uint Weight { get; set; }
        public uint Size { get; set; }
        public int Confirmations { get; set; }

        [JsonProperty("tx")]
        public string[] Transactions { get; set; }
    }
}