using System.Threading.Tasks;
using arggio.Configuration.Dto;

namespace arggio.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
