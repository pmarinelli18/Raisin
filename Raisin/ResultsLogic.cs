using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raisin
{
    class ResultsLogic
    {
        List<SentenceW> lswrap;
        LangProc Langpr;

         public ResultsLogic(String info)
        {
            Langpr = new LangProc();
            Langpr.AnalyzeSyntaxFromText(info);
        }
    }

    
}
