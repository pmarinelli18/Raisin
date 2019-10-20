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

            var a = rntFact();
            System.Console.WriteLine();
         }


        
        public List<Sentence> rntFact()
        {
            List<Sentence> ws = new List<Sentence>();
            List<int> vs = new List<int>();
            foreach (var item in response.Tokens)
            {
                if (item.PartOfSpeech.Mood == PartOfSpeech.Types.Mood.Indicative)
                {
                    vs.Add(item.Text.BeginOffset);
                }
            }

            foreach (var index in vs)
            {
                for (int i = 0; i < response.Sentences.Count(); i++)
                {   
                    if ((response.Sentences[i].Text.BeginOffset  <= index
                        && ((i + 1) >= response.Sentences.Count())) ||
                        (response.Sentences[i].Text.BeginOffset <= index                          
                        && response.Sentences[i + 1].Text.BeginOffset >= index))
                        ws.Add(response.Sentences[i]);  
                }                                     
            }
            
            return ws;
        }

    }

    
}
