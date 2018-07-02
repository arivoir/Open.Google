using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Open.OAuth2;

namespace Open.Google
{
    public abstract class GoogleClient : OAuth2Client
    {
        #region ** fields

        private static string OAUTH2 = "https://accounts.google.com/o/oauth2/auth";
        private static string TOKEN = "https://accounts.google.com/o/oauth2/token";

        #endregion

        #region ** authentication

        public static string GetRequestUrl(string clientId, string scope, string callbackUrl)
        {
            return OAuth2Client.GetRequestUrl(OAUTH2, clientId, scope, callbackUrl);
        }

        public static async Task<OAuth2Token> ExchangeCodeForAccessTokenAsync(string code, string clientId, string clientSecret, string callbackUrl)
        {
            return await ExchangeCodeForAccessTokenAsync(TOKEN, code, clientId, clientSecret, callbackUrl);
        }

        public static async Task<OAuth2Token> RefreshAccessTokenAsync(string refreshToken, string clientId, string clientSecret, CancellationToken cancellationToken)
        {
            return await OAuth2Client.RefreshAccessTokenAsync(TOKEN, refreshToken, clientId, clientSecret, cancellationToken);
        }

        #endregion

        #region ** public methods

        public static Uri BuildUri(string uri, string q = null, string kind = null, string fields = null, string pageToken = null, int? maxResults = null, string orderby = null, string uploadType = null, Dictionary<string, string> parameters = null)
        {
            var builder = new UriBuilder(uri);
            var query = builder.Query ?? "";
            if (query.StartsWith("?"))
                query = query.Substring(1);
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    query += "&" + parameter.Key + "=" + parameter.Value;
                }
            }
            if (orderby != null)
                query += "&orderby=" + orderby;
            if (!string.IsNullOrWhiteSpace(pageToken))
                query += "&pageToken=" + pageToken;
            if (maxResults.HasValue && maxResults > 0)
                query += "&maxResults=" + maxResults;
            if (!string.IsNullOrWhiteSpace(q))
                query += "&q=" + Uri.EscapeDataString(q);
            if (!string.IsNullOrWhiteSpace(kind))
                query += "&kind=" + kind;
            if (!string.IsNullOrWhiteSpace(fields))
                query += "&fields=" + Uri.EscapeDataString(fields);
            if (!string.IsNullOrWhiteSpace(uploadType))
                query += "&uploadType=" + uploadType;
            builder.Query = query;
            return builder.Uri;
        }

        #endregion
    }
}
