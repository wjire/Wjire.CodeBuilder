using System.IO;
using Wjire.CodeBuilder.BaseBuilder;
using Wjire.CodeBuilder.Model;

namespace Wjire.CodeBuilder.cs_Builder
{

    public abstract class Cs_AbstractBuilder : AbstractBuilder
    {
        protected override string GetTemplateFromPath()
        {
            return Path.Combine(base.GetTemplateFromPath(), TemplatePath.Cs);
        }

        protected override string ReplaceTemplateOfLine(string line, FormInfo formInfo)
        {
            return line
                    .Replace(TemplatePlaceholder.NameSpaceName, formInfo.NameSpaceName)
                    .Replace(TemplatePlaceholder.TableName, formInfo.TableName)
                    .Replace(TemplatePlaceholder.DbName, formInfo.DbName)
                ;
        }
    }
}
