using Mersy.Common.Responses;

namespace Mersy.Web.Helpers
{
    public interface IMailHelper
    {

        Response SendMail(string to, string subject, string body);
    }
}
