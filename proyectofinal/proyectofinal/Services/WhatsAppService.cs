namespace proyectofinal.Services
{
    public class WhatsAppService
    {
        private readonly HttpClient _http;
        private readonly string _token;
        private readonly string _phoneNumberId;

        public WhatsAppService(IConfiguration config)
        {
            _http = new HttpClient();
            _token = config["WhatsApp:AccessToken"] ?? "";
            _phoneNumberId = config["WhatsApp:PhoneNumberId"] ?? "";
        }

        public async Task<HttpResponseMessage> SendTextAsync(string to, string message)
        {
            var url = $"https://graph.facebook.com/v17.0/{_phoneNumberId}/messages";

            var payload = new
            {
                messaging_product = "whatsapp",
                to = to,
                type = "text",
                text = new { body = message }
            };

            var req = new HttpRequestMessage(HttpMethod.Post, url);
            req.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _token);
            req.Content = JsonContent.Create(payload);

            return await _http.SendAsync(req);
        }
    }
}