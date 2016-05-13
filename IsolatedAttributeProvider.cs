using System.CodeDom;
using TechTalk.SpecFlow.Utils;

namespace NCrunch.Generator.SpecflowPlugin
{
    /// <summary>
    /// Implementation class which is responsible for generating the NCrunch attributes NCrunch.Framework.Isolated()
    /// </summary>
    internal class IsolatedAttributeProvider : NCrunchAttributeProviderBase
    {
        protected override CodeAttributeDeclaration InternalProvideAttribute(CodeDomHelper codeDomHelper,
            CodeMemberMethod method,
            string nCrunchAttributeParameters)
        {
            return codeDomHelper.AddAttribute(method, AttributeName());
        }

        protected override string AttributeName()
        {
            return NCrunchAttributeNames.NCrunchIsolated;
        }
    }
}