using System.Threading.Tasks;

namespace Hybrid.Core.Services
{
    public interface IDialogService
    {
        Task<bool> RequestConfirmationAsync(string message);
    }
}
