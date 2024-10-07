using ProductInventoryManagementModel;
using PI_ManagementServices;
using MailKit.Net.Smtp;
using MimeKit;


namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<CrochetProducts> productsDB = SQLDbData.GetProducts();

            /*GetProducts getProducts = new GetProducts();

            var avail = getProducts.GetAllProducts();

            foreach (var product in avail)
            {
                Console.WriteLine(product.ID);
                Console.WriteLine(product.name);
                Console.WriteLine(product.productType);
                Console.WriteLine(product.availability);
                Console.WriteLine(product.description);
                Console.WriteLine(product.category);
                Console.WriteLine(product.material);
                Console.WriteLine(product.size);
            }*/


            /*var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Testing1", "do-not-reply@frommynotes.com"));
            message.To.Add(new MailboxAddress("User", "user@example.com"));
            message.Subject = "Thanks for suscribing!";

            message.Body = new TextPart("html")
            {
                Text = "<h1> Hi! Testing of Email version 2!</h1>" + "<p>Good Day! Thank so much for giving attention to this!</P>"
                    + "<p><strong>Have Fun!</strong></p>"
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
                }*/


            }
        }
    }

