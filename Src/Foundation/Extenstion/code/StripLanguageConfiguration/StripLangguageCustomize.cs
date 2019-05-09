using Sitecore.Diagnostics;
using Sitecore.Globalization;
using Sitecore.Pipelines.PreprocessRequest;
using Sitecore.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Foundation.Extenstion.StripLanguageConfiguration
{
    public class StripLangguageCustomize : StripLanguage
    { 
        /// <summary>Processes the specified arguments.</summary>
        /// <param name="args">The arguments.</param>
        public override void Process(PreprocessRequestArgs args)
        {
            Assert.ArgumentNotNull((object)args, "args");

            Language language = StripLangguageCustomize.ExtractLanguage(args.Context.Request);
            if (language == (Language)null)
            {
                //if url doesn't contain language name, we will set the default language
                language = Sitecore.Globalization.Language.Parse("en");
            }
            Context.Language = language;
            Context.Data.FilePathLanguage = language;
        }

        /// <summary>
        /// Extracts the language from the file path of the current request.
        /// </summary>
        /// <param name="request">The HTTP request.</param>
        /// <returns>The language.</returns>
        private static Language ExtractLanguage(HttpRequest request)
        {
            Assert.ArgumentNotNull((object)request, "request");
            string languageName = WebUtil.ExtractLanguageName(request.FilePath);
            if (string.IsNullOrEmpty(languageName))
                return (Language)null;
            Language result;
            if (!Language.TryParse(languageName, out result))
                return (Language)null;
            return result;
        }
    }
}