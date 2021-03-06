using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections;
using MayTinh;
using NetLib;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;		

namespace ThuBaiThi
{
    class ServerThread
    {
        public List<Socket> ListClient;
        public TcpListener listener;
        private const int Buffersize = 1024 * 1024 * 20;
        private const int port = 1605;
        public Queue InQueue = new Queue();
        public Queue OutQueue = new Queue();
        public Queue CommandQueue = new Queue();
        public Queue inCommandQueue = new Queue();
        

        Thread mainThread;
        Thread receiveCommand;

        MaytinhInfoManager maytinhInfoManager;
        Socket socket;
        string clientpath = null;
        string serverpath = null;


        event Action<List<Maytinhinfo>> _onClientListChanged;
        public event Action<List<Maytinhinfo>> OnClientListChanged
        {
            add
            {
                _onClientListChanged += value;
            }
            remove
            {
                _onClientListChanged -= value;
            }
        }
        public ServerThread()
        {
            maytinhInfoManager = new MaytinhInfoManager();
            listener = new TcpListener(IPAddress.Any,port);
            ListClient = new List<Socket>();
            socket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            
        }
        public void Start()
        {
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            OutQueue.Enqueue("Dang cho ket noi den...");

            mainThread = new Thread(new ThreadStart(Tam));
            mainThread.IsBackground = true;
            mainThread.Start();

            IPEndPoint serverIP = null;

            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    serverIP = new IPEndPoint(ip, port);
                    break;
                }
            }

        }

        public void ReceiveCommand(object obj)
        {
            Socket client = obj as Socket;
            string ClientIP = client.RemoteEndPoint.ToString().Split(':')[0];
            Maytinhinfo maytinhinfo = maytinhInfoManager.Find(ClientIP);
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[Buffersize];
                    client.Receive(buffer);
                    ServerResponse response = ServerResponse.Deserialize(buffer);
                    switch (response.Type)
                    {
                        
                        case ServerResponseType.SendDSCSDL:
                            break;
                        case ServerResponseType.SendListStudentExcel:
                            break;
                        case ServerResponseType.SendStudent:
                            Student student = response.Data as Student;
                            maytinhinfo.student = student;
                            maytinhinfo.status = ClientinfoStatus.StudentConnected;
                            if (_onClientListChanged != null)
                                _onClientListChanged(maytinhInfoManager.maytinh);
                            break;
                        case ServerResponseType.SendMessage:
                            break;
                        case ServerResponseType.SendPcName:
                            string pcname = response.Data as string;
                            maytinhinfo.PCName = pcname;
                            maytinhinfo.status = ClientinfoStatus.ClientConnected;
                            if (_onClientListChanged != null)
                                _onClientListChanged(maytinhInfoManager.maytinh);
                            break;
                        case ServerResponseType.DisconnectAll:
                           
                            break;
                        case ServerResponseType.BeginExam:
                            break;
                        case ServerResponseType.FinishExam:
                            FileContainer savefilebaithi = response.Data as FileContainer;
                            string savepath = this.serverpath;
                            if (!Directory.Exists(savepath))
                                Directory.CreateDirectory(savepath);

                            string fileName = savefilebaithi.FileInfo.Name;
                            string fullPath = Path.Combine(savepath, fileName);

                            byte[] fileContent = savefilebaithi.FileContent;

                            using (var fileStream = File.Create(fullPath))
                                fileStream.Write(fileContent, 0, fileContent.Length);
                            
                            break;
                        case ServerResponseType.LockClient:
                            break;
                        case ServerResponseType.Undefined:
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {

               maytinhinfo.status = ClientinfoStatus.Disconnected;

                if (_onClientListChanged != null)
                    _onClientListChanged(maytinhInfoManager.maytinh);

                ListClient.Remove(client);
                client.Close();
            }

        }

        public void DisconnectAll()
        {
            foreach (Socket item in ListClient)
            {
                ServerResponse response = new ServerResponse(ServerResponseType.DisconnectAll, null);
                item.Send(response.Serialize());
            }

            ListClient.Clear();
            maytinhInfoManager.DisconnectAll();
        }

        public void Close()
        {
            
            if (socket != null) 
                socket.Close();
            listener.Stop();
           
        }
        public void DisconnectDisable(frmmaytinh frm)
        {
            if(frm.maytinhinfo.status == ClientinfoStatus.Undefine)
            {
                frm.maytinhinfo.status = ClientinfoStatus.Disconnected;

            }

        }

       

        public void Tam()
        {
            while (true)
            {
                while (!listener.Pending())
                {
                    Thread.Sleep(1000);
                }
                Socket clientToHandle = listener.AcceptSocket();
                ListClient.Add(clientToHandle);
                string IP = clientToHandle.RemoteEndPoint.ToString().Split(':')[0];
                Maytinhinfo newmaytinh = new Maytinhinfo()
                {
                    endPoint = clientToHandle.RemoteEndPoint as IPEndPoint,
                    ClientIP = IP,
                    status = ClientinfoStatus.ClientConnected,
                    student = new Student()
                    
                };
               
                maytinhInfoManager.Add(newmaytinh);
                if (_onClientListChanged != null)
                    _onClientListChanged(maytinhInfoManager.maytinh);
                receiveCommand = new Thread(ReceiveCommand);
                receiveCommand.IsBackground = true;
                receiveCommand.Start(clientToHandle);
            }
        }

    
        public void SetClienttoList(string FirstIP, string LastIP, string SubnetMask)
        {
            maytinhInfoManager = new MaytinhInfoManager(FirstIP, LastIP, SubnetMask);
            if (_onClientListChanged != null)
                _onClientListChanged(maytinhInfoManager.maytinh);   
        }
        
        public void HandleConnection()
        {

            TcpListener threadListener = listener;
            Socket clientToHandle = listener.AcceptSocket();
            ListClient.Add(clientToHandle);

            IPEndPoint remoteEP = (IPEndPoint) clientToHandle.RemoteEndPoint;
            string IP = remoteEP.Address.ToString();
         
            clientToHandle.Close();

        }
        public void SendmessageAll(string mess)
        {
            ServerResponse response = new ServerResponse(ServerResponseType.SendMessage, mess);
            byte[] buff = response.Serialize();
            foreach (Socket item in ListClient)
            {
                item.Send(buff);
            }
            
        }
        public void SendMonThi(string monthi)
        {
            ServerResponse response = new ServerResponse(ServerResponseType.SendMonThi, monthi);
            byte[] buff = response.Serialize();
            foreach (Socket item in ListClient)
            {
                item.Send(buff);
            }
        }
        public void SendThoiGianThi(string timeexam)
        {
            ServerResponse response = new ServerResponse(ServerResponseType.SendThoiGianThi, timeexam);
            byte[] buff = response.Serialize();
            foreach (Socket item in ListClient)
            {
                item.Send(buff);
            }
        }
        public void StartExam(string time)
        {
            ServerResponse response = new ServerResponse(ServerResponseType.BeginExam, time);
            byte[] buff = response.Serialize();
            foreach (Socket item in ListClient)
            {
                item.Send(buff);
            }
        }
        public void SetClientPath(string Clientpath)
        {
            this.clientpath = Clientpath;
        }
        public void SetServerPath(string Serverpath)
        {
            this.serverpath = Serverpath;
        }

        public void SendListStudent(List<Student> students)
        {
            ServerResponse response = new ServerResponse(ServerResponseType.SendListStudentExcel, students);
            byte[] buff = response.Serialize();
            foreach (Socket item in ListClient)
            {
                item.Send(buff);
            }
        }
        public void PhatDe(List<string> dsDeThi)
        {
            if (dsDeThi.Count == 0)
                return;

            List<FileContainer> listfiledetai = new List<FileContainer>();
            foreach (string item in dsDeThi)
            {
                listfiledetai.Add(new FileContainer(item, this.clientpath));
            }

            if(dsDeThi.Count == 1)
            {
                FileContainer dethi = listfiledetai[0];
                foreach (Socket clientsock in ListClient)
                {
                    ServerResponse response = new ServerResponse(ServerResponseType.PhatDe, dethi);
                    clientsock.Send(response.Serialize());
                }
            }

            if(dsDeThi.Count > 1)
            {
                int soluongde = dsDeThi.Count;
                int detruoc = 0;
                int desau = 0;
                foreach (Socket item in ListClient)
                {
                    do
                    {
                        Random rd = new Random();
                        desau = rd.Next(0, soluongde);
                    } while (detruoc == desau);
                    detruoc = desau;
                    FileContainer dethi = listfiledetai[desau];
                    ServerResponse response = new ServerResponse(ServerResponseType.PhatDe, dethi);
                    item.Send(response.Serialize());
                }
            }
        }
        public void Thubai()
        {
            ServerResponse response = new ServerResponse(ServerResponseType.FinishExam, null);
            foreach (Socket item in ListClient)
            {
                item.Send(response.Serialize());
            }
        }
        public void Undefine(frmmaytinh frm)
        {
            if (frm.maytinhinfo.status != ClientinfoStatus.Undefine)
            {
                frm.maytinhinfo.status = ClientinfoStatus.Undefine;

            }
        }
    }
}
