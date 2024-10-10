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
        //SQLDbData uwu = new SQLDbData();
        public void EmailNotification(string htmlBod, string emailSub)
        {
            //GetProducts uwu = new GetProducts();
            //ProductsServices uwu = new ProductsServices();

            //SQLDbData uwu = new SQLDbData();

            //bool mailSent = true;

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("CrochetProduce", "do-not-reply@eumoirouscro.com"));
            message.To.Add(new MailboxAddress("Edzel", "userEdzel@gmail.com"));
            //message.Subject = "New Product Added!";
            message.Subject = emailSub;

            message.Body = new TextPart("html")
            {
                //Text = "<h1> Good day! New product is added.</h1>" + "<br>" + "<p>Products are successfully created in eumoirous</p>"
                Text = htmlBod
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


        public void addedProduct(string name)
        {
            string emailSub = "Eumoirous, a new product ADDED!";
            string htmlBod = "<h1>Product is successfully uploaded in your shop!</h1>" + "<br>"
                + "<p> The product you have updated is successfully stored.</p>";

            EmailNotification(htmlBod, emailSub);

        }

        public void updateProduct(string name)
        {
            string emailSub = "Eumoirous Product Updated";
            string htmlBod = "<h1>Product is successfully updated in your shop!</h1>" + "<br>"
                + "<p> The product you have updated is successfully stored.</p>";

            EmailNotification(htmlBod, emailSub);

        }

        public void deleteProduct(string ID)
        {
            string emailSub = "Eumoirous Product Deleted";
            string htmlBod = "<h1>Product is successfully deleted.</h1>" + "<br>"
                + "<p> The product you have deleted is successfully stored.</p>";

            EmailNotification(htmlBod, emailSub);

        }

        //public class messages()
        //{
        //    public bool updateMessageMail(CrochetProducts crochetProducts, string ID, string name)
        //    {

        //        var addMessage = new MimeMessage();
        //        addMessage.From.Add(new MailboxAddress("CrochetProduce", "do-not-reply@eumoirouscro.com"));
        //        addMessage.To.Add(new MailboxAddress("Edzel", "userEdzel@gmail.com"));
        //        addMessage.Subject = "A product is updated!";

        //        addMessage.Body = new TextPart("html")
        //        {
        //            Text = "<h1>Product is successfully updated in your shop!</h1>" + "<br>"
        //            + $"<p>Product ID: {crochetProducts.name}</p>" 
        //            + "<p> The product you have updated is successfully stored.</p>"
        //        };

        //        return updateMessageMail(crochetProducts, ID, name);
        //    }
        //}

        //public class MailSet2
        //{
        //    SQLDbData uwu = new SQLDbData();

        //    public MailSet2()
        //    {
        //        //GetProducts uwu = new GetProducts();
        //        //ProductsServices uwu = new ProductsServices();

        //        //SQLDbData uwu = new SQLDbData();

        //        var message = new MimeMessage();
        //        message.From.Add(new MailboxAddress("CrochetProduce", "do-not-reply@eumoirouscro.com"));
        //        message.To.Add(new MailboxAddress("Edzel", "userEdzel@gmail.com"));
        //        message.Subject = "A product is updated!";

        //        message.Body = new TextPart("html")
        //        {
        //            Text = "<h1>Product is successfully updated in your shop!</h1>" + "<br>" + uwu.GetProducts() + "<p> The product you have updated is successfully stored.</p>"
        //        };

        //        using (var client = new SmtpClient())
        //        {
        //            try
        //            {
        //                client.Connect("sandbox.smtp.mailtrap.io", 2525, MailKit.Security.SecureSocketOptions.StartTls);

        //                client.Authenticate("690f318e2d42da", "6725be2123c229");

        //                client.Send(message);

        //                Console.WriteLine("Email successfully sent through MailTrap.");
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine("Error sending email: (ex.Message)");
        //            }
        //            finally
        //            {
        //                client.Disconnect(true);
        //            }
        //        }
        //    }
    }
}

    



