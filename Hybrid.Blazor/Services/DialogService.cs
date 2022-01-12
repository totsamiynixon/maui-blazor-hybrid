using Hybrid.Core.Services;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Hybrid.Blazor.Services
{
    public class DialogService : IDialogService
    {
        private readonly IJSRuntime _jsRuntime;

        public DialogService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task<bool> RequestConfirmationAsync(string message)
        {
             return await this._jsRuntime.InvokeAsync<bool>("confirm", message);
        }
    }
}
