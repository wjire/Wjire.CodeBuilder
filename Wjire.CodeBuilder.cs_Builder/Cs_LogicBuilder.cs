using System.IO;
using Wjire.CodeBuilder.Model;

namespace Wjire.CodeBuilder.cs_Builder
{

    public class Cs_LogicBuilder : Cs_AbstractBuilder
    {
        protected override string GetTemplateFromPath()
        {
            return Path.Combine(base.GetTemplateFromPath(), "Logic.txt");
        }

        protected override string GetFileToSavePath(FormInfo formInfo)
        {
            return Path.Combine(formInfo.BasePath, $"{formInfo.NameSpaceName}.Logic\\{formInfo.TableName}Logic.cs");
        }
    }
}
