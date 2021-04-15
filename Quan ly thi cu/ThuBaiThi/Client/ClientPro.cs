using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections;
using NetLib;
using System.Windows.Forms;
using System.Diagnostics;
	
namespace Client
{

    public class ClientPro
    {
        Thread receiveThread;
        public Queue outQueue = new Queue();
        public Queue inQueue = new Queue();
        public Queue inCommandQueue = new Queue();

        public Queue CommandQueue = new Queue();

        IPEndPoint IP;
        Socket socket;
        string noiluu = null;

        public Action<List<Student>> NhanDSfileExcel;
        public Action<string> Message;
        public Action<string> exam;


        public void Connect(string TenServer, int port)
        {

           
            IP = new IPEndPoint(IPAddress.Parse(TenServer), port);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
           
            string desktop = System.Environment.MachineName;
            try
            {
                socket.Connect(IP);

                ServerResponse response = new ServerResponse(ServerResponseType.SendPcName, desktop);
                socket.Send(response.Serialize());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            receiveThread = new Thread(new ThreadStart(Receive));
            receiveThread.IsBackground = true;
            receiveThread.Start();
            
        }
        public void GoiBaiThiLenServer()
        {
            /*string rarPath = Environment.CurrentDirectory + "\\rar.exe";
            IPEndPoint ep = (IPEndPoint)client.Client.RemoteEndPoint;
            string ServerDir = @"\\" + ep.Address.ToString() + @"\" +  ServerPath+ "\\" + CurrDir;
            string clientpath = ClientPath + "\\" + CurrDir;
            string command = "a " + ServerDir + "  " + clientpath;
            Process.Start(rarPath, command);*/
            
        }

        public void Send(ServerResponse reponse)
        {
            try
            {
                socket.Send(reponse.Serialize());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
           
           /* while (true)
            {
                
                if (CommandQueue.Count > 0)
                {
                    string s = CommandQueue.Dequeue().ToString();
                    //MessageBox.Show(s);
                    sw.WriteLine(s);
                    sw.Flush();
                }
                Thread.Sleep(100);
            }*/

        }
        public void CloseConnection()
        {
            /*if (client != null) 
                client.Close();
*/
            if (socket != null)
            socket.Close();
        }
        public void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] buff = new byte[1024 * 1024 * 20];
                    socket.Receive(buff);
                    ServerResponse response = ServerResponse.Deserialize(buff);
                    switch (response.Type)
                    {
                        case ServerResponseType.SendListStudentExcel:
                            List<Student> students = response.Data as List<Student>;
                            NhanDSfileExcel(students);
                            break;
                        case ServerResponseType.SendStudent:
                            break;
                        case ServerResponseType.SendMessage:
                            string mess = response.Data.ToString();
                            Message(mess);
                            break;
                        case ServerResponseType.SendPcName:
                            break;
                        case ServerResponseType.DisconnectAll:
                            MessageBox.Show("Yêu cầu đóng kết nối từ server.");
                            CloseConnection();
                            break;
                        case ServerResponseType.PhatDe:
                            FileContainer file = response.Data as FileContainer;
                            string savepath = file.SavePath;
                            this.noiluu = file.SavePath;

                            if (Directory.Exists(savepath))
                                NetLib.DirectoryHelper.DeleteAllFileInDirectory(savepath);

                            Directory.CreateDirectory(savepath);

                            string filename = file.FileInfo.Name;

                            string fullpath = Path.Combine(savepath, filename);
                            byte[] filecontent = file.FileContent;

                            using (var fstream = File.Create(fullpath))
                            {
                                fstream.Write(filecontent, 0, filecontent.Length);
                            }
                            if (exam != null)
                                exam(fullpath);

                            break;
                        case ServerResponseType.BeginExam:
                            break;
                        case ServerResponseType.FinishExam:
                            if (string.IsNullOrWhiteSpace(this.noiluu))
                            {
                                break;
                            }

                            if (!Directory.Exists(this.noiluu))
                            {
                                Message("Chưa có nơi lưu bài thi ");
                                break;
                            }

                            List<string> sucessfile = new List<string>()
                        {
                            ".zip",
                            ".7z",
                            ".rar"
                        };

                            DirectoryInfo direc = new DirectoryInfo(this.noiluu);
                            FileInfo[] files = direc.GetFiles("*.*");
                            string baithi = null;
                            foreach (FileInfo item in files)
                            {
                                string filenames = item.Name;
                                string phanmorong = Path.GetExtension(filenames);
                                if (sucessfile.Contains(phanmorong))
                                {
                                    baithi = item.FullName;
                                    break;
                                }
                            }

                            if (string.IsNullOrWhiteSpace(baithi))
                            {
                                MessageBox.Show("Lỗi lưu bài , vui lòng xem lại nơi lưu");
                                break;
                            }
                            FileContainer noiluubai = new FileContainer(baithi, null);
                            ServerResponse repor = new ServerResponse(ServerResponseType.FinishExam, baithi);
                            try
                            {
                                if (repor == null)
                                    MessageBox.Show("Data Available!!!");//dữ liệu rỗng
                                socket.Send(response.Serialize());
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }

                            break;
                        case ServerResponseType.LockClient:
                            break;
                        case ServerResponseType.Undefined:
                            break;
                        case ServerResponseType.SendDSCSDL:
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            /*while (true)
            {

                string s = "";
                try
                {
                    s = sr.ReadLine();
                    inCommandQueue.Enqueue(s);
                   //MessageBox.Show("Nhan duoc phia client: " + s);
                }
                catch { }



                Thread.Sleep(100);
            }*/
        }
        public void SendInFoStudent(Student student)
        {
            ServerResponse response = new ServerResponse(ServerResponseType.SendStudent, student);
            try
            {
                if (response == null)
                    MessageBox.Show("Data Available!!!");//dữ liệu rỗng
                socket.Send(response.Serialize());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        public void InPut(string text)
        {
            outQueue.Enqueue(text);
            inQueue.Enqueue(text);

        }

        public void Close()
        {
            /*if (t != null)
                t.Abort();
            if (receiveThread != null)
                receiveThread.Abort();
            if (sendThread != null)
                sendThread.Abort();
            if (ns != null)
                ns.Close();
            if (sw != null)
                sw.Close();
            if (this.client != null)

                this.client.Close();*/
        }

        private bool KiemTraKhacNull(params object[] obs)
        {
            foreach (object ob in obs)
            {
                if (ob == null)
                    return false;
            }
            return true;
        }

        public void SendFinishSignal()
        {
            CommandQueue.Enqueue(NetCommand.CombineCommandParam(NetCommand.ClientFinish, Dns.GetHostName() ));
        }

    }
}
