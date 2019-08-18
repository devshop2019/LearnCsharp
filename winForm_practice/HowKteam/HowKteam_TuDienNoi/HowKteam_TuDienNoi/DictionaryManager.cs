using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HowKteam_TuDienNoi
{
    public class DictionaryManager
    {
        #region Properties
        private DictionaryItem items;

        public DictionaryItem Items
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

        public string FilePath
        {
            get
            {
                return filePath;
            }

            set
            {
                filePath = value;
            }
        }

        private string filePath;

        #endregion

        #region Methods
        public DictionaryManager()
        {
            filePath = "data.xml";
            //items = new DictionaryItem();

            items = (DictionaryItem)DeserializeFromXML(filePath);
        }

        public void LoadDataToCombobox(ComboBox combo)
        {
            combo.DataSource = items.Items;
        }

        public void Serialize()
        {
            SerializeToXML(Items,filePath);
        }

        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));

            sr.Serialize(fs, data);

            fs.Close();

        }

        public object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath,FileMode.OpenOrCreate,FileAccess.ReadWrite);
            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));

            object obj = sr.Deserialize(fs);

            fs.Close();

            return obj;
        }

        #endregion
    }
}
