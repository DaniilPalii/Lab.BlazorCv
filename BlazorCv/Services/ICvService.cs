using BlazorCv.DataTransfer;

namespace BlazorCv.Services;

public interface ICvService
{
	Task<Cv> GetAsync();
}
