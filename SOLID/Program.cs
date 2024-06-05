using SOLID.DIP;
using SOLID.ISP;
using SOLID.LCP;
using SOLID.OCP;
using SOLID.SRP;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Single Responsible Principle

        var order = new Order { OrderId = 1 };
        order.AddItem(new OrderItem { Name = "Item 1", Quantity = 2, Price = 10.00m });
        order.AddItem(new OrderItem { Name = "Item 2", Quantity = 1, Price = 20.00m });

        var calculator = new OrderCalculator();
        var total = calculator.CalculateTotal(order);

        var receiptGenerator = new ReceiptGenerator();
        var receipt = receiptGenerator.GenerateReceipt(order, total);

        Console.WriteLine(receipt);

        #endregion

        #region Open Closed Principle - OCP

        IPaymentMethod creditCardPayment = new CreditCardPayment();
        var creditCardProcessor = new PaymentProcessor(creditCardPayment);
        creditCardProcessor.ProcessPayment(100.00m);

        IPaymentMethod payPalPayment = new PayPalPayment();
        var payPalProcessor = new PaymentProcessor(payPalPayment);
        payPalProcessor.ProcessPayment(200.00m);

        #endregion 

        #region Liskov Substitution Principle

        List<Shape> shapes = new List<Shape>
        {
            new Rectangle(5, 10),
            new Square(7)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"The area is: {shape.CalculateArea()}");
        }

        #endregion

        #region Interface Segregation Principle

        IPdfReport pdfReport = new PdfReport();
        pdfReport.Generate();
        pdfReport.ExportToPdf();

        IExcelReport excelReport = new ExcelReport();
        excelReport.Generate();
        excelReport.ExportToExcel();

        #endregion

        #region Dependency Inversion Principle

        INotificationService emailService = new EmailNotificationService();
        NotificationSender emailSender = new NotificationSender(emailService);
        emailSender.SendNotification("Hello via Email!");

        INotificationService smsService = new SmsNotificationService();
        NotificationSender smsSender = new NotificationSender(smsService);
        smsSender.SendNotification("Hello via SMS!");

        #endregion
    }
}