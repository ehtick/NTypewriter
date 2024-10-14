#nullable enable
using System.Collections.Generic;

namespace Tests.Assets.WebApi.Controllers
{
    public class NullableArrayDTO
    {
        public string[]? ArrayStr { get; set; }
        public List<string>? ListStr { get; set; }
        public NumbersEnum[]? ArrayEnum { get; set; }
        public List<NumbersEnum>? ListEnum { get; set; }
    }
}
