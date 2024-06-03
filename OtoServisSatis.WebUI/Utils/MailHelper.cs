﻿using OtoServisSatis.Entities;
using System.Net;
using System.Net.Mail;

namespace OtoServisSatis.WebUI.Utils
{
    public class MailHelper
    {
        public static async Task SendMailAsync(Musteri musteri)
        {
            SmtpClient smtpClient = new SmtpClient("mail.sideadresi.com", 587);
            smtpClient.Credentials = new NetworkCredential("eren18tarhan@gmail.com", "emailşifre");
            smtpClient.EnableSsl = false;
            MailMessage message = new MailMessage();
            message.From = new MailAddress("eren18tarhan@gmail.com");
            message.To.Add("eren18tarhan@gmail.com");
            message.Subject = "Siteden Mesaj Geldi";
            message.Body = $"Mail Bilgileri <hr/> Ad Soyad : {musteri.Adi},{musteri.Soyadi} <hr/> " +
                $"ilgilendiği Araç Id  :{musteri.AracId} <hr/>  Email :{musteri.Email}  < hr /> Telefon :{ musteri.Telefon} " +
                $"< hr /> Notlar :{musteri.Notlar}";
            message.IsBodyHtml = true;
            //smtpClient.Send(message);
            await smtpClient.SendMailAsync(message);
            smtpClient.Dispose();
        }
    }
}
