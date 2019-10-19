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
             for (int i = 0; i < response.CalculateSize(); i++)
             {
                for (int j = 0; j < response.Sentences.Count(); j++)
                {
                    if(response.Sentences[i].)
                }
             }
             /*foreach(var sentence in response.Sentences)
             {

             }*/
         }

    }

    
}
