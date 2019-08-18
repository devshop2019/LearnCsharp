using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lưu ý: Class dùng để ghi vào file không nên có Constructor nếu có thì không được có Param.

namespace HowKteam_TuDienNoi
{
    [Serializable]                  // Thêm Artribute Có thể serialize 
    public class DictionaryItem         // Dùng để lưu danh sách
    {
        private List<DictionaryData> items;

        public List<DictionaryData> Items
        {
            get
            {
                return items;
            }

            set
            {
                items = value;
            }
        }
    }
}
