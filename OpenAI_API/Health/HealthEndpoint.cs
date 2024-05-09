using OpenAI_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAI_API.Health {
  public class HealthEndpoint : EndpointBase, IHealthEndpoint {
    public HealthEndpoint(OpenAIAPI api) : base(api) {
    }

    protected override string Endpoint => "health";

    public async Task<Health> GetHealthAsync() {
      return await HttpGet<Health>($"{Url.Replace("v1/", "")}");
    }
  }
}
