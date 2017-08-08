﻿using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using MiningCore.Extensions;

namespace MiningCore.Blockchain.Bitcoin
{
    public class BitcoinExtraNonceProvider
    {
        public BitcoinExtraNonceProvider()
        {
            uint instanceId;

            using (var rng = RandomNumberGenerator.Create())
            {
                var bytes = new byte[4];
                rng.GetNonZeroBytes(bytes);
                instanceId = BitConverter.ToUInt32(bytes, 0);
            }

            counter = instanceId << 27;
        }

        private readonly byte[] extraNoncePlaceholder = "f000000ff111111f".HexToByteArray();
        private uint counter;

        public byte[] PlaceHolder => extraNoncePlaceholder;

        public int Size => extraNoncePlaceholder.Length - Marshal.SizeOf(counter);

        public uint Next()
        {
            return ++counter;
        }
    }
}
