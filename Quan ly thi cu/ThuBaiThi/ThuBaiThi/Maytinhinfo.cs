using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using NetLib;
namespace ThuBaiThi
{
    public class Maytinhinfo
    {
        public string PCName { get; set; }
        public Student student { get; set; }
        public IPEndPoint endPoint { get; set; }
        public string ClientIP { get; set; }
        public ClientinfoStatus status { get; set; }
        public Maytinhinfo()
        {
            student = new Student();
            endPoint = new IPEndPoint(IPAddress.Any, 0);
            status = ClientinfoStatus.Undefine;
        }

        public Maytinhinfo(Maytinhinfo client)
        {
            PCName = client.PCName;
            student = client.student;
            endPoint = client.endPoint;
            ClientIP = client.ClientIP;
            status = client.status;
        }

       

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Maytinhinfo client = obj as Maytinhinfo;

            return client.ClientIP == ClientIP && client.PCName == PCName && client.status == status && client.student.MSSV == student.MSSV;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    [Serializable]
    public enum ClientinfoStatus
    {
        Undefine,
        ClientConnected,
        StudentConnected,
        Disconnected
    }
}
