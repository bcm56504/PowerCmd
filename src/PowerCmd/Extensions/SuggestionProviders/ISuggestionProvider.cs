using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowerCmd.Extensions.SuggestionProviders
{
    public interface ISuggestionProvider
    {
        bool SupportsCommand(string command);

        Task<IEnumerable<string>> GetSuggestionsAsync(string command);
    }
}