using System;
using System.IO;
using System.Text;
using Wjire.CodeBuilder.Model;
using Wjire.CodeBuilder.Util;

namespace Wjire.CodeBuilder.BaseBuilder
{

    /// <summary>
    /// 项目创建基类 工厂模式+模板模式
    /// </summary>
    public abstract class AbstractBuilder
    {
        public virtual void CreateFile(FormInfo formInfo)
        {
            string to = GetFileToSavePath(formInfo);
            if (File.Exists(to) == true && IsCover() == false)
            {
                return;
            }
            string dir = Path.GetDirectoryName(to);
            FileHelper.CheckDirectory(dir);

            string content = CreateContent(formInfo);
            File.WriteAllText(to, content);
        }

        protected virtual string CreateContent(FormInfo formInfo)
        {
            string from = GetTemplateFromPath();
            string[] stringArray = File.ReadAllLines(from);
            StringBuilder sb = new StringBuilder();
            foreach (string line in stringArray)
            {
                string item = ReplaceTemplateOfLine(line, formInfo);
                sb.AppendLine(item);
            }
            return sb.ToString();
        }

        protected virtual string GetTemplateFromPath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TemplatePath.BasePath);
        }

        protected abstract string ReplaceTemplateOfLine(string line, FormInfo formInfo);

        protected abstract string GetFileToSavePath(FormInfo formInfo);

        protected virtual bool IsCover()
        {
            return false;
        }
    }
}