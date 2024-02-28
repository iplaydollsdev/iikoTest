

namespace iikoTestServer.Models
{
    public class ErrorDto
    {
        public string Result { get; set; }
        public Error[] Errors { get; set; }
    }

    public class Error
    {
        public string Value { get; set; }
        public string Code { get; set; }
    }

}
