using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAI_API.Health {
  public class Health : ApiResultBase {
    [JsonProperty("status")]
    public string Status { get; set; }
  }
}
