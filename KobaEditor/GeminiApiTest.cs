using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GenerativeAI;
using GenerativeAI.Tools;
using GenerativeAI.Models;

namespace GeminiAPI_test
{
    class GeminiApiTest
    {
        private static string ApiKey;  // あなたのAPIキーをここに記入

        public static async Task Execute()
        {
            ApiKey = Environment.GetEnvironmentVariable("GeminiApiKey", EnvironmentVariableTarget.User);

            // APIクライアントの初期化
            var model = new GenerativeModel(ApiKey);

            // APIリクエストを送信
            try
            {
                var response = await model.GenerateContentAsync("How are you?");

                // レスポンスを表示
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"リクエストエラー: {ex.Message}");
            }
        }
    }
}
