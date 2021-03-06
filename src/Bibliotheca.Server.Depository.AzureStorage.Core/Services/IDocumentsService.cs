using System.Collections.Generic;
using System.Threading.Tasks;
using Bibliotheca.Server.Depository.AzureStorage.Core.DataTransferObjects;

namespace Bibliotheca.Server.Depository.AzureStorage.Core.Services
{
    public interface IDocumentsService
    {
        Task<IList<BaseDocumentDto>> GetDocumentsAsync(string projectId, string branchName);

        Task<DocumentDto> GetDocumentAsync(string projectId, string branchName, string fileUri);

        Task CreateDocumentAsync(string projectId, string branchName, DocumentDto document);

        Task UpdateDocumentAsync(string projectId, string branchName, string fileUri, DocumentDto document);

        Task DeleteDocumentAsync(string projectId, string branchName, string fileUri);
    }
}