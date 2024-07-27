using Strategy.ImageStorageExample;
using System;
using Strategy.ChatExample;
using Strategy.ChatExample.EncryptionAlgorithms;
using Strategy.ImageStorageExample.Compressors;
using Strategy.ImageStorageExample.Filters;

namespace Strategy
{
    internal abstract class Program
    {
        private static void Main()
        {
            var imageStore = new ImageStorage();

            imageStore.Store("testing.png", new PngCompressor(), new BlackAndWhiteFilter());
            imageStore.Store("testing.png", new JpegCompressor(), new HighContrastFilter());

            Console.ReadLine();

            var chatClient = new ChatClient(new AesEncryptionAlgorithm());

            chatClient.Send("Hello");

            Console.ReadLine();
        }
    }
}
