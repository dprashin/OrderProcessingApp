namespace OrderProcessingApp.Email {
    public interface IEmailSender {
        string SendEmail(string message);
    }
}