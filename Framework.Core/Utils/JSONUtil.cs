using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.Utils
{
    public class JSONUtil
    {
        public void CreateJSONSchema()
        {
            JSchema schema = JSchema.Parse(@"{
              'type': 'object',
              'properties': {
                'name': {'type':'string'},
                'roles': {'type': 'array'}
              }
            }");

            JObject user = JObject.Parse(@"{
  'name': 'Arnie Admin',
  'roles': ['Developer', 'Administrator']
}");

            bool valid = user.IsValid(schema);
        }
    }
}
