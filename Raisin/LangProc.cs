using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Language.V1;

namespace Raisin
{
    class LangProc
    {
        public LangProc(string _info)
        {
            info = _info;
        }
        string info;
        //client langClient;

        /*private static void AnalyzeSyntaxFromText(string text)
        {
            var client = LanguageServiceClient.Create();
            var response = client.AnnotateText(new Document()
            {
                Content = text,
                Type = Document.Types.Type.PlainText
            },
            new Features() { ExtractSyntax = true });
            WriteSentences(response.Sentences, response.Tokens);
        }*/
    }

    /*AnalysisSyntaxResponse getSyntax()
    {
        return langClient.AnalyzeSentiment(info);
    }*/
}
//LanguageServiceClient client = LanguageServiceClient().Create();
