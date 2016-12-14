using System;
using System.Drawing;
using EloBuddy;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Rendering;
using EloBuddy.SDK.Utils;
using SharpDX;

namespace AramBuddy
{
    internal class Program
    {
        private static string Msg = "AramBuddy Is no longer Maintained and supported\nTherefore it's removed and wont be uploaded or updated by me dnk\nHave fun using other botting software.";
        private static float textsize;
        private static Text text;

        private static void Main()
        {
            Loading.OnLoadingComplete += Loading_OnLoadingComplete;
        }

        private static void Loading_OnLoadingComplete(EventArgs args)
        {
            textsize = Drawing.Width <= 1280 || Drawing.Height <= 720 ? 10F : 40F;
            text = new Text("", new Font("Euphemia", textsize, FontStyle.Bold)) { Color = System.Drawing.Color.White, Position = new Vector2(Drawing.Width * 0.3f, Drawing.Height * 0.2f) };
            Drawing.OnEndScene += Drawing_OnEndScene;

            Logger.Error(Msg);
            Chat.Print(Msg);
        }
        
        private static void Drawing_OnEndScene(EventArgs args)
        {
            text.TextValue = Msg;
            text.Position = new Vector2(Drawing.Width * 0.3f, Drawing.Height * 0.2f);
            text.Draw();
        }
    }
}
