using OpenAI_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAI_API.Health {
  public interface IHealthEndpoint {
      Task<Health> GetHealthAsync();
  }
}
