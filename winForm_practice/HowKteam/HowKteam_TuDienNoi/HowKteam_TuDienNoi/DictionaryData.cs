using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lưu ý: Class dùng để ghi vào file không nên có Constructor nếu có thì không được có Param.

namespace HowKteam_TuDienNoi
{
    public class DictionaryData
    {
        private string key;  // Ctrl+R - Ctrl+E to encapsulate field

        public string Key
        {
            get
            {
                return key;
            }

            set
            {
                key = value;
            }
        }

        public string Meaning
        {
            get
            {
                return meaning;
            }

            set
            {
                meaning = value;
            }
        }

        public string Explaination
        {
            get
            {
                return explaination;
            }

            set
            {
                explaination = value;
            }
        }

        private string meaning;
        private string explaination;
    }
}
