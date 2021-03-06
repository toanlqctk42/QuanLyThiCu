using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace NetLib
{
    [Serializable]
    public enum ServerResponseType
    {
        SendMonThi,
        SendThoiGianThi,
        SendPcName,
        SendMessage,
        SendDSCSDL,
        SendListStudentExcel,
        SendStudent,
        PhatDe,
        DisconnectAll,
        DisconnectDisable,
        BeginExam,
        FinishExam,
        LockClient,
        Undefined
    }

    [Serializable]
    public class ServerResponse
    {
        public ServerResponseType Type { get; private set; }
        public object Data { get; private set; }

        private ServerResponse()
        {
            Type = ServerResponseType.Undefined;
            Data = null;
        }

        public ServerResponse(ServerResponseType Type, object Data)
        {
            this.Type = Type;
            this.Data = Data;
        }

        public byte[] Serialize()
        {
            if (Type.HasFlag(ServerResponseType.Undefined))
                throw new Exception("Response is invalid");

            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, this);

            return stream.ToArray();
        }

        public static ServerResponse Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            object obj = formatter.Deserialize(stream);

            return obj as ServerResponse;
        }
    }
}
