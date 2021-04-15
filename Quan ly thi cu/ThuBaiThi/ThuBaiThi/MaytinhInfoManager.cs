using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThuBaiThi
{
    [Serializable]
    class MaytinhInfoManager
    {
        private const string Default_IP = "0.0.0.0";
        private readonly List<Maytinhinfo> _maytinh;
        public List<Maytinhinfo> maytinh
        {
            get
            {
                return new List<Maytinhinfo>(_maytinh);
            }
        }
        public MaytinhInfoManager()
        {
            _maytinh = new List<Maytinhinfo>();
        }
        public MaytinhInfoManager(string FirstIP , string LastIP , string SubnetMask)
        {
            _maytinh = new List<Maytinhinfo>();
            try
            {
                string s1 = "", s2 = "";
                int y = 0, x = 0, z = 0, t = 0;
                if (FirstIP != "")
                {
                    s1 = FirstIP.Substring(0, FirstIP.LastIndexOf("."));
                    x = int.Parse(FirstIP.Substring(FirstIP.LastIndexOf(".") + 1));
                }
                if (LastIP != "")
                {
                    s2 = LastIP.Substring(0, LastIP.LastIndexOf("."));
                    y = int.Parse(LastIP.Substring(LastIP.LastIndexOf(".") + 1));
                }
                t = y - x;
                if (SubnetMask != "")
                    z = 256 - int.Parse(SubnetMask.Substring(SubnetMask.LastIndexOf(".") + 1));
                if (x < 255 && y < 255 && s1.CompareTo(s2) == 0)
                {
                    for (int i = x; i < z && i <=y; i++)
                    {
                        string ip = s1 + "." + i.ToString();
                        Maytinhinfo maytinhinfo = new Maytinhinfo();
                        maytinhinfo.ClientIP = ip;
                        _maytinh.Add(maytinhinfo);
                    }
                }
                else
                    MessageBox.Show("Nhập sai IP");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void Add(Maytinhinfo client)
        {
            int? index = IndexOf(client);
            if (index != null)
            {
                _maytinh[(int)index] = client;
                return;
            }
            AddTail(client);
        }
        
        void AddTail(Maytinhinfo client)
        {
            _maytinh.Add(client);
        }
        public int? IndexOf(Maytinhinfo client)
        {
            for (int i = 0; i < _maytinh.Count; i++)
            {
                if (_maytinh[i].ClientIP.Equals(client.ClientIP))
                    return i;
            }

            return null;
        }
        public void DisconnectAll()
        {
            foreach (Maytinhinfo item in _maytinh)
            {
                if (item.status != ClientinfoStatus.Disconnected)
                    item.status = ClientinfoStatus.Disconnected;
            }
        }
        public Maytinhinfo Find(string ipAddress)
        {
            for (int i = 0; i < _maytinh.Count; i++)
            {
                if (_maytinh[i].ClientIP.Equals(ipAddress))
                    return _maytinh[i];
            }

            return null;
        }
        public void DisconnectDisable()
        {
            foreach (Maytinhinfo item in maytinh)
            {
                if (item.status != ClientinfoStatus.Undefine)
                    item.status = ClientinfoStatus.Disconnected;
            }        
        }

    }
}
