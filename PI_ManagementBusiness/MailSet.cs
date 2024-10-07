using MimeKit;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductInventoryManagementModel;


namespace PI_ManagementServices
{
    public class MailSet
    {
        SQLDbData uwu = new SQLDbData();

        public void MailSet1()
        {
            //GetProducts uwu = new GetProducts();
            //ProductsServices uwu = new ProductsServices();

            //SQLDbData uwu = new SQLDbData();

            bool mailSent = true;

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("CrochetProduce", "do-not-reply@eumoirouscro.com"));
            message.To.Add(new MailboxAddress("Edzel", "userEdzel@gmail.com"));
            message.Subject = "New Product Added!";

            message.Body = new TextPart("html")
            {
                Text = "<h1> Good day! New product is added.</h1>" + "<br>" + "<p>Products are successfully created in eumoirous</p>"
            };


            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect("sandbox.smtp.mailtrap.io", 2525, MailKit.Security.SecureSocketOptions.StartTls);

                    client.Authenticate("690f318e2d42da", "6725be2123c229");

                    client.Send(message);
                    //mailSent = true;

                    Console.WriteLine("Email successfully sent through MailTrap.");
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error sending email: (ex.Message)");
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
            //return mailSent;
        }

        public void MailSet2()
        {

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("CrochetProduce", "do-not-reply@eumoirouscro.com"));
            message.To.Add(new MailboxAddress("Edzel", "userEdzel@gmail.com"));
            message.Subject = "A product is updated!";

            message.Body = new TextPart("html")
            {
                Text = "<h1>Product is successfully updated in your shop!</h1>" + "<br>" + "<p> The product you have updated is successfully stored.</p>"
            };

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect("sandbox.smtp.mailtrap.io", 2525, MailKit.Security.SecureSocketOptions.StartTls);

                    client.Authenticate("690f318e2d42da", "6725be2123c229");

                    client.Send(message);

                    Console.WriteLine("Email successfully sent through MailTrap.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error sending email: (ex.Message)");
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
            


        }

        /*public class MailSet2
        {
            SQLDbData uwu = new SQLDbData();

            public MailSet2()
            {
                //GetProducts uwu = new GetProducts();
                //ProductsServices uwu = new ProductsServices();

                //SQLDbData uwu = new SQLDbData();

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("CrochetProduce", "do-not-reply@eumoirouscro.com"));
                message.To.Add(new MailboxAddress("Edzel", "userEdzel@gmail.com"));
                message.Subject = "A product is updated!";

                message.Body = new TextPart("html")
                {
                    Text = "<h1>Product is successfully updated in your shop!</h1>" + "<br>" + uwu.GetProducts() + "<p> The product you have updated is successfully stored.</p>"
                };

                using (var client = new SmtpClient())
                {
                    try
                    {
                        client.Connect("sandbox.smtp.mailtrap.io", 2525, MailKit.Security.SecureSocketOptions.StartTls);

                        client.Authenticate("690f318e2d42da", "6725be2123c229");

                        client.Send(message);

                        Console.WriteLine("Email successfully sent through MailTrap.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error sending email: (ex.Message)");
                    }
                    finally
                    {
                        client.Disconnect(true);
                    }
                }*/

    }
}
    



