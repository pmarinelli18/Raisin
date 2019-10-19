using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Language.V1;
using Google.Protobuf.Collections;
using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;


namespace Raisin
{
    class SentenceW
    {
        Sentence _sentence;
        float confidence;
        bool hasSubject;
        bool hasVerb;
        bool isFact;

        //AnnotateTextResponse response;

        SentenceW(LangProc _LangObj)
        {
            //response = _LangObj.AnalyzeSyntaxFromText();
        }
    }
}
