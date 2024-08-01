﻿using System;
using Decorator.BasicExample;

namespace Decorator
{
    internal abstract class Program
    {
        private static void Main()
        {
            //
            // Basic Example
            //

            StoreCreditCard(new EncryptedCloudStream(new CompressedCloudStream(new CloudStream())));

            Console.ReadLine();
        }

        private static void StoreCreditCard(IStream stream)
        {
            stream.Write("1234-1234-1234-1234");
        }
    }
}
