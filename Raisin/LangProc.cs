using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Language.V1;
using Google.Protobuf.Collections;
using static Google.Cloud.Language.V1.AnnotateTextRequest.Types;

namespace Raisin
{
    class LangProc
    {      
        LanguageServiceClient langClient;

        public LangProc()
        {     
            
        }
        public void AnalyzeSyntaxFromText(string info)
        {
            
            var client = new LanguageServiceClientBuilder();
            client.CredentialsPath = ("creds.json");

            var clientt = client.Build();
            


            9var response = clientt.AnnotateText(new Document()
            {
                Content = info,
                Type = Document.Types.Type.PlainText
            },
            new Features() { ExtractSyntax = true });
            WriteSentences(response.Sentences, response.Tokens);
        }

        public void WriteSentences(IEnumerable<Sentence> sentences,
        RepeatedField<Token> tokens)
        {
            Console.WriteLine("Sentences:");
            foreach (var sentence in sentences)
            {
                Console.WriteLine($"\t{sentence.Text.BeginOffset}: {sentence.Text.Content}");
            }
            Console.WriteLine("Tokens:");
            foreach (var token in tokens)
            {
                Console.WriteLine($"\t{token.PartOfSpeech.Tag} "
                    + $"{token.Text.Content}");
            }
        }
    }     
}

