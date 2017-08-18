﻿using System.Security.Cryptography;

namespace MiningCore.Crypto.Hashing.Algorithms
{
    /// <summary>
    ///     Sha-256 single round
    /// </summary>
    public class Sha256S : IHashAlgorithm
    {
        public byte[] Digest(byte[] data, ulong nTime)
        {
            using (var hasher = SHA256.Create())
            {
                return hasher.ComputeHash(data);
            }
        }
    }
}
