using System.IO;
using Wjire.CodeBuilder.BaseBuilder;
using Wjire.CodeBuilder.Model;

namespace Wjire.CodeBuilder.cs_Builder
{

    public class Cs_AppsettingsBuilder : Cs_WebApiAbstractBuilder
    {
        protected override string GetTemplateFromPath()
        {
            return Path.Combine(base.GetTemplateFromPath(), "appsettings.txt");
        }

        protected override string GetFileToSavePath(FormInfo formInfo)
        {
            return Path.Combine(formInfo.BasePath, $"{formInfo.NameSpaceName}.WebApi\\appsettings.json");
        }

        protected override string ReplaceTemplateOfLine(string line, FormInfo formInfo)
        {
            string str = base.ReplaceTemplateOfLine(line, formInfo);
            return str.Replace(TemplatePlaceholder.Pwd, formInfo.Pwd)
                .Replace(TemplatePlaceholder.User, formInfo.User)
                .Replace(TemplatePlaceholder.Host, formInfo.Host);
        }
    }
}
