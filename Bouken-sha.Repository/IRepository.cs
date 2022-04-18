using Bouken_sha.Extension.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bouken_sha.Repository
{
    public interface IRepository
    {
        ILibraryRepository Lirbraries { get; }
        IHistoryRepository Histories { get; }
        INewsRepository News { get; }
        IExtensionRepository Extensions { get; }
        IUpdateRepository Updates { get; }
    }
}
