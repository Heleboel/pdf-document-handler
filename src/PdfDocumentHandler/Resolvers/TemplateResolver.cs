using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace PdfDocumentHandler.Resolvers
{
    public class TemplateResolver
    {
        public TemplateResolver()
        {
        }


        public TemplateResolver(string template)
        {
            Template = template;
        }


        public string Template { get; }


        public string Resolve(string filename)
        {
            return Resolve(filename, new Dictionary<string, object>());
        }


        public string Resolve(string filename, Dictionary<string, object> values)
        {
            if (string.IsNullOrEmpty(Template))
            {
                return filename;
            }

            var template = Template;

            if (template.Contains("{RegEx:"))
            {
                template = ResolveRegEx(template, filename);
            }

            foreach (var kvpair in values)
            {
                var key   = kvpair.Key;
                var value = kvpair.Value;

                if (template.Contains($"{{{key}}}"))
                {
                    if (value is DateTime)
                    {
                        template = template.Replace($"{{{key}}}", ((DateTime)value).ToString("yyyy-MM-dd"));
                    }
                    if (value is string)
                    {
                        template = template.Replace($"{{{key}}}", value as string);
                    }
                    if (value is int)
                    {
                        template = template.Replace($"{{{key}}}", value.ToString());
                    }
                }

                if (template.Contains($"{{{key}:"))
                {
                    // The template contains some formatting string.
                    template = ResolveKeyWithFormatting(template, key, value);
                }
            }

            return template.Trim();
        }


        private static string ResolveRegEx(string template, string value)
        {
            var keyRegex = new Regex(@"\{RegEx:(?<pattern>[^\}]*)\}");
            var keyMatch = keyRegex.Match(template);

            if (keyMatch.Success)
            {
                var pattern = keyMatch.Groups["pattern"].Value;

                var valueRegex = new Regex(pattern);
                var valueMatch = valueRegex.Match(value);

                if (valueMatch.Success)
                {
                    template = keyRegex.Replace(template, valueMatch.Value);
                }
            }

            return template;
        }


        private static string ResolveKeyWithFormatting(string template, string key, object value)
        {
            var pattern = @"\{" + $"{key}" + @":(?<formatting>[^\}]*)\}";
            var keyRegEx = new Regex(pattern);
            var keyMatch = keyRegEx.Match(template);

            if (keyMatch.Success)
            {
                var formatting = keyMatch.Groups["formatting"].Value;

                if (value is DateTime)
                {
                    template = keyRegEx.Replace(template, ((DateTime)value).ToString(formatting));
                }
                if (value is string)
                {
                    template = keyRegEx.Replace(template, (string)value);
                }
                if (value is int)
                {
                    template = keyRegEx.Replace(template, ((int)value).ToString(formatting));
                }
            }

            return template;
        }
    }
}
