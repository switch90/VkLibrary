using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Types.Gifts;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Gifts API section.
    /// </summary>
    public class Gifts
    {
        private readonly Vkontakte _vkontakte;
        internal Gifts(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Returns a list of user gifts.
        /// Docs: <see href="https://vk.com/dev/gifts.get">gifts.get</see>
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="count">Number of gifts to return.</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        public Task<ApiItemsResponse<Gift>> Get(int? userId = null, int? count = null, int? offset = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());

            return _vkontakte.RequestAsync<ApiItemsResponse<Gift>>("gifts.get", parameters);
        }
    }
}