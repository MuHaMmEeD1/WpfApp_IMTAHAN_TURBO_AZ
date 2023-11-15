using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp_IMTAHAN_TURBO_AZ.MyCommand;
using WpfApp_IMTAHAN_TURBO_AZ.View.Pages;
using WpfApp_IMTAHAN_TURBO_AZ.Models;
using System.Text.Json;
using System.IO;

namespace WpfApp_IMTAHAN_TURBO_AZ.ViewModels.Pages
{
    public class LoginViewModel
    {

        public RealeCommand LoginCommand { get; set; }
       

        public int randomSay { get; set; } = Random.Shared.Next(100000, 999999);

        

        public LoginViewModel() {

            LoginCommand = new RealeCommand(_LoginCommand, _CanLoginCommand);
           
           

        }




      

        public bool _CanLoginCommand(object? parameter)
        {
            LoginView page = (parameter as LoginView)!;


            if(page.Email.Text.Length != 0 && page.WAre.Text.Length != 0 ) { return true; }

            return false;

        }

        public void _LoginCommand(object? parameter) {

            LoginView page = (parameter as LoginView)!;

            bool yoxla = true;



            if (page.Email.Text.Length != 0 && page.WAre.Text.Length != 0 && page.VCode.Text == Convert.ToString(randomSay)) { 
            
                List<Client> clients = new List<Client>();

                clients = JsonSerializer.Deserialize<List<Client>>(File.ReadAllText("../../../DataBaseJson/clients.json"))!;
            


                if (clients.Count > 0) {

                    for (int i = 0; i < clients.Count; i++)
                    {
                        if (clients[i].Email == page.Email.Text) { 
                            clients[i].Nov = page.WAre.Text; 

                            File.WriteAllText("../../../DataBaseJson/index.json", JsonSerializer.Serialize(i)); 
                            break; 
                        }
                    }

                }
                else {  
                    
                    clients.Add(new Client() { Email = page.Email.Text , Nov = page.WAre.Text});
                    File.WriteAllText("../../../DataBaseJson/index.json", JsonSerializer.Serialize(clients.Count-1));
                    
                }


                File.WriteAllText("../../../DataBaseJson/clients.json", JsonSerializer.Serialize(clients, new JsonSerializerOptions() { WriteIndented = true }));

                page.NavigationService.GoBack();
            }

            else if (page.Email.Text.Length != 0 && page.Email.Text.Length > 10)
            {

                string email_ = "@gmail.com";

                for (int i = 0; i < email_.Length; i++)
                {
                    if (page.Email.Text[page.Email.Text.Length - (i + 1)] != email_[9 - i]) { yoxla = false; break; }
                }

                if(yoxla)
                {

                    GizliData gizliData = new GizliData();

                    gizliData = JsonSerializer.Deserialize<GizliData>(File.ReadAllText("../../../DataBaseJson/gizliData.json"))!;


                    string senderEmail = gizliData.Email!;
                    string senderPassword = gizliData.Code!;

                    string recipientEmail = $"{page.Email.Text}";

                    MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail);
                    mailMessage.Subject = "Email Notification";
                    mailMessage.Body = $"{randomSay}";


                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                    smtpClient.Port = gizliData.PortNum;
                    smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    smtpClient.EnableSsl = true;

                    smtpClient.Send(mailMessage);

                }

               

            }







        }


    }
}
