using System;
using System.Collections.Concurrent;

namespace ProductCatalogApi.Configuration;

public class BackgroundImportQueue
{
    public static readonly BackgroundImportQueue Instance = new BackgroundImportQueue();
    private readonly ConcurrentQueue<BackgroundImportJob> _q = new();
    private BackgroundImportQueue() {}
    public void Enqueue (BackgroundImportJob job) => _q.Enqueue(job);
    public bool TryDequeue (out BackgroundImportJob? job) => _q.TryDequeue(out job);
}
