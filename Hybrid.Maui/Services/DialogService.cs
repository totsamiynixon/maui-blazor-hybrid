using System.Threading.Tasks;
using Hybrid.Core.Services;

namespace Hybrid.Maui.Services
{
    public class DialogService : IDialogService
    {
        public async Task<bool> RequestConfirmationAsync(string message)
        {
            return await Task.FromResult(false);
        }
    }
}
