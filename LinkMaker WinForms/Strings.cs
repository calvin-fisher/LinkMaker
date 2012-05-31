using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace LinkMaker
{
    public static class Strings
    {
        public static string ReplaceTokens(string source, char startToken, char endToken, Func<string,string> tokenLookup)
        {
            var startIndex = source.IndexOf(startToken);
            if (startIndex < 0)
                return source;

            var afterStartToken = source.Substring(startIndex + 1, source.Length - startIndex - 1);

            var endIndex = afterStartToken.IndexOf(endToken);
            if (endIndex < 0)
                return source;

            var token = afterStartToken.Substring(0, endIndex);

            var lookupResult = tokenLookup(token);
            if (lookupResult == null)
                return source;

            var beforeStartToken = source.Substring(0, startIndex);
            var afterEndToken = afterStartToken.Length > endIndex
                ? afterStartToken.Substring(endIndex + 1, afterStartToken.Length - endIndex - 1)
                : "";

            var modified = string.Format("{0}{1}{2}", beforeStartToken, lookupResult, afterEndToken);

            if (afterEndToken.IndexOf(startToken) < 0)
                return modified;

            return ReplaceTokens(modified, startToken, endToken, tokenLookup);
        }

        public static string GetValueOrDefault(this Dictionary<string, string> dictionary, string key)
        {
            return dictionary.ContainsKey(key) ? dictionary[key] : null;
        }

        public static string ReplaceEnvironmentVariables(string source)
        {
            try
            {
                var modified = ReplaceTokens(source, '%', '%', Environment.GetEnvironmentVariable);
                return modified;
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Exception in ReplaceEnvironmentVariables");
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public static string ReplaceBraceTokens(string source, Dictionary<string, string> lookupDictionary)
        {
            try
            {
                var modified = ReplaceTokens(source, '{', '}', lookupDictionary.GetValueOrDefault);
                return modified;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception in ReplaceBraceTokens");
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public static string ReplacePipeTokens(string source, Dictionary<string, string> lookupDictionary)
        {
            try
            {
                var modified = ReplaceTokens(source, '|', '|', lookupDictionary.GetValueOrDefault);
                return modified;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception in ReplacePipeTokens");
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
