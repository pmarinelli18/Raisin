using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Language.V1;

namespace Raisin
{
    class ResultsLogic
    {
        List<SentenceW> lswrap;
        LangProc Langpr;
        AnnotateTextResponse response;

         public ResultsLogic(String info)
         {
             Langpr = new LangProc();
             response = Langpr.AnalyzeSyntaxFromText(info);
            
             foreach(var token in response.Tokens)
             {
                Console.Out.WriteLine(token.PartOfSpeech.Case);
                                      
             }
             

         }

    }

    
}
