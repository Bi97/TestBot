using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBot.Model
{
    public class ConversationFlow
    {
        // Identifies the last question asked.
        public enum Question
        {
            BName,
            BAge,
            BType,
            BProduct,
            None, // Our last action did not involve a question.
            Empty,
            PName,
            PInformation,
        }

        // The last question asked.
        public Question LastQuestionAsked { get; set; } = Question.Empty;
    }
}
