using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;

namespace Radix.Gateway.WebApi.Utility
{
    /// <summary>
    /// Classe genérica para tratamento de erros, evitando que dados confidenciais sejam retornados
    /// </summary>
    public static class ModelStateExtension
    {
        public static IEnumerable<string> GetCustomErrors(this ModelStateDictionary modelState)
        {
            return modelState.SelectMany(state => state.Value.Errors).Select(error => error.ErrorMessage);
        }
    }
}
