using Project_ATM.Model;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using System.Configuration;

namespace Project_ATM
{
    
    public static class Global_Functions
    {
       static  ATMEntities db = new ATMEntities();
        
        private static string AddEmail = "wb.cctv@amrelisteels.com";
        private static string FromEmail = "system.notify@amrelisteels.com";
        private static string NotifyEmail = "system.notify@amrelisteels.com";
        private static string PassEmail = "ASL@1234566";
        private static string HostEmail = "mail.amrelisteels.com";
        private static int PortEmail = 25;

        static string macAddresses = Global_Functions.GetMac();
        public static System.Timers.Timer WeightTimer;

        

        public static void Exception_Log(string FormName, string MethodName, Exception ex)
        {
            try
            {
                bool ChkDB = false;
                ChkDB = Global_Variables.Check_DB;
                tbl_Exception_Logs exceptionlog = new tbl_Exception_Logs();
                exceptionlog.FormName = FormName;
                exceptionlog.MethodName = MethodName;
                exceptionlog.Date = DateTime.Now;
                exceptionlog.Time = DateTime.Now.TimeOfDay;
                exceptionlog.UserId = Global_Variables.LoginID;
                exceptionlog.SystemName = System.Environment.MachineName;
                exceptionlog.ErrorMessage = ex.Message;
                exceptionlog.ErrorStacktrace = ex.StackTrace;
                exceptionlog.Macaddress = macAddresses;
                if (ChkDB == true)
                {
                    try
                    {
                        db.tbl_Exception_Logs.Add(exceptionlog);
                        db.SaveChanges();
                        
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine("\nMessage ---\n{0}", exc.Message);
                    }
                }
               

            }
            catch (Exception exc)
            {
                Console.WriteLine("\nMessage ---\n{0}", exc.Message);
            }
        }

        public static void Event_Log(string FormName, string MethodName)
        {
            try
            {
                tbl_eventlog eventlog = new tbl_eventlog();
                eventlog.FormName = FormName;
                eventlog.Date = DateTime.Now;
                eventlog.Time = DateTime.Now.TimeOfDay;
                eventlog.UserID = Global_Variables.LoginID;
                eventlog.SystemName = System.Environment.MachineName;
                eventlog.MacAddress = macAddresses;
                eventlog.TransactionID = 0;
                db.tbl_eventlog.Add(eventlog);
                db.SaveChanges();
            }
            catch (Exception exc)
            {
                Console.WriteLine("\nMessage ---\n{0}", exc.Message);
            }
        }

        public static string GetMac()
        {
            string macAddresses = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.NetworkInterfaceType != NetworkInterfaceType.Ethernet) continue;
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return macAddresses;
        }
        public static string GetIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        
        public static string GetServerIP()
        {
            try
            {
                var connectionString = @ConfigurationManager.ConnectionStrings["WBEntities"].ConnectionString.Replace("metadata=res://*/Model.DBModel.csdl|res://*/Model.DBModel.ssdl|res://*/Model.DBModel.msl;provider=System.Data.SqlClient;provider connection string=", "").Replace("\"", "");
                string[] output = connectionString.Split(';');
                using (var connection = new SqlConnection(connectionString))
                {                    
                    return (output[0].Replace("data source=", ""));
                }
            }
            catch (Exception ex)
            {
                return ("Not Connected");
            }
        }

        public static void Sendemail(string subject, string body)
        {
            try
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.To.Add(AddEmail);
                mail.From = new MailAddress(FromEmail, "", System.Text.Encoding.UTF8);
                mail.Subject = subject;
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = body;
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential(NotifyEmail, PassEmail);
                client.Port = PortEmail;
                client.Host = HostEmail;
                client.EnableSsl = false;
                try
                {
                    client.Send(mail);
                }
                catch (Exception ex)
                {
                    Exception ex2 = ex;
                    string errorMessage = string.Empty;
                    while (ex2 != null)
                    {
                        errorMessage += ex2.ToString();
                        ex2 = ex2.InnerException;
                    }
                    Global_Functions.Exception_Log("Error on sending email", "Sendemail", ex);
                }
            }
            catch (Exception ee)
            {
                Global_Functions.Exception_Log("Error on sending email", "Sendemail", ee);
            }
        }
        public static bool IsServerConnected()
        {
            var connectionString = @ConfigurationManager.ConnectionStrings["ATMEntities"].ConnectionString.Replace("metadata=res://*/Model.DBModel.csdl|res://*/Model.DBModel.ssdl|res://*/Model.DBModel.msl;provider=System.Data.SqlClient;provider connection string=", "").Replace("\"", "");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException ex)
                {
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        
       

      
    }
}
