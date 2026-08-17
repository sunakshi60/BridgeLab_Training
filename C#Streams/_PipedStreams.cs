using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.IO;

namespace C_Streams
{
    public class PipedStreams
    {
        public static void Run()
        {
            try
            {
                using (AnonymousPipeServerStream pipe = new AnonymousPipeServerStream(
                        PipeDirection.Out,
                        HandleInheritability.Inheritable))
                {
                    using (AnonymousPipeClientStream readerPipe = new AnonymousPipeClientStream(
                            PipeDirection.In,
                            pipe.ClientSafePipeHandle))
                    {
                        Thread writerThread = new Thread(() =>
                        {
                            try
                            {
                                using (StreamWriter writer = new StreamWriter(pipe))
                                {
                                    writer.AutoFlush = true;

                                    writer.WriteLine("Hello from Writer Thread");
                                    writer.WriteLine("This data is sent through the pipe.");
                                    writer.WriteLine("Inter-thread communication completed.");
                                }
                            }
                            catch (IOException ex)
                            {
                                Console.WriteLine(
                                    "Writer IOException: " + ex.Message);
                            }
                        });

                        Thread readerThread = new Thread(() =>
                        {
                            try
                            {
                                using (StreamReader reader = new StreamReader(readerPipe))
                                {
                                    string message;

                                    while ((message = reader.ReadLine()) != null)
                                    {
                                        Console.WriteLine("Reader received: " + message);
                                    }
                                }
                            }
                            catch (IOException ex)
                            {
                                Console.WriteLine("Reader IOException: " + ex.Message);
                            }
                        });

                        writerThread.Start();
                        readerThread.Start();

                        writerThread.Join();
                        readerThread.Join();
                    }
                }

                Console.WriteLine("Communication completed successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Pipe IOException: " + ex.Message);
            }
        }
    }
}

