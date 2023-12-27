using System.Globalization;
using System.Text.RegularExpressions;


namespace PdfDocumentHandler.Resolvers;

public class TemplateResolver(string template)
{
    public string Template { get; } = template;


    public TemplateResolver() : this(string.Empty)
    {
    }


    public string Resolve(string filename)
    {
        return Resolve(filename, new());
    }


    public string Resolve(string filename, Dictionary<string, object> values)
    {
        if (string.IsNullOrEmpty(Template))
        {
            return filename;
        }

        var localTemplate = Template;

        if (localTemplate.Contains("{RegEx:"))
        {
            localTemplate = ResolveRegEx(localTemplate, filename);
        }

        foreach (var kvpair in values)
        {
            var key   = kvpair.Key;
            var value = kvpair.Value;

            if (localTemplate.Contains($"{{{key}}}"))
            {
                if (value is DateTime time)
                {
                    localTemplate = localTemplate.Replace($"{{{key}}}", time.ToString("yyyy-MM-dd"));
                }
                if (value is string s)
                {
                    localTemplate = localTemplate.Replace($"{{{key}}}", s);
                }
                if (value is int i)
                {
                    localTemplate = localTemplate.Replace($"{{{key}}}", i.ToString());
                }
            }

            if (localTemplate.Contains($"{{{key}:"))
            {
                // The template contains some formatting string.
                localTemplate = ResolveKeyWithFormatting(localTemplate, key, value);
            }
        }

        localTemplate = localTemplate.Trim();

        // Allways add a '.pdf' extension if it's not there
        if (!localTemplate.EndsWith(".pdf", true, CultureInfo.InvariantCulture))
        {
            localTemplate += ".pdf";
        }

        return localTemplate;
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
