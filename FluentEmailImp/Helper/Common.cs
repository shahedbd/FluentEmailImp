namespace FluentEmailImp.Helper
{
    public static class Common
    {
        public static string GetTestEmailBody()
        {
            string EmailBody = "Subject: Test Email \n \n"
                + " Dear [Recipient's Name], \n"
                + " I hope this email finds you well. This is a test email to ensure that our communication channels are working smoothly. Please confirm receipt by replying to this email at your earliest convenience. \n \n"
                + " If you encounter any issues or have any feedback regarding the email delivery or content, please let me know. Your input is valuable in ensuring the efficiency of our communication system. \n"
                + " Thank you for your cooperation. \n \n"
                + " Best regards, \n"
                + " [Your Name] \n"
                + " [Your Position] \n"
                + " [Your Company] \n"
                + " [Your Contact Information] \n";
            return EmailBody;
        }
    }
}
