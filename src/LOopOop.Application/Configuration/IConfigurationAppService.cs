using System.Threading.Tasks;
using LOopOop.Configuration.Dto;

namespace LOopOop.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
