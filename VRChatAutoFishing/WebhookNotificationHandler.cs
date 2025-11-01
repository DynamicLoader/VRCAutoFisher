using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace VRChatAutoFishing
{
    public class WebhookNotificationHandler : INotificationHandler
    {
        private readonly string _webhookUrl;
        private readonly string _template;

        public WebhookNotificationHandler(string webhookUrl, string template)
        {
            if (string.IsNullOrWhiteSpace(webhookUrl))
                throw new ArgumentException("Webhook URL 不能为空", nameof(webhookUrl));

            _webhookUrl = webhookUrl;
            _template = template;
        }


        public async Task<NotifyResult> NotifyAsync(string message)
        {
            try
            {
                using var client = new HttpClient();
                string payload = _template.Replace("{{message}}", message);
                var content = new StringContent(payload, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(_webhookUrl, content);
                if (!response.IsSuccessStatusCode)
                {
                    return new(false, $"Webhook 通知失败: {response.StatusCode}, Body: {response.Content}");
                }
                return new(true, response.Content.ToString() ?? "");
            }
            catch (Exception ex)
            {
                return new(false, $"Webhook 通知错误: {ex.Message}");
            }
        }
    }
}