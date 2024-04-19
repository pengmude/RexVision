using System;

namespace DMSkin.Socket
{
    [Serializable]
    public class ResponeTraFransfersFile
    {
        public ResponeTraFransfersFile()
        {
        }
        public ResponeTraFransfersFile(string md5, int size, int index)
        {
            this._MD5 = md5;
            this._Size = size;
            this._Index = index;
        }

        public string MD5
        {
            get
            {
                return this._MD5;
            }
            set
            {
                this._MD5 = value;
            }
        }
        public int Size
        {
            get
            {
                return this._Size;
            }
            set
            {
                this._Size = value;
            }
        }
        public int Index
        {
            get
            {
                return this._Index;
            }
            set
            {
                this._Index = value;
            }
        }

        private string _MD5;
        private int _Size;
        private int _Index;
    }
}
