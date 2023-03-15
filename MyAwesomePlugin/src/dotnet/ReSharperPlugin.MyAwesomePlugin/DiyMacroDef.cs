using System;
using System.Collections.Generic;
using JetBrains.DocumentModel;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;
using JetBrains.ReSharper.Psi;

namespace ReSharperPlugin.MyAwesomePlugin
{
    [MacroDefinition("etReplEmpty",
        ResourceType = typeof(Strings),
        DescriptionResourceName = nameof(Strings.etReplEmpty_Short_Text),
        LongDescriptionResourceName = nameof(Strings.etReplEmpty_Long_Text))]
    public class EtReplEmptyMacroDef : SimpleMacroDefinition
    {
        public override string GetPlaceholder(IDocument document, ISolution solution, IEnumerable<IMacroParameterValue> parameters)
        {
            return Evaluate(document.GetPsiSourceFile(solution));
        }
    
        public static string Evaluate(IPsiSourceFile sourceFile)
        {
            var str = sourceFile?.GetLocation().NameWithoutExtension ?? "";
            if (str.EndsWith("Handler"))
            {
                return str.Replace("Handler", "");
            }
            
            if (str.EndsWith("Help"))
            {
                return str.Replace("Help", "");
            }
            
            if (str.EndsWith("ClientSystem"))
            {
                return str.Replace("ClientSystem", "");
            }
            
            if (str.EndsWith("ServerSystem"))
            {
                return str.Replace("ServerSystem", "");
            }
            
            if (str.EndsWith("System"))
            {
                return str.Replace("System", "");
            }
            
            return str;

        }
    
        public override bool CanBeEvaluatedWithoutCommit => true;
    }
  
    [MacroImplementation(Definition = typeof(EtReplEmptyMacroDef), ScopeProvider = typeof(PsiImpl))]
    public class EtReplEmptyMacroDefImpl : SimpleMacroImplementation
    {
        public override HotspotItems GetLookupItems(IHotspotContext context)
        {
            var sourceFile = context.ExpressionRange.Document.GetPsiSourceFile(context.SessionContext.Solution);
            return MacroUtil.SimpleEvaluateResult(EtReplEmptyMacroDef.Evaluate(sourceFile));
        }
    }
    
    //
    [MacroDefinition("etHandlerReversal",
        ResourceType = typeof(Strings),
        DescriptionResourceName = nameof(Strings.etHandlerReversal_Short_Text),
        LongDescriptionResourceName = nameof(Strings.etHandlerReversal_Long_Text))]
    public class EtHandlerUtilMacroDef : SimpleMacroDefinition
    {
        public override string GetPlaceholder(IDocument document, ISolution solution, IEnumerable<IMacroParameterValue> parameters)
        {
            return Evaluate(document.GetPsiSourceFile(solution));
        }
    
        public static string Evaluate(IPsiSourceFile sourceFile)
        {
            var str = sourceFile?.GetLocation().NameWithoutExtension ?? "";
            
            // 这个是消息 反转
            if ((str.IndexOf("_", StringComparison.Ordinal) != -1) && ((str.IndexOf("2", StringComparison.Ordinal) != -1) && str.EndsWith("Handler")))
            {
                char[] separator = new char[] { '_' };
                string[] strArray = str.Split(separator);
                if (strArray.Length == 2)
                {
                    char[] chArray2 = new char[] { '2' };
                    string[] strArray2 = strArray[0].Split(chArray2);
                    if (strArray2.Length == 2)
                    {
                        string[] textArray1 = new string[] { strArray2[1], "2", strArray2[0], "_", strArray[1].Replace("Handler", "") };
                        return string.Concat(textArray1);
                    }
                }
            }

            return str;

        }
    
        public override bool CanBeEvaluatedWithoutCommit => true;
    }
  
    [MacroImplementation(Definition = typeof(EtHandlerUtilMacroDef), ScopeProvider = typeof(PsiImpl))]
    public class EtHandlerUtilMacroDefImpl : SimpleMacroImplementation
    {
        public override HotspotItems GetLookupItems(IHotspotContext context)
        {
            var sourceFile = context.ExpressionRange.Document.GetPsiSourceFile(context.SessionContext.Solution);
            return MacroUtil.SimpleEvaluateResult(EtHandlerUtilMacroDef.Evaluate(sourceFile));
        }
    }
    
    //
    [MacroDefinition("etSplit0",
        ResourceType = typeof(Strings),
        DescriptionResourceName = nameof(Strings.etSplit0_Short_Text),
        LongDescriptionResourceName = nameof(Strings.etSplit0_Long_Text))]
    public class EtSplit0MacroDef : SimpleMacroDefinition
    {
        public override string GetPlaceholder(IDocument document, ISolution solution, IEnumerable<IMacroParameterValue> parameters)
        {
            return Evaluate(document.GetPsiSourceFile(solution));
        }
    
        public static string Evaluate(IPsiSourceFile sourceFile)
        {
            var str = sourceFile?.GetLocation().NameWithoutExtension ?? "";
            
            if ((str.IndexOf("_", StringComparison.Ordinal) != -1))
            {
                char[] separator = new char[] { '_' };
                string[] strArray = str.Split(separator);
                return strArray[0];
            }

            return str;

        }
    
        public override bool CanBeEvaluatedWithoutCommit => true;
    }
  
    [MacroImplementation(Definition = typeof(EtSplit0MacroDef), ScopeProvider = typeof(PsiImpl))]
    public class EtSplit0MacroDefImpl : SimpleMacroImplementation
    {
        public override HotspotItems GetLookupItems(IHotspotContext context)
        {
            var sourceFile = context.ExpressionRange.Document.GetPsiSourceFile(context.SessionContext.Solution);
            return MacroUtil.SimpleEvaluateResult(EtSplit0MacroDef.Evaluate(sourceFile));
        }
    }
    
}