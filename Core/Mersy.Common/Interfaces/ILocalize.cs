using System.Globalization;

namespace Mersy.Common.Interfaces
{
    namespace Soccer.Prism.Interfaces
    {
        public interface ILocalize
        {
            CultureInfo GetCurrentCultureInfo();

            void SetLocale(CultureInfo ci);
        }
    }
}
