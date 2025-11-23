using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace lab9
{
    internal class ByteSearcher
    {
        public event Action<int> ProgressChanged;
        public event Action<long> SearchCompleted;
        public event Action SearchStopped;

        private Thread searchThread;
        private bool shoudStop = false;
        public void StartSearch(string filepath, byte targetByte)
        {
            shoudStop = false;

            searchThread = new Thread(() => doSearch(filepath, targetByte));
            searchThread.Start();
        }
        public void StopSearch()
        {
            shoudStop = true;
        }

        private void doSearch(string filepath, byte targetByte) 
        {
            long count = 0;

            using (FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                long fileSize = fs.Length;
                int bytesRead;
                byte[] buffer = new byte[1024];
                long totalRead = 0;

                while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    if (shoudStop)
                    {
                        SearchStopped?.Invoke();
                        return;
                    }

                    for (int i = 0; i < bytesRead; i++)
                    {
                        if (buffer[i] == targetByte)
                        {
                            count++;
                        }
                    }

                    totalRead += bytesRead;
                    int progress = (int)((double)totalRead / fileSize * 100);
                    ProgressChanged?.Invoke(progress);
                }
                SearchCompleted?.Invoke(count);
            }

        }

    }
}
