using System;
using System.Threading.Tasks;
using Hybrid.Core.Services;
using Microsoft.Maui.Essentials;
using Microsoft.UI.Xaml.Controls;

namespace Hybrid.Maui.Services
{
    public class DialogService : IDialogService
    {
        public async Task<bool> RequestConfirmationAsync(string message)
        {
            return await Task.FromResult(true);
        }
    }
}
